using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class ServerAPI : MonoBehaviour
{
    const string _uri = "http://almetpt.ru:3000/2020/miass/tables/";

    const string _table_users = "Users";//- пользователи
    const string _table_groups  = "Groups"; //- группа в которой занимаются
    const string _table_cubes = "Cubes"; // название групы
    const string _table_news = "News"; // нащвание 
    const string _table_honors = "Honors"; // - достижения
    const string _table_userHonors = "UserHonors"; //
    const string _table_userInventory = "UserInventars"; //
    const string _table_inventory = "Inventars"; //
    const string _table_userFriends = "UserFriends"; //

    public static IEnumerator GetRequest(string uri, Action<string> result)
    {
        // UnityWebRequest request = UnityWebRequest.Get(_url);
        // UnityWebRequestAsyncOperation async = request.SendWebRequest();
        // while (!async.isDone) { yield return null; }

        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
                if (result != null) result(webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                if (result != null) result(webRequest.downloadHandler.text);
            }
        }
    }

/*
// void NonCoroutineFunction()
// {
//     StartCoroutine(m_GetUserToken("YourURL", (v_UserToken) =>
//     {
//         //You can now use the v_UserToken variable
//         Debug.Log(v_UserToken);
//     }));
// }
*/
    public static IEnumerator getUserInfo(int userId, Action<string> result) {
        string _url = $"{ServerAPI._uri}{ServerAPI._table_users}/{userId}/";
        yield return ServerAPI.GetRequest(_url, result);
    }
}
