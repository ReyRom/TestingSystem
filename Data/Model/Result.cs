using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingSystemData.Model;

namespace TestingSystemData
{
    public partial class Result
    {
        public int ResultId { get; set; }

        public int TestId { get; set; }

        public string Username { get; set; }

        public int Score { get; set; }

        public int MaxScore { get; set; }

        public DateTime DateTime { get; set; }
        public string TestLog { get; set; }

        public virtual Test Test { get; set; }
    }
}
