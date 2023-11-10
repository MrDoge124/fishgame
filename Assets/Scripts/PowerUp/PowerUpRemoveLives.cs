using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpRemoveLives : PowerUpBase
{
    public override void PowerUpCollect(GameManager gmlocal)
    {
        base.PowerUpCollect(gm);
        gmlocal = gm;
        gmlocal.SubtractLives(1);
        Destroy(this.gameObject, 1f);
    }
    public override void OnTriggerEnter(Collider other)
    {
        PowerUpCollect(gm);
    }
}
