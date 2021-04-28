using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Shiyan
    {
        private string _name;
        public string _Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private int _age;
        public int _Age
        {
            get { return _age; }
            set
            {
                if (value<0||value>100)
                {
                    value = 0;
                }
                _age = value;}
        }

        private char _gender;
        public char _Gender
        {
            get
            {
                if (_gender !='男'&&_gender!='女')
                {
                    return _gender = '男';
                }
                return _gender; }
            set { _gender = value; }
        }

        public void CHWL()
        {
            Console.WriteLine("我叫{0}，我今年{1}，我是{2},我会吃喝玩乐", this._Name, this._Age, this._Gender);
        }
    }

}
