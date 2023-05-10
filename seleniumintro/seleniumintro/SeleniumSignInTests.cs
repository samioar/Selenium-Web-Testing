using System.Transactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace seleniumintro
{
    public class Selenium_Sign_InTests
    {
        [Test]
        [Category("Happy Path")]
        public void GivenIAmOnTheHomepage_WhenIEnterAValidEmailAndValidPassword_ThenIShouldLandOnTheInventoryPage()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--headless"); //bypasses gui

            // the resource with in the using arguement disposes when it leaves the brace
            // anything in the using statement arguement, argument must implement the Idisposable
            // so when we leave the using block, its dispose method is called
            using (IWebDriver driver = new FirefoxDriver(options))
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                var userName = driver.FindElement(By.Id("user-name"));
                userName.SendKeys("standard_user");
                var passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("secret_sauce");
                var loginButton = driver.FindElement(By.Id("login-button"));
                loginButton.Click();
                Assert.That(driver.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
            }
        }
        [Test]
        [Category("SAD Path")]
        public void GivenIAmOnTheHomepage_WhenIEnterAValidEmailAndinValidPassword_ThrowEpicSadface()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--headless");
            // the resource with in the using arguement disposes when it leaves the brace
            // anything in the using statement arguement, argument must implement the Idisposable
            // so when we leave the using block, its dispose method is called
            using (IWebDriver driver = new FirefoxDriver(options))
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                var userName = driver.FindElement(By.Id("user-name"));
                userName.SendKeys("standard_user");
                var passwordField = driver.FindElement(By.Id("password"));
                passwordField.SendKeys("intentionally wrong password");
                var loginButton = driver.FindElement(By.Id("login-button"));
                loginButton.Click();

                var errorString = driver.FindElement(By.ClassName("error-message-container"));
                Assert.That(errorString.Text.Contains("Epic sadface: Username and password do not match any user in this service"));
            }
        }
        [Test]
        [Category("droppable")]
        public void GivenIAmOnDroppable_WhenIMoveDragable_ThenDroppedIsDisplayed()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--headless");
            using (IWebDriver driver = new FirefoxDriver(options))
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://demoqa.com/droppable/");
                var draggable = driver.FindElement(By.Id("draggable"));
                var dropped = driver.FindElement(By.Id("droppable"));
                Actions action = new Actions(driver);
                action.DragAndDrop(draggable, dropped).Perform();
                Assert.That(dropped.Text, Does.Contain("Dropped!"));
            }
        }
    }
}

