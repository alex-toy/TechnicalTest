namespace TechnicalTests.LevelTwo
{
    public class Solution
    {
        public static int Calculate(string operations)
        {
            if(operations.Length == 0) return 0;
            return int.Parse(Reduce(operations));
        }

        /// <summary>
        /// Returns result of reverse polish notation in string format.
        /// </summary>
        /// <param name="operations">String of operands and operators, separated by comas and formated for reverse polish notation.</param>
        /// <returns>Result of operations in string format.</returns>
        private static string Reduce(string operations)
        {
            string[] operationList = operations.Split(" ");
            if (operationList.Count() == 1) return operations;

            string result = "";
            int plusIndex = Array.IndexOf(operationList, "+");
            int minusIndex = Array.IndexOf(operationList, "-");
            int divisionIndex = Array.IndexOf(operationList, "/");
            int multiplicationIndex = Array.IndexOf(operationList, "*");
            int[] indexes = { plusIndex, minusIndex, divisionIndex, multiplicationIndex };
            int index = indexes.Where(i => i >= 0).Min();
            int operandLeft = int.Parse(operationList[index - 2]);
            int operandRight = int.Parse(operationList[index - 1]);

            if (plusIndex == index)
            {
                result = (operandLeft + operandRight).ToString();
            }
            else if (minusIndex == index)
            {
                result = (operandLeft - operandRight).ToString();
            }
            else if (divisionIndex == index)
            {
                result = (operandLeft / operandRight).ToString();
            }
            else if (multiplicationIndex == index)
            {
                result = (operandLeft * operandRight).ToString();
            }

            string[] leftArray = operationList.Take(index - 2).ToArray();
            string[] middleArray = { result };
            string[] rightArray = operationList.Skip(index + 1).Take(operationList.Length).ToArray();
            string[] finalArray = leftArray.Concat(middleArray).Concat(rightArray).ToArray();
            string finalString = String.Join(" ", finalArray);
            return Reduce(finalString);
        }
    }
}
