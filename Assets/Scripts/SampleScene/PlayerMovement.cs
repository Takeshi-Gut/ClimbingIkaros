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
    /// bool�^��IsGrounded������������
    /// </summary>
    private Collider2D isGroundedCollider;

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

    /// <summary>
    /// �E�������ǂ���
    /// </summary>
    private bool isRight = true;

    /// <summary>
    /// �O������E�������ǂ������擾����A�N�Z�T
    /// </summary>
    public bool GetIsRight
    {
        get
        {
            return isRight;
        }
    }

    //
    private MainGameStateManager mainGameStateManager => FindAnyObjectByType<MainGameStateManager>();




    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        //����mainGameStateManager�ŃQ�[���C���̃t���O�������Ă�����
        if(mainGameStateManager.GetGameEnd)
        {
            //�ړ��Ȃǁi�������牺�j�̏��������Ȃ�
            return;
        }


        //���E�̓��͂��擾
        var horizontalInput = Input.GetAxis("Horizontal");

        //���E�̈ړ����v�Z
        var moveX = horizontalInput * moveSpeed * Time.deltaTime;


        if (isRight)
        {
            //���������ꂽ
            if (horizontalInput < 0)
            {
                isRight = false;
            }
        }
        else
        {
            //�E�������ꂽ
            if (horizontalInput > 0)
            {
                isRight = true;
            }
        }




        //���݂̈ʒu�Ɉړ��ʂ�ǉ�
        transform.Translate(new Vector3(moveX,0,0));

        //�n�ʂɐڐG���Ă��邩�𔻒�
        isGroundedCollider = Physics2D.OverlapCircle
            (transform.position - new Vector3(0,0.9f,0),0.2f,GroundLayer);



        ////�n�ʂɐڐG���Ă���ꍇ
        //if ( isGrounded )
        //{
        //    //Player��Rigidbody2D�ɏ�����̗͂�������
        //    playerRigidBody.velocity = new Vector2 ( playerRigidBody.velocity.x,jumpForce );

        //    //�W�����v�J�E���g�������Ăяo��
        //    JumpCount.AddJumpCount();

        //}
    }

    private void FixedUpdate()
    {
        //�n�ʂɐڒn���Ă���A�Ȃ������~���̏ꍇ
        if (isGroundedCollider != null && playerRigidBody.velocity.y < 0f)
        {
            //��������Collider��StageBase���擾
            var stageBase = isGroundedCollider.GetComponent<StageBase>();

            //StageBase���擾�ł����
            if (stageBase != null)
            {
                stageBase.OnCollisionEnter2DAction(this.gameObject);


                //Player��Rigidbody2D�ɏ�����̗͂�������
                playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x,jumpForce);

                //�W�����v�J�E���g�������Ăяo��
                JumpCount.AddJumpCount();
            }

            //jumpPower�ɉ����x��y��^����
            jumpPower = playerRigidBody.velocity.y;


        }

    }

}
