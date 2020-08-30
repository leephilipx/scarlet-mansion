/*using UnityEngine;
using UnityEditor;
using System.IO;

public class AddScene
{
    // Simple script that lets you load the contents of a selected scene 
    // to your current scene.

    [@MenuItem("Example/Load Scene Additive")]
    static void Apply()
    {
        string strScenePath = AssetDatabase.GetAssetPath(Selection.activeObject);
        if (strScenePath == null || !strScenePath.Contains(".unity"))
        {
            EditorUtility.DisplayDialog("Select Scene", "You Must Select a Scene!", "Ok");
            EditorApplication.Beep();
            return;
        }
        Debug.Log("Opening " + strScenePath + " additively");
        EditorSceneManager.OpenSceneAdditive(strScenePath);
    }
}*/