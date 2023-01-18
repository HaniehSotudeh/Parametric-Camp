using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the CSV file and store the data in an array
            string [] csvLines = System.IO.File.ReadAllLines(@"C:\Users\hanie\OneDrive\Desktop\Parametric Camp\Coding Gem\grade.csv");
            //create a list of students 
            var students = new List<Student>();

            //a for loop to split every line and extract the params
            for (int i =1; i<csvLines.Length; i++) 
            {
                Student st = new Student(csvLines[i]);
                students.Add(st);
            }

            for (int i = 1; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            Console.ReadKey();
        }
    }

    public class Student 
    {
        //properties 
        public string firstName, lastName, SSN;
        public double[] testScores = new double[4];
        public string finalGrade;

        //constructor 
        public Student(string dataLine)
        {
            string[] parameter = dataLine.Split(',');
            firstName = parameter[0];
            lastName = parameter[1];
            SSN = parameter[2];

            double score0 = Convert.ToDouble(parameter[3]);
            testScores[0] = score0;

            double score1 = Convert.ToDouble(parameter[4]);
            testScores[1] = score1;

            double score2 = Convert.ToDouble(parameter[5]);
            testScores[2] = score2;

            double score3 = Convert.ToDouble(parameter[6]);
            testScores[3] = score3;


            finalGrade = parameter[7];
        }

        public override string ToString()
        {
            string str = $"{firstName} {lastName}: SSN: {SSN}   "
                +$"{testScores[0]}-{testScores[1]}-{testScores[2]}-{testScores[3]},"
                +$" Final Grade: {finalGrade}.";
            return str;
        }
    }
}
