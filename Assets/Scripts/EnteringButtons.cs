using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnteringButtons : MonoBehaviour
{
    public GameObject MainMenu;


    public void Back() {
        MainMenu.SetActive(true);
        



    }

    public void BackToStartMenu()
    {
        SceneManager.LoadScene("Start Scene");
    }

    
    public void Play() {
        SceneManager.LoadScene("Game Scene");
    }

    public void Quit() {
        Application.Quit();


    }
}
