
using UnityEngine;

public class LepkedesIIV : MonoBehaviour
{
    [SerializeField] Vector3 speedVector3;
    [SerializeField] float boost;


    void Update()
    {
        
        //Lépkedés fix sebességgel: 

        if (Input.GetKeyUp(KeyCode.UpArrow))
        { transform.position += Vector3.forward *   boost * Time.deltaTime * speedVector3.y; }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        { transform.position += Vector3.back    *   boost * Time.deltaTime * speedVector3.y; }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        { transform.position += Vector3.right   *   boost * Time.deltaTime * speedVector3.x; }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        { transform.position += Vector3.left    *   boost * Time.deltaTime * speedVector3.x; }


    }
}
