using System;
using System.Collections.Generic;


namespace product{

    public interface Iproduct{
        List<Product_Group> ProductGroupFill();

        List<Product_Info> ProductFill();

        IEnumerable<Product_Info> ProductSort(List<Product_Info> pinfo);

        List<Product_Info> ProductDelete(List<Product_Info> pinfo, int number);
        List<Product_Info> ProductDelete(List<Product_Info> pinfo);
        List<Product_Info> ProductDelete(List<Product_Info> pinfo, int start, int end);
    }
}