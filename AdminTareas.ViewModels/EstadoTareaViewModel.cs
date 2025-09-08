using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using AdminTareas.Datos.Persistences.Interfaces;
using AdminTareas.Modelos.Entidades;
using CommunityToolkit.Mvvm.Input;

namespace AdminTareas.ViewModels
{
    public class EstadoTareaViewModel : INotifyPropertyChanged
    {
        private readonly IEstadoTareaRespository _repository;
        public ICommand CargarEstadoTareaCommand { get; }
        private ObservableCollection<EstadoTarea> _estadoTarea;


        public ObservableCollection<EstadoTarea> EstadoTarea
        {
            get => _estadoTarea;
            set
            {
                _estadoTarea = value;
                OnPropertyChanged();
            }
        }


        public EstadoTareaViewModel(IEstadoTareaRespository repository)
        {
            _repository = repository;
            _estadoTarea = new ObservableCollection<EstadoTarea>();
            EstadoTarea = new ObservableCollection<EstadoTarea>();
            CargarEstadoTareaCommand = new RelayCommand(CargarEstadoTarea);

        }

        private void CargarEstadoTarea()
        {
            var listaDeEstadoTarea = _repository.ObtenerEstadoTarea();
            EstadoTarea.Clear();
            foreach (var estadoTarea in listaDeEstadoTarea)
            {
                EstadoTarea.Add(estadoTarea);
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
