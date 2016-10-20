using Gauge.CSharp.Lib.Attribute;
using Gauge.Example.Implementation.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauge.Example.Implementation
{
    class createUserSpec
    {
        private CreateUserPage cup = new CreateUserPage();

        [Step("generate users for demo <emailAddress>")]
        public void generateusersfordemo(string emailAddress)
        {
            DriverFactory.Driver.Visit(CreateUserPage.url);

            cup.txtEmail.SendKeys(emailAddress);
            cup.btnSubmit.Click();

        }

        [Step("get the user login details")]
        public void gettheuserlogindetails()
        {
            string usr = cup.userName.Text;
            string psw = cup.userPassword.Text;

            StringBuilder csvcontent = new StringBuilder();
            csvcontent.AppendLine((usr+","+psw).ToString());
            Console.WriteLine(usr);
            Console.WriteLine(psw);
            File.AppendAllText("resources/my_login_users.csv", csvcontent.ToString());


        }

    }
}
