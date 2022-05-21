namespace simple_Shell
{
    public struct Token
    {
        public string command;
        public string value;
        public string sec_value;
    }

    class Program
    {
        public static string PATH_ON_PC = @"C:\Users\Inspiron_5587G5\source\repos\Simple Shell\Simple Shell\miniFat.txt";
        public static Directory current;
        public static string currentPath;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, This Shell Is Developed By : Mohamed Sayed Osman, Mahmoud Khairy Abdelmoez, Mahmoud Ahmed Mahmoud:)");
            Console.WriteLine("Section 3 - IS:)\n\n");
            VirtualDisk.initialize(PATH_ON_PC);


            currentPath = new string(current.dir_name);
            currentPath = currentPath.Trim(new char[] { '\0', ' ' });


            Parser parser = new Parser();



            while (true)
            {
                var currentLocation = currentPath;
                Console.Write(currentLocation + "\\>");
                current.ReadDirectory();

                string input = Console.ReadLine();
                parser.parse_input(input);
            }
        }
    }
}
