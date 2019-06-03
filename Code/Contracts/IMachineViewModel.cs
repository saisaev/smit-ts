using System.Collections.ObjectModel;

namespace SmitDemo.Contract
{
    public interface IMachineViewModel
    {
        ObservableCollection<IProductViewModel> ProductViewModels { get; }

        double MachineWidth { get; }

        double MachineLength { get; }

        void AddProduct(IProductData product);

        bool IsFull { get; }
    }
}
