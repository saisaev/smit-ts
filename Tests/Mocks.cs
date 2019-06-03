using SmitDemo;
using SmitDemo.Contract;
using System;
using System.Collections.Generic;

namespace SmitTest
{
    class ProductMock : IProductData
    {
        public const int ID = 123;
        public const string CID = "DEMO";
        public const double POS_X = 1.11;
        public const double POS_Y = 2.22;
        public const ProductState STATE = ProductState.ProductOK;

        public int ProductId => ID;
        public string CustomerProductId => CID;

        public double PosX { get => POS_X; set => throw new NotImplementedException(); }
        public double PosY { get => POS_Y; set => throw new NotImplementedException(); }
        public ProductState State { get => STATE; set => throw new NotImplementedException(); }

        public double Length => 1;
        public double Width => 1;
    }

    class MachineMock : IMachineData
    {
        public const double LENGTH = 1.11;
        public const double WIDTH = 2.22;
        public const bool FULL = false;

        public IMachineData AddProduct(IProductData product) => this;
        public double Length => LENGTH;
        public IEnumerable<IProductData> Products => throw new NotImplementedException();
        public double Width => WIDTH;
        public bool IsFull => FULL;
    }
}
