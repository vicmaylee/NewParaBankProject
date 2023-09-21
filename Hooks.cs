namespace NewParaBankProject
{
    [Binding]
    public sealed class Hooks : DriverHelper 
    {
        public Hooks(IObjectContainer _objectContainer)
        {
            container = _objectContainer;    
        }

        [BeforeScenario()]
        public void FirstBeforeScenario()
        {
            InitialiseBrowser(bType.Chrome);
            container.RegisterInstanceAs(driver); 
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //QuitBrowser();
        }
    }
}