using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresGroup1_3 : MonoBehaviour
{
    Notifier notifier;
    float force = 50f;
 
    void Start()
    {
        notifier = GameObject.Find("Cube").GetComponent<Notifier>();
        notifier.OnContactSpheres += ChangeColor;
        notifier.OnContactSpheres += Jump;
    }
 
    private void ChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }

    private void Jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * force);
    }
}
