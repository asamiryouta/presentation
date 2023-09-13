using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jinarasi : MonoBehaviour
{
    public float speed = 0.5f; //エネミーのスピード
    int counter = 50; //if文実行用


    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position = transform.position; //enemyの場所
        jinarasidecision decision;//decisionのクラスをdecisionに代入
        GameObject obj = GameObject.Find("decision4"); //objの中にdecisionを代入
        decision = obj.GetComponent<jinarasidecision>();
        jinarasidecision decision2;//decisionのクラスの中身をdecision2に代入
        GameObject obb = GameObject.Find("decision6");//obbの中にdecisionを代入
        decision2 =obb.GetComponent<jinarasidecision>();


        if (decision.isHit //decisionの中身がtrueの時か
            || 
            decision2.isHit)//decisionの中身がtrueの時に実行される
        {
            position.x -= speed;　//x方向にspeedで移動していく
        }

        transform.position = position;//transformの中に座標を代入
    }
}
