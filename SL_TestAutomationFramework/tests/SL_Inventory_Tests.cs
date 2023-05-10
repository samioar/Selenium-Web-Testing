
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using SL_TestAutomationFramework.lib.pages;
//using System.Reflection.Metadata;

//namespace SL_TestAutomationFramework.tests
//{
//    public class SL_Inventory_Tests
//    {
//        private SL_Website<ChromeDriver> SL_Website = new(isHeadless:true);
//        [SetUp]
//        public void Setup() //takes you to inventory page
//        {
//            SL_Website.SeleniumDriver.Manage().Window.Maximize();
//            SL_Website.SL_HomePage.VisitHomePage();
//            SL_Website.SL_HomePage.EnterUserName(AppConfigReader.UserName);
//            SL_Website.SL_HomePage.EnterPassword(AppConfigReader.Password);
//            SL_Website.SL_HomePage.ClickLoginButton();
//        }
//        public void SetUpBasketWithSauceLabBackPack()
//        {
//            SL_Website.SL_InventoryPage.ClickOnAddToBasket();
//            SL_Website.SL_InventoryPage.GoToBasket();
//        }

//        [Test]
//        public void GivenOnInventoryPageClickingOnItem_ItemPageIsDisplayed()
//        {
//            SL_Website.SL_InventoryPage.ClickOnItem_SauceLabsBackpack();
//            Assert.That(SL_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.SauceLabBackpackURL));
//        }
//        [Test]
//        public void GivenOnInventoryPageAddToCart_AddsToCart()
//        {
//            SetUpBasketWithSauceLabBackPack();
//            Assert.That(SL_Website.SL_InventoryPage.CheckCartForBackPack(), Does.Contain("Sauce Labs Backpack"));
//        }
//        [Test]
//        public void GivenItemInCart_Remove_RemovesItemFromCart()
//        {
//            SetUpBasketWithSauceLabBackPack();
//            SL_Website.SL_InventoryPage.RemoveBackpackFromCart();
//            Assert.That(() => SL_Website.SL_InventoryPage.CheckCartForBackPack(), Throws.TypeOf <NoSuchElementException>());
//        }

//    }


//}

