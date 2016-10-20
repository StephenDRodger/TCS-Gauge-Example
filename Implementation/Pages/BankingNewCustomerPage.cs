using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauge.Example.Implementation.Pages
{
    public class BankingNewCustomerPage : BasePage
    {
        public static string NewCustomerURL = string.Concat(BaseUrl, "/manager/addcustomerpage.php");

        [FindsBy(How = How.Name, Using = "name")]
        public IWebElement txtCustomerName;

        [FindsBy(How = How.CssSelector, Using = "#message")]
        public IWebElement lblNameErrorMessage;

        [FindsBy(How = How.Name, Using = "rad1")]
        public IWebElement btnGender;



    }
}
