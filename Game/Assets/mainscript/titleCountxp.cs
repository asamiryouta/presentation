using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleCountxp : MonoBehaviour
{
    Vector3 moveX;
    float speed;
    bool moveFlag;
    // Start is called before the first frame update
    void Start()
    {
        moveX = transform.position;
        speed = 0.1f;
        moveFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveFlag) 
        {
            moveX.x += speed;
        }
        transform.position = moveX;
    }
}
