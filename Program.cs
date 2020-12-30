using System;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Info NCIStudent = new Info();


           
            Console.WriteLine(NCIStudent.StudentFullname + "" + NCIStudent.StudentUniverity);

            Student ncistudent = new Student();


            ncistudent.Info();


        }
    }
}
