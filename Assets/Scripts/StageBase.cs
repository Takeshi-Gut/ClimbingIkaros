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
        Acceleration,//�������Ԃ������Ȃ�
        Damage,//�_���[�W��^����
        Move,//������
    }

    /// <summary>
    /// �X�e�[�W�^�C�v��ʏ�ŏ�����
    /// </summary>
    public StageTypes StageType = StageTypes.Normal;





    /// <summary>
    /// �N������
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D ( Collider2D collision )
    {
        //�������Ă����̂��v���C���[��������
        if ( collision.gameObject.tag == GameSettingUtility.PlayerTagName )
        {
            if ( collision.transform.position.y > this.transform.position.y )
            {
                //������BoxCollider2D��IsTrigger���I�t�ɂ���
                this.GetComponent<BoxCollider2D> ().isTrigger = false;
            }
        }
    }




    public void OnCollisionEnter2DAction ( GameObject player )
    {
        switch ( StageType )
        {
            case StageTypes.Invalide:
                break;

            case StageTypes.Normal:
                Time.timeScale = 1f;
                break;

            case StageTypes.Fall:
                //Player�����������痎�Ƃ�����
                if ( this.gameObject.GetComponent<Rigidbody2D> () == null )
                {
                    this.gameObject.AddComponent<Rigidbody2D> ();
                }
                //this.gameObject.SetActive ( false );   
                break;

            case StageTypes.Acceleration:
                //����timeScale��2�{�𒴂��Ȃ�������timeScale�͕ύX�����
                if ( Time.timeScale < 2f )
                {
                    //timeScale��2�{�̂܂܂ɂ���
                    Time.timeScale *= 1.2f;
                    Debug.Log ( $"{Time.timeScale}" );
                }
                break;

            case StageTypes.Damage:

                //Health�R���|�[�l���g���Q�b�g���Ă���
                var health = player.GetComponent<Health> ();
                if ( health != null )
                {
                    //Health�R���|�[�l���g��TakeDamage�𔭓�������B
                    health.TakeDamage ( 20f );
                }
                break;
        }
    }

    private void Update ()
    {
        //�����X�e�[�W�^�C�v��Move��������
        if ( StageType == StageTypes.Move )
        {
            //�����Ɏ��Ԃ�˂�����Sin���擾����
            //Sin(x)�̃O���t�̓���������̂�1����-1�̒l����������B
            var sin = Mathf.Sin ( Time.time );
            // �ꎞ�ϐ���pos���쐬���A�R�[�h��ǂ݂₷������
            var pos = this.transform.position;
            // ������position��x�̒l��sin�𑫂�������
            this.transform.position = new Vector3
                ( pos.x + sin * GameSettingUtility.MoveStageHorizontalFactor,
                pos.y,
                pos.z );
        }
    }
}
