using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jinarasi : MonoBehaviour
{
    public float speed = 0.5f; //�G�l�~�[�̃X�s�[�h
    int counter = 50; //if�����s�p


    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position = transform.position; //enemy�̏ꏊ
        jinarasidecision decision;//decision�̃N���X��decision�ɑ��
        GameObject obj = GameObject.Find("decision4"); //obj�̒���decision����
        decision = obj.GetComponent<jinarasidecision>();
        jinarasidecision decision2;//decision�̃N���X�̒��g��decision2�ɑ��
        GameObject obb = GameObject.Find("decision6");//obb�̒���decision����
        decision2 =obb.GetComponent<jinarasidecision>();


        if (decision.isHit //decision�̒��g��true�̎���
            || 
            decision2.isHit)//decision�̒��g��true�̎��Ɏ��s�����
        {
            position.x -= speed;�@//x������speed�ňړ����Ă���
        }

        transform.position = position;//transform�̒��ɍ��W����
    }
}
