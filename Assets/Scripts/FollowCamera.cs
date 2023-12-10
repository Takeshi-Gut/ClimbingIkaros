using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject Player;


    private float cameraDiff = 0f;

    /// <summary>
    /// カメラが追えるステージの最大の高さ
    /// </summary>
    public float StageMaxY = 0f;


    // Update is called once per frame
    private void Update ()
    {
        //もしプレイヤーの高さが0以下なら処理をしない。下へは追従しない
        if ( Player.transform.position.y < 0 )
        {
            return;
        }

        //自分の高さがカメラが追えるステージの最大の高さを超えたら処理をしない
        if ( this.transform.position.y > StageMaxY )
        {
            return;
        }


        this.transform.position
            = new Vector3 ( 0,Player.transform.position.y + cameraDiff,-10 );
    }
}
