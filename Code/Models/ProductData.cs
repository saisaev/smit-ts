using SmitDemo.Contract;

namespace SmitDemo
{
    public class ProductData : IProductData
    {
        private readonly int productId;

        private readonly string customerProductId;

        private double machinePosX;

        private double machinePosY;

        private ProductState state;

        private static double length = 0.1;

        private static double width = 0.1;

        public int ProductId => this.productId;

        public string CustomerProductId => this.customerProductId;

        public double PosX { get => this.machinePosX; set => this.machinePosX = value; }

        public double PosY { get => this.machinePosY; set => this.machinePosY = value; }

        public ProductState State { get => this.state; set => this.state = value; }

        public double Length => ProductData.length;

        public double Width => ProductData.width;

        public ProductData(int id, string customerId, double posX, double posY) {
            this.productId = id;
            this.customerProductId = customerId;
            this.machinePosX = posX;
            this.machinePosY = posY;
            this.state = ProductState.Undefined;
        }

        public static void SetSize(double length, double width) {
            ProductData.length = length;
            ProductData.width = width;
        }
    }
}
