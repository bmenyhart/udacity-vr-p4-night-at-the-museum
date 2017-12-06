using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Modify the given vertices so they follow a sin curve
 */
[Obsolete]
public class Bend : BaseVertexEffect
{
    private float scale;
    private float phase;
    private float amplitude;
    public Bend(float scale, float phase, float amplitude)
    {
        this.scale = scale;
        this.phase = phase;
        this.amplitude = amplitude;
    }

   
    [Obsolete]
    public override void ModifyVertices(List<UIVertex> verts)
    {
        for (int index = 0; index < verts.Count; index++)
        {
            var uiVertex = verts[index];

            uiVertex.position.z = Mathf.Sin(uiVertex.position.x * this.scale + this.phase) * this.amplitude;
            verts[index] = uiVertex;
        }
    }
}