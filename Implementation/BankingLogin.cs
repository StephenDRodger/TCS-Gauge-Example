using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Gauge.Example.Implementation.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Gauge.Example.Implementation
{
    public class BankingLogin
    {
        private readonly BankingLoginPage _bankingLoginPage = new BankingLoginPage();
        private readonly BankingManagerHomePage _bankingManagerHomePage = new BankingManagerHomePage();

        [Step("Log into banking app as a Manager <UserName> <Password>")]
        public void LogintobankingappasaManager(string UserName, string Password)
        {
            DriverFactory.Driver.Visit(BankingLoginPage.Url);

            _bankingLoginPage.txtUserID.Clear();
            _bankingLoginPage.txtUserID.SendKeys(UserName);

            _bankingLoginPage.txtPassword.Clear();
            _bankingLoginPage.txtPassword.SendKeys(Password);

            _bankingLoginPage.btnLogin.Click();
        }

    }
}
