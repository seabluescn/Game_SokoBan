using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanLib
{
    public enum MapState
    {
        GLASS = 0,
        WALL = 1,
        ROAD = 2,
        MAN = 3,
        BOX = 4,
        DIRECT = 5,
        DIRECT_MAN = 8,
        DIRECT_BOX = 9
    }

}
