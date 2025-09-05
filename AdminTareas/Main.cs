using AdminTareas.Datos.Context;
using AdminTareas.Datos.Persistences.Interfaces;
using AdminTareas.Datos.Persistences.Repositories;
using AdminTareas.Modelos.Entidades;
using AdminTareas.ViewModels;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;

namespace AdminTareas {
    //public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    public partial class Main : Form

    {
        private readonly TareaViewModel _viewModel;
        public Main()
        {
            InitializeComponent();
            // 1. Instantiate the DbContext
            var optionsBuilder = new DbContextOptionsBuilder<AdminTareaContext>();

            var dbContext = new AdminTareaContext(optionsBuilder.Options);

            ITareaRepository repository = new TareaRepository(dbContext);

           // var estadoTarea = repository

            _viewModel = new TareaViewModel(repository);
            txtDescricion.DataBindings.Add("Text", _viewModel, "Descripcion", true, DataSourceUpdateMode.OnPropertyChanged);
            txtEstado.DataBindings.Add("Text", _viewModel, "Estado", true, DataSourceUpdateMode.OnPropertyChanged);

            btn_guardar.Click += (sender, e) => _viewModel.GuardarCommand.Execute(null);

            // Vinculación del DataGridView a la lista de tareas del ViewModel
            dgvTareas.DataSource = _viewModel.Tareas;



            _viewModel.CargarTareasCommand.Execute(null);
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {

            int focuseRowSelected = gridView1.FocusedRowHandle;

            if (focuseRowSelected >= 0)
            {
                var tarea = gridView1.GetRow(focuseRowSelected) as Tarea;

                if (tarea != null)
                {
                    if (XtraMessageBox.Show($"¿Está seguro que desea eliminar la tarea {tarea.Id}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _viewModel.EliminarCommand.Execute(tarea);
                    }

                }
            }

        }

        private void EditarTarea(object sender, EventArgs e)
        {
            int focuseRowSelected = gridView1.FocusedRowHandle;

            if (focuseRowSelected >= 0)
            {
                var tarea = gridView1.GetRow(focuseRowSelected) as Tarea;

                if (tarea != null)
                {

                    // Cargar datos de la tarea al formulario
                    _viewModel.Descripcion = tarea.Descripcion;
                    _viewModel.Estado = tarea.Estado;

                    // Guardar cambios al presionar botón "Editar"
                    btn_guardar.Click -= (s, ev) => _viewModel.GuardarCommand.Execute(null);
                    btn_guardar.Click += (s, ev) => _viewModel.EditarCommand.Execute(tarea);

                }
            }
        }

        private void dgvTareas_Click(object sender, EventArgs e)
        {

        }
    }
}
