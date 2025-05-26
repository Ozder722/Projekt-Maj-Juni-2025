using UnityEngine;

public static class Globalhelper
{
    public static string GenerateUniqueID(GameObject obj)
    {
        return $"{obj.scene.name}";
    }
}
