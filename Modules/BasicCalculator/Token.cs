using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You.Modules.BasicCalculator
{
    public enum TokenType
    {
        T_INT,
        T_FLOAT,
        T_ADD,
        T_SUB,
        T_MUL,
        T_DIV,
        T_PAROPEN,
        T_PARCLOSE,
        T_MOD,
        T_WHITESPACE,
    }

    public class Token
    {
        private TokenType type;
        private String lexeme;

        public Token(TokenType type, String lexeme)
        {
            this.type = type;
            this.lexeme = lexeme;
        }

        public String GetLexeme()
        {
            return lexeme;
        }

        public TokenType GetTokenType()
        {
            return type;
        }

        public bool IsOperator()
        {
            if (this.type == TokenType.T_ADD ||
                this.type == TokenType.T_DIV ||
                this.type == TokenType.T_MUL ||
                this.type == TokenType.T_SUB ||
                this.type == TokenType.T_MOD ||
                this.type == TokenType.T_PARCLOSE ||
                this.type == TokenType.T_PAROPEN)
                return true;

            return false;
        }
    }

}
