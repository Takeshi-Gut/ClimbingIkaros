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
        //JumpCountの数字をJumpCountTextの文字ボックスに入れろ
        JumpCountText.text = JumpCount.GetJumpCount.ToString ();
    }
}