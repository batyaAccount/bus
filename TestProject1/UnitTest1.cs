using busesProject.Controllers;
using busesProject.Lists;
using busesProject.pages;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    public class UnitTest1
    {
        readonly IEmployeeDataContext _employeeDataContext= new FakeContext();
        [Fact]
        public void Test1()
        {
            int id = -1;
            EmployeesController employee = new EmployeesController(new EmployeeList(new FakeContext()));
            var resualt = employee.Get(id);
            Assert.IsType<BadRequestResult>(resualt.Result);
        }
        [Fact]
        public void Test2()
        {
            string TZ = "2p";
            EmployeesController employee = new EmployeesController(new EmployeeList(new FakeContext()));
            employee e = new employee();
            e.Tz = TZ;
            e.PhoneNumber = "12345";
            var resualt = employee.Post(e);
            Assert.IsType<BadRequestResult>(resualt);
        }
        [Fact]
        public void Test3()
        {
            int id = 88;
            EmployeesController employee = new EmployeesController(new EmployeeList(new FakeContext()));
            employee e = new employee();
            var resualt = employee.Put(id, e);
            Assert.IsType<NotFoundObjectResult>(resualt);
        }
        [Fact]
        public void Test4()
        {
            int id = 88;
            EmployeesController employee = new EmployeesController(new EmployeeList(new FakeContext()));
            var resualt = employee.Delete(id);
            Assert.IsType<NotFoundObjectResult>(resualt);
        }
    }
}