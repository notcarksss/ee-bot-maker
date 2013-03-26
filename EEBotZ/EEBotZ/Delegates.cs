using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EEBotZ
{
    /// <summary>
    /// A handler for the OnConnect event.
    /// </summary>
    /// <param name="sender">The object that fired this event.</param>
    public delegate void OnConnectEventHandler(object sender);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="message"></param>
    public delegate void OnFailConnectEventHandler(object sender, string message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    public delegate void OnJoinWorldEventHandler(object sender);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="message"></param>
    public delegate void OnFailJoinWorldEventHandler(object sender, string message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="s"></param>
    public delegate void OnCreateWorldEventHandler(object sender, string s);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="message"></param>
    public delegate void OnFailCreateWorldEventHandler(object sender, string message);

    /// <summary>
    /// A handler for the GotWorldKey event.
    /// </summary>
    /// <param name="sender">The object that fired this event.</param>
    /// <param name="worldKey">The value of WorldKey.</param>
    public delegate void OnWorldKeyEventHandler(object sender, string worldKey);

    /// <summary>
    /// A handler for the OnPacket event.
    /// Also for the OnOther event.
    /// </summary>
    /// <param name="sender">The object that fired this event.</param>
    /// <param name="p">The packet received.</param>
    public delegate void OnPacketEventHandler(object sender, Packet p);

    /// <summary>
    /// A handler for the OnDisconnect event.
    /// </summary>
    /// <param name="sender">The object that fired this event.</param>
    /// <param name="message">The reason for disconnecting.</param>
    public delegate void OnDisconnectEventHandler(object sender, string message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="owner"></param>
    /// <param name="worldName"></param>
    /// <param name="numberOfPlays"></param>
    /// <param name="woots"></param>
    /// <param name="totalWoots"></param>
    /// <param name="worldKey"></param>
    /// <param name="botUser"></param>
    /// <param name="access"></param>
    /// <param name="isOwner"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="tutorial"></param>
    /// <param name="gravity"></param>
    /// <param name="potions"></param>
    /// <param name="mapData"></param>
    /// <param name="potionData"></param>
    public delegate void OnInitEventHandler(object sender, string owner, string worldName, string numberOfPlays, int woots, int totalWoots, string worldKey, User botUser, bool access, bool isOwner, int width, int height, bool tutorial, double gravity, bool potions, Pixel[,] mapData, Dictionary<int, int> potionData);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="title"></param>
    /// <param name="message"></param>
    public delegate void OnInfoEventHandler(object sender, string title, string message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    /// <param name="potionID"></param>
    /// <param name="active"></param>
    public delegate void OnPotionEventHandler(object sender, int userID, int potionID, bool active);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="title"></param>
    /// <param name="message"></param>
    public delegate void OnWriteEventHandler(object sender, string title, string message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    public delegate void OnUpgradeEventHandler(object sender);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    /// <param name="motion"></param>
    /// <param name="coins"></param>
    /// <param name="purple"></param>
    /// <param name="hasLevitation"></param>
    public delegate void OnMoveEventHandler(object sender, int userID, User.Motion motion, int coins, bool purple, bool hasLevitation);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="user"></param>
    public delegate void OnAddEventHandler(object sender, User user);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    /// <param name="coins"></param>
    public delegate void OnCoinEventHandler(object sender, int userID, int coins);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    public delegate void OnCrownEventHandler(object sender, int userID);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    public delegate void OnWinEventHandler(object sender, int userID);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="layer"></param>
    /// <param name="posX"></param>
    /// <param name="posY"></param>
    /// <param name="blockID"></param>
    /// <param name="userID"></param>
    /// <param name="coins"></param>
    /// <param name="sound"></param>
    /// <param name="rotation"></param>
    /// <param name="thisID"></param>
    /// <param name="targetID"></param>
    /// <param name="text"></param>
    public delegate void OnBlockEventHandler(object sender, int layer, int posX, int posY, int blockID, int userID, int coins, int sound, int rotation, int thisID, int targetID, string text);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="doorType"></param>
    public delegate void OnShowEventHandler(object sender, string doorType);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="doorType"></param>
    public delegate void OnHideEventHandler(object sender, string doorType);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    /// <param name="smileyID"></param>
    public delegate void OnFaceEventHandler(object sender, int userID, int smileyID);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    /// <param name="god"></param>
    public delegate void OnGodEventHandler(object sender, int userID, bool god);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    public delegate void OnModEventHandler(object sender, int userID);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    public delegate void OnLostAccessEventHandler(object sender);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    public delegate void OnAccessEventHandler(object sender);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="b"></param>
    /// <param name="potions"></param>
    public delegate void OnAllowPotionsEventHandler(object sender, bool b, int[] potions);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    public delegate void OnWootUpEventHandler(object sender, int userID);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    public delegate void OnWootEventHandler(object sender, int userID);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    /// <param name="level"></param>
    public delegate void OnLevelUpEventHandler(object sender, int userID, int level);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    /// <param name="message"></param>
    public delegate void OnSayEventHandler(object sender, int userID, string message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userName"></param>
    /// <param name="message"></param>
    public delegate void OnSayOldEventHandler(object sender, string userName, string message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="owner"></param>
    /// <param name="worldName"></param>
    /// <param name="numberOfPlays"></param>
    public delegate void OnUpdateMetaEventHandler(object sender, string owner, string worldName, int numberOfPlays, int woots, int totalWoots);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    /// <param name="message"></param>
    public delegate void OnQuickChatEventHandler(object sender, int userID, string message);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="userID"></param>
    public delegate void OnLeftEventHandler(object sender, int userID);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    public delegate void OnClearEventHandler(object sender, int width, int height);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="idk"></param>
    /// <param name="spawnInfo"></param>
    public delegate void OnResetEventHandler(object sender, bool idk, SpawnInfo[] spawnInfo);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="mapData"></param>
    public delegate void OnLoadLevelEventHandler(object sender, Pixel[,] mapData);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    public delegate void OnSaveEventHandler(object sender);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    public delegate void OnGroupDisallowedJoinEventHandler(object sender);
}
