// Author: Martin Strelec
// Purpose: Creates a simple menu object with option prompt and heading
// Constructor: new Menu("<string[] options>", "<heading>")

using System.Linq.Expressions;

namespace QMenu
{
    public class Menu
    {
        private string[] _menuOptions;
        private string _menuName;

        public string[] MenuOptions
        {
            get { return _menuOptions; }
            set { _menuOptions = value; }
        }

        public string MenuName
        {
            get { return _menuName; }
            set { _menuName = value; }
        }

        public Menu(string[] o, string n)
        {
            _menuOptions = o;
            _menuName = n;
        }

        public void MenuPrint()
        {
            Console.WriteLine("");
            Console.WriteLine($"{MenuName} Menu");
            for (int i = 0; i < MenuOptions.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {MenuOptions[i]}");
            }
            Console.WriteLine($"{MenuOptions.Length + 1}. Exit");
        }

        public int GetMenuOption()
        {
            bool exit = false;
            int option = 0;

            try
            {
                Console.Write("Enter option: ");
                option = int.Parse(Console.ReadLine());
                while (exit == false)
                {
                    if (option <= 0 || option > MenuOptions.Length + 1)
                    {
                        Console.WriteLine("Wrong input!");
                        Console.WriteLine("> ");
                        option = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        exit = true;
                    }
                }
                Console.WriteLine("");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            return option;
        }

        public override string ToString()
        {
            return "Name: "+MenuName+" Options "+MenuOptions.Length;
        }
    }
}
