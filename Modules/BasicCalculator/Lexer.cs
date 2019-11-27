using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Just4You.Modules.BasicCalculator
{
    internal static class Lexer
    {
        private static Dictionary<TokenType, Regex> matches;

        private static bool _initialized = false;

        public static void Initialize()
        {
            if (_initialized)
                return;
            fillDict();
            _initialized = true;
        }

        /// <summary>
        /// Reguläre Ausdrücke anlegen um Eingaben zum richtigen Token zu machen.
        /// </summary>
        private static void fillDict()
        {
            matches = new Dictionary<TokenType, Regex>();
            matches.Add(TokenType.T_ADD, new Regex("^(\\+)"));
            matches.Add(TokenType.T_SUB, new Regex("^(-)"));
            matches.Add(TokenType.T_MUL, new Regex("^(\\*)"));
            matches.Add(TokenType.T_DIV, new Regex("^(/)"));
            matches.Add(TokenType.T_MOD, new Regex("^(%)"));
            matches.Add(TokenType.T_PAROPEN, new Regex("^[(]"));
            matches.Add(TokenType.T_PARCLOSE, new Regex("^[)]"));
            // Reihenfolge von Float und Int ist wichtig, da sonst vor und nach dem Komma als separate Integer gematcht werden.
            matches.Add(TokenType.T_FLOAT, new Regex("^[-]?\\d*[.,]?\\d+"));
            matches.Add(TokenType.T_INT, new Regex("^-?\\d+"));
            matches.Add(TokenType.T_WHITESPACE, new Regex("^\\s+"));
        }

        public static List<Token> Tokenize(String input)
        {
            Initialize();
            List<Token> tokens = new List<Token>();
            int offset = 0;
            // Einfach den String durchgehen und die Eingaben den richtigen Tokens zuordnen
            while (offset < input.Length)
            {
                String current = input.Substring(offset);
                Token result = Match(current);
                tokens.Add(result);
                offset += result.GetLexeme().Length;
            }
            return tokens;
        }

        private static Token Match(String input)
        {
            foreach (KeyValuePair<TokenType, Regex> entry in matches)
            {
                Match match = entry.Value.Match(input);
                if (match != System.Text.RegularExpressions.Match.Empty)
                {
                    return new Token(entry.Key, match.Value);
                }
            }

            // Das sollte theoretisch nicht möglich sein.
            throw new Exception("Unmatched Token");
        }
    }
}
