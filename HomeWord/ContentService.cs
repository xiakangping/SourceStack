using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    //添加一个新类ContentService，其中有一个发布（Publish()）方法：

    //1.如果发布Article，需要消耗一个帮帮币
    //2.如果发布Problem，需要消耗其设置悬赏数量的帮帮币
    //3.如果发布Suggest，不需要消耗帮帮币
    class ContentService
    {

        public string Name { get; set; }
        public virtual void Publish()
        {

        }
    }
    class Article : ContentService
    {
        public string Name { get; set; }
        public override void Publish()
        {
            Console.WriteLine($"{Name}需要消耗一个帮帮币");
        }
    }
    class Problem : ContentService
    {
        public override void Publish()
        {
            Console.WriteLine($"{Name}需要消耗其设置悬赏数量的帮帮币");
        }
    }
    class Suggest : ContentService
    {
        public override void Publish()
        {
            Console.WriteLine($"{Name}不需要消耗帮帮币");
        }
    }


}
