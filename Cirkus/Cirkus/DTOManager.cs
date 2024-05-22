using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using Cirkus.Entiteti;
using System.Windows.Forms;

namespace Cirkus
{
    class DTOManager
    {
        #region Artisti
        public static List<ArtistaPregled> VratiSveArtiste()
        {
            List<ArtistaPregled> artisti = new List<ArtistaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Artista> svi_artisti = from a in s.Query<Artista>() select a;

                foreach(Artista a in svi_artisti)
                {
                    artisti.Add(new ArtistaPregled(a.Id, a.Maticni_Broj, a.Datum_Rodjenja, a.Nadimak, a.Licno_Ime, a.Ime_Roditelja, a.Prezime, a.Pocetak_Rada, a.Pol, a.Mesto_Rodjenja));
                }

                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return artisti;
        }
        public static List<ArtistaBasic> VratiSveArtisteBasic()
        {
            List<ArtistaBasic> artisti = new List<ArtistaBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Artista> artiste = from a in s.Query<Artista>() select a;

                foreach(Artista a in artiste)
                {
                    ArtistaBasic artista = DTOManager.VratiArtistu(a.Id);
                    artisti.Add(artista);
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return artisti;
        }

        public static ArtistaBasic VratiArtistu(int id)
        {
            ArtistaBasic artista = new ArtistaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Artista ar = s.Load<Artista>(id);
                artista = new ArtistaBasic(ar.Id, ar.Maticni_Broj, ar.Datum_Rodjenja, ar.Nadimak, ar.Licno_Ime, ar.Ime_Roditelja, ar.Prezime, ar.Pocetak_Rada, ar.Pol, ar.Mesto_Rodjenja, ar.Direktor.Id);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return artista;
        }

        public static void ObrisiArtistuIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Artista a = s.Load<Artista>(id);

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Akrobate
        public static List<AkrobataBasic> VratiAkrobate()
        {
            List<AkrobataBasic> artisti = new List<AkrobataBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Akrobata> svi_artisti = from a in s.Query<Akrobata>() select a;

                foreach (Akrobata a in svi_artisti)
                {
                    artisti.Add(new AkrobataBasic(a.Id, a.Maticni_Broj, a.Datum_Rodjenja, a.Nadimak, a.Licno_Ime, a.Ime_Roditelja, a.Prezime, a.Pocetak_Rada, a.Pol, a.Mesto_Rodjenja, a.Direktor.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return artisti;
        }
        public static void SacuvajAkrobatu(AkrobataBasic akrobata)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Akrobata a = new Akrobata
                {
                    Maticni_Broj = akrobata.Maticni_Broj,
                    Datum_Rodjenja = akrobata.Datum_Rodjenja,
                    Nadimak = akrobata.Nadimak,
                    Licno_Ime = akrobata.Licno_Ime,
                    Ime_Roditelja = akrobata.Ime_Roditelja,
                    Prezime = akrobata.Prezime,
                    Pocetak_Rada = akrobata.Pocetak_Rada,
                    Pol = akrobata.Pol,
                    Mesto_Rodjenja = akrobata.Mesto_Rodjenja,
                    Direktor = s.Load<Direktor>(akrobata.DirektorId)
                };

                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static AkrobataBasic VratiAkrobatu(int id)
        {
            AkrobataBasic ak = new AkrobataBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Akrobata a = s.Load<Akrobata>(id);
                ak = new AkrobataBasic(a.Id, a.Maticni_Broj, a.Datum_Rodjenja, a.Nadimak, a.Licno_Ime, a.Ime_Roditelja, a.Prezime, a.Pocetak_Rada, a.Pol, a.Mesto_Rodjenja, a.Direktor.Id);

                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ak;
        }

        public static AkrobataBasic AzurirajAkrobatu(AkrobataBasic akrobata)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Akrobata a = s.Load<Akrobata>(akrobata.Id);

                a.Maticni_Broj = akrobata.Maticni_Broj;
                a.Datum_Rodjenja = akrobata.Datum_Rodjenja;
                a.Nadimak = akrobata.Nadimak;
                a.Licno_Ime = akrobata.Licno_Ime;
                a.Ime_Roditelja = akrobata.Ime_Roditelja;
                a.Prezime = akrobata.Prezime;
                a.Pocetak_Rada = akrobata.Pocetak_Rada;
                a.Pol = akrobata.Pol;
                a.Mesto_Rodjenja = akrobata.Mesto_Rodjenja;

                s.Update(a);
                s.Flush();

                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return akrobata;
        }
        public static void ObrisiAkrobatuIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Akrobata a = s.Load<Akrobata>(id);

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Vestine
        public static List<VestinaBasic> VratiVestine(int id_akrobate)
        {
            List<VestinaBasic> vestine = new List<VestinaBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Vestina> vest = from v in s.Query<Vestina>() where v.Akrobata.Id == id_akrobate select v;

                foreach (Vestina v in vest)
                {
                    vestine.Add(new VestinaBasic(v.Id, v.Naziv, v.Broj_Godina, v.Akrobata.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return vestine;
        }

        public static VestinaBasic VratiVestinu(int id)
        {
            VestinaBasic vestina = new VestinaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Vestina v = s.Load<Vestina>(id);
                vestina = new VestinaBasic(v.Id, v.Naziv, v.Broj_Godina, v.Akrobata.Id);

                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return vestina;
        }

        public static VestinaBasic AzurirajVestinu(VestinaBasic vestina)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vestina v = new Vestina
                {
                    Broj_Godina = vestina.Broj_Godina,
                    Naziv = vestina.Naziv,
                    Akrobata = s.Load<Akrobata>(vestina.AkrobataId)
                };

                v.Naziv = vestina.Naziv;
                v.Broj_Godina = vestina.Broj_Godina;

                s.Update(v);
                s.Flush();

                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return vestina;
        }

        public static VestinaBasic SacuvajVestinu(VestinaBasic vestina)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vestina v = s.Load<Vestina>(vestina.Id);

                v.Naziv = vestina.Naziv;
                v.Broj_Godina = vestina.Broj_Godina;

                s.SaveOrUpdate(v);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return vestina;
        }

        public static void ObrisiVestinu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vestina v = s.Load<Vestina>(id);

                s.Delete(v);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #endregion

        #region Asistenti
        public static List<AsistentiBasic> VratiAsistente(int id_artiste_sa_asistentima)
        {
            List<AsistentiBasic> asistenti = new List<AsistentiBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Asistenti> asist = from v in s.Query<Asistenti>() where v.Artista_Sa_Asistentima.Id == id_artiste_sa_asistentima select v;

                foreach (Asistenti a in asist)
                {
                    AsistentiBasic asistent = DTOManager.VratiAsistenta(a.Id);
                    asistenti.Add(asistent);
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return asistenti;
        }
        public static List<AsistentiBasic> VratiSveAsistente()
        {
            List<AsistentiBasic> asistenti = new List<AsistentiBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Asistenti> asist = from v in s.Query<Asistenti>() select v;

                foreach (Asistenti a in asist)
                {
                    AsistentiBasic asistent = DTOManager.VratiAsistenta(a.Id);
                    asistenti.Add(asistent);
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return asistenti;
        }
        public static void SacuvajAsistenta(AsistentiBasic asistent)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Asistenti a = new Asistenti
                {
                    Maticni_Broj = asistent.Maticni_Broj,
                    Datum_Rodjenja = asistent.Datum_Rodjenja,
                    Nadimak = asistent.Nadimak,
                    Licno_Ime = asistent.Licno_Ime,
                    Ime_Roditelja = asistent.Ime_Roditelja,
                    Prezime = asistent.Prezime,
                    Pocetak_Rada = asistent.Pocetak_Rada,
                    Pol = asistent.Pol,
                    Mesto_Rodjenja = asistent.Mesto_Rodjenja,
                    Direktor = s.Load<Direktor>(asistent.DirektorId),
                    Artista_Sa_Asistentima = s.Load<Asistenti>(asistent.Artista_Sa_Asistentima.Id)
                };

                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static AsistentiBasic VratiAsistenta(int id)
        {
            AsistentiBasic ak = new AsistentiBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Asistenti a = s.Load<Asistenti>(id);
                ak = new AsistentiBasic(a.Id, a.Maticni_Broj, a.Datum_Rodjenja, a.Nadimak, a.Licno_Ime, a.Ime_Roditelja, a.Prezime, a.Pocetak_Rada, a.Pol, a.Mesto_Rodjenja, a.Artista_Sa_Asistentima.Id, a.Direktor.Id);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ak;
        }

        public static AsistentiBasic AzurirajAsistenta(AsistentiBasic asistent)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Asistenti a = s.Load<Asistenti>(asistent.Id);

                a.Maticni_Broj = asistent.Maticni_Broj;
                a.Datum_Rodjenja = asistent.Datum_Rodjenja;
                a.Nadimak = asistent.Nadimak;
                a.Licno_Ime = asistent.Licno_Ime;
                a.Ime_Roditelja = asistent.Ime_Roditelja;
                a.Prezime = asistent.Prezime;
                a.Pocetak_Rada = asistent.Pocetak_Rada;
                a.Pol = asistent.Pol;
                a.Mesto_Rodjenja = asistent.Mesto_Rodjenja;
                a.Artista_Sa_Asistentima = s.Load<Asistenti>(asistent.Artista_Sa_Asistentima.Id);

                s.Update(a);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return asistent;
        }
        public static void ObrisiAsistentaIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Asistenti a = s.Load<Asistenti>(id);

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Bacaci_Nozeva
        public static List<BacaciNozevaBasic> VratiBacaceNozeva()
        {
            List<BacaciNozevaBasic> artisti = new List<BacaciNozevaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<BacaciNozeva> svi_artisti = from a in s.Query<BacaciNozeva>() select a;

                foreach (BacaciNozeva a in svi_artisti)
                {
                    artisti.Add(new BacaciNozevaBasic(a.Id, a.Maticni_Broj, a.Datum_Rodjenja, a.Nadimak, a.Licno_Ime, a.Ime_Roditelja, a.Prezime, a.Pocetak_Rada, a.Pol, a.Mesto_Rodjenja, a.Direktor.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return artisti;
        }
        public static void SacuvajBacacaNozeva(BacaciNozevaBasic bacac_nozeva)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BacaciNozeva b = new BacaciNozeva
                {
                    Maticni_Broj = bacac_nozeva.Maticni_Broj,
                    Datum_Rodjenja = bacac_nozeva.Datum_Rodjenja,
                    Nadimak = bacac_nozeva.Nadimak,
                    Licno_Ime = bacac_nozeva.Licno_Ime,
                    Ime_Roditelja = bacac_nozeva.Ime_Roditelja,
                    Prezime = bacac_nozeva.Prezime,
                    Pocetak_Rada = bacac_nozeva.Pocetak_Rada,
                    Pol = bacac_nozeva.Pol,
                    Mesto_Rodjenja = bacac_nozeva.Mesto_Rodjenja,
                    Direktor = s.Load<Direktor>(bacac_nozeva.DirektorId)
                };

                s.Save(b);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static BacaciNozevaBasic VratiBacacaNozeva(int id)
        {
            BacaciNozevaBasic bn = new BacaciNozevaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                BacaciNozeva b = s.Load<BacaciNozeva>(id);
                bn = new BacaciNozevaBasic(b.Id, b.Maticni_Broj, b.Datum_Rodjenja, b.Nadimak, b.Licno_Ime, b.Ime_Roditelja, b.Prezime, b.Pocetak_Rada, b.Pol, b.Mesto_Rodjenja, b.Direktor.Id);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bn;
        }

        public static BacaciNozevaBasic AzurirajBacacaNozeva(BacaciNozevaBasic bacac_nozeva)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BacaciNozeva b = s.Load<BacaciNozeva>(bacac_nozeva.Id);

                b.Maticni_Broj = bacac_nozeva.Maticni_Broj;
                b.Datum_Rodjenja = bacac_nozeva.Datum_Rodjenja;
                b.Nadimak = bacac_nozeva.Nadimak;
                b.Licno_Ime = bacac_nozeva.Licno_Ime;
                b.Ime_Roditelja = bacac_nozeva.Ime_Roditelja;
                b.Prezime = bacac_nozeva.Prezime;
                b.Pocetak_Rada = bacac_nozeva.Pocetak_Rada;
                b.Pol = bacac_nozeva.Pol;
                b.Mesto_Rodjenja = bacac_nozeva.Mesto_Rodjenja;

                s.Update(b);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bacac_nozeva;
        }
        public static void ObrisiBacacaNozevaIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BacaciNozeva a = s.Load<BacaciNozeva>(id);

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Dreseri
        public static void ObrisiDreseraIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dreseri a = s.Load<Dreseri>(id);

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static List<DreseriBasic> VratiDresere()
        {
            List<DreseriBasic> artisti = new List<DreseriBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Dreseri> svi_artisti = from a in s.Query<Dreseri>() select a;

                foreach (Dreseri a in svi_artisti)
                {
                    artisti.Add(new DreseriBasic(a.Id, a.Maticni_Broj, a.Datum_Rodjenja, a.Nadimak, a.Licno_Ime, a.Ime_Roditelja, a.Prezime, a.Pocetak_Rada, a.Pol, a.Mesto_Rodjenja, a.Direktor.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return artisti;
        }
        public static void SacuvajDresera(DreseriBasic dreser)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dreseri d = new Dreseri
                {
                    Maticni_Broj = dreser.Maticni_Broj,
                    Datum_Rodjenja = dreser.Datum_Rodjenja,
                    Nadimak = dreser.Nadimak,
                    Licno_Ime = dreser.Licno_Ime,
                    Ime_Roditelja = dreser.Ime_Roditelja,
                    Prezime = dreser.Prezime,
                    Pocetak_Rada = dreser.Pocetak_Rada,
                    Pol = dreser.Pol,
                    Mesto_Rodjenja = dreser.Mesto_Rodjenja,
                    Direktor = s.Load<Direktor>(dreser.DirektorId)
                };

                s.SaveOrUpdate(d);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DreseriBasic VratiDresera(int id)
        {
            DreseriBasic dr = new DreseriBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Dreseri d = s.Load<Dreseri>(id);
                dr = new DreseriBasic(d.Id, d.Maticni_Broj, d.Datum_Rodjenja, d.Nadimak, d.Licno_Ime, d.Ime_Roditelja, d.Prezime, d.Pocetak_Rada, d.Pol, d.Mesto_Rodjenja, d.Direktor.Id);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dr;
        }

        public static DreseriBasic AzurirajDresera(DreseriBasic dreser)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dreseri d = s.Load<Dreseri>(dreser.Id);

                d.Maticni_Broj = dreser.Maticni_Broj;
                d.Datum_Rodjenja = dreser.Datum_Rodjenja;
                d.Nadimak = dreser.Nadimak;
                d.Licno_Ime = dreser.Licno_Ime;
                d.Ime_Roditelja = dreser.Ime_Roditelja;
                d.Prezime = dreser.Prezime;
                d.Pocetak_Rada = dreser.Pocetak_Rada;
                d.Pol = dreser.Pol;
                d.Mesto_Rodjenja = dreser.Mesto_Rodjenja;

                s.Update(d);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dreser;
        }
        #endregion

        #region Gutaci_Plamena
        public static void ObrisiGutacaPlamenaIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GutaciPlamena a = s.Load<GutaciPlamena>(id);

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static List<GutaciPlamenaBasic> VratiGutacePlamena()
        {
            List<GutaciPlamenaBasic> artisti = new List<GutaciPlamenaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<GutaciPlamena> svi_artisti = from a in s.Query<GutaciPlamena>() select a;

                foreach (GutaciPlamena a in svi_artisti)
                {
                    artisti.Add(new GutaciPlamenaBasic(a.Id, a.Maticni_Broj, a.Datum_Rodjenja, a.Nadimak, a.Licno_Ime, a.Ime_Roditelja, a.Prezime, a.Pocetak_Rada, a.Pol, a.Mesto_Rodjenja, a.Direktor.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return artisti;
        }
        public static void SacuvajGutacaPlamena(GutaciPlamenaBasic gutaci_plamena)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GutaciPlamena gp = new GutaciPlamena
                {
                    Maticni_Broj = gutaci_plamena.Maticni_Broj,
                    Datum_Rodjenja = gutaci_plamena.Datum_Rodjenja,
                    Nadimak = gutaci_plamena.Nadimak,
                    Licno_Ime = gutaci_plamena.Licno_Ime,
                    Ime_Roditelja = gutaci_plamena.Ime_Roditelja,
                    Prezime = gutaci_plamena.Prezime,
                    Pocetak_Rada = gutaci_plamena.Pocetak_Rada,
                    Pol = gutaci_plamena.Pol,
                    Mesto_Rodjenja = gutaci_plamena.Mesto_Rodjenja,
                    Direktor = s.Load<Direktor>(gutaci_plamena.DirektorId)
                };

                s.SaveOrUpdate(gp);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static GutaciPlamenaBasic VratiGutacaPlamena(int id)
        {
            GutaciPlamenaBasic gp = new GutaciPlamenaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                GutaciPlamena g = s.Load<GutaciPlamena>(id);
                gp = new GutaciPlamenaBasic(g.Id, g.Maticni_Broj, g.Datum_Rodjenja, g.Nadimak, g.Licno_Ime, g.Ime_Roditelja, g.Prezime, g.Pocetak_Rada, g.Pol, g.Mesto_Rodjenja, g.Direktor.Id);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return gp;
        }

        public static GutaciPlamenaBasic AzurirajGutacaPlamena(GutaciPlamenaBasic gutac_plamena)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GutaciPlamena gp = s.Load<GutaciPlamena>(gutac_plamena.Id);

                gp.Maticni_Broj = gutac_plamena.Maticni_Broj;
                gp.Datum_Rodjenja = gutac_plamena.Datum_Rodjenja;
                gp.Nadimak = gutac_plamena.Nadimak;
                gp.Licno_Ime = gutac_plamena.Licno_Ime;
                gp.Ime_Roditelja = gutac_plamena.Ime_Roditelja;
                gp.Prezime = gutac_plamena.Prezime;
                gp.Pocetak_Rada = gutac_plamena.Pocetak_Rada;
                gp.Pol = gutac_plamena.Pol;
                gp.Mesto_Rodjenja = gutac_plamena.Mesto_Rodjenja;

                s.Update(gp);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return gutac_plamena;
        }
        #endregion

        #region Klovnovi
        public static void ObrisiKlovnaIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Klovn a = s.Load<Klovn>(id);

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static List<KlovnBasic> VratiKlovnove()
        {
            List<KlovnBasic> artisti = new List<KlovnBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Klovn> svi_artisti = from a in s.Query<Klovn>() select a;

                foreach (Klovn a in svi_artisti)
                {
                    artisti.Add(new KlovnBasic(a.Id, a.Maticni_Broj, a.Datum_Rodjenja, a.Nadimak, a.Licno_Ime, a.Ime_Roditelja, a.Prezime, a.Pocetak_Rada, a.Pol, a.Mesto_Rodjenja, a.Tip, a.Predmet_Za_Zabavu, a.Direktor.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return artisti;
        }
        public static void SacuvajKlovna(KlovnBasic klovn)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Klovn k = new Klovn
                {
                    Maticni_Broj = klovn.Maticni_Broj,
                    Datum_Rodjenja = klovn.Datum_Rodjenja,
                    Nadimak = klovn.Nadimak,
                    Licno_Ime = klovn.Licno_Ime,
                    Ime_Roditelja = klovn.Ime_Roditelja,
                    Prezime = klovn.Prezime,
                    Pocetak_Rada = klovn.Pocetak_Rada,
                    Pol = klovn.Pol,
                    Mesto_Rodjenja = klovn.Mesto_Rodjenja,
                    Tip = klovn.Tip,
                    Predmet_Za_Zabavu = klovn.Predmet_Za_Zabavu,
                    Direktor = s.Load<Direktor>(klovn.DirektorId)
                };

                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static KlovnBasic VratiKlovna(int id)
        {
            KlovnBasic kl = new KlovnBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Klovn k = s.Load<Klovn>(id);
                kl = new KlovnBasic(k.Id, k.Maticni_Broj, k.Datum_Rodjenja, k.Nadimak, k.Licno_Ime, k.Ime_Roditelja, k.Prezime, k.Pocetak_Rada, k.Pol, k.Mesto_Rodjenja, k.Tip, k.Predmet_Za_Zabavu, k.Direktor.Id);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return kl;
        }

        public static KlovnBasic AzurirajKlovna(KlovnBasic klovn)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Klovn k = s.Load<Klovn>(klovn.Id);

                k.Maticni_Broj = klovn.Maticni_Broj;
                k.Datum_Rodjenja = klovn.Datum_Rodjenja;
                k.Nadimak = klovn.Nadimak;
                k.Licno_Ime = klovn.Licno_Ime;
                k.Ime_Roditelja = klovn.Ime_Roditelja;
                k.Prezime = klovn.Prezime;
                k.Pocetak_Rada = klovn.Pocetak_Rada;
                k.Pol = klovn.Pol;
                k.Mesto_Rodjenja = klovn.Mesto_Rodjenja;
                k.Tip = klovn.Tip;
                k.Predmet_Za_Zabavu = klovn.Predmet_Za_Zabavu;

                s.Update(k);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return klovn;
        }
        #endregion

        #region Zongleri
        public static void ObrisiZongleraIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zongler a = s.Load<Zongler>(id);

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static List<ZonglerBasic> VratiZonglere()
        {
            List<ZonglerBasic> artisti = new List<ZonglerBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zongler> svi_artisti = from a in s.Query<Zongler>() select a;

                foreach (Zongler a in svi_artisti)
                {
                    artisti.Add(new ZonglerBasic(a.Id, a.Maticni_Broj, a.Datum_Rodjenja, a.Nadimak, a.Licno_Ime, a.Ime_Roditelja, a.Prezime, a.Pocetak_Rada, a.Pol, a.Mesto_Rodjenja, a.Naziv, a.Broj_Predmeta, a.Direktor.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return artisti;
        }
        public static void SacuvajZonglera(ZonglerBasic zongler)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zongler z = new Zongler
                {
                    Maticni_Broj = zongler.Maticni_Broj,
                    Datum_Rodjenja = zongler.Datum_Rodjenja,
                    Nadimak = zongler.Nadimak,
                    Licno_Ime = zongler.Licno_Ime,
                    Ime_Roditelja = zongler.Ime_Roditelja,
                    Prezime = zongler.Prezime,
                    Pocetak_Rada = zongler.Pocetak_Rada,
                    Pol = zongler.Pol,
                    Mesto_Rodjenja = zongler.Mesto_Rodjenja,
                    Naziv = zongler.Naziv,
                    Broj_Predmeta = zongler.Broj_Predmeta,
                    Direktor = s.Load<Direktor>(zongler.Direktor.Id)
                };

                s.SaveOrUpdate(z);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static ZonglerBasic VratiZonglera(int id)
        {
            ZonglerBasic zg = new ZonglerBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Zongler z = s.Load<Zongler>(id);
                zg = new ZonglerBasic(z.Id, z.Maticni_Broj, z.Datum_Rodjenja, z.Nadimak, z.Licno_Ime, z.Ime_Roditelja, z.Prezime, z.Pocetak_Rada, z.Pol, z.Mesto_Rodjenja, z.Naziv, z.Broj_Predmeta, z.Direktor.Id);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zg;
        }

        public static ZonglerBasic AzurirajZonglera(ZonglerBasic zongler)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zongler z = s.Load<Zongler>(zongler.Id);

                z.Maticni_Broj = zongler.Maticni_Broj;
                z.Datum_Rodjenja = zongler.Datum_Rodjenja;
                z.Nadimak = zongler.Nadimak;
                z.Licno_Ime = zongler.Licno_Ime;
                z.Ime_Roditelja = zongler.Ime_Roditelja;
                z.Prezime = zongler.Prezime;
                z.Pocetak_Rada = zongler.Pocetak_Rada;
                z.Pol = zongler.Pol;
                z.Mesto_Rodjenja = zongler.Mesto_Rodjenja;
                z.Naziv = zongler.Naziv;
                z.Broj_Predmeta = zongler.Broj_Predmeta;

                s.Update(z);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zongler;
        }
        #endregion

        #endregion

        #region Angazuje_Artistu
        public static List<AngazujeArtistuBasic> VratiAngazovaneArtiste(int cirkuska_tacka_id)
        {
            List<AngazujeArtistuBasic> angazovani_artisti = new List<AngazujeArtistuBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<AngazujeArtistu> artisti = from a in s.Query<AngazujeArtistu>() where a.Cirkuska_Tacka.Id == cirkuska_tacka_id select a;

                foreach (AngazujeArtistu a in artisti)
                {
                    ArtistaBasic artista = DTOManager.VratiArtistu(a.Artista.Id);
                    CirkuskaTackaBasic cirkuska_tacka = DTOManager.VratiCirkuskuTacku(a.Cirkuska_Tacka.Id);
                    angazovani_artisti.Add(new AngazujeArtistuBasic(a.Id, artista, cirkuska_tacka));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return angazovani_artisti;
        }

        public static void ObrisiArtistu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AngazujeArtistu artista = s.Load<AngazujeArtistu>(id);

                s.Delete(artista);
                s.Flush();

                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SacuvajAngazujeArtistu(AngazujeArtistuBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AngazujeArtistu an = new AngazujeArtistu
                {
                    Artista = s.Load<Artista>(a.Artista.Id),
                    Cirkuska_Tacka = s.Load<CirkuskaTacka>(a.Cirkuska_Tacka.Id)
                };

                s.Save(an);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Angazuje_Zivotinju
        /*public static List<ZivotinjaBasic> VratiAngazovaneZivotinje(int cirkuska_tacka_id)
        {
            List<ZivotinjaBasic> angazovani_artisti = new List<ZivotinjaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<AngazujeZivotinju> zivotinje = from z in s.Query<AngazujeZivotinju>() where z.Cirkuska_Tacka.Id == cirkuska_tacka_id select z;

                foreach (AngazujeZivotinju z in zivotinje)
                {
                    ZivotinjaBasic zivotinja = DTOManager.VratiZivotinju(z.Zivotinja.Id);
                    //CirkuskaTackaBasic cirkuska_tacka = DTOManager.VratiCirkuskuTacku(z.Cirkuska_Tacka.Id);
                    angazovani_artisti.Add(new ZivotinjaBasic(z.Zivotinja.Id, z.Zivotinja.Nadimak, z.Zivotinja.Vrsta, z.Zivotinja.Pol, z.Zivotinja.Starost, z.Zivotinja.Vreme_Boravka, z.Zivotinja.Datum_Veterinarskog_Pregleda, z.Zivotinja.Broj_Kaveza, z.Zivotinja.Tezina, z.Zivotinja.Dreser.Id, z.Zivotinja.Direktor.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return angazovani_artisti;
        }*/

        public static List<AngazujeZivotinjuBasic> VratiAngazovaneZivotinje(int cirkuska_tacka_id)
        {
            List<AngazujeZivotinjuBasic> angazovane_zivotinje = new List<AngazujeZivotinjuBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<AngazujeZivotinju> zivotinje = from a in s.Query<AngazujeZivotinju>() where a.Cirkuska_Tacka.Id == cirkuska_tacka_id select a;

                foreach (AngazujeZivotinju a in zivotinje)
                {
                    ZivotinjaBasic zivotinja = DTOManager.VratiZivotinju(a.Zivotinja.Id);
                    CirkuskaTackaBasic cirkuska_tacka = DTOManager.VratiCirkuskuTacku(a.Cirkuska_Tacka.Id);
                    angazovane_zivotinje.Add(new AngazujeZivotinjuBasic(a.Id, zivotinja, cirkuska_tacka));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return angazovane_zivotinje;
        }

        public static void ObrisiAngazujeZivotinju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AngazujeZivotinju zivotinja = s.Load<AngazujeZivotinju>(id);

                s.Delete(zivotinja);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SacuvajAngazujeZivotinju(AngazujeZivotinjuBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AngazujeZivotinju an = new AngazujeZivotinju
                {
                    Zivotinja = s.Load<Zivotinja>(z.Zivotinja.Id),
                    Cirkuska_Tacka = s.Load<CirkuskaTacka>(z.Cirkuska_Tacka.Id)
                };

                s.Save(an);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Cirkuske_Tacke
        public static List<CirkuskaTackaPregled> VratiCirkuskeTackePredstave(int id_predstave)
        {
            List<CirkuskaTackaPregled> cirkuske_tacke = new List<CirkuskaTackaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<CirkuskaTacka> svi_artisti = from a in s.Query<CirkuskaTacka>() where a.Pripada_Predstavi.Id == id_predstave select a;

                foreach (CirkuskaTacka ct in svi_artisti)
                {
                    cirkuske_tacke.Add(new CirkuskaTackaPregled(ct.Id, ct.Ime, ct.Tip, ct.Opasni_Efekti, ct.Donja_Granica_Uzrasta, ct.Pripada_Predstavi.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cirkuske_tacke;
        }
        public static List<CirkuskaTackaBasic> VratiSveCirkuskeTackeBasic()
        {
            List<CirkuskaTackaBasic> cirkuske_tacke = new List<CirkuskaTackaBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<CirkuskaTacka> ct = from a in s.Query<CirkuskaTacka>() select a;

                foreach (CirkuskaTacka c in ct)
                {
                    CirkuskaTackaBasic cirkuska_tacka = DTOManager.VratiCirkuskuTacku(c.Id);
                    cirkuske_tacke.Add(cirkuska_tacka);
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cirkuske_tacke;
        }
        public static CirkuskaTackaBasic VratiCirkuskuTacku(int id)
        {
            CirkuskaTackaBasic cirkuska_tacka = new CirkuskaTackaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                CirkuskaTacka ct = s.Load<CirkuskaTacka>(id);
                cirkuska_tacka = new CirkuskaTackaBasic(ct.Id, ct.Ime, ct.Tip, ct.Opasni_Efekti, ct.Donja_Granica_Uzrasta, ct.Pripada_Predstavi.Id);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cirkuska_tacka;
        }
        public static void ObrisiCirkuskuTackuIzSistema(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                CirkuskaTacka ct = s.Load<CirkuskaTacka>(id);

                s.Delete(ct);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DodajCirkuskuTacku(CirkuskaTackaBasic cirkuska_tacka)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                CirkuskaTacka ct = new CirkuskaTacka
                {
                    Ime = cirkuska_tacka.Ime,
                    Tip = cirkuska_tacka.Tip,
                    Opasni_Efekti = cirkuska_tacka.Opasni_Efekti,
                    Donja_Granica_Uzrasta = cirkuska_tacka.Donja_Granica_Uzrasta,
                    Pripada_Predstavi = s.Load<Predstava>(cirkuska_tacka.Predstava_Id)
                };

                s.SaveOrUpdate(ct);

                s.Flush();

                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static CirkuskaTackaBasic AzurirajCirkuskuTacku(CirkuskaTackaBasic cirkuska_tacka)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                CirkuskaTacka ct = s.Load<CirkuskaTacka>(cirkuska_tacka.Id);

                ct.Ime = cirkuska_tacka.Ime;
                ct.Tip = cirkuska_tacka.Tip;
                ct.Opasni_Efekti = cirkuska_tacka.Opasni_Efekti;
                ct.Donja_Granica_Uzrasta = cirkuska_tacka.Donja_Granica_Uzrasta;

                s.Update(ct);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return cirkuska_tacka;
        }
        #endregion

        #region Direktori
        public static List<DirektorBasic> VratiSveDirektoreBasic()
        {
            List<DirektorBasic> direktori = new List<DirektorBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Direktor> direkt = from d in s.Query<Direktor>() select d;

                foreach (Direktor d in direkt)
                {
                    DirektorBasic direktor = DTOManager.VratiDirektora(d.Id);
                    direktori.Add(direktor);
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return direktori;
        }
        public static DirektorBasic VratiDirektora(int id)
        {
            DirektorBasic direktor = new DirektorBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Direktor dt = s.Load<Direktor>(id);
                direktor = new DirektorBasic(dt.Id, dt.Licno_Ime, dt.Srednje_Slovo, dt.Prezime);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return direktor;
        }
        public static void ObrisiDirektora(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Direktor dt = s.Load<Direktor>(id);

                s.Delete(dt);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DodajDirektora(DirektorBasic direktor)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Direktor dt = new Direktor
                {
                    Licno_Ime = direktor.Licno_Ime,
                    Srednje_Slovo = direktor.Srednje_Slovo,
                    Prezime = direktor.Prezime
                };

                s.SaveOrUpdate(dt);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DirektorBasic AzurirajDirektora(DirektorBasic direktor)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Direktor dt = s.Load<Direktor>(direktor.Id);

                dt.Licno_Ime = direktor.Licno_Ime;
                dt.Srednje_Slovo = direktor.Srednje_Slovo;
                dt.Prezime = direktor.Prezime;

                s.Update(dt);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return direktor;
        }

        #region Telefoni_Direktora
        public static IList<TelefonDirektoraPregled> VratiTelefoneDirektora(int id_direktora)
        {
            List<TelefonDirektoraPregled> telefoni_direktora = new List<TelefonDirektoraPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TelefonDirektora> svi_telefoni = from a in s.Query<TelefonDirektora>() where a.Direktor.Id == id_direktora select a;

                foreach (TelefonDirektora td in svi_telefoni)
                {
                    telefoni_direktora.Add(new TelefonDirektoraPregled(td.Id, td.Broj_Telefona, td.Direktor.Id));
                }

                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return telefoni_direktora;
        }
        public static void ObrisiTelefon(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TelefonDirektora td = s.Load<TelefonDirektora>(id);

                s.Delete(td);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DodajTelefon(TelefonDirektoraBasic telefon)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TelefonDirektora td = new TelefonDirektora
                {
                    Direktor = s.Load<Direktor>(telefon.Direktor_Id),
                    Broj_Telefona = telefon.Broj_Telefona
                };

                s.SaveOrUpdate(td);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static TelefonDirektoraBasic AzurirajBrojTelefona(TelefonDirektoraBasic telefon)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TelefonDirektora td = s.Load<TelefonDirektora>(telefon.Id);

                td.Broj_Telefona = telefon.Broj_Telefona;

                s.Update(td);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return telefon;
        }
        #endregion

        #region Emailovi_Direktora
        public static IList<EmailDirektoraPregled> VratiEmailoveDirektora(int id_direktora) 
        {
            List<EmailDirektoraPregled> emailovi_direktora = new List<EmailDirektoraPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<EmailDirektora> svi_emailovi = from a in s.Query<EmailDirektora>() where a.Direktor.Id == id_direktora select a;

                foreach (EmailDirektora a in svi_emailovi)
                {
                    emailovi_direktora.Add(new EmailDirektoraPregled(a.Id, a.Email, a.Direktor.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return emailovi_direktora;
        }
        public static void ObrisiEmail(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                EmailDirektora ed = s.Load<EmailDirektora>(id);

                s.Delete(ed);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DodajEmail(EmailDirektoraBasic email)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                EmailDirektora ed = new EmailDirektora
                {
                    Direktor = s.Load<Direktor>(email.Direktor_Id),
                    Email = email.Email
                };

                s.SaveOrUpdate(ed);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static EmailDirektoraBasic AzurirajEmail(EmailDirektoraBasic email)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                EmailDirektora ed = s.Load<EmailDirektora>(email.Id);

                ed.Email = email.Email;

                s.Update(ed);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return email;
        }
        #endregion

        #endregion

        #region Gradovi
        public static List<GradBasic> VratiSveGradoveBasic()
        {
            List<GradBasic> gradovi = new List<GradBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Grad> grad = from d in s.Query<Grad>() select d;

                foreach (Grad d in grad)
                {
                    GradBasic g = DTOManager.VratiGrad(d.Id);
                    gradovi.Add(g);
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return gradovi;
        }
        public static GradBasic VratiGrad(int id)
        {
            GradBasic grad = new GradBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Grad gr = s.Load<Grad>(id);
                grad = new GradBasic(gr.Id, gr.Naziv_Drzave, gr.Naziv_Grada, gr.Datum_Od, gr.Datum_Do, gr.Opis);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return grad;
        }
        public static void ObrisiGrad(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad gr = s.Load<Grad>(id);

                s.Delete(gr);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DodajGrad(GradBasic grad)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad dt = new Grad
                {
                    Naziv_Drzave = grad.Naziv_Drzave,
                    Naziv_Grada = grad.Naziv_Grada,
                    Datum_Od = grad.Datum_Od,
                    Datum_Do = grad.Datum_Do
                };

                s.SaveOrUpdate(dt);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static GradBasic AzurirajGrad(GradBasic grad)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad gr = s.Load<Grad>(grad.Id);

                gr.Naziv_Drzave = grad.Naziv_Drzave;
                gr.Naziv_Grada = grad.Naziv_Grada;
                gr.Datum_Od = grad.Datum_Od;
                gr.Datum_Do = grad.Datum_Do;
                gr.Opis = grad.Opis;

                s.Update(gr);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return grad;
        }
        #endregion

        #region Grad_Predstava
        public static List<GradPredstavaBasic> VratiGradoveSaPredstavama(int grad_id)
        {
            List<GradPredstavaBasic> grad_predstava = new List<GradPredstavaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<GradPredstavaBasic> gradovi = from a in s.Query<GradPredstavaBasic>() where a.Grad.Id == grad_id select a;

                foreach (GradPredstavaBasic g in gradovi)
                {
                    GradBasic grad = DTOManager.VratiGrad(g.Id);
                    PredstavaBasic predstava = DTOManager.VratiPredstavu(g.Predstava.Id);
                    grad_predstava.Add(new GradPredstavaBasic(g.Id, g.Vreme_Odrzavanja, g.Broj_Prodatih_Karata, grad, predstava));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return grad_predstava;
        }

        public static void ObrisiGradPredstava(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GradPredstava grad_predstava = s.Load<GradPredstava>(id);

                s.Delete(grad_predstava);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SacuvajGradPredstava(GradPredstavaBasic gp)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GradPredstava grad_predstava = new GradPredstava
                {
                    Grad = s.Load<Grad>(gp.Grad.Id),
                    Predstava = s.Load<Predstava>(gp.Predstava.Id)
                };

                s.Save(grad_predstava);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Pomocno_Osoblje
        public static List<PomocnoOsobljeBasic> VratiPomocnoOsobljeBasic()
        {
            List<PomocnoOsobljeBasic> pomocno_osoblje = new List<PomocnoOsobljeBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<PomocnoOsoblje> pomocne_osobe = from p in s.Query<PomocnoOsoblje>() select p;

                foreach (PomocnoOsoblje po in pomocne_osobe)
                {
                    pomocno_osoblje.Add(new PomocnoOsobljeBasic(po.Id, po.Maticni_Broj, po.Licno_Ime, po.Srednje_Slovo, po.Prezime, po.Pol, po.Mesto_Rodjenja, po.Datum_Rodjenja, po.Direktor.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pomocno_osoblje;
        }
        public static PomocnoOsobljeBasic VratiPomocnuOsobu(int id)
        {
            PomocnoOsobljeBasic pomocna_osoba = new PomocnoOsobljeBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                PomocnoOsoblje po = s.Load<PomocnoOsoblje>(id);
                pomocna_osoba = new PomocnoOsobljeBasic(po.Id, po.Maticni_Broj, po.Licno_Ime, po.Srednje_Slovo, po.Prezime, po.Pol, po.Mesto_Rodjenja, po.Datum_Rodjenja, po.Direktor.Id);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return pomocna_osoba;
        }
        public static void ObrisiPomocnuOsobu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PomocnoOsoblje po = s.Load<PomocnoOsoblje>(id);

                s.Delete(po);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DodajPomocnuOsobu(PomocnoOsobljeBasic pomocno_osoblje)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PomocnoOsoblje dt = new PomocnoOsoblje
                {
                    Maticni_Broj = pomocno_osoblje.Maticni_Broj,
                    Licno_Ime = pomocno_osoblje.Licno_Ime,
                    Srednje_Slovo = pomocno_osoblje.Srednje_Slovo,
                    Prezime = pomocno_osoblje.Prezime,
                    Pol = pomocno_osoblje.Pol,
                    Mesto_Rodjenja = pomocno_osoblje.Mesto_Rodjenja,
                    Datum_Rodjenja = pomocno_osoblje.Datum_Rodjenja,
                    Direktor = s.Load<Direktor>(pomocno_osoblje.Direktor_Id)
                };

                s.SaveOrUpdate(dt);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static PomocnoOsobljeBasic AzurirajPomocnuOsobu(PomocnoOsobljeBasic pomocna_osoba)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PomocnoOsoblje po = s.Load<PomocnoOsoblje>(pomocna_osoba.Id);

                po.Maticni_Broj = pomocna_osoba.Maticni_Broj;
                po.Licno_Ime = pomocna_osoba.Licno_Ime;
                po.Srednje_Slovo = pomocna_osoba.Srednje_Slovo;
                po.Prezime = pomocna_osoba.Prezime;
                po.Pol = pomocna_osoba.Pol;
                po.Mesto_Rodjenja = pomocna_osoba.Mesto_Rodjenja;
                po.Datum_Rodjenja = pomocna_osoba.Datum_Rodjenja;
                po.Direktor = s.Load<Direktor>(pomocna_osoba.Direktor_Id);

                s.Update(po);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return pomocna_osoba;
        }
        #endregion

        #region Predstave
        public static List<PredstavaBasic> VratiSvePredstave()
        {
            List<PredstavaBasic> sve_predstave = new List<PredstavaBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Predstava> predstave = from p in s.Query<Predstava>() select p;

                foreach (Predstava predstava in predstave)
                {
                    PredstavaBasic p = DTOManager.VratiPredstavu(predstava.Id);
                    sve_predstave.Add(p);
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sve_predstave;
        }
        public static PredstavaBasic VratiPredstavu(int id)
        {
            PredstavaBasic predstava = new PredstavaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Predstava pr = s.Load<Predstava>(id);
                if (pr.Tip_Predstave == 0)
                {
                    predstava = new RedovnaPredstavaBasic(pr.Id);
                }
                else if (pr.Tip_Predstave==1 && pr.Razlog_Organizovanja == 0)
                {
                    predstava = new HumanitarnaPredstavaBasic(pr.Id, pr.Prihod, pr.Namenjen_Prihod);
                }
                else
                {
                    predstava = new NarucenaPredstavaBasic(pr.Id, pr.Naziv, pr.Adresa);
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return predstava;
        }
        public static void ObrisiPredstavu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstava predstava = s.Load<Predstava>(id);

                s.Delete(predstava);
                s.Flush();

                s.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Redovna_Predstava
        public static List<RedovnaPredstavaBasic> VratiRedovnePredstave()
        {
            List<RedovnaPredstavaBasic> redovne_predstave = new List<RedovnaPredstavaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<RedovnaPredstava> predstave = from p in s.Query<RedovnaPredstava>() select p;

                foreach (RedovnaPredstava p in predstave)
                {
                    redovne_predstave.Add(new RedovnaPredstavaBasic(p.Id));
                }

                s.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return redovne_predstave;
        }
        public static void DodajRedovnuPredstavu()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RedovnaPredstava p = new RedovnaPredstava 
                {
                    Razlog_Organizovanja = null,
                    Prihod = null,
                    Namenjen_Prihod = null,
                    Naziv = null,
                    Adresa = null,
                    Brojevi_Telefona_Narucioca = null
                };

                s.Save(p);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Humanitarna_Predstava
        public static List<HumanitarnaPredstavaBasic> VratiHumanitarnePredstave()
        {
            List<HumanitarnaPredstavaBasic> humanitarne_predstave = new List<HumanitarnaPredstavaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<HumanitarnaPredstava> predstave = from p in s.Query<HumanitarnaPredstava>() where p.Razlog_Organizovanja==0 select p;

                foreach (HumanitarnaPredstava p in predstave)
                {
                    humanitarne_predstave.Add(new HumanitarnaPredstavaBasic(p.Id, p.Prihod, p.Namenjen_Prihod));
                }

                s.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return humanitarne_predstave;
        }

        public static HumanitarnaPredstavaBasic VratiHumanitarnuPredstavu(int id)
        {
            HumanitarnaPredstavaBasic predstava = new HumanitarnaPredstavaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                HumanitarnaPredstava pr = s.Load<HumanitarnaPredstava>(id);
                predstava = new HumanitarnaPredstavaBasic(pr.Id, pr.Prihod, pr.Namenjen_Prihod);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return predstava;
        }
        public static void DodajHumanitarnuPredstavu(HumanitarnaPredstavaBasic predstava)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                HumanitarnaPredstava p = new HumanitarnaPredstava
                {
                    Razlog_Organizovanja = 0,
                    Prihod = predstava.Prihod,
                    Namenjen_Prihod = predstava.Namenjen_Prihod,
                    Naziv = null,
                    Adresa = null,
                    Brojevi_Telefona_Narucioca = null
                };

                s.Save(p);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void AzurirajHumanitarnuPredstavu(HumanitarnaPredstavaBasic predstava)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                HumanitarnaPredstava p = s.Load<HumanitarnaPredstava>(predstava.Id);

                p.Prihod = predstava.Prihod;
                p.Namenjen_Prihod = predstava.Namenjen_Prihod;

                s.SaveOrUpdate(p);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Narucena_Predstava
        public static List<NarucenaPredstavaBasic> VratiNarucenePredstave()
        {
            List<NarucenaPredstavaBasic> narucene_predstave = new List<NarucenaPredstavaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<NarucenaPredstava> predstave = from p in s.Query<NarucenaPredstava>() where p.Razlog_Organizovanja==1 select p;

                foreach (NarucenaPredstava p in predstave)
                {
                    narucene_predstave.Add(new NarucenaPredstavaBasic(p.Id, p.Naziv, p.Adresa));
                }

                s.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return narucene_predstave;
        }

        public static NarucenaPredstavaBasic VratiNarucenuPredstavu(int id)
        {
            NarucenaPredstavaBasic predstava = new NarucenaPredstavaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                NarucenaPredstava pr = s.Load<NarucenaPredstava>(id);
                predstava = new NarucenaPredstavaBasic(pr.Id, pr.Naziv, pr.Adresa);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return predstava;
        }
        public static void DodajNarucenuPredstavu(NarucenaPredstavaBasic predstava)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NarucenaPredstava p = new NarucenaPredstava
                {
                    Razlog_Organizovanja = 1,
                    Prihod = null,
                    Namenjen_Prihod = null,
                    Naziv = predstava.Naziv,
                    Adresa = predstava.Adresa,
                    Brojevi_Telefona_Narucioca = new List<TelefonNarucioca>()
                };

                s.Save(p);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void AzurirajNarucenuPredstavu(NarucenaPredstavaBasic predstava)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NarucenaPredstava p = s.Load<NarucenaPredstava>(predstava.Id);

                p.Naziv = predstava.Naziv;
                p.Adresa = predstava.Adresa;

                s.SaveOrUpdate(p);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Telefoni_Narucioca
        public static List<TelefonNaruciocaBasic> VratiTelefoneNarucioca(int id_predstave)
        {
            List<TelefonNaruciocaBasic> telefoni_narucioca = new List<TelefonNaruciocaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<TelefonNarucioca> svi_telefoni = from a in s.Query<TelefonNarucioca>() where a.Narucioc_Predstave.Id == id_predstave select a;

                foreach (TelefonNarucioca tn in svi_telefoni)
                {
                    telefoni_narucioca.Add(new TelefonNaruciocaBasic(tn.Id, tn.Broj_Telefona, tn.Narucioc_Predstave.Id));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return telefoni_narucioca;
        }
        public static void ObrisiTelefonNarucioca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TelefonNarucioca tn = s.Load<TelefonNarucioca>(id);

                s.Delete(tn);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DodajTelefonNarucioca(TelefonNaruciocaBasic telefon)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TelefonNarucioca tn = new TelefonNarucioca
                {
                    Narucioc_Predstave = s.Load<Predstava>(telefon.Narucioc_Predstave_Id),
                    Broj_Telefona = telefon.Broj_Telefona
                };

                s.SaveOrUpdate(tn);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static TelefonNaruciocaBasic AzurirajBrojTelefonaNarucioca(TelefonNaruciocaBasic telefon)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TelefonNarucioca tn = s.Load<TelefonNarucioca>(telefon.Id);

                tn.Broj_Telefona = telefon.Broj_Telefona;

                s.Update(tn);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return telefon;
        }
        #endregion

        #endregion

        #region Zaduzen
        public static List<ZaduzenBasic> VratiZaduzeneOsobe(int cirkuska_tacka_id)
        {
            List<ZaduzenBasic> zaduzeno_osoblje = new List<ZaduzenBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaduzen> zaduzeni = from a in s.Query<Zaduzen>() where a.Cirkuska_Tacka.Id == cirkuska_tacka_id select a;

                foreach (Zaduzen a in zaduzeni)
                {
                    PomocnoOsobljeBasic pomocna_osoba = DTOManager.VratiPomocnuOsobu(a.Pomocno_Osoblje.Id);
                    CirkuskaTackaBasic cirkuska_tacka = DTOManager.VratiCirkuskuTacku(a.Cirkuska_Tacka.Id);
                    zaduzeno_osoblje.Add(new ZaduzenBasic(a.Id, pomocna_osoba, cirkuska_tacka));
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zaduzeno_osoblje;
        }

        public static void ObrisiZaduzenuOsobu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaduzen zaduzena_osoba = s.Load<Zaduzen>(id);

                s.Delete(zaduzena_osoba);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SacuvajZaduzenuOsobu(ZaduzenBasic z)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaduzen zaduzen = new Zaduzen
                {
                    Pomocno_Osoblje = s.Load<PomocnoOsoblje>(z.Pomocno_Osoblje.Id),
                    Cirkuska_Tacka = s.Load<CirkuskaTacka>(z.Cirkuska_Tacka.Id)
                };

                s.Save(zaduzen);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Zivotinje
        public static List<ZivotinjaBasic> VratiZivotinjeDresera(int id_dresera)
        {
            List<ZivotinjaBasic> zivotinje = new List<ZivotinjaBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zivotinja> ziv = from v in s.Query<Zivotinja>() where v.Dreser.Id == id_dresera select v;

                foreach (Zivotinja z in ziv)
                {
                    ZivotinjaBasic zivotinja = DTOManager.VratiZivotinju(z.Id);
                    zivotinje.Add(zivotinja);
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zivotinje;
        }
        public static List<ZivotinjaBasic> VratiZivotinje()
        {
            List<ZivotinjaBasic> zivotinje = new List<ZivotinjaBasic>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zivotinja> ziv = from d in s.Query<Zivotinja>() select d;

                foreach (Zivotinja po in ziv)
                {
                    ZivotinjaBasic p = DTOManager.VratiZivotinju(po.Id);
                    zivotinje.Add(p);
                }

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zivotinje;
        }
        public static ZivotinjaBasic VratiZivotinju(int id)
        {
            ZivotinjaBasic zivotinja = new ZivotinjaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinja zi = s.Load<Zivotinja>(id);
                zivotinja = new ZivotinjaBasic(zi.Id, zi.Nadimak, zi.Vrsta, zi.Pol, zi.Starost, zi.Vreme_Boravka, zi.Datum_Veterinarskog_Pregleda, zi.Broj_Kaveza, zi.Tezina, zi.Dreser.Id, zi.Direktor.Id);

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return zivotinja;
        }
        public static void ObrisiZivotinju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinja po = s.Load<Zivotinja>(id);

                s.Delete(po);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DodajZivotinju(ZivotinjaBasic zivotinja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinja zv = new Zivotinja
                {
                    Nadimak = zivotinja.Nadimak,
                    Vrsta = zivotinja.Vrsta,
                    Pol = zivotinja.Pol,
                    Starost = zivotinja.Starost,
                    Vreme_Boravka = zivotinja.Vreme_Boravka,
                    Datum_Veterinarskog_Pregleda = zivotinja.Datum_Veterinarskog_Pregleda,
                    Broj_Kaveza = zivotinja.Broj_Kaveza,
                    Tezina = zivotinja.Tezina,
                    Dreser = s.Load<Dreseri>(zivotinja.Dreser.Id),
                    Direktor = s.Load<Direktor>(zivotinja.Direktor.Id)
                };

                s.SaveOrUpdate(zv);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static ZivotinjaBasic AzurirajZivotinju(ZivotinjaBasic zivotinja)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zivotinja zv = s.Load<Zivotinja>(zivotinja.Id);

                zv.Nadimak = zivotinja.Nadimak;
                zv.Vrsta = zivotinja.Vrsta;
                zv.Pol = zivotinja.Pol;
                zv.Starost = zivotinja.Starost;
                zv.Vreme_Boravka = zivotinja.Vreme_Boravka;
                zv.Datum_Veterinarskog_Pregleda = zivotinja.Datum_Veterinarskog_Pregleda;
                zv.Broj_Kaveza = zivotinja.Broj_Kaveza;
                zv.Tezina = zivotinja.Tezina;
                zv.Dreser = s.Load<Dreseri>(zivotinja.Dreser.Id);
                zv.Direktor = s.Load<Direktor>(zivotinja.Direktor.Id);

                s.Update(zv);
                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return zivotinja;
        }
        #endregion
    }
}
