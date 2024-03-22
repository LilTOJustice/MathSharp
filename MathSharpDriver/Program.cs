using MathSharp;

namespace MathSharpDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FVec3 fVec = new FVec3(1, 0, 0);
            Console.WriteLine(fVec.Rotate(new DVec3(0, 90, 0)));
        }
    }
}