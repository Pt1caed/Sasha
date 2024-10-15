using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Employee : Creature
    {
        private string full_name;
        private string name;
        private DateOnly date_birthday;
        private string home_phone_number;
        private string phone_number;
        private string mail;
        private string job_title;
        private string job_description;

        public Employee(string full_name, string name, int year, int month, int day, string home_phone_number, string phone_number, string mail, string job_title, string job_description)
        {
            this.full_name = full_name;
            this.name = name;
            this.date_birthday = new DateOnly(year, month, day);
            this.home_phone_number = home_phone_number;
            this.phone_number = phone_number;
            this.mail = mail;
            this.job_title = job_title;
            this.job_description = job_description;
        }
        public Employee()
        {
            this.full_name = "N/A";
            this.name = "N/A";
            this.date_birthday = new DateOnly();
            this.home_phone_number = "N/A";
            this.phone_number = "N/A";
            this.mail = "N/A";
            this.job_title = "N/A";
            this.job_description = "N/A";
        }

        public string GetFullName()
        { return this.full_name; }
        public string GetName()
        {  return this.name; }
        public DateOnly GetDateBirthday()
        { return this.date_birthday; }
        public string GetHomePhoneNumber() 
        { return this.home_phone_number; }
        public string GetPhoneNumber()
        { return this.phone_number; }
        public string GetMail()
        { return this.mail; }
        public string GetJobTitle()
        { return this.job_title; }
        public string GetJobDescription()
        { return this.job_description; }

        public void SetFullName(string fullName)
        { this.full_name = fullName; }
        public void SetName(string name) 
        { this.name = name; }
        public void SetBirthDay(int year, int month, int day)
        { date_birthday = new DateOnly(year, month, day); }
        public void SetHomePhoneNumber(string phoneNumber)
        { home_phone_number = phoneNumber; }
        public void SetPhoneNumber(string phoneNumber)
        { this.phone_number = phoneNumber; }
        public void SetMail(string mail)
        { this.mail = mail; }
        public void SetJobTitle(string jobTitle)
        { this.job_title = jobTitle; }
        public void SetJobDescription(string jobDescription)
        { this.job_description = jobDescription; }


        public override void Info()
        {
            Console.WriteLine("Full name: " + full_name);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Birthday: " + date_birthday.ToString());
            Console.WriteLine("Home phone number: " + home_phone_number);
            Console.WriteLine("Phone number: " + phone_number);
            Console.WriteLine("Mail: " + mail);
            Console.WriteLine("Job title: " + job_title);
            Console.WriteLine("Job description: " + job_description);
            Console.WriteLine();
        }
    }
}
