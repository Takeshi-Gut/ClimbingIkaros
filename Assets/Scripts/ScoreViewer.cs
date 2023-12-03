using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreViewer : MonoBehaviour
{

    public Score Score;
    public TextMeshProUGUI ScoreText;



    // Update is called once per frame
    void Update ()
    {
        //ScoreのテキストをScoreTextに入れろ
        ScoreText.text = Score.GetScore.ToString ("F2");
    }
}
