using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        [DllImport("hello1.dll")]
        public static extern void HelloWorld(string name);

        [DllImport("hello1.dll", EntryPoint = "HelloWorld")]

        public static extern void testFunction(string name);

        //[DllImport("hello1.dll")]
        //public static extern int checkName(string s, ref byte info);
        [DllImport("Encrypt.dll")]
        public static extern int getEncodeString(string s, ref byte info);

        [DllImport("FileCheck.dll")]
        public static extern int checkName(string s, ref byte info);
        [DllImport("FileCheck.dll")]
        public static extern int getFileType(string fileName);
        //[DllImport("Encrypt.dll")]
        //public static extern string checkName(string s);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! C#");
            HelloWorld("Hello C++");
            testFunction("Hello c++");
            byte[] s = new byte[1024];
            int result = checkName("aaa", ref s[0]);
            //string info = System.Text.Encoding.Default.GetString(s, 0, s.Length);
            StringBuilder info = new StringBuilder();
            for (int i=0;i <s.Length;++i)
            {
                if(s[i]!=0)
                {
                    info.Append((char)s[i]);
                } else
                {
                    break;
                }
            }
            Console.WriteLine(info.Length);
            Console.WriteLine(info);
            Console.WriteLine("Password");
            byte[] password = new byte[256];
            int res = getEncodeString("a", ref password[0]);
            StringBuilder psw = new StringBuilder();
            for (int i = 0; i <password.Length;++i)
            {
                //if(password[i] != 0)
                //{
                //    psw.Append((char)password[i]);
                //} else
                //{
                //    break;
                //}
                psw.Append((char)password[i]);
            }

            
            Console.WriteLine(psw);
            Console.WriteLine(getFileType("FILE.PNG"));
            Console.ReadLine();
        }
    }
}
