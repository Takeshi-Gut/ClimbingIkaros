using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    /// <summary>
    /// BGMやSEを鳴らすスピーカーのコンポーネントの配列
    /// 合計4つだが、1つ目はBGM、2～4個目はSEで音がかぶっても大丈夫なようにする
    /// </summary>
    private AudioSource [] audioSources = new AudioSource [4];

    public AudioClip BGMClip;

    public AudioClip SEClip;


    private void Awake()
    {
        //もしaudioSourcesがこのコンポーネントがついたGameObjectに追加されていない場合は、
        //AddComponentして補充する
        if (audioSources [0] == null)
        {
            //4回繰り返す
            for (int i = 0 ; i < audioSources.Count() ; i++)
            {
                //audioSourcesに追加されるAudioSourceを代入する
                audioSources [i] = this.gameObject.AddComponent<AudioSource>();
            }
        }
    }


    /// <summary>
    /// BGMを再生する
    /// </summary>
    public void PlayBGM()
    {
        audioSources [0].clip = BGMClip;
        audioSources [0].Play();
    }

    /// <summary>
    /// SEを再生する
    /// </summary>
    public void PlaySE()
    {
        //配列の0番目はBGMが使っているので、１番目からfor文を回す
        for (int i = 1 ; i < audioSources.Length ; i++)
        {
            //audioSourcesがプレイ中じゃなかったら
            if (!audioSources [i].isPlaying)
            {
                //SEクリップを４代入
                audioSources [i].clip = SEClip;
                //再生する
                audioSources [i].Play();

                //for文を抜ける
                break;
            }
        }
    }
}
