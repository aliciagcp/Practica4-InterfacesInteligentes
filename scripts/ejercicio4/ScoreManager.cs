using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    Notifier2 cube;
    private int score = 0;
 
    void Start()
    {
        cube = GameObject.Find("Cube").GetComponent<Notifier2>();
        cube.OnCollectSpheres += UpdateScore;
    }
 
    private void UpdateScore(int points)
    {
        score += points;
        Debug.Log("Puntuación actual: " + score);
    }
}
