using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{    //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、
     //悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()

    //1.将之前User/Problem/HelpMoney类的字段封装成属性，其中：
    //1.user.Password在类的外部只能改不能读
    //2.如果user.Name为“admin”，输入时修改为“系统管理员”
    //3.problem.Reward不能为负数
    //2.调用这些类的有参/无参构造函数，生成这些类的对象，调用他们的方法
    //3.一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
    //4.设计一种方式，保证：
    //1.每一个Problem对象一定有Body赋值
    //2.每一个User对象一定有Name和Password赋值
    class Problem
    {
        public string _title { get; set; }
        public string _body { get; set; }
        public Problem(string body)
        {
            _body = body;
        }
        public int _reward;
        public int _Reward
        {
            get { return _reward; }
            set
            {
                if (value<0)
                {
                    Console.WriteLine("悬赏不能为负数");
                    return;
                }
            }
        }
        public DateTime _publishDateTime { get; set; }
        public User _author { get; set; }
        private string[] _keyword = new string[10];
        public string this[int index]
        {
            get { return _keyword[index - 1]; }
            set { _keyword[index - 1] = value; }           
        }
        
    }
}
