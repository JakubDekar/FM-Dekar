
using System;

public class Zvire
{
    public string Druh { get;set; }
    public string Plemeno { get; set; }
    public int Vek { get;set; }
    public string Zvuk { get; set; }

    public Zvire() {}

    
    public void VydatZvuk()
    {
        Console.WriteLine($"{Druh} ({Plemeno}) vydává zvuk: {Zvuk}");
    }
}


public class Kocka : Zvire
{
    public Kocka(int vek)
    {
        Druh = "Kočka";
        Vek = vek;
        Zvuk = "Mňau";
        Plemeno = "Obecná";
    }
}

public class PerskaKocka : Zvire
{
    public PerskaKocka(int vek)
    {
        Druh = "Kočka";
        Vek = vek;
        Zvuk = "Mňau";
        Plemeno = "Perská";
    }
}

public class SijamskaKocka : Zvire
{
    public SijamskaKocka(int vek)
    {
        Druh = "Kočka";
        Vek = vek;
        Zvuk = "Mňau";
        Plemeno = "Siamská";
    }
}


public class Pes : Zvire
{
    public Pes(int vek)
    {
        Druh = "Pes";
        Vek = vek;
        Zvuk = "Haf";
        Plemeno = "Obecný";
    }
}

public class Labrador : Zvire
{
    public Labrador(int vek)
    {
        Druh = "Pes";
        Vek = vek;
        Zvuk = "Haf";
        Plemeno = "Labrador";
    }
}

 public class NemeckyOvciak : Zvire
{
    public NemeckyOvciak(int vek)
    {
        Druh = "Pes";
        Vek = vek;
        Zvuk = "Haf";
        Plemeno = "Německý ovčák";
    }
}


public class Krava : Zvire
{
    public Krava(int vek)
    {
        Druh = "Kráva";
        Vek = vek;
        Zvuk = "Můů";
        Plemeno = "Obecná";
    }
}

public class HolstynskaKrava : Zvire
{
    public HolstynskaKrava(int vek)
    {
        Druh = "Kráva";
        Vek = vek;
        Zvuk = "Můů";
        Plemeno = "Holštýnská";
    }
}

public class JerseyskaKrava : Zvire
{
    public JerseyskaKrava(int vek)
    {
        Druh = "Kráva";
        Vek = vek;
        Zvuk = "Můů";
        Plemeno = "Jerseyská";
    }
}


public class Ovce : Zvire
{
    public Ovce(int vek)
    {
        Druh = "Ovce";
        Vek = vek;
        Zvuk = "Béé";
        Plemeno = "Obecná";
    }
}

public class Merino : Zvire
{
    public Merino(int vek)
    {
        Druh = "Ovce";
        Vek = vek;
        Zvuk = "Béé";
        Plemeno = "Merino";
    }
}

public class Suffolk : Zvire
{
    public Suffolk(int vek)
    {
        Druh = "Ovce";
        Vek = vek;
        Zvuk = "Béé";
        Plemeno = "Suffolk";
    }
}

 public class VytvorZvire
{
    public static Kocka VytvorKocku(int vek)
    {
        return new Kocka(vek);
    }

    public static PerskaKocka VytvorPerskouKocku(int vek)
    {
        return new PerskaKocka(vek);
    }

    public static Pes VytvorPsa(int vek)
    {
        return new Pes(vek);
    }

    public static Labrador VytvorLabradora(int vek)
    {
        return new Labrador(vek);
    }

    public static Krava VytvorKravu(int vek)
    {
        return new Krava(vek);
    }

    public static HolstynskaKrava VytvorHolstynskouKravu(int vek)
    {
        return new HolstynskaKrava(vek);
    }

    public static Ovce VytvorOvci(int vek)
    {
        return new Ovce(vek);
    }

    public static Merino VytvorMerino(int vek)
    {
        return new Merino(vek);
    }

    public static Kralik VytvorKralika(int vek)
    {
        return new Kralik(vek);
    }

    public static AngorskyKralik VytvorAngorskyKralika(int vek)
    {
        return new AngorskyKralik(vek);
    }

    public static Kun VytvorKone(int vek)
    {
        return new Kun(vek);
    }

    public static ArabskyKun VytvorArabskyKone(int vek)
    {
        return new ArabskyKun(vek);
    }

    public static Slepice VytvorSlepici(int vek)
    {
        return new Slepice(vek);
    }

    public static PlymutSrock VytvorPlymutSrock(int vek)
    {
        return new PlymutSrock(vek);
    }

    public static Prase VytvorPrase(int vek)
    {
        return new Prase(vek);
    }

    public static Bjerkera VytvorBjerkeru(int vek)
    {
        return new Bjerkera(vek);
    }

    public static Koza VytvorKozu(int vek)
    {
        return new Koza(vek);
    }

    public static SaanenskaKoza VytvorSaanenskouKozu(int vek)
    {
        return new SaanenskaKoza(vek);
    }

    public static Husa VytvorHusu(int vek)
    {
        return new Husa(vek);
    }

    public static ToulouseHusa VytvorToulouseHusu(int vek)
    {
        return new ToulouseHusa(vek);
    }
}