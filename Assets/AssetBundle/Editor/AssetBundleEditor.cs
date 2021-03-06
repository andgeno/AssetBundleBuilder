using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(AssetBundleBuilder))]
public class AssetBundleEditor : Editor
{
	public override void OnInspectorGUI()
	{
		AssetBundleBuilder gen = (AssetBundleBuilder)target;
		DrawDefaultInspector();
		
		EditorGUILayout.BeginVertical();

		EditorGUILayout.BeginHorizontal();
		if (GUILayout.Button("Build Web")) gen.BuildWeb();
		if (GUILayout.Button("Build Android")) gen.BuildAndroid();
		
		if (Application.platform == RuntimePlatform.OSXEditor)
			if (GUILayout.Button("Build iOS")) gen.BuildiPhone();

		EditorGUILayout.EndHorizontal();
		
		if (GUILayout.Button("Build All Platform")) gen.BuildAll();
		
		EditorGUILayout.EndVertical();
	}
}
