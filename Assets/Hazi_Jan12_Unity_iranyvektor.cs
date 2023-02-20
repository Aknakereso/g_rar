using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazi_Jan12_Unity_iranyvektor : MonoBehaviour
{
      // Iranyvektor a -b. O.K.


    [SerializeField] Vector3 a;
    [SerializeField] Vector3 b;
    [SerializeField] Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnValidate()
    {
        

        direction = myDirectionGiverBetweenTwoVectors(a, b);


    }

    Vector3 myDirectionGiverBetweenTwoVectors(Vector3 a, Vector3 b)
    {
        Vector3 direction = b - a;
        return direction.normalized;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
