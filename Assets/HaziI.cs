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
         ;
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
        */

        // Kerek�t�s: -felsele, -lefele, -ide oda

        float a = -5.945f;

        Debug.Log(BreakPointForRound(a)); //a.5 nek kell lennie, mindig pozitiv halmazban
        // 5.5f Ok| 5.5f Ok | 5.5f OK | 5.5f ok | 5.5f ok | 5.5f ok | 5.5f ok | 5.5f ok

        Debug.Log(prepareToBeRoundedUp(a)); // egy felfele kerek�tend� sz�mot el�k�sz�t arra, hogy +1 et adjak hozz�
        //5.0f Ok | 5.0f Ok | 5.0f Ok | 5 ok    | 5 ok    | 5 ok    | 5.0f ok | 5.0f ok

        Debug.Log(Fel(a)); // felfele kerek�t� f�ggv�nyem
        // 6 Ok   | 6 Ok    | 6 Ok    | 5 ok    | -5 ok   | -6 ok   | -6  ok  | -6 !! -6 lett!!

        Debug.Log(Mathf.Ceil(a)); // sima felfele kerek�t�s 
        //6 Ok    | 6 Ok    | 6 OK    | 5 ok    | -5 ok   | -6 ok   | -6  ok  | -6 !!-5 lett!!
         

        


    }
    float prepareToBeRoundedUp(float a)
    {
        float abs = myAbszolutFunction(a); //PL: |-3.4|;-> 3.4
        int b = (int)abs;                 //3.4f -> 3    
        float c = (float)b;        // 3-> 3.0f
        return c;

    }
    
    float BreakPointForRound(float a)  //Ehhez viszony�tva d�nt�nk a kerek��sr�l
    {
        float abs = myAbszolutFunction(a); //PL: |-3.4|;-> 3.4
        int b = (int)abs;                 //3.4f -> 3    
        float c = (float)b + 0.5f;        // 3-> 3.0f+0.5f -> 3.5f
        return c; // 3.5f A bevitt sz�m holtpontt� alak�tott �rt�kben, de abszol�t �rt�kben. (negat�v sz�mot k�s�bb negat�vv� kell tenni)
    
    }
    float Fel(float a )      // k�t megold�s lehets�ges: eg�sz �rt�ken t�li marad�kkal val� m�veletek; int alak +/-1
    {
        float b = myAbszolutFunction(a); //ak�rmilyen is a (pl.:-3.5) az abszol�t �rt�k�t vessz�k.-> 3.5
        float c = mySignFunction(a);    // az adott �rt�knek vessz�k az el�jel�t. L�nyeg�ben - vagy +.

        if (a == (int)a)
        {
            return a;
        }
        else
        {
            return (prepareToBeRoundedUp(a) + 1) *c;

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
