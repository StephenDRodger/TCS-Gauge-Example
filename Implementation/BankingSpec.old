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
    public class BankingSpec
    {
        private readonly BankingLoginPage _bankingLoginPage = new BankingLoginPage();
        private readonly BankingManagerHomePage _bankingManagerHomePage = new BankingManagerHomePage();
        private readonly BankingNewCustomerPage _bankingNewCustomerPage = new BankingNewCustomerPage();

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

        [Step("Click on the New Customer button")]
        public void ClickontheNewCustomerbutton()
        {
            _bankingManagerHomePage.btnNewCustomer.Click();
        }

        [Step("Enter blank as Customer Name")]
        public void EnterblankasCustomerName()
        {
            _bankingNewCustomerPage.txtCustomerName.SendKeys(Keys.Tab);
        }

        [Step("Enter space as Customer Name")]
        public void EnterspaceasCustomerName()
        {
            _bankingNewCustomerPage.txtCustomerName.SendKeys(" ");
        }

        [Step("Check for error message <ErrorMessage>")]
        public void Checkforerrormessage(string ErrorMessage)
        {
            GaugeMessages.WriteMessage("Checking for error messages");

            string errorMessage = _bankingNewCustomerPage.lblNameErrorMessage.Text;

            Assert.AreEqual(ErrorMessage, errorMessage);
        }

        [Step("click ok on the alert box")]
        public void clickokonthealertbox()
        {
            try
            {
                IAlert alert = DriverFactory.Driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Data);
            }

        }
    }
}
