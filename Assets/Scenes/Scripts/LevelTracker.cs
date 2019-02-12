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
            if (HandleData.load() != levelsUnlocked)
            {
                levelsUnlocked = HandleData.load();
            }


        }
        catch {}
        Debug.Log(levelsUnlocked[0]);

        button2.enabled = levelsUnlocked[0];
    }
}
