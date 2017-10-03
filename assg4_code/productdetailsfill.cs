using System;
using System.Collections.Generic;
using System.Linq;
using iproduct;
using product_group;
using product_info;
using groupid;

namespace product_details_fill{

    public class ProductDetailsFill: Iproduct, IComparer<Product_Info>
    {
        public List<Product_Group> ProductGroupFill()
        {
            Product_Group ob1=new Product_Group(){
                id=1,
                name="dairy"
            };
            Product_Group ob2=new Product_Group(){
                id=2,
                name="chocolate"
            };
            Product_Group ob3=new Product_Group(){
                id=3,
                name="juice"
            };
            Product_Group ob4=new Product_Group(){
                id=4,
                name="sweet"
            };
            List <Product_Group> pgroup=new List<Product_Group>(4);
            pgroup.Add(ob1);
            pgroup.Add(ob2);
            pgroup.Add(ob3);
            pgroup.Add(ob4);

            return pgroup;
        }

        public List<Product_Info> ProductFill(){

            Product_Info p1=new Product_Info(){
                groupid=FindGroupId.Find("dairy"),
                id=1,
                name="go cheese",
                description="go cheese 180g",
                rate=115,
            };
            Product_Info p2=new Product_Info(){
                groupid=FindGroupId.Find("dairy"),
                id=2,
                name="amul cheese",
                description="amul cheese 210g",
                rate=125
            };
            Product_Info p3=new Product_Info(){
                groupid=FindGroupId.Find("dairy"),
                id=3,
                name="britania cheese",
                description="britania cheese 200g",
                rate=135,
            };
            Product_Info p4=new Product_Info(){
                groupid=FindGroupId.Find("chocolate"),
                id=4,
                name="eclairs",
                description="eclairs 170g",
                rate=145,
            };
            Product_Info p5=new Product_Info(){
                groupid=FindGroupId.Find("chocolate"),
                id=5,
                name="dairy milk",
                description="dairy milk silk 160g",
                rate=155
            };
            Product_Info p6=new Product_Info(){
                groupid=FindGroupId.Find("juice"),
                id=6,
                name="mango juice",
                description="mango juice 100ml",
                rate=165
            };
            Product_Info p7=new Product_Info(){
                groupid=FindGroupId.Find("juice"),
                id=7,
                name="papayya juice",
                description="papayya juice 130ml",
                rate=75
            };
            Product_Info p8=new Product_Info(){
                groupid=FindGroupId.Find("sweet"),
                id=8,
                name="gulab jamun",
                description="gulab jamun 70g",
                rate=85
            };
            Product_Info p9=new Product_Info(){
                groupid=FindGroupId.Find("sweet"),
                id=9,
                name="kova",
                description="kova milk 200g",
                rate=65
            };
            Product_Info p10=new Product_Info(){
                groupid=FindGroupId.Find("sweet"),
                id=10,
                name="barfi",
                description="barfi 120g",
                rate=95
            };
            List<Product_Info> pinfo=new List<Product_Info>(10);
            pinfo.Add(p1);
            pinfo.Add(p2);
            pinfo.Add(p3);
            pinfo.Add(p4);
            pinfo.Add(p5);
            pinfo.Add(p6);
            pinfo.Add(p7);
            pinfo.Add(p8);
            pinfo.Add(p9);
            pinfo.Add(p10);

            return pinfo;
        }
        public int Compare(Product_Info x,Product_Info y){
            return x.name.CompareTo(y.name);
        }
        public IEnumerable<Product_Info> ProductSort(List<Product_Info> pinfo){
            ProductDetailsFill obj1=new ProductDetailsFill();
            pinfo.Sort(obj1);
            return pinfo;
        }
        public List<Product_Info> ProductDelete(List<Product_Info> pinfo,int number){
            pinfo.RemoveAt(number);
            return pinfo;
        }
        public  List<Product_Info> ProductDelete(List<Product_Info>  pinfo){
            pinfo.RemoveAll(item =>item.rate>90);
            return pinfo;
        }
        public List<Product_Info> ProductDelete(List<Product_Info> pinfo,int start,int end){
            pinfo.RemoveRange(start,end);
            return pinfo;
        }
    }
}