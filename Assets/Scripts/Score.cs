using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float score = 0f;
    public GameObject Player;

    private float currentHighScore = 0f;


    /// <summary>
    /// score‚Ìgetter
    /// </summary>
    public float GetScore
    {
        get
        {
            return currentHighScore;
        }
    }



        public string GetScoreText
    {
        get
        {
            return currentHighScore.ToString ( "F2" );
        }
    }





    // Update is called once per frame
    void Update ()
    {
        if ( currentHighScore < Player.transform.position.y )
        {
            currentHighScore = Player.transform.position.y;
        }

        Debug.Log ( currentHighScore );
    }
}
