using System;

namespace dev_homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Conejos!");

            var conejos = new string[]{"🐰","🐰🐰🐰"};

            Console.WriteLine(conejos[0]);
            Console.WriteLine(conejos[1]);


            var valores = new int[]{1,3,4,5,6};
            int res=0;

            for(int i=0;i<valores.Length;i++){
                res=res+valores[i];
            }

            Console.WriteLine(res);

            int valor=0;

            int suma=0;

            //valor=Convert.ToInt16(Console.ReadLine());
            string[] lectura = new string[valor];
            var arreglo= new int[valor];

            Console.WriteLine(valor);

            //lectura=Console.ReadLine().Split(' ');

            if(lectura.Length>valor){
                Console.WriteLine("Tronamos todo, no ponga espacio al final o valor extra");
            }else{

                for(int i=0;i<lectura.Length;i++){
                    suma=suma+Convert.ToInt32(lectura[i]);
                }
                Console.WriteLine("El valor total es " + suma);
            }

            Program programa = new Program();
            //programa.EjercicioUno();
            //programa.EjercicioDos();
            //programa.EjercicioTres();
            //programa.Ejercicio4();
            //programa.Ejercicio5();


        }

        private void EjercicioUno(){
            int valores=10;
            Console.WriteLine("Aqui");
            for(int i=0;i<=valores;i++)
            {
                Console.Write(i);
            }

        }

        private void EjercicioDos(){
            int valores=10;


            Console.WriteLine("Aqui van en regreso");
            for(int i=valores;i>=0;i--)
            {
                Console.Write(i);
            }

        }

        private void EjercicioTres(){
            var valores= new string[]{"a","b","c"};

            for(int i=0;i<valores.Length;i++)
            {
                Console.WriteLine($"Valor: {valores[i]}");
            }
        }

        private void Ejercicio4()
        {
            var valores= new string[]{"Estoy","feliz","programando"};
            string acum="";
            for(int i=0;i<valores.Length;i++)
            {
                acum=acum+" "+valores[i];
            }   

            Console.Write($"{acum}");

        }

        private void Ejercicio5()
        {
            int escalera = 12;
            string escalon="";
            for(int i=0;i<=escalera;i++)
            {
             //   Console.WriteLine(i);
                escalon=escalon+"*";
                Console.WriteLine(escalon);
            }
        }

        

    }
}
