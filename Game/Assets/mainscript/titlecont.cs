using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlecont : MonoBehaviour
{
    Vector3 Move;
    public float speed;
    bool isMoveFlag;

    // Start is called before the first frame update
    void Start()
    {
        Move = transform.position;
        speed = 0.1f;
        isMoveFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoveFlag)
        {
            Move.x -= speed;
        }

        transform.position = Move;
    }
}
