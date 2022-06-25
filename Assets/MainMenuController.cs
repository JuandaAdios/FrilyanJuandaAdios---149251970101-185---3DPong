using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void CreditTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
