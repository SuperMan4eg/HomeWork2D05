using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimator : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Rigidbody2D _rigidBody;

    private void Update()
    {
        if (_rigidBody.velocity.x > 0)
        {
            _spriteRenderer.flipX = true;
        }
        else if (_rigidBody.velocity.x < 0)
        {
            _spriteRenderer.flipX = false;
        }
    }
}
