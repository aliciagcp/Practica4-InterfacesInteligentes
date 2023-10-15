using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresGroup2_2 : MonoBehaviour
{
    Cube cube;
    public float increaseSize = 1.5f;
 
    void Start()
    {
        cube = GameObject.Find("Cube").GetComponent<Cube>();
        cube.OnContactGroup1 += IncreaseSizeSphere;
    }
 
    private void IncreaseSizeSphere()
    {
        Vector3 scale = transform.localScale;
        transform.localScale = new Vector3(scale.x * increaseSize, scale.y * increaseSize, scale.z * increaseSize);
    }
}
