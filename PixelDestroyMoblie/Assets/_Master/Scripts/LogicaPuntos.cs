using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LogicaPuntos : MonoBehaviour
{
    [SerializeField] private float puntos;

    public TextMeshProUGUI text;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cubes"))
        {
            puntos++;
        }
    }

    private void Update()
    {
        text.text = "Puntos " + puntos.ToString();
    }

}
