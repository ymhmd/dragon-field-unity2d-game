using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHandler
{

    public int LoadLifes()
    {
        if (PlayerPrefs.HasKey("lifes"))
        {
            return PlayerPrefs.GetInt("lifes");
        }
        return 0;
    }

    public void SaveLifes(int lifes)
    {
        PlayerPrefs.SetInt("lifes", lifes);
        PlayerPrefs.Save();
    }

    public void ResetLifes()
    {
        SaveLifes(2);
    }

    public int incrementLifes()
    {
        int lifes = LoadLifes();
        lifes++;
        SaveLifes(lifes);
        return lifes;
    }
}
