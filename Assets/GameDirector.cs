using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI�� �� ���� �ݵ�� �ʿ�

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    public void DecreaseHp() //arrow controller���� �浹 üũ�� �ϹǷ� arrow controller���� ����� �� �ֵ��� �Լ��� ������.
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
