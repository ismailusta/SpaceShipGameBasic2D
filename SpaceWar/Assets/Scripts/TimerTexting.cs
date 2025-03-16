using UnityEngine;

public class TimerTexting : MonoBehaviour
{
    Timer _timer;
    float _startTime;

    void Start()
    {
        _timer = gameObject.AddComponent<Timer>();
        _timer.TotalTime = 3;
        _timer.StartTimer();

        _startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer.Finished())
        {
            float elapsedTime = Time.time - _startTime;
            Debug.Log("Timer bitti. Geçen süre: " + elapsedTime);

            _startTime = Time.time;
            _timer.StartTimer();
        }
    }
}
