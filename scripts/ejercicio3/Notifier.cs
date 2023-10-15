using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier : MonoBehaviour
{
    public delegate void ContactSpheres();
    public event ContactSpheres OnContactSpheres;
    public GameObject cylinder;
    float currentDistance;
    float umbral = 0.05f;

    void Start() {
        currentDistance = Vector3.Distance(transform.position, cylinder.transform.position);
    }

    void FixedUpdate() {
        float newDistance = Vector3.Distance(transform.position, cylinder.transform.position);
        if (currentDistance - newDistance > umbral) 
        {
            if(OnContactSpheres != null)
            {
                OnContactSpheres();
            }
        }
        currentDistance = newDistance;
    }
}
