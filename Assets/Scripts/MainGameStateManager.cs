using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStateManager : MonoBehaviour
{
    public Canvas ResultCanvas;

    public Timer Timer;


    // Update is called once per frame
    void Update ()
    {
        //Timerの制限時間が0を下回った時
        if ( Timer.GetLimitTime < 0f )
        {
            //ResultCanvasのアクティブをオンにする
            ResultCanvas.gameObject.SetActive ( true );
        }
    }
}
