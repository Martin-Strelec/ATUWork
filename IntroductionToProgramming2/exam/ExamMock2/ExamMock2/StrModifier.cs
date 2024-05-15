/*
    Class made for formatting strings 
*/


namespace ExamMock2
{
    class StrModifier
    {
        public StrModifier()
        {
        }

        public string SimplifyString(string input) //only input lowercase characters
        {
            List<int> removeIndex = new List<int>();
            string inputTemp = input.ToLower();
            char rmChar = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                if (inputTemp[i] == rmChar)
                {
                    removeIndex.Add(i);
                }
            }

            for (int i = 0; i < removeIndex.Count; i++)
            {
                inputTemp = inputTemp.Remove(removeIndex[i] - i, 1);
            }
            return inputTemp;
        }

        public string RemoveChar(char rmChar, string input) //only input lowercase characters
        {
            List<int> removeIndex = new List<int>();
            string inputTemp = input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                if (inputTemp[i] == rmChar)
                {
                    removeIndex.Add(i);
                }
            }

            for (int i = 0; i < removeIndex.Count; i++)
            {
                inputTemp = inputTemp.Remove(removeIndex[i] - i, 1);
            }
            return inputTemp;
        }

    }
}