using System;
using TechTalk.SpecFlow;
using AmazonProductTest.Pages;
using System.Threading;

namespace AmazonProductTest.Steps
{
    [Binding]
    public class ProductTestSteps
    {

        private DriverHelper _driverHelper;
        SearchPage SearchPage;
        ProductDetails ProductDetails;
        int milliseconds = 3000;



        public ProductTestSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            SearchPage = new SearchPage(_driverHelper.Driver);
            ProductDetails = new ProductDetails(_driverHelper.Driver);


        }

        [Given(@"GoTo Amazon website")]
        public void GivenGoToAmazonWebsite()
        {
            _driverHelper.Driver.Navigate().GoToUrl("https://www.amazon.com/");
        }

        [Given(@"Search for Product '(.*)'")]
        public void GivenSearchForProduct(string SearchItem)
        {
            SearchPage.AmazonProductSearch(SearchItem);
            SearchPage.AmazonSearchSubmit();
            
        }


        [When(@"Sort from low to high price")]
        public void WhenSortFromLowToHighPrice()

        {
            SearchPage.ClickSort();
            
            Thread.Sleep(milliseconds);

        }

        [Then(@"Name of first item should contains the words '(.*)' and '(.*)'")]
        public void ThenNameOfFirstItemShouldContainsTheWordsAnd(string SearchWord1, string SearchWord2)
        {
            
            SearchPage.VerifyFirstProductName(SearchWord1, SearchWord2);
        }

        [Given(@"Sort from low to high price")]
        public void GivenSortFromLowToHighPrice()
        {
            SearchPage.ClickSort();
            Thread.Sleep(milliseconds);


        }

        [When(@"First product is clicked")]
        public void WhenFirstProductIsClicked()
        {
            SearchPage.ClickFirstProduct();
        }

        [Then(@"Brand name is '(.*)' and Seller name is '(.*)'")]
        public void ThenBrandNameIsAndSellerNameIs(string BrandName, string SellerName)
        {
            ProductDetails.VerifyBrand(BrandName);
            ProductDetails.VerifySeller(SellerName);
            
        }

    }
}
