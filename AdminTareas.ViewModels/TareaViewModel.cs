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
        private string _descripcion;
        private string _estado;
        private ObservableCollection<Tarea> _tareas;


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

        public ObservableCollection<Tarea> Tareas
        {
            get => _tareas;
            set
            {
                _tareas = value;
                OnPropertyChanged();
            }
        }
        public ICommand GuardarCommand { get; set; }
        public ICommand CargarTareasCommand { get; }
        public ICommand EliminarCommand { get; }
        public ICommand EditarCommand { get; }

        public TareaViewModel(ITareaRepository repository)
        {
            _repository = repository;
            Tareas = new ObservableCollection<Tarea>();
            GuardarCommand = new RelayCommand(GuardarTarea, CanGuardarTarea);
            CargarTareasCommand = new RelayCommand(CargarTareas);
            EliminarCommand = new RelayCommand<Tarea>(EliminarTarea);
            EditarCommand = new RelayCommand<Tarea>(EditarTarea);

        }

        private void GuardarTarea()
        {

            var nuevaTarea = new Tarea
            {
                Descripcion = _descripcion,
                Estado = _estado,
                Prioridad = "Alta",
                FechaCompromiso = DateTime.Now.AddDays(2),
                Notas = "Prueba"

            };
            _repository.AgregarTarea(nuevaTarea);
            Tareas.Add(nuevaTarea); // Se agrega la nueva tarea a la colección observable
            Descripcion = string.Empty;
            Estado = string.Empty;

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

        private void EliminarTarea(Tarea tarea)
        {
            if (tarea == null) return;

            _repository.EliminarTarea(tarea.Id);
            Tareas.Remove(tarea);
        }

        private void EditarTarea(Tarea tarea)
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


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
