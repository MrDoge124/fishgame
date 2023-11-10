using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : MonoBehaviour
{
    protected GameObject player;
    protected float duration;
    protected float maxtime;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PowerUpGet();
        }
    }

    public virtual void PowerUpGet()
    {
        print("power up get. " + maxtime);
    }

}
