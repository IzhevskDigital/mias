using UnityEngine;
using UnityEngine.SceneManagement;
using Models;
using Helpers;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    private Text _fio;
    private Text _age;
    private Text _cubes;
    private RawImage _photo;
    // called zero
    void Awake()
    {
        StartCoroutine(ServerAPI.getUserInfo(1, (_userInfo) =>
        {
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
            //You can now use the v_UserToken variable
            var _users = JsonHelper.ArrayFromJson<User>(_userInfo);
            this._fio.text = $"{_users[0].Family} {_users[0].Name} {_users[0].Father}";
            this._age.text = _users[0].Ages;
            this._cubes.text = _users[0].NameGroup;
        }));
    }


    // called first
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
    }

    // called third
    void Start()
    {
        this._fio = GameObject.Find("fio").GetComponent<Text>();
        this._age = GameObject.Find("age").GetComponent<Text>();
        this._cubes = GameObject.Find("cubes").GetComponent<Text>();;
        this._photo = GameObject.Find("photo").GetComponent<RawImage>();
    }

    // called when the game is terminated
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
