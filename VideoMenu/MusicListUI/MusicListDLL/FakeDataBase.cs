using System;
using System.Collections.Generic;
using System.Text;
using MusicListEntities;


namespace MusicListDAL
{
    public class FakeDataBase
    {
        
        static int id = MusicManager.allMusics.Count + 1;
        
        static Music m1 = new Music()
        {
            Id = id++,
            Name = "MachineGunKelly - Sail",
            Style = "Trap"
        };
        static Music m2 = new Music()
        {
            Id = id++,
            Name = "T-Pain - Church",
            Style = "Pop"

        };
        static Music m3 = new Music()
        {
            Id = id++,
            Name = "Copy con - Ganja Mama",
            Style = "Raggie"

        };
        static Music m4 = new Music()
        {
            Id = id++,
            Name = "Pentatonix - Radio Active",
            Style = "Acapella"
        };
        static public void addMusics()
        {
            MusicManager.AddSpecificMusic(m1);
            MusicManager.AddSpecificMusic(m2);
            MusicManager.AddSpecificMusic(m3);
            MusicManager.AddSpecificMusic(m4);
        }
        
    }
    
}
