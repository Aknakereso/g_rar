
using UnityEngine;

public class LepkedesII : MonoBehaviour
{
    
    


    void Update()
    {

        if(Input.GetKeyDown(KeyCode.UpArrow))
        { transform.position += Vector3.forward;     }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        { transform.position += Vector3.back;        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        { transform.position += Vector3.right;       }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        { transform.position += Vector3.left;        }

        //GetKeyDown = akkor mozog az objektum, ha lenyomtuk a gombot, de megint meg kell a tov�bbi mozg�shoz.
        //GetKey = meg/lenyomvatartva mozog az obj.,felenged�skor meg�ll
        //GetKeyUp = ua, csak felenged�skor l�p az objektum egyszer, annyit amennyi be�ll�tott

        //   !! "szaggatott " l�pked�sn�l nem ad hozz� a Time.deltaTime

    }
    
        
}
