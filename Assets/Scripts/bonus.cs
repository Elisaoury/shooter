using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.down * speed;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var movementEtTir = collision.GetComponent<MovementEtTir>();
        if (movementEtTir != null) movementEtTir.specialAttack = true;
        Destroy(gameObject);
        //ScoreScript.score += 3;
    }
}