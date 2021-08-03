using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Transform))]
public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed = 2.5f;
    [SerializeField] private Transform _point1;
    [SerializeField] private Transform _point2;

    private Rigidbody2D _rigidBody;
    private Transform _transform;
    private bool _onRight;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (_transform.position.x <= _point2.position.x)
        {
            _onRight = true;
        }
        if (_transform.position.x >= _point1.position.x)
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
