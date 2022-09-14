using System;

namespace LuaBundler
{
    public static class Logger
    {
        public static void Warn(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Error(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void Success(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}