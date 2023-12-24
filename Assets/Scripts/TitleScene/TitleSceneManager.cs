using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleSceneManager : MonoBehaviour
{
    /// <summary>
    /// soundManager���g����^�C�~���O�ŃV�[���ォ��T������
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    /// <summary>
    /// BGM���t�F�[�h�C�����鎞��
    /// </summary>
    public float FadeDuration = 2f;



    private void Start()
    {
        StartCoroutine(FadeInBGM());
    }


    /// <summary>
    /// �C���Q�[���̃V�[����ǂݍ��݂���i�ڍs����j
    /// </summary>
    public void GotoInGameScene()
    {
        StartCoroutine(SceneTransition());

        //BGM�̉��ʂ�0�ɂ���
        soundManager.GetBGMAudioSouce.volume = 0;
    }

    /// <summary>
    /// SE����I���̂��A�҂�����ɃV�[����J�ڂ�����
    /// </summary>
    /// <returns></returns>
    public IEnumerator SceneTransition()
    {
        //SE��炷�������ɂ���̂͂��������Ȃ̂Ō�ŕς���
        soundManager.PlaySE();
        //yield return new WaitForSeconds(1f);
        //SE�����Ă���ԑ҂�
        yield return new WaitWhile(() => soundManager.IsSEAudioSourcesPlaying());
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);


    }


    /// <summary>
    /// �x���BGM��炷
    /// </summary>
    /// <returns></returns>
    public IEnumerator FadeInBGM()
    {

        //yield return new WaitForSeconds(1f);

        //����soundManager��null����Ȃ����
        if (soundManager != null)
        {
            //BGM���Đ�����
            soundManager.PlayBGM();

            //BGM�̉��ʂ�0�ɂ���
            soundManager.GetBGMAudioSouce.volume = 0;

            //�o�ߎ��Ԃ�0
            var elapsedTime = 0f;

            //�o�ߎ��Ԃ�FadeDuration�̒l�𒴂���܂�
            while (elapsedTime < FadeDuration)
            {
                //�t�F�[�h�C���̃{�����[�����v�Z
                //0����1�̊ԂŐ��`��Ԃ������Ȃ������ʂ��{�����[���̒l�ɑ������
                soundManager.GetBGMAudioSouce.volume = Mathf.Lerp(0f,1,elapsedTime / FadeDuration);

                //�o�ߎ��Ԃ��X�V����
                elapsedTime += Time.deltaTime;

                //�P�t���[���ҋ@����
                yield return null;
            }

            //�t�F�[�h�C��������ɍŏI�I�ȃ{�����[����1�ɂ���
            soundManager.GetBGMAudioSouce.volume = 1f;
        }
    }
}
