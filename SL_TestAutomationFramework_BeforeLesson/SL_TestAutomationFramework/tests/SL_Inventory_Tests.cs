
using OpenQA.Selenium.Chrome;
using SL_TestAutomationFramework.lib.pages;

namespace SL_TestAutomationFramework.tests
{
    public class SL_Inventory_Tests
    {
        private SL_Website<ChromeDriver> SL_Website = new(isHeadless:true);
        [SetUp]
        public void Setup() //takes you to inventory page
        {
            SL_Website.SeleniumDriver.Manage().Window.Maximize();
            SL_Website.SL_HomePage.VisitHomePage();
            SL_Website.SL_HomePage.EnterUserName(AppConfigReader.UserName);
            SL_Website.SL_HomePage.EnterPassword(AppConfigReader.Password);
            SL_Website.SL_HomePage.ClickLoginButton();
        }
        [Test]
        public void GivenOnInventoryPageClickingOnItem_ItemPageIsDisplayed()
        {
            SL_Website.SL_InventoryPage.ClickOnItem_SauceLabsBackpack();
            Assert.That(SL_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.SauceLabBackpackURL));
        }
    }


}

