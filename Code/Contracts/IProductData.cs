namespace SmitDemo.Contract
{
    public interface IProductData : IMeasurable
    {
        int ProductId { get; }

        string CustomerProductId { get; }

        double PosX { get; set; }

        double PosY { get; set; }

        ProductState State { get; set; }
    }
}
