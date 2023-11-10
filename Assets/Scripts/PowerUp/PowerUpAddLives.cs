using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpAddLives : PowerUpBase
{
    public override void PowerUpCollect(GameManager gmlocal)
    {
        base.PowerUpCollect(gm);
        gmlocal = gm;
        gmlocal.AddLives(1);
        Destroy(this.gameObject, 1f);
    }
    public override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PowerUpCollect(gm);
        }
    }
}
