using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelector : MonoBehaviour {

    public string level;

   public void OpenScene() {
        SceneManager.LoadScene("Level " + level);
   }

     void Update()
     {
          if (Input.GetButtonDown("Start"))
          {
               SceneManager.LoadScene("Level 1.1");
          }

          if (Input.GetButtonDown("Cancel"))
          {
               SceneManager.LoadScene("Menu");
          }
     }
}
