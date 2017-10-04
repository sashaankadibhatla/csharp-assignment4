using System;
using System.Collections.Generic;
using System.Linq;
namespace product{

    public class ProductDetailsFill: Iproduct, IComparer<Product_Info>
    {
        public List<Product_Group> ProductGroupFill()
        {
            Product_Group objProductGroup1=new Product_Group(){
                id=1,
                name="dairy"
            };
            Product_Group objProductGroup2=new Product_Group(){
                id=2,
                name="chocolate"
            };
            Product_Group objProductGroup3=new Product_Group(){
                id=3,
                name="juice"
            };
            Product_Group objProductGroup4=new Product_Group(){
                id=4,
                name="sweet"
            };
            List <Product_Group> listProductGroup=new List<Product_Group>(4);
            listProductGroup.Add(objProductGroup1);
            listProductGroup.Add(objProductGroup2);
            listProductGroup.Add(objProductGroup3);
            listProductGroup.Add(objProductGroup4);

            return listProductGroup;
        }

        public List<Product_Info> ProductFill(){

            Product_Info objProductInfo1=new Product_Info(){
                groupid=FindGroupId.Find("dairy"),
                id=1,
                name="go cheese",
                description="go cheese 180g",
                rate=115,
            };
            Product_Info objProductInfo2=new Product_Info(){
                groupid=FindGroupId.Find("dairy"),
                id=2,
                name="amul cheese",
                description="amul cheese 210g",
                rate=125
            };
            Product_Info objProductInfo3=new Product_Info(){
                groupid=FindGroupId.Find("dairy"),
                id=3,
                name="britania cheese",
                description="britania cheese 200g",
                rate=135,
            };
            Product_Info objProductInfo4=new Product_Info(){
                groupid=FindGroupId.Find("chocolate"),
                id=4,
                name="eclairs",
                description="eclairs 170g",
                rate=145,
            };
            Product_Info objProductInfo5=new Product_Info(){
                groupid=FindGroupId.Find("chocolate"),
                id=5,
                name="dairy milk",
                description="dairy milk silk 160g",
                rate=155
            };
            Product_Info objProductInfo6=new Product_Info(){
                groupid=FindGroupId.Find("juice"),
                id=6,
                name="mango juice",
                description="mango juice 100ml",
                rate=165
            };
            Product_Info objProductInfo7=new Product_Info(){
                groupid=FindGroupId.Find("juice"),
                id=7,
                name="papayya juice",
                description="papayya juice 130ml",
                rate=75
            };
            Product_Info objProductInfo8=new Product_Info(){
                groupid=FindGroupId.Find("sweet"),
                id=8,
                name="gulab jamun",
                description="gulab jamun 70g",
                rate=85
            };
            Product_Info objProductInfo9=new Product_Info(){
                groupid=FindGroupId.Find("sweet"),
                id=9,
                name="kova",
                description="kova milk 200g",
                rate=65
            };
            Product_Info objProductInfo10=new Product_Info(){
                groupid=FindGroupId.Find("sweet"),
                id=10,
                name="barfi",
                description="barfi 120g",
                rate=95
            };
            List<Product_Info> listProductInfo=new List<Product_Info>(10);
            listProductInfo.Add(objProductInfo1);
            listProductInfo.Add(objProductInfo2);
            listProductInfo.Add(objProductInfo3);
            listProductInfo.Add(objProductInfo4);
            listProductInfo.Add(objProductInfo5);
            listProductInfo.Add(objProductInfo6);
            listProductInfo.Add(objProductInfo7);
            listProductInfo.Add(objProductInfo8);
            listProductInfo.Add(objProductInfo9);
            listProductInfo.Add(objProductInfo10);

            return listProductInfo;
        }
        public int Compare(Product_Info objProductInfoA,Product_Info objProductInfoB){
            return objProductInfoA.name.CompareTo(objProductInfoB.name);
        }
        public IEnumerable<Product_Info> ProductSort(List<Product_Info> listProductInfo){
            ProductDetailsFill listProductDetailsFill=new ProductDetailsFill();
            listProductInfo.Sort(listProductDetailsFill);
            return listProductInfo;
        }
        public List<Product_Info> ProductDelete(List<Product_Info> listProductInfo,int intIndex){
            listProductInfo.RemoveAt(intIndex);
            return listProductInfo;
        }
        public  List<Product_Info> ProductDelete(List<Product_Info> listProductInfo){
            listProductInfo.RemoveAll(item =>item.rate>90);
            return listProductInfo;
        }
        public List<Product_Info> ProductDelete(List<Product_Info> listProductInfo,int intStart,int intEnd){
            listProductInfo.RemoveRange(intStart,intEnd);
            return listProductInfo;
        }
        public List<Product_Info> ProductDelete(List<Product_Info> listProductInfo, string strDelete)
        {
            while(true)
            {
                try
                {
                    listProductInfo.RemoveAll(p =>p.name==strDelete);
                    return listProductInfo;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}