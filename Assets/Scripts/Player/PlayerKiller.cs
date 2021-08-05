using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKiller : MonoBehaviour
{
    [SerializeField] private EnemyCheker _enemyCheker;
    [SerializeField] private Player _player;
    [SerializeField] private Animator _playerAnimator;

    private float _delay = 0.1f;

    private void Update()
    {
        if (_enemyCheker.IsTouched)
        {
            StartCoroutine(PlayerDead(_player));
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
