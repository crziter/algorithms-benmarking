using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public interface Algorithm
    {
        Input Input { get; set; }
        Output Output { get; set; }
        AlgorithmInformations Info { get; set; }
        Boolean PrepareInput();
        Boolean Performance();
        Boolean PrintOutput();
        Boolean GenerateInput(int n, Output output);
    }
}
