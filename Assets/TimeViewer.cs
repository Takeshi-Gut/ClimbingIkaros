using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeViewer : MonoBehaviour
{
    /// <summary>
    /// 時間計測用クラス
    /// </summary>
    public Timer Timer;

    /// <summary>
    /// 時間表示用の文字を表示する場所
    /// </summary>
    public TextMeshProUGUI TimerText;


    // Update is called once per frame
    void Update ()
    {
        //TimerText.text = Timer.GetGameTimeText;

        //リミットタイムをタイマーテキストに代入せよ
        TimerText.text = Timer.GetLimitTimeText;
    }
}
