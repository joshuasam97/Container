using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Pageobjects;
using TestProject1.Utilities;

namespace TestProject1.Test
{
    public class DeleteUsertc : Base
    {
        [Test]
        public void DeleteUser()
        {
            Loginpage loginpage = new Loginpage(getDriver());
            loginpage.ValidLogin("Admin", "admin123");
            DeleteUser dl = new DeleteUser(getDriver());
            dl.UserDelete("Admin1");
        }
    }
}
