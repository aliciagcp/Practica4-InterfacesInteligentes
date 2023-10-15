using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    Notifier2 cube;
    private int score = 0;
    TextMeshProUGUI scoreText;
 
    void Start()
    {
        cube = GameObject.Find("Cube").GetComponent<Notifier2>();
        scoreText = GameObject.Find("Canvas/score").GetComponent<TextMeshProUGUI>();
        cube.OnCollectSpheres += UpdateScore;
    }
 
    private void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}
