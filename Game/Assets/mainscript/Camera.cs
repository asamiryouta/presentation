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
        //ã‰º’Ç”ö
        transform.position = new Vector3(PlayerTransform.position.x,        //player‚Ìx•ûŒü‚ÌÀ•W
                                         PlayerTransform.position.y + 1.25f,//player‚Ìy•ûŒü‚ÌÀ•W
                                         transform.position.z);             //player‚Ìz•ûŒü‚ÌÀ•W
    }
}
