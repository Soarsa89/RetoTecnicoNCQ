using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using AdminTareas.Datos.Persistences.Interfaces;
using AdminTareas.Modelos.Entidades;
using CommunityToolkit.Mvvm.Input;

namespace AdminTareas.ViewModels
{
    public class PrioridadTareaViewModel : INotifyPropertyChanged
    {
        private readonly IPrioridadTareaRepository _repository;
        private ObservableCollection<PrioridadTarea> _prioridadTarea;
        public ICommand CargarPriroridaTareaCommand { get; set; }
        public ObservableCollection<PrioridadTarea> PrioridadTareas
        {
            get => _prioridadTarea;
            set
            {
                _prioridadTarea = value;
                OnPropertyChanged();                
            }
        }
        public PrioridadTareaViewModel(IPrioridadTareaRepository repository)
        {
            _repository = repository;
            _prioridadTarea = new ObservableCollection<PrioridadTarea>();
            PrioridadTareas = new ObservableCollection<PrioridadTarea>();
            CargarPriroridaTareaCommand = new RelayCommand(CargarPrioridaTarea);
        }
        private void CargarPrioridaTarea()
        {
            var listaDePrioridadTarea = _repository.ObtenerPrioridadTarea();
            PrioridadTareas.Clear();
            foreach (var priroridadTarea in listaDePrioridadTarea)
            {
                PrioridadTareas.Add(priroridadTarea);
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
