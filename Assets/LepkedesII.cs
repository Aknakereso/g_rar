
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

        //GetKeyDown = akkor mozog az objektum, ha lenyomtuk a gombot, de megint meg kell a további mozgáshoz.
        //GetKey = meg/lenyomvatartva mozog az obj.,felengedéskor megáll
        //GetKeyUp = ua, csak felengedéskor lép az objektum egyszer, annyit amennyi beállított

        //   !! "szaggatott " lépkedésnél nem ad hozzá a Time.deltaTime

    }
    
        
}
