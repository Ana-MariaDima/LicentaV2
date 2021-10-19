using Licenta.Models.Base;
using System.Collections.Generic;

namespace Licenta.Models.Relations.One_to_Many
{
    public class Bucatari: BaseEntity
    {
        public string Pseudonume_bucarat { set; get; }
        public string Nume_bucarat { set; get; }
        public ICollection<Retete> Retete { get; set; }
    }
}
