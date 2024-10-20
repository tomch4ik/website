using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace website
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Website site = new Website
            {
                Name = "Wikipedia",
                Url = "https://wikipedia.com",
                Description = "description",
                Ip = "111.11.11.1"
            };
            Console.WriteLine(site.ToString());
        }
    }
    public class Website
    {
        private string name { get; set; }
        private string url { get; set; }
        private string description { get; set; }
        private string ip { get; set; }

        public Website() { }
        public Website(string name, string url, string description, string ip)
        {
            Name = name;
            Url = url;
            Description = description;
            Ip = ip;
        }
        public override string ToString()
        {
            return $"Название сайта: {Name}\nПуть к сайту: {Url}\nОписание сайта: {Description}\nIP-адрес сайта: {Ip}";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Url
        {
            get { return url; }
            set
            {
                if (value.StartsWith("http://") || value.StartsWith("https://"))
                {
                    url = value;
                }
                else
                {
                    throw new ArgumentException("URL должен начинаться с http:// или https://");
                }
            }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Ip
        {
            get { return ip; }
            set
            {
                if (value.Length >= 7 && value.Length <= 15)
                {
                    ip = value;
                }
                else
                {
                    throw new ArgumentException("IP-адрес должен быть длиной от 7 до 15 символов.");
                }
            }
        }
       
    }
}

