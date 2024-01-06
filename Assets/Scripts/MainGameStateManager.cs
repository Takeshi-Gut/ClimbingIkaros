using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStateManager : MonoBehaviour
{
    public Canvas ResultCanvas;

    public Timer Timer;

    public Health PlayerHealth;

    bool gameEnd = false;

    //�O������gameEnd���擾����Q�b�^�[
    public bool GetGameEnd
    {
        get { return gameEnd; }
    }


    /// <summary>
    /// soundManager���g����^�C�~���O�ŃV�[���ォ��T������
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    private void Start()
    {
        soundManager.PlayBGM();
        {
            //�J�E���g�_�E���̃X�^�[�g�R���[�`���B�X�^�[�g������J�E���g�_�E�����n�߂�B
            StartCoroutine(CountDownCoroutine());
        }
    }

    public IEnumerator CountDownCoroutine()
    {
        //3�b����J�E���g�_�E�����A0���傫��������P������������
        for (int i = 3 ; i >= 1 ; i--)
        {
            //1�b�҂�
            yield return new WaitForSeconds(1);

            //DebugLog�ɃJ�E���g�_�E���\���B3.2.1.START��\������B
            Debug.Log(i.ToString());

            //����-1�b�ɂȂ�����ASTART��Debug.Log�ɕ\������
            if (i == 1)
            {
                //1�b�҂�
                yield return new WaitForSeconds(1);
                Debug.Log("START");
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (gameEnd)
        {
            return;
        }
        if (PlayerHealth.IsDead)
        {
            //ResultCanvas�̃A�N�e�B�u���I���ɂ���
            ResultCanvas.gameObject.SetActive(true);
            gameEnd = true;
        }



        //Timer�̐������Ԃ�0�����������
        if (Timer.GetLimitTime < 0f)
        {
            //ResultCanvas�̃A�N�e�B�u���I���ɂ���
            ResultCanvas.gameObject.SetActive(true);
            gameEnd = true;
        }
    }
}
