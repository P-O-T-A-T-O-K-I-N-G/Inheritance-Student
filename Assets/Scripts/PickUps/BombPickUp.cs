using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPickUp : PickUp
{
    public override void ActivatePickUp()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach(GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        Destroy(gameObject);
    }
}
