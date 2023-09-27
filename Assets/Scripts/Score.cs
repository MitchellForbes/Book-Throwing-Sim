using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int scorecount = 0;
    public int highScore = 0;

    public TextMeshProUGUI scoreText;

    // Update is called once per frame

    void Start()
    {
        scoreText.text = $"Score: {scorecount}";
    }

    void Update()
    {
        
    }


    public void AddPoints()
    {
        scorecount += 1;
        scoreText.text = $"Score: {scorecount}";
    }


    public void ResetScore()
    {
        if(scorecount > highScore)
        {
            highScore = scorecount;
        }

        scorecount = 0;
        scoreText.text = $"Score: {scorecount}";
    }
}
