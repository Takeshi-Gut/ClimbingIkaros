using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBase : MonoBehaviour
{
    //ステージのタイプをenumで管理する
    public enum StageTypes
    {
        Invalide = -1, //未定義
        Normal,//通常
        Fall, //落ちる
        Acceleration,//制限時間が早くなる
        Damage,//ダメージを与える
        Move,//動く床
    }

    /// <summary>
    /// ステージタイプを通常で初期化
    /// </summary>
    public StageTypes StageType = StageTypes.Normal;





    /// <summary>
    /// 侵入判定
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D ( Collider2D collision )
    {
        //当たってきたのがプレイヤーだったら
        if ( collision.gameObject.tag == GameSettingUtility.PlayerTagName )
        {
            if ( collision.transform.position.y > this.transform.position.y )
            {
                //自分のBoxCollider2DのIsTriggerをオフにする
                this.GetComponent<BoxCollider2D> ().isTrigger = false;
            }
        }
    }




    private void OnCollisionEnter2D ( Collision2D collision )
    {
        switch ( StageType )
        {
            case StageTypes.Invalide:
                break;

            case StageTypes.Normal:
                //Playerが当たったら落とす実装
                if ( collision.gameObject.tag == GameSettingUtility.PlayerTagName )
                {
                    Time.timeScale = 1f;
                }

                break;

            case StageTypes.Fall:
                //Playerが当たったら落とす実装
                if ( collision.gameObject.tag == GameSettingUtility.PlayerTagName )
                {
                    //もし、このゲームオブジェクトの中にリジッドボディ2Dが無かったら
                    if ( this.gameObject.GetComponent<Rigidbody2D> () == null )
                    {
                        //リジッドボディ2Dを追加せよ
                        this.gameObject.AddComponent<Rigidbody2D> ();
                    }
                }

                //もし、他のステージに当たったらゲームオブジェクトのアクティブを切る
                if ( collision.gameObject.layer == GameSettingUtility.GroundLayerNumber )
                {
                    this.gameObject.SetActive ( false );
                }
                Debug.Log ( "落とす" );
                break;

            case StageTypes.Acceleration:
                //もし当たってきた相手のtagがPlayerだったら、
                if ( collision.gameObject.tag == GameSettingUtility.PlayerTagName )
                {
                    ////時間の縮尺を変更する。
                    //Time.timeScale *= 1.2f;
                    //Debug.Log ( $"{Time.timeScale}" );

                    //もしtimeScaleが2倍を超えないかぎりtimeScaleは変更される
                    if ( Time.timeScale < 2f )
                    {
                        //timeScaleは2倍のままにする
                        Time.timeScale *= 1.2f;
                        Debug.Log ( $"{Time.timeScale}" );
                    }
                }
                break;

            case StageTypes.Damage:
                //もし当たってきた相手のtagがPlayerだったら、
                if ( collision.gameObject.tag == GameSettingUtility.PlayerTagName )
                {
                    //Healthコンポーネントをゲットしてきて
                    var health = collision.gameObject.GetComponent<Health> ();
                    if ( health != null )
                    {
                        //HealthコンポーネントのTakeDamageを発動させる。
                        health.TakeDamage ( 20f );
                    }
                }
                break;
        }
    }

    private void Update ()
    {
        //もしステージタイプがMoveだったら
        if ( StageType == StageTypes.Move )
        {
            //引数に時間を突っ込んだSinを取得する
            //Sin(x)のグラフの動きをするので1から-1の値が代入される。
            var sin = Mathf.Sin ( Time.time );
            // 一時変数のposを作成し、コードを読みやすくする
            var pos = this.transform.position;
            // 自分のpositionのxの値にsinを足し続ける
            this.transform.position = new Vector3
                ( pos.x + sin * GameSettingUtility.MoveStageHorizontalFactor,
                pos.y,
                pos.z );
        }
    }
}
