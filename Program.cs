namespace AoC24
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var input = File.ReadAllLines("Day2/sample.txt");

			Console.WriteLine(Day2.Day2.SolvePart1(input.ToList()));
		}
	}
}
