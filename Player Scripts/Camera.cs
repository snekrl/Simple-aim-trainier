using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PCamera : MonoBehaviour
{
    [Header("Camera settings")]
    private float XMouse;
    private float YMouse;
    private float XRotation;

    [Header("Player obj")]
    public Transform character;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        XMouse = Input.GetAxis("Mouse X");
        YMouse = Input.GetAxis("Mouse Y");
        XRotation -= YMouse;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);
        character.Rotate(Vector3.up * XMouse);
    }
}
