﻿using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// got code from: https://www.youtube.com/watch?v=XOjd_qU2Ido
public static class HandleData
{
    public static bool[] data1;
    public static void save()
    {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.juan";
        FileStream stream = new FileStream(path, FileMode.Create);

        //PlayerData data = new PlayerData();
        //public static bool[] data = LevelTracker.levelsUnlocked;
        data1 = LevelTracker.levelsUnlocked;

        formatter.Serialize(stream, data1);
        stream.Close();

    }

    public static bool[] load()
    {
        string path = Application.persistentDataPath + "/player.juan";
        if (File.Exists(path) == true)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            //PlayerData data = formatter.Deserialize(stream) as PlayerData;
            data1 = formatter.Deserialize(stream) as bool[];
            stream.Close();

            return data1;
        }
        else
        {
            Debug.Log("Error warning!");
            return null;
        }
    }
}
