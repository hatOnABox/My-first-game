﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class winLevel : MonoBehaviour
{
    private int placeholder;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {


            try
            {
                placeholder = int.Parse(SceneManager.GetActiveScene().name[6].ToString());
                LevelTracker.levelsUnlocked[placeholder - 1] = true;
            }
            catch
            {}
            HandleData.save();
            SceneManager.LoadScene("LevelsMenu");
        }
    }
}
