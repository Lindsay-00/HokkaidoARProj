using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    // Plugins
  
 
    // URL
    private readonly string url = "https://palanar.app/v2/ar_contents/56a436f38a01c09f";
 
    // 開くボタンを押したときの処理
    public void ClickOpenButton()
    {
        OpenWindow();
    }
 
    // 外部ブラウザでURLを開く
    private void OpenWindow()
    {
        #if UNITY_EDITOR
          Application.OpenURL(url);
        #elif UNITY_WEBGL
          OpenNewTab(url);
        #else
          Application.OpenURL(url);
        #endif
    }
}
