using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Choosing : MonoBehaviour
{
    string sceneName;
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    
    void Update()
    {
        if(Input.GetKeyDown("escape")){
            PlayerPrefs.SetString("nameLevel", sceneName);
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void ShowFirstGame(){
        SceneManager.LoadScene("Game");
         PlayerPrefs.SetString("nameLevel", sceneName);
    }
    public void ShowSecondGame(){
        SceneManager.LoadScene("Game2");
         PlayerPrefs.SetString("nameLevel", sceneName);
    }
    public void ShowThGame(){
        SceneManager.LoadScene("Game3");
         PlayerPrefs.SetString("nameLevel", sceneName);
    }
}
