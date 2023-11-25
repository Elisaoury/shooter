using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float speed;
    public int life;
    // St0art is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed*2;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) return;

        life--;
        var enemyBonus = other.GetComponent<Enemy_bonus>();
        if (enemyBonus != null) enemyBonus.OnEnemyDied();
        Destroy(other.gameObject);
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

}
