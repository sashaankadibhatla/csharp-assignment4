using System;
using System.Collections.Generic;


namespace product{

    public class FindGroupId{

        public static int Find(string strFind){
            try{
            ProductDetailsFill objProductDetailFill=new ProductDetailsFill();
            List<Product_Group> listProductGroup=objProductDetailFill.ProductGroupFill();

            foreach(Product_Group item in listProductGroup){
                if(strFind==item.name)
                return item.id;
            }
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
            
        }
}