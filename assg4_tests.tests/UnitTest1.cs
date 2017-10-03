using System;
using Xunit;
using System.Collections.Generic;
using product_group;
using product_info;
using iproduct;
using product_details_fill;

namespace assg4_tests.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Product_Info obj1=new Product_Info();
            Product_Info obj2=new Product_Info();
            Product_Info obj3=new Product_Info();
            ProductDetailsFill mainobj=new ProductDetailsFill();
            List<Product_Info> pg1=new List<Product_Info>(3);
            List<Product_Info> pg2=new List<Product_Info>();
            pg1.Add(obj1);
            pg1.Add(obj2);
            pg1.Add(obj3);
            //Act
            int cnt=pg1.Count;
            pg2=mainobj.ProductDelete(pg1,1);
            int cnt1=pg2.Count;
            //Assert
            Assert.IsType<int>(cnt);
            Assert.IsType<int>(cnt1);
            Assert.Equal(cnt1+1,cnt);
            Assert.NotEqual(cnt1,cnt);
        }
    }
}
