using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class TmpOrderPlanning
    {
        public int IdTmpOrderPlanning { get; set; }
        public DateTime? SessionDt { get; set; }
        /// <summary>
        /// id sesji planowania
        /// </summary>
        public int? SessionId { get; set; }
        /// <summary>
        /// 0-opmPlanning /1-opmAccept /2-opmCancel /3-opmRemove
        /// </summary>
        public int? PlanningMode { get; set; }
        /// <summary>
        /// (0/1) czy planowanie wstępne?
        /// </summary>
        public int? IsTrialPlanning { get; set; }
        /// <summary>
        /// (0/1) czy automatyczne przydzielanie myjni przy liczeniu CC?
        /// </summary>
        public int? IsAutoCarWash { get; set; }
        /// <summary>
        /// (0/1) czy podzlecenie (np. po przeładunku)?
        /// </summary>
        public int? IsTransShipment { get; set; }
        /// <summary>
        /// (0/1) czy zlecenie wstępne?
        /// </summary>
        public int? IsOrderW { get; set; }
        /// <summary>
        /// (0/1) czy naczepa ze zlecenia zlecenia?
        /// </summary>
        public int? IsOrderTrailer { get; set; }
        /// <summary>
        /// (0/1) czy wymagana zmiana typu zlecenia?
        /// </summary>
        public int? IsOrderTypeChange { get; set; }
        /// <summary>
        /// (0/1) czy właściciel pojazdu na podstawie [TABOR].[WLASCICIEL_ID]?
        /// </summary>
        public int? IsDirectCarrier { get; set; }
        /// <summary>
        /// id &quot;jednego&quot; centralnego punktu kontrolnego przy planowaniu
        /// </summary>
        public int? OneCheckPointId { get; set; }
        /// <summary>
        /// dt początku zlecenia
        /// </summary>
        public DateTime? DtOrderStart { get; set; }
        /// <summary>
        /// dt końca zlecenia
        /// </summary>
        public DateTime? DtOrderStop { get; set; }
        /// <summary>
        /// (2/6) id typu obiektu zlecenia
        /// </summary>
        public int? OrderObjId { get; set; }
        /// <summary>
        /// id zlecenia
        /// </summary>
        public int? OrderId { get; set; }
        /// <summary>
        /// typ zlecenia S/T/W
        /// </summary>
        public string OrderType { get; set; }
        /// <summary>
        /// numer zlecenia
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        /// status SFM zlecenia
        /// </summary>
        public int? OrderStatusSfm { get; set; }
        /// <summary>
        /// id pojazdu ze zlecenia
        /// </summary>
        public int? OrderVehicleId { get; set; }
        /// <summary>
        /// nr rej. pojazdu ze zlecenia
        /// </summary>
        public string OrderVehicleLicencePlate { get; set; }
        /// <summary>
        /// nr inwent. pojazdu ze zlecenia
        /// </summary>
        public string OrderVehicleInvNo { get; set; }
        /// <summary>
        /// id naczepy ze zlecenia
        /// </summary>
        public int? OrderTrailerId { get; set; }
        /// <summary>
        /// nr rej. naczepy ze zlecenia
        /// </summary>
        public string OrderTrailerLicencePlate { get; set; }
        /// <summary>
        /// nr inwent. naczepy ze zlecenia
        /// </summary>
        public string OrderTrailerInvNo { get; set; }
        /// <summary>
        /// id dyspozytora ze zlecenia
        /// </summary>
        public int? OrderDispatcherId { get; set; }
        /// <summary>
        /// dyspozytor ze zlecenia
        /// </summary>
        public string OrderDispatcher { get; set; }
        /// <summary>
        /// rodzaj formatki zlecenia
        /// </summary>
        public int? OrderFrmId { get; set; }
        /// <summary>
        /// (0/1) czy zlecenie ADR?
        /// </summary>
        public int? OrderAdr { get; set; }
        /// <summary>
        /// UN ładunku ADR
        /// </summary>
        public string OrderAdrUn { get; set; }
        /// <summary>
        /// id klienta/zleceniodawcy
        /// </summary>
        public int? OrderClientId { get; set; }
        /// <summary>
        /// klient/zleceniodawca
        /// </summary>
        public string OrderClient { get; set; }
        /// <summary>
        /// dział zlecenia
        /// </summary>
        public string OrderDepartment { get; set; }
        /// <summary>
        /// lokalizacja zlecenia
        /// </summary>
        public string OrderLocalization { get; set; }
        /// <summary>
        /// kontrahent z lokalizacji zlecenia
        /// </summary>
        public string OrderLocalizationCust { get; set; }
        /// <summary>
        /// id płatnika
        /// </summary>
        public int? OrderPayerId { get; set; }
        /// <summary>
        /// płatnik
        /// </summary>
        public string OrderPayer { get; set; }
        /// <summary>
        /// stawka za KM
        /// </summary>
        public double? OrderRatePerKm { get; set; }
        /// <summary>
        /// status zlecenia po zaplanowaniu
        /// </summary>
        public int? NewOrderStatusSfm { get; set; }
        /// <summary>
        /// nowy typ dla zlecenia
        /// </summary>
        public string NewOrderType { get; set; }
        /// <summary>
        /// (0/1) czy nadawać numer dla zlecenia wstępnego
        /// </summary>
        public int? NewOrderUpdateNumber { get; set; }
        /// <summary>
        /// procedura mycia pojazdu/naczepy
        /// </summary>
        public string NewOrderWashingProcedure { get; set; }
        /// <summary>
        /// (0/1) czy użyto matrycę mycia
        /// </summary>
        public int? NewOrderWashingMatrix { get; set; }
        /// <summary>
        /// (0/1) czy dobierać myjnię (zerowane przez użycie matrycy mycia)
        /// </summary>
        public int? NewOrderCarwash { get; set; }
        /// <summary>
        /// (ID_KONTRAH) id przewoźnika/właściciela nowego pojazdu
        /// </summary>
        public int? CarrierId { get; set; }
        /// <summary>
        /// (SYMBOL) przewoźnik/właściciel nowego pojazdu
        /// </summary>
        public string CarrierName { get; set; }
        /// <summary>
        /// (NAZWA) nazwa przewoźnika
        /// </summary>
        public string CarrierLongName { get; set; }
        /// <summary>
        /// (ULICA)
        /// </summary>
        public string CarrierAddress { get; set; }
        /// <summary>
        /// (MIEJSCOWOSC)
        /// </summary>
        public string CarrierCity { get; set; }
        /// <summary>
        /// (KOD)
        /// </summary>
        public string CarrierZipCode { get; set; }
        /// <summary>
        /// (KRAJ)
        /// </summary>
        public string CarrierCountry { get; set; }
        /// <summary>
        /// (PREFIX_NIP + NIP)
        /// </summary>
        public string CarrierNip { get; set; }
        /// <summary>
        /// (FAX as TEL)
        /// </summary>
        public string CarrierPhoneNo { get; set; }
        /// <summary>
        /// (0/1) (TEST_PRZEWOZNIK)
        /// </summary>
        public int? CarrierIsCarrier { get; set; }
        /// <summary>
        /// (OSOBA_KONTAKT)
        /// </summary>
        public string CarrierContactPerson { get; set; }
        /// <summary>
        /// (0/1) (SPEDYTOR_BEZ_FLOTY)
        /// </summary>
        public int? CarrierShipperWithoutFleet { get; set; }
        /// <summary>
        /// (WALUTA_FRACHTU_KOSZTY)
        /// </summary>
        public string CarrierFreightCurrencyCosts { get; set; }
        /// <summary>
        /// (WALUTA_ROZLICZEN_KOSZTY)
        /// </summary>
        public string CarrierClearingCurrencyCosts { get; set; }
        /// <summary>
        /// (FORMA_PLATNOSCI_DOST)
        /// </summary>
        public string CarrierPaymentForm { get; set; }
        /// <summary>
        /// (TERMIN_PLATNOSCI_DOST)
        /// </summary>
        public int? CarrierPaymentDeadline { get; set; }
        /// <summary>
        /// (CENNIK_FTL_P_ID)
        /// </summary>
        public int? CarrierCennikFtlPId { get; set; }
        /// <summary>
        /// (CENNIK_FTL_P)
        /// </summary>
        public string CarrierCennikFtlP { get; set; }
        /// <summary>
        /// (TYP_KURS_P)
        /// </summary>
        public string CarrierTypKursP { get; set; }
        /// <summary>
        /// (TYP_TAB_P)
        /// </summary>
        public int? CarrierTypTabP { get; set; }
        /// <summary>
        /// zmieniona wartość dla pola zlec.WALUTA_P
        /// </summary>
        public string CarrierNewCurrency { get; set; }
        /// <summary>
        /// zmieniona wartość dla pola zlec.WALUTA_FV_P
        /// </summary>
        public string CarrierNewCurrencyVat { get; set; }
        /// <summary>
        /// uprawnienia ADR pojazdu
        /// </summary>
        public string NewVehicleClassAdr { get; set; }
        /// <summary>
        /// dział nowego pojazdu
        /// </summary>
        public string NewVehicleDepartment { get; set; }
        /// <summary>
        /// (0/1) czy tabor obcy
        /// </summary>
        public int? NewVehicleForeignFleet { get; set; }
        /// <summary>
        /// id nowego pojazdu
        /// </summary>
        public int? NewVehicleId { get; set; }
        /// <summary>
        /// nr inwent. nowego pojazdu
        /// </summary>
        public string NewVehicleInvNo { get; set; }
        /// <summary>
        /// (0/1) czy pojazd do przewozu ADR
        /// </summary>
        public int? NewVehicleIsAdr { get; set; }
        /// <summary>
        /// nr rej. nowego pojazdu
        /// </summary>
        public string NewVehicleLicencePlate { get; set; }
        /// <summary>
        /// lokalizacja nowego pojazdu
        /// </summary>
        public string NewVehicleLocalization { get; set; }
        /// <summary>
        /// kontrahent z lokalizacji nowego pojazdu
        /// </summary>
        public string NewVehicleLocalizationCust { get; set; }
        /// <summary>
        /// id profilu nowego pojazdu
        /// </summary>
        public int? NewVehicleProfileId { get; set; }
        /// <summary>
        /// id naczepy powiązanej z nowym pojazdem
        /// </summary>
        public int? NewVehicleTrailerId { get; set; }
        /// <summary>
        /// uprawnienia ADR naczepy
        /// </summary>
        public string NewTrailerClassAdr { get; set; }
        /// <summary>
        /// id nowej naczepy
        /// </summary>
        public int? NewTrailerId { get; set; }
        /// <summary>
        /// (0/1) czy naczepa do przewozu ADR
        /// </summary>
        public int? NewTrailerIsAdr { get; set; }
        /// <summary>
        /// nr rej. nowej naczepy
        /// </summary>
        public string NewTrailerLicencePlate { get; set; }
        /// <summary>
        /// nr inwent. nowej naczepy
        /// </summary>
        public string NewTrailerInvNo { get; set; }
        /// <summary>
        /// id kierowcy 1
        /// </summary>
        public int? NewDriver1Id { get; set; }
        /// <summary>
        /// nazwa kierowcy 1
        /// </summary>
        public string NewDriver1Name { get; set; }
        /// <summary>
        /// tel. kierowcy 1
        /// </summary>
        public string NewDriver1PhoneNo { get; set; }
        /// <summary>
        /// uprawnienia ADR kierowcy 1
        /// </summary>
        public string NewDriver1ClassAdr { get; set; }
        /// <summary>
        /// id kierowcy 2
        /// </summary>
        public int? NewDriver2Id { get; set; }
        /// <summary>
        /// nazwa kierowcy 2
        /// </summary>
        public string NewDriver2Name { get; set; }
        /// <summary>
        /// tel. kierowcy 2
        /// </summary>
        public string NewDriver2PhoneNo { get; set; }
        /// <summary>
        /// uprawnienia ADR kierowcy 2
        /// </summary>
        public string NewDriver2ClassAdr { get; set; }
        /// <summary>
        /// (0/1) czy finanse przewoźnika &quot;po nowemu&quot;?
        /// </summary>
        public int? IsNewCarrierFinances { get; set; }
        /// <summary>
        /// (VAT_W_PLN_KOSZTY)
        /// </summary>
        public int? CarrierVatWPlnP { get; set; }
        /// <summary>
        /// (KURS_WG_P)
        /// </summary>
        public string CarrierKursWgP { get; set; }
        /// <summary>
        /// (KURS_Z_DNIA_P_P)
        /// </summary>
        public int? CarrierKursZDniaPP { get; set; }
    }
}
