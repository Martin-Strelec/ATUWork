/*
    This class is made for reading a file and storing its contents into "database"
    You can choose if the database will be formatted or not
    This class relies on StrModifier.cs class, which is responsible for formatting the records 
*/

namespace ExamMock2
{
    class FileRead
    {
        private string _path;
        private int _dataLength;
        private char _divider;
        private List<string[]> _database;

        public string Path
        {
            get { return _path; }
        }

        public List<string[]> Database
        {
            get { return this._database; }
        }

        public FileRead(string path, int dataLength, char divider, bool formated)
        {
            this._path = path;
            this._dataLength = dataLength;
            this._divider = divider;
            this._database = new List<string[]>(ReadFile(path, dataLength, divider, formated));
        }

        //Static methods
        static List<string[]> ReadFile(string path, int dataLength, char divider, bool formated) //Method for reading a .csv file
        {
            StrModifier mod = new StrModifier();
            List<string[]> record = new List<string[]>(); //For storing and returning values  
            string[] readLine; //One line of data

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    readLine = s.Split(divider);
                    if (readLine.Length == dataLength)
                    {
                        if (formated == true)
                        {
                            for (int i = 0; i < dataLength; i++)
                            {
                                string temp = readLine[i];
                                readLine[i] = mod.SimplifyString(temp);
                            }
                            record.Add(readLine);
                        }
                        else
                        {
                            record.Add(readLine);
                        }
                    }
                }
                return record;
            }
        }
    }
}