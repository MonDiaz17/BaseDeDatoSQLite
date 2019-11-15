using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WPFDatabse.Clases
{
    class LibroInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Anio { get; set; }
        public string Franquicia { get; set; }
        public string Editorial { get; set; }

        public override string ToString()
        {
            return $"{Titulo} - {Autor} - {Anio} - {Franquicia} - {Editorial}";
        }
    }
}