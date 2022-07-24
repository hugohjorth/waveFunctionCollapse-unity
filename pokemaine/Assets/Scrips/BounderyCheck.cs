using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounderyCheck : MonoBehaviour
{
    public bool isWater;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision);
        if (collision.gameObject.layer == 8 && !isWater) isWater = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 && isWater) isWater = false;
    }
}
