using System;
class PenDistribution{
	static int penPerStudent;
	static int remainingPen;
	static void Main(String[] args){
		int totalPen = 14;
		int studentCount = 3;
		penProblem(totalPen,studentCount);
		Console.WriteLine($"The Pen Per Student is {penPerStudent} and the remaining pen not distributed is {remainingPen}");
	}
	//this method calculates pen per student and remaining pen count
	static void penProblem(int totalPen , int studentCount){
		penPerStudent = totalPen/studentCount;
		remainingPen = totalPen%studentCount;
	}
}
		
		