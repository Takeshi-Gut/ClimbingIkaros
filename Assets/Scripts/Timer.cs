using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    private float gameTime = 0f;

    public float GetGameTime
    {
        get
        {
            return gameTime;
        }
    }


    public string GetGameTimeText
    {
        get
        {
            return gameTime.ToString ( "F2" );
        }
    }



    /// <summary>
    /// 制限時間
    /// </summary>
    private float limitTime = 30f;




    //リミットタイムのgetter
    public float GetLimitTime
    {
        get
        {
            return limitTime;
        }
    }

    public string GetLimitTimeText
    {
        get
        {
            return limitTime.ToString ( "F2" );
        }
    }



    //private int frameCounter = 0;

    //public float GetFrameCounter
    //{
    //    get
    //    {
    //        return frameCounter;
    //    }
    //}



    // Update is called once per frame
    void Update ()
    {
        if ( limitTime == 0 )
        {
            Debug.LogError ( "ゲームオーバー" );
            return;
        }

        //もしgameTimeが0を下回れば、
        //このif文より下の処理を行わない
        if ( limitTime <= 0 )
        {
            limitTime = 0f;
            return;
        }

        limitTime -= Time.deltaTime;

        //gameTime += Time.deltaTime;
        //frameCounter++;





        ////もしframeCounterが30フレームになったら
        //if ( frameCounter >= 30 )
        //{
        //    //Debug.logに"30フレーム経過しました"と表示する
        //    Debug.Log("30フレーム経過しました");
        //}

        ////もしframeCounterが30で割り切れたなら
        //if(frameCounter % 30 == 0)
        //{
        //    //Debug.logに"1秒経過"と表示する
        //    Debug.Log("1秒経過");
        //}






        //Debug.Log($"{limitTime}");

        //limitTimeが0以下になったら
        //if ( limitTime < 0 )
        //{
        //    //タイムアップと表示する
        //    Debug.Log ( "タイムアップ" );

        //    //黄色いログ←注意してくださいログ
        //    Debug.LogWarning ( "タイムアップ" );

        //    //赤いログ←エラーが起きましたログ
        //    Debug.LogError ( "タイムアップ" );
        //}
        //else //そうじゃなかったら
        //{
        //    //limitTimeをログにだす
        //    Debug.Log ( $"{limitTime}" );
        //}

        //処理の内容をコメントで書いちゃう。



        //gameTime += Time.deltaTime;
        //if ( gameTime > 10f && gameTime < 30f)
        //{
        //    Debug.Log ($"{GetGameTimeText}" );
        //}
    }
}

