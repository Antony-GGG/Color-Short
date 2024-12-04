using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "LevelData_", menuName = "ScriptableObjects/LevelData", order = 1)]
public class LevelData : ScriptableObject
{
    public int numberOfTubes;
    public List<TubeData> tubes = new List<TubeData>();
}
