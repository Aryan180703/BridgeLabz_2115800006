using System;
class GradeAndRemark{
    static void Main(String[] args){
        Console.Write("Enter marks in Physics : ");
        int marks1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter marks in Chemistry : ");
        int marks2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter marks in Maths : ");
        int marks3 = Convert.ToInt32(Console.ReadLine());
        //calculating average
        double average = (double)(marks1+marks2+marks3)/3;
        //calling method
        Grade(average);

    }
    //this method will print the average marks with grade and remark
    static void Grade(double averageMarks){
        char Grade;
        if(averageMarks>=80){
            Grade = 'A';
            Console.WriteLine($"Average Marks : {averageMarks} \nGrade : {Grade}\nRemark : Level 4, above agency-normalized standards");
        }
        else if(averageMarks>=70&&averageMarks<80){
            Grade = 'B';
            Console.WriteLine($"Average Marks : {averageMarks} \n Grade : {Grade}\n Remark : Level 3, at agency-normalized standards");
        }
        else if(averageMarks>=60&&averageMarks<70){
            Grade = 'C';
            Console.WriteLine($"Average Marks : {averageMarks} \n Grade : {Grade}\n Remark : Level 2, below but approaching agency-normalized standards");
        }
        else if(averageMarks>=50&&averageMarks<60){
            Grade = 'D';
            Console.WriteLine($"Average Marks : {averageMarks} \n Grade : {Grade}\n Remark : Level 1, well below agency-normalized standards");
        }
        else if(averageMarks>=40&&averageMarks<50){
            Grade = 'E';
            Console.WriteLine($"Average Marks : {averageMarks} \n Grade : {Grade}\n Remark : Level 1, too below agency-normalized standards");
        }
        else{
            Grade = 'R';
            Console.WriteLine($"Average Marks : {averageMarks} \n Grade : {Grade}\n Remark : Remedials standards");
        }
    }
}