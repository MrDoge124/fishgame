using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : PowerUpBase
{
    float speedMult = 1.5f;
    public override void PowerUpGet(GameObject player)
    {
        base.PowerUpGet(player);
        player.GetComponent<PlayerMovement>().playerSpeedX = player.GetComponent<PlayerMovement>().playerSpeedX * speedMult;
        player.GetComponent<PlayerMovement>().playerSpeedY = player.GetComponent<PlayerMovement>().playerSpeedY * speedMult;
    }
    public override void PowerUpStop(GameObject player)
    {
        base.PowerUpStop(player);
        player.GetComponent<PlayerMovement>().playerSpeedX = player.GetComponent<PlayerMovement>().playerSpeedX = 7;
        player.GetComponent<PlayerMovement>().playerSpeedY = player.GetComponent<PlayerMovement>().playerSpeedY = 4;
    }
}
