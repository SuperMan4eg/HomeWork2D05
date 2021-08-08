using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed = 2.5f;
    [SerializeField] private Transform _pointStart;
    [SerializeField] private Transform _pointEnd;

    private Rigidbody2D _rigidBody;
    private bool _onRight;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (transform.position.x <= _pointEnd.position.x)
        {
            _onRight = true;
        }
        if (transform.position.x >= _pointStart.position.x)
        {
            _onRight = false;
        }

        MakePosition();
    }

    private void MakePosition()
    {
        if (_onRight)
        {
            _rigidBody.velocity = new Vector2(_speed, _rigidBody.velocity.y);
        }
        else
        {
            _rigidBody.velocity = new Vector2(-_speed, _rigidBody.velocity.y);
        }
    }
}
