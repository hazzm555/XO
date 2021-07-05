using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMap : MonoBehaviour
{   
    
    public Sprite X, O; // me = X ,  the other guy = O
    public bool Turn = false; //false = me , true = the other guy
    public int TurnNumber = 0;
    public Button [] x;
    public AudioSource AudioClip;

    private bool [] xarr = new bool [9];
    private bool[] oarr = new bool[9];

    public GameObject PauseMenu, Menubtn, GameTools;
    public Image TurnToggle;


    // Start is called before the first frame update

    void Start()
    {
        for (int i = 0; i < 9; i++) {
            xarr[i] = false;
            oarr[i] = false;
        }
    }

    // Activated after each click
    private void Checker() {
        TurnNumber++;
        AudioClip.Play();
        //win
        if (xarr[0] == true && xarr[1] == true && xarr[2] == true)
            Win();
        else if (xarr[3] == true && xarr[4] == true && xarr[5] == true)
            Win();
        else if (xarr[6] == true && xarr[7] == true && xarr[8] == true)
            Win();
        else if (xarr[0] == true && xarr[3] == true && xarr[6] == true)
            Win();
        else if (xarr[1] == true && xarr[4] == true && xarr[7] == true)
            Win();
        else if (xarr[2] == true && xarr[5] == true && xarr[8] == true)
            Win();
        else if (xarr[0] == true && xarr[4] == true && xarr[8] == true)
            Win();
        else if (xarr[2] == true && xarr[4] == true && xarr[6] == true)
            Win();
        //lose
        if (oarr[0] == true && oarr[1] == true && oarr[2] == true)
            Lose();
        else if (oarr[3] == true && oarr[4] == true && oarr[5] == true)
            Lose();
        else if (oarr[6] == true && oarr[7] == true && oarr[8] == true)
            Lose();
        else if (oarr[0] == true && oarr[3] == true && oarr[6] == true)
            Lose();
        else if (oarr[1] == true && oarr[4] == true && oarr[7] == true)
            Lose();
        else if (oarr[2] == true && oarr[5] == true && oarr[8] == true)
            Lose();
        else if (oarr[0] == true && oarr[4] == true && oarr[8] == true)
            Lose();
        else if (oarr[2] == true && oarr[4] == true && oarr[6] == true)
            Lose();

        //Draw
        if (TurnNumber == 9)
            SceneManager.LoadScene("Draw Scene");


        //TurnToggle 
        if(Turn)
            TurnToggle.sprite = O ;
        else
            TurnToggle.sprite = X ;



    }

    private void Lose() {
        SceneManager.LoadScene("Lose Scene");

    }

    private void Win()
    {
        SceneManager.LoadScene("Win Scene");

    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }

    public void Menu() {
        GameTools.SetActive(false);
        PauseMenu.SetActive(true);
        Menubtn.SetActive(false);


    }
    public void Quit()
    {
        Application.Quit();


    }
    public void BackToStartMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void BackFromPauseMenu()
    {
        Menubtn.SetActive(true);
        PauseMenu.SetActive(false);
        GameTools.SetActive(true);
        
    }


    public void btn1() {
        int r = 0;
        if (x[r].image.sprite.name == "UIMask")
        {
            if (Turn)
            {
                x[r].image.sprite = O;
                oarr[r] = true;
            }
            else
            {       x[r].image.sprite = X;
            xarr[r] = true;
        }
            Turn = !Turn;
            Checker();
        }
    }

    public void btn2()
    {
        int r = 1;
        if (x[r].image.sprite.name == "UIMask") {
            if (Turn)
            {
                x[r].image.sprite = O;
                oarr[r] = true;
            }
            else
            {
                x[r].image.sprite = X;
                xarr[r] = true;
            }
        Turn = !Turn;
            Checker();
        }
    }
    public void btn3()
        
    {
        int r = 2;
        if (x[r].image.sprite.name == "UIMask")
        {
            if (Turn)
            {
                x[r].image.sprite = O;
                oarr[r] = true;
            }
            else
            {
                x[r].image.sprite = X;
                xarr[r] = true;
            }
            Turn = !Turn;
            Checker();
        }
    }
    public void btn4()
    {
        int r = 3;
        if (x[r].image.sprite.name == "UIMask")
        {
            if (Turn)
            {
                x[r].image.sprite = O;
                oarr[r] = true;
            }
            else
            {
                x[r].image.sprite = X;
                xarr[r] = true;
            }
            Turn = !Turn;
            Checker();
        }
    }
    public void btn5()
    {
        int r = 4;
        if (x[r].image.sprite.name == "UIMask")
        {
            if (Turn)
            {
                x[r].image.sprite = O;
                oarr[r] = true;
            }
            else
            {
                x[r].image.sprite = X;
                xarr[r] = true;
            }
            Turn = !Turn;
            Checker();
        }
    }
    public void btn6()
    {
        int r = 5;
        if (x[r].image.sprite.name == "UIMask")
        {
            if (Turn)
            {
                x[r].image.sprite = O;
                oarr[r] = true;
            }
            else
            {
                x[r].image.sprite = X;
                xarr[r] = true;
            }
            Turn = !Turn;
            Checker();
        }
    }
    public void btn7()
    {
        int r = 6;
        if (x[r].image.sprite.name == "UIMask")
        {
            if (Turn)
            {
                x[r].image.sprite = O;
                oarr[r] = true;
            }
            else
            {
                x[r].image.sprite = X;
                xarr[r] = true;
            }
            Turn = !Turn;
            Checker();
        }
    }
    public void btn8()
    {
        int r = 7;
        if (x[r].image.sprite.name == "UIMask")
        {
            if (Turn)
            {
                x[r].image.sprite = O;
                oarr[r] = true;
            }
            else
            {
                x[r].image.sprite = X;
                xarr[r] = true;
            }
            Turn = !Turn;
            Checker();
        }
    }
    public void btn9()
    {
        int r = 8;
        if (x[r].image.sprite.name == "UIMask")
        {
            if (Turn)
            {
                x[r].image.sprite = O;
                oarr[r] = true;
            }
            else
            {
                x[r].image.sprite = X;
                xarr[r] = true;
            }
            Turn = !Turn;
            Checker();
        }
    }

}
