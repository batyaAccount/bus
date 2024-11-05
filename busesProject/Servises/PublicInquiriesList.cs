using busesProject.pages;

namespace busesProject.Lists
{
    public class PublicInquiriesList
    {
        public List<PublicInquiries> GetInq() { return DataContextManager.DataContext.PublicInquiries; }
        public PublicInquiries getByIdInq(int id)
        {
            return DataContextManager.DataContext.PublicInquiries.Find(z => z.Id == id);

        }
        public bool Add(PublicInquiries publicInquiry)
        {
            if (getByIdInq(publicInquiry.Id) != null)
                DataContextManager.DataContext.PublicInquiries = new List<PublicInquiries>();
            if (publicInquiry.PhoneNumber.Length != 10)
                return false;
            DataContextManager.DataContext.PublicInquiries.Add(publicInquiry);
            if (getByIdInq(publicInquiry.Id).Equals(publicInquiry))
            { return true; }
            return false;


        }
        public bool Update(int id, PublicInquiries publicInquiry)
        {
            PublicInquiries inquiries = DataContextManager.DataContext.PublicInquiries.Find(b => b.Id == id);
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
        public bool DeleteInq(int id)
        {
            if (getByIdInq(id) != null)
                return DataContextManager.DataContext.PublicInquiries.Remove(getByIdInq(id));
            return false;

        }
        public bool DeleteByDate(DateTime date)
        {
            bool flag = false;
            for (int i = 0; i < DataContextManager.DataContext.PublicInquiries.Count; i++)
            {
                if (DataContextManager.DataContext.PublicInquiries.ElementAt(i).Date.CompareTo(date) < 0)
                {
                    DataContextManager.DataContext.PublicInquiries.Remove(DataContextManager.DataContext.PublicInquiries.ElementAt(i));
                    flag = true;
                }
            }
            return flag;

        }

    }
}
