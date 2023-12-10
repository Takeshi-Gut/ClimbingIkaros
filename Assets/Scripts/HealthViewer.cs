using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthViewer : MonoBehaviour
{
    /// <summary>
    /// 体力管理クラス。Healthクラスを取得
    /// </summary>
    public Health Health;

    /// <summary>
    /// 体力反映用のスライダー。スライダーのUIを使用します
    /// </summary>
    public Slider HealthSlider;


    // Update is called once per frame
    private void LateUpdate ()
    {
        //SliderのPositionにカメラの座標変換を使って
        //プレイヤーのポジション+Y軸方向に1の値を代入し続ける
        this.HealthSlider.GetComponent<RectTransform> ().position =
            Camera.main.WorldToScreenPoint ( this.Health.gameObject.transform.position + Vector3.up );

        //もし死んでいたらSliderに値を代入しないようにする
        if ( Health.IsDead )
        {
            return;
        }
        //現在体力/最大体力　をすることによって、80/100だった場合0.8の値をSliderに与えることができる
        HealthSlider.value = Health.GetCurrentHealth / Health.MaxHealth;
    }
}
