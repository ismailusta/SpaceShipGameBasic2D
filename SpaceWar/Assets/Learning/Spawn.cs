using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject _astreoidprefab;
    private Timer _timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _timer = gameObject.AddComponent<Timer>();
        _timer.TotalTime = 1;
        _timer.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer.Finished())
        {
            SpawnAsteroid();
            _timer.StartTimer();
        }
    }

    void SpawnAsteroid()
    {
        Instantiate(_astreoidprefab);
    }
}
