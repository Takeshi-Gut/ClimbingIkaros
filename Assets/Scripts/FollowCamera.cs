using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject Player;


    private float cameraDiff = 0f;


    // Update is called once per frame
    void Update ()
    {
        //�����v���C���[�̍�����0�ȉ��Ȃ珈�������Ȃ��B���ւ͒Ǐ]���Ȃ�
        if ( Player.transform.position.y < 0 )
        {
            return;
        }

        this.transform.position
            = new Vector3 ( 0,Player.transform.position.y + cameraDiff,-10 );
    }
}
