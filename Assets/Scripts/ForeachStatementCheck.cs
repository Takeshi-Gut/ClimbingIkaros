using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachStatementCheck : MonoBehaviour
{

    int [] intArray = new int [20];

    // Start is called before the first frame update
    void Start ()
    {

        List<int> intList = new List<int> ();


        //0����20�܂ł̒l��intArray�̊e�v�f�̒l��������
        for ( var count = 0 ; count < intArray.Length ; count++ )
        {
            //intArray��count�Ԗڂ̒l��count�Ƃ���
            //�Ⴆ��intArray�̂Q�Ԗڂ̗v�f��2�Ƃ���
            intArray [count] = count;
            intList.Add ( count );
        }
        //intArray[0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19]
        //intList[0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19]


        ////intArray�̒���{������
        ////foreach�i�v�f�̎擾 in �z�񂩃��X�g�j
        //foreach ( var intValue in intArray )
        //{
        //    // intArray�̒���21�͊܂܂�Ȃ��̂ŁA���L���O�͏o�Ȃ�
        //    if ( intValue == 21 )
        //    {
        //        Debug.Log ( "���̔z���21�͊܂܂�Ă���" );
        //    }
        //}

        //List�͗v�f���𑝂₷���Ƃ��ł��܂�
        intList.Add ( 21 );

        //List�͗v�f�������炷���Ƃ��ł��܂�
        intList.Remove ( 0 );

        foreach ( var intValue in intList )
        {
            // intArray�̒���21�͊܂܂�Ă���̂ŁA���L���O�͏o�Ȃ�
            if ( intValue == 21 )
            {
                Debug.Log ( "���̔z���21�͊܂܂�Ă���" );
            }
        }
    }
}
