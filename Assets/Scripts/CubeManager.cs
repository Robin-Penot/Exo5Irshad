using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{

    [SerializeField] private List<Transform> _wayPoints = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        StartCoroutine(SpawnCubes());
    }

    private IEnumerator SpawnCubes()
    {
        foreach(Transform _wayPoint in _wayPoints)
        {
            GameObject newObject;
            newObject = Instantiate(gameObject, _wayPoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2);
            Destroy(newObject);
        }
    }
}
