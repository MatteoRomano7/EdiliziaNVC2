namespace EdiliziaCompleto.Models
{
    public static class Db
    {
        private static int _maxId = 3;

        private static List<Dipendente> _dipendenti { get; set; } = [
            new Dipendente() {DipendenteId = 1, Nome = "Francesco", Cognome = "Missorini", Indirizzo = "Via Brombeis", CodiceFiscale = "1234567890123456", Coniugato = true, Figli = 3, Mansione = "Scafista"},
            new Dipendente() {DipendenteId = 2, Nome = "Abel", Cognome = "Sassu", Indirizzo = "Via Cagliari", CodiceFiscale = "1234567890123456", Coniugato = true, Figli = 5, Mansione = "Guardia"},
            new Dipendente() {DipendenteId = 3, Nome = "Marco", Cognome = "Silveri", Indirizzo = "Via Roma", CodiceFiscale = "1234567890123456", Coniugato = true, Figli = 2, Mansione = "Professore"},
            ];

        public static List<Dipendente> getAll()
        {
            return _dipendenti;
        }

        public static Dipendente? getById(int? id) 
        {
            if (id == null) return null;

            for (int i =0; i < _dipendenti.Count; i++)
            {
                Dipendente dipendente = _dipendenti[i];
                if (_dipendenti[i].DipendenteId == id)
                {
                    return dipendente;
                };
            }
            return null;    
        }
        public static Dipendente AggiungiDipendente(string nome, string cognome, string indirizzo, string codicefiscale, bool coniugato, int figli, string mansione) 
        {
            _maxId++;
            var dipendente = new Dipendente() { DipendenteId = _maxId, Nome = nome, Cognome = cognome, Indirizzo = indirizzo, CodiceFiscale = codicefiscale, Coniugato = coniugato, Figli = figli, Mansione = mansione };
            _dipendenti.Add(dipendente);
            return dipendente;
        } 
    }

}
