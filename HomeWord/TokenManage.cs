using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class TokenManage
    {
        private Token _tokens;
        public void Add(Token token)
        {
            _tokens = _tokens | token;
        }
        public void Remove(Token token)
        {
            if (Has(token))
            {
                _tokens = _tokens ^ token;
            }
            else
            {
                System.Console.WriteLine("Exception");
            }
        }
        public bool Has(Token token)
        {
            return token == (_tokens & token);
        }
    }
}
