class Program
{
    static void Main(string[] args)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animation)
            {
                Console.Write(s);
                Thread.Sleep(350);
                Console.Write("\b \b");
            }
        } 
    }
}