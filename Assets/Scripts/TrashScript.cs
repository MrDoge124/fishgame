using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashScript : MonoBehaviour
{
    GameManager gm;
    Rigidbody rb;
    float wallForce = 20;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = FindObjectOfType<GameManager>();
        print(gm.name);
    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground")) 
        {
            gm.SubtractLives(1);
            Destroy(this);
        }
        if (collision.gameObject.CompareTag("WallL"))
        {
            rb.AddForce(wallForce,0,0);
        }
        if (collision.gameObject.CompareTag("WallR"))
        {
            rb.AddForce(-wallForce, 0, 0);
        }
    }
}
