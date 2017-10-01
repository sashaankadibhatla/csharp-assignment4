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
                ProductDetailsFill obj = new ProductDetailsFill();

                List<Product_Group> pGroup = obj.ProductGroupFill();
                List<Product_Info> pInfo = obj.ProductFill();
                IEnumerable<Product_Info> p = obj.ProductSort(pInfo);

                foreach (Product_Group item1 in pGroup)
                {
                    foreach (Product_Info item2 in p)
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
                ProductDetailsFill obj = new ProductDetailsFill();

                List<Product_Group> pGroup = obj.ProductGroupFill();
                List<Product_Info> pInfo = obj.ProductFill();

                foreach(Product_Group item1 in pGroup)
                {
                    foreach(Product_Info item2 in pInfo)
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

        public void DisplayFound(string str)
        {
            if(str == null)
                Console.WriteLine("Please enter a string!");
            else    
            {
                try
                {
                    ProductDetailsFill obj = new ProductDetailsFill();

                    List<Product_Group> pGroup = obj.ProductGroupFill();
                    List<Product_Info> pInfo = obj.ProductFill();

                    var res = pInfo.Where(p => p.name.ToUpper().Contains(str.ToUpper()));

                        foreach (Product_Group item1 in pGroup)
                        {
                            foreach (Product_Info item2 in res)
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

        public void DisplayAfterDeletion(int num)
        {
            try
            {
                ProductDetailsFill obj = new ProductDetailsFill();

                List<Product_Group> pGroup = obj.ProductGroupFill();
                List<Product_Info> pInfo = obj.ProductFill();

                List<Product_Info> pNew = obj.ProductDelete(pInfo,num);

                foreach (Product_Group item1 in pGroup)
                {
                    foreach (Product_Info item2 in pInfo)
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
                ProductDetailsFill obj = new ProductDetailsFill();

                List<Product_Group> pGroup = obj.ProductGroupFill();
                List<Product_Info> pInfo = obj.ProductFill();

                List<Product_Info> pNew = obj.ProductDelete(pInfo);

                foreach (Product_Group item1 in pGroup)
                {
                    foreach (Product_Info item2 in pInfo)
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

        public void DisplayAfterDeletion(int start, int end)
        {
            try
            {
                ProductDetailsFill obj = new ProductDetailsFill();

                List<Product_Group> pGroup = obj.ProductGroupFill();
                List<Product_Info> pInfo = obj.ProductFill();

                List<Product_Info> pNew = obj.ProductDelete(pInfo, start, end);

                foreach (Product_Group item1 in pGroup)
                {
                    foreach (Product_Info item2 in pInfo)
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