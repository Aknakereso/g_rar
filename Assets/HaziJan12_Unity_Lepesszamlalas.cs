
using UnityEngine;

public class HaziJan12_Unity : MonoBehaviour
{

    

    
    //L�p�ssz�ml�l�s feladat
     [Space]
    [SerializeField] Vector3 a, b; // B
    [SerializeField] Vector3 singleUnit; // B
   // K  [SerializeField] Vector3 jumpLength; 
    [SerializeField] float jumpAmount;   //K
    [SerializeField] float jumpAmountInGeneral;  // K: kihagyjuk a tetsz�legesen megadott ugr�shosszt.




    private void Start()
    {
        



    }
    private void OnValidate()
    {
        float aLength = a.magnitude;
        float bLength = b.magnitude;
        Vector3 c = b - a;
        
       //   jumpLength = c / 2; // kivettem, szerintem buta m�velet

        float route = c.magnitude;
        float jumpCustom = singleUnit.magnitude;


        jumpAmountInGeneral = (bLength - aLength) / aLength;  // amikor nem vessz�k sz�m�t�sba a tesz�legesen megadott l�p�snagys�got.

        jumpAmount = route / jumpCustom;

        // 





    }

    


    // Update is called once per frame
    void Update()
    {
        

    }
    
}
