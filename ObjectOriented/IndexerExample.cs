//An indexer allows an object to be indexed like an array. 
//It is defined with the this keyword and can take parameters.

using System;

namespace ObjectOriented
{
    internal class IndexerExample
    {
        public void run()
        {
            var studentMarks = new StudentMarks();

            studentMarks[0] = 10;
            studentMarks[1] = 20;
            studentMarks[2] = 30;
            studentMarks[3] = 35;

            // Console.WriteLine("Marks:");
            // Console.WriteLine(studentMarks[0]);

            
            var studentList = new StudentList();
            studentList[0] = "Dinesh";
            Console.WriteLine(studentList[0]);
            
        }
    }

    class StudentMarks
    {
        private int[] marks = new int[10];

        public int this[int index]
        {
            get { return marks[index]; }
            set { marks[index] = value; }
        }
    }

    class StudentList
    {
        private string[] students = new string[10];

        public string this[int index]
        {
            get { return students[index]; }
            set { students[index] = value; }
        }
    }
}
