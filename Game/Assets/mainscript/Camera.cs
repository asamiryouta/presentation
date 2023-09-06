using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Camera : MonoBehaviour
{
    GameObject playerObj;
    charController player;
    Transform PlayerTransform;
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        player = playerObj.GetComponent<charController>();
        PlayerTransform = playerObj.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //�㉺�ǔ�
        transform.position = new Vector3(PlayerTransform.position.x,        //player��x�����̍��W
                                         PlayerTransform.position.y + 1.25f,//player��y�����̍��W
                                         transform.position.z);             //player��z�����̍��W
    }
}
