using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp59
{
    internal class Student
    {
        public Student(string fullname,string groupNo,int age)
        {
            this.GroupNo = groupNo;
            this.Fullname = fullname;

        }
        private string _fullname;
        private string _groupNo;
        
        public string GroupNo
        {
            get => this._groupNo;
            set
            {
                if (CheckGroupNo(value))
                    this._groupNo = value;
            }
        }
        public string Fullname
        {
            get=>this._fullname;
            set
            {
                if(CheckFullname(value))
                    this.Fullname = value;
            }
        }
        public static bool CheckGroupNo(this string GroupNo)
        {
            for (int i = 0; i < GroupNo.Length; i++)
            {
                if (char.IsUpper(GroupNo[0]) && GroupNo.Length > 2 && GroupNo.Length < 4)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckFullname(this string Fullname)
        {
            string[] sentence = Fullname.Split(' ');
            for (int i = 0; i < Fullname.Length; i++)
            {
                if (sentence.Length == 2)
                {
                    foreach (var item in sentence)
                    {
                        if (char.IsUpper(sentence[i]))
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
            
        }

    }
}
