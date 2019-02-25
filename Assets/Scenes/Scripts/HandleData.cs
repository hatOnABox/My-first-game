using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// got code from: https://www.youtube.com/watch?v=XOjd_qU2Ido
public static class HandleData
{
    public static bool[] data1 = { false, false, false, false, false, false };
    public static void save()
    {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.gamedata";
        FileStream stream = new FileStream(path, FileMode.Create);

        data1 = LevelTracker.levelsUnlocked;

        formatter.Serialize(stream, data1);
        stream.Close();

    }

    public static bool[] load()
    {
        string path = Application.persistentDataPath + "/player.gamedata";
        if (File.Exists(path) == true)
        {
            //Debug.Log(path);
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            //PlayerData data = formatter.Deserialize(stream) as PlayerData;
            data1 = formatter.Deserialize(stream) as bool[];
            stream.Close();

            return data1;
        }
        else
        {
            return data1;
        }
    }
}