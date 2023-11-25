using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ui_controller : MonoBehaviour
{
    public Transform conteneurEnemy; 
    public TextMeshProUGUI enemyText;

    private void Update()
    {
        enemyText.text = "Ennemis restants : ";
        enemyText.text += conteneurEnemy.childCount.ToString();
    }
}
