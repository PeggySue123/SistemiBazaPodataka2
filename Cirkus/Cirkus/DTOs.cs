using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkus
{
    #region Artista
    public class ArtistaPregled
    {
        public int Id;
        public string Maticni_Broj;
        public DateTime Datum_Rodjenja;
        public string Nadimak;
        public string Licno_Ime;
        public string Ime_Roditelja;
        public string Prezime;
        public DateTime Pocetak_Rada;
        public char Pol;
        public string Mesto_Rodjenja;

        public ArtistaPregled()
        {

        }

        public ArtistaPregled(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja)
        {
            this.Id = id;
            this.Maticni_Broj = maticni_broj;
            this.Datum_Rodjenja = datum_rodjenja;
            this.Nadimak = nadimak;
            this.Licno_Ime = licno_ime;
            this.Ime_Roditelja = ime_roditelja;
            this.Prezime = prezime;
            this.Pocetak_Rada = pocetak_rada;
            this.Pol = pol;
            this.Mesto_Rodjenja = mesto_rodjenja;
        }
    }

    public class ArtistaBasic
    {
        public int Id;
        public string Maticni_Broj;
        public DateTime Datum_Rodjenja;
        public string Nadimak;
        public string Licno_Ime;
        public string Ime_Roditelja;
        public string Prezime;
        public DateTime Pocetak_Rada;
        public char Pol;
        public string Mesto_Rodjenja;

        public int DirektorId;
        public DirektorBasic Direktor;

        public IList<CirkuskaTackaBasic> Cirkuske_Tacke;

        public ArtistaBasic()
        {
            Cirkuske_Tacke = new List<CirkuskaTackaBasic>();
        }
        public ArtistaBasic(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja, int direktor)
        {
            this.Id = id;
            this.Maticni_Broj = maticni_broj;
            this.Datum_Rodjenja = datum_rodjenja;
            this.Nadimak = nadimak;
            this.Licno_Ime = licno_ime;
            this.Ime_Roditelja = ime_roditelja;
            this.Prezime = prezime;
            this.Pocetak_Rada = pocetak_rada;
            this.Pol = pol;
            this.Mesto_Rodjenja = mesto_rodjenja;
            this.DirektorId = direktor;

            Cirkuske_Tacke = new List<CirkuskaTackaBasic>();
        }
    }
    #endregion

    #region Akrobata
    public class AkrobataPregled : ArtistaPregled
    {
        public AkrobataPregled()
        {
            
        }

        public AkrobataPregled(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja)
        {
            
        }
    }

    public class AkrobataBasic : ArtistaBasic
    {
        public IList<VestinaBasic> Poseduje_Vestine { get; set; }

        public AkrobataBasic() : base()
        {
            Poseduje_Vestine = new List<VestinaBasic>();
        }

        public AkrobataBasic(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja, int direktor)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja, direktor)
        {
            
        }
    }
    #endregion

    #region Asistenti
    public class AsistentiPregled : ArtistaPregled
    {
        public AsistentiPregled() : base()
        {

        }
        public AsistentiPregled(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja)
        {
            
        }
    }

    public class AsistentiBasic : ArtistaBasic
    {
        public int Artista_Sa_Asistentima_Id;
        public ArtistaBasic Artista_Sa_Asistentima;

        public AsistentiBasic() : base()
        {

        }
        public AsistentiBasic(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja, int artista_sa_asistentima, int direktor)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja, direktor)
        {
            this.Artista_Sa_Asistentima_Id = artista_sa_asistentima;
        }
    }
    #endregion

    #region Bacaci_Nozeva
    public class BacaciNozevaPregled : ArtistaPregled
    {
        public BacaciNozevaPregled() : base()
        {

        }

        public BacaciNozevaPregled(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja)
        {

        }
    }

    public class BacaciNozevaBasic : ArtistaBasic
    {
        public IList<AsistentiBasic> Asistenti;

        public BacaciNozevaBasic() : base()
        {
            Asistenti = new List<AsistentiBasic>();
        }

        public BacaciNozevaBasic(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja, int direktor)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja, direktor)
        {
            Asistenti = new List<AsistentiBasic>();
        }
    }
    #endregion

    #region Dreseri
    public class DreseriPregled : ArtistaPregled
    {
        public DreseriPregled() : base()
        {

        }

        public DreseriPregled(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja)
        {

        }
    }

    public class DreseriBasic : ArtistaBasic
    {
        public IList<ZivotinjaBasic> Dresira;
        public IList<AsistentiBasic> Asistenti;

        public DreseriBasic() : base()
        {
            Dresira = new List<ZivotinjaBasic>();
            Asistenti = new List<AsistentiBasic>();
        }

        public DreseriBasic(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja, int direktor)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja, direktor)
        {
            Dresira = new List<ZivotinjaBasic>();
            Asistenti = new List<AsistentiBasic>();
        }
    }
    #endregion

    #region Gutaci_Plamena
    public class GutaciPlamenaPregled : ArtistaPregled
    {
        public GutaciPlamenaPregled() : base()
        {

        }

        public GutaciPlamenaPregled(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja)
        {

        }
    }

    public class GutaciPlamenaBasic : ArtistaBasic
    {
        public IList<AsistentiBasic> Asistenti;

        public GutaciPlamenaBasic() : base()
        {
            Asistenti = new List<AsistentiBasic>();
        }

        public GutaciPlamenaBasic(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja, int direktor)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja, direktor)
        {
            Asistenti = new List<AsistentiBasic>();
        }
    }
    #endregion

    #region Klovn
    public class KlovnPregled : ArtistaPregled
    {
        public int Tip;
        public string Predmet_Za_Zabavu;

        public KlovnPregled() : base()
        {

        }

        public KlovnPregled(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja, int tip, string predmet)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja)
        {
            this.Tip = tip;
            this.Predmet_Za_Zabavu = predmet;
        }
    }

    public class KlovnBasic : ArtistaBasic
    {
        public int Tip;
        public string Predmet_Za_Zabavu;

        public KlovnBasic() : base()
        {

        }

        public KlovnBasic(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja, int tip, string predmet, int direktor)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja, direktor)
        {
            this.Tip = tip;
            this.Predmet_Za_Zabavu = predmet;
        }
    }
    #endregion

    #region Zongleri
    public class ZonglerPregled : ArtistaPregled
    {
        public string Naziv;
        public int Broj_Predmeta;

        public ZonglerPregled() : base()
        {

        }

        public ZonglerPregled(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja, string naziv, int broj_predmeta)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja)
        {
            this.Naziv = naziv;
            this.Broj_Predmeta = broj_predmeta;
        }
    }

    public class ZonglerBasic : ArtistaBasic
    {
        public string Naziv;
        public int Broj_Predmeta;

        public ZonglerBasic() : base()
        {

        }

        public ZonglerBasic(int id, string maticni_broj, DateTime datum_rodjenja, string nadimak, string licno_ime, string ime_roditelja, string prezime, DateTime pocetak_rada, char pol, string mesto_rodjenja, string naziv, int broj_predmeta, int direktor)
            : base(id, maticni_broj, datum_rodjenja, nadimak, licno_ime, ime_roditelja, prezime, pocetak_rada, pol, mesto_rodjenja, direktor)
        {
            this.Naziv = naziv;
            this.Broj_Predmeta = broj_predmeta;
        }
    }
    #endregion

    #region Cirkuske_Tacke
    public class CirkuskaTackaPregled
    {
        public int Id;
        public string Ime;
        public string Tip;
        public string Opasni_Efekti;
        public int Donja_Granica_Uzrasta;

        public int Predstava_Id;
        public PredstavaPregled Pripada_Predstavi;

        public CirkuskaTackaPregled()
        {

        }

        public CirkuskaTackaPregled(int id, string ime, string tip, string opasni_efekti, int donja_granica_uzrasta, int predstava)
        {
            this.Id = id;
            this.Ime = ime;
            this.Tip = tip;
            this.Opasni_Efekti = opasni_efekti;
            this.Donja_Granica_Uzrasta = donja_granica_uzrasta;
            this.Predstava_Id = predstava;
        }
    }

    public class CirkuskaTackaBasic
    {
        public int Id;
        public string Ime;
        public string Tip;
        public string Opasni_Efekti;
        public int Donja_Granica_Uzrasta;

        public int Predstava_Id;
        public PredstavaBasic Pripada_Predstavi;

        public IList<PomocnoOsobljeBasic> Pomocno_Osoblje;
        public IList<ArtistaBasic> Artisti;
        public IList<ZivotinjaBasic> Zivotinje;

        public CirkuskaTackaBasic()
        {
            Pomocno_Osoblje = new List<PomocnoOsobljeBasic>();
            Artisti = new List<ArtistaBasic>();
            Zivotinje = new List<ZivotinjaBasic>();
        }

        public CirkuskaTackaBasic(int id, string ime, string tip, string opasni_efekti, int donja_granica_uzrasta, int predstava)
        {
            this.Id = id;
            this.Ime = ime;
            this.Tip = tip;
            this.Opasni_Efekti = opasni_efekti;
            this.Donja_Granica_Uzrasta = donja_granica_uzrasta;
            this.Predstava_Id = predstava;
        }
    }
    #endregion

    #region Direktor
    public class DirektorPregled
    {
        public int Id;
        public string Licno_Ime;
        public string Srednje_Slovo;
        public string Prezime;
        public IList<EmailDirektoraPregled> Emailovi;
        public IList<TelefonDirektoraPregled> Brojevi_Telefona;

        public DirektorPregled()
        {
            Emailovi = new List<EmailDirektoraPregled>();
            Brojevi_Telefona = new List<TelefonDirektoraPregled>();
        }

        public DirektorPregled(int id, string licno_ime, string srednje_slovo, string prezime)
        {
            this.Id = id;
            this.Licno_Ime = licno_ime;
            this.Srednje_Slovo = srednje_slovo;
            this.Prezime = prezime;

            Emailovi = new List<EmailDirektoraPregled>();
            Brojevi_Telefona = new List<TelefonDirektoraPregled>();
        }
    }

    public class DirektorBasic
    {
        public int Id;
        public string Licno_Ime;
        public string Srednje_Slovo;
        public string Prezime;
        public IList<EmailDirektoraBasic> Emailovi;
        public IList<TelefonDirektoraBasic> Brojevi_Telefona;

        public IList<ArtistaBasic> NadredjenArtistima;
        public IList<ZivotinjaBasic> NabavljeneZivotinje;
        public IList<PomocnoOsobljeBasic> Zaposljeno_Osoblje;

        public DirektorBasic()
        {
            Emailovi = new List<EmailDirektoraBasic>();
            Brojevi_Telefona = new List<TelefonDirektoraBasic>();
            NadredjenArtistima = new List<ArtistaBasic>();
            NabavljeneZivotinje = new List<ZivotinjaBasic>();
            Zaposljeno_Osoblje = new List<PomocnoOsobljeBasic>();
        }

        public DirektorBasic(int id, string licno_ime, string srednje_slovo, string prezime)
        {
            this.Id = id;
            this.Licno_Ime = licno_ime;
            this.Srednje_Slovo = srednje_slovo;
            this.Prezime = prezime;
        }
    }
    #endregion

    #region Email_Direktora
    public class EmailDirektoraPregled
    {
        public int Id;
        public string Email;

        public int Direktor_Id;
        public DirektorPregled Direktor;

        public EmailDirektoraPregled()
        {

        }

        public EmailDirektoraPregled(int id, string email, int direktor)
        {
            this.Id = id;
            this.Email = email;
            this.Direktor_Id = direktor;
        }
    }

    public class EmailDirektoraBasic
    {
        public int Id;
        public string Email;

        public int Direktor_Id;
        public DirektorBasic Direktor;

        public EmailDirektoraBasic()
        {

        }

        public EmailDirektoraBasic(int id, string email, int direktor)
        {
            this.Id = id;
            this.Email = email;
            this.Direktor_Id = direktor;
        }
    }
    #endregion

    #region Grad
    public class GradPregled
    {
        public int Id;
        public string Naziv_Drzave;
        public string Naziv_Grada;
        public DateTime Datum_Od;
        public DateTime Datum_Do;
        public string Opis;

        public GradPregled()
        {

        }

        public GradPregled(int id, string naziv_drzave, string naziv_grada, DateTime datum_od, DateTime datum_do, string opis)
        {
            this.Id = id;
            this.Naziv_Drzave = naziv_drzave;
            this.Naziv_Grada = naziv_grada;
            this.Datum_Od = datum_od;
            this.Datum_Do = datum_do;
            this.Opis = opis;
        }
    }

    public class GradBasic
    {
        public int Id;
        public string Naziv_Drzave;
        public string Naziv_Grada;
        public DateTime Datum_Od;
        public DateTime Datum_Do;
        public string Opis;

        public IList<PredstavaBasic> Predstave;

        public GradBasic()
        {
            Predstave = new List<PredstavaBasic>();
        }

        public GradBasic(int id, string naziv_drzave, string naziv_grada, DateTime datum_od, DateTime datum_do, string opis)
        {
            this.Id = id;
            this.Naziv_Drzave = naziv_drzave;
            this.Naziv_Grada = naziv_grada;
            this.Datum_Od = datum_od;
            this.Datum_Do = datum_do;
            this.Opis = opis;
        }
    }
    #endregion

    #region Pomocno_Osoblje
    public class PomocnoOsobljePregled
    {
        public int Id;
        public string Maticni_Broj;
        public string Licno_Ime;
        public string Srednje_Slovo;
        public string Prezime;
        public char Pol;
        public string Mesto_Rodjenja;
        public DateTime? Datum_Rodjenja;

        public int Direktor_Id;
        public DirektorPregled Direktor { get; set; }

        public PomocnoOsobljePregled()
        {

        }

        public PomocnoOsobljePregled(int id, string maticni_broj, string licno_ime, string srednje_slovo, string prezime, char pol, string mesto_rodjenja, DateTime? datum_rodjenja, int direktor)
        {
            this.Id = id;
            this.Maticni_Broj = maticni_broj;
            this.Licno_Ime = licno_ime;
            this.Srednje_Slovo = srednje_slovo;
            this.Prezime = prezime;
            this.Pol = pol;
            this.Mesto_Rodjenja = mesto_rodjenja;
            this.Datum_Rodjenja = datum_rodjenja;
            this.Direktor_Id = direktor;
        }
    }

    public class PomocnoOsobljeBasic
    {
        public int Id;
        public string Maticni_Broj;
        public string Licno_Ime;
        public string Srednje_Slovo;
        public string Prezime;
        public char Pol;
        public string Mesto_Rodjenja;
        public DateTime? Datum_Rodjenja;

        public int Direktor_Id;
        //public DirektorBasic Direktor { get; set; }

        public IList<CirkuskaTackaBasic> Cirkuske_Tacke;

        public PomocnoOsobljeBasic()
        {
            Cirkuske_Tacke = new List<CirkuskaTackaBasic>();
        }

        public PomocnoOsobljeBasic(int id, string maticni_broj, string licno_ime, string srednje_slovo, string prezime, char pol, string mesto_rodjenja, DateTime? datum_rodjenja, int direktor)
        {
            this.Id = id;
            this.Maticni_Broj = maticni_broj;
            this.Licno_Ime = licno_ime;
            this.Srednje_Slovo = srednje_slovo;
            this.Prezime = prezime;
            this.Pol = pol;
            this.Mesto_Rodjenja = mesto_rodjenja;
            this.Datum_Rodjenja = datum_rodjenja;
            this.Direktor_Id = direktor;
            Cirkuske_Tacke = new List<CirkuskaTackaBasic>();
        }
    }
    #endregion

    #region Predstava
    public class PredstavaPregled
    {
        public int Id;
        public int? Razlog_Organizovanja;
        public float? Prihod;
        public string Namenjen_Prihod;
        public string Naziv;
        public string Adresa;
        public IList<TelefonNaruciocaPregled> Brojevi_Telefona_Narucioca;

        public PredstavaPregled()
        {

        }

        public PredstavaPregled(int id)
        {
            this.Id = id;
        }
    }

    public class RedovnaPredstavaPregled : PredstavaPregled
    {
        public RedovnaPredstavaPregled() : base()
        {
            this.Brojevi_Telefona_Narucioca = null;
        }

        public RedovnaPredstavaPregled(int id) : base(id)
        {
            this.Razlog_Organizovanja = null;
            this.Prihod = null;
            this.Namenjen_Prihod = this.Adresa = this.Naziv = null;
            this.Brojevi_Telefona_Narucioca = null;
        }
    }

    public class SpecijalnaPredstavaPregled : PredstavaPregled
    {
        public SpecijalnaPredstavaPregled() : base()
        {

        }

        public SpecijalnaPredstavaPregled(int id) : base(id)
        {

        }
    }

    public class HumanitarnaPredstavaPregled : PredstavaPregled
    {
        public HumanitarnaPredstavaPregled() : base()
        {
            this.Brojevi_Telefona_Narucioca = null;
        }

        public HumanitarnaPredstavaPregled(int id, float prihod, string namenjen_prihod) : base(id)
        {
            this.Razlog_Organizovanja = 0;
            this.Prihod = prihod;
            this.Namenjen_Prihod = namenjen_prihod;
            this.Naziv = this.Adresa = null;
            this.Brojevi_Telefona_Narucioca = null;
        }
    }

    public class NarucenaPredstavaPregled : PredstavaPregled
    {
        public NarucenaPredstavaPregled() : base()
        {
            Brojevi_Telefona_Narucioca = new List<TelefonNaruciocaPregled>();
        }

        public NarucenaPredstavaPregled(int id, string naziv, string adresa) : base(id)
        {
            this.Razlog_Organizovanja = 1;
            this.Prihod = null;
            this.Namenjen_Prihod = null;
            this.Naziv = naziv;
            this.Adresa = adresa;
            Brojevi_Telefona_Narucioca = new List<TelefonNaruciocaPregled>();
        }
    }

    public class PredstavaBasic
    {
        
        public int Id;
        public int? Razlog_Organizovanja;
        public float? Prihod;
        public string Namenjen_Prihod;
        public string Naziv;
        public string Adresa;
        public IList<TelefonNaruciocaBasic> Brojevi_Telefona_Narucioca;

        public IList<GradBasic> Gradovi;
        public IList<CirkuskaTackaBasic> Cirkuske_Tacke;

        public PredstavaBasic()
        {
            Gradovi = new List<GradBasic>();
            Cirkuske_Tacke = new List<CirkuskaTackaBasic>();
        }

        public PredstavaBasic(int id)
        {
            this.Id = id;
            Gradovi = new List<GradBasic>();
            Cirkuske_Tacke = new List<CirkuskaTackaBasic>();
        }
    }

    public class RedovnaPredstavaBasic : PredstavaBasic
    {
        public RedovnaPredstavaBasic() : base()
        {
            this.Brojevi_Telefona_Narucioca = null;
        }

        public RedovnaPredstavaBasic(int id) : base(id)
        {
            
            this.Razlog_Organizovanja = null;
            this.Prihod = null;
            this.Namenjen_Prihod = this.Adresa = this.Naziv = null;
            this.Brojevi_Telefona_Narucioca = null;
        }
    }

    /*public class SpecijalnaPredstavaBasic : PredstavaBasic
    {
        public SpecijalnaPredstavaBasic() : base()
        {

        }

        public SpecijalnaPredstavaBasic(int id) : base(id)
        {

        }
    }*/

    public class HumanitarnaPredstavaBasic : PredstavaBasic
    {
        public HumanitarnaPredstavaBasic() : base()
        {
            this.Brojevi_Telefona_Narucioca = null;
        }

        public HumanitarnaPredstavaBasic(int id, float? prihod, string namenjen_prihod) : base(id)
        {
            
            this.Razlog_Organizovanja = 0;
            this.Prihod = prihod;
            this.Namenjen_Prihod = namenjen_prihod;
            this.Naziv = this.Adresa = null;
            this.Brojevi_Telefona_Narucioca = null;
        }
    }

    public class NarucenaPredstavaBasic : PredstavaBasic
    {
        public NarucenaPredstavaBasic() : base()
        {
            Brojevi_Telefona_Narucioca = new List<TelefonNaruciocaBasic>();
        }

        public NarucenaPredstavaBasic(int id, string naziv, string adresa) : base(id)
        {
            
            this.Razlog_Organizovanja = 1;
            this.Prihod = null;
            this.Namenjen_Prihod = null;
            this.Naziv = naziv;
            this.Adresa = adresa;
            Brojevi_Telefona_Narucioca = new List<TelefonNaruciocaBasic>();
        }
    }
    #endregion

    #region Telefon_Direktora
    public class TelefonDirektoraPregled
    {
        public int Id;
        public string Broj_Telefona;
        public int Direktor_Id;
        public DirektorPregled Direktor;

        public TelefonDirektoraPregled()
        {

        }

        public TelefonDirektoraPregled(int id, string broj_telefona, int direktor)
        {
            this.Id = id;
            this.Broj_Telefona = broj_telefona;
            this.Direktor_Id = direktor;
        }
    }

    public class TelefonDirektoraBasic
    {
        public int Id;
        public string Broj_Telefona;
        public int Direktor_Id;
        public DirektorBasic Direktor;

        public TelefonDirektoraBasic()
        {

        }

        public TelefonDirektoraBasic(int id, string broj_telefona, int direktor)
        {
            this.Id = id;
            this.Broj_Telefona = broj_telefona;
            this.Direktor_Id = direktor;
        }
    }
    #endregion

    #region Telefon_Narucioca
    public class TelefonNaruciocaPregled
    {
        public int Id;
        public string Broj_Telefona;

        public int Narucioc_Predstave_Id;
        public PredstavaPregled Narucioc_Predstave;

        public TelefonNaruciocaPregled()
        {

        }

        public TelefonNaruciocaPregled(int id, string broj_telefona, int narucioc_predstave)
        {
            this.Id = id;
            this.Broj_Telefona = broj_telefona;
            this.Narucioc_Predstave_Id = narucioc_predstave;
        }
    }

    public class TelefonNaruciocaBasic
    {
        public int Id;
        public string Broj_Telefona;

        public int Narucioc_Predstave_Id;
        public PredstavaBasic Narucioc_Predstave;

        public TelefonNaruciocaBasic()
        {

        }

        public TelefonNaruciocaBasic(int id, string broj_telefona, int narucioc_predstave)
        {
            this.Id = id;
            this.Broj_Telefona = broj_telefona;
            this.Narucioc_Predstave_Id = narucioc_predstave;
        }
    }
    #endregion

    #region Vestina
    public class VestinaPregled
    {
        public int Id;
        public string Naziv;
        public float Broj_Godina;

        public int AkrobataId;
        public AkrobataPregled Akrobata;

        public VestinaPregled()
        {

        }
        public VestinaPregled(int id, string naziv, float broj_godina, int akrobata)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Broj_Godina = broj_godina;
            this.AkrobataId = akrobata;
        }
    }

    public class VestinaBasic
    {
        public int Id;
        public string Naziv;
        public float Broj_Godina;

        public int AkrobataId;
        public AkrobataBasic Akrobata;

        public VestinaBasic()
        {

        }
        public VestinaBasic(int id, string naziv, float broj_godina, int akrobata)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Broj_Godina = broj_godina;
            this.AkrobataId = akrobata;
        }
    }
    #endregion

    #region Zivotinja
    public class ZivotinjaPregled
    {
        public int Id;
        public string Nadimak;
        public string Vrsta;
        public char Pol;
        public float Starost;
        public float Vreme_Boravka;
        public DateTime Datum_Veterinarskog_Pregleda;
        public int Broj_Kaveza;
        public float Tezina;

        public int DreserId;
        public DreseriPregled Dreser;
        public int DirektorId;
        public DirektorPregled Direktor;

        public ZivotinjaPregled()
        {

        }

        public ZivotinjaPregled(int id, string nadimak, string vrsta, char pol, float starost, float vreme_boravka, DateTime datum_veterinarskog_pregleda, int broj_kaveza, float tezina, int dreser, int direktor)
        {
            this.Id = id;
            this.Nadimak = nadimak;
            this.Vrsta = vrsta;
            this.Pol = pol;
            this.Starost = starost;
            this.Vreme_Boravka = vreme_boravka;
            this.Datum_Veterinarskog_Pregleda = datum_veterinarskog_pregleda;
            this.Broj_Kaveza = broj_kaveza;
            this.Tezina = tezina;
            this.DreserId = dreser;
            this.DirektorId = direktor;
        }
    }

    public class ZivotinjaBasic
    {
        public int Id;
        public string Nadimak;
        public string Vrsta;
        public char Pol;
        public float Starost;
        public float Vreme_Boravka;
        public DateTime Datum_Veterinarskog_Pregleda;
        public int Broj_Kaveza;
        public float Tezina;

        public int DreserId;
        public DreseriBasic Dreser;
        public int DirektorId;
        public DirektorBasic Direktor;

        public IList<CirkuskaTackaBasic> Cirkuske_Tacke;

        public ZivotinjaBasic()
        {
            Cirkuske_Tacke = new List<CirkuskaTackaBasic>();
        }

        public ZivotinjaBasic(int id, string nadimak, string vrsta, char pol, float starost, float vreme_boravka, DateTime datum_veterinarskog_pregleda, int broj_kaveza, float tezina, int dreser, int direktor)
        {
            this.Id = id;
            this.Nadimak = nadimak;
            this.Vrsta = vrsta;
            this.Pol = pol;
            this.Starost = starost;
            this.Vreme_Boravka = vreme_boravka;
            this.Datum_Veterinarskog_Pregleda = datum_veterinarskog_pregleda;
            this.Broj_Kaveza = broj_kaveza;
            this.Tezina = tezina;
            this.DreserId = dreser;
            this.DirektorId = direktor;

            Cirkuske_Tacke = new List<CirkuskaTackaBasic>();
        }
    }
    #endregion

    #region Angazuje_Artistu
    public class AngazujeArtistuPregled
    {
        public int Id;

        public ArtistaPregled Artista;
        public CirkuskaTackaPregled Cirkuska_Tacka;

        public AngazujeArtistuPregled()
        {

        }

        public AngazujeArtistuPregled(int id, ArtistaPregled artista, CirkuskaTackaPregled cirkuska_tacka)
        {
            this.Id = id;
            this.Artista = artista;
            this.Cirkuska_Tacka = cirkuska_tacka;
        }
    }

    public class AngazujeArtistuBasic
    {
        public int Id;

        public ArtistaBasic Artista;
        public CirkuskaTackaBasic Cirkuska_Tacka;

        public AngazujeArtistuBasic()
        {

        }

        public AngazujeArtistuBasic(int id, ArtistaBasic artista, CirkuskaTackaBasic cirkuska_tacka)
        {
            this.Id = id;
            this.Artista = artista;
            this.Cirkuska_Tacka = cirkuska_tacka;
        }
    }
    #endregion

    #region Angazuje_Zivotinju
    public class AngazujeZivotinjuBasic
    {
        public int Id;

        public ZivotinjaBasic Zivotinja;
        public CirkuskaTackaBasic Cirkuska_Tacka;

        public AngazujeZivotinjuBasic()
        {

        }

        public AngazujeZivotinjuBasic(int id, ZivotinjaBasic zivotinja, CirkuskaTackaBasic cirkuska_tacka)
        {
            this.Id = id;
            this.Zivotinja = zivotinja;
            this.Cirkuska_Tacka = cirkuska_tacka;
        }
    }

    public class AngazujeZivotinjuPregled
    {
        public int Id;

        public ZivotinjaPregled Zivotinja;
        public CirkuskaTackaPregled Cirkuska_Tacka;

        public AngazujeZivotinjuPregled()
        {

        }

        public AngazujeZivotinjuPregled(int id, ZivotinjaPregled zivotinja, CirkuskaTackaPregled cirkuska_tacka)
        {
            this.Id = id;
            this.Zivotinja = zivotinja;
            this.Cirkuska_Tacka = cirkuska_tacka;
        }
    }
    #endregion

    #region Grad_Predstava
    public class GradPredstavaPregled
    {
        public int Id;
        public string Vreme_Odrzavanja;
        public int Broj_Prodatih_Karata;

        public GradPregled Grad;
        public PredstavaPregled Predstava;

        public GradPredstavaPregled()
        {

        }

        public GradPredstavaPregled(int id, string vreme_odrzavanja, int broj_prodatih_karata, GradPregled grad, PredstavaPregled predstava)
        {
            this.Id = id;
            this.Vreme_Odrzavanja = vreme_odrzavanja;
            this.Broj_Prodatih_Karata = broj_prodatih_karata;
            this.Grad = grad;
            this.Predstava = predstava;
        }
    }

    public class GradPredstavaBasic
    {
        public int Id;
        public string Vreme_Odrzavanja;
        public int Broj_Prodatih_Karata;

        public GradBasic Grad;
        public PredstavaBasic Predstava;

        public GradPredstavaBasic()
        {

        }

        public GradPredstavaBasic(int id, string vreme_odrzavanja, int broj_prodatih_karata, GradBasic grad, PredstavaBasic predstava)
        {
            this.Id = id;
            this.Vreme_Odrzavanja = vreme_odrzavanja;
            this.Broj_Prodatih_Karata = broj_prodatih_karata;
            this.Grad = grad;
            this.Predstava = predstava;
        }
    }
    #endregion

    #region Zaduzen
    public class ZaduzenBasic
    {
        public int Id;

        public PomocnoOsobljeBasic Pomocno_Osoblje;
        public CirkuskaTackaBasic Cirkuska_Tacka;

        public ZaduzenBasic()
        {

        }

        public ZaduzenBasic(int id, PomocnoOsobljeBasic pomocno_osoblje, CirkuskaTackaBasic cirkuska_tacka)
        {
            this.Id = id;
            this.Pomocno_Osoblje = pomocno_osoblje;
            this.Cirkuska_Tacka = cirkuska_tacka;
        }
    }

    public class ZaduzenPregled
    {
        public int Id;

        public PomocnoOsobljePregled Pomocno_Osoblje;
        public CirkuskaTackaPregled Cirkuska_Tacka;

        public ZaduzenPregled()
        {

        }

        public ZaduzenPregled(int id, PomocnoOsobljePregled pomocno_osoblje, CirkuskaTackaPregled cirkuska_tacka)
        {
            this.Id = id;
            this.Pomocno_Osoblje = pomocno_osoblje;
            this.Cirkuska_Tacka = cirkuska_tacka;
        }
    }
    #endregion
}
