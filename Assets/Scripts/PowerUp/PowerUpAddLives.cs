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
    }
    public override void OnTriggerEnter(Collider other)
    {
        PowerUpCollect(gm);
    }
}
