using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField]
    private Vector2 StartingVelocity;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var enemy = collider.GetComponent<Enemy>();
        if(enemy)
        {
            enemy?.die();
            fireballDisappears();
        }
    }

    private void fireballDisappears()
    {
        Destroy(gameObject);
    }
}
