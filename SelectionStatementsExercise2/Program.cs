namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite subject in school...");
            string faveSubject = Console.ReadLine();
            string snarkyRemark;

            switch (faveSubject.ToUpper())
            {
                case "ENGLISH":
                    snarkyRemark = "Ohhh, so you're a barista?";
                    break;
                case "HISTORY":
                    snarkyRemark = "Ahh, living in the past then?";
                    break;
                case "MATH":
                case "SCIENCE":
                case "PHYSICS":
                case "CHEMISTRY":
                    snarkyRemark = "You can't really separate math and science, can you? They eventually merge.";
                    break;
                case "DRAMA":
                    snarkyRemark = "Yeah... saw that coming.";
                    break;
                default:
                    snarkyRemark = "Hmmm... I don't know that subject.";
                    break;
            }
            Console.WriteLine(snarkyRemark);
        }
    }
}