using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// baza ADR
    /// </summary>
    public partial class AdrUn
    {
        public int IdAdrUn { get; set; }
        /// <summary>
        /// 0/1 gdy powinien pojawić się tekxt NIE PODLEGA ADR
        /// </summary>
        public int? Niepodlega { get; set; }
        /// <summary>
        /// 0/1 gdy powinien pojawić się tekst PRZEWÓZ ZABRONIONY
        /// </summary>
        public int? Przewzabr { get; set; }
        /// <summary>
        /// 0/1 gdy powinien pojawić się tekst RID: PRZEWÓZ ZABRONONY
        /// </summary>
        public int? Przewzabrrid { get; set; }
        /// <summary>
        /// dodatkowy tekst jaki pojawia sią za NIE PODLEGA ADR
        /// </summary>
        public string Niepodlegainfo { get; set; }
        public string Przewzabrinfo { get; set; }
        /// <summary>
        /// Kod UN
        /// </summary>
        public string Un { get; set; }
        /// <summary>
        /// Klasa
        /// </summary>
        public string Klasa { get; set; }
        /// <summary>
        /// Kod klasyfikacyjny
        /// </summary>
        public string KodKlasy { get; set; }
        /// <summary>
        /// Grupa pakowania
        /// </summary>
        public string GrupaPakowania { get; set; }
        /// <summary>
        /// Nalepki ADR/RID
        /// </summary>
        public string Nalepki { get; set; }
        /// <summary>
        /// Nalepki RID
        /// </summary>
        public string NalepkiRid { get; set; }
        /// <summary>
        /// Przepisy szczególne
        /// </summary>
        public string Przepisy { get; set; }
        /// <summary>
        /// Ilości ograniczone (bez ADR)
        /// </summary>
        public string IloscOgraniczona { get; set; }
        /// <summary>
        /// Ilości ograniczone - LQ-2011
        /// </summary>
        public string IlosciOgrLq2011 { get; set; }
        /// <summary>
        /// Ilości wyłaczone
        /// </summary>
        public string IlosciWylacz { get; set; }
        /// <summary>
        /// Instrukcje pakowania
        /// </summary>
        public string OpakInstr { get; set; }
        /// <summary>
        /// Szczególne przepisy pakowania
        /// </summary>
        public string OpakPrzepisy { get; set; }
        /// <summary>
        /// Przepisy dotyczące pakowania razem
        /// </summary>
        public string OpakPakRazem { get; set; }
        /// <summary>
        /// Instrukcje dla cystern przenośnych  i kontenerów do przewozu luzem
        /// </summary>
        public string CystpInstr { get; set; }
        /// <summary>
        /// Przepisy szczególne dla cystern przenośnych i kontenerów do przewozu luzem
        /// </summary>
        public string CystpPrzepisy { get; set; }
        /// <summary>
        /// Kod cysterny dla cystern ADR
        /// </summary>
        public string CystAdrKod { get; set; }
        /// <summary>
        /// Przepisy szczególne dla cystern ADR
        /// </summary>
        public string CystAdrPrzepisy { get; set; }
        /// <summary>
        /// Pojazdy do przewozu w cysternach
        /// </summary>
        public string PojazdCystAdr { get; set; }
        /// <summary>
        /// Kategoria transportowa
        /// </summary>
        public string KategoriaTransp { get; set; }
        /// <summary>
        /// Mnożnik
        /// </summary>
        public string Mnoznik { get; set; }
        /// <summary>
        /// Ilość na jednostkę transportową
        /// </summary>
        public string IloscJt { get; set; }
        /// <summary>
        /// Kod ograniczeń przewozu przez tunele
        /// </summary>
        public string OgrTunele { get; set; }
        /// <summary>
        /// Przepisy szczególne dotyczące przewozu - sztuki przesyłki
        /// </summary>
        public string PrzepisySzt { get; set; }
        /// <summary>
        /// Przepisy szczególne dotyczące przewozu - przewóz luzem
        /// </summary>
        public string PrzepisyLuzem { get; set; }
        /// <summary>
        /// Przepisy szczególne dotyczące przewozu - załadunek i rozładunek
        /// </summary>
        public string PrzepisyZalwyl { get; set; }
        /// <summary>
        /// Przepisy szczególne dotyczące przewozu - postępowanie ADR2009
        /// </summary>
        public string PrzepisyPost { get; set; }
        /// <summary>
        /// Numer rozpoznawczy zagrożenia
        /// </summary>
        public string NrZagroz { get; set; }
        /// <summary>
        /// 0/1 gdy numer rozpoznawczy zagrożenia dotyczy RID
        /// </summary>
        public int? Rid { get; set; }
        /// <summary>
        /// Opis po polsku
        /// </summary>
        public string OpisPl { get; set; }
        /// <summary>
        /// Opis po angielsku
        /// </summary>
        public string OpisGb { get; set; }
    }
}
