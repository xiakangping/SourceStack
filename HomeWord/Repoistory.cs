﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    //1.定义一个仓库（Repoistory）类，用于存取对象，其中包含：
    //  1.一个int类型的常量version
    //  2.一个静态只读的字符串connection，以后可用于连接数据库
    //  3.思考Respoitory应该是static类还是实例类更好
    class Repoistory
    {
        private const int version = 0;
        public static readonly string connection;
    }
}
