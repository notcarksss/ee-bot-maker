using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EEBotZ
{
    public class RoomInfo
    {
        public string ID { get; private set; }
        public int OnlineUsers { get; private set; }
        public Dictionary<string, string> RoomData { get; private set; }
        public string RoomType { get; private set; }

        public RoomInfo(string id, int onlineUsers, Dictionary<string, string> roomData, string roomType)
        {
            ID = id;
            OnlineUsers = onlineUsers;
            RoomData = roomData;
            RoomType = roomType;
        }
    }
}
