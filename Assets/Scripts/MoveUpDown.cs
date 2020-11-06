using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    [SerializeField]
    private float UP_DOWN_MOVING_FACTOR = 2f;

    // Update is called once per frame
    void Update()
    {
        var coin = GetComponent<Coin>();
        var enemy = GetComponent<Enemy>();

        if (coin)
        {
            transform.position += Vector3.up * Mathf.Cos(Time.time) * Time.deltaTime * UP_DOWN_MOVING_FACTOR;
        }
        else if (enemy)
        {
            transform.position += Vector3.up * Mathf.Cos(Time.time) * Time.deltaTime * Random.Range(1f, 5f);
        }
        else
        {
            transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * UP_DOWN_MOVING_FACTOR;
        }
    }
}
