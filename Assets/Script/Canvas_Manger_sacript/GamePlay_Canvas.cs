using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamePlay_Canvas : MonoBehaviour
{

    public TextMeshProUGUI coinText;
    public Canvas Gameplay_canvas;
    // Start is called before the first frame update
    public void CoinCount()
    {
        string coinCountText = coinText.text.Replace("Coins: ", "");


        int currentCoinCount = int.Parse(coinCountText);

        currentCoinCount += 5;


        coinText.text = currentCoinCount.ToString();

    }
}
