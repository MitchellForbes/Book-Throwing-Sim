using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPojectiles : MonoBehaviour
{
    private float timer;
    private float timeLimit = 4f;



    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeLimit)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            Destroy(gameObject);
        }
    }

}
