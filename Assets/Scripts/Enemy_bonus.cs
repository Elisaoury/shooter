using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_bonus : MonoBehaviour
{
    public GameObject bonus;

    public void OnEnemyDied ()
    {
        Instantiate(bonus, transform.position, transform.rotation);

    }

}