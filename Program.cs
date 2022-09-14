using System;
using System.IO;

namespace LuaBundler
{
    internal class Program
    {
        private const string Root = @"C:\Users\suho\Desktop\Crypto-Punch-main";

        public static void Main(string[] args)
        {
            new Program();
        }

        private Program()
        {
            var bundler = new LuaBundler();   
            
            bundler.ToFile(Path.Combine(Root, @"src\Scripts\index.lua"), Path.Combine(Root, @"Scripts\___bundle___.lua"));
            bundler.Clear();
            bundler.ToFile(Path.Combine(Root, @"src\ServerScripts\index.lua"), Path.Combine(Root, @"ServerScripts\___bundle___.lua"));
            Console.WriteLine("Success Bundle");
        }
    }
}