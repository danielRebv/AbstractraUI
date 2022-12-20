using AbstractraUI.HomePage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractraUI.StepDefinitions
{
    [Binding]
    internal class AbstractaSteps
    {
        private AbstractraHomePage _homePage;

        public AbstractaSteps(AbstractraHomePage homePage)
        {
            _homePage= homePage;    
        }


        [Given(@"I open ""([^""]*)""")]
        public void GivenIOpen(string p0)
        {
            _homePage.callurl(p0);
        }

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string iPhone)
        {
           _homePage.sendText(iPhone);
        }

        [When(@"I click on the first option")]
        public void WhenIClickOnTheFirstOption()
        {
            _homePage.firtResult();
        }

        [When(@"I click on Add to Cart")]
        public void WhenIClickOnAddToCart()
        {
            _homePage.addToCart();
        }

        [When(@"I should see Success")]
        public void WhenIShouldSeeSuccess()
        {
            _homePage.waitE();
            //Console.WriteLine(_homePage.textSucces());
            Assert.AreEqual("Success: You have added iPhone to your shopping cart!\r\n×", _homePage.textSucces());
        }

        [When(@"I click on Shopping Cart")]
        public void WhenIClickOnShoppingCart()
        {
            _homePage.ShoppingCart();
        }

        [When(@"I click on View Cart")]
        public void WhenIClickOnViewCart()
        {
            _homePage.viewCartShopping();
        }


        [When(@"I should see iPhone")]
        public void WhenIShouldSeeIPhone()
        {
            _homePage.ScreenShot("//iphone.png");
        }

        [When(@"I click on Remove")]
        public void WhenIClickOnRemove()
        {
            _homePage.eraseProduct();
        }

        [Then(@"I should not see iPhone")]
        public void ThenIShouldNotSeeIPhone()
        {
            _homePage.ScreenShot("//deleteIphone.png");
        }









    }
}
