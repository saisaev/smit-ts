using SmitDemo.Contract;
using System.ComponentModel;
using System.Windows.Input;

namespace SmitDemo
{
    public class ProductViewModel : IProductViewModel, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public int ProductId => this.product.ProductId;

        public string CustomerProductId => this.product.CustomerProductId;

        public string PopupTip => string.Format("id: {0}\ncustomer id: {1}\nstate: {2}"
            , this.ProductId
            , this.product.CustomerProductId
            , this.ProductState.ToString());

        public ICommand CommandReject => commandReject;

        private readonly IProductData product;

        private readonly ICommand commandReject;

        public ProductState ProductState {
            get => this.product.State;
            set {
                this.product.State = value;
                OnPropertyChanged(nameof(this.ProductState));
                OnPropertyChanged(nameof(this.PopupTip));
            }
        }

        public ProductViewModel(IProductData product) {
            this.product = product;
            this.commandReject = new RelayCommand(oa => true, o => this.ExecReject());
        }

        public double MachinePosX {
            get => this.product.PosX;
            set {
                this.product.PosX = value;
                OnPropertyChanged(nameof(this.MachinePosX));
            }
        }

        public double MachinePosY {
            get => this.product.PosY;
            set {
                this.product.PosY = value;
                OnPropertyChanged(nameof(this.MachinePosY));
            }
        }

        public double ProductLength => this.product.Length;

        public double ProductWidth => this.product.Width;

        private void ExecReject() => this.ProductState = ProductState.ProductRejected;
    }
}
