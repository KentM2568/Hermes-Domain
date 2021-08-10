using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestoryOnLoad : MonoBehaviour
{
    //Scene scene = SceneManager.GetSceneByName("Main Menu");


    void Start()
    {
         DontDestroyOnLoad(gameObject);

    }
}
