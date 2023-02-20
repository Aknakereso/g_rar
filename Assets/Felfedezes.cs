using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Felfedezes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // !!!Met�dust kell �rni! Val�sz�n� string et �r ki, �s void lesz a tipus.
        // �rni egy met�dust, mely visszaad egy olyan sz�mot mely jegyeinek �sszege a viszonylagosan tetsz�legesen bevitt sz�m �rt�ke.
        // Met�dust kell �rni!
        // -n-t param�terben kapja meg a f�ggv�ny. (Azaz nem "k�velr�l)
        // - n = egy tetsz�leges sz�m (�n 0 �s 27 k�z� szor�tom).
        // - olyan sz�m kell mely sz�mjegyeinek �sszege egyenl� az n �rt�k�vel.
        // - a beviteli �s visszaadott �rt�k mind int t�pus.
        // - csak az els� megtal�lt, megfelel� sz�m kell !! Azaz egy �rt�k !!

        // ? -pozit�v n? -negat�v n? -return || Debug.Log();?
        // Hogy lesz a met�dusom ak�rh�ny helyi�rt�kkel kompatibilis? 23-> 2 elem;
        // 4523-> 4 elem. Minden elem egy 'char'. Hogy f�z�m �ket megfelel� sorrendben �ssze?

        // @ Megold�sok:
        // - 'for' f�ggv�ny seg�ts�g�vel: 10 t�l felfele sz�ml�l a megfelel� sz�mig.
        // - (n-1) + 10; !! Ez a logika probl�m�khoz vezethet !!
        // - *extra: tov�bbi sz�mokat is tal�l: 10 t�l indul: -El�sz�r az egyesek sz�ma n�vekszik 19-ig pl.
        //                                                    -M�sodsoorban a t�zesek �rt�ke n�vekszik kilencig 99.
        //                                                    -Harmadsorban a sz�zasok� kilencig 999.
        // -Meglehetne oldani Lista seg�ts�g�vel: Sz�m �t stringbe,
        //                                        karakterei list�ba,
        //                                        ehhez adunk +1 helyi�rt�ket, ami string �s 0-�s indexbe ker�l.
        //                                        A lista tartalm�t �tadom String-be.
        //                                        String-> int


        // [�] Ami kellhet:
        // -felfele sz�ml�l�s 'for'
        // felt�tel 'if'
        // -sz�mjegy�sszead� program (function): int->string-> (lista) -> int
        // -egy speci�lis felfele sz�ml�l� f�ggv�ny 'if'-el, 'for'-al: Egyesek: 010-> 019; T�zesek: 019-> 099; Sz�zasok: 099-> 999
        // -'int', -'String', -list�k, -karakterek, -konvert�l�s,-char + array, clamp
        // - kellhet t�bb function.


        /* Egy egyszer�bb feladat: String-> int / float




        string a = "caaabBbccc"; // helyettes�t�s:
        string b = "abcdefgh";

        */
        //   a.Length; nem null�val kezdi a sz�mol�st.- Ez int �rt�k. - Az a = 10 elem.
        //   a.IndexOf("c"); 0-val kezdi a sz�mol�st. - Ez int �rt�k. -
        //   a.Replace('c','x'); Ilyenkor minden az elemnek megfelel� elemet kicser�l a k�v�ntra.
        //   a.Replace("ca","x"); Vagy string et helyettes�t�nk stringgel vagy char-t char al.
        //   a.Replace("ca","x"); pontos karakterek defini�l�sa eset�n elker�lhetj�k a nem v�ltoztatni k�v�nt elemek v�ltoztat�s�t
        //   a.Remove(1,8); eredm�ny: cc Egyel kezd, nem exkluz�v a kiindul�si ponttal, azaz azt is t�rli.
        //   a.Insert(9,"x"); caaabbbccxc  �gy n�z ki 0 val kezdi a sz�mol�st
        //   a.TrimStart('c','a','b'); A sz�veg elej�t�l kezdve sorra t�rli a kijel�lt elemeket El�sz�r c, majd a majd b
        //               n�melyiket sz�k�zzel kihagyhatjuk, azaz nem t�rn�lk karaktert 
        //   a.TrimEnd('c',' ',' '); A v�g�r�l csak a cket t�r�lte, olyan mint a  xy.TrimStart();
        //   b.Trim('a','d','h'); : bcdefg lett. Kivelr�l a kijel�lt elemeket k�rbe lev�gja, lecuppantja

        //         Debug.Log(b.Trim('a','d','h'));




        // Ami nek�nk fontos az az int vm = xystring.IndexOf("string");
        // �s az int vmi = xy.Length;


        //Most j�jj�n a List�z�s:
        // -List�kn�l alkalmazhatunk t�bb, rugalmasabb megold�st, mint a T�mb n�l. T�mb n�l van: int[] nev = (int)nevii.Clone();
        // - List�n�l van vmi.Clear(); �s vmi.Sort();

        /*Deklar�l�s, Iter�l�s:
        List<int> pipa = new List<int>(); // Deklar�ltunk �s iter�ltunk egy �res int-eket tartalmaz� list�t
        List<float> kefe = new List<float>(3); // Ebben az iter�lt list�ban 3 elem van. Mind 0.0f �rt�kkel b�r.
        List<string> fal = new List<string>() { "kukac", "1000" };  //ebben a list�ban k�t elem van a "kukac" �s "1000".
        List<char> aprok = new List<char>() { 'a', 'r', 't', '7', '3' };
        */

        /*B�v�ts�k a list�t.
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



        /** T�MB�K: Array

        int[] kategoriz�ci�k = { 5, 3, 6, 2, 7, 1 };
        string[] kocsik = { "BMW", "Merci", "Trabant", "Lada", "Kutyaf�le" };
        float[] membran = { 0.012f, 1.033f, 1.001f, 78.66f };
        kategoriz�ci�k[0] = 9; // a nulladik �rt�ket kilencre v�ltottam

        int[] storage = new int[10]; // t�z t�rhelyes rakt�rhely
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




        //felfele sz�ml�l� met�dus
        //myFelfeleszamlaloFunction();

        //felfelesz�ml�l� function;

        // Ezek �t lesznek n�zve :
        // mySzamjegyOsszeadoMetodusom_Complex(11);  // 12?? 
        //mySzamjegyOsszeadoMethod(-7);



        //Megold�s a megold�s seg�ts�g�vel:

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
            nincsMegASzamjegyosszeadas = false; //break el is m�k�dik

        }
        return szamjegyOsszegzo;
    
    
    }
    void mySzamjegyOsszeadoMethod(int n) //n: alap�rt�k; nInAbsoluteForm: amihez hasonl�tunk
    {


        int nInAbsoluteForm = Mathf.Abs(n);  //ha net�n m�nusz. �gy ehhez k�nnyebb hasonl�tani a sz�mjegy�sszeget
        float nToSignForm = Mathf.Sign(n);   // ezzel az �rt�kkel szorzom a megfelel� sz�mot
        int nSignInInt = (int)nToSignForm;   // ezzel k�nnyebb b�nni az elk�vetkez� m�veletek miatt.

        for (int i = 10; i <20; i++)         // 10 t�l kezd�nk f�lfele sz�molni , 20 ig, egyes�vel
        {
            int iAtTens = i / 10;             //|EZ KELL | vessz�k az i-t, --  pl.:16, osszuk t�zzel, megkapjuk h�nyszor van meg benne: 1
            

            int iLessTens = i - (iAtTens * 10); // tudjuk h�nyszor van meg az i ben a t�z,

                                                // ezt szorozzuk 10 el, ezt kivonjuk az i b�l,
                                                // eredm�ny�l kapva az egyeseket. -- pl.: 16-(1*10) = 6
            int iAtSinglesPos = iLessTens / 1;  //|EZ KELL| ez azt szolg�ln�, hogy az egyes hely�rt�ken l�v� �rt�ket m�ri meg. 


            int TensAndSingles = iAtTens + iAtSinglesPos; //elvileg �gy a t�zes helyi�rt�ken �ll� sz�mot (pl.:1) �sszeadtuk az egyesek hely�n �ll� sz�mmal (pl.: 6)
                                                          //ennek 7 nek kell lennie 1+6 = 7


           // Debug.Log(i);                   // i-t ki�ratom.  10-19 ig. Ezekb�l kell olyan, amijegyeinek �sszege = n vagy nInAbsoluteForm.
            //Debug.Log(TensAndSingles);      //az �rt�keket �gy t�nik j�l �sszeadja

            //Debug.Log(i*nSignInInt);       // ki�rja az �sszes i-t olyan form�ban melyben az n tal�lhat� (negat�v/pozit�v)

            if (TensAndSingles == nInAbsoluteForm)         // ha az �sszevont geyek n el egyenl�ek
            {
                Debug.Log(i*nSignInInt);     // ..akkor ki�rja a keresett sz�mot  �s csak azt.
            
            
            
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
            //Debug.Log($"String: {szam} Ez int:  {i} ");  // j�l m�k�d�nek t�nik


            char jegy = szam[0];          //1
            char jegyi = szam[1];         //2
           // Debug.Log($"Ez cChar jegy: {jegy} ez char jegyi: {jegyi}");   j�nak t�nik


            string tizes = jegy.ToString();        //1
            string egyes = jegyi.ToString();       //2

           // Debug.Log($"ez tizes: {tizes} ez egyes {egyes}"); //  Char vmi = 1; == int vmiII = 49; Stringbe v�ltozta�ssal megoldva

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
