using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{//观察“一起帮”的：
 //注册/登录功能，定义一个User类，包含字段：Name（用户名）、
 //Password（密码）和 邀请人（InvitedBy），
 //和方法：Register()、Login()


    //1.将之前User/Problem/HelpMoney类的字段封装成属性，其中：
    //1.user.Password在类的外部只能改不能读
    //2.如果user.Name为“admin”，输入时修改为“系统管理员”
    //3.problem.Reward不能为负数
    //2.调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法
    //3.一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
    //4.设计一种方式，保证：
    //1.每一个Problem对象一定有Body赋值
    //2.每一个User对象一定有Name和Password赋值
    public class User
    {
        public  User(string name, string password)  //每一个User对象一定有Name和Password赋值
        {
            _name = name;
            _password = password;
        }
        private string _name;
        public string Name   //如果user.Name为“admin”，输入时修改为“系统管理员”
        {
            get { return _name; }
            
            set
            {
                if (_name == "admin")
                {
                    _name = "系统管理员";
                }
                else
                {
                    _name = value;
                }
            }
        }
        private string _password;
        public string Password //user.Password在类的外部只能改不能读
        {
            //get{}
            set { _password = value; }
        }
      
        public User InvitedBy { get; set; }
        public string InviteCode { get; set; }
        public string AuthCode { get; set; }



        //public static bool Register()
        //{

        //}

        //public static bool Login()
        //{

        //}
    }
}
