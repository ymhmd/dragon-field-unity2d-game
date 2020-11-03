using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField]
    private GameObject fireGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float x = GetComponent<Transform>().position.x + 2;
            float y = GetComponent<Transform>().position.y;
            Vector3 firestartingPosition = new Vector3(x, y, 0);

            //var x = Instantiate(fireGameObject, transform.position, fireGameObject.transform.rotation);

            var xx = Instantiate(fireGameObject, firestartingPosition, fireGameObject.transform.rotation);
        }

    }
}
