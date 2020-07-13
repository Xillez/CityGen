using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSegment
{
    [SerializeField] public Vector3 start;
    [SerializeField] public Vector3 end;

    public RoadSegment(Vector3 start, Vector3 end)
	{
		this.start = start;
		this.end = end;
	}
}
