using busesProject.pages;

namespace busesProject.Lists
{
    public class EmployeeList
    {
        public static List<employee> employees { get; set; } = new List<employee>();
        public List<employee> GetEmployees() { return employees; }
        public employee getById(int id)
        {
            return employees.Find(z => z.Id == id);

        }
        public bool post(employee employee)
        {
            if (getById(employee.Id) != null)
            {
                return false;
            }
            employees.Add(employee);
            if (getById(employee.Id).Equals(employee))
            { return true; }
            return false;


        }
        public bool put(int id, employee employee)
        {
            employee employee1 = employees.Find(b => b.Id == id);
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
        public bool delete(int id)
        {

            if (getById(id) != null)
                return employees.Remove(getById(id));
            return false;
        }
        public List<employee> GetByTypeWork(workingType type)
        {
            return employees.FindAll(b => b.WorkType == type);
        }
    }
}
