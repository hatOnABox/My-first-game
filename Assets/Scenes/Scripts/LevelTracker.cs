using UnityEngine;
using UnityEngine.UI;

public class LevelTracker : MonoBehaviour
{
    public Button[] buttons = {};
    public static bool[] levelsUnlocked = {false, false, false, false, false, false}; // list excludes level 1
    private int x;


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

        foreach (bool i in levelsUnlocked)
        {
            try
            {
                buttons[x].enabled = levelsUnlocked[x];
                if (levelsUnlocked[x] == false)
                {
                    buttons[x].GetComponent<Image>().color = Color.grey;
                }
            } catch (System.Exception) {
                ;
            }
            x++;
        }
    }
}
