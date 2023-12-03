using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultViewer : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;

    public Score Score;

    public Canvas MovingCanvas;

    /// <summary>
    /// GameObjectがアクティブになったときに実行される
    /// </summary>
    private void OnEnable ()
    {
        HighScoreText.text = $"貴方のスコアは{Score.GetScoreText}";

        MovingCanvas.gameObject.SetActive ( true );
    }

    /// <summary>
    /// シーンを再読み込みする
    /// </summary>
    public void Reload()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
