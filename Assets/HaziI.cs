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
        
                float x = -2.5f;


        //  Debug.Log(myBeginnerFel(a)); //O.K.

        //  Debug.Log(myAdvancedFel(a)); // O.K.

        //  Debug.Log(myMasterFel(a));  // O.K.
        //  Debug.Log(myLe(a));     //O.K



        Debug.Log(myFinalRound(x));// -2.5 -> -4
                Debug.Log(Mathf.Round(x)); 


                

                


        // Pitagoraszi sz�mh�rmast kider�t� f�ggv�ny (bool): h�rom sz�m: a n�gyzeten + b n�gyzeten = c a n�gyzeten

        float a = 2.45f;
        float b = 3;
        float c = 4;
        

        //Debug.Log(myPitTrio(a,b,c));
       
        //Soulslike feladatok:
        // Egy f�ggv�ny mely k�t bevitt sz�m k�z�s oszt�j�t adja vissza.


        


    }
    float myUltimateDividerSearcher(float a, float b)
    {
        /*float[] osztok;

        float maxN = Mathf.Max(a, b);
        float minN = Mathf.Min(a,b);
        float equalNI;
        float equalNII;

        

        if (a == b)
           {
                return a;
           }

        for (float i =minN; minN==0; minN--)
        {
            if (minN % i ==0 )
            {
                var osztokLista = new List<float>() { i };
                osztok = new float[] { +i };

                return Mathf.Max(osztok);
            }
       
        }
    */
        return a + b; //ez kamu return
    
    }
    bool myPitTrio(float a, float b, float c)
    {
        if (a * a + b * b == c * c)
        {
            return true;
        }
        else if (b * b + c * c == a * a)
        {
            return true;
        }
        else if (a * a + c * c == b * b)
        {
            return true;
        }
        else
        { 
            return false;
        } 

    }

    float myLe(float a)
    {
        int b;
        if (a < 0)
        {

            b = (int)a;
            return (float)b-1;

        }
        else
        {
            b = (int)a;
            return (float)b;
        }
   
    }
  
    float myRound(float a) // Megn�zettetni!!
    {
        if (a < 0 && a > (float)(int)a + 0.5 || a > 0 && a < (float)(int)a + 0.5)  //negat�vokra �s pozit�cvokra, hogy int-hez hasonl� eg�sz alakjuk legyen
        {
            return (float)(int)a;


        }
        else if (a < 0 && a <= (float)(int)a + 0.5)  //negat�vokra lefelekerek�t�s
        {
            return (float)(int)a - 1;


        }
        else //pozit�vokra felfele kerek�t�s
        {
            return (float)(int)a + 1;
        
        }
        
    
    
    }
    float myFinalRound(float a) //leg�jabb f�ggv�ny
    {
        float maradek = a % 1;
        float hiany = 1 - maradek;

        if (a >= (float)(int)a + 0.5) // 
        {
            return a + hiany;
        }
        else if (a <= (float)(int)a - 0.5)
        {
            return a - hiany;
        }
        else
        {
            return (float)(int)a;
        }
    
    
    }


    float prepareToBeRoundedUp(float a)
    {
        float abs = myAbszolutFunction(a); 
        int b = (int)abs;                   
        float c = (float)b;        
        return c;

    }
    
    float BreakPointForRound(float a)  //Ehhez viszony�tva d�nt�nk a kerek��sr�l
    {
        float s = mySignFunction(a);
        float abs = myAbszolutFunction(a); //PL: |-3.4|;-> 3.4
        int b = (int)abs;                 //3.4f -> 3    
        float c = (float)b + 0.5f;        // 3-> 3.0f+0.5f -> 3.5f
        return c * s; // 3.5f A bevitt sz�m holtpontt� alak�tott �rt�kben, de abszol�t �rt�kben. (negat�v sz�mot k�s�bb negat�vv� kell tenni)
    
    }
    float myMasterFel(float a)
    {
        if (a > (int)a && a > 0)
        {
            return (float)(int)a + 1;
        }
        else
        {
            return (float)(int)a;
        }
      
    }
    float myAdvancedFel(float a)
    {
        float s = mySignFunction(a);
        if (a > (int)a)
        {
            a++;
            int b = (int)a;
            return (float)b * s;

        }
        else 
        {
            int b = (int)a;

            return (float)b;
        }

    
    }
    float myBeginnerFel(float a)  //negat�vra is m�k�dik
    {
        float b = myAbszolutFunction(a); 
        float c = mySignFunction(a);    

        if (a < 0)
        {
            return prepareToBeRoundedUp(a) * c;
        }
        else if (a == (int)a)
        {
            return prepareToBeRoundedUp(a);

        }
        else
        {
            return (prepareToBeRoundedUp(a) + 1) * c;
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
