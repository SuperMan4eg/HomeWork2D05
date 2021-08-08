using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private int _gemAmount = 0;

    private float _delay = 0.1f;

    public void CollectGem(int amount)
    {
        _gemAmount += amount;
    }

    public void DeathJob()
    {
        StartCoroutine(Death(_player));
    }

    private IEnumerator Death(Player player)
    {
        _playerAnimator.SetTrigger("IsDead");

        yield return new WaitForSeconds(_delay);

        if (player != null)
            Destroy(player.gameObject);
    }
}
