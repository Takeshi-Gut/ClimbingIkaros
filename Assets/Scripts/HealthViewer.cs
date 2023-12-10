using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthViewer : MonoBehaviour
{
    /// <summary>
    /// �̗͊Ǘ��N���X�BHealth�N���X���擾
    /// </summary>
    public Health Health;

    /// <summary>
    /// �̗͔��f�p�̃X���C�_�[�B�X���C�_�[��UI���g�p���܂�
    /// </summary>
    public Slider HealthSlider;


    // Update is called once per frame
    private void LateUpdate ()
    {
        //Slider��Position�ɃJ�����̍��W�ϊ����g����
        //�v���C���[�̃|�W�V����+Y��������1�̒l������������
        this.HealthSlider.GetComponent<RectTransform> ().position =
            Camera.main.WorldToScreenPoint ( this.Health.gameObject.transform.position + Vector3.up );

        //��������ł�����Slider�ɒl�������Ȃ��悤�ɂ���
        if ( Health.IsDead )
        {
            return;
        }
        //���ݑ̗�/�ő�̗́@�����邱�Ƃɂ���āA80/100�������ꍇ0.8�̒l��Slider�ɗ^���邱�Ƃ��ł���
        HealthSlider.value = Health.GetCurrentHealth / Health.MaxHealth;
    }
}