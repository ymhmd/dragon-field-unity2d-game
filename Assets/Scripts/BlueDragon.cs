using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BlueDragon : MonoBehaviour
{
    private Rigidbody2D rigidbodyComponenet;
    private Vector2 jumpForce;

    private bool jump = false;
    private int JUMP_FACTOR = 500;

    [SerializeField]
    private int lifes;


    private LifeHandler lifeHandler;


    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponenet = GetComponent<Rigidbody2D>();
        jumpForce = new Vector2(0, JUMP_FACTOR);

        lifeHandler = new LifeHandler();
        lifes = lifeHandler.LoadLifes();
    }

    private void handleFailure()
    {
        lifes--;
        if (lifes == 0)
        {
            SceneManager.LoadScene("fail");
            lifeHandler.ResetLifes();
        }
        else
        {
            SceneManager.LoadScene("gameplay");
            lifeHandler.SaveLifes(lifes);
        }
    }

    private void DragonKiller()
    {
        float currentY = GetComponent<Transform>().position.y;
        if (currentY > 5f || currentY < -5f)
        {
            handleFailure();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

        DragonKiller();
    }

    private void FixedUpdate()
    {
        DragonJumps();
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        var enemy = collider2D.GetComponent<Enemy>();
        var tree = collider2D.GetComponent<Tree>();
        var meat = collider2D.GetComponent<Meat>();

        if (enemy || tree)
        {
            handleFailure();
        }

        if (meat)
        {
            lifes = lifeHandler.incrementLifes();
            meat?.die();
        }
    }

    //Custome methods
    private void DragonJumps()
    {
        if (jump)
        {
            rigidbodyComponenet.AddForce(jumpForce);
            jump = false;
        }
    }
}
