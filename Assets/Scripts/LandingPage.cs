using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LandingPage : MonoBehaviour
{
    private LifeHandler lifeHandler;

    private void Start()
    {
        lifeHandler = new LifeHandler();
    }

    private void OnMouseDown()
    {
        lifeHandler.ResetLifes();
        new KillHandler().ResetKills();
        SceneManager.LoadScene("gameplay");
    }
}
