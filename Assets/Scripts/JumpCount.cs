using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCount : MonoBehaviour
{
    /// <summary>
    /// ジャンプ回数の変数、0で初期化
    /// </summary>
    private int jumpCount = 0;

    public int GetJumpCount
    {
        get { return jumpCount;}
    }

    /// <summary>
    /// ジャンプカウントを加算する
    /// </summary>
    public void AddJumpCount ()
    {
        jumpCount++;
    }

    ////文字列jumpCountのゲッター
    //public string GetJumpCountText
    //{
    //    get
    //    {
    //        return jumpCount.ToString ();
    //    }
    //}



    ////===== ボールがぶつかったときに加算される処理 =====
    //void OnCollisionEnter ( Collision collision )
    //{
    //    jumpCount++;
    //}
}
