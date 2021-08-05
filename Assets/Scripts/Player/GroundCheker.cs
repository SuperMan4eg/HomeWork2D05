using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheker : MonoBehaviour
{

    private bool _isGrounded = true;

    public bool IsGrounded => _isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Ground>(out Ground ground))
            _isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Ground>(out Ground ground))
            _isGrounded = false;
    }
}
