using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerBody;
    [SerializeField] private SpriteRenderer spriteRenderer;

    bool flipX = false;

    // Update is called once per frame
    void Update()
    {
        if (playerBody.velocity.x < 0) spriteRenderer.flipX = flipX = true;
        else if (playerBody.velocity.x == 0) spriteRenderer.flipX = flipX;
        else spriteRenderer.flipX = flipX = false;
    }
}
