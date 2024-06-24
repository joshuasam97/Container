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
    public class AddNewUser : Base
    {

        [Test]
        public void admin()
        {
            Loginpage loginpage = new Loginpage(getDriver());
            loginpage.ValidLogin("Admin", "admin123");
            HomePage hm = new HomePage(getDriver());
            bool dashboard = hm.dashbord.Displayed;
            TestContext.WriteLine("Dashboard " + dashboard);
            Assert.That(dashboard, Is.True, "Dashboard");
            hm.getAdminTab().Click();
            hm.getAddButton().Click();
            hm.SelectUserRole("Admin");
            hm.employeenamefield("jo");
            Thread.Sleep(5000);
            hm.selectFirstSuggestion();
            hm.Statusdropdown("Enabled");
            hm.userPassSave("josh1997", "Joshua@1910", "Joshua@1910");
            //bool uservalidate = hm.validateUser.Displayed;
            //TestContext.WriteLine("josh1997" + uservalidate);
            //Assert.AreEqual(true, uservalidate);

        }
    }
}