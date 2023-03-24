using System.Collections;
using UnityEngine;

public class ZombieFactory : GenericFactory<ZombiMove>
{
    [SerializeField] private float _timer = 10f;
    private float _currentTimer;

    private void Start()
    {
        _currentTimer = _timer;
    }

    private void Update()
    {
        _currentTimer -= Time.deltaTime;
        if(_currentTimer <= 0f)
        {
            GetNewInstance();
            _currentTimer = _timer;
        }
    }
}
