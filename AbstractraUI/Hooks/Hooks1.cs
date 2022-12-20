using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AbstractraUI.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private IWebDriver? _driver;
        private readonly IObjectContainer? _container;

        public Hooks1(IObjectContainer objetContainer)
        {
            _container = objetContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _container.RegisterInstanceAs<IWebDriver>(_driver);
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Manage().Window.Maximize();
        }


        

        [AfterScenario]
        public void AfterScenario()
        {
            //_driver.Quit();
        }
    }
}