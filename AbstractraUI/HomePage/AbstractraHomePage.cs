using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractraUI.HomePage
{
    internal class AbstractraHomePage
    {
        private readonly IWebDriver? _driver;
        

        public AbstractraHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        
        //routes
        private readonly By searchInput = By.XPath("//input[@placeholder='Search']");
        private readonly By btnSearch = By.XPath("//button[@class='btn btn-default btn-lg']");
        private readonly By firstR = By.XPath("//a[normalize-space()='iPhone']");
        private readonly By btnAddToCartt = By.XPath("//button[@id='button-cart']");
        private readonly By messageSucces = By.XPath("(//div[@class='alert alert-success alert-dismissible'])[1]");
        private readonly By btnShopping = By.XPath("//button[@class='btn btn-inverse btn-block btn-lg dropdown-toggle']");
        private readonly By btnViewCart = By.XPath("//strong[normalize-space()='View Cart']");
        private readonly By iphoneCart = By.XPath("(//a[contains(text(),'iPhone')])[2]");
        private readonly By deleteProduct = By.XPath("//button[@class='btn btn-danger']");
        private readonly By emptyCart = By.XPath("//div[@id='content']//p[contains(text(),'Your shopping cart is empty!')]");

        //methods

        public void callurl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void sendText(string text)
        {
            _driver.FindElement(searchInput).SendKeys(text);
            _driver.FindElement(btnSearch).Click();

        }

        public void firtResult()
        {
            //new WebDriverWait(_driver, TimeSpan.FromSeconds(5)).Until(driver => driver.Title.Equals("Search - IPhone"));
            _driver.FindElement(firstR).Click();
        }

        public void addToCart()
        {
            
            _driver.FindElement(btnAddToCartt).Click();
        }

        public String textSucces()
        {

           
           string texto = _driver.FindElement(messageSucces).Text;
            return texto;
        }

        public void waitE()
        {
            WebDriverWait w = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            w.Until(ExpectedConditions.ElementIsVisible(messageSucces));
        }

        public void ShoppingCart()
        {
            _driver.FindElement(btnShopping).Click();
            
        }

        public void viewCartShopping()
        {
            _driver.FindElement(btnViewCart).Click();
        }


        public void ScreenShot(string image)
        {
            Screenshot ss = ((ITakesScreenshot)_driver).GetScreenshot();
            ss.SaveAsFile(AppDomain.CurrentDomain.BaseDirectory + image, ScreenshotImageFormat.Png);
        }

        public void eraseProduct()
        {
            
            _driver.FindElement(deleteProduct).Click();
            WebDriverWait w = new WebDriverWait(_driver, TimeSpan.FromSeconds(4));
            w.Until(ExpectedConditions.ElementExists(emptyCart));
        }
    }
}
