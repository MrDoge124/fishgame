using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]BoxCollider trashBox;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(4, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-4, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = rb.velocity / 1.5f;
        }
    }
}
