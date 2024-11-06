using System;

public class Program
{
    public static void Main(string[] args)
    {
       
        Kocka kocka = VytvorZvire.VytvorKocku(3);
       kocka.VydatZvuk();

        PerskaKocka perskaKocka = VytvorZvire.VytvorPerskouKocku(2);
        perskaKocka.VydatZvuk();

        SijamskaKocka sijamskaKocka = new SijamskaKocka(1);
        sijamskaKocka.VydatZvuk();

        Pes pes = VytvorZvire.VytvorPsa(4);
        pes.VydatZvuk();



        Labrador labrador = VytvorZvire.VytvorLabradora(5);
        labrador.VydatZvuk();

        NemeckyOvciak nemeckyOvciak = new NemeckyOvciak(6);
        nemeckyOvciak.VydatZvuk();

        Krava krava = VytvorZvire.VytvorKravu(3);
        krava.VydatZvuk();

        HolstynskaKrava holstynskaKrava = VytvorZvire.VytvorHolstynskouKravu(2);
        holstynskaKrava.VydatZvuk();

         JerseyskaKrava jerseyskaKrava = new JerseyskaKrava(4);
        jerseyskaKrava.VydatZvuk();

        Ovce ovce = VytvorZvire.VytvorOvci(2);
        ovce.VydatZvuk();

        Merino merino = VytvorZvire.VytvorMerino(1);
        merino.VydatZvuk();

        Suffolk suffolk = new Suffolk(3);
        suffolk.VydatZvuk();
        //atd
    }
}