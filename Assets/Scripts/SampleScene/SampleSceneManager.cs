using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleSceneManager : MonoBehaviour
{
   
     /// <summary>
    /// �V�[����ǂݍ��݂���
    /// </summary>
    public void GotoOutGameScene()
    {
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
    }

}
