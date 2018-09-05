using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutoPro
{
    public class Common
    {
        public static void SaveData(string path, string data)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(data);
            }
        }
    }
}
