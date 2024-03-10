using MathSharp;

namespace MathSharpDriver
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            FVec2 fVec2 = new FVec2(1, 2);
            fVec2[0] = 3;
            fVec2 = fVec2["yx"];
            Console.WriteLine(fVec2);
            FVec2 other = new FVec2(4, 5);
            fVec2["yx"] = other;
            Console.WriteLine(fVec2);
        }
    }
}