using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresGroup1_2 : MonoBehaviour
{
    Cube cube;
    GameObject cylinder;
    public float speed = 100f;
 
    void Start()
    {
        cube = GameObject.Find("Cube").GetComponent<Cube>();
        cube.OnContactOtherGroup += MoveTowardsCylinder;
        cylinder = GameObject.Find("Cylinder");
    }
 
    private void MoveTowardsCylinder()
    {
        Vector3 directionToCylinder = cylinder.transform.position - transform.position;
        transform.LookAt(cylinder.transform, Vector3.up);
        Vector3 movement = transform.forward * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}
