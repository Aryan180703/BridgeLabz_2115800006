using System;
class SamAverageMarks{
	static void Main(String[] args){
		int marksInMaths = 94;
		int marksInPhysics = 95;
		int marksInChemistry = 96;
		int averageMarks = Average(marksInMaths,marksInPhysics,marksInChemistry);
		Console.WriteLine("Sam's average marks in PCM is " + averageMarks);
	}
	//This Method calculates average marks of three subjects and return the result
	static int Average(int marksSubject1,int marksSubject2,int marksSubject3){
		int averageMarks = (marksSubject1+marksSubject2+marksSubject3)/3; //Average marks
		return averageMarks;
	}
}