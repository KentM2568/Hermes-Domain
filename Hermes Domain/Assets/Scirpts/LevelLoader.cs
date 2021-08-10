using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int iLevelToLoad;
    /// public Transform GameObject;

    void Start()
    {

    }

    public void Check()
    {
        Debug.Log("bruhsa");
    }

   /// void Update()
 ///   {
     ///  if (GameObject.tag == "Loader")
      ///  {
     //       Debug.Log("Success!");
     ///       LoadScene();
    //    }
///   }


    public void LoadScene()
    {
        SceneManager.LoadScene(iLevelToLoad);
    }


}
