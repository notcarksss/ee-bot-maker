using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EEBotZ
{
    /// <summary>
    /// Contains info for where a player spawns at upon reset.
    /// </summary>
    public class SpawnInfo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="position"></param>
        public SpawnInfo(int userID, Point position)
        {
            UserID = userID;
            Position = position;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        public SpawnInfo(int userID, int posX, int posY)
        {
            UserID = userID;
            Position.X = posX;
            Position.Y = posY;
        }

        /// <summary>
        /// The ID of the user.
        /// </summary>
        public int UserID;

        /// <summary>
        /// The position of the user.
        /// </summary>
        public Point Position;
    }
}
