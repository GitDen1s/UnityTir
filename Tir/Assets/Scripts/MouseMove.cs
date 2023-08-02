using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    [SerializeField] float _mouseSpeed = 2f;
    private float _mouseX = 0;
    private float _mouseY = 0;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        _mouseX += Input.GetAxis("Mouse X")*_mouseSpeed;
        _mouseY -= Input.GetAxis("Mouse Y")*_mouseSpeed;
        _mouseY = Mathf.Clamp(_mouseY, -45, 45);
        transform.rotation = Quaternion.Euler(_mouseY, _mouseX, 0);

    }
}
