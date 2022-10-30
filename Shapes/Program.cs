namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Name = "rect1";
            rectangle1.PosX = 23;
            rectangle1.PosY = 17;
            rectangle1.Height = 54;
            rectangle1.Width = 33;
            Rectangle rectangle2 = new Rectangle();
            rectangle2.Name = "rect2";
            rectangle2.PosX = 45;
            rectangle2.PosY = 86;
            rectangle2.Height = 59;
            rectangle2.Width = 97;

            Console.WriteLine($"Rectangle1 Name = {rectangle1.Name} Area = {rectangle1.Area} Starting Point = {rectangle1.Start} Width = {rectangle1.Width} Height = {rectangle1.Height}");
            Console.WriteLine($"Rectangle2 Name = {rectangle2.Name} Area = {rectangle2.Area} Starting Point = {rectangle2.Start} Width = {rectangle2.Width} Height = {rectangle2.Height}");
        }
    }
}