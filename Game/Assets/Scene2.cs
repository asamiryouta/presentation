using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour
{
   public void OnClickSecondStage()
    {
        SceneManager.LoadScene("SecondStage");
    }
}
