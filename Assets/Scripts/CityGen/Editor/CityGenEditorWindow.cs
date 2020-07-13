using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CityGenEditorWindow : EditorWindow
{
    [SerializeField] private CityGenConfig config;

    [SerializeField] private GameObject cityContainer;
    [SerializeField] private CityGen citygen;

    // Add menu named "City Gen" to the Window menu
    //! [MenuItem("Window/City Gen")]              NOTE! Enable this when editor window is feasable
    static void Init()
    {
        // Get existing window or if none, make a new one:
        CityGenEditorWindow window = (CityGenEditorWindow)EditorWindow.GetWindow<CityGenEditorWindow>("City Gen");
        window.setup();
        window.Show();
    }

    public void setup()
    {
        this.config = (CityGenConfig) Resources.Load("Config/CityGen"); // Load config

        this.cityContainer = GameObject.Find(config.CityParentObjectName);  // Find city containment object.
        if (this.cityContainer == null)                                     // Containment obj not found, make it.
        {
            Debug.Log(Logging.Error + "Couldn't find gameobject with name: " + config.CityParentObjectName + "! Making one!");
            this.cityContainer = new GameObject(config.CityParentObjectName);
            this.citygen = this.cityContainer.AddComponent<CityGen>();
        }
    }

    void OnGUI()
    {
        // SELECION MENU

        // ASSET SCREEN

        // PROPERTY EDITOR


        /*GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Text Field", myString);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();*/
    }
}
