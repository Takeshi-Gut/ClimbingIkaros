using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleSceneManager : MonoBehaviour
{
    /// <summary>
    /// soundManagerが使われるタイミングでシーン上から探索する
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    /// <summary>
    /// BGMがフェードインする時間
    /// </summary>
    public float FadeDuration = 2f;



    private void Start()
    {
        StartCoroutine(FadeInBGM());
    }


    /// <summary>
    /// インゲームのシーンを読み込みする（移行する）
    /// </summary>
    public void GotoInGameScene()
    {
        StartCoroutine(SceneTransition());

        //BGMの音量を0にする
        soundManager.GetBGMAudioSouce.volume = 0;
    }

    /// <summary>
    /// SEが鳴り終わるのを、待った後にシーンを遷移させる
    /// </summary>
    /// <returns></returns>
    public IEnumerator SceneTransition()
    {
        //SEを鳴らす→ここにあるのはすごく嫌なので後で変える
        soundManager.PlaySE();
        //yield return new WaitForSeconds(1f);
        //SEが鳴っている間待つ
        yield return new WaitWhile(() => soundManager.IsSEAudioSourcesPlaying());
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);


    }


    /// <summary>
    /// 遅れてBGMを鳴らす
    /// </summary>
    /// <returns></returns>
    public IEnumerator FadeInBGM()
    {

        //yield return new WaitForSeconds(1f);

        //もしsoundManagerがnullじゃなければ
        if (soundManager != null)
        {
            //BGMを再生する
            soundManager.PlayBGM();

            //BGMの音量を0にする
            soundManager.GetBGMAudioSouce.volume = 0;

            //経過時間を0
            var elapsedTime = 0f;

            //経過時間がFadeDurationの値を超えるまで
            while (elapsedTime < FadeDuration)
            {
                //フェードインのボリュームを計算
                //0から1の間で線形補間をおこなった結果をボリュームの値に代入する
                soundManager.GetBGMAudioSouce.volume = Mathf.Lerp(0f,1,elapsedTime / FadeDuration);

                //経過時間を更新する
                elapsedTime += Time.deltaTime;

                //１フレーム待機する
                yield return null;
            }

            //フェードイン完了後に最終的なボリュームを1にする
            soundManager.GetBGMAudioSouce.volume = 1f;
        }
    }
}
