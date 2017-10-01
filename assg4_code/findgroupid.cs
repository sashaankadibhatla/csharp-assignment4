using System;
using System.Collections.Generic;
using product_details_fill;
using product_group;


namespace groupid{

    public class FindGroupId{

        public static int Find(string str){
            try{
            ProductDetailsFill ob4=new ProductDetailsFill();
            List<Product_Group> lg1=ob4.ProductGroupFill();

            foreach(Product_Group item in lg1){
                if(item.name=="dairy"&&item.name==str)
                    return 1;
                if(item.name=="chocolate"&&item.name==str)
                    return 2;
                if(item.name=="juice"&&item.name==str)
                    return 3;
                if(item.name=="sweet"&&item.name==str)
                    return 4;
            }
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
            
        }
}