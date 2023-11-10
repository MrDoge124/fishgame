using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]BoxCollider trashBox;
    [SerializeField] GameObject playerModel;
    [SerializeField]GameManager gm;
    public float playerSpeedX = 7f,playerSpeedY = 4f, playerBrakes = 1.3f, bounceForce = 36f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity.x > 0)
        {
            FlipModel(false);
        }
        if (rb.velocity.x < 0)
        {
            FlipModel(true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(playerSpeedX, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-playerSpeedX, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, playerSpeedY, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, -playerSpeedY, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = rb.velocity / playerBrakes;
        }
    }
    private void FlipModel(bool flip)
    {
        if (!flip)
        {
            playerModel.transform.localScale = new Vector3(playerModel.transform.localScale.x, 111.5997f, playerModel.transform.localScale.z);
        }
        if (flip)
        {
            playerModel.transform.localScale = new Vector3(playerModel.transform.localScale.x, -111.5997f, playerModel.transform.localScale.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Trash"))
        {
            Destroy(other.gameObject);
            gm.AddScore();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trash"))
        {
            if (collision.gameObject.GetComponent<Rigidbody>())
            {
                collision.gameObject.GetComponent<Rigidbody>().AddForce(0,bounceForce,0);
            }
        }
    }
}
