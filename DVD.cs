using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class DVD : Documento
    {
        public int numeroSeriale;
        public double durata;

        public DVD(string titolo, int anno, string autoreNome, string autoreCognome, int numeroSeriale, double durata) : base(titolo, anno, autoreNome, autoreCognome)
        {
            this.numeroSeriale = numeroSeriale;
            this.durata = durata;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + "Numero seriale: " + this.numeroSeriale + "\n" + "Durata: " + this.durata + "\n" + "--------------------";
        }
    }
}
