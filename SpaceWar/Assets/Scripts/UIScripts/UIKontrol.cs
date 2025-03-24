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
        _oyunAdi.SetActive(false);
        _baslabuton.gameObject.SetActive(false);
        _puan.SetActive(true);
        PuanGuncelle();
    }
    void PuanGuncelle()
    {
        _puanText = _puan.GetComponent<TextMeshProUGUI>();
        _puanText.text = "SCORE:" + puannum;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
