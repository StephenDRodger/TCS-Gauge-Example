using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauge.Example.Implementation.Pages
{
    public class BankingCustomisedStatementInput : BasePage
    {
        public static string NewCustomerURL = string.Concat(BaseUrl, "/manager/CustomisedStatementInput.php");

        [FindsBy(How = How.Name, Using = "accountno")]
        public IWebElement txtAccountNo;

        [FindsBy(How = How.Id, Using = "message2")]
        public IWebElement lblAccountNoErrorMessage;

        [FindsBy(How = How.Name, Using = "fdate")]
        public IWebElement txtFromDate;

        [FindsBy(How = How.Name, Using = "tdate")]
        public IWebElement txtToDate;

        [FindsBy(How = How.Name, Using = "amountlowerlimit")]
        public IWebElement txtMinimunTransactionValue;

        [FindsBy(How = How.Id, Using = "message12")]
        public IWebElement lblAmountLowerLimitErrorMessage;

        [FindsBy(How = How.Name, Using = "numtransaction")]
        public IWebElement txtNumberOfTransaction;

        [FindsBy(How = How.Id, Using = "message13")]
        public IWebElement lblNumberOfTransactionErrorMessage;

        [FindsBy(How = How.Name, Using = "AccSubmit")]
        public IWebElement btnSubmit;

        [FindsBy(How = How.Name, Using = "res")]
        public IWebElement btnReset;

        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement btnHome;


    }
}
