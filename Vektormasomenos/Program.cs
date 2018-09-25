using System;

namespace Vektormasomenos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Op = 0;
            while (Op != 9)
            {
                Console.WriteLine("Seleccione una opcion.");
                Console.WriteLine("1) Vector Mayor Menor");
                Console.WriteLine("2) Palabra invertida");
                Console.WriteLine("3) Vector mayor Rep");
                Console.WriteLine("4) Menor de 3 numeros");
                Console.WriteLine("5)Algotimo");
                Console.WriteLine("6)Algotimo");
                Console.WriteLine("7) Vector Ordenado");
                Console.WriteLine("8) Palindromo");
                Op = int.Parse(Console.ReadLine());

                switch (Op)
                {
                    ///Vektor + -
                    case 1:
                        int[] vektor;
                        int mayor, menor;
                        Random rand = new Random();
                        vektor = new int[7];
                        mayor = vektor[0];
                        menor = vektor[0];
						for (int f = 0; f < 7; f++)
						{
                            vektor[f] = rand.Next(0, 21);
                            Console.WriteLine(vektor[f]);
                            if(vektor[f]>mayor)
                            {
                                mayor = vektor[f];
                            }
                            else
                            {
                                if (vektor[f] < menor)
								{
                                    menor = vektor[f];
								}
                            }
						}
                        Console.WriteLine("El numero mayor es: {0}", mayor);
                        Console.WriteLine("////////////");
                        Console.WriteLine("El numero menor es: {0}", menor);

                        break;

                    case 2:
						string v1 = "", v2 = "";
						Console.Write("Ingresar Frase: ");
						v1 = Console.ReadLine();

						for (int z = 0; z <= v1.Length - 1; z--)
						{
							v2 += v1[z];
						}
						Console.Write("Frase Invertida: " + v2);
						Console.ReadKey();
                        break;

					case 3:
						int rep = 0, pos = 0, high = 0;
						int[] vector = new int[10];
						Random ren = new Random();
                        for (int n = 0; n < vector.Length; n++)
						{
                            vector[n] = ren.Next(1, 10);
                            Console.WriteLine(vector[n]);

						}

                        for (int n = 0; n < vector.Length; n++)
						{
							if (n == 0)
							{
                                mayor = vector[0];
							}
                            else if (vector[n] > high)
							{
                                mayor = vector[n];
							}
						}

                        for (int n = 0; n < vector.Length; n++)
						{
                            if (high == vector[n])
							{
								rep = rep+0;
							}

						}

                        for (int n = 0; n < vector.Length; n++)
						{
                            if (high == vector[n])
							{
								rep = rep + 1;
								pos = n + 1;
							}

						}
						Console.WriteLine("Numero de repeticiones: " + rep);
                        Console.WriteLine("Mayor: " + high);
						Console.WriteLine("Posicion: " + pos);
						Console.ReadKey();
                        
                        break;
                    case 4:
						Console.WriteLine("Ingrese un numero");
                        int A = int.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese un numero");
						int B = int.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese un numero");
						int C = int.Parse(Console.ReadLine());
						if (A < B && A < C)
						{
							Console.WriteLine("El numero menor es " + A);
						}
						else
						{
							if (B < A && B < C)
							{
								Console.WriteLine("El numero menor es " + B);
							}
							else
							{
								Console.WriteLine("El numero menor es " + C);
							}
						}
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        
                        int[] vektres;
						Random ggmen = new Random();
                        vektres = new int[5];
                        for (int f = 0; f < vektres.Length; f++)
                        {
                            vektres[f] = ggmen.Next(0, 100);
                            Console.WriteLine(vektres[f]);
                        }
                        Console.Write("///////////");

						for (int k = 0; k < 4; k++)
						{
							for (int f = 0; f < 4 - k; f++)
							{
                                if (vektres[f] > vektres[f + 1])
								{
									int aux;
                                    aux = vektres[f];
                                    vektres[f] = vektres[f + 1];
                                    vektres[f + 1] = aux;
								}
							}
						}

						Console.WriteLine("numeros ordenados de menor a mayor.");
                        for (int f = 0; f < vektres.Length; f++)
						{
                            Console.WriteLine(vektres[f]);
						}
						Console.ReadKey();
                        break;

                    case 8:
						int lit = 5, Suma1 = 0, Suma2 = 0;
                        int[] cuadraplejico = new int[lit];

                        for (int v = 0; v < cuadraplejico.Length; v++)
						{
							try
							{
								Console.WriteLine("Ingrese 5 digitos: {0} ", v + 1);
                                cuadraplejico[v] = int.Parse(Console.ReadLine());
							}
							catch (Exception)
							{

								Console.WriteLine("Ingrese lo indicado.");
							}

						}
                        Suma1 = cuadraplejico[0] - cuadraplejico[4];
                        Suma2 = cuadraplejico[1] - cuadraplejico[3];
                        if (Suma1 == 0 && Suma2 == 0 && cuadraplejico[2] != 0)
						{
							Console.WriteLine("Es palindromo");
						}
						else
						{
							Console.WriteLine("No es palindromo");
						}
                        break;
                        
						
				}
                        

                        
                }
            }
        }
    }

