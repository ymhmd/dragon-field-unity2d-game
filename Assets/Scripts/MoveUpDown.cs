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
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * UP_DOWN_MOVING_FACTOR;
    }
}
