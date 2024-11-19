namespace busesProject.pages
{
    public interface IEmployeeDataContext
    {
        public List<employee> LoadData();
        public bool SaveData(List<employee> data);
    }
}
