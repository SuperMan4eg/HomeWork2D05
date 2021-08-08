using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private GroundCheker _groundCheker;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigitBody2D;

    private void Start()
    {
        _rigitBody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-_speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space) && _groundCheker.IsGrounded)
        {
            _rigitBody2D.velocity = (Vector2.up * _jumpForce);
        }
    }
}
