using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class timecount : MonoBehaviour
{
    //�J�E���g�A�b�v
    public float countdown = 300.0f;

    //���Ԃ�\������Text�^�̕ϐ�
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g����
        countdown -= Time.deltaTime;

        //���Ԃ�\������
        timeText.text = countdown.ToString("f1") + "�b";

            //countdown��0�ȉ��ɂȂ����Ƃ�
            if(countdown <= 0)
        {
            timeText.text = "���ԂɂȂ�܂����I";
        }

        
    }
}
