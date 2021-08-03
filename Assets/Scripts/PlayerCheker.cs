using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheker : MonoBehaviour
{
    private Animator _playerAnimator;
    private float _delay = 0.1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _playerAnimator = collision.GetComponent<Animator>();
            StartCoroutine(PlayerDead(player));
        }
    }

    private IEnumerator PlayerDead(Player player)
    {
        _playerAnimator.SetTrigger("IsDead");

        yield return new WaitForSeconds(_delay);

        if (player != null)
            Destroy(player.gameObject);
    }
}
