using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.IsolatedStorage;


namespace guildwarsEvents
{
    public static class Globals
    {
        #region Variable Declarations
        private static int _mapID;
        private static int _eventID;
        private static GuildWorld _currentWorld;
        private static GuildMap _currentMap;
        private static SaveData _saveData;
        private static GuildEvent _currentEvent;
        #endregion

        #region Variable Definitions
        public static GuildEvent CurrentEvent
        {
            get { return _currentEvent; }
            set { _currentEvent = value; }
        }
        public static GuildMap CurrentMap
        {
            get
            {
                return _currentMap;
            }
            set
            {
                _currentMap = value;
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

        public static GuildWorld CurrentServer
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

        public static SaveData StorageSave
        {
            get
            {
                return _saveData;
            }
            set
            {
                _saveData = value;
            }
        }
        #endregion
        #region Storage Handling
        public static void SaveStorageData()
        {
            using (var filesystem = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (var fs = new IsolatedStorageFileStream(
                  "saveData.dat", FileMode.Create, filesystem))
                {
                    var serializer = new System.Runtime.Serialization
                      .Json.DataContractJsonSerializer(typeof(SaveData));
                    serializer.WriteObject(fs, _saveData);
                }
            }
        }
        #endregion

    }
}
