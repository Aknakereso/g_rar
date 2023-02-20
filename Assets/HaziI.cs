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


         // Kerekítés: -felfele, -lefele, -ide oda


                 float x = -2.0f;


         Debug.Log(myFinalFel(x)); //Remekül mûködik
         Debug.Log(Mathf.Ceil(x));

         Debug.Log(myFinalLe(x)); // Remekül mûködik
         Debug.Log(Mathf.Floor(x));

         Debug.Log(myFinalRound(x)); // Remekül mûködik
         Debug.Log(Mathf.Round(x));

       */
        /*
         // Pitagoraszi számhármast kiderítõ függvény (bool): három szám: a négyzeten + b négyzeten = c a négyzeten

         float a = 9;
         float b = 16;
         float c = 25;


         Debug.Log(myPitTrio(a,b,c)); // elég okésan mûködik.

       */


        /*     // Egy függvény mely két bevitt szám közös osztóját adja vissza.
          int a = 56;
          int b = 20;

          Debug.Log(myUltimateDividerSearcher(a, b));  // pozitívban és negatívban is jól mûködik. Kevert értéknél (- és +) 0 t ír ki.
       */


        // n = x számjegyeinek összege, vagyis 5 = 23-> 2+3 = 5

        //int a = 34;

        //myNumberTagSummer(a); // 5

      







    }
    int mySumTheValuesOfTheGivenNumber(int a)
    {

        return a;
    
    
    }
  
    int myUltimateDividerSearcher(int a, int b) // O.K.
    {
        float i;

        float aa = (float)a;
        float bb = (float)b;
        
        float Higher = Mathf.Max(a, b);
        float Lesser = Mathf.Min(a, b);

        

        if (a < 0 && b < 0)
        {
            for (i = Lesser; i <= 0; i++)
            {
                if (Higher % i == 0 && Lesser % i == 0)
                {
                    return (int)i;
                }

            }

        }
        else 
        { 
            for (i =Lesser; i >=0;i-- )
            {
              if (Higher % i == 0 && Lesser % i ==0)
              {
                return (int) i;
              }
      
            }

        }
        return 1;
        
    
    }
    bool myPitTrio(float a, float b, float c)  // O.K.
    {
        

        if (a < 0 || b < 0 || c < 0)
        {
            return false;

        }
        else if (a * a + b * b == c * c)
        {
            return true;
        }
        else if (b * b + c * c == a * a)
        {
            return true;

        }
        else if (c * c + a * a == b * b)
        {
            return true;

        }
        else
        {
            return false;
        }

    }

    float myFinalLe(float a)   // O.K.
    {
        float b = (float)(int)a;

        if (a < 0 && a < b)
        {

            
            return b-1;

        }
        else
        {
            
            return b;
        }
   
    }
  
    
    float myFinalRound(float a)  //O.K.
    {
        float maradek;
        float hiany;
        float bNeg = (float)((int)a) - 0.5f;
        float bPoz = (float)((int)a) + 0.5f;

        if (a <  bNeg)  
        {
            maradek = -a % 1;
            hiany = 1 - maradek;

            return a - hiany;
        }
        else if (a >=  bPoz)
        {
            maradek = a % 1;
            hiany = 1 - maradek;

            return a + hiany;
        }
        else
        {
            return (float)(int)a;
        }


    }
    float myFinalFel(float a)  //O.K.
    {
        float b = (float)(int)a;
        if (a > b && a > 0)
        {
            return b + 1;
        }
        else
        {
            return (float)(int)a;
        }
      
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
    {  //egyszerûbb:
        if (a < 0)
        {
            return -1;
        }
        else 
        {
            return 1;        
        }



        /*Én  megoldásom:
        if  (a < 0)
        {
            return -(a / a);
        }
        else 
        {
            return a / a;
        } 
        */
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
