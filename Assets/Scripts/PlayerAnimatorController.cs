using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    /// <summary>
    /// PlayerMovement�N���X���擾
    /// </summary>
    public PlayerMovement PlayerMovement;

    /// <summary>
    /// Animator�R���|�[�l���g��playerAnimator��ϐ��錾
    /// </summary>
    private Animator playerAnimator;


    // Start is called before the first frame update
    void Start ()
    {
        //playerAnimator��GameObject�������Ă���Animator����
        playerAnimator = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update ()
    {
        //Animator��float�^�̃p�����[�^�[�AJumpPower��PlayerMovement��jumpPower��������
        playerAnimator.SetFloat ( "JumpPower",PlayerMovement.GetJumpPower );
    }
}
