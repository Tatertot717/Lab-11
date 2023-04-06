namespace Lab_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baby[] Babies = new Baby[5];
            Babies[0] = new Baby("Noah");
            Babies[1] = new Baby("Olivia");
            Babies[2] = new Baby("Liam");
            Babies[3] = new Baby("Emma");
            Babies[4] = new Baby("Amelia");

            foreach (var item in Babies)
            {
                Thread b = new(item.Run);
                b.Start();
            }
        }
    }

    public class Baby
    {
        int time;
        string name;

        public Baby(string name) 
        {
            this.name = name;
            Random rand = new Random();
            time = rand.Next(5000);
        }
        public void Run() 
        {
            try
            {
                Console.WriteLine("My name is " + name + " I am going to sleep for " + time + "ms");
                Thread.Sleep(time);
                Console.WriteLine("My name is " + name + "  and I'm awake,feed me!!!");
            }
            catch(ThreadInterruptedException e) { Console.WriteLine(e.Message); };
        }
    }
}