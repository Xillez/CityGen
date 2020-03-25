using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(City))]
public class CityInspector : Editor
{
	[SerializeField] private City city;

	//[SerializeField] private ScriptableObject generator;

	void OnEnable()
    {
        this.city = (City) target;

		//this.LoadSettings();
    }

	public override void OnInspectorGUI()
	{
		//EditorGUI.BeginChangeCheck();
		this.city.generator = (ScriptableObject) EditorGUILayout.ObjectField("Generator", this.city.generator, typeof(ScriptableObject), false);
		if (!(this.city.generator is IGenerator))	// If not IGenerator, give error and abort
		{
			GUIStyle errorStyle = new GUIStyle(GUI.skin.label);
			errorStyle.richText = true;
			EditorGUILayout.LabelField(Logging.Error + "\"Generator\" is not valid, Use SO's in the CityGen/Generators folder!", errorStyle);
			return;
		}

		if (GUILayout.Button("Generate", GUILayout.ExpandWidth(true)) && this.city.generator != null)	// Generate button pressed and generator available
			((IGenerator) this.city.generator).Generate(this.city);										// Generate city

		/*if (EditorGUI.EndChangeCheck())
       		SaveSettings();*/
	}

	public void OnSceneGUI()
	{
		this.city = (City) target;
		if (this.city != null)		// City available
		{
			if (this.city.GetSegments() != null)	// City has road segments
			{
				Color tempColor = Handles.color;
				Handles.color = Color.red;
				foreach (RoadSegment segment in this.city.GetSegments())	
				{
					Handles.DrawLine(segment.start, segment.end);	// Draw line per road segment
				}
				Handles.color = tempColor;
			}
		}
	}

	protected void OnDisable()
	{
		//this.SaveSettings();
	}

	/*public void OnSceneSaving(SceneManagement.Scene scene, string path)
	{
		this.SaveSettings();
	}*/

	private void SaveSettings()
	{
		// Save city config data
		/*string data = JsonUtility.ToJson(this, false);
		//EditorPrefs.SetString("CityGen_CityInspector_City" + this.city.GetId().ToString(), data);
		
		string path = "./Assets/Scripts/CityGen/Resources/CitySaves/City_" + this.city.GetId().ToString() + ".json";

		// Delete the file if it exists.
        if (File.Exists(path))
        {
            File.Delete(path);
        }

		using (FileStream fs = new FileStream(path, FileMode.Create))
		{
			Debug.Log("DOOUUUOOEEESSS DIIIS SHEEIEIIIT WAAARKRRKKKK?");
			using (StreamWriter writer = new StreamWriter(fs))
			{
				writer.Write(data);
			}
		}
		
		#if UNITY_EDITOR
			UnityEditor.AssetDatabase.Refresh();
		#endif*/
	}

	private void LoadSettings()
	{
		// Get city config data and apply it if it exsists
		/*string data = EditorPrefs.GetString("CityGen_CityInspector_City_" + this.city.GetId().ToString(), JsonUtility.ToJson(this, false));
		if (data != null || data.Length == 0)
			JsonUtility.FromJsonOverwrite(data, this);*/

		/*string path = "./Assets/Scripts/CityGen/Resources/CitySaves/City_" + this.city.GetId().ToString() + ".json";

		if (File.Exists(path))
		{
			string data = File.ReadAllText(path);
			if (data != null || data.Length == 0)
				JsonUtility.FromJsonOverwrite(data, this);
		}*/
	}
}
