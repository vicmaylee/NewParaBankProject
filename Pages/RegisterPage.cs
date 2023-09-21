namespace NewParaBankProject.Pages
{
    public class RegisterPage
    {
        IWebDriver driver;
        ConfigReader configReader;  
        public RegisterPage(IObjectContainer _objectContainer)
        {
            driver = _objectContainer.Resolve<IWebDriver>(); 
            configReader = _objectContainer.Resolve<ConfigReader>();    
        }

        IWebElement FillForm (string locator) => driver.FindElement(By.Id(locator));
        IWebElement register =>driver.FindElement(By.XPath("//input[@type='submit']"));

        public void FillFormInfo(string fName, string LName, string _address, string _city, string _state, string _zipcode,
            string _phone, string _ssn, string _userName, string _psw, string _confirm)
        {
            FillForm(configReader.GetData("CustomerInfo:firstName")).EnterText(fName);
            FillForm(configReader.GetData("CustomerInfo:lastName")).EnterText(LName);
            FillForm(configReader.GetData("CustomerInfo:street")).EnterText(_address);
            FillForm(configReader.GetData("CustomerInfo:city")).EnterText(_city);
            FillForm(configReader.GetData("CustomerInfo:state")).EnterText(_state);
            FillForm(configReader.GetData("CustomerInfo:zipCode")).EnterText(_zipcode);
            FillForm(configReader.GetData("CustomerInfo:phoneNumber")).EnterText(_phone);
            FillForm(configReader.GetData("CustomerInfo:ssn")).EnterText(_ssn);
            FillForm(configReader.GetData("CustomerInfo:userName")).EnterText(_userName);
            FillForm(configReader.GetData("CustomerInfo:password")).EnterText(_psw);
            FillForm(configReader.GetData("CustomerInfo:confirm")).EnterText(_confirm);
        }
        public void ClickRegister()=>register.ClickElement();
    }
}
