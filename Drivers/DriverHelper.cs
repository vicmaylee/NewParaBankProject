namespace NewParaBankProject.Drivers
{
    public class DriverHelper
    {
        public IWebDriver? driver;
        public IObjectContainer? container;
        ConfigReader configReader = new ConfigReader(); 
        public enum bType
        { Chrome, Edge, Firefox}

        public IWebDriver InitialiseBrowser(bType _browserName) => _browserName switch
        {
            bType.Chrome => driver = GetChromeCofig(),
            bType.Edge => driver = GetEdgeConfig(),
            bType.Firefox => driver = GetFirefoxConfig(),
            _ => throw new Exception("Browser Not Supported")
        };

        public IWebDriver GetChromeCofig()
        {
           new DriverManager().SetUpDriver(new ChromeConfig());
            var options = new ChromeOptions();
            options.AddArguments(configReader.GetData("option:max"),configReader.GetData("option:incog"));
            options.AddArguments("--no-sandbox");
            options.AddArguments("--disable-dev-shm-usage");
            options.AddArgument("--headless");
           driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(configReader.GetData("Env:url"));
            return driver;  
        }
        public IWebDriver GetEdgeConfig()
        {
            new DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }

        public IWebDriver GetFirefoxConfig()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }

        public void QuitBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
            }
            driver = null;
        }
    }
}
