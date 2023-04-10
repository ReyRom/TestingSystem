using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystemData.Model
{
    public partial class LectionContent
    {
        public int LectionId { get; set; }
        public byte[] Content { get; set; }

        public virtual Lection Lection { get; set; }
    }
}
