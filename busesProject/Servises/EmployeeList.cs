using busesProject.pages;

namespace busesProject.Lists
{
    public class EmployeeList
    {
        public List<employee> GetEmployees() { return DataContextManager.DataContext.Employees; }
        public employee getByIdEmployees(int id)
        {
           return DataContextManager.DataContext.Employees.Find(z => z.Id == id);
            
        }
        public bool Add(employee employee)
        {
            if (getByIdEmployees(employee.Id) != null)
                DataContextManager.DataContext.Employees = new List<employee>();
            if (employee.PhoneNumber.Length != 10 || CheckIDNo(employee.Tz))
                return false;
            DataContextManager.DataContext.Employees.Add(employee);
            if (getByIdEmployees(employee.Id).Equals(employee))
            { return true; }
            return false;


        }
        public bool Update(int id, employee employee)
        {
            employee employee1 = DataContextManager.DataContext.Employees.Find(b => b.Id == id);
            if (employee1 == null)
                return false;
            employee1.Address = employee.Address;
            employee1.Id = id;
            employee1.Name = employee.Name;
            employee1.StartDate = employee.StartDate;
            employee1.AmountOfHours = employee.AmountOfHours;
            employee1.PhoneNumber= employee.PhoneNumber;
            employee1.Salary=employee.Salary;
            employee1.Tz=employee.Tz;
            employee1.WorkType= employee.WorkType;
            return true;

        }
        public bool DeleteEmployees(int id)
        {

            if (getByIdEmployees(id) != null)
                return DataContextManager.DataContext.Employees.Remove(getByIdEmployees(id));
            return false;
        }
        public List<employee> GetByTypeWork(workingType type)
        {
            return DataContextManager.DataContext.Employees.FindAll(b => b.WorkType == type);
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
