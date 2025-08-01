using UnityEngine;

public class Targetsettings : MonoBehaviour
{
    private float timePassed = 0.0f;
    bool hit = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            hit = true;
            gameObject.transform.localScale = new Vector3(0,0,0);
            timePassed = 0.0f;
        }
    }

    private void Update()
    {
        timePassed += Time.deltaTime;

        if(hit && timePassed >= 0.5f)
        {
            var minPosition = new Vector3(-45, 0, 20);
            var maxPosition = new Vector3(-35, 10, 20);
            var randomPosition = new Vector3(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y), Random.Range(minPosition.z, maxPosition.z));
            gameObject.transform.localPosition = (randomPosition);
            gameObject.transform.localScale = new Vector3(1,1,1);
            hit = false;
            timePassed = 0.0f;
        }
    }
}
