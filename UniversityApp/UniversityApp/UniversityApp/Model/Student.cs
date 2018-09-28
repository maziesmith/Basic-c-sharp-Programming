namespace UniversityApp.Model
{
    public class Student
    {
        public string Address { get; set; }
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string RegNo { get; set; }
        

        public Student(string name, string email, string phone, string regNo)
        {
            Name = name;
            Email = email;
            Phone = phone;
            RegNo = regNo;
        }

        public Student()
        {
            
        }
    }
}