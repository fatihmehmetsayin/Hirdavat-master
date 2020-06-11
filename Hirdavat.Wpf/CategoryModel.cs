using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Hirdavat.Wpf
{
   public class CategoryModel
    {
               
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        //Icollection Interface den bir dizi oluşturduk 
        //category de birden fazla ürün olabilir.
        public List<ProductsModel> Products { get; set; }

    }
}
