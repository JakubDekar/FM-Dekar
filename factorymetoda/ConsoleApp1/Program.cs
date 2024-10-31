// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

class Zvire{
    private string zvuk;
    private string rasa;

    private Zvire(string zvuk, string rasa){
        this.zvuk = zvuk;
        this.rasa = rasa;
    }

    public static Zvire kocka(){
        return new Zvire("Mnau", "Kocka");
    }

    public string ZvukKocky(){
        return zvuk;
    }

    public string RasaKocky(){
        return rasa;
    }
    
    public static Zvire pes(){
        return new Zvire("Haf", "Pes");
    }
}
