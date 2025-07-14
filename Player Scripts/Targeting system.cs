using Unity.VisualScripting;
using UnityEngine;

public class TargetingSystem : MonoBehaviour
{
    public GameObject bulletObject;
    public float bulletSpeed = 10f;
    public Transform shootingPoint;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var bullet = Instantiate(bulletObject, shootingPoint.position, shootingPoint.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = shootingPoint.forward * bulletSpeed;
        }


;

    }





}
