using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 250f;
    public float minXAngle = -80f;
    public float maxAngle = 90f;
    Transform playerBody;
    private float mouseX;
    private float mouseY;
    private float xRotation = 0f;
    public CursorLockMode mode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
