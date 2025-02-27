using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySprite : MonoBehaviour
{
    [SerializeField] private Rigidbody2D enemyBody;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private bool flip = false;

    bool flipX = false;

    // Update is called once per frame
    void Update()
    {
        if (enemyBody.velocity.x < 0) spriteRenderer.flipX = flipX = true;
        else if (enemyBody.velocity.x == 0) spriteRenderer.flipX = flipX;
        else spriteRenderer.flipX = flipX = false;
        if (flip) spriteRenderer.flipX = !spriteRenderer.flipX;
    }
}
