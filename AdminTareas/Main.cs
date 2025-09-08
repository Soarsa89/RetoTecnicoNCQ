using AdminTareas.Datos.Context;
using AdminTareas.Datos.Persistences.Interfaces;
using AdminTareas.Datos.Persistences.Repositories;
using AdminTareas.Modelos.Entidades;
using AdminTareas.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Microsoft.EntityFrameworkCore;

namespace AdminTareas
{
    public partial class Main : Form
    {
        private readonly TareaViewModel _tareaViewModel;
        private readonly EstadoTareaViewModel _estadoTareaViewModel;
        private readonly PrioridadTareaViewModel _prioridadTareaViewModel;
        private bool _modoEdicion = false; 
        private int _tareaEnEdicionId = 0; 

        public Main()
        {
            InitializeComponent();

            gridView1.OptionsView.RowAutoHeight = true;
          
            var optionsBuilder = new DbContextOptionsBuilder<AdminTareaContext>();
            var dbContext = new AdminTareaContext(optionsBuilder.Options);

            ITareaRepository tarea = new TareaRepository(dbContext);
            IEstadoTareaRespository estadoTarea = new EstadoTareaRepository(dbContext);
            IPrioridadTareaRepository prioridadTarea = new PrioridadTareaRepository(dbContext);

            _estadoTareaViewModel = new EstadoTareaViewModel(estadoTarea);
            _prioridadTareaViewModel = new PrioridadTareaViewModel(prioridadTarea);

            lookUpEdit1.Properties.DataSource = _estadoTareaViewModel.EstadoTarea;
            lookUpEdit1.Properties.DisplayMember = "Nombre";
            lookUpEdit1.Properties.ValueMember = "Nombre";
            lookUpEdit1.Properties.NullText = "Seleccione un estado";

            lookUpEditPrioridad.Properties.DataSource = _prioridadTareaViewModel.PrioridadTareas;
            lookUpEditPrioridad.Properties.DisplayMember = "Nombre";
            lookUpEditPrioridad.Properties.ValueMember = "Nombre";
            lookUpEditPrioridad.Properties.NullText = "Seleccione la prioridad";

            _tareaViewModel = new TareaViewModel(tarea);
            _tareaViewModel.FechaCompromiso = DateTime.Now.Date;

            txtDescricion.DataBindings.Add("Text", _tareaViewModel, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
            lookUpEdit1.DataBindings.Add("EditValue", _tareaViewModel, "Estado", true, DataSourceUpdateMode.OnPropertyChanged);
            lookUpEditPrioridad.DataBindings.Add("EditValue", _tareaViewModel, "Prioridad", true, DataSourceUpdateMode.OnPropertyChanged);
            fechaCompromiso.DataBindings.Add("EditValue", _tareaViewModel, "FechaCompromiso", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNotas.DataBindings.Add("Text", _tareaViewModel, "Notas", true, DataSourceUpdateMode.OnPropertyChanged);

            
            ConfigurarBotonGuardar();

           
            dgvTareas.DataSource = _tareaViewModel.Tareas;

            _tareaViewModel.CargarTareasCommand.Execute(null);
            _estadoTareaViewModel!.CargarEstadoTareaCommand.Execute(null);
            _prioridadTareaViewModel!.CargarPriroridaTareaCommand.Execute(null);

         
            RepositoryItemButtonEdit btnEditar = new RepositoryItemButtonEdit();
            btnEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnEditar.Buttons[0].Caption = "Editar";
            btnEditar.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            btnEditar.ButtonClick += editarTarea;

            RepositoryItemButtonEdit btnEliminar = new RepositoryItemButtonEdit();
            btnEliminar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnEliminar.Buttons[0].Caption = "Eliminar";
            btnEliminar.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete;
            btnEliminar.ButtonClick += eliminarTarea;

           
            dgvTareas.RepositoryItems.Add(btnEditar);
            dgvTareas.RepositoryItems.Add(btnEliminar);

         
            if (gridView1.Columns["Editar"] == null)
            {
                var colEditar = gridView1.Columns.AddVisible("Editar", "Editar");
                colEditar.ColumnEdit = btnEditar;
            }

            if (gridView1.Columns["Eliminar"] == null)
            {
                var colEliminar = gridView1.Columns.AddVisible("Eliminar", "Eliminar");
                colEliminar.ColumnEdit = btnEliminar;
            }
        }

        #region Métodos para manejar el botón Guardar/Actualizar

        
        private void ConfigurarBotonGuardar()
        {
            _modoEdicion = false;
            _tareaEnEdicionId = 0;
            btn_guardar.Text = "Guardar";
            btn_guardar.Click -= ActualizarTarea; 
            btn_guardar.Click += CrearTarea; 
        }        
        private void ConfigurarBotonActualizar(int tareaId)
        {
            _modoEdicion = true;
            _tareaEnEdicionId = tareaId;
            btn_guardar.Text = "Actualizar";
            btn_guardar.Click -= CrearTarea; 
            btn_guardar.Click += ActualizarTarea; 
        }
        #endregion
        
        private void CrearTarea(object? sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario())
                    return;

                var estadoSeleccionado = lookUpEdit1.GetSelectedDataRow() as EstadoTarea;
                var prioridadSeleccionada = lookUpEditPrioridad.GetSelectedDataRow() as PrioridadTarea;

              
                _tareaViewModel.Id = 0; 
                _tareaViewModel.Estado = estadoSeleccionado?.Nombre!;
                _tareaViewModel.Prioridad = prioridadSeleccionada?.Nombre!;

                if (_tareaViewModel.GuardarCommand.CanExecute(null))
                {
                    _tareaViewModel.GuardarCommand.Execute(null);

                    XtraMessageBox.Show("Tarea creada correctamente!",
                     "Éxito",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);

                    // Recargar la tabla
                    _tareaViewModel.CargarTareasCommand.Execute(null);

                    // Limpiar formulario 
                    _tareaViewModel.LimpiarDatos();
                }
                else
                {
                    XtraMessageBox.Show("El formulario no es válido o no se pudo guardar la tarea.",
                       "Validación",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al crear la tarea: " + ex.Message,
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }    
        private void ActualizarTarea(object? sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario() )
                    return;

                var estadoSeleccionado = lookUpEdit1.GetSelectedDataRow() as EstadoTarea;
                var prioridadSeleccionada = lookUpEditPrioridad.GetSelectedDataRow() as PrioridadTarea;

                if (estadoSeleccionado!.Nombre == "FINALIZADA") 
                {
                    XtraMessageBox.Show("No se pudo actualizar una tarea finalizada.",
                       "",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    return;
                }

                _tareaViewModel.Id = _tareaEnEdicionId;
                _tareaViewModel.Estado = estadoSeleccionado?.Nombre!;
                _tareaViewModel.Prioridad = prioridadSeleccionada?.Nombre!;

                
                if (_tareaViewModel.ActualizarCommand?.CanExecute(null) == true)
                {
                    _tareaViewModel.ActualizarCommand.Execute(null);

                    XtraMessageBox.Show("Tarea actualizada correctamente!",
                     "Éxito",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information);

                    
                    _tareaViewModel.CargarTareasCommand.Execute(null);
                }
                else
                {
                    XtraMessageBox.Show("No se pudo actualizar la tarea. Verifique los datos.",
                       "Error de actualización",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    return; 
                }

               
                _tareaViewModel.LimpiarDatos();
                ConfigurarBotonGuardar();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al actualizar la tarea: " + ex.Message,
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void editarTarea(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int focuseRowSelected = gridView1.FocusedRowHandle;

                if (focuseRowSelected >= 0)
                {
                    var tarea = gridView1.GetRow(focuseRowSelected) as Tarea;

                    if (tarea != null)
                    {
                       
                        _tareaViewModel.Id = tarea.Id;
                        _tareaViewModel.Descripcion = tarea.Descripcion;
                        _tareaViewModel.Estado = tarea.Estado;
                        _tareaViewModel.Prioridad = tarea.Prioridad;
                        _tareaViewModel.FechaCompromiso = tarea.FechaCompromiso;
                        _tareaViewModel.Notas = tarea.Notas ?? string.Empty;

                        // Cambiar el botón a modo actualizar
                        ConfigurarBotonActualizar(tarea.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al editar la tarea: " + ex.Message,
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void eliminarTarea(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int focuseRowSelected = gridView1.FocusedRowHandle;

                if (focuseRowSelected >= 0)
                {
                    var tarea = gridView1.GetRow(focuseRowSelected) as Tarea;

                    if (tarea != null)
                    {
                        if(tarea.Estado != "EN_PROCESO")
                        {
                            if (XtraMessageBox.Show($"¿Está seguro que desea eliminar la tarea {tarea.Id}?",
                            "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                _tareaViewModel.EliminarCommand.Execute(tarea);


                                _tareaViewModel.CargarTareasCommand.Execute(null);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Una tarea en proceso no puede ser eliminada.",
                             "",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error al eliminar la tarea: " + ex.Message,
                       "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }              
        private bool ValidarFormulario()
        {           
            if (string.IsNullOrWhiteSpace(txtDescricion.Text))
            {
                XtraMessageBox.Show("La descripción es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricion.Focus();
                return false;
            }

            if (lookUpEdit1.EditValue == null || lookUpEdit1.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Debe seleccionar un estado válido para la tarea.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lookUpEdit1.Focus();
                return false;
            }
            
            if (lookUpEditPrioridad.EditValue == null || lookUpEditPrioridad.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Debe seleccionar una prioridad válida para la tarea.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lookUpEditPrioridad.Focus();
                return false;
            }
          
            if (fechaCompromiso.EditValue == null || fechaCompromiso.EditValue == DBNull.Value)
            {
                XtraMessageBox.Show("Debe seleccionar una fecha de compromiso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fechaCompromiso.Focus();
                return false;
            }

            if (fechaCompromiso.EditValue is DateTime fechaSeleccionada)
            {
                if (fechaSeleccionada.Date < DateTime.Now.Date)
                {
                    XtraMessageBox.Show("La fecha de compromiso debe ser hoy o una fecha futura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    fechaCompromiso.Focus();
                    return false;
                }
            }
            else
            {
                XtraMessageBox.Show("La fecha de compromiso no es válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fechaCompromiso.Focus();
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _tareaViewModel.LimpiarDatos();           
            ConfigurarBotonGuardar();
        }
    }
}