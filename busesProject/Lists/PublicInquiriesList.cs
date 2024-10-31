using busesProject.pages;

namespace busesProject.Lists
{
    public class PublicInquiriesList
    {
        public static List<PublicInquiries> publicInquiries { get; set; } = new List<PublicInquiries>();
        public List<PublicInquiries> Get() { return publicInquiries; }
        public PublicInquiries getById(int id)
        {
            return publicInquiries.Find(z => z.Id == id);

        }
        public bool post(PublicInquiries publicInquiry)
        {
            if (getById(publicInquiry.Id) != null)
            {
                return false;
            }
            publicInquiries.Add(publicInquiry);
            if (getById(publicInquiry.Id).Equals(publicInquiry))
            { return true; }
            return false;


        }
        public bool put(int id, PublicInquiries publicInquiry)
        {
            PublicInquiries inquiries = publicInquiries.Find(b => b.Id == id);
            if (inquiries == null)
                return false;
            inquiries.Id = publicInquiry.Id;
            inquiries.Driver = publicInquiry.Driver;
            inquiries.Date = publicInquiry.Date;
            inquiries.Description = publicInquiry.Description;
            inquiries.CaredBy = publicInquiry.CaredBy;
            inquiries.Cared = publicInquiry.Cared;
            inquiries.ComplainerName = publicInquiry.ComplainerName;
            inquiries.PhoneNumber = publicInquiry.PhoneNumber;
            return true;

        }
        public bool delete(int id)
        {
            if (getById(id) != null)
                return publicInquiries.Remove(getById(id));
            return false;

        }
        public bool deleteByDate(DateTime date)
        {
            bool flag = false;
            for (int i = 0; i < publicInquiries.Count; i++)
            {
                if (publicInquiries.ElementAt(i).Date.CompareTo(date) < 0)
                { 
                    publicInquiries.Remove(publicInquiries.ElementAt(i));
                    flag = true;
                }
            }
            return flag;

        }

    }
}
