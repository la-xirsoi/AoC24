using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC24.Day1
{
	internal class Day1
	{
		public static Int32 SolvePart1(List<String> input)
		{
			Int32 diff = 0;

			List<Int32> left, right;

			ParseInputs(input, out left, out right);

			left.Sort();
			right.Sort();

			for (int i = 0; i < left.Count; i++)
			{
				diff += Math.Abs(left[i] - right[i]);
			}

			return diff;
		}

		public static Int32 SolvePart2(List<String> input)
		{
			Int32 similarity = 0;

			List<Int32> left, right;

			ParseInputs(input, out left, out right);

			left.Sort(); right.Sort();

			for (int i = 0; i < left.Count; i++)
			{
				similarity += left[i] * right.FindAll(x => x == left[i]).Count;
			}

			return similarity;
		}

		private static void ParseInputs(List<String> input, out List<Int32> left, out List<Int32> right)
		{
			left = new List<Int32>();
			right = new List<Int32>();

			foreach (var line in input)
			{
				var bits = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

				left.Add(Int32.Parse(bits[0]));
				right.Add(Int32.Parse(bits[1]));
			}
		}
	}
}
