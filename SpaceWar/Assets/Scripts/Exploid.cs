using UnityEngine;

public class Exploid : MonoBehaviour
{
    private Timer _backtimer;
    [SerializeField] GameObject _exploidPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _backtimer = gameObject.AddComponent<Timer>();
        _backtimer.TotalTime = Random.Range(1, 20);
        _backtimer.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (_backtimer.Finished())
        {
            Instantiate(_exploidPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
