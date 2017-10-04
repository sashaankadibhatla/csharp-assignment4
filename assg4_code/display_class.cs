using System;
using System.Collections.Generic;
using System.Linq;
using product_group;
using product_info;
using product_details_fill;

namespace display
{
    public class Display
    {
        public void displaySortedProducts()
        {
            try
            {
                ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();

                List<Product_Group> listProductGroup = objProductDetailsFill.ProductGroupFill();
                List<Product_Info> listProductInfo = objProductDetailsFill.ProductFill();
                IEnumerable<Product_Info> listProductInfoEnumerable = objProductDetailsFill.ProductSort(listProductInfo);

                foreach (Product_Group item1 in listProductGroup)
                {
                    foreach (Product_Info item2 in listProductInfoEnumerable)
                    {
                        if(item1.id == item2.groupid)
                        {
                            Console.WriteLine("Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }

        public void DisplayAll()
        {
            try
            {
                ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();

                List<Product_Group> listProductGroup = objProductDetailsFill.ProductGroupFill();
                List<Product_Info> listProductInfo = objProductDetailsFill.ProductFill();

                foreach(Product_Group item1 in listProductGroup)
                {
                    foreach(Product_Info item2 in listProductInfo)
                    {
                        if(item1.id == item2.groupid)
                        {   
                            Console.WriteLine("Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }       
        }

        public void DisplayFound(string strFound)
        {
            if(strFound == null)
                Console.WriteLine("Please enter a string!");
            else    
            {
                try
                {
                    ProductDetailsFill objProductDetailsFill  = new ProductDetailsFill();

                    List<Product_Group> listProductGroup = objProductDetailsFill.ProductGroupFill();
                    List<Product_Info> listProductInfo = objProductDetailsFill.ProductFill();

                    var resultFound = listProductInfo.Where(p => p.name.ToUpper().Contains(strFound.ToUpper()));

                        foreach (Product_Group item1 in listProductGroup)
                        {
                            foreach (Product_Info item2 in resultFound)
                            {
                                if (item1.id == item2.groupid)
                                {
                                    Console.WriteLine("Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
                                }
                            }   
                        }
                   
                }catch(Exception ex){
                    Console.WriteLine(ex.Message);
                }
            }
                        
        }

        public void DisplayAfterDeletion(int intIndex)
        {
            try
            {
                ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();

                List<Product_Group> listProductGroup = objProductDetailsFill.ProductGroupFill();
                List<Product_Info> listProductInfo = objProductDetailsFill.ProductFill();

                List<Product_Info> listProductInfoAfterDelete = objProductDetailsFill.ProductDelete(listProductInfo,intIndex);

                foreach (Product_Group item1 in listProductGroup)
                {
                    foreach (Product_Info item2 in listProductInfo)
                    {
                        if (item1.id == item2.groupid)
                        {
                            Console.WriteLine("Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }        
        }

        public void DisplayAfterDeletion()
        {
            try
            {
                ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();

                List<Product_Group> listProductGroup = objProductDetailsFill.ProductGroupFill();
                List<Product_Info> listProductInfo = objProductDetailsFill.ProductFill();

                List<Product_Info> listProductInfoAfterDelete = objProductDetailsFill.ProductDelete(listProductInfo);

                foreach (Product_Group item1 in listProductGroup)
                {
                    foreach (Product_Info item2 in listProductInfo)
                    {
                        if (item1.id == item2.groupid)
                        {
                            Console.WriteLine("Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }

        public void DisplayAfterDeletion(int intStartIndex, int intEndIndex)
        {
            try
            {
                ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();

                List<Product_Group> listProductGroup = objProductDetailsFill.ProductGroupFill();
                List<Product_Info> listProductInfo = objProductDetailsFill.ProductFill();

                List<Product_Info> listProductInfoAfterDelete = objProductDetailsFill.ProductDelete(listProductInfo, intStartIndex, intEndIndex);

                foreach (Product_Group item1 in listProductGroup)
                {
                    foreach (Product_Info item2 in listProductInfo)
                    {
                        if (item1.id == item2.groupid)
                        {
                            Console.WriteLine("Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }
    }
}