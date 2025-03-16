using UnityEditor.Rendering;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _totalTime = 0;
    private float _elapsedTime = 0;
    private bool _isRunning = false;
    private bool _isStarted = false;

    public float TotalTime
    {
        get { return _totalTime; }
        set
        {
            if (!_isRunning)
            {
                _totalTime = value;
            }
        }
    }
    public bool Finished()
    {
        return _isStarted && !_isRunning;
    }
    public void StartTimer()
    {
        if (_totalTime > 0)
        {
            _isRunning = true;
            _isStarted = true;
            _elapsedTime = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (_isRunning)
        {
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime >= _totalTime)
            {
                _isRunning = false;
            }
        }
    }
}
