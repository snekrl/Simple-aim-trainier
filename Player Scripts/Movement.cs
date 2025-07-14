using JetBrains.Annotations;
using UnityEngine;

public class FPMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    private float xMove;
    private float yMove;
    public float runSpeed = 10f;

    private CharacterController characterController;

    public float gravity = -9.81f;
    public Transform checkForGround;
    public float distanceFromGround = 0.3f;
    public LayerMask layerMask;
    public bool thisIsGround;
    Vector3 velocity;

    public float Jump = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        thisIsGround = Physics.CheckSphere(checkForGround.position, distanceFromGround, layerMask);

        if (velocity.y < 0 && thisIsGround)
        {
            velocity.y = -2f;
        }

        xMove = Input.GetAxis("Horizontal");
        yMove = Input.GetAxis("Vertical");

        Vector3 Move = transform.right * xMove + transform.forward * yMove;
        characterController.Move(Move * runSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump")&& thisIsGround)
        {
            velocity.y = Mathf.Sqrt(Jump * -2 * gravity);
            thisIsGround=false;
        }
        velocity.y += gravity * Time.deltaTime;
        characterController = GetComponent<CharacterController>();
    }
}
