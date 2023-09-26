using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timer = 60f;
    private int timelimit = 0;

    bool timerState = false;
    Score score;
    SpawnTarget targetTimer;

    public TextMeshProUGUI startText;


    void Start()
    {
        targetTimer = GameObject.Find("TargetSpawner").GetComponent<SpawnTarget>();
    }
    // Update is called once per frame
    void Update()
    {


        if (timerState == true)
        {
            timer -= Time.deltaTime;
        }
        
        if (timer <= timelimit)
        {
            timerState = false;
            timer = 0f;
            targetTimer.timerActive = false;
        }

    }

    private void OnMouseDown()
    {
        if (timerState == false)
        {
            score = GameObject.Find("UI").GetComponent<Score>();
            score.ResetScore();
            targetTimer.timerActive = true;
        }
        timerState = true;
    }

    private void OnMouseOver()
    {
        startText.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        startText.gameObject.SetActive(false);
    }
}
