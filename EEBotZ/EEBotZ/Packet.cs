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
    public class Packet
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public Packet(string type, params object[] parameters)
        {
            Type = type;
            Parameters = new List<object>();
            Parameters.AddRange(parameters);
            Count = Parameters.Count;
        }

        #region Variables

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public List<object> Parameters { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int Count { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Add(object parameter)
        {
            Parameters.Add(parameter);
            Count = Parameters.Count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get { return Parameters[index]; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetInt(int index)
        {
            return (int)Parameters[index];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public uint GetUint(int index)
        {
            return (uint)Parameters[index];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public double GetDouble(int index)
        {
            return (double)Parameters[index];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetString(int index)
        {
            return (string)Parameters[index];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool GetBool(int index)
        {
            return (bool)Parameters[index];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public byte[] GetByteArray(int index)
        {
            return (byte[])Parameters[index];
        }

        #endregion
    }
}
