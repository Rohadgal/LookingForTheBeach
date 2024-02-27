using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public GameObject prefab; // The prefab to be pooled
    public int poolSize = 2; // The initial size of the object pool
    public float spawnDistance = 20f; // Distance at which objects will be spawned

    private List<GameObject> objectPool = new List<GameObject>();
    private Transform playerTransform;

    float randomX;
    float randomY;
    float spawnZ;

    void Start() {
        playerTransform = Camera.main.transform; // Assuming the camera follows the player

        randomX = 2.0f; // Random.Range(-5f, 5f); // Adjust th
        randomY = 1.4f; // You may adjust the Y position if ne
        spawnZ = playerTransform.position.z - (spawnDistance * 1.75f);
        // Initialize the object pool
        InitializeObjectPool();
    }

    void Update() {
        // Check if any objects need to be recycled
        RecycleObjects();
    }

    void InitializeObjectPool() {
        for (int i = 0; i < poolSize; i++) {
            GameObject obj = Instantiate(prefab, GetRandomSpawnPosition(), Quaternion.identity);
            obj.SetActive(true);
            objectPool.Add(obj);
        }
    }

    void RecycleObjects() {
        foreach (GameObject obj in objectPool) {
            // Check if the object is behind the player and can be recycled
            if (obj.activeSelf && obj.transform.position.z < playerTransform.position.z - spawnDistance) {
                obj.SetActive(false); // Deactivate the object
                obj.transform.position = GetRandomSpawnPosition(); // Reposition for the next use
                return;
            }
        }
    }

    Vector3 GetRandomSpawnPosition() {
        // Calculate a random spawn position within the spawnDistance range
        spawnZ += spawnDistance;

        return new Vector3(randomX, randomY, spawnZ);
    }

    // Function to retrieve an object from the pool
    public GameObject GetPooledObject() {
        foreach (GameObject obj in objectPool) {
            if (!obj.activeSelf) {
                obj.SetActive(true);
                return obj;
            }
        }

        //// If all objects are in use, expand the pool by creating a new object
        //GameObject newObj = Instantiate(prefab, GetRandomSpawnPosition(), Quaternion.identity);
        //newObj.SetActive(false);
        //objectPool.Add(newObj);

        //return newObj;
        return null;
    }
}
