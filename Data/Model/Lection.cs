using System;
using System.IO;

namespace TestingSystemData.Model
{
    public class Lection
    {
        public int LectionId { get; set; }

        public string Name { get; set; }

        public string Group { get; set; }

        public virtual LectionContent LectionContent { get; set; }

        string filename;
        public string FileName
        {
            get
            {
                filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TestingSystem\\" + Group + "\\" + Name + ".pdf";
                if (!File.Exists(filename))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filename));
                    File.WriteAllBytes(filename, LectionContent.Content);
                }
                return filename;
            }
        }
    }
}
