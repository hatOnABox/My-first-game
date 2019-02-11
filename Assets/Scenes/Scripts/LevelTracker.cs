using UnityEngine;
using UnityEngine.UI;

public class LevelTracker : MonoBehaviour
{
    //public Button button1;
    public Button button2;
    public static bool[] levelsUnlocked = {false}; // list excludes level 1

    void Start()
    {
        try
        {
            LevelTracker.levelsUnlocked = HandleData.load();
        }
        catch {}
        HandleData.save();
     

        if (LevelTracker.levelsUnlocked[0] == false)
        {
            button2.enabled = false;
        }
    }
}
