
using UnityEngine;

public class Lepesszamlalas : MonoBehaviour
{   

    [SerializeField] Vector2 a;
    [SerializeField] Vector2 b;   
    [SerializeField] Vector2 jumpArbitrary;
    [Space]
    [SerializeField] int stepsToReachFinish;
    [SerializeField] Vector2 stepValueToJump;




    void OnValidate()
    {
        Vector2 cRouteV = b - a;
        float cRouteS = (b - a).magnitude; // táv

        float arbitraryJumpFloat = jumpArbitrary.magnitude;

        stepsToReachFinish =(int)(cRouteS / arbitraryJumpFloat);
        stepValueToJump = cRouteV / stepsToReachFinish;
       








    }
    void Update()
    {
        

    }  
}
