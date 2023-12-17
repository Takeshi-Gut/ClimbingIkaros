using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleSceneManager : MonoBehaviour
{
   
     /// <summary>
    /// ƒV[ƒ“‚ğ“Ç‚İ‚İ‚·‚é
    /// </summary>
    public void GotoOutGameScene()
    {
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
    }

}
