using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HermesCoinPickUp : PickUp
{
    public override void ActivatePickUp()
    {
        float originalSpeed = 5;

        player.moveSpeed *= 2.0f;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;

        StartCoroutine(ResetSpeed(originalSpeed, 5.0f));
    }

    private IEnumerator ResetSpeed(float originalSpeed, float duration)
    {
        yield return new WaitForSeconds(5);

        player.moveSpeed = originalSpeed;
        Destroy(gameObject);
    }
}
