namespace busesProject.pages
{
    public enum workingType { driver,officeEmployee, cleaner}
    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tz { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkType { get; set; }
        public int AmountOfHours { get; set; }
        public int Salary { get; set; }
        public DateTime StartDate { get; set; }

        public employee(int id, string name, string tz, string address, string phoneNumber, string workerType, int amountOfHours, int salary, DateTime startDate)
        {
            this.Id = id;
            this.Name = name;
            this.Tz = tz;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.WorkType = workerType;
            this.AmountOfHours = amountOfHours;
            this.Salary = salary;
            this.StartDate = startDate;
        }
        public employee()
        {
        }
    }
}
