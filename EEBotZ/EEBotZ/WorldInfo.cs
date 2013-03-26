using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EEBotZ
{
    /// <summary>
    /// 
    /// </summary>
    public class WorldInfo
    {
        #region Variables

        /// <summary>
        /// The world ID.
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// The number of online users in the world.
        /// </summary>
        public int OnlineUsers { get; private set; }

        /// <summary>
        /// The type of world.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> Data { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return Data["name"]; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Plays
        {
            get { return Convert.ToInt32(Data["plays"]); }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Locked
        {
            get { return Convert.ToBoolean(Data["needskey"]); }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Saved
        {
            get { return Convert.ToBoolean(Data["owned"]); }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Beta
        {
            get { return Convert.ToBoolean(Data["beta"]); }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Rating
        {
            get { return Convert.ToInt32(Data["rating"]); }
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="onlineUsers"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
        public WorldInfo(string id, int onlineUsers, string type, Dictionary<string, string> data)
        {
            ID = id;
            OnlineUsers = onlineUsers;
            Type = type;
            Data = data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="onlineUsers"></param>
        /// <param name="type"></param>
        public WorldInfo(string id, int onlineUsers, string type)
        {
            ID = id;
            OnlineUsers = onlineUsers;
            Type = type;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="plays"></param>
        /// <param name="locked"></param>
        /// <param name="saved"></param>
        /// <param name="beta"></param>
        /// <param name="rating"></param>
        /// <returns></returns>
        public static Dictionary<string, string> CreateWorldData(string name, Nullable<int> plays, Nullable<bool> locked, Nullable<bool> saved, Nullable<bool> beta, Nullable<int> rating)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            if (name != null && name != "") data.Add("name", name);
            if (plays.HasValue) data.Add("plays", plays.Value.ToString());
            if (locked.HasValue) data.Add("needskey", locked.Value.ToString());
            if (saved.HasValue) data.Add("owned", saved.Value.ToString());
            if (beta.HasValue) data.Add("beta", beta.Value.ToString());
            if (rating.HasValue) data.Add("rating", rating.Value.ToString());
            return data;
        }
    }
}
