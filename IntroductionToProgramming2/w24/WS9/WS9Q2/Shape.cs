namespace QShape
{
    class Shape
    {
        static string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value;}
        }

        public Shape()
        {

        }
        public virtual double CalcArea()
        {
            return 0;
        }

        public virtual double CalcPerimeter()
        {
            return 0;
        }
    }
}