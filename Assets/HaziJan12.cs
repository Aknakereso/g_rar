using System.Collections.Generic;
using UnityEngine;

public class HaziJan12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* T�k�letes sz�mok: pipa
         * m�k�dik: 1 es,0 ra, negat�v sz�mokra



          int a = -28;
          Debug.Log(isYourNumberPerfect(a));

          int b = 8128;
          Debug.Log(isYourNumberPerfect(b));

          int c = 496;
          Debug.Log(isYourNumberPerfect(c));

          Debug.Log(myNumberDividerBool(a));  false maert negat�v volt
          Debug.Log(myNumberDividerBool(b));  true
          Debug.Log(myNumberDividerBool(c));  true
       */


        // Bin�ris �talak�t�: O.K.
        
        /*    
        int binput = 0001101010;

        Debug.Log(myBinaryConverter(binput));  
        */
       

        /*  N x N feladat: O.K.


        
         

        int n = 39;
        Debug.Log(myDigitAdditioner(n)); // minuszban is m�k�dik, szerintem nem kell abszol�t �s el�jel f�ggv�ny
       
        int N = 22;
        myAnswerToN(N);  //39 //Hiba lehet�s�gek: -az if el�gaz�sb�l "nem j�n ki" az "answer" �rt�ke
                                         //                   - vagy az answer  �rt�ke 0

         
        */
        



    }

    void myAnswerToN(int N)
    {
        float absN = Mathf.Abs(N);
        float signN = Mathf.Sign(N);
        N = (int)absN;


        int i;
        int foundOne = 0;
        for (i = 0; foundOne <= 2; i++)
        {

            if (myDigitAdditioner(i) == N)
            {
                Debug.Log(i);
                break;

            }

        }
    }
    int myDigitAdditioner(int N)
    { 
        

         int NfromPieces = 0;  // bent van a 'for' ban

        string stringN = N.ToString();
        int lengthN = stringN.Length;  // 4
        int intN = int.Parse(stringN);

        for (int i = 1; i <= lengthN; i++) 
        {
        int slashedN = intN % 10;
        

         NfromPieces += slashedN;
           

         intN /= 10;
         
        }
        return NfromPieces;
    
    }
    int myBinaryConverter(int binput) // j�l m�k�dik
    { 
    
        int maradek = 0;
        int osszegzo = 0;
        int szamsor = 1;


        string binputString = binput.ToString();
        binputString = binputString.TrimStart('0',' ',' '); //110101

        float binputStringLength = binputString.Length;   // 6

        int binputTrimmed = int.Parse(binputString);        //110101



        if (myPreCheck(binput) == true)   //  000110101  true
        {

            for (int i = 1; i <= binputStringLength; i++)
            {
                maradek = binputTrimmed % 10;   // 
                osszegzo += maradek * szamsor;   //+ 1*1 ; 0*2 ; 1*4 ; 0* 8 ; 1* 16 ; 1* 32


                binputTrimmed /= 10;
                szamsor *= 2;

            }
            return osszegzo;  // 

        }
        else
        {
            return 0;
        }
    
    }
    bool myPreCheck(int a)  // �gy t�nik remekel | A bin�ris konvert�l� r�sze
    {
        string aString = a.ToString();
        aString = aString.TrimEnd(' ',' ','0');
        float aStringLength = aString.Length;

        int aInt = int.Parse(aString);


        int remained = 0;
        
       for(int i = 0;i <= aStringLength; i++)
       {
            remained = aInt  % 10;
            aInt /= 10;
            if (remained > 1)
            {

                break;          
            }
         
       }
        return remained <= 1;
        
    
    }
    string isYourNumberPerfect(int a) // 1@ remek
    {

        string perfect = $"Your number {a} is Perfect!";
        string nPerfect = $"Your number {a} is NOT perfect!";

        int WorkCopya = Mathf.Abs(a);   //ha negat�v lenne, + ne t�veszt�dj�n �ssze saj�t mag�val v�letlen�l
        int simpleCopya = Mathf.Abs(a);



        if (WorkCopya == 1 || WorkCopya == 0)
        {
            return perfect;


        }
        else if (myNumberDivider(WorkCopya) == simpleCopya)
        {
            return perfect;

        }
        else
        {
            return nPerfect;
        }
    



    }
    int myNumberDivider(int a) // remek
    {
        int aAbs = Mathf.Abs(a);
        int iSummer = 0;
        for (int i = a-1;i >0; i--)
        {
            if (a % i == 0)
            { 
            iSummer += i;
            }
                      
        }
        return iSummer;
        
    }
    bool myNumberDividerBool(int a) // remek, Boolt ad vissza
    {
        int aAbs = Mathf.Abs(a);
        int iSummer = 0;
        for (int i = a - 1; i > 0; i--)
        {
            if (a % i == 0)
            {
                iSummer += i;
            }

        }
        return iSummer ==a;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
