using System.Windows.Input;

namespace SmitDemo.Contract
{
    public interface IProductViewModel
    {
        int ProductId { get; }

        string CustomerProductId { get; }

        double MachinePosX { get; set; }

        double MachinePosY { get; set; }

        ICommand CommandReject { get; }

        ProductState ProductState { get; set; }

        string PopupTip { get; }

        double ProductLength { get; }

        double ProductWidth { get; }
    }
}
