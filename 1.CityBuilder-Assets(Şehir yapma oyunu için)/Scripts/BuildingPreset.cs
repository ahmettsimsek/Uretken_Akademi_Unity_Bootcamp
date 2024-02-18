using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CreateAssetMenu(fileName ="Building Preset", menuName ="New Building Preset")] // create sa� t�k� yaparsan new building preset se�ene�i gelr listede
public class BuildingPreset : ScriptableObject 
{
    public int cost;
    public int costPerTurn;
    public GameObject prefab;

    public int population;
    public int jobs;
    public int food;

}
