using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OitavoProjeto
{
	class Database
	{

		//Atributo

		private List<UserData> UserList;

		//Métodos

		public void AddUser(UserData pUser)
		{
			UserList.Add(pUser);
		}

		public List<UserData> SearchList(string pNumDoc)
		{
			List<UserData> TempUserList = UserList.Where(x => x.NumDoc == pNumDoc).ToList();
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
				foreach(UserData user in TempUserList)
				{
					UserList.Remove(user);
				}
				return TempUserList;
			}
			else
				return null;
		}

		// Construtor

		public Database()
		{
			UserList = new List<UserData>();
		}
	}
}
