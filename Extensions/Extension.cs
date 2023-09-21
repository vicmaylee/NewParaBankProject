namespace NewParaBankProject.Extensions
{
    public static class Extension
    {
        /// <summary>
        /// This Method Clicks an Element
        /// </summary>
        /// <param name="element"></param>
        public static void ClickElement(this IWebElement element) => element.Click();

        /// <summary>
        /// This Method Enter text in a text field
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value) =>
            element.SendKeys(value);
        /// <summary>
        /// This Method Selects From DropDown
        /// </summary>
        /// <param name="element"></param>
        /// <param name="text"></param>
        /// 


        public static void SelectByText(IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }
        /// <summary>
        /// This Method Selects from a dropdown by Index
        /// </summary>
        /// <param name="element"></param>
        /// <param name="index"></param>
        public static void SelectByIndex(IWebElement element, int index)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(index);
        }
        /// <summary>
        /// This method selects from dropdown by Value
        /// </summary>
        /// <param name="element"></param>
        /// <param name="text"></param>
        public static void SelectByValue(IWebElement element, string text)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(text);
        }

        public class CustomExtension2
        {
            /// <summary>
            /// This is a wait Method
            /// </summary>
            /// <param name="driver"></param>
            /// <param name="locator"></param>
            /// <returns></returns>
            public static IWebElement FindMyElementWait(IWebDriver driver, By locator)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                return wait.Until(x => x.FindElement(locator));
            }
        }
    }
}
