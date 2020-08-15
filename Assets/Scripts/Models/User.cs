using System;


// "id": "1",
// "Family": "\u0418\u0432\u0430\u043d\u043e\u0432",
// "Name": "\u0418\u0432\u0430\u043d",
// "Father": "\u0418\u0432\u0430\u043d\u043e\u0432\u0438\u0447",
// "UserName": "admin",
// "Password": "admin",
// "Role": "\u0410\u0434\u043c\u0438\u043d\u0438\u0441\u0442\u0440\u0430\u0442\u043e\u0440",
// "idGroup": "0",
// "Telefon": "9171111111",
// "DateBD": "2000-08-14"

namespace Models
{
  [Serializable]
	public class User
	{
		public int id;

		public string Family;

		public string Name;

		public string Father;

		public string UserName;
		public string Ages;

		public string Password;
		public string Role;
    public string idGroup;
		public string NameGroup;

    public string Telefon;
    public string DateBD;

		public override string ToString(){
			return UnityEngine.JsonUtility.ToJson (this, true);
		}
	}
}