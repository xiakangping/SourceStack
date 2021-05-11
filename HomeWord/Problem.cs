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

    //1. 考虑求助（Problem）的以下方法/属性，哪些适合实例，哪些适合静态，然后添加到类中：
    //  1.Publish()：发布一篇求助，并将其保存到数据库
    //  2.Load(int Id)：根据Id从数据库获取一条求助
    //  3.Delete(int Id)：根据Id删除某个求助
    //  4.repoistory：可用于在底层实现上述方法和数据库的连接操作等

    //2.观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），
    //根据他们的特点，抽象出一个父类：内容（Content）
    // 1.Content中有一个字段：kind，
    // 记录内容的种类（problem/article/suggest等），只能被子类使用
    // 2.确保每个Content对象都有kind的非空值
    // 3.Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
    // 4.其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
    public class Content
    {
        static DateTime createtime
        {
            get;
        }
        internal string Kind { get; set; }
    }

    public class Suggest /*建议*/ : Content
    {
        
        public Suggest(string kind)
        {

        }

    }
    public class Article /*文章*/ : Content
    {
        public Article(string kind)
        {

        }

    }
    public class Problem /*求助*/ : Content
    {

 
        public Problem(string kind)
        {

        }
        /// <summary>
        /// 求助方法
        /// </summary>
        public static void Publish()
        {

        }
        /// <summary>
        /// 获取求助方法
        /// </summary>
        /// <param name="id"></param>
        public void Load(int id)
        {

        }
        /// <summary>
        /// 删除求助方法
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {

        }

     


        //    Repoistory repoistory = new Repoistory();

        //    public string Title { get; set; }
        //    public string Body { get; set; }
        //    public Problem(string body)  //每一个Problem对象一定有Body赋值
        //    {
        //        Body = body;
        //    }
        //    public int _reward;
        //    public int Reward      //problem.Reward不能为负数
        //    {
        //        get { return _reward; }
        //        set
        //        {
        //            if (value < 0)
        //            {
        //                Console.WriteLine("悬赏不能为负数");
        //                return;
        //            }
        //            else
        //            {
        //                _reward = value;
        //            }
        //        }
        //    }
        //    public DateTime PublishDateTime { get; set; }
        //    public User Author { get; set; }
        //    private string[] _Keyword = new string[10]; //一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        //    public string this[int index]
        //    {
        //        get { return _Keyword[index - 1]; }
        //        set { _Keyword[index - 1] = value; }
        //    }

    }
    }
