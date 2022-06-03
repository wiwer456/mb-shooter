using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public GameObject Cam;
    public GameObject Cam2;
    public GameObject [] UIForDel;
    public GameObject [] SettingsUI;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void DelDefoltUI(){
        UIForDel[0].SetActive(false);
        UIForDel[1].SetActive(false);
        UIForDel[2].SetActive(false);
        UIForDel[3].SetActive(false);
    }
    void ShowDefoltUI(){
        UIForDel[0].SetActive(true);
        UIForDel[1].SetActive(true);
        UIForDel[2].SetActive(true);
        UIForDel[3].SetActive(true);
    }

    void DelSettingsUI(){
        SettingsUI[0].SetActive(false);
        SettingsUI[1].SetActive(false);
    }
    void ShowSettingsUI(){
        SettingsUI[0].SetActive(true);
        SettingsUI[1].SetActive(true);
    }

    public void StartGame(){
        SceneManager.LoadScene("ChoosingLevel");
    }
    public void ShowSettings(){
        DelDefoltUI();
        ShowSettingsUI();
    }
    public void BackToMenu(){
        ShowDefoltUI();
        DelSettingsUI();
    }
    public void ContinueGame(){
        SceneManager.LoadScene(PlayerPrefs.GetString("nameLevel"));
    }
}
