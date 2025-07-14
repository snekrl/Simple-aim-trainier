using UnityEngine;

public class TargetingSystem : MonoBehaviour
{
    public GameObject bulletObject;
    public float bulletSpeed = 400f; 
    public Transform shootingPoint;
    public Camera playerCamera; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            Vector3 direction;

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                direction = (hit.point - shootingPoint.position).normalized;
            }
            else
            {
          
                direction = ray.direction;
            }

            var bullet = Instantiate(bulletObject, shootingPoint.position, Quaternion.LookRotation(direction));
            bullet.GetComponent<Rigidbody>().linearVelocity = direction * bulletSpeed;

        }
    }
}
