using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneKill : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().Damage(10000, false, true);
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
