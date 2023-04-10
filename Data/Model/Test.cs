using System.Collections.Generic;

namespace TestingSystemData.Model
{
    public class Test
    {
        public int TestId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string XmlContent { get; set; }

        public virtual ICollection<Result> Results { get; } = new List<Result>();
    }
}
