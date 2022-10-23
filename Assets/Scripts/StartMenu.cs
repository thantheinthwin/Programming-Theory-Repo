using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class StartMenu : MonoBehaviour
{
    public TMP_InputField PlayerName;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startNew()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayerNameInput()
    {
        PlayerData.Instance.PlayerName = PlayerName.text;
    }

    public void Quit()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #endif
        Application.Quit();
    }
}
