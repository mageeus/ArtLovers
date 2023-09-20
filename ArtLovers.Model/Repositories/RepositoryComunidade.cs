using ArtLovers.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLovers.Model.Repositories
{
    public class RepositoryComunidade : RepositoryBase<Comunidade>
    {
        public RepositoryComunidade(bool saveChanges = true) : base(saveChanges) 
        {
        
        }
    }
}
