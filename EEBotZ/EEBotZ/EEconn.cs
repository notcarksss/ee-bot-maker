using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayerIOClient;

namespace EEBotZ
{
    /// <summary>
    /// 
    /// </summary>
    public class EEConn
    {
        /// <summary>
        /// 
        /// </summary>
        public EEConn()
        {
        }

        #region Variables

        /// <summary>
        /// 
        /// </summary>
        private Client client;

        /// <summary>
        /// 
        /// </summary>
        private Connection conn;

        /// <summary>
        /// 
        /// </summary>
        private string gameID = "everybody-edits-su9rn58o40itdbnw69plyw";

        /// <summary>
        /// 
        /// </summary>
        private UserManager Manager = new UserManager();

        /// <summary>
        /// 
        /// </summary>
        private Pixel[,] MapData;

        /// <summary>
        /// 
        /// </summary>
        public int Version = 0; //The version of Everybodyedits is v216

        /// <summary>
        /// 
        /// </summary>
        public string WorldKey { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public bool isConnected { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public bool isJoinedWorld { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ListenForPackets = false;

        /// <summary>
        /// 
        /// </summary>
        public bool ListUsers = false;

        #endregion

        #region Events

        /// <summary>
        /// Triggered when bot gets connected to the server. (after using Connect, etc)
        /// </summary>
        public event OnConnectEventHandler OnConnect;

        /// <summary>
        /// Triggered when bot gets connected to the server. (after using Connect, etc)
        /// </summary>
        public event OnFailConnectEventHandler OnFailConnect;

        /// <summary>
        /// 
        /// </summary>
        public event OnJoinWorldEventHandler OnJoinWorld;

        /// <summary>
        /// 
        /// </summary>
        public event OnFailJoinWorldEventHandler OnFailJoinWorld;

        /// <summary>
        /// 
        /// </summary>
        public event OnCreateWorldEventHandler OnCreateWorld;

        /// <summary>
        /// 
        /// </summary>
        public event OnFailCreateWorldEventHandler OnFailCreateWorld;

        /// <summary>
        /// Triggered when bot retrieves the WorldKey.
        /// </summary>
        public event OnWorldKeyEventHandler OnWorldKey;

        /// <summary>
        /// Triggered when any packet is received.
        /// </summary>
        public event OnPacketEventHandler OnPacket;

        /// <summary>
        /// Triggered when no OnTypeEventHandler can triggered.
        /// </summary>
        public event OnPacketEventHandler OnOther;

        /// <summary>
        /// Triggered when bot gets disconnected.
        /// </summary>
        public event OnDisconnectEventHandler OnDisconnect;

        /// <summary>
        /// Triggered when "init" packet is received.
        /// [0] owner of world (string)
        /// [1] name of world (string)
        /// [2] number of plays (string)
        /// [3] encrypted WorldKey (string
        /// [4] bot's user ID (int)
        /// [5] spawn position X (double)
        /// [6] spawn position Y (double)
        /// [7] bot's user name (string)
        /// [8] can edit? (bool)
        /// [9] is owner? (bool)
        /// [10] world dimension X (int)
        /// [11] world dimension Y (int)
        /// [12] tutorial room (bool)
        /// [13] gravity (double)
        /// [14] allow potions (bool)
        /// [15] "ws" (string)
        /// .... map data (see documentation for more info)
        /// [??] "we" (string)
        /// [??] "ps" (string)
        /// .... potion data (see documentation for more info)
        /// [??] "pe" (string)
        /// </summary>
        public event OnInitEventHandler OnInit;

        /// <summary>
        /// Triggered when a user joins the world.
        /// [0] user ID (int)
        /// [1] user name (string)
        /// [2] smiley ID (int)
        /// [3] spawn position X (double)
        /// [4] spawn position Y (double)
        /// [5] god mode? (bool)
        /// [6] mod mode? (bool)
        /// [7] has chat? (bool)
        /// [8] number of coins (int)
        /// [9] ??? (bool)
        /// </summary>
        public event OnAddEventHandler OnAdd;

        /// <summary>
        /// Triggered when a user has left the world.
        /// [0]  user ID (int)
        /// </summary>
        public event OnLeftEventHandler OnLeft;

        /// <summary>
        /// Triggered when a user goes in or out of god mode.
        /// [0] user ID (int)
        /// [1] god mode? (bool)
        /// </summary>
        public event OnGodEventHandler OnGod;

        /// <summary>
        /// Triggered when a user goes in or out of mod mode.
        /// [0] user ID (int)
        /// [1] mod mode? (bool)
        /// </summary>
        public event OnModEventHandler OnMod;

        /// <summary>
        /// Triggered when a user chats a packet.
        /// [0] user ID (int)
        /// [1] chat message (string)
        /// [2] ??? (bool)
        /// </summary>
        public event OnSayEventHandler OnSay;

        /// <summary>
        /// Triggered when displaying chat messages before the bot arrived.
        /// [0] user name (string)
        /// [1] chat message (string)
        /// [2] ??? (bool)
        /// </summary>
        public event OnSayOldEventHandler OnSayOld;

        /// <summary>
        /// Triggered when *System chats a message.
        /// [0] prefix (string)
        /// [1] chat message (string)
        /// </summary>
        public event OnWriteEventHandler OnWrite;

        /// <summary>
        /// Triggered when a user uses the quick-chat.
        /// [0] user ID (int)
        /// [1] chat message (string)
        /// </summary>
        public event OnQuickChatEventHandler OnQuickChat;

        /// <summary>
        /// Triggered when a user moves.
        /// [0] user ID (int)
        /// [1] position X (double)
        /// [2] position Y (double)
        /// [3] velocity X (double)
        /// [4] velocity Y (double)
        /// [5] acceleration X (double)
        /// [6] acceleration Y (double)
        /// [7] key down X (int)
        /// [8] key down Y (int)
        /// [9] number of coins (int)
        /// </summary>
        public event OnMoveEventHandler OnMove;

        /// <summary>
        /// Triggered when a block is built.
        /// [0] layer (int)
        /// [1] position X (int)
        /// [2] position Y (int)
        /// [3] block ID (int)
        /// [4] number of coins (int) for coin door/gate
        /// [5] note (int) for piano/drum
        /// [6] orientation (int) for portal
        /// [7] this ID (int) for portal
        /// [8] target ID (int) for portal
        /// </summary>
        public event OnBlockEventHandler OnBlock;

        /// <summary>
        /// Triggered when a user changes his/her smiley.
        /// [0] user ID (int)
        /// [1] smiley ID (int)
        /// </summary>
        public event OnFaceEventHandler OnFace;

        /// <summary>
        /// Triggered when a user gets the crown.
        /// [0] user ID (int)
        /// </summary>
        public event OnCrownEventHandler OnCrown;

        /// <summary>
        /// Triggered when a user wins the level.
        /// [0] user ID (int)
        /// </summary>
        public event OnWinEventHandler OnWin;

        /// <summary>
        /// Triggered when a user gets a coin.
        /// [0] user ID (int)
        /// [1] number of coins (int)
        /// </summary>
        public event OnCoinEventHandler OnCoin;

        /// <summary>
        /// Triggered when doors hide and gates show.
        /// [0] "red", "blue", "green", "purple", or "timedoor" (string)
        /// </summary>
        public event OnHideEventHandler OnHide;

        /// <summary>
        /// Triggered when doors show and gates hide.
        /// [0] "red", "blue", "green", "purple", or "timedoor" (string)
        /// </summary>
        public event OnShowEventHandler OnShow;

        /// <summary>
        /// Triggered when bot gains access to edit the level.
        /// </summary>
        public event OnAccessEventHandler OnAccess;

        /// <summary>
        /// Triggered when the world code changes. Bot can no longer edit.
        /// </summary>
        public event OnLostAccessEventHandler OnLostAccess;

        /// <summary>
        /// 
        /// </summary>
        public event OnAllowPotionsEventHandler OnAllowPotions;

        /// <summary>
        /// 
        /// </summary>
        public event OnWootUpEventHandler OnWootUp;

        /// <summary>
        /// 
        /// </summary>
        public event OnWootEventHandler OnWoot;

        /// <summary>
        /// 
        /// </summary>
        public event OnLevelUpEventHandler OnLevelUp;

        /// <summary>
        /// Triggered when the world is saved.
        /// </summary>
        public event OnSaveEventHandler OnSave;

        /// <summary>
        /// Triggered when the world is cleared.
        /// [0] world dimension X (int)
        /// [1] world dimension Y (int)
        /// [2] border block ID (int)
        /// [3] ??? (int)
        /// </summary>
        public event OnClearEventHandler OnClear;

        /// <summary>
        /// Triggered when the world is loaded.
        /// [1] "ws" (string)
        /// ... map data (see documentation for more info)
        /// [?] "we" (string)
        /// </summary>
        public event OnLoadLevelEventHandler OnLoadLevel;

        /// <summary>
        /// Triggered when the world is reset.
        /// [0] ??? (bool)
        /// [1] user ID (int)
        /// [2] spawn position X (double)
        /// [3] spawn position Y (double)
        /// ... The pattern of [1],[2],[3] continues for all users in the world.
        /// </summary>
        public event OnResetEventHandler OnReset;

        /// <summary>
        /// Triggered when name of world is changed.
        /// [0] owner of world (string)
        /// [1] name of world (string)
        /// [2] number of plays (int)
        /// </summary>
        public event OnUpdateMetaEventHandler OnUpdateMeta;

        /// <summary>
        /// Triggered when server sends an info box.
        /// [0] title (string)
        /// [1] message (string)
        /// </summary>
        public event OnInfoEventHandler OnInfo;

        /// <summary>
        /// Triggered when bot attempts to (but cannot) enter a world.
        /// </summary>
        public event OnGroupDisallowedJoinEventHandler OnGroupDisallowedJoin;

        /// <summary>
        /// Triggered when a player uses a potion, or when a potion wears off.
        /// [0] user ID (int)
        /// [1] potion ID (int)
        /// [2] active (bool)
        /// </summary>
        public event OnPotionEventHandler OnPotion;

        /// <summary>
        /// Triggered when game gets upgraded.
        /// </summary>
        public event OnUpgradeEventHandler OnUpgrade;

        #endregion

        #region Connections

        /// <summary>
        /// Sign in as a registered user.
        /// </summary>
        /// <param name="email">The email registered with the account.</param>
        /// <param name="password">The password registered with the account.</param>
        public void Connect(string email, string password)
        {
            PlayerIO.QuickConnect.SimpleConnect(gameID, email, password, new Callback<Client>(LogIn), new Callback<PlayerIOError>(FailLogIn));
        }

        /// <summary>
        /// Sign in with Facebook.
        /// </summary>
        /// <param name="accessToken">The access token of the Facebook account.</param>
        public void Connect_Facebook(string accessToken)
        {
            PlayerIO.QuickConnect.FacebookOAuthConnect(gameID, accessToken, "_blank", new Callback<Client>(LogIn), new Callback<PlayerIOError>(FailLogIn));
        }

        /// <summary>
        /// Sign in with Kongregate.
        /// </summary>
        /// <param name="userID">The UserID of the Kongregate account.</param>
        /// <param name="gameAuthToken">The authentication token of the Kongregate account.</param>
        public void Connect_Kongregate(string userID, string gameAuthToken)
        {
            PlayerIO.QuickConnect.KongregateConnect(gameID, userID, gameAuthToken, new Callback<Client>(LogIn), new Callback<PlayerIOError>(FailLogIn));
        }

        /// <summary>
        /// Successful logging in.
        /// </summary>
        /// <param name="c">client</param>
        private void LogIn(Client c)
        {
            client = c;
            isConnected = true;
            if (OnConnect != null) OnConnect(this);
        }

        /// <summary>
        /// Failed logging in.
        /// </summary>
        /// <param name="e">error</param>
        private void FailLogIn(PlayerIOError e)
        {
            if (OnFailConnect != null) OnFailConnect(this, e.Message);
        }

        /// <summary>
        /// Join an existing world currently in the Lobby.
        /// </summary>
        /// <param name="worldID">The WorldID of the world.</param>
        public void JoinWorld(string worldID)
        {
            client.Multiplayer.JoinRoom(worldID, new Dictionary<string, string>(), new Callback<Connection>(Join), new Callback<PlayerIOError>(FailJoin));
        }

        /// <summary>
        /// Create a non-existing world. Or open a saved world not currently in the Lobby.
        /// </summary>
        /// <param name="worldID">The World ID of the world.</param>
        /// <param name="worldType">The type of the world.</param>
        /// <param name="visible">Will this world be visible in the Lobby?</param>
        public void CreateWorld(string worldID, string worldType, bool visible)
        {
            client.Multiplayer.CreateRoom(worldID, worldType, visible, new Dictionary<string, string>(), new Callback<string>(Create), new Callback<PlayerIOError>(FailCreate));
        }

        /// <summary>
        /// Create a world, then join it. If the world already exists, then just join it.
        /// </summary>
        /// <param name="worldID">The World ID of the world.</param>
        /// <param name="worldType">The type of the world.</param>
        /// <param name="visible">Will this world be visible in the Lobby?</param>
        public void CreateJoinWorld(string worldID, string worldType, bool visible)
        {
            client.Multiplayer.CreateJoinRoom(worldID, worldType, visible, new Dictionary<string, string>(), new Dictionary<string, string>(), new Callback<Connection>(Join), new Callback<PlayerIOError>(FailJoin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        private void Join(Connection c)
        {
            conn = c;
            isJoinedWorld = true;
            conn.OnMessage += new MessageReceivedEventHandler(conn_OnMessage);
            conn.OnDisconnect += new DisconnectEventHandler(conn_OnDisconnect);
            if (OnJoinWorld != null) OnJoinWorld(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        private void FailJoin(PlayerIOError e)
        {
            if (OnFailJoinWorld != null) OnFailJoinWorld(this, e.Message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        private void Create(string s)
        {
            if (OnCreateWorld != null) OnCreateWorld(this, s);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        private void FailCreate(PlayerIOError e)
        {
            if (OnFailCreateWorld != null) OnFailCreateWorld(this, e.Message);
        }

        #endregion

        #region Send Packets

        /// <summary>
        /// This is the summary.
        /// </summary>
        /// <param name="type">This is the type parameter.</param>
        /// <param name="parameters">These are the parameters of the message.</param>
        public void Send(string type, params object[] parameters)
        {
            if (conn.Connected)
                conn.Send(type, parameters);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public void Send(Packet p)
        {
            Send(p.Type, p.Parameters);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Init()
        {
            Send("init");
            Send("init2");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Say(string message)
        {
            Send("say", message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void QuickChat(int message)
        {
            Send("autosay", message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Position_X"></param>
        /// <param name="Position_Y"></param>
        /// <param name="Velocity_X"></param>
        /// <param name="Velocity_Y"></param>
        /// <param name="Acceleration_X"></param>
        /// <param name="Acceleration_Y"></param>
        /// <param name="RightArrowKey"></param>
        /// <param name="DownArrowKey"></param>
        /// <param name="Gravity"></param>
        /// <param name="SpaceBar"></param>
        public void Move(double Position_X, double Position_Y, double Velocity_X, double Velocity_Y, double Acceleration_X, double Acceleration_Y, int RightArrowKey, int DownArrowKey, double Gravity, bool SpaceBar)
        {
            Send("m", Position_X, Position_Y, Velocity_X, Velocity_Y, Acceleration_X, Acceleration_Y, RightArrowKey, DownArrowKey, Gravity, SpaceBar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Teleport(double x, double y)
        {
            Send("m", x, y, 0, 0, 0, 0, 0, 0, 0, false);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Jump()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        public void Access(string code)
        {
            Send("access", code);
        }

        #endregion

        #region Receive Packets

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="message"></param>
        private void conn_OnDisconnect(object sender, string message)
        {
            isJoinedWorld = false;
            if (OnDisconnect != null) OnDisconnect(this, message);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void conn_OnMessage(object sender, Message e)
        {
            if (!ListenForPackets) return;
            if (OnPacket != null)
            {
                Packet packet = new Packet(e.Type);
                for (uint n = 0; n < e.Count; n++)
                {
                    packet.Add(e[n]);
                }
                OnPacket(this, packet);
            }
            switch (e.Type)
            {
                case "init":
                    WorldKey = Rot13(e.GetString(5));
                    if (OnWorldKey != null) OnWorldKey(this, WorldKey);
                    MapData = Init2Array(e);
                    if (OnInit != null)
                    {
                        User bot = new User(e.GetString(9), e.GetInt(6));
                        bot.Move.Position.X = (double)e.GetInt(7);
                        bot.Move.Position.Y = (double)e.GetInt(8);
                        Dictionary<int, int> potData = Init2Pot(e);
                        OnInit(this,
                            e.GetString(0),
                            e.GetString(1),
                            e.GetString(2),
                            e.GetInt(3),
                            e.GetInt(4),
                            WorldKey,
                            bot,
                            e.GetBoolean(10),
                            e.GetBoolean(11),
                            e.GetInt(12),
                            e.GetInt(13),
                            e.GetBoolean(14),
                            e.GetDouble(15),
                            e.GetBoolean(16),
                            MapData,
                            potData);
                    }
                    break;
                case "info":
                    if (OnInfo != null) OnInfo(this, e.GetString(0), e.GetString(1));
                    break;
                case "p":
                    if (OnPotion != null) OnPotion(this, e.GetInt(0), e.GetInt(1), e.GetBoolean(2));
                    break;
                case "write":
                    if (OnWrite != null) OnWrite(this, e.GetString(0), e.GetString(1));
                    break;
                case "upgrade":
                    if (OnUpgrade != null) OnUpgrade(this);
                    break;
                case "m":
                    if (OnMove != null)
                    {
                        User.Motion motion = new User.Motion();
                        motion.Position.X = e.GetDouble(1);
                        motion.Position.Y = e.GetDouble(2);
                        motion.Velocity.X = e.GetDouble(3);
                        motion.Velocity.Y = e.GetDouble(4);
                        motion.Acceleration.X = e.GetDouble(5);
                        motion.Acceleration.Y = e.GetDouble(6);
                        motion.KeyDown.X = e.GetDouble(7);
                        motion.KeyDown.Y = e.GetDouble(8);
                        OnMove(this, e.GetInt(0), motion, e.GetInt(9), e.GetBoolean(10), e.GetBoolean(11));
                    }
                    break;
                case "add":
                    if (OnAdd != null || ListUsers)
                    {
                        User u = new User(e.GetString(1), e.GetInt(0));
                        u.SmileyID = e.GetInt(2);
                        u.Move.Position.X = e.GetDouble(3);
                        u.Move.Position.Y = e.GetDouble(4);
                        u.isGod = e.GetBoolean(5);
                        u.isMod = e.GetBoolean(6);
                        u.isChat = e.GetBoolean(7);
                        u.Coins = e.GetInt(8);
                        u.isFriend = e.GetBoolean(9);
                        u.isPurple = e.GetBoolean(10);
                        u.Level = e.GetInt(11);
                        u.isClubMember = e.GetBoolean(12);
                        if (OnAdd != null) OnAdd(this, u);
                        if (ListUsers) Manager.UserJoined(u);
                    }
                    break;
                case "c":
                    if (OnCoin != null) OnCoin(this, e.GetInt(0), e.GetInt(1));
                    break;
                case "k":
                    if (OnCrown != null) OnCrown(this, e.GetInt(0));
                    break;
                case "ks":
                    if (OnWin != null) OnWin(this, e.GetInt(0));
                    break;
                case "b":
                    if (OnBlock != null) OnBlock(this, e.GetInt(0), e.GetInt(1), e.GetInt(2), e.GetInt(3), e.GetInt(4), -1, -1, -1, -1, -1, "");
                    break;
                case "bc":
                    if (OnBlock != null) OnBlock(this, 0, e.GetInt(0), e.GetInt(1), e.GetInt(2), -1, e.GetInt(3), -1, -1, -1, -1, "");
                    break;
                case "bs":
                    if (OnBlock != null) OnBlock(this, 0, e.GetInt(0), e.GetInt(1), e.GetInt(2), -1, -1, e.GetInt(3), -1, -1, -1, "");
                    break;
                case "pt":
                    if (OnBlock != null) OnBlock(this, 0, e.GetInt(0), e.GetInt(1), e.GetInt(2), -1, -1, -1, e.GetInt(3), e.GetInt(4), e.GetInt(5), "");
                    break;
                case "lb":
                    if (OnBlock != null) OnBlock(this, 0, e.GetInt(0), e.GetInt(1), e.GetInt(2), -1, -1, -1, -1, -1, -1, e.GetString(3));
                    break;
                case "br":
                    if (OnBlock != null) OnBlock(this, 0, e.GetInt(0), e.GetInt(1), e.GetInt(2), -1, -1, -1, e.GetInt(3), -1, -1, "");
                    break;
                case "show":
                    if (OnShow != null) OnShow(this, e.GetString(0));
                    break;
                case "hide":
                    if (OnHide != null) OnHide(this, e.GetString(0));
                    break;
                case "face":
                    if (OnFace != null) OnFace(this, e.GetInt(0), e.GetInt(1));
                    break;
                case "god":
                    if (OnGod != null) OnGod(this, e.GetInt(0), e.GetBoolean(1));
                    break;
                case "mod":
                    if (OnMod != null) OnMod(this, e.GetInt(0));
                    break;
                case "lostaccess":
                    if (OnLostAccess != null) OnLostAccess(this);
                    break;
                case "access":
                    if (OnAccess != null) OnAccess(this);
                    break;
                case "allowpotions":
                    if (OnAllowPotions != null)
                    {
                        List<int> potions = new List<int>();
                        for (uint n = 1; n < e.Count; n++)
                        {
                            potions.Add(e.GetInt(n));
                        }
                        OnAllowPotions(this, e.GetBoolean(0), potions.ToArray());
                    }
                    break;
                case "wu":
                    if (OnWootUp != null) OnWootUp(this, e.GetInt(0));
                    break;
                case "w":
                    if (OnWoot != null) OnWoot(this, e.GetInt(0));
                    break;
                case "levelup":
                    if (OnLevelUp != null) OnLevelUp(this, e.GetInt(0), e.GetInt(1));
                    break;
                case "say":
                    if (OnSay != null) OnSay(this, e.GetInt(0), e.GetString(1));
                    break;
                case "say_old":
                    if (OnSayOld != null) OnSayOld(this, e.GetString(0), e.GetString(1));
                    break;
                case "updatemeta":
                    if (OnUpdateMeta != null) OnUpdateMeta(this, e.GetString(0), e.GetString(1), e.GetInt(2), e.GetInt(3), e.GetInt(4));
                    break;
                case "autotext":
                    if (OnQuickChat != null) OnQuickChat(this, e.GetInt(0), e.GetString(1));
                    break;
                case "left":
                    if (OnLeft != null) OnLeft(this, e.GetInt(0));
                    if (ListUsers) Manager.UserLeft(e.GetInt(0));
                    break;
                case "clear":
                    if (OnClear != null) OnClear(this, e.GetInt(0), e.GetInt(1));
                    break;
                case "tele":    //owner reset level OR a user got killed
                    if (OnReset != null)
                    {
                        List<SpawnInfo> si = new List<SpawnInfo>();
                        for (uint n = 1; n < e.Count; n += 3)
                        {
                            si.Add(new SpawnInfo(e.GetInt(n), e.GetInt(n + 1), e.GetInt(n + 2)));
                        }
                        OnReset(this, e.GetBoolean(0), si.ToArray());
                    }
                    break;
                case "reset":   // owner loded level
                    MapData = Load2Array(e);
                    if (OnLoadLevel != null) OnLoadLevel(this, MapData);
                    break;
                case "saved":
                    if (OnSave != null) OnSave(this);
                    break;
                default:
                    if (OnOther != null)
                    {
                        Packet packet = new Packet(e.Type);
                        for (uint n = 0; n < e.Count; n++)
                        {
                            packet.Add(e[n]);
                        }
                        OnOther(this, packet);
                    }
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private Pixel[,] Init2Array(Message e)
        {
            int w = e.GetInt(12);
            int h = e.GetInt(13);
            Pixel[,] array = new Pixel[w, h];
            for (int yn = 0; yn < h; yn++)
            {
                for (int xn = 0; xn < w; xn++)
                {
                    array[xn, yn] = new Pixel();
                }
            }
            byte[] xarray, yarray;
            int x, y;
            int id;
            uint n = 17;
            while (n < e.Count)
            {
                if (e.GetString(n) == "ws")
                    break;
                n++;
            }
            n++;
            while (n < e.Count)
            {
                if (e.GetString(n) == "we")
                    break;
                id = e.GetInt(n);
                xarray = e.GetByteArray(n + 2);
                yarray = e.GetByteArray(n + 3);
                for (int i = 0; i < xarray.Length; i += 2)
                {
                    x = xarray[i] << 8 | xarray[i + 1];
                    y = yarray[i] << 8 | yarray[i + 1];
                    if (id < 500) array[x, y].Foreground = id;
                    if (id >= 500) array[x, y].Background = id;
                    switch (id)
                    {
                        case 43:
                        case 165:
                            array[x, y].Coins = e.GetInt(n + 4);
                            n += 5;
                            break;
                        case 77:
                        case 83:
                            array[x, y].Sound = e.GetInt(n + 4);
                            n += 5;
                            break;
                        case 242:
                            array[x, y].Rotation = e.GetInt(n + 4);
                            array[x, y].ThisID = e.GetInt(n + 5);
                            array[x, y].TargetID = e.GetInt(n + 6);
                            n += 7;
                            break;
                        default:
                            n += 4;
                            break;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private Pixel[,] Load2Array(Message e)
        {
            Pixel[,] array = MapData;
            int w = array.GetLength(0);
            int h = array.GetLength(1);
            for (int yn = 0; yn < h; yn++)
            {
                for (int xn = 0; xn < w; xn++)
                {
                    array[xn, yn] = new Pixel();
                }
            }
            byte[] xarray, yarray;
            int x, y;
            int id;
            uint n = 0;
            while (n < e.Count)
            {
                if (e.GetString(n) == "ws")
                    break;
                n++;
            }
            n++;
            while (n < e.Count)
            {
                if (e.GetString(n) == "we")
                    break;
                id = e.GetInt(n);
                xarray = e.GetByteArray(n + 2);
                yarray = e.GetByteArray(n + 3);
                for (int i = 0; i < xarray.Length; i += 2)
                {
                    x = xarray[i] << 8 | xarray[i + 1];
                    y = yarray[i] << 8 | yarray[i + 1];
                    if (id < 500) array[x, y].Foreground = id;
                    if (id >= 500) array[x, y].Background = id;
                    switch (id)
                    {
                        case 43:
                        case 165:
                            array[x, y].Coins = e.GetInt(n + 4);
                            n += 5;
                            break;
                        case 77:
                        case 83:
                            array[x, y].Sound = e.GetInt(n + 4);
                            n += 5;
                            break;
                        case 242:
                            array[x, y].Rotation = e.GetInt(n + 4);
                            array[x, y].ThisID = e.GetInt(n + 5);
                            array[x, y].TargetID = e.GetInt(n + 6);
                            n += 7;
                            break;
                        default:
                            n += 4;
                            break;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private Dictionary<int, int> Init2Pot(Message e)
        {
            Dictionary<int, int> ret = new Dictionary<int, int>();
            uint n = 17;
            while (n < e.Count)
            {
                if (e.GetString(n) == "ps")
                    break;
                n++;
            }
            n++;
            while (n < e.Count)
            {
                if (e.GetString(n) == "pe")
                    break;
                ret.Add(e.GetInt(n), e.GetInt(n + 1));
                n += 2;
            }
            return ret;
        }

        #endregion

        #region Lobby

        /// <summary>
        /// List all rooms visible in the lobby.
        /// </summary>
        /// <param name="resultLimit">limit how many results to list (use 0 to list as many as possible)</param>
        /// <param name="resultOffset">the offset into the list</param>
        /// <returns>a list of all rooms in the lobby</returns>
        public WorldInfo[] ListAllRooms(int resultLimit = 0, int resultOffset = 0)
        {
            RoomInfo[] ri = client.Multiplayer.ListRooms("Everybodyedits" + Version.ToString(), null, 0, 0);
            WorldInfo[] wi = new WorldInfo[ri.Length];
            for (int n = 0; n < ri.Length; n++)
            {
                wi[n] = new WorldInfo(ri[n].Id, ri[n].OnlineUsers, ri[n].RoomType, ri[n].RoomData);
            }
            return wi;
        }

        /// <summary>
        /// List all rooms in the lobby that match certain criteria.
        /// </summary>
        /// <param name="searchCriteria">search criteria</param>
        /// <param name="resultLimit">limit how many results to list (use 0 to list as many as possible)</param>
        /// <param name="resultOffset">the offset into the list</param>
        /// <returns>a list of all rooms in the lobby that match the criteria</returns>
        public WorldInfo[] ListRooms(Dictionary<string, string> searchCriteria, int resultLimit = 0, int resultOffset = 0)
        {
            RoomInfo[] ri = client.Multiplayer.ListRooms("Everybodyedits" + Version.ToString(), searchCriteria, 0, 0);
            WorldInfo[] wi = new WorldInfo[ri.Length];
            for (int n = 0; n < ri.Length; n++)
            {
                wi[n] = new WorldInfo(ri[n].Id, ri[n].OnlineUsers, ri[n].RoomType, ri[n].RoomData);
            }
            return wi;
        }

        #endregion

        #region User Management
        #endregion

        #region Cryptography

        /// <summary>
        /// Performs the Rot13 encryption/decryption algorithm.
        /// </summary>
        /// <param name="str">The string to encrypt/decrypt.</param>
        /// <returns>The encrypted/decrypted string.</returns>
        public static string Rot13(string str)
        {
            string ret = "";
            uint ascii;
            for (int n = 0; n < str.Length; n++)
            {
                ascii = (uint)str[n];
                if (ascii >= 65 && ascii <= 77)             //if str[n] is between 'A' and 'M'
                    ret += (char)(ascii + 13);
                else if (ascii >= 78 && ascii <= 90)        //if str[n] is between 'N' and 'Z'
                    ret += (char)(ascii - 13);
                else if (ascii >= 97 && ascii <= 109)       //if str[n] is between 'a' and 'm'
                    ret += (char)(ascii + 13);
                else if (ascii >= 110 && ascii <= 122)      //if str[n] is between 'n' and 'z'
                    ret += (char)(ascii - 13);
                else ret += str[n];                         //if str[n] is anything else
            }
            return ret;
        }

        #endregion
    }
}
