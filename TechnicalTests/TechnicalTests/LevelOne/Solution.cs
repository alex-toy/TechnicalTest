namespace TechnicalTests.LevelOne
{
    public class Solution
    {
        static string filename = @"C:\source\TechnicalTestsDotnet\TechnicalTests\TechnicalTests\LevelOne\input.txt";

        public static int GetMagicNumber()
        {
            string ruleK = HandleLetter('k', 6).ToString();
            string ruleC = HandleLetter('c', 9).ToString();
            string concatRule = $"{ruleK}{ruleC}";
            int result;
            bool isParsable = Int32.TryParse(concatRule, out result);

            if (isParsable)
                Console.WriteLine(result);
            else
                Console.WriteLine("Could not be parsed.");
            return result;
        }

        public static int GetSuperMagicNumber()
        {
            string ruleK = HandleLetterAverage('k', 6).ToString();
            string ruleC = HandleLetterAverage('c', 9).ToString();
            string concatRule = $"{ruleK}{ruleC}";
            int result;
            bool isParsable = Int32.TryParse(concatRule, out result);

            if (isParsable)
                Console.WriteLine(result);
            else
                Console.WriteLine("Could not be parsed.");
            return result;
        }

        /// <summary>
        /// Handles first two rules for magic number.
        /// </summary>
        /// <param name="c">Character given for the rule</param>
        /// <param name="factor">Factor given for the rule.</param>
        /// <returns>number corresponding to the rule</returns>
        private static int HandleLetter(char c, int factor)
        {
            int numberLetter = 0;
            var lines = File.ReadLines(filename);
            foreach (var line in lines)
            {
                numberLetter += line.ToCharArray().Count(letter => char.ToLower(letter) == c );
            }
            return numberLetter * factor;
        }

        /// <summary>
        /// Handles first two rules for magic number taking average position into account.
        /// </summary>
        /// <param name="c">Character given for the rule</param>
        /// <param name="factor">Factor given for the rule.</param>
        /// <returns></returns>
        private static int HandleLetterAverage(char c, int factor)
        {
            int numberLetter = 0;
            int positionsSum = 0;
            var lines = File.ReadLines(filename);
            if (!lines.Any()) return 0;
            foreach (var line in lines)
            {
                IEnumerable<int> positions = line.ToCharArray().Select((letter, i) =>
                {
                    int linePositions = 0;
                    if (char.ToLower(letter) == c)
                    {
                        numberLetter++;
                        linePositions += i+1;
                    }
                    return linePositions;
                });
                positionsSum += positions.Aggregate(0, (acc, p) => acc + p);
            }
            return positionsSum * factor;
        }
    }
}
