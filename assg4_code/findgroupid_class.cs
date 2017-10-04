using System;
using System.Collections.Generic;
using product_details_fill;
using product_group;


namespace groupid{

    public class FindGroupId{

        public static int Find(string strFind){
            try{
            ProductDetailsFill objProductDetailFill=new ProductDetailsFill();
            List<Product_Group> listProductGroup=objProductDetailFill.ProductGroupFill();

            foreach(Product_Group item in listProductGroup){
                if(item.name=="dairy"&&item.name==strFind)
                    return 1;
                if(item.name=="chocolate"&&item.name==strFind)
                    return 2;
                if(item.name=="juice"&&item.name==strFind)
                    return 3;
                if(item.name=="sweet"&&item.name==strFind)
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