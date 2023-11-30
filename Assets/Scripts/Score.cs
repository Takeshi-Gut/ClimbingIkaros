using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float score = 0f;
    public GameObject Player;

    /// <summary>
    /// score‚Ìgetter
    /// </summary>
    public float GetScore
    {
        get
        {
            return score;
        }
    }


    // Update is called once per frame
    void Update ()
    {
        score = Player.transform.position.y;

        Debug.Log ( $"{Player.transform.position.y}" );
    }
}
