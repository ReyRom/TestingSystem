using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingSystemData
{
    public partial class Result
    {
        public string ScoreString => $"{Score}/{MaxScore}";
    }
}
