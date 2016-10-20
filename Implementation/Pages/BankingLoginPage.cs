using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauge.Example.Implementation.Pages
{
    public class BankingLoginPage : BasePage
    {
        public static string Url = BaseUrl;

        [FindsBy(How = How.Name, Using = "uid")]
        public IWebElement txtUserID;

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtPassword;

        [FindsBy(How = How.Name, Using = "btnLogin")]
        public IWebElement btnLogin;
    }
}
