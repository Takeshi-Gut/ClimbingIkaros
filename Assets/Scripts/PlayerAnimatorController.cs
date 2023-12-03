using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    /// <summary>
    /// PlayerMovementクラスを取得
    /// </summary>
    public PlayerMovement PlayerMovement;

    /// <summary>
    /// AnimatorコンポーネントのplayerAnimatorを変数宣言
    /// </summary>
    private Animator playerAnimator;


    // Start is called before the first frame update
    void Start ()
    {
        //playerAnimatorにGameObjectが持っているAnimatorを代入
        playerAnimator = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update ()
    {
        //Animatorのfloat型のパラメーター、JumpPowerにPlayerMovementのjumpPowerを代入する
        playerAnimator.SetFloat ( "JumpPower",PlayerMovement.GetJumpPower );
    }
}
