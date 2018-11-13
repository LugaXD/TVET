using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazardscript : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(horizontalMove, verticalMove, 0) * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
