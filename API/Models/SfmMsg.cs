using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// Komunikaty wymieniane między spedytorem/dyspozytorem i kierowcą
    /// </summary>
    public partial class SfmMsg
    {
        public SfmMsg()
        {
            SfmMsgAttaches = new HashSet<SfmMsgAttach>();
            SfmMsgRecipients = new HashSet<SfmMsgRecipient>();
            SfmMsgRefs = new HashSet<SfmMsgRef>();
        }

        public int IdSfmMsg { get; set; }
        /// <summary>
        /// ID wiadomości źródłowej
        /// </summary>
        public int? IdMsgFwd { get; set; }
        /// <summary>
        /// macro number
        /// </summary>
        public int? MacroNr { get; set; }
        /// <summary>
        /// macro version
        /// </summary>
        public int? MacroVer { get; set; }
        public int IdSfmTerm { get; set; }
        /// <summary>
        /// typ terminala (operator)
        /// </summary>
        public string TypTerm { get; set; }
        /// <summary>
        /// symbol terminala (Entity_ID)
        /// </summary>
        public string SymbolTerm { get; set; }
        public int IdSfmTabor { get; set; }
        public int IdTabor { get; set; }
        public string NrRej { get; set; }
        public string NrInwent { get; set; }
        /// <summary>
        /// id kierowcy
        /// </summary>
        public int? IdKierowcy { get; set; }
        /// <summary>
        /// nazwisko kierowcy
        /// </summary>
        public string Kierowca { get; set; }
        /// <summary>
        /// id dyspozytora
        /// </summary>
        public int? IdUzytk { get; set; }
        /// <summary>
        /// nazwisko dyspozytora
        /// </summary>
        public string Nazwauzytk { get; set; }
        /// <summary>
        /// id zlecenia
        /// </summary>
        public int? IdZlecenia { get; set; }
        /// <summary>
        /// numer zlecenia
        /// </summary>
        public string Nrzlec { get; set; }
        /// <summary>
        /// id załadunku
        /// </summary>
        public int? IdZa { get; set; }
        /// <summary>
        /// id wyładunku
        /// </summary>
        public int? IdWy { get; set; }
        /// <summary>
        /// ID pozycji GPS
        /// </summary>
        public int? IdSfmPos { get; set; }
        /// <summary>
        /// typ wiadomości: 0-odbiór/ 1-nadawanie/ 2-wysł.zlecenie/ 3-wiad.systemowa(makro)
        /// </summary>
        public short? Typ { get; set; }
        /// <summary>
        /// 0-default/ 1-important/ 2-sleepy/ 3-sleepy important/ 9-emergency/ 255-alert
        /// </summary>
        public short? Priorytet { get; set; }
        /// <summary>
        /// 1 - żądanie potwierdzenia/odpowiedzi
        /// </summary>
        public short? Potwierdz { get; set; }
        /// <summary>
        /// 1 - odbiór potwierdzony
        /// </summary>
        public short? Potwierdzok { get; set; }
        /// <summary>
        /// planowany czas wysłania wiadomości
        /// </summary>
        public DateTime? DtPlan { get; set; }
        /// <summary>
        /// czas zapisu do bazy danych
        /// </summary>
        public DateTime? DtZapis { get; set; }
        /// <summary>
        /// czas wysłania (z samochodu/dyspozytorni)
        /// </summary>
        public DateTime? DtWysl { get; set; }
        /// <summary>
        /// czas odbioru/dostarczenia
        /// </summary>
        public DateTime? DtOdb { get; set; }
        /// <summary>
        /// czas przeczytania wiadomości
        /// </summary>
        public DateTime? DtPrzeczyt { get; set; }
        /// <summary>
        /// termin dostarczenia wiadomości
        /// </summary>
        public DateTime? DtTermin { get; set; }
        /// <summary>
        /// skrót wiadomości
        /// </summary>
        public string Msgshort { get; set; }
        /// <summary>
        /// Wiadomość
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// długość komunikatu
        /// </summary>
        public int? Msglen { get; set; }
        /// <summary>
        /// (&apos;T&apos;/&apos;B&apos;) typ wiadomości
        /// </summary>
        public string Msgtype { get; set; }
        /// <summary>
        /// status wiadomości
        /// </summary>
        public short? Msgstat { get; set; }
        /// <summary>
        /// tekst lub numer błędu
        /// </summary>
        public string Msgblad { get; set; }
        /// <summary>
        /// folder wiadomości
        /// </summary>
        public int? MsgFolder { get; set; }
        /// <summary>
        /// (0/1) - tekst bez polskich znaków
        /// </summary>
        public short? Bezpl { get; set; }
        /// <summary>
        /// rodzaj danych wiadomości:
        /// - przychodząca:  0-wiadomość/ 1-stat itp./ 2-raport SMS
        /// - wychodząca:  0-wiadomość/ 1-zlec./ 2-dane kierowcy
        /// </summary>
        public short? Rodzaj { get; set; }
        /// <summary>
        /// 0-nowe/ 1-zrobione (przetworzone)
        /// </summary>
        public short? Zrobione { get; set; }
        /// <summary>
        /// 0-nowe/ 1-wykonane przekierowanie
        /// </summary>
        public short? Przekierowane { get; set; }
        /// <summary>
        /// ID wiadomości głównej (gdy do wielu
        /// </summary>
        public int? IdSfmMsgMaster { get; set; }
        /// <summary>
        /// Liczba odbiorców
        /// </summary>
        public int? Liczbaodbiorcow { get; set; }
        /// <summary>
        /// ID kategorii wiadomości
        /// </summary>
        public int? IdSfmMsgKategoria { get; set; }
        /// <summary>
        /// kod lokalizacji
        /// </summary>
        public string Lokalizacja { get; set; }
        /// <summary>
        /// kod działu
        /// </summary>
        public string Dzial { get; set; }
        /// <summary>
        /// symbol formatki odpowiedzi (PNC:wiad.strukturalne)
        /// </summary>
        public string Formatka { get; set; }
        /// <summary>
        /// obiekt - id tablicy
        /// </summary>
        public int? IdObj { get; set; }
        /// <summary>
        /// id w obiekcie (patrz ID_OBJ)
        /// </summary>
        public int? IdRec { get; set; }
        /// <summary>
        /// licznik wysyłki wiadomości/zlecenia (np. po błędnej wysyłce)
        /// </summary>
        public short? Sendcount { get; set; }
        /// <summary>
        /// określa font wyświetlania (0-&quot;Tahoma&quot; /1-&quot;Lucida Console&quot;)
        /// </summary>
        public short? Consolefont { get; set; }
        public DateTime? DtSentUtc { get; set; }
        public int? IdSfmSystem { get; set; }
        public string ExternalId { get; set; }
        public string ExternalReplyId { get; set; }
        public string ExtraInfo { get; set; }

        public virtual ICollection<SfmMsgAttach> SfmMsgAttaches { get; set; }
        public virtual ICollection<SfmMsgRecipient> SfmMsgRecipients { get; set; }
        public virtual ICollection<SfmMsgRef> SfmMsgRefs { get; set; }
    }
}
