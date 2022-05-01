using TechnicalTests.LevelThree.Services;

namespace TechnicalTests.LevelThree
{
    public class LevelThree
    {
        private static string Hello(string command)
        {
            int idx = command.IndexOf(' ');
            string arg1 = command.Substring(idx + 1);
            Console.WriteLine("Hello, " + arg1, ", and welcome to the micro-app LevelThree! What can I do for you?");
            return "";
        }

        private static string Add(string command)
        {
            int idx = command.IndexOf(' ');
            string arg1 = command.Substring(idx + 1, command.IndexOf(' ', idx + 1) - idx - 1);
            string arg2 = command.Substring(command.IndexOf(' ', idx + 1) + 1);
            return int.Parse(arg1) + int.Parse(arg2) + "";
        }

        private static string Print(string command)
        {
            int idx = command.IndexOf(' ');
            var svc = new PrinterService();
            string arg1 = command.Substring(idx + 1);
            svc.PrintFile(arg1);
            return "";
        }

        private static string List(string command)
        {
            Console.WriteLine("Here are the different commands available :");
            Console.WriteLine("   Hello -> welcomes user to the app. No parameter required.");
            Console.WriteLine("   Add -> return an integer sum of x and y. Parameters x and y which must both be integers.");
            Console.WriteLine("   Print -> prints file. Parameter : name of file to be printed which must be a string.");
            return command;
        }

        private static IDictionary<string, Func<string, string>> commands = new Dictionary<string, Func<string, string>>();
        private static Func<string, string>[] cmds = { Hello, Add, Print, List, Coffee.GetCoffee };


        private static IDictionary<string, Func<string, int>> commandsInt = new Dictionary<string, Func<string, int>>();
        private static Func<string, int>[] cmdsInt = { Coffee.GetSugar };

        public static void Init()
        {
            if (commands.Count == 0) 
            {
                foreach (Func<string, string> cmd in cmds)
                {
                    commands.Add(cmd.Method.Name, cmd);
                }

                foreach (Func<string, int> cmd in cmdsInt)
                {
                    commandsInt.Add(cmd.Method.Name, cmd);
                }
            }
        }

        public static string Execute(string command)
        {
            Init();

            int idx = command.IndexOf(' ');
            int index = idx != -1 ? idx : command.Length;
            string cmd = command.Substring(0, index);

            if (!commands.ContainsKey(cmd) && !commandsInt.ContainsKey(cmd))
            {
                string errorMessage = "Error, command " + cmd + " not found";
                Console.WriteLine(errorMessage);
                return errorMessage;
            }

            if(commands.ContainsKey(cmd)) return commands[cmd](command);

            return commandsInt[cmd](command).ToString();
        }
    }

    internal class PrinterService
    {
        public void PrintFile(string filename)
        {
            Console.WriteLine("Printing file " + filename + " on the printer");
        }
    }
}
