using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "CityGen/Config/CityGen Config", order = 1)]
public class CityGenConfig : ScriptableObject
{
    public string CityParentObjectName;
    public string ConfigurationLocation;
}