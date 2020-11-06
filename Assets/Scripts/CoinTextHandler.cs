using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinTextHandler : MonoBehaviour
{
    private Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>(); 
    }

    void Update()
    {
        txt.text = "" + new CoinHandler().LoadCoins();
    }
}
