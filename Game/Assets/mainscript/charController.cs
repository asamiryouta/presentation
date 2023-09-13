using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class charController : MonoBehaviour
{
    public float speed = 2f;//�v���C���[�̈ړ����x
    Rigidbody2D rigid2D; //�d��
    float jumpForce = 600.0f;//�W�����v��
    int cooldown = 65;//�W�����v�����Ƃ��ɂ�����N�[���_�E���^�C��
    public float volume;


    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        AudioListener.volume= volume;
    }

    //�L�[�������ƁA�v���C���[���ړ�����
    void Update()
    {
        Vector2 position = transform.position;


        //�W�����v����
        //�N�[���_�E���^�C���ǉ�
        if (cooldown > 60)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.rigid2D.AddForce(transform.up * this.jumpForce);
                GetComponent<AudioSource>().Play();
                cooldown = 0;
            }
        }
        
        cooldown++;




        //���E�ړ�

        if (Input.GetKey(KeyCode.D))//d�L�[����͂����ꍇ
        {
            position.x += speed ;
        }

        if (Input.GetKey(KeyCode.A))//a�L�[����͂����ꍇ
        {
            position.x -= speed;//�������ɐi��
        }

        //�X�s�[�h����

        transform.position = position;

        if(Input.GetKey(KeyCode.Escape)) 
        {
            SceneManager.LoadScene("TitleScene");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�G�Ƃ̓����蔻����擾
        //�G�ɓ���������Q�[���I�[�o�[��Scene�Ɉڂ�
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene("GameOverScene");
        }

        //Flag(��)�Ƃ̓����蔻��
        //Flag(��)�ɓ���������Q�[���N���A��Scene�Ɉڂ�
        if (collision.gameObject.CompareTag("Flag"))
        {
            SceneManager.LoadScene("GameClearScene");
        }
    }

}
