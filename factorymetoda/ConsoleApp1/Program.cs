
using System;
// Základní třída pro zvíře
public class Zvire
{
    public string Druh { get;set; }
    public string Plemeno { get; set; }
    public int Vek { get;set; }
    public string Zvuk { get; set; }

    public Zvire() {}// Prázdný konstruktor

    //metoda
    public void VydatZvuk()
    {
        Console.WriteLine($"{Druh} ({Plemeno}) vydává zvuk: {Zvuk}");
    }
}
//třídy pro jednotlive zvířata

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

public class Kralik : Zvire
{
    public Kralik(int vek)
    {
        Druh = "Králík";
        Vek = vek;
        Zvuk = "Chrocht";
        Plemeno = "Obecný";
    }
}

public class AngorskyKralik : Zvire
{
    public AngorskyKralik(int vek)
    {
        Druh = "Králík";
        Vek = vek;
        Zvuk = "Chrocht";
        Plemeno = "Angorský";
    }
}

public class Kun : Zvire
{
    public Kun(int vek)
    {
        Druh = "Kůň";
        Vek = vek;
        Zvuk = "Hřebec";
        Plemeno = "Obecný";
    }
}

public class ArabskyKun : Zvire
{
    public ArabskyKun(int vek)
    {
        Druh = "Kůň";
        Vek = vek;
        Zvuk = "Hřebec";
        Plemeno = "Arabský";
    }
}

public class Slepice : Zvire
{
    public Slepice(int vek)
    {
        Druh = "Slepice";
        Vek = vek;
        Zvuk = "Kukuryku";
        Plemeno = "Obecná";
    }
}

public class PlymutSrock : Zvire
{
    public PlymutSrock(int vek)
    {
        Druh = "Slepice";
        Vek = vek;
        Zvuk = "Kukuryku";
        Plemeno = "Plymut Srock";
    }
}

public class Prase : Zvire
{
    public Prase(int vek)
    {
        Druh = "Prase";
        Vek = vek;
        Zvuk = "Oink";
        Plemeno = "Obecné";
    }
}

public class Bjerkera : Zvire
{
    public Bjerkera(int vek)
    {
        Druh = "Prase";
        Vek = vek;
        Zvuk = "Oink";
        Plemeno = "Bjerkera";
    }
}

public class Koza : Zvire
{
    public Koza(int vek)
    {
        Druh = "Koza";
        Vek = vek;
        Zvuk = "Méé";
        Plemeno = "Obecná";
    }
}

public class SaanenskaKoza : Zvire
{
    public SaanenskaKoza(int vek)
    {
        Druh = "Koza";
        Vek = vek;
        Zvuk = "Méé";
        Plemeno = "Saanenská";
    }
}

public class Husa : Zvire
{
    public Husa(int vek)
    {
        Druh = "Husa";
        Vek = vek;
        Zvuk = "Hú";
        Plemeno = "Obecná";
    }
}

public class ToulouseHusa : Zvire
{
    public ToulouseHusa(int vek)
    {
        Druh = "Husa";
        Vek = vek;
        Zvuk = "Hú";
        Plemeno = "Toulouse";
    }
}
//factory metody
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