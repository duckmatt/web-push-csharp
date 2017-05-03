using NUnit.Common;
using NUnitLite;
using System;
using System.Reflection;

namespace WebPush.Test
{
    /// NUnit runner on dotnet core not currently complete, see: http://stackoverflow.com/a/43500590/2685161
    public class Program
    {
        public static int Main(string[] args)
        {
            return new AutoRun(typeof(Program).GetTypeInfo().Assembly)
                .Execute(args, new ExtendedTextWrapper(Console.Out), Console.In);
        }
    }
}