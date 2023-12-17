using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultViewer : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;

    public Score Score;

    public Button RetryButton;

    public Button GotoTitleButton;

    /// <summary>
    /// �N���A�G�t�F�N�g�̃Q�[���I�u�W�F�N�g
    /// </summary>
    public GameObject ClearEffect;

    /// <summary>
    /// ClimbingIkarosStageDataManager��UnityEditor����Q�Ƃ���
    /// </summary>
    public ClimbingIkarosStageDataManager ClimbingIkarosStageDataManager;


    /// <summary>
    /// GameObject���A�N�e�B�u�ɂȂ����Ƃ��Ɏ��s�����
    /// </summary>
    private void OnEnable()
    {
        HighScoreText.text = $"�M���̃X�R�A��{Score.GetScoreText}";

        RetryButton.gameObject.SetActive(true);

        GotoTitleButton.gameObject.SetActive(true);

        //�����X�R�A�i������ClimbingStageData�̐ݒ肷�鍂����荂����΁j
        if (Score.GetScore > ClimbingIkarosStageDataManager.GetClearHeight)
        {
            //�N���A�G�t�F�N�g���Đ�����
            ClearEffect.gameObject.SetActive(true);
        }

    }

    /// <summary>
    /// �V�[�����ēǂݍ��݂���
    /// </summary>
    public void Reload()
    {
        SceneManager.LoadScene(GameSceneUtility.GameSceneName);
    }

    /// <summary>
    /// �^�C�g���V�[���ɑJ�ڂ���
    /// </summary>
    public void GotoTitleScene()
    {
        SceneManager.LoadScene(GameSceneUtility.TitleSceneName);
    }
}
