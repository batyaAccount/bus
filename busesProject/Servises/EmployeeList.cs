using busesProject.pages;

namespace busesProject.Lists
{
    public class EmployeeList
    {
        public readonly IEmployeeDataContext _employeeDataContext;
        public EmployeeList(IEmployeeDataContext iEmployeeDataContext)
        {
            _employeeDataContext = iEmployeeDataContext;
        }
        public List<employee> GetEmployees() { return _employeeDataContext.LoadData(); }
        public employee getByIdEmployees(int id)
        {
            return _employeeDataContext.LoadData().Find(z => z.Id == id);

        }
        public bool Add(employee employee)
        {
            List<employee> l = _employeeDataContext.LoadData();
            if (getByIdEmployees(employee.Id) != null)
            {
                return false;
            }
            if (l == null)
                return false;
            l.Add(employee);
            if (employee.PhoneNumber.Length != 10 || CheckIDNo(employee.Tz) == false)
                return false;
            _employeeDataContext.SaveData(l);
            if (getByIdEmployees(employee.Id) != null)
            { return true; }
            return false;


        }


        public bool Update(int id, employee employee)
        {
            employee employee1 = _employeeDataContext.LoadData().Find(b => b.Id == id);
            if (employee1 == null)
                return false;
            DeleteEmployees(id);
            employee1.Address = employee.Address;
            employee1.Id = id;
            employee1.Name = employee.Name;
            employee1.StartDate = employee.StartDate;
            employee1.AmountOfHours = employee.AmountOfHours;
            employee1.PhoneNumber = employee.PhoneNumber;
            employee1.Salary = employee.Salary;
            employee1.Tz = employee.Tz;
            employee1.WorkType = employee.WorkType;
            if (Add(employee1))
                return true;
            return false;

        }

        public bool DeleteEmployees(int id)
        {

            if (getByIdEmployees(id) != null)
            {
                List<employee> l = _employeeDataContext.LoadData();
                l.Remove(getByIdEmployees(id));
                _employeeDataContext.SaveData(l);
                return true;

            }
            return false;
        }
        public List<employee> GetByTypeWork(string type)
        {
            return _employeeDataContext.LoadData().FindAll(b => b.WorkType == type);
        }
        static bool CheckIDNo(string strID)
        {
            int[] id_12_digits = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int count = 0;

            if (strID == null)
                return false;

            strID = strID.PadLeft(9, '0');

            for (int i = 0; i < 9; i++)
            {
                int num = Int32.Parse(strID.Substring(i, 1)) * id_12_digits[i];

                if (num > 9)
                    num = (num / 10) + (num % 10);

                count += num;
            }

            return (count % 10 == 0);
        }
    }
}
