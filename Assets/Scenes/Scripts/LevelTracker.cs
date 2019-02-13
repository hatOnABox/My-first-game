using UnityEngine;
using UnityEngine.UI;

public class LevelTracker : MonoBehaviour
{
    public Button[] buttons = {};
    public static bool[] levelsUnlocked = {false, false}; // list excludes level 1

    void Start()
    {
        try
        {
            if (HandleData.load() != levelsUnlocked)
            {
                levelsUnlocked = HandleData.load();
            }


        }
        catch (System.Exception) {
            ;
        }

        for (int i = 0; i <= buttons.Length - 1; i++) {
            buttons[i].enabled = levelsUnlocked[i];
            if (levelsUnlocked[i] == false)
            {
                buttons[i].GetComponent<Image>().color = Color.grey;
            }
        }
    }
}
