using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CityGen))]
public class CityGenInspector : Editor
{
	public override void OnInspectorGUI()
	{
		CityGen cityGen = (CityGen) target;
	}
}
