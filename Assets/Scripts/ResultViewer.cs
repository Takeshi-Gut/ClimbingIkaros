using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultViewer : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;

    public Score Score;

    public Button RetryButton;

    public Button GotoTitleButton;

    /// <summary>
    /// クリアエフェクトのゲームオブジェクト
    /// </summary>
    public GameObject ClearEffect;

    /// <summary>
    /// ClimbingIkarosStageDataManagerをUnityEditorから参照する
    /// </summary>
    public ClimbingIkarosStageDataManager ClimbingIkarosStageDataManager;


    /// <summary>
    /// GameObjectがアクティブになったときに実行される
    /// </summary>
    private void OnEnable()
    {
        HighScoreText.text = $"貴方のスコアは{Score.GetScoreText}";

        RetryButton.gameObject.SetActive(true);

        GotoTitleButton.gameObject.SetActive(true);

        //もしスコア（高さがClimbingStageDataの設定する高さより高ければ）
        if (Score.GetScore > ClimbingIkarosStageDataManager.GetClearHeight)
        {
            //クリアエフェクトを再生する
            ClearEffect.gameObject.SetActive(true);
        }

    }

    /// <summary>
    /// シーンを再読み込みする
    /// </summary>
    public void Reload()
    {
        SceneManager.LoadScene(GameSceneUtility.GameSceneName);
    }

    /// <summary>
    /// タイトルシーンに遷移する
    /// </summary>
    public void GotoTitleScene()
    {
        SceneManager.LoadScene(GameSceneUtility.TitleSceneName);
    }
}
