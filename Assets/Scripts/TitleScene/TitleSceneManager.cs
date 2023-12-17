using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleSceneManager : MonoBehaviour
{

    /// <summary>
    /// ƒV[ƒ“‚ğ“Ç‚İ‚İ‚·‚é
    /// </summary>
    public void GotoInGameScene()
    {
        SceneManager.LoadScene(GameSceneUtility.TitleSceneName);
    }
}
