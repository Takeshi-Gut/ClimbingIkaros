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
        //Score�̃e�L�X�g��ScoreText�ɓ����
        ScoreText.text = Score.GetScore.ToString ("F2");
    }
}
