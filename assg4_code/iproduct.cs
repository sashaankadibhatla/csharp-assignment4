using System;
using System.Collections.Generic;
using product_group;
using product_info;


namespace iproduct{

    public interface Iproduct{
        List<Product_Group> ProductGroupFill();

        List<Product_Info> ProductFill();

        IEnumerable<Product_Info> ProductSort(List<Product_Info> pinfo);

        List<Product_Info> ProductDelete(List<Product_Info> pinfo, int number);
        List<Product_Info> ProductDelete(List<Product_Info> pinfo);
        List<Product_Info> ProductDelete(List<Product_Info> pinfo, int start, int end);
    }
}