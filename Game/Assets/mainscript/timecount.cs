using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class timecount : MonoBehaviour
{
    //カウントアップ
    public float countdown = 300.0f;

    //時間を表示するText型の変数
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //時間をカウントする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = countdown.ToString("f1") + "秒";

            //countdownが0以下になったとき
            if(countdown <= 0)
        {
            timeText.text = "時間になりました！";
        }

        
    }
}
