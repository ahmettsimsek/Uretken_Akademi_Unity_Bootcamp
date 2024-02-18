using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu(fileName ="Building Preset", menuName ="New Building Preset")] // create sað týký yaparsan new building preset seçeneði gelr listede
public class BuildingPreset : ScriptableObject 
{
    public int cost;
    public int costPerTurn;
    public GameObject prefab;

    public int population;
    public int jobs;
    public int food;

}
