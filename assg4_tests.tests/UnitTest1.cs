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
            Product_Info objProductInfo1=new Product_Info();
            Product_Info objProductInfo2=new Product_Info();
            Product_Info objProductInfo3=new Product_Info();
            ProductDetailsFill objProductDetailsFill=new ProductDetailsFill();
            List<Product_Info> listProductInfo=new List<Product_Info>(3);
            List<Product_Info> listProductInfoAfterDelete=new List<Product_Info>();
            listProductInfo.Add(objProductInfo1);
            listProductInfo.Add(objProductInfo2);
            listProductInfo.Add(objProductInfo3);
            //Act
            int intCountListProductInfo=listProductInfo.Count;
            listProductInfoAfterDelete=objProductDetailsFill.ProductDelete(listProductInfo,1);
            int intCountListProductInfoAfterDelete=listProductInfoAfterDelete.Count;
            //Assert
            Assert.IsType<int>(intCountListProductInfo);
            Assert.IsType<int>(intCountListProductInfoAfterDelete);
            Assert.Equal(intCountListProductInfoAfterDelete+1,intCountListProductInfo);
            Assert.NotEqual(intCountListProductInfoAfterDelete,intCountListProductInfo);
        }
    }
}
