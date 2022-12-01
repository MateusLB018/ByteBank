using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContadaGabriela =new ContaCorrente();

            ContadaGabriela.titular = "Gabriela";
            ContadaGabriela.agencia = 863;
            ContadaGabriela.numero = 863452;
            ContadaGabriela.saldo = 100;

            ContadaGabriela.saldo += 250;

            //ContadaGabriela pode apontar para uma outra conta criada, por exemplo ContadaGabriela=ContadaGabriela (o pongteiro estará apontando
            //para o mesmo espaço de resukltado logo se mudar um muda o outro

            Console.WriteLine(ContadaGabriela.titular);
            Console.WriteLine(ContadaGabriela.agencia);
            Console.WriteLine(ContadaGabriela.numero);
            Console.WriteLine(ContadaGabriela.saldo);


            Console.WriteLine("Aperte enter para finalizar : ");
            Console.ReadLine();
        }
    }
}
