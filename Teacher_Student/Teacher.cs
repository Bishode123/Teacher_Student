namespace Teacher_Student
{
    public class Teacher
    {
        public bool teach()
        {
            Student S1 = new Student();
            bool result = S1.learn();
            return result;
        }
    }
}