using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStateManager : MonoBehaviour
{
    public Canvas ResultCanvas;

    public Timer Timer;

    public Health PlayerHealth;

    bool gameEnd = false;

    //外部からgameEndを取得するゲッター
    public bool GetGameEnd
    {
        get { return gameEnd; }
    }


    /// <summary>
    /// soundManagerが使われるタイミングでシーン上から探索する
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    private void Start()
    {
        soundManager.PlayBGM();
        {
            //カウントダウンのスタートコルーチン。スタートしたらカウントダウンを始める。
            StartCoroutine(CountDownCoroutine());
        }
    }

    public IEnumerator CountDownCoroutine()
    {
        //3秒からカウントダウンし、0より大きかったら１を引き続けよ
        for (int i = 3 ; i >= 1 ; i--)
        {
            //1秒待つ
            yield return new WaitForSeconds(1);

            //DebugLogにカウントダウン表示。3.2.1.STARTを表示する。
            Debug.Log(i.ToString());

            //もし-1秒になったら、STARTとDebug.Logに表示せよ
            if (i == 1)
            {
                //1秒待つ
                yield return new WaitForSeconds(1);
                Debug.Log("START");
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (gameEnd)
        {
            return;
        }
        if (PlayerHealth.IsDead)
        {
            //ResultCanvasのアクティブをオンにする
            ResultCanvas.gameObject.SetActive(true);
            gameEnd = true;
        }



        //Timerの制限時間が0を下回った時
        if (Timer.GetLimitTime < 0f)
        {
            //ResultCanvasのアクティブをオンにする
            ResultCanvas.gameObject.SetActive(true);
            gameEnd = true;
        }
    }
}
