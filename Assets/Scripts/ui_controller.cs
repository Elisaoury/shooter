using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ui_controller : MonoBehaviour
{
    public Transform conteneurEnnemy; 
    public TextMeshProUGUI ennemiesText;

    private void Update()
    {
        ennemiesText.text = "Ennemis restants : ";
        ennemiesText.text += conteneurEnnemy.childCount.ToString();
    }
}
