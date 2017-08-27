using System;
using System.Collections.Generic;
using System.Text;
using MusicListDAL;
using static System.Console;

namespace MusicListDAL
{
    public class Introduction
    {
        public static void Showmenu()
        {
            string[] menuItems = {
                "List of all musics",
                "Add music",
                "Delete music",
                "Edit music",
                "Exit"
            };

            var MenuOptions = ShowMenu(menuItems);
            while (MenuOptions != 5)
            {
                switch (MenuOptions)
                {
                    case 1:
                        MusicManager.ShowAllMusics();
                        break;
                    case 2:
                        MusicManager.AddMusic();
                        break;
                    case 3:
                        MusicManager.DeleteMusic();
                        break;
                    case 4:
                       MusicManager.EditVideo();
                        break;
                    default:
                        break;
                }
            }
            WriteLine("Bye bye!!");
            Environment.Exit(0);
        }
        public static int ShowMenu(string[] MenuOptions)
        {
            WriteLine("<><><><><><><><><><><><><><><><><><>\n" +
                      "||  Welcome To KOPI'S Music List  ||\n" +
                      "||   Select what you want to do:  ||\n" +
                      "<><><><><><><><><><><><><><><><><><>\n"
                      );
            for (int i = 0; i < MenuOptions.Length; i++)
            {
                WriteLine((i + 1) + ":" + MenuOptions[i]);
            }
            int selection;
            while (!int.TryParse(ReadLine(), out selection)
                || selection < 1
                || selection > 5)
            {
                WriteLine("Please select a number between 1-5");
            }
            return selection;
        }
        public static void ExitorNot()
        {
            WriteLine("Do you want to do more options ? type y if yes n if no");
            string yesorno = ReadLine();
            if (yesorno.ToUpper() == "y".ToUpper() || yesorno.ToUpper() == "yes".ToUpper())
            {
                Clear();
                Showmenu();
            }
            else if (yesorno.ToUpper() == "n".ToUpper() || yesorno.ToUpper() == "no".ToUpper())
            {
                Environment.Exit(0);
            }
            else
            {
                ReadLine();
                Clear();
                Showmenu();
            }
        }
    }
}
