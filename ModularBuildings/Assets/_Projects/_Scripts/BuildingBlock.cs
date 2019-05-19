using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class BuildingBlock : MonoBehaviour
{
    public enum BlockType
    {
        Entry,Window,Corner
    }

    public BlockType blockType;
    public Vector2 GetWidthHeight()
    {
        var mesh = GetComponent<MeshFilter>().mesh;
        var width = mesh.bounds.max.x - mesh.bounds.min.x;
        var height = mesh.bounds.max.y - mesh.bounds.min.y;
        return new Vector2(width,height);
    }
}
