using System.Collections.Generic;
using AP2_POO.Models;

namespace AP2_POO.Interfaces
{
    public interface IContaRepository
    {
         Conta GetById(int id);
         List<Conta> GetAll();
         void Save(Conta conta);
         void Delete(Conta conta);
         void Update(Conta conta);
    }
}