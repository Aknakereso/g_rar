using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaziI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //_____ H�zi Feladat Janu�r 28 (szombat)____
        // !! a funkci�k l�trehoz�si sorrendje lentr�l felfele zajlik.

        // Abszol�t�rt�k �s el�jel f�ggv�nyek k�sz�t�se
        // -float bemenet, float kimenet

        //operandusok:
        /*

         float b = 12.5f;
         float resultInner;
         float resultMine;

         // saj�t Abszol�t f�ggv�nyem:
         resultMine = myAbszolutFunction(b);
         Debug.Log(resultMine);

         // Be�p�tett absz f�ggv�ny:

         resultInner = Mathf.Abs(b);
         Debug.Log(resultInner);


         // El�jelf�ggv�ny:


         //operandusok:
         float a = -34.5f;
         float resultInner;
         float resultMine;

         //saj�t El�jelf�ggv�ny:
         resultMine = mySignFunction(a);
         Debug.Log(resultMine);

         //G�pi f�ggv�ny:

         resultInner = Mathf.Sign(a);
         Debug.Log(resultInner);
        */


        // Saj�t Clamp f�ggv�ny: Clamp(megadott sz�m, min, max)   -Egy speci�lis Clamp01 f�ggv�ny k�sz�t�se, ami 0 �s 1 k�z� "helyezi" a sz�mot
        /*
         // operandusok:

         float a = 0.10f;
         float b = -4;
         float c = -100;

         float res;
         //saj�t Clamp f�ggv�ny:
         res = myAdvancedClampFunction(a,b,c);
         Debug.Log(res);

         //saj�t "buta" clamp f�ggv�nyem:
         res = myBasicClamp(a, b, c);
         Debug.Log(res);

         //G�pi f�ggv�ny:
         res = Mathf.Clamp(a,b,c);
         Debug.Log(res);

         //speci�lis Clamp f�ggv�ny:
         res = Clamp01(a);
         Debug.Log(res);


         // Kerek�t�s: -felfele, -lefele, -ide oda


                 float x = -2.0f;


         Debug.Log(myFinalFel(x)); //Remek�l m�k�dik
         Debug.Log(Mathf.Ceil(x));

         Debug.Log(myFinalLe(x)); // Remek�l m�k�dik
         Debug.Log(Mathf.Floor(x));

         Debug.Log(myFinalRound(x)); // Remek�l m�k�dik
         Debug.Log(Mathf.Round(x));

       */
        /*
         // Pitagoraszi sz�mh�rmast kider�t� f�ggv�ny (bool): h�rom sz�m: a n�gyzeten + b n�gyzeten = c a n�gyzeten

         float a = 9;
         float b = 16;
         float c = 25;


         Debug.Log(myPitTrio(a,b,c)); // el�g ok�san m�k�dik.

       */


        /*     // Egy f�ggv�ny mely k�t bevitt sz�m k�z�s oszt�j�t adja vissza.
          int a = 56;
          int b = 20;

          Debug.Log(myUltimateDividerSearcher(a, b));  // pozit�vban �s negat�vban is j�l m�k�dik. Kevert �rt�kn�l (- �s +) 0 t �r ki.
       */


        // n = x sz�mjegyeinek �sszege, vagyis 5 = 23-> 2+3 = 5

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
    {  //egyszer�bb:
        if (a < 0)
        {
            return -1;
        }
        else 
        {
            return 1;        
        }



        /*�n  megold�som:
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
        //megold�s I:
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
