using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FuelCounter : MonoBehaviour
{


    public static int scoreValue = 0;

    TextMeshProUGUI textMesh;


    private void Start()
    {

        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textMesh.text = scoreValue + "/3:";

    }



}