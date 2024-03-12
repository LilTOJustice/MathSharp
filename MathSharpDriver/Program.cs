using MathSharp;

namespace MathSharpDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FVec2 fVec2 = new FVec2(1, 2);
            Vec2 vec2 = new Vec2(1, 2);
            for (int i = 0; i < 10000000; i++)
            {
                vec2.Rotate(new Radian(1));
            }
        }
    }
}