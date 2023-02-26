using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NonoProjeto
{
	[DataContract]
	class Database
	{
		//Atributo

		[DataMember] private List<UserData> UserList;
		private string pathDatabase;

		//Métodos

		public void AddUser(UserData pUser)
		{
			UserList.Add(pUser);
			Serializer.Serialize(pathDatabase, this);
		}

		public List<UserData> SearchList(string pNumDoc)
		{
			List<UserData> TempUserList = UserList.Where(x => x.NumDoc.Contains(pNumDoc)).ToList();
			if (TempUserList.Count > 0)
			{
				return TempUserList;
			}
			else
				return null;
		}

		public List<UserData> RemoveUser(string pNumDoc)
		{
			List<UserData> TempUserList = UserList.Where(x => x.NumDoc == pNumDoc).ToList();
			if (TempUserList.Count > 0)
			{
				foreach (UserData user in TempUserList)
				{
					UserList.Remove(user);
				}
				return TempUserList;
			}
			else
				return null;
		}

		// Construtor

		public Database(string pPathDatabase)
		{
			pathDatabase = pPathDatabase;
			Database tempDatabase = Serializer.Deserialize(pPathDatabase);
			if (tempDatabase != null)
			{
				UserList = tempDatabase.UserList;
			}
			else
			{
				UserList = new List<UserData>();
			}

		}

	}
}
