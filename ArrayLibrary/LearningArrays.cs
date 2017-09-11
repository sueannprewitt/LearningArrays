using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{

    public class LearningArrays
    {
		public static string[] Students = { "a", "b", "c", "d", "e" };

		public static int[] TestScores = { 95, 87, 99, 92, 100 };

		public static int[] Frames = { 9, 10, 8, 7, 9, 10, 5, 10, 9, 8 };

		public static int[,] BowlingScores = new int[,] { 
			{9, 10, 8, 7, 9, 10, 5, 10, 9, 8}, //first game of 10 frames
			{5, 2, 10, 10, 10, 10, 9, 8, 10, 9}, //second game of 10 frames
			{6, 4, 10, 10, 10, 10, 10, 10, 9, 10} //third game of 10 frames   //BowlingScores [1,6] = 9 (second game, 7th score)
		};

		public static List<int> GradingScores = new List<int>();
    }
}
