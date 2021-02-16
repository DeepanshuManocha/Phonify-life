using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour
{
    private GameObject selectedPrefab;
    private GameObject spawnedPrefab;

    public void SetPrefab(GameObject prefabObject)
    {
        selectedPrefab = prefabObject;
        foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Alphabet") )
        {
            Destroy(gameObject);
            spawnedPrefab = null;
        }
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Player"))
        {
            if (spawnedPrefab == null)
            {
                spawnedPrefab = Instantiate(selectedPrefab) as GameObject;
                spawnedPrefab.transform.parent = g.transform;
                spawnedPrefab.transform.position = g.transform.position + Vector3.up * 0.1f;
                spawnedPrefab.transform.rotation = g.transform.rotation;
            }
        }
    }
}
