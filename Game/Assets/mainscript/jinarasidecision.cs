using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jinarasidecision : MonoBehaviour
{
    public bool isHit = false;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isHit = true;
            GetComponent<AudioSource>().Play();
            Debug.Log("playerHit");
        }
    }
}
