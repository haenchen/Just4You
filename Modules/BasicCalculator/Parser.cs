using Just4You.Modules.BasicCalculator.Node;
using Just4You.Modules.BasicCalculator.Node.Operator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You.Modules.BasicCalculator
{
    internal static class Parser
    {
        public static NodeInterface GetAst(List<Token> tokens)
        {
            Stack<Token> ReorderedTokens = ReorderedTokens = ReorderTokensToReversePolishNotation(tokens);
            NodeInterface Node;
            try
            {
                Node = CreateAst(ReorderedTokens);
            }
            catch (Exception)
            {
                Node = new Scalar(0);
                GlobalLogger.addError("Grundrechner: Ungültige Eingabe");
            }
            return Node;
        }

        /// <summary>
        /// Shunting-Yard-Algorithmus von Dijkstra
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        private static Stack<Token> ReorderTokensToReversePolishNotation(List<Token> tokens)
        {
            var Stack = new Stack<Token>();

            var List = new List<Token>();

            foreach (Token Token in tokens)
            {
                if (Token.GetType() != typeof(Token))
                {
                    throw new Exception("Invalid input!");
                }

                if (Token.GetTokenType() == TokenType.T_WHITESPACE)
                {
                    continue;
                }


                if (Token.GetTokenType() == TokenType.T_PAROPEN)
                {
                    Stack.Push(Token);
                    continue;
                }

                if (Token.GetTokenType() == TokenType.T_PARCLOSE)
                {
                    while (Stack.Peek().GetTokenType() != TokenType.T_PAROPEN)
                    {
                        List.Add(Stack.Pop());
                    }
                    Stack.Pop();
                    continue;
                }

                if (Token.IsOperator())
                {
                    while (Stack.Count > 0 &&  HasPrecedence(Stack.Peek(), Token))
                    {
                        List.Add(Stack.Pop());
                    }
                    Stack.Push(Token);
                    continue;
                }

                List.Add(Token);
            }


            while (List.Count > 0)
            {
                Stack.Push(List[List.Count - 1]);
                List.RemoveAt(List.Count - 1);
            }

            return Stack;
        }

        /// <summary>
        /// Aus dem Tokenstack lässt sich ein abstrakter Syntaxbaum bauen.
        /// Für den AST sind Klammern irrelevant.
        /// Das wurde eigentlich nur aus eigenem Interesse daran so umgesetzt.
        /// Der Scalar ist die Wurzelnode und kann rekursiv den ganzen Baum ausrechnen.
        /// </summary>
        /// <param name="TokenStack"></param>
        /// <returns></returns>
        private static NodeInterface CreateAst(Stack<Token> TokenStack)
        {
            var astStack = new Stack<NodeInterface>();

            while (TokenStack.Count > 0)
            {
                Token Token = TokenStack.Pop();

                if (Token.GetTokenType() == TokenType.T_PAROPEN || Token.GetTokenType() == TokenType.T_PARCLOSE)
                    continue;

                if (Token.IsOperator())
                {
                    Type NodeType;
                    switch (Token.GetTokenType())
                    {
                        case TokenType.T_ADD:
                            NodeType = typeof(Add);
                            break;
                        case TokenType.T_SUB:
                            NodeType = typeof(Sub);
                            break;
                        case TokenType.T_DIV:
                            NodeType = typeof(Div);
                            break;
                        case TokenType.T_MUL:
                            NodeType = typeof(Mul);
                            break;
                        case TokenType.T_MOD:
                            NodeType = typeof(Mod);
                            break;
                        default:
                            throw new Exception("Invalid operator: " + Token.GetLexeme() + "!");
                    }
                    NodeInterface rValue = astStack.Pop();
                    NodeInterface lValue = astStack.Pop();
                    astStack.Push((NodeInterface)Activator.CreateInstance(NodeType, new NodeInterface[] { lValue, rValue }));
                    continue;
                }

                if ((Token.GetTokenType() == TokenType.T_INT) || (Token.GetTokenType() == TokenType.T_FLOAT))
                {
                    String Lexeme = Token.GetLexeme().Replace('.', ',');
                    double convertedLexeme;
                    Double.TryParse(Lexeme, out convertedLexeme);
                    astStack.Push(new Scalar(convertedLexeme));
                    continue;
                }
                else
                {
                    throw new Exception("Unhandled Token: " + Token.GetLexeme());
                }
            }
            if (astStack.Count != 1)
            {
                throw new Exception("Didn't resolve stack down to single item!");
            }

            return astStack.Pop();
        }
        
        private static bool HasPrecedence(Token Left, Token Right)
        {
            var OperatorPrecedence = new Dictionary<TokenType, int>
            {   { TokenType.T_MUL, 2 },
                { TokenType.T_DIV, 2 },
                { TokenType.T_MOD, 2 },
                { TokenType.T_ADD, 1 },
                { TokenType.T_SUB, 1 },
                { TokenType.T_PAROPEN, 0 },
                { TokenType.T_PARCLOSE, 0 }
            };

            return OperatorPrecedence[Left.GetTokenType()] >= OperatorPrecedence[Right.GetTokenType()];
        }
    }
}