using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGameplayManager : MonoBehaviour
{
    
    public int _maxPlanes = 1;
    float _timer;
    [SerializeField]
    float _maxTimer = 12;
    [SerializeField]
    float _minTimer = 8;

    [SerializeField]
    GameObject _enemyPrefab;
    [SerializeField]
    Transform[] _spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        _timer = Random.Range(_minTimer, _maxTimer);
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        if(_timer <= 0)
        {
            _timer = Random.Range(_minTimer, _maxTimer);
            GameObject spawnedEnemy = Instantiate(_enemyPrefab);
            int ranSpawn = Random.Range(0, _spawnPoints.Length-1);
            spawnedEnemy.transform.position = _spawnPoints[ranSpawn].position;
            spawnedEnemy.transform.rotation = _spawnPoints[ranSpawn].rotation;
        }
    }
}
