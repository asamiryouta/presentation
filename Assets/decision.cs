using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decision : MonoBehaviour
{
    public bool isdecision = false; //“–‚½‚Á‚½‚É•Ï‚í‚é—p‚Ì•Ï”

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("Player"))
        {
            isdecision = true;
            Debug.Log("playerHit");
        }

    }
}

