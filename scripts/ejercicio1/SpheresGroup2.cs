using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresGroup2 : MonoBehaviour
{
    Cylinder cylinder;
    GameObject targetObject;
    public float speed = 100f;
 
    void Start()
    {
        cylinder = GameObject.Find("Cylinder").GetComponent<Cylinder>();
        cylinder.OnContact += MoveTowardsCylinder;
        targetObject = GameObject.Find("Cylinder");
    }
 
    private void MoveTowardsCylinder()
    {
        Vector3 directionToCylinder = cylinder.transform.position - transform.position;
        transform.LookAt(cylinder.transform, Vector3.up);
        Vector3 movement = transform.forward * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}

