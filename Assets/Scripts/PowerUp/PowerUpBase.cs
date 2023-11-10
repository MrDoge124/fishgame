using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : MonoBehaviour
{
    protected GameObject playerObj;
    protected float duration;
    protected float maxtime = 5;
    protected bool poweredUp;
    protected AudioSource Source;
    protected AudioClip Clip;
    protected GameManager gm;
    // Start is called before the first frame update
    private void Start()
    {
        Source = GetComponent<AudioSource>();
        Clip = GetComponent<AudioSource>().clip;
        gm = GameObject.Find("Manager").GetComponent<GameManager>();
    }
    public virtual void OnTriggerEnter(Collider other)
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
        Source.PlayOneShot(Clip);
        print("Power up get. Will last " + maxtime + " seconds.");
        poweredUp = true;
        this.transform.position = new Vector3 (12, 400, 0);
    }
    public virtual void PowerUpCollect(GameManager gmlocal)//for point adding
    {
        Source.PlayOneShot(Clip);
        print("Play sound " + Clip.name);
        this.transform.position = new Vector3(12, 400, 0);
    }
    public virtual void PowerUpStop(GameObject player)
    {
        print("power up stop. Lasted " + maxtime + " seconds.");
        poweredUp = false;
        Destroy(this.gameObject);
    }

}
