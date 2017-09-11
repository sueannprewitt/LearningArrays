using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace TestArrayLibrary {
	class Program {

		void Run() {
			var aStudent = LearningArrays.Students[3];
			Console.WriteLine($"The second student in the array is {aStudent}");

			//Iterating through all items in the array
			var Total = 0;
			for(var idx = 0; idx < LearningArrays.TestScores.Count(); idx++) {
				Total += LearningArrays.TestScores[idx];
			}

			var Average = ((double) Total) / LearningArrays.TestScores.Count();
			Console.WriteLine($"The sum of the scores is {Total}; the average is {Average}");

			var TotalFrames = 0;
			//for(var idx = 0; idx < LearningArrays.Frames.Count(); idx++) {
			 //TotalFrames += LearningArrays.Frames[idx];

			foreach(var score in LearningArrays.Frames) {
					TotalFrames += score;
			}

			var FrameAverage = ((double) TotalFrames) / LearningArrays.Frames.Count();

			Console.WriteLine($"Bowling score is {TotalFrames}; average score is {FrameAverage}");
			Console.WriteLine($"BowlingScore 1,6 is {LearningArrays.BowlingScores[1, 6]}");


			LearningArrays.GradingScores.Add(97);
			LearningArrays.GradingScores.Add(89);
			LearningArrays.GradingScores.Add(34);
			LearningArrays.GradingScores.Add(98);
			LearningArrays.GradingScores.Add(99);
			LearningArrays.GradingScores.Remove (97);
			var idx2 = LearningArrays.GradingScores.IndexOf(99);
			LearningArrays.GradingScores[idx2] = 65;

			Console.WriteLine($"There are {LearningArrays.GradingScores.Count() } items in the list");
			foreach(var score in LearningArrays.GradingScores) {
				Console.WriteLine($"A score is {score}");
			}
		}
				
			

		static void Main(string[] args) {
			new Program().Run();
		}
	
}
}
