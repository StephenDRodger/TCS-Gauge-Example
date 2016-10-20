using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauge.Example.Implementation.Pages
{
    public class BankingManagerHomePage : BasePage
    {
        public static string ManagerHomePageURL = string.Concat(BaseUrl, "/manager/Managerhomepage.php");

        [FindsBy(How = How.LinkText, Using = "New Customer")]
        public IWebElement btnNewCustomer;

        [FindsBy(How = How.LinkText, Using = "Customised Statement")]
        public IWebElement btnCustomisedStatement;



    }
}
