using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

using SmitDemo.Contract;

namespace SmitDemo
{
    public class MachineViewModel : IMachineViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public ObservableCollection<IProductViewModel> ProductViewModels { get; set; } 
            = new ObservableCollection<IProductViewModel>();

        public double MachineWidth => this.machine.Width;

        public double MachineLength => this.machine.Length;

        public bool IsFull => this.machine.IsFull;

        private readonly IMachineData machine;

        public MachineViewModel(IMachineData machine) {
            this.machine = machine;
        }

        public void AddProduct(IProductData product) {
            try {
                this.machine.AddProduct(product);
                var productViewModel = new ProductViewModel(product);
                this.ProductViewModels.Add(productViewModel);
            }
            catch (Exception e) {
                System.Windows.MessageBox.Show(e.Message);
            }
        }
    }
}
