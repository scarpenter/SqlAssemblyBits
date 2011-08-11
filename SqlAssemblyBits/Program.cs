using System;
using System.IO;
using System.Text;

namespace Carpenter.SqlAssemblyBits
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var prog = new Program();
            prog.Run(args[0]);
        }

        private void Run(string dllPath)
        {
            var bits = new StringBuilder("0x");
            using (var fs = new FileStream(dllPath, FileMode.Open, FileAccess.Read))
            {
                var buffer = new byte[8192];
                int bytesRead = fs.Read(buffer, 0, buffer.Length);
                while (bytesRead > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        bits.Append(buffer[i].ToString("X2"));
                    }
                    bytesRead = fs.Read(buffer, 0, buffer.Length);
                }
            }
            Console.WriteLine(bits.ToString());
        }
    }
}
