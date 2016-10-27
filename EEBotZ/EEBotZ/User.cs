using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EEBotZ
{
	/// <summary>
	/// User contains all info relevant to a particular player in the world.
	/// </summary>
	public class User
	{
		/// <summary>
		/// Constructs a new instance of User.
		/// </summary>
		/// <param name="Name">The user's name.</param>
		/// <param name="ID">The user's ID number.</param>
		public User(string Name, int ID)
		{
			this.Name = Name;
			this.ID = ID;
		}

		/// <summary>
		/// Constructs a new instance of User. With Name = "" and ID = -1.
		/// </summary>
		public User()
		{
			this.Name = "";
			this.ID = -1;
		}

		#region Variables

		/// <summary>
		/// The username of the user.
		/// </summary>
		public string Name { get; internal set; }

		/// <summary>
		/// The ID number of the user.
		/// </summary>
		public int ID { get; internal set; }

		/// <summary>
		/// The movement of the user.
		/// </summary>
		public UserMotion Move = new UserMotion();

		/// <summary>
		/// The ID of the user's smiley.
		/// </summary>
		public int SmileyID { get; internal set; }

		/// <summary>
		/// Is the user in god mode?
		/// </summary>
		public bool isGod { get; internal set; }

		/// <summary>
		/// Is the user in mod mode?
		/// </summary>
		public bool isMod { get; internal set; }

		/// <summary>
		/// Is the user the owner of the level?
		/// </summary>
		public bool isOwner { get; internal set; }

		/// <summary>
		/// Does this user have chat?
		/// </summary>
		public bool isChat { get; internal set; }

		/// <summary>
		/// Is this user the bot's friend?
		/// </summary>
		public bool isFriend { get; internal set; }

		/// <summary>
		/// Is this user purple?
		/// </summary>
		public bool isPurple { get; internal set; }

		/// <summary>
		/// Is the user a gold member?
		/// </summary>
		public bool isGoldmember { get; internal set; }

		/// <summary>
		/// The user's level.
		/// </summary>
		public int Level { get; internal set; }

		/// <summary>
		/// The number of coins this user has.
		/// </summary>
		public int Coins { get; internal set; }

		/// <summary>
		/// Does this user have the crown?
		/// </summary>
		public bool hasCrown { get; internal set; }

		/// <summary>
		/// Did this user win the level?
		/// </summary>
		public bool Won { get; internal set; }

		/// <summary>
		/// The number of points this user has.
		/// </summary>
		public int Points { get; internal set; }

		/// <summary>
		/// The number of times this user has won.
		/// </summary>
		public int Wins { get; internal set; }

		#endregion
	}

	/// <summary>
	/// A motion class to track the motion of a user
	/// </summary>
	public class UserMotion
	{
		/// <summary>
		/// 
		/// </summary>
		public Vector Position;

		/// <summary>
		/// 
		/// </summary>
		public Vector Velocity;

		/// <summary>
		/// 
		/// </summary>
		public Vector Acceleration;

		/// <summary>
		/// 
		/// </summary>
		public Vector KeyDown;

		/// <summary>
		/// 
		/// </summary>
		public double GravityMultiplier;

		/// <summary>
		/// 
		/// </summary>
		public bool KeyDown_Space;

		/// <summary>
		/// 
		/// </summary>
		public class Vector
		{
			/// <summary>
			/// 
			/// </summary>
			/// <param name="x"></param>
			/// <param name="y"></param>
			public Vector(double x, double y)
			{
				X = x;
				Y = y;
			}

			/// <summary>
			/// 
			/// </summary>
			public double X;

			/// <summary>
			/// 
			/// </summary>
			public double Y;

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			public static Vector Zero()
			{
				return new Vector(0, 0);
			}
		}
	}

	/// <summary>
	/// Manages admin list and ban list.
	/// </summary>
	public class UserManager
	{
		/// <summary>
		/// Constructs a new instance of UserManager
		/// </summary>
		public UserManager()
		{
			Users.Add(-1, new User());
			AdminList = new List<string>();
			BanList = new List<string>();
		}

		#region Variables

		/// <summary>
		/// The admin list.
		/// </summary>
		public List<string> AdminList { get; private set; }

		/// <summary>
		/// The ban list.
		/// </summary>
		public List<string> BanList { get; private set; }

		/// <summary>
		/// 
		/// </summary>
		public Dictionary<int, User> Users = new Dictionary<int, User>();

		#endregion

		#region Methods

		/// <summary>
		/// Add a user to the admin list.
		/// It will not add if the name is already on the list.
		/// </summary>
		/// <param name="user">The user's username.</param>
		public void AddAdmin(string user)
		{
			if (!AdminList.Contains(user))
				AdminList.Add(user);
		}

		/// <summary>
		/// Add a user to the admin list.
		/// It will not add if the name is already on the list.
		/// </summary>
		/// <param name="user">The users username.</param>
		public void AddBan(string user)
		{
			if (!BanList.Contains(user))
				BanList.Add(user);
		}

		/// <summary>
		/// Remove a user from the admin list.
		/// </summary>
		/// <param name="user">The user's username.</param>
		public void RemoveAdmin(string user)
		{
			AdminList.Remove(user);
		}

		/// <summary>
		/// Remove a user from the ban list.
		/// </summary>
		/// <param name="user">The user's username.</param>
		public void RemoveBan(string user)
		{
			BanList.Remove(user);
		}

		/// <summary>
		/// Is the user on the admin list?
		/// </summary>
		/// <param name="user">The user's username.</param>
		/// <returns>True if the user is on the admin list.</returns>
		public bool isAdmin(string user)
		{
			return AdminList.Contains(user);
		}

		/// <summary>
		/// Is the user on the ban list?
		/// </summary>
		/// <param name="user">The user's username.</param>
		/// <returns>True if the user is on the ban list.</returns>
		public bool isBan(string user)
		{
			return BanList.Contains(user);
		}

		/// <summary>
		/// Finds the ID a user among an array of users.
		/// </summary>
		/// <param name="Name">The name of the user to find.</param>
		/// <returns>Returns the ID found in the array. Returns null if not found.</returns>
		public int ID_of(string Name)
		{
			foreach (KeyValuePair<int, User> kvp in Users)
			{
				if (((User)kvp.Value).Name == Name)
					return ((User)kvp.Value).ID;
			}
			return -1;
		}

		/// <summary>
		/// Adds the new user to the array of users.
		/// </summary>
		/// <param name="NewUser">The new user to add.</param>
		public void UserJoined(User NewUser)
		{
			Users.Add(NewUser.ID, NewUser);
		}

		/// <summary>
		/// Removes the user from the array of users.
		/// </summary>
		/// <param name="ID">The ID of the user to remove.</param>
		public void UserLeft(int ID)
		{
			Users.Remove(ID);
		}

		#endregion
	}
}
