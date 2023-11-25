using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spell;
    public GameObject enemy;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;

    public bool specialAttack = false;

    public float speed = 8f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * 2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * 2;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, parent.position, parent.rotation);
        }
        if (Input.GetKeyDown(KeyCode.E) && specialAttack)
        {
            Instantiate(spell, parent.position, parent.rotation);
            specialAttack = false;
        }

        if (transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }
}
