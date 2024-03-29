using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlay_Canvas : MonoBehaviour
{

    public TextMeshProUGUI coinText;
    public Canvas Gameplay_canvas;
    public Canvas GameStart_Canvas;
    public Canvas GameWin_Canvas;
    public Canvas GameOver_Canvas;
    public TextMeshProUGUI Health_txt;


    private void Start()
    {
        Gameplay_canvas.enabled = false;
        GameWin_Canvas .enabled = false;
        GameOver_Canvas.enabled = false;
        GameStart_Canvas.enabled = true;
    }
    // Start is called before the first frame update
   

    public void OnPlayBtnClick()
    {
        GameStart_Canvas.enabled = false;
        Gameplay_canvas.enabled = true;
    }

    public void OnExitBtnClick()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void OnGameWin()
    {
        GameWin_Canvas.enabled = true;
        Gameplay_canvas.enabled = false;
    }
    public void OnRestartBtnClick()
    {
        SceneManager.LoadScene("Mario");
    }
    public void GameOverEnable()
    {
        GameOver_Canvas.enabled = true;
    }
    public void healthCount()
    {
        string healthCount_text = Health_txt.text.Replace("health","");

        int currentHealth = int.Parse(healthCount_text);

        currentHealth -= 20;

        Health_txt.text = currentHealth.ToString();
    }
    public void CoinCount()
    {
        string coinCountText = coinText.text.Replace("Coins: ", "");


        int currentCoinCount = int.Parse(coinCountText);

        currentCoinCount += 5;


        coinText.text = currentCoinCount.ToString();

    }
}

