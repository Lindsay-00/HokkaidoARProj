using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchOdori : MonoBehaviour
{
    public string sceneName;

    public void changeScene(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
