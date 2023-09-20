using ArtLovers.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLovers.Model.Repositories
{
    public class RepositoryComentario : RepositoryBase<Comentario>
    {
        public RepositoryComentario(bool saveChanges = true) : base(saveChanges) 
        { 
        
        }
    }
}
