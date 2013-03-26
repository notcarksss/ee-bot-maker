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
        /// The ID of the user.
        /// </summary>
        public int UserID;

        /// <summary>
        /// The position of the user.
        /// </summary>
        public Point Position;
    }
}
