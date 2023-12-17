using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    /// <summary>
    /// �ő�HitPoint�B���N��Ԃ�\��
    /// </summary>
    public float MaxHealth = 100f;

    /// <summary>
    /// ���݂�HitPoint�B
    /// </summary>
    private float currentHealth;

    /// <summary>
    /// currentHealth���Q�b�g���邽�߂̃A�N�Z�T�i�Q�b�^�[�j
    /// </summary>
    public float GetCurrentHealth
    {
        get { return currentHealth; }
    }



    /// <summary>
    /// ���S����
    /// </summary>
    public bool IsDead = false;//���S�t���O��"�܂�Ă���"���


    /// <summary>
    /// �ŏ��Ɉ�񂾂���������郁�\�b�h
    /// </summary>
    void Start()
    {
        //���݂�HitPoint�ɍő�HitPoint����
        currentHealth = MaxHealth;
    }

    /// <summary>
    /// ���݂�HitPoint����damage���̒l������
    /// </summary>
    /// <param name="damage">HitPoint����������l</param>
    public void TakeDamage(float damage)
    {
        //HitPoint��0�Ȃ̂ł���if��艺�͏������s��Ȃ��悤�ɂ���
        if (currentHealth == 0)
        {
            return;
        }
        //���݂�HP��0����Ȃ�
        if (currentHealth > 0)
        {
            currentHealth -= damage;
            Debug.Log($"���݂�Health��{currentHealth}");
        }
        //HitPoint��0����������Ȃ�
        if (currentHealth <= 0)
        {
            //currentHealth��0�ɂ���B
            currentHealth = 0;

            Debug.LogError("�Q�[���I�[�o�[");
            //���S�t���O��"���Ă�"
            IsDead = true;
        }
    }
}
