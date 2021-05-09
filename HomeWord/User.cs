using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{



    //1.定义一个仓库（Repoistory）类，用于存取对象，其中包含：
    //  1.一个int类型的常量version
    //  2.一个静态只读的字符串connection，以后可用于连接数据库
    //  3.思考Respoitory应该是static类还是实例类更好
    //2.考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：
    //  1.Publish()：发布一篇求助，并将其保存到数据库
    //  2.Load(int Id)：根据Id从数据库获取一条求助
    //  3.Delete(int Id)：根据Id删除某个求助
    //  4.repoistory：可用于在底层实现上述方法和数据库的连接操作等
    //    //
    //1.让User类无法被继承
   
    //3.实例化文章和意见建议，调用他们：
    // 1.继承自父类的属性和方法
    // 2.自己的属性和方法
    //4.再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？


    /// <summary>
    /// 系统管理员的作业
    /// </summary>
    //sealed class User:Entity //让User类无法被继承
    //{
    //    public User(string name, string password)  //每一个User对象一定有Name和Password赋值
    //    {
    //        _name = name;
    //        _password = password;
    //    }
    //    private string _name;
    //    public string Name   //如果user.Name为“admin”，输入时修改为“系统管理员”
    //    {
    //        get { return _name; }

    //        set
    //        {
    //            if (_name == "admin")
    //            {
    //                _name = "系统管理员";
    //            }
    //            else
    //            {
    //                _name = value;
    //            }
    //        }
    //    }
    //    private string _password;
    //    public string Password //user.Password在类的外部只能改不能读
    //    {
    //        //get{}
    //        set { _password = value; }
    //    }

    //    public User InvitedBy { get; set; }
    //    public string InviteCode { get; set; }
    //    public string AuthCode { get; set; }


    //    public static bool Register()
    //    {

    //    }

    //    public static bool Login()
    //    {

    //    }
    //}

}
