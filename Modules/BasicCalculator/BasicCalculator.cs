using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You.Modules.BasicCalculator
{
    public static class BasicCalculator
    {
        public static Double Evaluate(String Expression)
        {
            var Tokens = Lexer.Tokenize(Expression);
            var Node = Parser.GetAst(Tokens);
            return Node.Calculate().Value;
        }
    }
}
