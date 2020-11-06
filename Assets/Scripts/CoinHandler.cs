using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHandler
{
    public int LoadCoins()
    {
        if (PlayerPrefs.HasKey("coins"))
        {
            return PlayerPrefs.GetInt("coins");
        }
        return 0;
    }

    public void SaveCoins(int coins)
    {
        PlayerPrefs.SetInt("coins", coins);
        PlayerPrefs.Save();
    }

    public void ResetCoins()
    {
        SaveCoins(0);
    }

    public int incrementCoins()
    {
        int coins = LoadCoins();
        coins++;
        SaveCoins(coins);
        Debug.Log(coins);
        return coins;
    }
}
