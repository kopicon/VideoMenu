using System;
using System.Collections.Generic;
using System.Text;
using MusicListEntities;

namespace MusicListBLL
{
    interface IMusicService
    {
        Music GetMusic();
        Music Add();
        Music Delete();
        Music Edit();     
    }
}
