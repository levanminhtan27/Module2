using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace phone
{
    public class PhoneBook : Phone
    {
        PhoneBook[] PhoneList = new PhoneBook[0];
        public PhoneBook() { }

        

        public PhoneBook(string newname, string newphonenumber) : base(newname, newphonenumber)
        {

        }

        public override void InsertPhone(string name, string phone)
        {
            int index = FindPhone(name);
            // neu khong co ten trong danh ba;
            if (index == -1)
            {
                PhoneBook phoneBook = new PhoneBook(name,phone);
                Array.Resize(ref PhoneList,PhoneList.Length+1);
                PhoneList[PhoneList.Length - 1] = phoneBook;
            }
            //neu co ten trong danh ba thi so sanh sdt co bang nhau ko
            //neu bang nhau thi khong lam gi them
            //neu khac nhau thi noi 2 so dien thoai lai
            else if (index != -1)
            {
                if (PhoneList[index].Phonenumber != phone)
                {
                    PhoneList[index].Phonenumber = $"{PhoneList[index].Phonenumber} : {phone}";
                }
            }

        }


        //kiem tra xem ten ng dung da co trong danh ba chua
        private int FindPhone(string name)
        {
            for (int i=0;i<PhoneList.Length;i++)
            {
                if (PhoneList[i].Name==name)
                {
                    return i;
                }
            }

            return -1;
        }

        public override void RemovePhone(string name)

        {
            int vitri = FindPhone(name);
            if (vitri != -1)
            {
                for (int i = vitri; i < PhoneList.Length - 1; i++)
                {
                    PhoneList[i] = PhoneList[i + 1];
                }
                Array.Resize(ref PhoneList, PhoneList.Length - 1);
            }
            else
            {
                Console.WriteLine($"name : {name} khong tim thay");
            }
        }
       
        // tìm kiếm
        public override void SearchPhone(string name)
        {
            int vitri = FindPhone(name);
            if (vitri!=-1)
            {
                PhoneList[vitri].Show();
            }
            else
            {
                Console.WriteLine("not found");
            }
        
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            int vitri = FindPhone(name);
           if (vitri != -1)
            {
                PhoneList[vitri].Phonenumber = newPhone;
            }
           else
            {
                Console.WriteLine($"ten khong tim thay {FindPhone(Name)}");
            }
        }

        public void viewPhone()
        {
            foreach (PhoneBook item in PhoneList)
            {
                item.Show();
            }
        }

        public override void Sort()
        {
        }
    }
}
