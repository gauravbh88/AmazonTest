using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AmazonProductTest.Pages
{
    class SearchPage
    {
        private IWebDriver _driver;
    
      

        public SearchPage(IWebDriver driver)
        {
            _driver = driver;
        }

  
        IWebElement AmazonSearch => _driver.FindElement(By.Id("twotabsearchtextbox"));

        IWebElement SubmitButton => _driver.FindElement(By.Id("nav-search-submit-button"));

        IWebElement sort => _driver.FindElement(By.Id("a-autoid-0-announce"));

        IWebElement PriceLowToHigh => _driver.FindElement(By.Id("s-result-sort-select_1"));

        

        IWebElement FirstProduct => _driver.FindElement(By.XPath("(//span/div/div/div[2]/div[2]/div/div[1]/div/div/div[1]/h2/a)[1]"));

        

       



        public void AmazonProductSearch(String SearchItem)
        {
            AmazonSearch.SendKeys(SearchItem);
            
        
        }

        public void AmazonSearchSubmit()
        {
            SubmitButton.Click();
        }

        public void ClickSort()
        {
            sort.Click();
            PriceLowToHigh.Click();

        }

        public void  VerifyFirstProductName(String SearchWord1, String SearchWord2)
        {



            String FirstProductText = FirstProduct.FindElement(By.XPath("(//span[contains(@class, 'a-size-medium a-color-base a-text-normal')])")).Text;

            StringAssert.Contains(SearchWord1, FirstProductText);
            StringAssert.Contains(SearchWord2, FirstProductText);

        }

        public void ClickFirstProduct()
        {
            FirstProduct.Click();

        }



    }
}
