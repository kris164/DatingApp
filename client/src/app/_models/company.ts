export interface company {
    id:number,
    email: string
    mobile: string 
    regon: string
    nip: string
    statusNip: string
    nazwa: string
    wojewodztwo: string
    powiat: string
    gmina: string
    miejscowosc: string
    kodPocztowy: string
    ulica: string
    nrNieruchomosci: string
    nrLokalu: string
    typ: "F"
    silosID: 1
    dataZakonczeniaDzialalnosci: string
    miejscowoscPoczty: string
    errors: []
    ciagnikSiodlowy: number
    ciagnikTrojosiowy: number
    ciagnikTypuMega: number
    ciagnikTypuMegaReagul: number
    jumbo: number
    naczepaOplanegkowana: number
    megaNaczepaOplanegkowana: number
    Password: string
    UserName: string
    UsernameDto: string
    Id_kontrah: number
    accepted: number
}