using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace AlisapSAP_1
{
    class CheckAssemblerError
    {
        List<String> Errors = new List<String>();
      

        public List<String> checkError(HashSet<string> reservedWords, HashSet<string> reservedWords1, HashSet<string> reservedWords2
                                            , String[,] _words, int wordcount , String[,] machineCode)
        {
            int counter = 0;

            for (int i = 0; i <= wordcount; i++)
            {
                if (String.IsNullOrEmpty(_words[i, 0]) && String.IsNullOrWhiteSpace(_words[i, 0]))
                { break; }

                counter++;
            }

            for (int i = 0; i < counter; i++) {
              
                    if (_words[i, 0] == "ORG")
                    {
                        if (reservedWords1.Contains( _words[i + 1, 0]))
                        {
                            if (_words[i+2, 0] == ",")
                            {
                                if (reservedWords2.Contains(_words[i + 3, 0]))
                                {
                                        
                                    string hex = _words[i + 1, 0].Remove(2);
                                    hex = hex.Replace("x", string.Empty);
                                    int dec = 0;
                                    int.TryParse(hex, System.Globalization.NumberStyles.HexNumber, null, out dec);
                                    if (dec <= 2) {
                                        Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "Cannot Perform ORG Command on 00H / 01H / 02H Address , It is reserved for Machine Program");
                                        continue;
                                        
                                    }
                                    string bin = Convert.ToString(dec, 2).PadLeft(4, '0');
                                  

                                    string hex2 = _words[i + 3, 0].Remove(2);
                                    hex2 = hex2.Replace("x", string.Empty);
                                    int dec2 = 0;
                                    int.TryParse(hex2, System.Globalization.NumberStyles.HexNumber, null, out dec2);
                        
                                    string bin2 = Convert.ToString(dec2, 2).PadLeft(8, '0');
                         
                                    for (int y = 0; y <= 15; y++) {
                                        if (bin == machineCode[y, 0]) {
                                            if (machineCode[y, 2] == "-")
                                            {
                                                machineCode[y, 1] = bin2;
                                                machineCode[y, 2] = _words[i + 3, 0] + " Data (" + dec2 + ")";
                                            }
                                            else {
                                                Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "Cannot Perform ORG Command, Address " + _words[i + 1, 0] + " is already taken");
                                            }
                                        }
                                    }
                    
                                }

                            }

                        }

                    }
                    else if (_words[i, 0] == "LDA")
                    {
                         if (reservedWords1.Contains( _words[i + 1, 0])){
                             string hex = _words[i + 1, 0].Remove(2);
                             hex = hex.Replace("x", string.Empty);
                             int dec = 0;
                             int.TryParse(hex, System.Globalization.NumberStyles.HexNumber, null, out dec);
                             string bin = Convert.ToString(dec, 2).PadLeft(4, '0');
                             if (dec <= 2)
                             {
                                 Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "Cannot Perform LDA on 00H / 01H / 02H Address");
                                 continue;

                             }
                             for (int y = 0; y <= 15; y++)
                             {
                                 if (bin == machineCode[y, 0])
                                 {
                                     if (machineCode[y, 2] == "-")
                                     {
                                         Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "Cannot LOAD, Address Data of " + _words[i + 1, 0] + " is empty");

                                     }
                                     else {
                                         machineCode[0, 1] = "0000" + bin;
                                         machineCode[0, 2] = "LDA " + _words[i + 1, 0];
                                     }
                                  
                                 }
                             }
                    

                         }
                    
                    }
                    else if (_words[i, 0] == "ADD") {
                        if (reservedWords1.Contains(_words[i + 1, 0])) { 
                            string hex = _words[i + 1, 0].Remove(2);
                             hex = hex.Replace("x", string.Empty);
                             int dec = 0;
                             int.TryParse(hex, System.Globalization.NumberStyles.HexNumber, null, out dec);
                             string bin = Convert.ToString(dec, 2).PadLeft(4, '0');
                             if (dec <= 2)
                             {
                                 Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "Cannot Perform ADD on 00H / 01H / 02H Address");
                                 continue;

                             }
                             for (int y = 0; y <= 15; y++)
                             {
                                 if (bin == machineCode[y, 0])
                                 {
                                     if (machineCode[y, 2] == "-")
                                     {
                                         Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "Cannot ADD, Address Data of " + _words[i + 1, 0] + " is empty");

                                     }
                                     else
                                     {
                                         for (int k = 1; k <= 6; k++) { 
                                            if (machineCode[k, 2] == "-") {
                                                machineCode[k, 1] = "0001" + bin;
                                                machineCode[k, 2] = "ADD " + _words[i + 1, 0];
                                              
                                                break;
                                            }
                                            else if (machineCode[k, 2][0] == 'A' || machineCode[k, 2][0] == 'S')
                                            {
                                                continue;
                                            }
                                            else {

                                                Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "No Available Space, Cannot Perform ADD " + _words[i + 1, 0]);
                                                break;
                                            }
                                           }
                                            
                                            
                                     }

                                 }
                             }
                             
                        }
                    
                    
                    }
                    else if (_words[i, 0] == "SUB")
                    {
                        if (reservedWords1.Contains(_words[i + 1, 0]))
                        {
                            string hex = _words[i + 1, 0].Remove(2);
                            hex = hex.Replace("x", string.Empty);
                            int dec = 0;
                            int.TryParse(hex, System.Globalization.NumberStyles.HexNumber, null, out dec);
                            string bin = Convert.ToString(dec, 2).PadLeft(4, '0');
                            if (dec <= 2)
                            {
                                Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "Cannot Perform SUB on 00H / 01H / 02H Address");
                                continue;

                            }
                            for (int y = 0; y <= 15; y++)
                            {
                                if (bin == machineCode[y, 0])
                                {
                                    if (machineCode[y, 2] == "-")
                                    {
                                        Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "Cannot SUB, Address Data of " + _words[i + 1, 0] + " is empty");

                                    }
                                    else
                                    {
                                        for (int k = 1; k <= 6; k++)
                                        {
                                            if (machineCode[k, 2] == "-")
                                            {
                                                machineCode[k, 1] = "0010" + bin;
                                                machineCode[k, 2] = "SUB " + _words[i + 1, 0];

                                                break;
                                            }
                                            else if (machineCode[k, 2][0] == 'A' || machineCode[k, 2][0] == 'S')
                                            {
                                                continue;
                                            }
                                            else
                                            {

                                                Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "No Available Space, Cannot Perform SUB " + _words[i + 1, 0]);
                                                break;
                                            }
                                        }


                                    }

                                }
                            }

                        }


                    }
                    else if (_words[i, 0] == "OUT") {
                        for (int k = 1; k <= 6; k++)
                        {
                            if (machineCode[k, 2] == "-")
                            {
                                machineCode[k, 1] = "11101111";
                                machineCode[k, 2] = "OUT";

                                break;
                            }
                            else if (machineCode[k, 2][0] == 'A' || machineCode[k, 2][0] == 'S')
                            {
                                continue;
                            }
                            else
                            {

                                Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "No Available Space, Cannot Perform OUT " + _words[i + 1, 0]);
                                break;
                            }
                        }
                    
                    }
                    else if (_words[i, 0] == "HLT")
                    {
                        for (int k = 1; k <= 6; k++)
                        {
                            if (machineCode[k, 2] == "-")
                            {
                                machineCode[k, 1] = "11111111";
                                machineCode[k, 2] = "HLT";

                                break;
                            }
                            else if (machineCode[k, 2][0] == 'A' || machineCode[k, 2][0] == 'S' || machineCode[k, 2][0] == 'O')
                            {
                                continue;
                            }
                            else
                            {

                                Errors.Add("Line " + _words[i, 1] + " Column " + _words[i, 2] + " :      " + "No Available Space, Cannot Perform HLT " + _words[i + 1, 0]);
                                break;
                            }
                        }

                    }
                    
           
            }

            return Errors;
        }
    }
}
