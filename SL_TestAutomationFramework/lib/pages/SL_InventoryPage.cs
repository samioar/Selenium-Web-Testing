
using OpenQA.Selenium;
using static System.Net.WebRequestMethods;

namespace SL_TestAutomationFramework.lib.pages
{
    public class SL_InventoryPage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _usernameField => _seleniumDriver.FindElement(By.Id("user-name"));
        private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));
        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.CssSelector("[data-test=\"error\"]"));
        private IWebElement _goToCartbutton => _seleniumDriver.FindElement(By.ClassName("shopping_cart_link"));

        private IWebElement _sauceLabBackpackCartCheck=> _seleniumDriver.FindElement(By.CssSelector(".inventory_item_name"));
        private IWebElement _removeBackpackFromCart => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-backpack"));



        private string _homePageUrl = AppConfigReader.BaseUrl;
        public SL_InventoryPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
        public void VisitHomePage() => _seleniumDriver.Navigate().GoToUrl(_homePageUrl);
        public void EnterUserName(string username) => _usernameField.SendKeys(username);
        public void EnterPassword(string password) => _passwordField.SendKeys(password);
        public void ClickLoginButton() => _loginButton.Click();
        public string CheckErrorMessage() => _errorMessage.Text;
        internal void ClickOnItem_SauceLabsBackpack()
        {
            var item = _seleniumDriver.FindElement(By.CssSelector("#item_4_title_link > .inventory_item_name"));
            item.Click();
        }

        internal void ClickOnAddToBasket()
        {
            var basket = _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            basket.Click();
        }
        internal void GoToBasket() => _goToCartbutton.Click();

        internal string CheckCartForBackPack() => _sauceLabBackpackCartCheck.Text;
        internal void RemoveBackpackFromCart() => _removeBackpackFromCart.Click();


    }
}
