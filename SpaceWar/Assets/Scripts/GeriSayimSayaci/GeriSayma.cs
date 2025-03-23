using UnityEngine;

public class GeriSayma : MonoBehaviour
{
    private float toplamSure;
    private float gecenSure;
    private bool _basladiMi = false;
    private bool _calisiyorMu = false;

    public float ToplamSure
    {
        get { return toplamSure; }
        set
        {
            if (!_calisiyorMu)
            {
                toplamSure = value;
            }
        }
    }
    public void Baslat()
    {
        if (toplamSure > 0)
        {
            _basladiMi = true;
            _calisiyorMu = true;
            gecenSure = 0;
        }
    }
    public bool BittiMi()
    {
        return _basladiMi && !_calisiyorMu;
    }
    // Update is called once per frame
    void Update()
    {
        if (_basladiMi)
        {
            gecenSure += Time.deltaTime;
            if (gecenSure >= toplamSure)
            {
                _calisiyorMu = false;
            }
        }
    }
}
