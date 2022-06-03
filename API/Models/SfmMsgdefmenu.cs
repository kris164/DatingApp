using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// definicje menu do wysyłki wiadomości w kontekście obiektów SPEED
    /// </summary>
    public partial class SfmMsgdefmenu
    {
        public SfmMsgdefmenu()
        {
            SfmMsgDefMenuWindows = new HashSet<SfmMsgDefMenuWindow>();
        }

        public int IdSfmMsgdefmenu { get; set; }
        /// <summary>
        /// indeks do sortowania opcji w menu
        /// </summary>
        public short? Lp { get; set; }
        /// <summary>
        /// (0/1) czy definicja jest aktywna (gotowa do użycia)
        /// </summary>
        public short? Active { get; set; }
        /// <summary>
        /// nazwa opcji wyświetlana w menu
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// opis opcji menu wyświetlany w postaci hinta
        /// </summary>
        public string Hint { get; set; }
        /// <summary>
        /// ID obiektu SPEED
        /// </summary>
        public int? Idobj { get; set; }
        /// <summary>
        /// PS do przygotowania listy wiadomości
        /// </summary>
        public string Prepareproc { get; set; }
        /// <summary>
        /// PS do wysyłki wiadomości
        /// </summary>
        public string Sendproc { get; set; }
        /// <summary>
        /// (0/1) czy utworzyć jedną wiadomość dla wszystkich zaznaczonych rekordów
        /// </summary>
        public short? Onemsgforall { get; set; }

        public virtual ICollection<SfmMsgDefMenuWindow> SfmMsgDefMenuWindows { get; set; }
    }
}
