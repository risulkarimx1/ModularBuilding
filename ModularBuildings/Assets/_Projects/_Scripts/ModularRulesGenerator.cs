using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct FloorRules
{
    public string rule;
}

public class ModularRulesGenerator:MonoBehaviour
{
    public List<FloorRules> floors;

    public List<FloorRules> GetRules()
    {
        return floors;
    }
}
