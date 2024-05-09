using System.Runtime.Serialization;
using com.calitha.commons;

namespace com.calitha.goldparser
{
    public class SymbolException : System.Exception
    {
        public SymbolException(string message) : base(message) { }
        public SymbolException(string message, Exception inner) : base(message, inner) { }
        protected SymbolException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
    public class RuleException : System.Exception
    {
        public RuleException(string message) : base(message) { }
        public RuleException(string message, Exception inner) : base(message, inner) { }
        protected RuleException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }

    enum SymbolConstants : int
    {
        SYMBOL_EOF            =  0, // (EOF)
        SYMBOL_ERROR          =  1, // (Error)
        SYMBOL_WHITESPACE     =  2, // Whitespace
        SYMBOL_MINUS          =  3, // '-'
        SYMBOL_EXCLAMEQ       =  4, // '!='
        SYMBOL_LPAREN         =  5, // '('
        SYMBOL_RPAREN         =  6, // ')'
        SYMBOL_TIMES          =  7, // '*'
        SYMBOL_COMMA          =  8, // ','
        SYMBOL_DIV            =  9, // '/'
        SYMBOL_COLON          = 10, // ':'
        SYMBOL_CARET          = 11, // '^'
        SYMBOL_PLUS           = 12, // '+'
        SYMBOL_LT             = 13, // '<'
        SYMBOL_EQ             = 14, // '='
        SYMBOL_EQEQ           = 15, // '=='
        SYMBOL_GT             = 16, // '>'
        SYMBOL_DIGIT          = 17, // Digit
        SYMBOL_ELSE           = 18, // else
        SYMBOL_END            = 19, // End
        SYMBOL_FOR            = 20, // for
        SYMBOL_FUNC           = 21, // func
        SYMBOL_ID             = 22, // Id
        SYMBOL_IF             = 23, // if
        SYMBOL_IN             = 24, // in
        SYMBOL_PRINT          = 25, // print
        SYMBOL_RANGE          = 26, // range
        SYMBOL_START          = 27, // Start
        SYMBOL_WHILE          = 28, // while
        SYMBOL_ASSIGN         = 29, // <assign>
        SYMBOL_CONDITION      = 30, // <condition>
        SYMBOL_DIGIT2         = 31, // <digit>
        SYMBOL_EXP            = 32, // <exp>
        SYMBOL_EXPRETION      = 33, // <expretion>
        SYMBOL_FACTOR         = 34, // <factor>
        SYMBOL_FOR_STATMENT   = 35, // <for_statment>
        SYMBOL_ID2            = 36, // <id>
        SYMBOL_IF_STATMENT    = 37, // <if_statment>
        SYMBOL_MAIN           = 38, // <Main>
        SYMBOL_METHOD         = 39, // <method>
        SYMBOL_METHOD_NAME    = 40, // <method_name>
        SYMBOL_OPERATION      = 41, // <operation>
        SYMBOL_PRINT_STATMENT = 42, // <print_statment>
        SYMBOL_STATMENT_LIST  = 43, // <statment_list>
        SYMBOL_TERM           = 44, // <term>
        SYMBOL_TOPIC          = 45, // <topic>
        SYMBOL_WHILE_STATMENT = 46  // <while_statment>
    };
    enum RuleConstants : int
    {
        RULE_MAIN_START_END                                      =  0, // <Main> ::= Start <statment_list> End
        RULE_STATMENT_LIST                                       =  1, // <statment_list> ::= <topic>
        RULE_STATMENT_LIST2                                      =  2, // <statment_list> ::= <topic> <statment_list>
        RULE_TOPIC                                               =  3, // <topic> ::= <assign>
        RULE_TOPIC2                                              =  4, // <topic> ::= <print_statment>
        RULE_TOPIC3                                              =  5, // <topic> ::= <if_statment>
        RULE_TOPIC4                                              =  6, // <topic> ::= <for_statment>
        RULE_TOPIC5                                              =  7, // <topic> ::= <while_statment>
        RULE_TOPIC6                                              =  8, // <topic> ::= <method>
        RULE_ASSIGN_EQ                                           =  9, // <assign> ::= <id> '=' <expretion>
        RULE_EXPRETION_PLUS                                      = 10, // <expretion> ::= <expretion> '+' <term>
        RULE_EXPRETION_MINUS                                     = 11, // <expretion> ::= <expretion> '-' <term>
        RULE_EXPRETION                                           = 12, // <expretion> ::= <term>
        RULE_TERM_TIMES                                          = 13, // <term> ::= <term> '*' <factor>
        RULE_TERM_DIV                                            = 14, // <term> ::= <term> '/' <factor>
        RULE_TERM                                                = 15, // <term> ::= <factor>
        RULE_FACTOR_CARET                                        = 16, // <factor> ::= <factor> '^' <exp>
        RULE_FACTOR                                              = 17, // <factor> ::= <exp>
        RULE_EXP_LPAREN_RPAREN                                   = 18, // <exp> ::= '(' <expretion> ')'
        RULE_EXP                                                 = 19, // <exp> ::= <id>
        RULE_EXP2                                                = 20, // <exp> ::= <digit>
        RULE_ID_ID                                               = 21, // <id> ::= Id
        RULE_DIGIT_DIGIT                                         = 22, // <digit> ::= Digit
        RULE_PRINT_STATMENT_PRINT                                = 23, // <print_statment> ::= print <exp>
        RULE_IF_STATMENT_IF_LPAREN_RPAREN_COLON                  = 24, // <if_statment> ::= if '(' <condition> ')' ':' <statment_list>
        RULE_IF_STATMENT_IF_LPAREN_RPAREN_COLON_ELSE_COLON       = 25, // <if_statment> ::= if '(' <condition> ')' ':' <statment_list> else ':' <statment_list>
        RULE_CONDITION                                           = 26, // <condition> ::= <expretion> <operation> <expretion>
        RULE_OPERATION_LT                                        = 27, // <operation> ::= '<'
        RULE_OPERATION_GT                                        = 28, // <operation> ::= '>'
        RULE_OPERATION_EQEQ                                      = 29, // <operation> ::= '=='
        RULE_OPERATION_EXCLAMEQ                                  = 30, // <operation> ::= '!='
        RULE_FOR_STATMENT_FOR_IN_RANGE_LPAREN_COMMA_RPAREN_COLON = 31, // <for_statment> ::= for <exp> in range '(' <exp> ',' <exp> ')' ':' <statment_list>
        RULE_WHILE_STATMENT_WHILE_LPAREN_RPAREN_COLON            = 32, // <while_statment> ::= while '(' <condition> ')' ':' <statment_list>
        RULE_METHOD_FUNC_LPAREN_RPAREN_COLON                     = 33, // <method> ::= func <method_name> '(' <id> ')' ':' <statment_list>
        RULE_METHOD_FUNC_LPAREN_RPAREN_COLON2                    = 34, // <method> ::= func <method_name> '(' ')' ':' <statment_list>
        RULE_METHOD_NAME                                         = 35  // <method_name> ::= <id>
    };
    public class MyParser
    {
        ListBox list1 , list2;
        private LALRParser parser;
        public MyParser(string filename, ListBox list1, ListBox list2)
        {
            FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            this.list1 = list1;
            this.list2 = list2;
            Init(stream);
            stream.Close();
        }
        public MyParser(string baseName, string resourceName)
        {
            byte[] buffer = ResourceUtil.GetByteArrayResource(
                System.Reflection.Assembly.GetExecutingAssembly(),
                baseName,
                resourceName);
            MemoryStream stream = new MemoryStream(buffer);
            Init(stream);
            stream.Close();
        }
        public MyParser(Stream stream)
        {
            Init(stream);
        }
        private void Init(Stream stream)
        {
            CGTReader reader = new CGTReader(stream);
            parser = reader.CreateNewParser();
            parser.TrimReductions = false;
            parser.StoreTokens = LALRParser.StoreTokensMode.NoUserObject;

            parser.OnTokenError += new LALRParser.TokenErrorHandler(TokenErrorEvent);
            parser.OnParseError += new LALRParser.ParseErrorHandler(ParseErrorEvent);
            parser.OnTokenRead += new LALRParser.TokenReadHandler(TokenReadEvent);
        }
        public void Parse(string source)
        {
            NonterminalToken token = parser.Parse(source);
            if (token != null)
            {
                Object obj = CreateObject(token);
            }
        }
        private Object CreateObject(Token token)
        {
            if (token is TerminalToken)
                return CreateObjectFromTerminal((TerminalToken)token);
            else
                return CreateObjectFromNonterminal((NonterminalToken)token);
        }
        private Object CreateObjectFromTerminal(TerminalToken token)
        {
            switch (token.Symbol.Id)
            {
                case (int)SymbolConstants.SYMBOL_EOF :
                //(EOF)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ERROR :
                //(Error)
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHITESPACE :
                //Whitespace
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MINUS :
                //'-'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXCLAMEQ :
                //'!='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LPAREN :
                //'('
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RPAREN :
                //')'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TIMES :
                //'*'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COMMA :
                //','
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIV :
                //'/'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_COLON :
                //':'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CARET :
                //'^'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PLUS :
                //'+'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_LT :
                //'<'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQ :
                //'='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EQEQ :
                //'=='
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_GT :
                //'>'
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIGIT :
                //Digit
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ELSE :
                //else
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_END :
                //End
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FOR :
                //for
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FUNC :
                //func
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ID :
                //Id
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IF :
                //if
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IN :
                //in
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRINT :
                //print
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_RANGE :
                //range
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_START :
                //Start
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILE :
                //while
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ASSIGN :
                //<assign>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_CONDITION :
                //<condition>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_DIGIT2 :
                //<digit>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXP :
                //<exp>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_EXPRETION :
                //<expretion>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FACTOR :
                //<factor>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_FOR_STATMENT :
                //<for_statment>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_ID2 :
                //<id>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_IF_STATMENT :
                //<if_statment>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_MAIN :
                //<Main>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_METHOD :
                //<method>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_METHOD_NAME :
                //<method_name>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_OPERATION :
                //<operation>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_PRINT_STATMENT :
                //<print_statment>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_STATMENT_LIST :
                //<statment_list>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TERM :
                //<term>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_TOPIC :
                //<topic>
                //todo: Create a new object that corresponds to the symbol
                return null;

                case (int)SymbolConstants.SYMBOL_WHILE_STATMENT :
                //<while_statment>
                //todo: Create a new object that corresponds to the symbol
                return null;

            }
            throw new SymbolException("Unknown symbol");
        }
        public Object CreateObjectFromNonterminal(NonterminalToken token)
        {
            switch (token.Rule.Id)
            {
                case (int)RuleConstants.RULE_MAIN_START_END :
                //<Main> ::= Start <statment_list> End
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATMENT_LIST :
                //<statment_list> ::= <topic>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_STATMENT_LIST2 :
                //<statment_list> ::= <topic> <statment_list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TOPIC :
                //<topic> ::= <assign>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TOPIC2 :
                //<topic> ::= <print_statment>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TOPIC3 :
                //<topic> ::= <if_statment>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TOPIC4 :
                //<topic> ::= <for_statment>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TOPIC5 :
                //<topic> ::= <while_statment>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TOPIC6 :
                //<topic> ::= <method>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ASSIGN_EQ :
                //<assign> ::= <id> '=' <expretion>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRETION_PLUS :
                //<expretion> ::= <expretion> '+' <term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRETION_MINUS :
                //<expretion> ::= <expretion> '-' <term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXPRETION :
                //<expretion> ::= <term>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM_TIMES :
                //<term> ::= <term> '*' <factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM_DIV :
                //<term> ::= <term> '/' <factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_TERM :
                //<term> ::= <factor>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR_CARET :
                //<factor> ::= <factor> '^' <exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FACTOR :
                //<factor> ::= <exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXP_LPAREN_RPAREN :
                //<exp> ::= '(' <expretion> ')'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXP :
                //<exp> ::= <id>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_EXP2 :
                //<exp> ::= <digit>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_ID_ID :
                //<id> ::= Id
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_DIGIT_DIGIT :
                //<digit> ::= Digit
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_PRINT_STATMENT_PRINT :
                //<print_statment> ::= print <exp>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IF_STATMENT_IF_LPAREN_RPAREN_COLON :
                //<if_statment> ::= if '(' <condition> ')' ':' <statment_list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_IF_STATMENT_IF_LPAREN_RPAREN_COLON_ELSE_COLON :
                //<if_statment> ::= if '(' <condition> ')' ':' <statment_list> else ':' <statment_list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_CONDITION :
                //<condition> ::= <expretion> <operation> <expretion>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION_LT :
                //<operation> ::= '<'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION_GT :
                //<operation> ::= '>'
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION_EQEQ :
                //<operation> ::= '=='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_OPERATION_EXCLAMEQ :
                //<operation> ::= '!='
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_FOR_STATMENT_FOR_IN_RANGE_LPAREN_COMMA_RPAREN_COLON :
                //<for_statment> ::= for <exp> in range '(' <exp> ',' <exp> ')' ':' <statment_list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_WHILE_STATMENT_WHILE_LPAREN_RPAREN_COLON :
                //<while_statment> ::= while '(' <condition> ')' ':' <statment_list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_METHOD_FUNC_LPAREN_RPAREN_COLON :
                //<method> ::= func <method_name> '(' <id> ')' ':' <statment_list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_METHOD_FUNC_LPAREN_RPAREN_COLON2 :
                //<method> ::= func <method_name> '(' ')' ':' <statment_list>
                //todo: Create a new object using the stored tokens.
                return null;

                case (int)RuleConstants.RULE_METHOD_NAME :
                //<method_name> ::= <id>
                //todo: Create a new object using the stored tokens.
                return null;

            }
            throw new RuleException("Unknown rule");
        }
        private void TokenErrorEvent(LALRParser parser, TokenErrorEventArgs args)
        {
            string message = "Token error with input: '" + args.Token.ToString() + "'";
        }
        private void ParseErrorEvent(LALRParser parser, ParseErrorEventArgs args)
        {
            string message1 = "Parse error caused by token: '" + args.UnexpectedToken.ToString() +
                                                  " In line " + args.UnexpectedToken.Location.LineNr;
            list1.Items.Add(message1);
            string message2 = " Expected Tokens " + args.ExpectedTokens.ToString();
            list1.Items.Add(message2);
        }
        private void TokenReadEvent(LALRParser parser, TokenReadEventArgs args)
        {
            string info = args.Token.Text + " \t " + (SymbolConstants)args.Token.Symbol.Id;
            list2.Items.Add(info);
        }
    }
}