using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauge.Example.Implementation.Pages
{
    class BankingLogoutPage : BasePage
    {
        public static string ManagerLogoutPageURL = string.Concat(BaseUrl, "/manager/Logout.php");

    }
}

