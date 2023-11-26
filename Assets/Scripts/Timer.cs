using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    private float gameTime = 0f;

    public float GetGameTime
    {
        get
        {
            return gameTime;
        }
    }


    public string GetGameTimeText
    {
        get
        {
            return gameTime.ToString ( "F2" );
        }
    }



    /// <summary>
    /// ��������
    /// </summary>
    private float limitTime = 30f;




    //���~�b�g�^�C����getter
    public float GetLimitTime
    {
        get
        {
            return limitTime;
        }
    }

    public string GetLimitTimeText
    {
        get
        {
            return limitTime.ToString ( "F2" );
        }
    }



    //private int frameCounter = 0;

    //public float GetFrameCounter
    //{
    //    get
    //    {
    //        return frameCounter;
    //    }
    //}



    // Update is called once per frame
    void Update ()
    {
        if ( limitTime == 0 )
        {
            Debug.LogError ( "�Q�[���I�[�o�[" );
            return;
        }

        //����gameTime��0�������΁A
        //����if����艺�̏������s��Ȃ�
        if ( limitTime <= 0 )
        {
            limitTime = 0f;
            return;
        }

        limitTime -= Time.deltaTime;

        //gameTime += Time.deltaTime;
        //frameCounter++;





        ////����frameCounter��30�t���[���ɂȂ�����
        //if ( frameCounter >= 30 )
        //{
        //    //Debug.log��"30�t���[���o�߂��܂���"�ƕ\������
        //    Debug.Log("30�t���[���o�߂��܂���");
        //}

        ////����frameCounter��30�Ŋ���؂ꂽ�Ȃ�
        //if(frameCounter % 30 == 0)
        //{
        //    //Debug.log��"1�b�o��"�ƕ\������
        //    Debug.Log("1�b�o��");
        //}






        //Debug.Log($"{limitTime}");

        //limitTime��0�ȉ��ɂȂ�����
        //if ( limitTime < 0 )
        //{
        //    //�^�C���A�b�v�ƕ\������
        //    Debug.Log ( "�^�C���A�b�v" );

        //    //���F�����O�����ӂ��Ă����������O
        //    Debug.LogWarning ( "�^�C���A�b�v" );

        //    //�Ԃ����O���G���[���N���܂������O
        //    Debug.LogError ( "�^�C���A�b�v" );
        //}
        //else //��������Ȃ�������
        //{
        //    //limitTime�����O�ɂ���
        //    Debug.Log ( $"{limitTime}" );
        //}

        //�����̓��e���R�����g�ŏ������Ⴄ�B



        //gameTime += Time.deltaTime;
        //if ( gameTime > 10f && gameTime < 30f)
        //{
        //    Debug.Log ($"{GetGameTimeText}" );
        //}
    }
}

