using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForStatementCheck : MonoBehaviour
{

    int breakCount = 67;

    // Start is called before the first frame update
    void Start ()
    {
        //�^���_
        //var

        //count0����10�ɂȂ�܂ŌJ��Ԃ�
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


        //fizzbuzzCount���`����
        int fizzbuzzCount = 100;

        //for����fizzbuzzount�ɂȂ�܂Ń��[�v������
        //���[�v���ł����AfizzbuzzCount��3�Ŋ����΁A���̐���fizz�𕶎����A������Debug.Log�ɏo���B

        for ( var count = 0 ; count < fizzbuzzCount ; count++ )
        {
            //count��breakCount�Ɠ����l���������ɁA���̃��[�v�𔲂��Ă��������B
            if (count == breakCount)
            {
                break;
            }


            //���[�v���ł����AfizzbuzzCount��3��5�Ŋ����΁A���̐���fizzbuzz�𕶎����A������Debug.Log�ɏo���B
            if ( ( count % 3 == 0 ) && ( count % 5 == 0 ) )
            {
                Debug.Log ( $"{count}:fizzbuzz" );
                continue;//������r���Ŏ~�߂āA���̃��[�v�ɂ����Ă��炤�B
                //break;  ���[�v���̂����I��点��
            }



            if ( count % 3 == 0 )
            {
                Debug.Log ( $"{count}:fizz" );
            }
            //���[�v���ł����AfizzbuzzCount��5�Ŋ����΁A���̐���fizz�𕶎����A������Debug.Log�ɏo���B
            if ( count % 5 == 0 )
            {
                Debug.Log ( $"{count}:buzz" );
            }
        }
    }
}

