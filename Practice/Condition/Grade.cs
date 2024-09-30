namespace Practice.Condition
{
    public class Grade
    {
        public void Main()
        {
            int marks = 85;
            string grade = "F";

            if (marks >= 90)
            {
                grade = "A";
            }
            else if (marks >= 80 && marks < 90)
            {
                grade = "B";
            }
            else if (marks >= 70)
            {
                grade = "C";

            }
            else
            {
                grade = "F";

            }



            Console.WriteLine(grade);
        }
    }
}
