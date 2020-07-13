using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "CityGen/Generators/Village Generator", order = 1)]
public class VillageGenerator : ScriptableObject, IGenerator
{
    [SerializeField] public int nrDivisions;
    [SerializeField] public bool doCurvingRoads;
    [Range(0, 10)]
    [SerializeField] public int roadCurveDetail;
    [SerializeField] public float maxBlockDistance;
    [SerializeField] public float minBlockDistance;

    public void Generate(City city)
    {
        

        /*Debug.Log(Logging.Info + "Generating city -> " + city.name);
		city.AddSegment(new RoadSegment(UnityEngine.Random.insideUnitSphere * 5.0f, UnityEngine.Random.insideUnitSphere * 5.0f));
		city.AddSegment(new RoadSegment(UnityEngine.Random.insideUnitSphere * 5.0f, UnityEngine.Random.insideUnitSphere * 5.0f));
		city.AddSegment(new RoadSegment(UnityEngine.Random.insideUnitSphere * 5.0f, UnityEngine.Random.insideUnitSphere * 5.0f));
		city.AddSegment(new RoadSegment(UnityEngine.Random.insideUnitSphere * 5.0f, UnityEngine.Random.insideUnitSphere * 5.0f));
        city.AddSegment(new RoadSegment(UnityEngine.Random.insideUnitSphere * 5.0f, UnityEngine.Random.insideUnitSphere * 5.0f));
		city.AddSegment(new RoadSegment(UnityEngine.Random.insideUnitSphere * 5.0f, UnityEngine.Random.insideUnitSphere * 5.0f));
		city.AddSegment(new RoadSegment(UnityEngine.Random.insideUnitSphere * 5.0f, UnityEngine.Random.insideUnitSphere * 5.0f));
		city.AddSegment(new RoadSegment(UnityEngine.Random.insideUnitSphere * 5.0f, UnityEngine.Random.insideUnitSphere * 5.0f));*/
    }

    public RoadSegment MakeRoadSegment(RoadSegment parent, Vector3 start, Vector3 end)
    {
        return null;
    }
}
