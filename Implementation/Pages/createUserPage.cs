using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauge.Example.Implementation.Pages
{
    class CreateUserPage : BasePage
    {
        public static string url = BaseUrl;

        [FindsBy(How = How.Name, Using = "emailid")]
        public IWebElement txtEmail;

        [FindsBy(How = How.Name, Using = "btnLogin")]
        public IWebElement btnSubmit;

        [FindsBy(How = How.CssSelector, Using = "body > table > tbody > tr:nth-child(4) > td:nth-child(2)")]
        public IWebElement userName;

        [FindsBy(How = How.CssSelector, Using = "body > table > tbody > tr:nth-child(5) > td:nth-child(2)")]
        public IWebElement userPassword;


        
    }
}
