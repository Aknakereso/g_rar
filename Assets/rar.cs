using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Értékcsere trükkösen: 2 számadat helyet cserél.



        /* String értékcsere
        string ALMA = "alma";
        string KORTE = "korte";


        KORTE = KORTE.Replace("korte", "alma");

        ALMA = ALMA.Replace("alma", "korte");
        Debug.Log($"{ KORTE } - { ALMA}");
        
        Int-tel:

        int z = 21;
        int u = 3;
        int temp; 
        temp = z;  //z azaz 21
        z = u;
        u = temp;
        Debug.Log($"z={z} _u= {u}");
        

        // Prím-e a szám, amit megadunk? Ha 10 nél nagyobb a szám, 7 nél nagyob számmal osztani felesleges.
       
        int NumberToCheck =9 ;  
        bool prime = true;
        for (int checkingValue = 2; checkingValue < NumberToCheck; checkingValue++ ) // a számítási sorozat nem megy el addig, hogy a megadott számot magával osszuk , mert mindenképp primet kapnánk.
        {

            if (NumberToCheck % checkingValue == 0)
            {
                prime = false;
            }
            
            
        }

         Debug.Log($"A {NumberToCheck} szám prím?:" + prime);
       
          A fentebbi Prím keresõs program rendben van.
        */


        //jan 28.: Saját abszolútérték és elõjelfüggvény.
        //Normál esetben ezek használatosak:
        int r = -32;
        float rAbs = Mathf.Abs(r);


        int z = 333;
        float zSign = Mathf.Sign(z); //1


        int zn = -553;
        float znSign = Mathf.Sign(zn); //-1

        //saját:
        float s = -10;
        float sC = MyAbszoluut(s);
        Debug.Log(sC);



        float sI = 20;
        float sIC = MyElojel(sI);
        Debug.Log(sIC);

        float sII = -30;
        float sIIC = MyElojel(sII);
        Debug.Log(sIIC);

        /*Clampelés. Példa:  Feladat: -Saját Clamp függvény. - Saját, egyedi speciális Clapm függvény mely akármilyen megadott számot 0 és 1 es közé tesz.
        float examlpeClamp = Mathf.Clamp(0,0.1f,1);
        Debug.Log(exampleClamp);
        */
        float vI = 42.2f, vII = 18.4f, vIII = 6;   // KORRIGÁLÁSRA SZORUL!!!
        float nMid = Mathf.Clamp(vI,vII,vIII);
        Debug.Log(nMid);


    }
    float MyAbszoluut(float n)
    {/*
        if (n < 0)
        { return n *= -1; }
        else return n; 
        
     */
        return n < 0 ? n *= -1 : n;

    }
    float MyElojel(float n)
    {
     /*
        if (n < 0)
        {

            return (n / n) * -1;
        }
        return n / n;
     */

        return n < 0 ? (n / n) * 1 : n / n; 

    }
    float MyVeryOwnClampFunction(float a, float b, float c) // !!! JAVÍTÁSRA SZORUL!!! 
    {
        float errorNum = 404.404f;

        bool aMid = a > b && a < c; //a
        bool bMid = b > a && b < c; //b
        bool cMid = c > a && c < b; //c


        if (aMid || !aMid)
        {
            return a;
        }
        else if (bMid || !bMid)
        {
            return b;
        }
        else if (cMid || !cMid)
        {
            return c;
        }
        else { return errorNum; }
    
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
