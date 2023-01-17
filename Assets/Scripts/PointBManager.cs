using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBManager : MonoBehaviour
{
    [SerializeField] private List<Transform> _wayPoints = new List<Transform>();
    GameObject pointA;
    GameObject newObject;

    void Start()
    {
        pointA = GameObject.Find("Point A");
    }

    void OnMouseDown()
    {
        StartCoroutine(SpawnCubes());
    }

    private IEnumerator SpawnCubes()
    {
        newObject = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity);
        float u = 0f;
        while(u<=1f)
        {
            newObject.transform.position = Vector3.Lerp(gameObject.transform.position, pointA.transform.position, u);
            u += Time.deltaTime * 0.12f;
            yield return null;
        }
        Destroy(newObject);
    }
}
