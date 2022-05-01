namespace TechnicalTests.LevelThree.Services
{
    public static class Coffee
    {
        public static string GetCoffee(string command)
        {
            int idx = command.IndexOf(' ');
            string arg1 = command.Substring(idx + 1);
            return "Here is some coffee, " + arg1 + " cups exactly!";
        }
        public static int GetSugar(string command)
        {
            int idx = command.IndexOf(' ');
            string arg1 = command.Substring(idx + 1);
            return int.Parse(arg1);
        }
    }
}
