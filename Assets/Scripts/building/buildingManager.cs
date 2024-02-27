using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingManager : MonoBehaviour
{
    buildingPool buildingPool;
    // Start is called before the first frame update
    void Start()
    {
        buildingPool = buildingPool.instance;
    }

    // Update is called once per frame
    void Update()
    {
        buildingPool.recycleObject();
    }


}
