using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBManager : MonoBehaviour
{
    [SerializeField] private List<Transform> _wayPoints = new List<Transform>();
    GameObject newObject;
    Rigidbody rb;
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
        newObject = Instantiate(gameObject, gameObject.transform.position, Quaternion.identity);
        foreach(Transform _wayPoint in _wayPoints)
        {
            yield return new WaitForSeconds(2);
           rb =  newObject.GetComponent<Rigidbody>();
        }
    }
}
