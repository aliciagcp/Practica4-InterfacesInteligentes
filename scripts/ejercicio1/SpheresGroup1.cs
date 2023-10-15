using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresGroup1 : MonoBehaviour
{
    Cylinder cylinder;
 
    void Start()
    {
        cylinder = GameObject.Find("Cylinder").GetComponent<Cylinder>();
        cylinder.OnContact += ChangeColor;
    }
 
    private void ChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}
