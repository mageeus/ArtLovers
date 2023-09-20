using ArtLovers.Model.Interfaces;
using ArtLovers.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLovers.Model.Repositories
{
    public  class RepositoryPessoa : RepositoryBase<Pessoa>
    {
        public RepositoryPessoa(bool saveChanges = true) : base(saveChanges)
        {
            
        }
    }
}
