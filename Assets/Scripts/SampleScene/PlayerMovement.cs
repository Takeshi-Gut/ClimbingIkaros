using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public JumpCount JumpCount;


    /// <summary>
    /// 移動速度
    /// </summary>
    private float moveSpeed = 5f; //移動速度

    /// <summary>
    /// ジャンプ力
    /// </summary>
    private float jumpForce = 7f;

    /// <summary>
    /// 床を表すレイヤーマスク
    /// </summary>
    public LayerMask GroundLayer;

    /// <summary>
    /// 地面に接触しているかどうか
    /// bool型のIsGroundedを書き換えた
    /// </summary>
    private Collider2D isGroundedCollider;

    /// <summary>
    /// Rigidbody2Dコンポーネント
    /// </summary>
    private Rigidbody2D playerRigidBody;

    /// <summary>
    /// ジャンプ力
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
    /// 右向きかどうか
    /// </summary>
    private bool isRight = true;

    /// <summary>
    /// 外部から右向きかどうかを取得するアクセサ
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
        //もしmainGameStateManagerでゲーム修了のフラグが立っていたら
        if(mainGameStateManager.GetGameEnd)
        {
            //移動など（ここから下）の処理をしない
            return;
        }


        //左右の入力を取得
        var horizontalInput = Input.GetAxis("Horizontal");

        //左右の移動を計算
        var moveX = horizontalInput * moveSpeed * Time.deltaTime;


        if (isRight)
        {
            //左が押された
            if (horizontalInput < 0)
            {
                isRight = false;
            }
        }
        else
        {
            //右が押された
            if (horizontalInput > 0)
            {
                isRight = true;
            }
        }




        //現在の位置に移動量を追加
        transform.Translate(new Vector3(moveX,0,0));

        //地面に接触しているかを判定
        isGroundedCollider = Physics2D.OverlapCircle
            (transform.position - new Vector3(0,0.9f,0),0.2f,GroundLayer);



        ////地面に接触している場合
        //if ( isGrounded )
        //{
        //    //PlayerのRigidbody2Dに上向きの力を加える
        //    playerRigidBody.velocity = new Vector2 ( playerRigidBody.velocity.x,jumpForce );

        //    //ジャンプカウント処理を呼び出す
        //    JumpCount.AddJumpCount();

        //}
    }

    private void FixedUpdate()
    {
        //地面に接地しており、なおかつ下降中の場合
        if (isGroundedCollider != null && playerRigidBody.velocity.y < 0f)
        {
            //当たったColliderのStageBaseを取得
            var stageBase = isGroundedCollider.GetComponent<StageBase>();

            //StageBaseが取得できれば
            if (stageBase != null)
            {
                stageBase.OnCollisionEnter2DAction(this.gameObject);


                //PlayerのRigidbody2Dに上向きの力を加える
                playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x,jumpForce);

                //ジャンプカウント処理を呼び出す
                JumpCount.AddJumpCount();
            }

            //jumpPowerに加速度のyを与える
            jumpPower = playerRigidBody.velocity.y;


        }

    }

}
