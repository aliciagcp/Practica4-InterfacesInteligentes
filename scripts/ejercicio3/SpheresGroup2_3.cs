using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresGroup2_3 : MonoBehaviour
{
    Notifier notifier;
    public GameObject cube;
 
    void Start()
    {
        notifier = GameObject.Find("Cube").GetComponent<Notifier>();
        notifier.OnContactSpheres += Rotate;
    }
 
    private void Rotate()
    {
        Vector3 directionToCube = cube.transform.position - transform.position;
        transform.LookAt(cube.transform, Vector3.up);
    }
}

