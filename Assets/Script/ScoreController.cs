using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public Text ScoreKiri;
    public Text ScoreKanan;

    public ScoreManager manager;

    private void Update()
    {
        ScoreKiri.text = manager.leftScore.ToString();
        ScoreKanan.text = manager.rightScore.ToString();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
