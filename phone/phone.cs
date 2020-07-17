using System;
using System.Collections.Generic;
using System.Text;

namespace phone
{
    public abstract class Phone
    {
        private string name;
        private string phonenumber;

        public Phone() { }

        public Phone(string name,string phonenumber) 
        {
            this.name = name;
            this.phonenumber = phonenumber;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Phonenumber
        {
            get => this.phonenumber;
            set => this.phonenumber = value;
        }

        public abstract void InsertPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newPhone);
        public abstract void SearchPhone(string name);
        public abstract void Sort();
        public void Show()

        {
            Console.WriteLine($"name : {Name}  phone : {Phonenumber}");
        }
    }
}
