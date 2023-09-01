using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class charController : MonoBehaviour
{
    public float speed = 2f;//プレイヤーの移動速度
    Rigidbody2D rigid2D; //重力
    float jumpForce = 600.0f;//ジャンプ力
    int cooldown = 30;//ジャンプしたときにおこるクールダウンタイム


    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    //キーを押すと、プレイヤーが移動する
    void Update()
    {
        Vector2 position = transform.position;


        //ジャンプする
        //クールダウンタイム追加
        if (cooldown > 30)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.rigid2D.AddForce(transform.up * this.jumpForce);
                cooldown = 0;
            }
        }
        
        cooldown++;




        //左右移動

        if (Input.GetKey(KeyCode.D))//dキーを入力した場合
        {
            position.x += speed ;
        }

        if (Input.GetKey(KeyCode.A))//aキーを入力した場合
        {
            position.x -= speed;//左方向に進む
        }

        //スピード制限

        transform.position = position;

        if(Input.GetKey(KeyCode.Escape)) 
        {
            SceneManager.LoadScene("TitleScene");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //敵との当たり判定を取得
        //敵に当たったらゲームオーバーのSceneに移る
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("GameOverScene");
        }

        //Flag(旗)との当たり判定
        //Flag(旗)に当たったらゲームクリアのSceneに移る
        if (collision.gameObject.CompareTag("Flag"))
        {
            SceneManager.LoadScene("GameClearScene");
        }
    }

}
