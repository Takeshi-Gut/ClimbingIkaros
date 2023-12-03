using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public JumpCount JumpCount;


    /// <summary>
    /// �ړ����x
    /// </summary>
    private float moveSpeed = 5f; //�ړ����x

    /// <summary>
    /// �W�����v��
    /// </summary>
    private float jumpForce = 7f;

    /// <summary>
    /// ����\�����C���[�}�X�N
    /// </summary>
    public LayerMask GroundLayer;

    /// <summary>
    /// �n�ʂɐڐG���Ă��邩�ǂ���
    /// </summary>
    private bool isGrounded;

    /// <summary>
    /// Rigidbody2D�R���|�[�l���g
    /// </summary>
    private Rigidbody2D playerRigidBody;

    /// <summary>
    /// �W�����v��
    /// </summary>
    private float jumpPower = 0f;

    public float GetJumpPower
    {
        get
        {
            return jumpPower;
        }
    }


    void Start ()
    {
        playerRigidBody = GetComponent<Rigidbody2D> ();
    }



    // Update is called once per frame
    void Update ()
    {
        //���E�̓��͂��擾
        var horizontalInput = Input.GetAxis ( "Horizontal" );

        //���E�̈ړ����v�Z
        var moveX = horizontalInput * moveSpeed * Time.deltaTime;

        //���݂̈ʒu�Ɉړ��ʂ�ǉ�
        transform.Translate ( new Vector3 ( moveX,0,0 ) );

        //�n�ʂɐڐG���Ă��邩�𔻒�
        isGrounded = Physics2D.OverlapCircle
            ( transform.position - new Vector3 ( 0,0.9f,0 ),0.2f,GroundLayer );



        ////�n�ʂɐڐG���Ă���ꍇ
        //if ( isGrounded )
        //{
        //    //Player��Rigidbody2D�ɏ�����̗͂�������
        //    playerRigidBody.velocity = new Vector2 ( playerRigidBody.velocity.x,jumpForce );

        //    //�W�����v�J�E���g�������Ăяo��
        //    JumpCount.AddJumpCount();

        //}
    }

    private void FixedUpdate ()
    {
        //�n�ʂɐڐG���Ă���ꍇ
        if ( isGrounded )
        {
            //Player��Rigidbody2D�ɏ�����̗͂�������
            playerRigidBody.velocity = new Vector2 ( playerRigidBody.velocity.x,jumpForce );

            //�W�����v�J�E���g�������Ăяo��
            JumpCount.AddJumpCount ();
        }

        //jumpPower�ɉ����x��y��^����
        jumpPower = playerRigidBody.velocity.y;


    }



}
