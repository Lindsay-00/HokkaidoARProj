using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public void PlayGame(){
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("SampleScene");
    }
}
