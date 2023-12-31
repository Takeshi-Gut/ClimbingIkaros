using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームの設定データの置き場所
/// staticは静的という意味なので、どこからでもアクセスできます
/// </summary>
public static class GameSettingUtility
{
   public const string PlayerTagName = "Player";
 
    /// <summary>
    /// Groundのレイヤーナンバー（No.）
    /// </summary>
    public const int GroundLayerNumber = 6;

    /// <summary>
    /// ステージの横への移動幅
    /// </summary>
    public const float MoveStageHorizontalFactor = 0.01f;
}
