using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using AdminTareas.Datos.Persistences.Interfaces;
using AdminTareas.Modelos.Entidades;
using CommunityToolkit.Mvvm.Input;

namespace AdminTareas.ViewModels
{
    public class TareaViewModel : INotifyPropertyChanged
    {
        private readonly ITareaRepository _repository;
        private int _id;
        private string _descripcion;
        private string _estado;
        private string _prioridad;
        private DateTime _fechaCompromiso;
        private string _notas;
        private ObservableCollection<Tarea> _tareas;


        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Descripcion
        {
            get => _descripcion;
            set
            {
                if (_descripcion != value)
                {
                    _descripcion = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Estado
        {
            get => _estado;
            set
            {
                if (_estado != value)
                {
                    _estado = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Prioridad
        {
            get => _prioridad;
            set
            {
                if (_prioridad != value)
                {

                    _prioridad = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime FechaCompromiso
        {
            get=>_fechaCompromiso;
            set
            {
                if( _fechaCompromiso != value)
                {
                    _fechaCompromiso = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Notas
        {
            get => _notas;
            set
            {
                if (_notas != value)
                {
                    _notas = value;
                    OnPropertyChanged();
                }
            }
        }


        public ObservableCollection<Tarea> Tareas
        {
            get => _tareas;
            set
            {
                _tareas = value;
                OnPropertyChanged();
            }
        }
        public IAsyncRelayCommand GuardarCommand { get; }
        public IAsyncRelayCommand ActualizarCommand { get; }
        public ICommand CargarTareasCommand { get; }
        public ICommand EliminarCommand { get; }
        public ICommand EditarCommand { get; }

        public TareaViewModel(ITareaRepository repository)
        {
            _repository = repository;
            _tareas = new ObservableCollection<Tarea>();
            Tareas = new ObservableCollection<Tarea>();
            GuardarCommand = new AsyncRelayCommand(GuardarTarea);
            ActualizarCommand = new AsyncRelayCommand(ActualizarTarea);
            CargarTareasCommand = new RelayCommand(CargarTareas);
            EliminarCommand = new RelayCommand<Tarea>(EliminarTarea);
            EditarCommand = new RelayCommand<Tarea>(EditarTarea);

            _descripcion = string.Empty;
            _estado = string.Empty;
            _prioridad= string.Empty;
            _notas = string.Empty;
           

        }

        private async Task GuardarTarea()
        {

            
            if (!ValidatoDatosFormulario()) return ;          

            var nuevaTarea = new Tarea
            {
                Descripcion = _descripcion,
                Estado = _estado,
                Prioridad = _prioridad,
                FechaCompromiso = _fechaCompromiso,
                Notas = _notas

            };
            var response = await _repository.AgregarTarea(nuevaTarea);


            if (response)
            {
                Tareas.Add(nuevaTarea);
                LimpiarDatos();                

            }
           

        }

        private async Task ActualizarTarea()
        {
            try
            {
                //Validar Formulario
                if (!ValidatoDatosFormulario()) return;

                var tareaExistente = await _repository.ObtenerPorIdAsync(Id);

                if (tareaExistente == null)
                {
                    throw new Exception("La tarea a actualizar no existe.");
                }

                // Actualizar solo los campos modificados
                tareaExistente.Descripcion = Descripcion;
                tareaExistente.Estado = Estado!;
                tareaExistente.Prioridad = Prioridad!;
                tareaExistente.FechaCompromiso = FechaCompromiso;
                tareaExistente.Notas = Notas;
               

                await _repository.EditarTarea(tareaExistente); ;
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar la tarea: {ex.Message}", ex);
            }
        }

        public void LimpiarDatos()
        {
            Id = 0;
            Descripcion = string.Empty;
            Estado = string.Empty;
            Prioridad = string.Empty;
            Notas = string.Empty;
        }

        private bool CanGuardarTarea()
        {
            return !string.IsNullOrEmpty(_descripcion);
        }

        private void CargarTareas()
        {
            var listaDeTareas = _repository.ObtenerTareas();
            Tareas.Clear();
            foreach (var tarea in listaDeTareas)
            {
                Tareas.Add(tarea);
            }
        }

        private void EliminarTarea(Tarea? tarea)
        {
            if (tarea == null) return;

            _repository.EliminarTarea(tarea.Id);
            Tareas.Remove(tarea);
        }

        private void EditarTarea(Tarea? tarea)
        {
            if (tarea == null) return;

            tarea.Descripcion = Descripcion;
            tarea.Estado = Estado;

            _repository.EditarTarea(tarea);

            // refrescar colección
            var index = Tareas.IndexOf(tarea);
            if (index >= 0)
            {
                Tareas[index] = tarea;
            }

            Descripcion = string.Empty;
            Estado = string.Empty;
        }



        //Validar Datos del Fomulario
        private bool ValidatoDatosFormulario()
        {           
            if (string.IsNullOrWhiteSpace(_descripcion))
            {
                return false;
            }            
            if (_estado == null)
            {
                return false;
            }          
            if (_prioridad == null)
            {
                return false;
            }        
            if (_fechaCompromiso == default(DateTime))
            {
                return false;
            }

            return true;
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
