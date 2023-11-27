using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI를 쓸 때는 반드시 필요

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    public void DecreaseHp() //arrow controller에서 충돌 체크를 하므로 arrow controller에서 사용할 수 있도록 함수를 정의함.
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
