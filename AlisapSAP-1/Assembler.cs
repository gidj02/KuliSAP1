using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kuliSAP1
{
    class Assembler
    {
        public String assemble(String[,] machineCode)
        {
            String binFile="";

            for (int i = 0; i <= 15; i++) {
                binFile = String.Concat(binFile,"A"+machineCode[i, 0] + machineCode[i, 1] + "\n"); 
            }

            return binFile;
        }

    }
}
