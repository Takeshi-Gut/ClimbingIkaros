using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeViewer : MonoBehaviour
{
    /// <summary>
    /// ���Ԍv���p�N���X
    /// </summary>
    public Timer Timer;

    /// <summary>
    /// ���ԕ\���p�̕�����\������ꏊ
    /// </summary>
    public TextMeshProUGUI TimerText;


    // Update is called once per frame
    void Update ()
    {
        //TimerText.text = Timer.GetGameTimeText;

        //���~�b�g�^�C�����^�C�}�[�e�L�X�g�ɑ������
        TimerText.text = Timer.GetLimitTimeText;
    }
}
