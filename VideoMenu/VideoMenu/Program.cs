using System;
using System.Collections.Generic;
using static System.Console;

namespace VideoMenu
{
    class Program
    {
        static int id = 1;

        static List<Music> AllMusics = new List<Music>();

        static void Main(string[] args)
        {
            var m1 = new Music()
            {
                Id = id++,
                Name = "MachineGunKelly - Sail",
                Style = "Trap"

            }; AllMusics.Add(m1);
            var m2 = new Music()
            {
                Id = id++,
                Name = "Copy Con - Ganja Mama",
                Style = "Raggie"

            }; AllMusics.Add(m2);
            Showmenu();
        }

        static void Showmenu()
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
                        ShowAllMusics();
                        break;
                    case 2:
                        AddMusic();
                        break;
                    case 3:
                        DeletMusic();
                        break;
                    case 4:
                        EditVideo();
                        break;
                    default:
                        break;
                }
            }
            WriteLine("Bye bye!!");
            Environment.Exit(0);
        }

        static void ShowAllMusics()
        {
            WriteLine("Here you can see all the stored musics:\n");
            foreach (var item in AllMusics)
            {
                WriteLine($"Id: { item.Id}\n" +
                          $"Name: {item.Name }\n" +
                          $"Style: {item.Style }\n");
            }
            WriteLine("\n");
            ExitorNot();
        }

        static void ExitorNot()
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
                WriteLine("Are you Drunk?! yes or no? ok try it again? (just press enter if yes ;) ))");
                ReadLine();
                Clear();
                Showmenu();
            }
        }

        static void AddMusic()
        {
            WriteLine("The name of the music: \n");
            var name = ReadLine();

            WriteLine("The Style of the music: \n");
            var style = ReadLine();

            AllMusics.Add(new Music()
            {
                Id = id++,
                Name = name,
                Style = style
            });
            WriteLine("You successfully added " + name + " to the list");
            ExitorNot();
        }

        static void DeletMusic()
        {
            var videoFound = FindMusicById();
            if (videoFound != null)
            {
                AllMusics.Remove(videoFound);
            }
            ExitorNot();
        }

        public static Music FindMusicById()
        {
            WriteLine("Insert Music Id: \n");
            int id;
            while (!int.TryParse(ReadLine(), out id))
            {
                WriteLine("Please insert a number");
            }

            foreach (var video in AllMusics)
            {
                if (video.Id == id)
                {
                    return video;
                }
            }
            return null;
        }

        static void EditVideo()
        {
            var Music = FindMusicById();
            WriteLine("Enter the new name of the music:\n");
            Music.Name = ReadLine();            
            WriteLine("Enter the new style of the music:\n");
            Music.Style = ReadLine();
            WriteLine("You successfully changed the nem of the music");
            ExitorNot();
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
    }
    }

