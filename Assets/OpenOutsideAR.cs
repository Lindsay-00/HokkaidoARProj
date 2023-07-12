using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenOutsideAR : MonoBehaviour
{
// Plugins
// URL
public string url;
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

