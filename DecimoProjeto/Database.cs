using System.Collections.Generic;
using System;
using System.Runtime.Serialization;
using System.Linq;
using System.Threading;

namespace DecimoProjeto
{
	[DataContract]
	class Database
	{
		//Atributo

		[DataMember] private List<UserData> UserList;
		private string pathDatabase;

		private Mutex fileMutex;
		private Mutex listMutex;

		private static bool avaliableDB;

		//Métodos

		public void AddUser(UserData pUser)
		{
			listMutex.WaitOne();
			UserList.Add(pUser);
			listMutex.ReleaseMutex();

			new Thread(() =>
			{
				avaliableDB = false;
				fileMutex.WaitOne();
				Serializer.Serialize(pathDatabase, this);
				fileMutex.ReleaseMutex();
				avaliableDB = true;

			}).Start();
			
		}

		public List<UserData> SearchList(string pNumDoc)
		{
			listMutex.WaitOne();
			List<UserData> TempUserList = UserList.Where(x => x.NumDoc.Contains(pNumDoc)).ToList();
			listMutex.ReleaseMutex();

			if (TempUserList.Count > 0)
			{
				return TempUserList;
			}
			else
				return null;
		}

		public List<UserData> RemoveUser(string pNumDoc)
		{
			listMutex.WaitOne();
			List<UserData> TempUserList = UserList.Where(x => x.NumDoc == pNumDoc).ToList();
			listMutex.ReleaseMutex();

			if (TempUserList.Count > 0)
			{
				
				foreach (UserData user in TempUserList)
				{
					listMutex.WaitOne();
					UserList.Remove(user);
					listMutex.ReleaseMutex();
				}
				

				new Thread(() =>
				{
					avaliableDB = false;
					fileMutex.WaitOne();
					Serializer.Serialize(pathDatabase, this);
					fileMutex.ReleaseMutex();
					avaliableDB = true;

				}).Start();

				return TempUserList;
			}
			else
				return null;
		}

		public static bool AvaliableDB()
		{
			return avaliableDB;
		}

		// Construtor

		public Database(string pPathDatabase)
		{
			pathDatabase = pPathDatabase;

			listMutex = new Mutex();
			fileMutex = new Mutex();
			avaliableDB = true;

			new Thread(() =>
			{
				avaliableDB = false;
				fileMutex.WaitOne();
				Database tempDatabase = Serializer.Deserialize(pPathDatabase);
				fileMutex.ReleaseMutex();

				listMutex.WaitOne();
				if (tempDatabase != null)
				{
					UserList = tempDatabase.UserList;
				}
				else
				{
					UserList = new List<UserData>();
				}
				listMutex.ReleaseMutex();
				avaliableDB = true;


			}).Start();
			

		}

	}
}