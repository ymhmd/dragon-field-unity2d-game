using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillHandler
{

    public int LoadKills()
    {
        if (PlayerPrefs.HasKey("kills"))
        {
            return PlayerPrefs.GetInt("kills");
        }
        return 0;
    }

    public void SaveKills(int kills)
    {
        PlayerPrefs.SetInt("kills", kills);
        PlayerPrefs.Save();
    }

    public void ResetKills()
    {
        SaveKills(0);
    }

    public int incrementKills()
    {
        int kills = LoadKills();
        kills++;
        SaveKills(kills);
        Debug.Log(kills);
        return kills;
    }
}
