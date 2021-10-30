using System.Collections.Generic;
using System.Linq;
using AP2_POO.Data;
using AP2_POO.Interfaces;
using AP2_POO.Models;
using Microsoft.EntityFrameworkCore;

namespace AP2_POO.Repositories
{
    public class ContaRepository :IContaRepository
    {
        private AppDbContext context;
        public ContaRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Conta GetById(int id)
        {
            return context.Contas.SingleOrDefault(x=>x.Id == id);
        }
        public List<Conta> GetAll()
        {
            return context.Contas.ToList();
        }
        public void Save(Conta conta)
        {
            context.Contas.Add(conta);
            context.SaveChanges();
        }
        public void Delete(Conta conta)
        {
            context.Contas.Remove(conta);
            context.SaveChanges();
        }
        public void Update(Conta conta)
        {
            context.Entry(conta).State = EntityState.Modified;
            context.SaveChanges();
        }
        
    }
}