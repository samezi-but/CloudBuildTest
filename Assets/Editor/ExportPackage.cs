using UnityEditor;

public class ExportPackage
{
    [MenuItem("Assets/Custom/Export Package")]
    static void Export()
    {
        // エクスポート
        AssetDatabase.ExportPackage("Assets/ExportPackage/Cube.prefab", "exportpackage.unitypackage",
            ExportPackageOptions.Recurse | ExportPackageOptions.Default);
    }
}