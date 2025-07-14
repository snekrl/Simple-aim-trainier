using System;
using UnityEngine;

public class Targetsettings : MonoBehaviour
{


    private float timePassed = 0.0f;
    bool hit = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            hit = true;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        timePassed += Time.deltaTime;

        if (hit = true)
        {
            Instantiate(gameObject);
        }

    }
}
