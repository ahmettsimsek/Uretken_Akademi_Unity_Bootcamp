using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacment : MonoBehaviour
{
    private bool currentlyPlacing;
    private bool currentlyBulldozering;

    private BuildingPreset curbuildingPreset;

    private float indicatorUpdateTime = 0.05f;
    private float lastUpdateTime;
    private Vector3 curIndicatorPos;

    public GameObject placementIndicator;
    public GameObject bulldozerIndicator;

    public void BeginNewBuildingPlacement(BuildingPreset preset)
    {
        currentlyPlacing = true;
        curbuildingPreset = preset;
        placementIndicator.SetActive(true);

    }

    void CancelBuildingPlacement()
    {
        currentlyPlacing = false;
        placementIndicator.SetActive(false);
    }

    public void ToggleBulldoze()
    {
        currentlyBulldozering = !currentlyBulldozering;
        bulldozerIndicator.SetActive(currentlyBulldozering);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) 
            CancelBuildingPlacement();
        if(Time.time-lastUpdateTime > indicatorUpdateTime)
        {
            lastUpdateTime = Time.time;

            curIndicatorPos = Selector.instance.GetCurTilePosition();

            if(currentlyPlacing)
                placementIndicator.transform.position = curIndicatorPos;
            else if(currentlyBulldozering)
                bulldozerIndicator.transform.position = curIndicatorPos;

        }
        if(Input.GetMouseButtonDown(0) && currentlyPlacing)
        {
            PlaceBuilding();
        }
        else if(Input.GetMouseButtonDown(0) && currentlyBulldozering)
        {
            Bulldoze();
        }
    }

    void PlaceBuilding()
    {
        GameObject buildingObj = Instantiate(curbuildingPreset.prefab, curIndicatorPos, Quaternion.identity);
        City.instance.OnPlaceBuilding(buildingObj.GetComponent<Building>());
       
    }

    void Bulldoze()
    {
        Building buildingToDestory = City.instance.buildings.Find(x => x.transform.position == curIndicatorPos);

        if(buildingToDestory != null)
        {
            City.instance.OnRemoveBuilding(buildingToDestory);
        }
    }

}
