using SmitDemo.Contract;
using System.ComponentModel;
using System.Windows.Input;

namespace SmitDemo
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public string NewCustomerProductId { get; set; }

        public ICommand CommandAdd => commandAdd;

        public IMachineViewModel MachineViewModel => this.machineViewModel;

        public double StartPosX { get; set; } = 0.0;

        public double StartPosY { get; set; } = 0.0;

        private readonly ICommand commandAdd;

        private readonly IMachineViewModel machineViewModel;

        public MainViewModel(IMachineViewModel machineViewModel) {
            this.machineViewModel = machineViewModel;
            this.commandAdd = new RelayCommand(_ => !this.machineViewModel.IsFull, _ => this.ExecAdd());
        }

        private void ExecAdd() {
            var id = this.machineViewModel.ProductViewModels.Count + 1;
            var product = new ProductData(id, this.NewCustomerProductId, StartPosX, StartPosY);
            this.machineViewModel.AddProduct(product);
        }
    }
}
