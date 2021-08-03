using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    [SerializeField] private Gem _template;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        SpawnGem();
    }

    private void SpawnGem()
    {
        foreach (var spawnPoint in _spawnPoints)
        {
            Instantiate(_template, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
