using UnityEngine;

public class ExploidCanceld : MonoBehaviour
{
    Timer _explodebacktimer;
    SiraliYokEdici _siraliYokEdici;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _explodebacktimer = gameObject.AddComponent<Timer>();
        _explodebacktimer.TotalTime = 1;
        _explodebacktimer.StartTimer();
        _siraliYokEdici = Camera.main.GetComponent<SiraliYokEdici>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_explodebacktimer.Finished())
        {
            _siraliYokEdici.HedefiYokEt();
            Destroy(gameObject);
        }
    }
}
