using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    /// <summary>
    /// 最大HitPoint。健康状態を表す
    /// </summary>
    public float MaxHealth = 100f;

    /// <summary>
    /// 現在のHitPoint。
    /// </summary>
    private float currentHealth;

    /// <summary>
    /// currentHealthをゲットするためのアクセサ（ゲッター）
    /// </summary>
    public float GetCurrentHealth
    {
        get { return currentHealth; }
    }



    /// <summary>
    /// 死亡判定
    /// </summary>
    public bool IsDead = false;//死亡フラグは"折れている"状態


    /// <summary>
    /// 最初に一回だけ処理されるメソッド
    /// </summary>
    void Start()
    {
        //現在のHitPointに最大HitPointを代入
        currentHealth = MaxHealth;
    }

    /// <summary>
    /// 現在のHitPointからdamage分の値を引く
    /// </summary>
    /// <param name="damage">HitPointから引かれる値</param>
    public void TakeDamage(float damage)
    {
        //HitPointが0なのでこのifより下は処理を行わないようにする
        if (currentHealth == 0)
        {
            return;
        }
        //現在のHPが0より上なら
        if (currentHealth > 0)
        {
            currentHealth -= damage;
            Debug.Log($"現在のHealthは{currentHealth}");
        }
        //HitPointが0を下回ったなら
        if (currentHealth <= 0)
        {
            //currentHealthを0にする。
            currentHealth = 0;

            Debug.LogError("ゲームオーバー");
            //死亡フラグを"立てる"
            IsDead = true;
        }
    }
}
