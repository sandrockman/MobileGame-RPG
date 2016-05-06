using UnityEngine;
using UnityEditor;

public class PositionManager : Editor
{
    //define menu option
    [MenuItem("Assets/Create/PositionManager")]
    public static void CreateAsset()
    {
        ScriptingObjects positionManager = ScriptableObject.CreateInstance<ScriptingObjects>();

        //Create a .asset file for new object and save it
        AssetDatabase.CreateAsset(positionManager, "Assets/newPositionManager.asset");
        AssetDatabase.SaveAssets();

        //Switch inspector to new object
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = positionManager;

    }
}
