int width = Convert.ToInt32(Console.ReadLine());
int Height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CalculateRectangleArea(width, Height));

static int CalculateRectangleArea(int width, int height)
{
    return width * height;
}