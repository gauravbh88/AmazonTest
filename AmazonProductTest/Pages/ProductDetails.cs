using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AmazonProductTest.Pages
{
    class ProductDetails
    {
        private IWebDriver _driver;



        public ProductDetails(IWebDriver driver)
        {
            _driver = driver;
        }


        IWebElement Brand => _driver.FindElement(By.Id("bylineInfo"));

        IWebElement Seller => _driver.FindElement(By.XPath("//*[@id='tabular-buybox-truncate-1']/span[2]/span/a"));

    


        public void VerifyBrand( String BrandName)
        {

            String ActualText = Brand.Text;

                   
            StringAssert.Contains(BrandName, ActualText);

        }

        public void VerifySeller(String SellerName)
        {

             String ActualSellerText = Seller.Text;

           
            StringAssert.Contains(SellerName, ActualSellerText);

          

        }
    }
}
