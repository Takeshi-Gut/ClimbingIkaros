using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JumpCountViewer : MonoBehaviour
{
    public JumpCount JumpCount;
    public TextMeshProUGUI JumpCountText;


    // Update is called once per frame
    void Update ()
    {
        //JumpCount�̐�����JumpCountText�̕����{�b�N�X�ɓ����
        JumpCountText.text = JumpCount.GetJumpCount.ToString ();
    }
}