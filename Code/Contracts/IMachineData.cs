using System.Collections.Generic;

namespace SmitDemo.Contract
{
    public interface IMachineData :IMeasurable
    {
        IMachineData AddProduct(IProductData product);

        IEnumerable<IProductData> Products { get; }

        bool IsFull { get; }
    }
}
