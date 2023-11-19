using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBase : MonoBehaviour
{
    //�X�e�[�W�̃^�C�v��enum�ŊǗ�����
    public enum StageTypes
    {
        Invalide = -1, //����`
        Normal,//�ʏ�
        Fall, //������
    }

    /// <summary>
    /// �X�e�[�W�^�C�v��ʏ�ŏ�����
    /// </summary>
    public StageTypes StageType = StageTypes.Normal;

    private void OnCollisionEnter2D ( Collision2D collision )
    {
        switch ( StageType )
        {
            case StageTypes.Invalide:
                break;
            case StageTypes.Normal:
                break;
            case StageTypes.Fall:
                //Player�����������痎�Ƃ�����
                if ( collision.gameObject.tag == GameSettingUtility.PlayerTagName )
                {
                    //�����A���̃Q�[���I�u�W�F�N�g�̒��Ƀ��W�b�h�{�f�B2D������������
                    if ( this.gameObject.GetComponent<Rigidbody2D> () == null )
                    {
                        //���W�b�h�{�f�B2D��ǉ�����
                        this.gameObject.AddComponent<Rigidbody2D> ();
                    }
                }

                //�����A���̃X�e�[�W�ɓ���������Q�[���I�u�W�F�N�g�̃A�N�e�B�u��؂�
                if ( collision.gameObject.layer == GameSettingUtility.GroundLayerNumber )
                {
                    this.gameObject.SetActive ( false );
                }



                Debug.Log ( "���Ƃ�" );
                break;
        }
    }




    // Update is called once per frame
    void Update ()
    {

    }
}
