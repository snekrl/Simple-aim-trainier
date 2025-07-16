using UnityEngine;

public class EnemyAI : MonoBehaviour
{




    void Start()
    {

    }

    void Update()
    {
        var minPosition = new Vector3(-45, 0, 20);
        var maxPosition = new Vector3(-35, 10, 20);
        var randomPosition = new Vector3(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y), Random.Range(minPosition.z, maxPosition.z));
        gameObject.transform.localPosition = (randomPosition);
        gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
}