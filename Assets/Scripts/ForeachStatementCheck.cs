using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachStatementCheck : MonoBehaviour
{

    //int [] intArray = new int [20];

    int [] intArray = new int [101];
    bool check = false;


    // Start is called before the first frame update
    void Start ()
    {

        List<int> intList = new List<int> ();


        //0から20までの値でintArrayの各要素の値を代入する
        for ( var count = 0 ; count < intArray.Length ; count++ )
        {
            //intArrayのcount番目の値をcountとする
            //例えばintArrayの２番目の要素を2とする
            intArray [count] = count;
            intList.Add ( count );
        }
        //intArray[0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19]
        //intList[0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19]


        ////intArrayの中を捜査する
        ////foreach（要素の取得 in 配列かリスト）
        //foreach ( var intValue in intArray )
        //{
        //    // intArrayの中に21は含まれないので、下記ログは出ない
        //    if ( intValue == 21 )
        //    {
        //        Debug.Log ( "この配列に21は含まれている" );
        //    }
        //}

        ////Listは要素数を増やすことができます
        //intList.Add ( 21 );

        ////Listは要素数を減らすこともできます
        //intList.Remove ( 0 );

        //foreach ( var intValue in intList )
        //{
        //    // intArrayの中に21は含まれているので、下記ログは出ない
        //    if ( intValue == 21 )
        //    {
        //        Debug.Log ( "この配列に21は含まれている" );
        //    }


        for ( int number = 2 ; number <= 100 ; number++ )
        {
            for ( int i = 2 ; i < number ; i++ )
            {
                if ( number % i == 0 )
                {
                    check = true;
                    break;
                }
            }

            //もしintList内に素数があったら
            if ( !check )

            //Debug.Logに表示せよ
            {
                Debug.Log ( $"{number}," );
                continue;
            }
            check = false;
        }

        //intList内を捜査します。
        foreach ( var intValue in intList )
        {
            //もしintValueが5だったら
            if ( ( !check && intValue == 5 ) )
            {
                Debug.Log ( "5" );
            }
            //もしintValueが90だったら
            if ( ( !check && intValue == 90 ) )
            {
                Debug.Log ( "90" );
            }
        }
    }
}
