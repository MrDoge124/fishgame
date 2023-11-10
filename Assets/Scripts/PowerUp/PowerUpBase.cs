using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : MonoBehaviour
{
    protected GameObject playerObj;
    protected float duration;
    protected float maxtime = 8;
    protected bool poweredUp;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerObj = other.gameObject;
            PowerUpGet(playerObj);
        }
    }
    private void Update()
    {
        if (poweredUp)
        {
            duration += Time.deltaTime;
        }
        if (duration >= maxtime)
        {
            duration = 0;
            PowerUpStop(playerObj);
        }
    }
    public virtual void PowerUpGet(GameObject player)
    {
        print("Power up get. Will last " + maxtime + " seconds.");
        poweredUp = true;
        this.transform.position = new Vector3 (12, 20, 0);
    }
    public virtual void PowerUpStop(GameObject player)
    {
        print("power up stop. Lasted " + duration + " seconds.");
        poweredUp = false;
        Destroy(this.gameObject);
    }

}
