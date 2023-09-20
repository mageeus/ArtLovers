using ArtLovers.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLovers.Model.Repositories
{
    public class RepositoryArte : RepositoryBase<Arte>
    {
        public RepositoryArte(bool saveChanges = true) : base(saveChanges)
        {
        
        }
    }
}
