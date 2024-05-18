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

        public string SimplifyString(string input) //only input lowercase characters. Outputs lowercase string with removed whitespaces
        {
            //Variables
            List<int> removeIndex = new List<int>();
            string inputTemp = input.ToLower();
            char rmChar = ' ';
            
            //Loop seraches for match with the rmChar variable
            for (int i = 0; i < input.Length; i++)
            {
                if (inputTemp[i] == rmChar)
                {
                    removeIndex.Add(i);
                }
            }

            //Loop removes indexes defined by the previous loop
            for (int i = 0; i < removeIndex.Count; i++)
            {
                inputTemp = inputTemp.Remove(removeIndex[i] - i, 1);
            }
            return inputTemp;
        }

        public string RemoveChar(char rmChar, string input) //only input lowercase characters. Outputs lowercase string with removed characters
        {
            //Variables
            List<int> removeIndex = new List<int>();
            string inputTemp = input.ToLower();

            //Searches for match with the rmChar variable and stores their index
            for (int i = 0; i < input.Length; i++)
            {
                if (inputTemp[i] == rmChar)
                {
                    removeIndex.Add(i);
                }
            }

            //Removes indexes defined by the previous loop
            for (int i = 0; i < removeIndex.Count; i++)
            {
                inputTemp = inputTemp.Remove(removeIndex[i] - i, 1);
            }
            return inputTemp;
        }

    }
}
