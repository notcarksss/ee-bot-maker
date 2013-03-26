using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EEBotZ
{
    /// <summary>
    /// Contains info for what blocks are contained at a particular location in the world.
    /// </summary>
    public class Pixel
    {
        /// <summary>
        /// The ID of the block in the foreground.
        /// </summary>
        public int Foreground = 0;

        /// <summary>
        /// The ID of the block in the background.
        /// </summary>
        public int Background = 0;

        /// <summary>
        /// The number of coins for coin door or coin gate.
        /// </summary>
        public int Coins = 0;

        /// <summary>
        /// The sound ID used for piano or drum blocks.
        /// </summary>
        public int Sound = 0;

        /// <summary>
        /// The direction in which a portal faces.
        /// </summary>
        public int Rotation = 0;

        /// <summary>
        /// The ID of this portal.
        /// </summary>
        public int ThisID = 0;

        /// <summary>
        /// The ID of the target portal.
        /// </summary>
        public int TargetID = 0;

        /// <summary>
        /// 
        /// </summary>
        public string Text = "";
    }
}
