using System;
using System.Collections.Generic;
using System.Text;

namespace Hirdavat.Wpf
{
    class ProductsModel
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public int Stok { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public string InnerBarCode { get; set; }

        //EntityFrameWork Category üzerinde değişiklik olduğunda izleme yapabilecek
        public virtual CategoryModel Category { get; set; }

    }
}
