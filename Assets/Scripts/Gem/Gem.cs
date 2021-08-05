using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    [SerializeField] Animator _animator;

    private int _amount = 1;
    private float _dalay = 0.2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            StartCoroutine(GettingGem(player));
        }
    }

    private IEnumerator GettingGem(Player player)
    {
        player.CollectGem(_amount);

        _animator.SetTrigger("IsGetting");

        yield return new WaitForSeconds(_dalay);
        Destroy(gameObject);
    }
}
