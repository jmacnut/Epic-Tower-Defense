using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //private Transform _start, _end;
    private Transform _spawnPoint;

    private GameObject[] _enemyPrefab;  // multiple enemy types


    // wave system - how and when do we increment?

    [SerializeField] private int _currentWave = 1;   // increment when all enemies killed
    [SerializeField] private int _spawnCount = 10;

    void Start()
    {
        // instantiate, delay, instantiate, delay... (use IEnumerator)
        // Instantiate(_enemyPrefab[Random.Range(0,2)]);   // 3 enemy types
        // empty object container (parent)

        // assign parent


        // start point
        // end point destination

        _spawnCount *= _currentWave;   // adds 10 to every wave...

    }

    void Update()
    {
        
    }
}
