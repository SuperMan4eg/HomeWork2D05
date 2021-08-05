using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private GroundCheker _groundCheker;

    private Animator _animator;
    private SpriteRenderer _renderer;
    private bool _grounded;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _grounded = _groundCheker.IsGrounded;
        _animator.SetBool("IsGrounded", _grounded);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            _animator.SetBool("IsRunning", true);

            if (Input.GetKey(KeyCode.A))
            {
                _renderer.flipX = true;
            }
            else
            {
                _renderer.flipX = false;
            }
        }
        else
        {
            _animator.SetBool("IsRunning", false);
        }
    }
}