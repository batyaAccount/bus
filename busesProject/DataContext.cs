using busesProject.pages;

namespace busesProject
{
    public class DataContext
    {
        public List<bus> Buses { get; set; } = new List<bus>();
        public List<employee> Employees { get; set; } = new List<employee>();
        public List<PublicInquiries> PublicInquiries { get; set; } = new List<PublicInquiries>();
        public List<Station> Stations { get; set; } = new List<Station>();
        public List<route> Routes { get; set; } = new List<route>();
    }
}
