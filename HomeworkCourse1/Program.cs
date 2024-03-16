public class Homework
{


    public static void Main(string[] args)
    {
        /* Ex1
        Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
        paralelipiped dreptunghic, va afisa volumul lui
•        Google: volumul paralelipipedului dreptunghic*/

        int lungime;
        int latime;
        int inaltime;
        lungime = int.Parse(Console.ReadLine());
        latime = int.Parse(Console.ReadLine());
        inaltime = int.Parse(Console.ReadLine());
        Console.WriteLine("Volumul paralelipipedului este: " + lungime * latime * inaltime);


        /*Ex2
        Scrieti un program care va calcula media aritmetica a trei numere citite de la
        tastatura*/

        double firstNumber;
        double secondNumber;
        double thirdNumber;
        firstNumber = double.Parse(Console.ReadLine());
        secondNumber = double.Parse(Console.ReadLine());
        thirdNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Media aritmetica a celor 3 numere este: " + (firstNumber+ secondNumber + thirdNumber) / 3);


        /*Ex3
        Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
        tastaura*/

        int numar = int.Parse(Console.ReadLine());
        int ultimaCifra = numar % 10;
        Console.WriteLine("Ultima cifra a numarului: " + numar + "este: " + ultimaCifra);


        /*Ex4
         Scrieti un program care va afisa semnul unui numar citit de la tastatura
        • Daca numarul este pozitiv, va afisa “+”
        • Daca numarul este negativ, va afisa “-”
        • Daca numarul este 0, va afisa “0”*/

        int number = int.Parse(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine("0");
        }
        else if (number > 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }


        /*Ex 5
        Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele
        doua valori in ordine crescatoare.
        • Exemplu: citim 9,0 Afisam : 0 9 */

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        if (x < y)
        {
            Console.WriteLine(x + " , " + y);
        }
        else
        {
            Console.WriteLine(y + " , " + x);
        };


        /*Ex 6
        Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
        impar
         In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
         Google :even and odd number*/

        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("par");
        }
        else
        {
            Console.WriteLine("impar");
        };


        /*Ex 7
        Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
        daca x este divizibil cu y.
         In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
        “indivizibil”.*/

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a % b == 0)
        {
            Console.WriteLine("divizibil");
        }
        else
        {
            Console.WriteLine("indivizibil");
        };


        /*Ex8
        Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele
        trei valori in ordine descrescatoare.
        • Exemplu: citim 3 9 0 Afisam : 9 3 0*/

        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());

        if ((d > e) && (d > f))
        {
            if (e > f)
            {
                Console.WriteLine(d + " , " + e + " , " + f);
            }
            else
            {
                Console.WriteLine(d + " , " + f + " , " + e);
            }
        }
        else if ((e > d) && (e > f))
        {
            if (d > f)
            {
                Console.WriteLine(e + " , " + d + " , " + f);
            }
            else
            {
                Console.WriteLine(e + " , " + f + " , " + d);
            }
        }
        else if ((f > d) && (f > e))
        {
            if (d > e)
            {
                Console.WriteLine(f + " , " + d + " , " + e);
            }
            else
            {
                Console.WriteLine(f + " , " + e + " , " + d);
            }
        }

        /* Ex 9
         Scrieti un program care interschimba valoarea a doua variabile intregi.*/

        int primulNr = int.Parse(Console.ReadLine());
        int alDoileaNr = int.Parse(Console.ReadLine());
        int aux = primulNr;
        primulNr = alDoileaNr;
        alDoileaNr = aux;
        Console.WriteLine("Primul numar are valoarea: " + primulNr);
        Console.WriteLine("Al doilea  numar are valoarea: " + alDoileaNr);


        /*Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la
        tastatura.
        
          Numarul are exact 2 cifre*/


        int numarul = int.Parse(Console.ReadLine());
        int sumaCifrelor = numarul % 10;
        numarul = numarul / 10;
        sumaCifrelor += numarul;
        Console.WriteLine("Suma cifrelor numarului introdus este: " + sumaCifrelor);


        /*Ex 11
        Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un
        numar intreg va verifica urmatoarele
        “unu” daca numarul citit este 1
        “doi” daca numarul citit este 2
        “trei” daca numarul citit este 3
        “cinci” daca numarul citit este 5
        “opt” daca numarul citit este 8
        “neidentificat” pentru orice alt caz */


        int unNumar = int.Parse(Console.ReadLine());
        switch (unNumar)
        {
            case 1:
                Console.WriteLine("unu");
                break;

            case 2:
                Console.WriteLine("doi");
                break;

            case 3:
                Console.WriteLine("trei");
                break;

            case 5:
                Console.WriteLine("cinci");
                break;

            case 8:
                Console.WriteLine("opt");
                break;

            default:
                Console.WriteLine("neindentificat");
                break;

        }
    }
}