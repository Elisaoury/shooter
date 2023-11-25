using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy_bonus : MonoBehaviour
{
    public GameObject bonus;

    public void OnEnnemyDied ()
    {
        Instantiate(bonus, transform.position, transform.rotation);

    }

}