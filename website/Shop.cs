using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace website
{
    internal class Shop
    {
        static void Main(string[] args)
        {
            shop site = new shop
            {
                Name = "Guchi",
                Adress = "г.Одесса, Садовая 3",
                Description = "description",
                PhoneNumber = 557328347,
                Email = "guchi_UA@gmail.com"
            };
            Console.WriteLine(site.ToString());
        }
    }
    public class shop
    {
        private string name { get; set; }
        private string adress { get; set; }
        private string description { get; set; }
        private int phonenumber { get; set; }
        private string email { get; set; }

        public shop() { }
        public shop(string name, string adress, string description, int phonenumber, string email)
        {
            Name = name;
            Adress = adress;
            Description = description;
            PhoneNumber = phonenumber;
            Email = email;
        }
        public override string ToString()
        {
            return $"Название магазина: {Name}\nАдресс: {Adress}\nОписание магазина: {Description}\n" +
                $"Номер телефона: {PhoneNumber}\nE-mail: {Email}";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Adress
        {
            get { return adress; }
            set
            {
                adress = value;
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
            set
            {
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
