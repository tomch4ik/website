using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace website
{
    internal class Magazine
    {
        static void Main(string[] args)
        {
            magazine site = new magazine
            {
                Name = "Forbes",
                Birthyear = 2007,
                Description = "description",
                PhoneNumber = 557328347,
                Email = "forbes_UA@gmail.com"
            };
            Console.WriteLine(site.ToString());
        }
    }
    public class magazine
    {
        private string name { get; set; }
        private int yearBirth { get; set; }
        private string description { get; set; }
        private int phonenumber { get; set; }
        private string email { get; set; }

        public magazine() { }
        public magazine(string name, int yearBirth, string description, int phonenumber, string email)
        {
            Name = name;
            Birthyear = yearBirth;
            Description = description;
            PhoneNumber = phonenumber;
            Email = email;
        }
        public override string ToString()
        {
            return $"Название журнала: {Name}\nГод основания: {Birthyear}\nОписание журнала: {Description}\n" +
                $"Номер телефона: {PhoneNumber}\nE-mail: {Email}";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Birthyear
        {
            get { return yearBirth; }
            set
            {
                yearBirth = value;
            }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int PhoneNumber
        {
            get { return phonenumber; }
            set
            {
                phonenumber = value;
            }
        }
        public string Email
        {
            get { return email; }
            set {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Email должен содержать символ <@>.");
                }
            }
        }
    }
}
