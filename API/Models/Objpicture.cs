using System;
using System.Collections.Generic;

namespace API.Models
{
    /// <summary>
    /// zdjęcia do obiektu SPEED
    /// </summary>
    public partial class Objpicture
    {
        public int Idobjpictures { get; set; }
        /// <summary>
        /// typ obiektu SPEED
        /// </summary>
        public int Objtype { get; set; }
        /// <summary>
        /// ID obiektu SPEED
        /// </summary>
        public int Objid { get; set; }
        /// <summary>
        /// znacznik modyfikacji
        /// </summary>
        public int Modifyid { get; set; }
        /// <summary>
        /// dane binarne zdjęcia
        /// </summary>
        public byte[] Picture { get; set; }
    }
}
