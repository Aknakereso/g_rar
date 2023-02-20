
using UnityEngine;

public class HaziJan12_Unity : MonoBehaviour
{

    

    
    //Lépésszámlálás feladat
     [Space]
    [SerializeField] Vector3 a, b; // B
    [SerializeField] Vector3 singleUnit; // B
   // K  [SerializeField] Vector3 jumpLength; 
    [SerializeField] float jumpAmount;   //K
    [SerializeField] float jumpAmountInGeneral;  // K: kihagyjuk a tetszõlegesen megadott ugráshosszt.




    private void Start()
    {
        



    }
    private void OnValidate()
    {
        float aLength = a.magnitude;
        float bLength = b.magnitude;
        Vector3 c = b - a;
        
       //   jumpLength = c / 2; // kivettem, szerintem buta mûvelet

        float route = c.magnitude;
        float jumpCustom = singleUnit.magnitude;


        jumpAmountInGeneral = (bLength - aLength) / aLength;  // amikor nem vesszük számításba a teszõlegesen megadott lépésnagységot.

        jumpAmount = route / jumpCustom;

        // 





    }

    


    // Update is called once per frame
    void Update()
    {
        

    }
    
}
