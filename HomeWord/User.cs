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

    //1.定义一个仓库（Repoistory）类，用于存取对象，其中包含：
    //  1.一个int类型的常量version
    //  2.一个静态只读的字符串connection，以后可用于连接数据库
    //  3.思考Respoitory应该是static类还是实例类更好
    //2.考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：
    //  1.Publish()：发布一篇求助，并将其保存到数据库
    //  2.Load(int Id)：根据Id从数据库获取一条求助
    //  3.Delete(int Id)：根据Id删除某个求助
    //  4.repoistory：可用于在底层实现上述方法和数据库的连接操作等
    //3.设计一个类FactoryContext，保证整个程序运行过程中，无论如何，外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例）
    //4.想一想，为什么Publish()方法不是放置在User类中呢？用户（user）发布（Publish）一篇文章（article），不正好是user.Publish(article) 么？
    //5.自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
    //1.出栈Pop()，弹出栈顶数据
    //2.入栈Push()，可以一次性压入多个数据
    //3.出/入栈检查，
    //  1.如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
    //  2.如果已弹出所有数据，提示“栈已空”

    public class User
    {
        public User(string name, string password)  //每一个User对象一定有Name和Password赋值
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
