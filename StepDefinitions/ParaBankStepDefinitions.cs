using NewParaBankProject.Extensions;
using NewParaBankProject.Pages;

namespace NewParaBankProject.StepDefinitions
{
    [Binding]
    public class ParaBankStepDefinitions
    {
        RegisterPage registerPage;
        private IWebDriver driver;
        public ParaBankStepDefinitions(IObjectContainer _objectContainer)
        {
            driver = _objectContainer.Resolve<IWebDriver>();
            registerPage = _objectContainer.Resolve<RegisterPage>();    
        }
        [Given(@"I'm on Parabank signUp page")]
        public void GivenImOnParabankSignUpPage()
        {
            Assert.IsTrue(driver.Url.Contains("register"));
        }

        [When(@"I enter the following details")]
        public void WhenIEnterTheFollowingDetails(Table table)
        {
            registerPage.FillFormInfo(table.Rows[0]["firstName"/*.AddRandomDigits()*/], table.Rows[0]["lastName"/*.AddRandomDigits()*/],
                table.Rows[0]["address"], table.Rows[0]["city"], table.Rows[0]["state"], table.Rows[0]["zipCode"],
                table.Rows[0]["phone"], table.Rows[0]["ssn"], table.Rows[0]["userName"/*.AddRandomDigits()*/], table.Rows[0]["password"],
                table.Rows[0]["confirm"]);
        }
        
        [When(@"I click Register")]
        public void WhenIClickRegister()
        {
            registerPage.ClickRegister();   
        }

        [Then(@"my account is created successfully")]
        public void ThenMyAccountIsCreatedSuccessfully()
        {
           
        }
    }
}
