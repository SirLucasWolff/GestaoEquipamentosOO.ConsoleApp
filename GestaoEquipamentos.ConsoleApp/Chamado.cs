using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ConsoleApp
{
    public class Chamado
    {
        private Equipamento Equipamento { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private DateTime DataAbertura { get; set; }
        public int id;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public Chamado registrar()
        {
            Chamado chamado = new Chamado();

            Console.WriteLine("Digite o ID do equipamento");
             Console.ReadLine();

            Console.WriteLine("Digite a Descrição do equipamento");
            chamado.Descricao = Console.ReadLine();

            Console.WriteLine("Digite a data de abertura");
            chamado.DataAbertura = Convert.ToDateTime(Console.ReadLine());

            Random rnd = new Random();
            chamado.id = rnd.Next();

            return chamado;
        }

        public void mostrar(List<Chamado> equipamentos)
        {
            Console.WriteLine("----- Lista de Chamados -----");
            foreach (var item in equipamentos)
            {
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Título: {item.Titulo}");
                Console.WriteLine($"Descrição: {item.Descricao}");
                Console.WriteLine($"Data de Abertura: {item.DataAbertura}");

            }
            Console.WriteLine("---------------------------------");
        }

        internal void mostrar(Chamado chamado)
        {
            throw new NotImplementedException();
        }

        public void Editar(List<Chamado> equipamentos)
        {
            Console.WriteLine("----- Lista de Chamados -----");
            foreach (var item in equipamentos)
            {
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Título: {item.Titulo}");
                Console.WriteLine($"Descrição: {item.Descricao}");
                Console.WriteLine($"Data de Abertura: {item.DataAbertura}");
                Chamado chamado = new Chamado();

                Console.WriteLine("Digite o novo nome do Chamado");
                chamado.Titulo = Console.ReadLine();

                Console.WriteLine("Digite a nova Descrição do equipamento");
                chamado.Descricao = Console.ReadLine();

                Console.WriteLine("Digite a nova data de abertura");
                chamado.DataAbertura = Convert.ToDateTime(Console.ReadLine());

                Random rnd = new Random();
                chamado.id = rnd.Next();


            }
            Console.WriteLine("---------------------------------");


        }

        internal void Editar(Chamado item)
        {
            Console.WriteLine($"ID: {item.id}");
            Console.WriteLine($"Título: {item.Titulo}");
            Console.WriteLine($"Descrição: {item.Descricao}");
            Console.WriteLine($"Data de Abertura: {item.DataAbertura}");
            Chamado chamado = new Chamado();

            Console.WriteLine("Digite o novo nome do Chamado");
            chamado.Titulo = Console.ReadLine();

            Console.WriteLine("Digite a nova Descrição do equipamento");
            chamado.Descricao = Console.ReadLine();

            Console.WriteLine("Digite a nova data de abertura");
            chamado.DataAbertura = Convert.ToDateTime(Console.ReadLine());

            Random rnd = new Random();
            chamado.id = rnd.Next();
        }
    }
}
