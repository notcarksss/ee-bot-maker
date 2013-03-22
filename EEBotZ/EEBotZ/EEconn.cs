using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlayerIOClient;

namespace EEBotZ
{
    public class EEConn
    {
        public EEConn()
        {
        }

        #region Variables

        private Client client;
        private Connection conn;
        private string gameID = "everybody-edits-su9rn58o40itdbnw69plyw";
        public int Version = 0;

        #endregion

        #region Events
        #endregion

        #region Connections

        /// <summary>
        /// Sign in as a registered user.
        /// </summary>
        /// <param name="email">The email registered with the account.</param>
        /// <param name="password">The password registered with the account.</param>
        public void Connect_Simple(string email, string password)
        {
            PlayerIO.QuickConnect.SimpleConnect(gameID, email, password, new Callback<Client>(Log), new Callback<PlayerIOError>(Fail));
        }

        /// <summary>
        /// Successful logging in.
        /// </summary>
        /// <param name="c">client</param>
        private void Log(Client c)
        {
            client = c;
        }

        /// <summary>
        /// Failed logging in.
        /// </summary>
        /// <param name="e">error</param>
        private void Fail(PlayerIOError e)
        {
            throw new Exception(e.Message);
        }

        #endregion

        #region Send Packets

        public void Send(string type, params object[] parameters)
        {
            if (conn.Connected)
                conn.Send(type, parameters);
        }

        public void Send(Packet p)
        {
            Send(p.Type, p.Parameters);
        }

        public void Init()
        {
            Send("init");
            Send("init2");
        }

        public void Say(string message)
        {
            Send("say", message);
        }

        public void QuickChat(int message)
        {
            Send("autosay", message);
        }

        public void Move(double Position_X, double Position_Y, double Velocity_X, double Velocity_Y, double Acceleration_X, double Acceleration_Y, int RightArrowKey, int DownArrowKey, double Gravity, bool SpaceBar)
        {
            Send("m", Position_X, Position_Y, Velocity_X, Velocity_Y, Acceleration_X, Acceleration_Y, RightArrowKey, DownArrowKey, Gravity, SpaceBar);
        }

        public void Teleport(double x, double y)
        {
            Move(x, y, 0, 0, 0, 0, 0, 0, 0, false);
        }

        public void Jump()
        {
        }

        #endregion

        #region Receive Packets
        #endregion

        #region Lobby

        /// <summary>
        /// List all rooms visible in the lobby.
        /// </summary>
        /// <param name="resultLimit">limit how many results to list (use 0 to list as many as possible)</param>
        /// <param name="resultOffset">the offset into the list</param>
        /// <returns>a list of all rooms in the lobby</returns>
        public RoomInfo[] ListAllRooms(int resultLimit = 0, int resultOffset = 0)
        {
            PlayerIOClient.RoomInfo[] ri1 = client.Multiplayer.ListRooms("Everybodyedits" + Version.ToString(), null, 0, 0);
            RoomInfo[] ri2 = new RoomInfo[ri1.Length];
            for (int n = 0; n < ri1.Length; n++)
            {
                ri2[n] = new RoomInfo(ri1[n].Id, ri1[n].OnlineUsers, ri1[n].RoomData, ri1[n].RoomType);
            }
            return ri2;
        }

        /// <summary>
        /// List all rooms in the lobby that match certain criteria.
        /// </summary>
        /// <param name="searchCriteria">search criteria</param>
        /// <param name="resultLimit">limit how many results to list (use 0 to list as many as possible)</param>
        /// <param name="resultOffset">the offset into the list</param>
        /// <returns>a list of all rooms in the lobby that match the criteria</returns>
        public RoomInfo[] ListRooms(Dictionary<string, string> searchCriteria, int resultLimit = 0, int resultOffset = 0)
        {
            PlayerIOClient.RoomInfo[] ri1 = client.Multiplayer.ListRooms("Everybodyedits" + Version.ToString(), searchCriteria, 0, 0);
            RoomInfo[] ri2 = new RoomInfo[ri1.Length];
            for (int n = 0; n < ri1.Length; n++)
            {
                ri2[n] = new RoomInfo(ri1[n].Id, ri1[n].OnlineUsers, ri1[n].RoomData, ri1[n].RoomType);
            }
            return ri2;
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
