using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
//1.声明一个令牌（Token）枚举，包含值：SuperAdmin、
//Admin、Blogger、Newbie、Registered。
//2.声明一个令牌管理（TokenManager）类：
//  1.使用私有的Token枚举_tokens存储所具有的权限
//  2.暴露Add(Token)、Remove(Token)和Has(Token)方法，可以
//  添加、删除和判断其有无某个权限
//3.User类中添加一个Tokens属性，类型为TokenManager
    enum Token
    {
        SuperAdmin,
        Admin,
        Blogger,
        Newbie,
        Registered
    }
}
