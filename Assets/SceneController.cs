using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class SceneController : MonoBehaviour
{
    public static string Keyword;
  
    public void Start()
    {
        Debug.Log(Keyword);
       


    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ChangeTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void AskGoogle(string keywordName)
    {
        Keyword = keywordName;
        Debug.Log(Keyword);
    }



    
}