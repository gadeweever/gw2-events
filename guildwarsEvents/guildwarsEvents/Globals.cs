using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guildwarsEvents
{
    public static class Globals
    {
        #region Variable Declarations
        private static int _worldID;
        private static int _mapID;
        private static int _eventID;
        private static World _currentWorld;
        #endregion

        #region Variable Definitions
        public static int WorldID
        {
            get
            {
                return _worldID;
            }
            set
            {
                _worldID = value;
            }
        }

        public static int MapID
        {
            get
            {
                return _mapID;
            }
            set
            {
                _mapID = value;
            }
        }

        public static int EventID
        {
            get
            {
                return _eventID;
            }
            set
            {
                _eventID = value;
            }
        }

        public static World CurrentServer
        {
            get
            {
                return _currentWorld;
            }
            set
            {
                _currentWorld = value;
            }
        }
        #endregion

    }
}
