// Author: Martin Strelec 
// Purpose: Class made for reading and outputing from a .csv or csv styled file format into a List
// Constructor: new SimpleDatabase("<path>", number of data fields on one line)
// Usage: You can access the data the same way as in two dimensional array
//      : Object keeps count of lines. Accessed by lineCount

using System.ComponentModel;

namespace QSimpleDatabase
{
    public class SimpleDatabase
    {
        private List<string[]> _table = new List<string[]>();
        private string _path;
        private int lineCount;

        public List<string[]> Table
        {
            get { return _table; }
        }

        public string Path
        {
            get { return _path; }
        }

        public int LineCount
        {
            get { return lineCount; }
        }

        public SimpleDatabase(string path, int recordLength)
        {
            _path = path;
            List<string[]> _table = new List<string[]>();
            ReadFile(path, recordLength);
        }

        public void ReadFile(string path, int length)
        {
            string[] data;
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        data = s.Split(',');
                        if (data.Length != length)
                        {
                            throw new Exception("Incorrect file format!");
                        }
                        else
                        {
                            _table.Add(data);
                        }
                        lineCount++;
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override string ToString()
        {
            return "Path:"+Path+" LineCount: "+LineCount;
        }
    }
}