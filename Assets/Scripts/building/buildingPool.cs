using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class buildingPool : MonoBehaviour
{
    public static buildingPool instance;

    [SerializeField]
    GameObject[] buildings;
    public Queue<GameObject> buildingsPool;
   // Queue<GameObject> recycledBuildings;
    //Transform spawnPos;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
       //spawnPos = this.transform;
       initializeObjectPooling();
    }


    void initializeObjectPooling() {
        buildingsPool = new Queue<GameObject>();
        //recycledBuildings = new Queue<GameObject>();

        foreach (var building in buildings) {
            buildingsPool.Enqueue(building);
            //building.transform.position = this.transform.position;
        }
       

        //foreach (var building in buildingsPool) {
        //    Instantiate(building);
        //}
    }

    public void recycleObject() {
        
        foreach (GameObject building in buildingsPool) {
            float disappearPos = -10.0f;
            //Debug.Log("this");
            Vector3 worldPos = building.transform.position; 
            //Debug.Log("pos: " + worldPos);
            if (building.transform.position.z < disappearPos) {
                Debug.Log("that");
                building.SetActive(false);
                //buildingsPool.Dequeue();
                //buildingsPool.Enqueue(building);

            }
        }
        
    }
}
