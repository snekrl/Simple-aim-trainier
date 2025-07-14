using UnityEngine;

public class EnemySettings : MonoBehaviour
{
    public float healthAmount = 10f;



    void Start()
    {

    }

    void Update()
    {
        if (healthAmount <= 0)
        {
            print("");//placeholder
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            healthAmount = healthAmount - 1;
        }
;
    }
}