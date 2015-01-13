using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Globalization;


namespace AlisapSAP_1
{
    class CheckSyntaxLexicalError
    {
        List<String> Errors = new List<String>();
        Stack<String> st = new Stack<String>();


        public List<String> checkError(HashSet<string> reservedWords, HashSet<string> reservedWords1, HashSet<string> reservedWords2
                                            , String[,] _words, int wordcount)
        {
            
            //LEX
            int counter = 0;
            
            for (int i=0; i<=wordcount; i++) {
                if (String.IsNullOrEmpty(_words[i, 0]) && String.IsNullOrWhiteSpace(_words[i, 0]))
                { break; }

                if (reservedWords.Contains(_words[i, 0]) || reservedWords1.Contains(_words[i, 0]) || reservedWords2.Contains(_words[i, 0]))
                {
                    
                }
                else {
                    Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "Lexeme '" + _words[i, 0] + "' not recognized");
                }
                 counter++;
                         
            }

            st.Push("HLT");
            st.Push("OUT");
            st.Push("SUBADD");
            st.Push("HEX1");
            st.Push("LDA");
            st.Push("LOAD");

            int y = 0;

            while (st.Count != 0 && y <= counter )
            {
           
                if (y == counter) {
                    if (st.Peek() == "HEX1" || st.Peek() == "HEX2")
                    {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] +" :      "+"Must be followed by Hexadecimal");
                        break;
                    }
                    else if (st.Peek() == ",")
                    {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "Must be followed by comma");
                        break;
                    }
                    else if (st.Peek() == "HLT")
                    {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "Must be followed by HLT");
                        break;
                    }
                    else if (st.Peek() == "LOAD1")
                    {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "Must be followed by ORG or LDA");
                        break;
                    }
                    else if (st.Peek() == "SUBADD")
                    {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "Must be followed by ADD/SUB , or OUT immediately");
                        break;
                    }

                }
                
                if(st.Peek() == "LOAD"){
                    if(_words[y,0] == "ORG"){
                        st.Pop();
                        st.Push("LOAD1");
                        st.Push("HEX2");
                        st.Push(",");
                        st.Push("HEX1");
                        st.Push("ORG");
                    }
                    else{
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "Must Start with ORG Command");
                        break;
                    }
                }
                else if (st.Peek() == "LOAD1")
                {
                    if (_words[y,0] == "ORG")
                    {
                        st.Pop();
                        st.Push("LOAD1");
                        st.Push("HEX2");
                        st.Push(",");
                        st.Push("HEX1");
                        st.Push("ORG");
                    }
                    else
                    {
                        st.Pop();
                    }
                }
                else if(st.Peek() == "HEX1"){
                    if (reservedWords1.Contains(_words[y,0]))
                    {
                        st.Pop();
                        y++;
           
                    }
                    else {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "After 'ORG' / 'LDA' / 'SUB / 'ADD', Lexeme must be of hexadecimal value less than 0FH");
                        break;
                    }

                }
                else if (st.Peek() == "HEX2")
                {
                    if (reservedWords2.Contains(_words[y, 0]))
                    {
                        st.Pop();
                        y++;
                    }
                    else
                    {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "After ',', Lexeme must be of hexadecimal value");
                        break;
                    }

                }
                else if(st.Peek() == "ORG"){
                    st.Pop();
                    y++;
                 
                }
                else if (st.Peek() == ",")
                {
                    if (_words[y,0] == ",")
                    {
                        y++;
                        st.Pop();
                    }
                    else {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "Lexeme must be comma");
                        break;
                    }

                }
                else if (st.Peek() == "LDA")
                {
                    if (_words[y,0] == "LDA")
                    {
                        y++;
                        st.Pop();
                    }
                    else
                    {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "Lexeme must be LDA or ORG ");
                        break;
                    }

                }
                else if (st.Peek() == "SUBADD")
                {
                    if (_words[y,0] == "SUB")
                    {
                        st.Pop();
                        st.Push("SUBADD");
                        st.Push("HEX1");
                        st.Push("SUB");
                    
                    }
                    else if (_words[y,0] == "ADD")
                    {
                        st.Pop();
                        st.Push("SUBADD");
                        st.Push("HEX1");
                        st.Push("ADD");

                    }
                    else
                    {
                        st.Pop();
                    }
                }
                
                else if (st.Peek() == "ADD")
                {
                    st.Pop();
                    y++;

                }
                else if (st.Peek() == "SUB")
                {
                    st.Pop();
                    y++;

                }
                else if (st.Peek() == "OUT")
                {
                    if (_words[y,0] == "OUT")
                    {
                        y++;
                        st.Pop();
                    }
                    else
                    {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "Lexeme must be Another SUB/ADD or OUT immediately");
                        break;
                    }

                }
                else if (st.Peek() == "HLT")
                {
                    if (_words[y,0] == "HLT")
                    {
                        y++;
                        st.Pop();
                    }
                    else
                    {
                        Errors.Add("Line " + _words[y, 1] + " Column " + _words[y, 2] + " :      " + "Lexeme must be HLT");
                        break;
                    }

                }

            }
            
            return Errors;
        }
    }
}
