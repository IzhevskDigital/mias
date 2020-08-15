using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserManager : MonoBehaviour
{
    private string _currentUserId = string.Empty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (string.IsNullOrEmpty(this._currentUserId)){
            SceneSwitcher.GotoWelcomeScene();
        }
    }
}
