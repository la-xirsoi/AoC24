using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC24.Day2
{
	internal class Day2
	{
		public static int SolvePart1(List<string> input)
		{
			var reports = ParseReports(input);

			return reports.FindAll(r =>
			{
				int dir = r[1] - r[0];

				if (dir == 0) return false;

				for (int i = 1; i < r.Length; i++)
				{
					if (Math.Abs(r[i] - r[i-1]) > 0
					&& Math.Abs(r[i] - r[i - 1]) < 4)
					{
						if ((dir < 0) != (r[i] - r[i - 1] < 0))
						{
							return false;
						}
					}
				}

				return true;
			}
			).Count();
		}

		private static List<int[]> ParseReports(List<string> input)
		{
			var reports = new List<int[]>();

			foreach (var report in input)
			{
				reports.Add(report.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray());
			}

			return reports;
		}
	}
}
