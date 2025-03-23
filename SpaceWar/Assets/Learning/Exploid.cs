using UnityEngine;

public class Exploid : MonoBehaviour
{
    private Timer _backtimer;
    [SerializeField] GameObject _exploidPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _backtimer = gameObject.AddComponent<Timer>();
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
    public void AsteroidYokEdici(int sure)
    {
        _backtimer.TotalTime = sure;
        _backtimer.StartTimer();
    }
}
