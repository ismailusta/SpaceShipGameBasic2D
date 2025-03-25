using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIKontrol : MonoBehaviour
{
    [SerializeField] GameObject _oyunAdi = default;
    [SerializeField] GameObject _oyunBitti = default;
    [SerializeField] GameObject _puan;
    TextMeshProUGUI _puanText;
    [SerializeField] Button _baslabuton = default;

    int puannum = 0;
    OyunKontrol oyunKontrol;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        oyunKontrol = GetComponent<OyunKontrol>();
        _oyunBitti.SetActive(false);
        _puan.SetActive(false);
        _baslabuton.onClick.AddListener(() => oyunKontrol.OyunBaslat());
    }
    public void OyunBasladiginda()
    {
        puannum = 0;
        _oyunBitti.SetActive(false);
        _oyunAdi.SetActive(false);
        _baslabuton.gameObject.SetActive(false);
        _puan.SetActive(true);
        PuanGuncelle();
    }
    public void OyunBittiginde()
    {
        _oyunBitti.SetActive(true);
        _baslabuton.gameObject.SetActive(true);
    }
    void PuanGuncelle()
    {
        _puanText = _puan.GetComponent<TextMeshProUGUI>();
        _puanText.text = "SCORE:" + puannum;
    }

    public void AsteroidYokOldugunda(GameObject astereoid)
    {
        var astereoidTur = astereoid.name[8];
        switch (astereoidTur)
        {
            case '1':
                puannum += 5;
                PuanGuncelle();
                break;
            case '2':
                puannum += 10;
                PuanGuncelle();
                break;
            case '3':
                puannum += 15;
                PuanGuncelle();
                break;
        }
    }

}
