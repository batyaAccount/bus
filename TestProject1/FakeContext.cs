using busesProject.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class FakeContext: IEmployeeDataContext
    { 
        
        List<employee> data = new List<employee>();
        public List<employee> LoadData()
        {
           
            data.Add(new employee() { Id =2, Name = "rrr",Tz="5456", PhoneNumber = "568" });
            data.Add(new employee() { Id = 1, Name = "rrr", Tz = "5456" ,PhoneNumber="568"});

            return data;
        }

        public bool SaveData(List<employee> data)
        {
            this.data = data;
            return true;
        }
    }
}
