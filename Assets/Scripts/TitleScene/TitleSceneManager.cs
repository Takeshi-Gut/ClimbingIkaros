using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleSceneManager : MonoBehaviour
{

    /// <summary>
    /// �V�[����ǂݍ��݂���
    /// </summary>
    public void GotoInGameScene()
    {
        SceneManager.LoadScene(GameSceneUtility.TitleSceneName);
    }
}
