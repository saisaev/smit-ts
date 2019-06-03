using System;
using System.Collections.Generic;
using SmitDemo.Contract;

namespace SmitDemo
{
    public class MachineData : IMachineData
    {
        private List<IProductData> products = new List<IProductData>();

        private readonly int maxCapacity;

        private readonly double length;

        private readonly double width;

        public IEnumerable<IProductData> Products => this.products;

        public double Length => this.length;

        public double Width => this.width;

        public bool IsFull => this.products.Count == this.maxCapacity;

        public MachineData(double length, double width, int capacity) {
            this.length = length;
            this.width = width;
            this.maxCapacity = capacity;
        }

        public IMachineData AddProduct(IProductData product) {
            if (!this.IsFull) {
                products.Add(product);
            }
            else {
                throw new Exception("too many products");
            }
            return this;
        }
    }
}