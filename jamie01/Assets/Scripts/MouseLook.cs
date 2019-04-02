using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Header("Rotation Type")]
    public RotationType rotateType = RotationType.MouseX;
    [Space(20)]
    [Range(0, 30)]
    public float sensitivity = 15;
    public float minY = -60, maxY = 60;
    //private float rotationY, rotationX;
    private float rotation;

    private void Start()
    {
        if (GetComponent<Camera>())
        {
            rotateType = RotationType.MouseY;
        }

    }

    // Update is called once per frame

    void Update()
    {
        if (rotateType == RotationType.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity * Time.timeScale, 0);
        }
        else
        {
            rotation += Input.GetAxis("Mouse Y") * sensitivity * Time.timeScale;
            rotation = Mathf.Clamp(rotation, minY, maxY);
            transform.localEulerAngles = new Vector3(-rotation, 0, 0);
        }
    }
}
public enum RotationType
{
    MouseX, MouseY
}