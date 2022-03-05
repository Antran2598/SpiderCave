using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel("GamePlay");
    }

    public void PlayGame1()
    {
        Application.LoadLevel("GamePlay2");
    }

    public void PlayGame2()
    {
        Application.LoadLevel("GamePlay3");
    }

    public void BackToMenu()
    {
        Application.LoadLevel("MainMenu");
    }
}
