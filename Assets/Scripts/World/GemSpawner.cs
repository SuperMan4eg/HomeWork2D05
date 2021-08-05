using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour
{
    [SerializeField] private Gem _template;
    [SerializeField] private Transform _spawnPoints;

    private Transform[] _points;

    private void Start()
    {   
        _points = new Transform[_spawnPoints.childCount];

        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            _points[i] = _spawnPoints.GetChild(i);
        }

        SpawnGem();
    }

    private void SpawnGem()
    {
        foreach (var spawnPoint in _points)
        {
            Instantiate(_template, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
