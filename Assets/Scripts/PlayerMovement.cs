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
    private void FlipModel(bool flip)
    {
        if (!flip)
        {
            playerModel.transform.localScale = new Vector3(playerModel.transform.localScale.x, playerModel.transform.localScale.y, 111.5997f);
        }
        if (flip)
        {
            playerModel.transform.localScale = new Vector3(playerModel.transform.localScale.x, playerModel.transform.localScale.y, -111.5997f);
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
}
