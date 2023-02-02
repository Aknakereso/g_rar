using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaziI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //_____ Házi Feladat Január 28 (szombat)____
        // !! a funkciók létrehozási sorrendje lentrõl felfele zajlik.

        // Abszolútérték és elõjel függvények készítése
        // -float bemenet, float kimenet

        //operandusok:
        /*
         ;
        float b = 12.5f;
        float resultInner;
        float resultMine;

        // saját Abszolút függvényem:
        resultMine = myAbszolutFunction(b);
        Debug.Log(resultMine);

        // Beépített absz függvény:

        resultInner = Mathf.Abs(b);
        Debug.Log(resultInner);
        

        // Elõjelfüggvény:


        //operandusok:
        float a = -34.5f;
        float resultInner;
        float resultMine;

        //saját Elõjelfüggvény:
        resultMine = mySignFunction(a);
        Debug.Log(resultMine);

        //Gépi függvény:

        resultInner = Mathf.Sign(a);
        Debug.Log(resultInner);
        */

        
        // Saját Clamp függvény: Clamp(megadott szám, min, max)   -Egy speciális Clamp01 függvény készítése, ami 0 és 1 közé "helyezi" a számot
        /*
        // operandusok:

        float a = 0.10f;
        float b = -4;
        float c = -100;

        float res;
        //saját Clamp függvény:
        res = myAdvancedClampFunction(a,b,c);
        Debug.Log(res);

        //saját "buta" clamp függvényem:
        res = myBasicClamp(a, b, c);
        Debug.Log(res);

        //Gépi függvény:
        res = Mathf.Clamp(a,b,c);
        Debug.Log(res);

        //speciális Clamp függvény:
        res = Clamp01(a);
        Debug.Log(res);
        */

        // Kerekítés: -felsele, -lefele, -ide oda




        




    }

    float Clamp01(float a) //O.K.
    {
        if (a >= 1)
        {
            return 1;
        }
        else if (a <= 0)
        {
            return 0;
        }
        else
        {
            return a;
        }
      
    
    
    
    }
    float myBasicClamp(float a, float b, float c) // O.K.
    {
        if (a <= b)
        {
            return b;
        }
        else if (a >= c)
        {
            return c;

        }
        else
        {
            return a;
        }

    }
    
    float myAdvancedClampFunction(float a, float b, float c)  //O.K.
    {
        if (b > c)
        {
            float storage = b;
            b = c;
            c = storage;

          return  myBasicClamp(a, b, c);

        }
        else   
        {
          return  myBasicClamp(a, b, c);
            
        }
    
    
    }




    float mySignFunction(float a) // O.K.
    {  
        if  (a < 0)
        {
            return -(a / a);
        }
        else 
        {
            return a / a;
        } 
    }

    float myAbszolutFunction(float a) // O.K.
    { 
        //megoldás I:
        if (a < 0)
        {
            return -a;
        }
        else
        {
            return a;   
        }   
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
