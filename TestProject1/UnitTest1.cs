using busesProject.Controllers;
using busesProject.Lists;
using busesProject.pages;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int id = 1;
            EmployeesController employee = new EmployeesController();
            var resualt = employee.Get(id);
            Assert.IsType<NotFoundResult>(resualt);
        }
        [Fact]
        public void Test2()
        {
            string TZ = "2p";
            EmployeesController employee = new EmployeesController();
            employee e = new employee();
            e.Tz = TZ;
            var resualt = employee.Post(e);
            Assert.IsType<BadRequestResult>(resualt);
        }
        [Fact]
        public void Test3()
        {
            int id = 1;
            EmployeesController employee = new EmployeesController();
            employee e = new employee();
            var resualt = employee.Put(id,e);
            Assert.IsType<NotFoundResult>(resualt);
        }
        [Fact]
        public void Test4()
        {
            int id = 1;
            EmployeesController employee = new EmployeesController();
            var resualt = employee.Delete(id);
            Assert.IsType<NotFoundResult>(resualt);
        }
    }
}