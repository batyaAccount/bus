using System.Text.Json;
namespace busesProject.pages
{
    public class EmployeeDataContext: IEmployeeDataContext
    {
        public List<employee> LoadData()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "EmployeeData.json");

                string jsonString = File.ReadAllText(path);
                var emp = JsonSerializer.Deserialize<List<employee>>(jsonString);

                if (emp == null) { return null; }

                return emp;
            }
            catch
            {
                return null;
            }
        }

        public bool SaveData(List<employee> data)
        {
           
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "EmployeeData.json");

                string jsonString = JsonSerializer.Serialize<List<employee>>(data);

                File.WriteAllText(path, jsonString);
                return true;
            }
            catch { return false; }
        }
    }
}
