using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCount : MonoBehaviour
{
    /// <summary>
    /// �W�����v�񐔂̕ϐ��A0�ŏ�����
    /// </summary>
    private int jumpCount = 0;

    public int GetJumpCount
    {
        get { return jumpCount;}
    }

    /// <summary>
    /// �W�����v�J�E���g�����Z����
    /// </summary>
    public void AddJumpCount ()
    {
        jumpCount++;
    }

    ////������jumpCount�̃Q�b�^�[
    //public string GetJumpCountText
    //{
    //    get
    //    {
    //        return jumpCount.ToString ();
    //    }
    //}



    ////===== �{�[�����Ԃ������Ƃ��ɉ��Z����鏈�� =====
    //void OnCollisionEnter ( Collision collision )
    //{
    //    jumpCount++;
    //}
}
