using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForStatementCheck : MonoBehaviour
{

    int breakCount = 67;

    // Start is called before the first frame update
    void Start ()
    {
        //型推論
        //var

        //count0から10になるまで繰り返す
        //for ( var count = 0 ; count < 10 ; count++ )
        //{
        //    Debug.Log ( count );// 0,1,2,3,4,5,6,7,8,9,
        //}

        //for ( var count = 0 ; count <= 10 ; count++ )
        //{
        //    Debug.Log ( count );
        //}

        //for ( var count = 10 ; count >= 0; count-- )
        //{
        //    Debug.Log ( count );
        //}


        //fizzbuzzCountを定義する
        int fizzbuzzCount = 100;

        //for文でfizzbuzzountになるまでループさせる
        //ループ中でもし、fizzbuzzCountが3で割れれば、その数にfizzを文字列を連結してDebug.Logに出す。

        for ( var count = 0 ; count < fizzbuzzCount ; count++ )
        {
            //countがbreakCountと同じ値だった時に、このループを抜けてください。
            if (count == breakCount)
            {
                break;
            }


            //ループ中でもし、fizzbuzzCountが3と5で割れれば、その数にfizzbuzzを文字列を連結してDebug.Logに出す。
            if ( ( count % 3 == 0 ) && ( count % 5 == 0 ) )
            {
                Debug.Log ( $"{count}:fizzbuzz" );
                continue;//処理を途中で止めて、次のループにいってもらう。
                //break;  ループ自体をを終わらせる
            }



            if ( count % 3 == 0 )
            {
                Debug.Log ( $"{count}:fizz" );
            }
            //ループ中でもし、fizzbuzzCountが5で割れれば、その数にfizzを文字列を連結してDebug.Logに出す。
            if ( count % 5 == 0 )
            {
                Debug.Log ( $"{count}:buzz" );
            }
        }
    }
}

