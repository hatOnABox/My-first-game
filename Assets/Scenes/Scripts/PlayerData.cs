using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// got code from: https://www.youtube.com/watch?v=XOjd_qU2Ido

[System.Serializable]
public class PlayerData
{
    public static bool[] levels;
    public PlayerData () {
        levels = LevelTracker.levelsUnlocked;

}
}
