using OpenQA.Selenium.Firefox;

namespace SL_TestAutomationFramework.lib.driver_config
{
    public class FirefoxDriver
    {
        private FirefoxOptions options;

        public FirefoxDriver(FirefoxOptions options)
        {
            this.options = options;
        }
    }
}