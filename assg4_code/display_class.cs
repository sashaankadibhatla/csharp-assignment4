using System;
using System.Collections.Generic;
using System.Linq;

namespace product
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
                            int intIndex=listProductInfo.IndexOf(item2);
                            Console.WriteLine("Index:"+intIndex +"|| Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
                            intIndex++;
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
                            int intIndex=listProductInfo.IndexOf(item2);   
                            Console.WriteLine("Index:"+intIndex+"|| Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
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
                                    int intIndex=listProductInfo.IndexOf(item2);
                                    Console.WriteLine("Index:"+intIndex+"|| Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
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
                    foreach (Product_Info item2 in listProductInfoAfterDelete)
                    {
                        if (item1.id == item2.groupid)
                        {
                            int intIndex0=listProductInfoAfterDelete.IndexOf(item2);
                            Console.WriteLine("Index:"+intIndex0+"||Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
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
                    foreach (Product_Info item2 in listProductInfoAfterDelete)
                    {
                        if (item1.id == item2.groupid)
                        {
                            int intIndex1=listProductInfoAfterDelete.IndexOf(item2);
                            Console.WriteLine("Index:"+intIndex1+"||Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
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
                    foreach (Product_Info item2 in listProductInfoAfterDelete)
                    {
                        
                        if (item1.id == item2.groupid)
                        {
                            int intIndex2=listProductInfoAfterDelete.IndexOf(item2);
                            Console.WriteLine("Index:"+intIndex2+"||Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }
        public void DisplayAfterDeletion(string strDelete)
        {
            try
            {
                ProductDetailsFill objProductDetailsFill = new ProductDetailsFill();

                List<Product_Group> listProductGroup = objProductDetailsFill.ProductGroupFill();
                List<Product_Info> listProductInfo = objProductDetailsFill.ProductFill();
                if(listProductInfo.Any(product=>product.name==strDelete)){
                List<Product_Info> listProductInfoAfterDelete = objProductDetailsFill.ProductDelete(listProductInfo,strDelete);
                foreach (Product_Group item1 in listProductGroup)
                {
                    foreach (Product_Info item2 in listProductInfoAfterDelete)
                    {
                        if (item1.id == item2.groupid)
                        {
                            int intIndex3=listProductInfoAfterDelete.IndexOf(item2);
                            Console.WriteLine("Index:"+intIndex3+"||Product Group Name: "+item1.name+" || Product Name: "+item2.name+" || Product Description: "+item2.description+" || Product Rate: "+item2.rate);
                        }
                    }
                }
                }
            else Console.WriteLine("product name does not exist so cant delete");
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        }
        
    }
}