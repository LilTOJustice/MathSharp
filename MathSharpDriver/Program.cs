using MathSharp;

namespace MathSharpDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FVec2 fVec2 = new FVec2(1, 2);
            FVec3 fVec3 = new FVec3(3, 4, 7);
            fVec2 = fVec2["yx"];
            Console.WriteLine(fVec2); // 2, 1
            fVec3 = fVec3["zyx"];
            Console.WriteLine(fVec3); // 7, 4, 3
            fVec2["yx"] = fVec3["brg"];
            Console.WriteLine(fVec2); // 4, 3
            FVec2 other = new FVec2(4, 5);
            fVec2["yx"] = other;
            Console.WriteLine(fVec2); // 5, 4
        }
    }
}