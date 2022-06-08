using System.Text;


namespace Course.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDay)
        {
            Name = name;
            Email = email;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(':');
            sb.Append(Email);
            sb.Append(':');
            sb.Append(BirthDay.ToString("dd/MM/yyyy"));
            return sb.ToString();
        }
    }
}
