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
    public class TCSCustomisedStatement
    {
        private readonly BankingLoginPage _bankingLoginPage = new BankingLoginPage();
        private readonly BankingManagerHomePage _bankingManagerHomePage = new BankingManagerHomePage();
        private readonly BankingCustomisedStatementInput _bankingCustomisedStatementPage = new BankingCustomisedStatementInput();


        [Step("Click on the Customised Statement button")]
        public void ClickontheCustomisedStatementbutton()
        {
            _bankingManagerHomePage.btnCustomisedStatement.Click();
        }

        // Verify Account No Field: CS1 - CS5
        /*
         * The below code can be refactured quite a bit.   
         * Steps can get reused by passing in the correct Web Element Flield to correspond with the 
         * BankingCustomisedStatementInput.cs page. Will look into this.
         * My "not so elegant" solution was to name each step with the test feild's name, eg. 
         * "Account No Do not enter...."
         * 
         */

        // CS1
        [Step("Account No Do not enter a value in Account number Field")]
        public void AccountNoDonotenteravalueinAccountnumberField()
        {
            _bankingCustomisedStatementPage.txtAccountNo.Clear();
            _bankingCustomisedStatementPage.txtAccountNo.SendKeys(Keys.Tab);
        }

        //CS2
        [Step("Account No Enter numeric value in Account number Field <TestData>")]
        public void AccountNoEnternumericvalueinAccountnumberField(string TestData)

        {
            _bankingCustomisedStatementPage.txtAccountNo.Clear();
            _bankingCustomisedStatementPage.txtAccountNo.SendKeys(TestData);

        }

        //CS3
        [Step("Account No Enter Special Character In Account number Field <TestData>")]
        public void AccountNoEnterSpecialCharacterInAccountnumberField(string TestData)

        {
            _bankingCustomisedStatementPage.txtAccountNo.Clear();
            _bankingCustomisedStatementPage.txtAccountNo.SendKeys(TestData);

        }

        //CS4
        [Step("Account No Account no cannot have Blank space <TestData>")]
        public void AccountNoAccountnocannothaveBlankspace(string TestData)

        {
            _bankingCustomisedStatementPage.txtAccountNo.Clear();
            _bankingCustomisedStatementPage.txtAccountNo.SendKeys(TestData);

        }

        //CS5
        [Step("Account No Enter first character space <TestData>")]
        public void AccountNoEnterfirstcharacterspace(string TestData)

        {
            _bankingCustomisedStatementPage.txtAccountNo.Clear();
            _bankingCustomisedStatementPage.txtAccountNo.SendKeys(TestData);

        }

        //Verify Amount lower limit: CS6 - CS10
        //All the code below to be refactured
        //CS6
        [Step("Amount lower limit Do not enter a value in Amount Field")]
        public void AmountlowerlimitDonotenteravalueinAmountField()
        {
            _bankingCustomisedStatementPage.txtMinimunTransactionValue.Clear();
            _bankingCustomisedStatementPage.txtMinimunTransactionValue.SendKeys(Keys.Tab);
        }

        //CS7
        [Step("Amount lower limit Enter numeric value in Amount Lower Limit number Field <TestData>")]
        public void AmountlowerlimitEnternumericvalueinAmountLowerLimitnumberField(string TestData)

        {
            _bankingCustomisedStatementPage.txtMinimunTransactionValue.Clear();
            _bankingCustomisedStatementPage.txtMinimunTransactionValue.SendKeys(TestData);

        }

        //CS8
        [Step("Amount lower limit Enter Special Character In Amount Field <TestData>")]
        public void AmountlowerlimitEnterSpecialCharacterInAmountField(string TestData)

        {
            _bankingCustomisedStatementPage.txtMinimunTransactionValue.Clear();
            _bankingCustomisedStatementPage.txtMinimunTransactionValue.SendKeys(TestData);

        }


        //CS9
        [Step("Amount lower limit Amount no cannot have Blank space <TestData>")]
        public void AmountlowerlimitAmountnocannothaveBlankspace(string TestData)

        {
            _bankingCustomisedStatementPage.txtMinimunTransactionValue.Clear();
            _bankingCustomisedStatementPage.txtMinimunTransactionValue.SendKeys(TestData);

        }

        //CS10
        [Step("Amount lower limit Enter first character space <TestData>")]
        public void AmountlowerlimitEnterfirstcharacterspace(string TestData)

        {
            _bankingCustomisedStatementPage.txtMinimunTransactionValue.Clear();
            _bankingCustomisedStatementPage.txtMinimunTransactionValue.SendKeys(TestData);

        }


        //Verify Number of Transaction: CS11 - CS15
        //Below code to be refactured
        //CS11
        [Step("Number of Transaction Do not enter a value in Number of Transaction Field")]
        public void NumberofTransactionDonotenteravalueinNumberofTransactionField()
        {
            _bankingCustomisedStatementPage.txtNumberOfTransaction.Clear();
            _bankingCustomisedStatementPage.txtNumberOfTransaction.SendKeys(Keys.Tab);
        }

        //CS12
        [Step("Number of Transaction Enter character value in Number of Transaction number Field <TestData>")]
        public void NumberofTransactionEntercharactervalueinNumberofTransactionnumberField(string TestData)
        {
            _bankingCustomisedStatementPage.txtNumberOfTransaction.Clear();
            _bankingCustomisedStatementPage.txtNumberOfTransaction.SendKeys(TestData);
        }

        //CS13
        [Step("Number of Transaction Enter Special Character In Number for Transaction Field <TestData>")]
        public void NumberofTransactionEnterSpecialCharacterInNumberforTransactionField(string TestData)
        {
            _bankingCustomisedStatementPage.txtNumberOfTransaction.Clear();
            _bankingCustomisedStatementPage.txtNumberOfTransaction.SendKeys(TestData);
        }

        //CS14
        [Step("Number of Transaction Number of transaction cannot have Blank space <TestData>")]
        public void NumberofTransactionNumberoftransactioncannothaveBlankspace(string TestData)
        {
            _bankingCustomisedStatementPage.txtNumberOfTransaction.Clear();
            _bankingCustomisedStatementPage.txtNumberOfTransaction.SendKeys(TestData);
        }

        //CS15
        [Step("Number of Transaction Enter first character space <TestData>")]
        public void NumberofTransactionEnterfirstcharacterspace(string TestData)
        {
            _bankingCustomisedStatementPage.txtNumberOfTransaction.Clear();
            _bankingCustomisedStatementPage.txtNumberOfTransaction.SendKeys(TestData);
        }

        
        /*
         * As with the above code, I used a "not so elegant" solution to get the different Error messages to compare them  
         * with the expected error messages. So I seperated them into the field names. This must also be fixed to use 
         * one "Step" and pass in different values.
        */
        

        //Error Messages for CS1 - CS5 (Account No field)
        [Step("An AccountNo error message <ExpectedErrorMessage> must be shown")]
        public void AnAccountNoerrormessagemustbeshown(string ExpectedErrorMessage)
        {
            GaugeMessages.WriteMessage("Checking for error messages");

            string ReturnedErrorMessage = _bankingCustomisedStatementPage.lblAccountNoErrorMessage.Text;


            Assert.AreEqual(ExpectedErrorMessage, ReturnedErrorMessage);
        }

        //Error Messages for CS6 - CS10 (Minimun Transaction Value field)
        [Step("An AmountLowerLimit error message <ExpectedErrorMessage> must be shown")]
        public void AnAmountLowerLimiterrormessagemustbeshown(string ExpectedErrorMessage)
        {
            GaugeMessages.WriteMessage("Checking for error messages");

            string ReturnedErrorMessage = _bankingCustomisedStatementPage.lblAmountLowerLimitErrorMessage.Text;


            Assert.AreEqual(ExpectedErrorMessage, ReturnedErrorMessage);
        }

        //Error Messages for CS11 - CS15 (Number of Transaction field)
        [Step("An NumberofTransaction error message <ExpectedErrorMessage> must be shown")]
        public void AnNumberofTransactionerrormessagemustbeshown(string ExpectedErrorMessage)
        {
            GaugeMessages.WriteMessage("Checking for error messages");

            string ReturnedErrorMessage = _bankingCustomisedStatementPage.lblNumberOfTransactionErrorMessage.Text;


            Assert.AreEqual(ExpectedErrorMessage, ReturnedErrorMessage);
        }


    }
}
