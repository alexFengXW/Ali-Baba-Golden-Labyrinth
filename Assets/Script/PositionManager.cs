using UnityEngine;

public class PositionManager : MonoBehaviour
{
    public static void SavePosition(Vector3 position, Quaternion rotation)
    {
        PlayerPrefs.SetFloat("TargetPosX", position.x);
        PlayerPrefs.SetFloat("TargetPosY", position.y);
        PlayerPrefs.SetFloat("TargetPosZ", position.z);
        PlayerPrefs.SetFloat("TargetRotX", rotation.x);
        PlayerPrefs.SetFloat("TargetRotY", rotation.y);
        PlayerPrefs.SetFloat("TargetRotZ", rotation.z);
        PlayerPrefs.SetFloat("TargetRotW", rotation.w);
        PlayerPrefs.Save();
    }

    public static Vector3 LoadPosition()
    {
        float x = PlayerPrefs.GetFloat("TargetPosX", 0);
        float y = PlayerPrefs.GetFloat("TargetPosY", 0);
        float z = PlayerPrefs.GetFloat("TargetPosZ", 0);
        return new Vector3(x, y, z);
    }

    public static Quaternion LoadRotation()
    {
        float x = PlayerPrefs.GetFloat("TargetRotX", 0);
        float y = PlayerPrefs.GetFloat("TargetRotY", 0);
        float z = PlayerPrefs.GetFloat("TargetRotZ", 0);
        float w = PlayerPrefs.GetFloat("TargetRotW", 1);
        return new Quaternion(x, y, z, w);
    }
}
