using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGenerator
{
    void Generate(City city);
    RoadSegment MakeRoadSegment(RoadSegment parent, Vector3 start, Vector3 end);
}
