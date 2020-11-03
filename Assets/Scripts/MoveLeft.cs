using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float MOVING_LEFT_FACTOR = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * MOVING_LEFT_FACTOR, Space.World);

        float currentX = GetComponent<Transform>().position.x;
        if (currentX <= -15)
        {
            //transform.position += Vector3.right * 20;
            transform.position += new Vector3(30, 0, 0);
            var enemy = GetComponent<Enemy>();
            enemy?.respawn();
            var meat = GetComponent<Meat>();
            meat?.respawn();

            showRandomSprite();
        }
    }

    private void OnEnable()
    {
        showRandomSprite();
    }

    private void showRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            child.gameObject.SetActive(index == i);
        }
    }
}
