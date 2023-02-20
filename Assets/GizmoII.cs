
using UnityEngine;

public class GizmoII : MonoBehaviour
{

    
    [SerializeField] Color color;


    // Start is called before the first frame update
    void Start()
    {
      // Ez csak egy célpontkocka

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawWireCube(transform.position, Vector3.one);

    }


}

