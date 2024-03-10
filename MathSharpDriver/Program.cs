using MathSharp;

namespace MathSharpDriver
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            FVec2 fVec2 = new FVec2(1, 2);
            fVec2[0] = 3;
            fVec2 = fVec2.Swizzle("yx");
            Console.WriteLine(fVec2);
        }
    }
}