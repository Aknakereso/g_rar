using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Felfedezes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // !!!Metódust kell írni! Valószínû string et ír ki, és void lesz a tipus.
        // Írni egy metódust, mely visszaad egy olyan számot mely jegyeinek összege a viszonylagosan tetszõlegesen bevitt szám értéke.
        // Metódust kell írni!
        // -n-t paraméterben kapja meg a függvény. (Azaz nem "kívelrül)
        // - n = egy tetszóleges szám (én 0 és 27 közé szorítom).
        // - olyan szám kell mely számjegyeinek összege egyenlõ az n értékével.
        // - a beviteli és visszaadott érték mind int típus.
        // - csak az elsõ megtalált, megfelelõ szám kell !! Azaz egy érték !!

        // ? -pozitív n? -negatív n? -return || Debug.Log();?
        // Hogy lesz a metódusom akárhány helyiértékkel kompatibilis? 23-> 2 elem;
        // 4523-> 4 elem. Minden elem egy 'char'. Hogy fûzöm õket megfelelõ sorrendben össze?

        // @ Megoldások:
        // - 'for' függvény segítségével: 10 tõl felfele számlál a megfelelõ számig.
        // - (n-1) + 10; !! Ez a logika problémákhoz vezethet !!
        // - *extra: további számokat is talál: 10 tõl indul: -Elõször az egyesek száma növekszik 19-ig pl.
        //                                                    -Másodsoorban a tízesek értéke növekszik kilencig 99.
        //                                                    -Harmadsorban a százasoké kilencig 999.
        // -Meglehetne oldani Lista segítségével: Szám át stringbe,
        //                                        karakterei listába,
        //                                        ehhez adunk +1 helyiértéket, ami string és 0-ás indexbe kerül.
        //                                        A lista tartalmát átadom String-be.
        //                                        String-> int


        // [§] Ami kellhet:
        // -felfele számlálás 'for'
        // feltétel 'if'
        // -számjegyösszeadó program (function): int->string-> (lista) -> int
        // -egy speciális felfele számláló függvény 'if'-el, 'for'-al: Egyesek: 010-> 019; Tízesek: 019-> 099; Százasok: 099-> 999
        // -'int', -'String', -listák, -karakterek, -konvertálás,-char + array, clamp
        // - kellhet több function.


        /* Egy egyszerûbb feladat: String-> int / float




        string a = "caaabBbccc"; // helyettesítés:
        string b = "abcdefgh";

        */
        //   a.Length; nem nullával kezdi a számolást.- Ez int érték. - Az a = 10 elem.
        //   a.IndexOf("c"); 0-val kezdi a számolást. - Ez int érték. -
        //   a.Replace('c','x'); Ilyenkor minden az elemnek megfelelõ elemet kicserél a kívántra.
        //   a.Replace("ca","x"); Vagy string et helyettesítünk stringgel vagy char-t char al.
        //   a.Replace("ca","x"); pontos karakterek definiálása esetén elkerülhetjük a nem változtatni kívánt elemek változtatását
        //   a.Remove(1,8); eredmény: cc Egyel kezd, nem exkluzív a kiindulási ponttal, azaz azt is törli.
        //   a.Insert(9,"x"); caaabbbccxc  Úgy néz ki 0 val kezdi a számolást
        //   a.TrimStart('c','a','b'); A szöveg elejétõl kezdve sorra törli a kijelõlt elemeket Elõször c, majd a majd b
        //               némelyiket szóközzel kihagyhatjuk, azaz nem törnülk karaktert 
        //   a.TrimEnd('c',' ',' '); A végérõl csak a cket törölte, olyan mint a  xy.TrimStart();
        //   b.Trim('a','d','h'); : bcdefg lett. Kivelrül a kijelölt elemeket körbe levágja, lecuppantja

        //         Debug.Log(b.Trim('a','d','h'));




        // Ami nekünk fontos az az int vm = xystring.IndexOf("string");
        // és az int vmi = xy.Length;


        //Most jöjjön a Listázás:
        // -Listáknál alkalmazhatunk több, rugalmasabb megoldást, mint a Tömb nél. Tömb nél van: int[] nev = (int)nevii.Clone();
        // - Listánál van vmi.Clear(); és vmi.Sort();

        /*Deklarálás, Iterálás:
        List<int> pipa = new List<int>(); // Deklaráltunk és iteráltunk egy üres int-eket tartalmazó listát
        List<float> kefe = new List<float>(3); // Ebben az iterált listában 3 elem van. Mind 0.0f értékkel bír.
        List<string> fal = new List<string>() { "kukac", "1000" };  //ebben a listában két elem van a "kukac" és "1000".
        List<char> aprok = new List<char>() { 'a', 'r', 't', '7', '3' };
        */

        /*Bõvítsük a listát.
        List<int> boltiArak;
        boltiArak = new List<int>(3) { 1, 2, 546 };
        boltiArak.Add(3);
        boltiArak.Insert(0, 100);
        boltiArak.RemoveAt(1);
        boltiArak.Remove(273 + 273);
        foreach (int t in boltiArak)
        {
            //Debug.Log(t);

        }

        */



        /** TÖMBÖK: Array

        int[] kategorizációk = { 5, 3, 6, 2, 7, 1 };
        string[] kocsik = { "BMW", "Merci", "Trabant", "Lada", "Kutyafüle" };
        float[] membran = { 0.012f, 1.033f, 1.001f, 78.66f };
        kategorizációk[0] = 9; // a nulladik értéket kilencre váltottam

        int[] storage = new int[10]; // tíz tárhelyes raktárhely
        int f = storage.Length;
       // Debug.Log(f);

        for (int i = 0; i < f; i++)
        {
            storage[i] += 1 + i;
           // Debug.Log(storage[i]);


        }

        int[] guba = (int[])storage.Clone();
        int zttt = guba.Length;
        // Debug.Log(zttt);

        **/




        //felfele számláló metódus
        //myFelfeleszamlaloFunction();

        //felfeleszámláló function;

        // Ezek át lesznek nézve :
        // mySzamjegyOsszeadoMetodusom_Complex(11);  // 12?? 
        //mySzamjegyOsszeadoMethod(-7);



        //Megoldás a megoldás segítségével:

        //Debug.Log(myBevittSzamJegyeitOsszeadoFunction(216)); ; //9 O.K.



        // NxN feladat:
        // N = 36        9999


      //  myTagSummerMethod(16); //79     O.K.
        



    }
    void myTagSummerMethod(int a)
    { 
    
        int oneHasBeenFound = 0;

        for (int i = 9; oneHasBeenFound <= 3; i++)
        {
            

            if (myBevittSzamJegyeitOsszeadoFunction(i) == a)
            {
                Debug.Log(i);
                oneHasBeenFound++;
            
            }
        
        }
    
    
    }


    int myBevittSzamJegyeitOsszeadoFunction(int a)
    {
        int szamjegyOsszegzo = 0;

        bool nincsMegASzamjegyosszeadas = true;

        while (nincsMegASzamjegyosszeadas)
        {
            int egyeseketElvesszuk = a % 10;

            a = a / 10;

            szamjegyOsszegzo += egyeseketElvesszuk;

            if (a == 0)
            nincsMegASzamjegyosszeadas = false; //break el is mûködik

        }
        return szamjegyOsszegzo;
    
    
    }
    void mySzamjegyOsszeadoMethod(int n) //n: alapérték; nInAbsoluteForm: amihez hasonlítunk
    {


        int nInAbsoluteForm = Mathf.Abs(n);  //ha netán mínusz. Így ehhez könnyebb hasonlítani a számjegyösszeget
        float nToSignForm = Mathf.Sign(n);   // ezzel az értékkel szorzom a megfelelõ számot
        int nSignInInt = (int)nToSignForm;   // ezzel könnyebb bánni az elkövetkezõ mûveletek miatt.

        for (int i = 10; i <20; i++)         // 10 tõl kezdünk fölfele számolni , 20 ig, egyesével
        {
            int iAtTens = i / 10;             //|EZ KELL | vesszük az i-t, --  pl.:16, osszuk tízzel, megkapjuk hányszor van meg benne: 1
            

            int iLessTens = i - (iAtTens * 10); // tudjuk hányszor van meg az i ben a tíz,

                                                // ezt szorozzuk 10 el, ezt kivonjuk az i bõl,
                                                // eredményül kapva az egyeseket. -- pl.: 16-(1*10) = 6
            int iAtSinglesPos = iLessTens / 1;  //|EZ KELL| ez azt szolgálná, hogy az egyes helyértéken lévõ értéket méri meg. 


            int TensAndSingles = iAtTens + iAtSinglesPos; //elvileg így a tízes helyiértéken álló számot (pl.:1) összeadtuk az egyesek helyén álló számmal (pl.: 6)
                                                          //ennek 7 nek kell lennie 1+6 = 7


           // Debug.Log(i);                   // i-t kiíratom.  10-19 ig. Ezekbõl kell olyan, amijegyeinek összege = n vagy nInAbsoluteForm.
            //Debug.Log(TensAndSingles);      //az értékeket úgy tûnik jól összeadja

            //Debug.Log(i*nSignInInt);       // kiírja az összes i-t olyan formában melyben az n található (negatív/pozitív)

            if (TensAndSingles == nInAbsoluteForm)         // ha az összevont geyek n el egyenlõek
            {
                Debug.Log(i*nSignInInt);     // ..akkor kiírja a keresett számot  és csak azt.
            
            
            
            }

        }
       

        // Debug.Log(n); //-7
        // Debug.Log(nInAbsoluteForm); // 7
        // Debug.Log(nSignInInt);  // -1
    }

    void mySzamjegyOsszeadoMetodusom_Complex(int n) // 3
    {
        int abszolutN = Mathf.Abs(n); // 3

        float signN = Mathf.Sign(n);  //1

        int signNint = (int)signN;   //1

        for (int i = 10; i < 30; i++)
        {
            string szam =  i.ToString();  //12
            //Debug.Log($"String: {szam} Ez int:  {i} ");  // jól mûködõnek tûnik


            char jegy = szam[0];          //1
            char jegyi = szam[1];         //2
           // Debug.Log($"Ez cChar jegy: {jegy} ez char jegyi: {jegyi}");   jónak túnik


            string tizes = jegy.ToString();        //1
            string egyes = jegyi.ToString();       //2

           // Debug.Log($"ez tizes: {tizes} ez egyes {egyes}"); //  Char vmi = 1; == int vmiII = 49; Stringbe változtaással megoldva

            int tizesHelyiertek = int.Parse(tizes);
            int egyesHelyiertek = int.Parse(egyes);


            int osszeg = tizesHelyiertek + egyesHelyiertek;    // 1+2 = 3
            //Debug.Log(osszeg);

            
            if (osszeg == abszolutN)    // 3 == 3
            {

                Debug.Log(i * signNint);    // 3 * 1
                break;
            } 
            
            
        }
    }



    void myFelfeleszamlaloFunction()
    { 
    
    for (int k = 10; k <20 ; k++)
        {
            if (k ==19)
            {
                for (int j = 19; j < 100; j += 10)
                {
                    if (j == 99)
                    {
                        for (int g = 99; g< 1000; g = g+100)
                        {

                            Debug.Log(g);
                        }

                    }
                 Debug.Log(j);
                }
                
            }
        Debug.Log(k);
        }
    
    
    }



    int myNumberTagSummer(int a)
    {
        

        string aString = a.ToString();

        char[] aStringToCharArray = aString.ToCharArray();

        string tizes = aStringToCharArray[0].ToString();
        string egyes = aStringToCharArray[1].ToString();

        int x = int.Parse(tizes);
        int y = int.Parse(egyes);

        int sumOfTags = x + y;

        return sumOfTags;

    }
    void myNumberTagSummerToGetN(int a)
    {
        for (int i = 10;i <1000;i++)
        {

            if (myNumberTagSummer(i) == a)
            {
                Debug.Log(i);
                break;
            }
        } 
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
