
using UnityEngine;

public class Lepkedes : MonoBehaviour
{
    [SerializeField] Vector2 speedVector;
    [SerializeField] float boost;


    // Start is called before the first frame update
    void Start()
    {
        
        // feladat: Lepkedes.
        // program mely gomb lenyomásakor lépked a beállított irányba
        // kell: bool gombbemenet lekérése
        // kell a bemeneteket értékké tenni ha bool-> érték.
        // bool: InputGetKey(KeyCode.gomb); if(bool){koordináta értéket kap} Vector2-k és transform.position-ok

    }

    // Update is called once per frame
    void Update()
    {  // bemenetek lekérdezése
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);


        // A vektoroknak tengelyeik vannak, azokhoz pedig érték kell,
        int x = 0;
        int y = 0;


        if (up) { y++; }
        if (down) { y--; }
        if (right) { x++; }
        if (left) { x--; }


        // a Vector2 megvan, de csak irányt kell jelölnie: normalizálás: DirectV2.normalized; / DirectV2.Normalize();
        Vector2 DirectV2 = new Vector2(x,y);
        DirectV2.Normalize();


        //Vektor, = objektum pozíciójával. || ez * Time.deltaTime * boost * speedVector

        Vector2 objectPos = transform.position;
        objectPos += DirectV2 * boost* Time.deltaTime;
        transform.position = objectPos; // az objektumom pozícióját mindig az aktuális helyével teszem egyenlõvé.

        






    }
}
