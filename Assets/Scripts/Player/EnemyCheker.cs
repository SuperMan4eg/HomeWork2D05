using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheker : MonoBehaviour
{
    private bool _isTouched;

    public bool IsTouched => _isTouched;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
        {
            _isTouched = true;
        }
    }
}
