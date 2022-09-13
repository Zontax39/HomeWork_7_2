using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arstotzka arstotzka = new Arstotzka();
            arstotzka.ShowPrisoners();
            arstotzka.Amnesty();
            arstotzka.ShowPrisoners();
        }
    }
    class Arstotzka
    {
        private List<Prisoner> _prisoners;

        public Arstotzka()
        {
            _prisoners = new List<Prisoner>();
            _prisoners.Add(new Prisoner("Liam", Crime.Убийство));
            _prisoners.Add(new Prisoner("Oliver", Crime.Кража));
            _prisoners.Add(new Prisoner("Elijah", Crime.Убийство));
            _prisoners.Add(new Prisoner("Sophia", Crime.Убийство));
            _prisoners.Add(new Prisoner("Benjamin", Crime.Антиправительственное));
            _prisoners.Add(new Prisoner("Henry", Crime.Кража));
            _prisoners.Add(new Prisoner("Alexander", Crime.Антиправительственное));
        }

        public void ShowPrisoners()
        {
            foreach(Prisoner prisoner in _prisoners)
            {
                Console.WriteLine("Преступники: ");
                Console.WriteLine($"{prisoner.Name} - {prisoner.Crime}");
            }
        }

        public void Amnesty()
        {
            var prisoners = _prisoners.Where(prisoner => prisoner.Crime != Crime.Антиправительственное);
            _prisoners = prisoners.ToList();
        }
    }


    class Prisoner
    {
        public string Name { get; private set; }
        public Crime Crime { get; private set; }

        public Prisoner(string name, Crime crime)
        {
            Name = name;
            Crime = crime;
        }
    }

    public enum Crime
    {
        Кража,
        Убийство,
        Антиправительственное
    }
}
