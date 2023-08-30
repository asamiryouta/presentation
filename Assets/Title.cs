using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    public void OnClickEndScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
