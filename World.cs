using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TheEgosphere
{
    enum season { SPRING, SUMMER, FALL, WINTER }
    enum weather { CLEAR, SUNNY, WINDY, CLOUDY, LIGHTRAIN, HEAVYRAIN, LIGHTSTORM, HEAVYSTORM, LIGHTSNOW, HEAVYSNOW }
    enum direction { NORTH = 90, SOUTH = 270, EAST = 0, WEST = 180, NORTHEAST = 45, NORTHWEST = 135, SOUTHEAST = 225, SOUTHWEST = 135 }

    class World
    {
        private int season;
        private int weather;
    }

    class WorldClock
    {
        private int clockHours, clockMinutes, clockSeconds;
    }
}



