using System;
using static System.Console;
using MusicListDAL;

namespace MusicListUI
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeDataBase.addMusics();
            Introduction.Showmenu();
        }
        
        
        
    }


}

