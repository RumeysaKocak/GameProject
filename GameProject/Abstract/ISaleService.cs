using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Add(Sale sale);
        void Delete(Sale sale);
        void Update(Sale sale);

    }
}
