using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManyPoints : PowerUpBase
{
    public override void PowerUpCollect(GameManager gmlocal)
    {
        base.PowerUpCollect(gm);
        gmlocal = gm;
        gmlocal.AddScore(5);
    }
    public override void OnTriggerEnter(Collider other)
    {
        PowerUpCollect(gm);
    }
}
