using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[ExecuteInEditMode]
public class City : MonoBehaviour
{
    [SerializeField] private string cityName {get; set;}
    [SerializeField] public ScriptableObject generator;
    [SerializeField] private List<RoadSegment> roadSegments;

    public void Setup()
    {
        this.cityName = this.transform.gameObject.name;

        if (this.roadSegments == null)
            this.roadSegments = new List<RoadSegment>();
    }

    public List<RoadSegment> GetSegments(RoadSegment exclude = null)
    {
        if (exclude == null || this.roadSegments == null)    // Nothing to exclude, give all
            return this.roadSegments;

        List<RoadSegment> temp = new List<RoadSegment>(this.roadSegments); 
        temp.RemoveAt(this.roadSegments.IndexOf(exclude));
        return temp;
    }

    public RoadSegment GetSegment(int index)
    {
        if (this.roadSegments == null)
            return null;

        return this.roadSegments[index];
    } 

    public void AddSegment(RoadSegment segment)
    {
        if (this.roadSegments != null)
            this.roadSegments.Add(segment);
    }

    public void RemoveSegment(int index)
    {
        if (this.roadSegments != null)
            this.roadSegments.RemoveAt(index);
    }

    public void RemoveSegment(RoadSegment segment)
    {
        if (this.roadSegments != null)
            this.roadSegments.Remove(segment);
    }
}
