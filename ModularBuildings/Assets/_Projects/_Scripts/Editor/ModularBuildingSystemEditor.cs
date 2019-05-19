using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ModularBuildingSystem))]
[CanEditMultipleObjects]
public class ModularBuildingSystemEditor : UnityEditor.Editor
{
    private ModularBuildingSystem modularBuildingSystem;

    private void OnEnable()
    {
        modularBuildingSystem = (ModularBuildingSystem) target;
    }
    public override void OnInspectorGUI()
    {
        //serializedObject.Update();
        if (GUILayout.Button("Generate Home"))
        {
            modularBuildingSystem.GenerateBuilding();
        }
        //serializedObject.ApplyModifiedProperties();
    }
}

