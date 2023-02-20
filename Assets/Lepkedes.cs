
using UnityEngine;

public class Lepkedes : MonoBehaviour
{
    [SerializeField] Vector2 speedVector;
    [SerializeField] float boost;


    // Start is called before the first frame update
    void Start()
    {
        
        // feladat: Lepkedes.
        // program mely gomb lenyom�sakor l�pked a be�ll�tott ir�nyba
        // kell: bool gombbemenet lek�r�se
        // kell a bemeneteket �rt�kk� tenni ha bool-> �rt�k.
        // bool: InputGetKey(KeyCode.gomb); if(bool){koordin�ta �rt�ket kap} Vector2-k �s transform.position-ok

    }

    // Update is called once per frame
    void Update()
    {  // bemenetek lek�rdez�se
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);


        // A vektoroknak tengelyeik vannak, azokhoz pedig �rt�k kell,
        int x = 0;
        int y = 0;


        if (up) { y++; }
        if (down) { y--; }
        if (right) { x++; }
        if (left) { x--; }


        // a Vector2 megvan, de csak ir�nyt kell jel�lnie: normaliz�l�s: DirectV2.normalized; / DirectV2.Normalize();
        Vector2 DirectV2 = new Vector2(x,y);
        DirectV2.Normalize();


        //Vektor, = objektum poz�ci�j�val. || ez * Time.deltaTime * boost * speedVector

        Vector2 objectPos = transform.position;
        objectPos += DirectV2 * boost* Time.deltaTime;
        transform.position = objectPos; // az objektumom poz�ci�j�t mindig az aktu�lis hely�vel teszem egyenl�v�.

        






    }
}
