using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleSceneManager : MonoBehaviour
{

    /// <summary>
    /// シーンを読み込みする
    /// </summary>
    public void GotoInGameScene()
    {
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
    }
}
