internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = ("amen");
      Console.Write("hi. what is your name:");
      string userName = Console.ReadLine();
      Console.WriteLine("ok " + userName + " lets start");

      double num01;
      double num02;

      Console.Write( userName + " please put a number: ");
      num01 = Convert.ToDouble( Console.ReadLine() );
      Console.Write("now please input a 2nd number for me:");
      num02 = Convert.ToDouble( Console.ReadLine() );

      double Result = num01 * num02;
      Console.WriteLine("This Is The Result:" + Result + " are you happy with your result " + userName);
      string yesOrNo = Console.ReadLine();
      Console.WriteLine("Thank You For Your Feedback. " + userName + " Feedback: " + yesOrNo + " :)");
      

        //press key before closing
        Console.ReadKey();
    }
}