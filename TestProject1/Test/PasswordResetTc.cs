using NUnit.Framework;
using TestProject1.Pageobjects;
using TestProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Test
{

    public class PasswordResetTest : Base
    {
        [Test]
        public void userPassReset()
        {
            Loginpage loginpage = new Loginpage(getDriver());
            loginpage.ValidLogin("Admin", "admin123");
            PasswordReset pr = new PasswordReset(getDriver());
            pr.passwordReset("josh1997", "LKJname@8979143", "LKJname@8979143");
            loginpage.ValidLogin("josh1997", "LKJname@8979143");

        }

    }
}