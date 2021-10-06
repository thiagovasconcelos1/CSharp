using System;

namespace listaCsharp1
{
    class Program
    {
        static void Main(string[] args)
        { //Estrutura de reptição para rodar as questões//
            for (int A = 0; A != 11;)
            {
              Console.WriteLine("\n"+
                  "\n" +
                  "Digite o número da questão que deseja rodar:\n" +
              "(1)Conversão de °C para °F; \n" +
              "(2) Salário Professor;\n" +
              "(3) Raiz e Exponenciação Simples;\n" +
              "(4) Área do circulo;\n" +
              "(5)Idade Atual e no próximo ano;\n" +
              "(6)Venda de Carros;\n" +
              "(7)Degraus;\n" +
              "(8)Salário;\n" +
              "(9)Presentes\n" +
              "(10)Questão bônus;\n" +
              "(11)Sair;\n");
               

                

                 A = Convert.ToInt32(Console.ReadLine());
                //em casa case será executado uma questão diferente
                switch (A)
                {
                    case 1:
                        Console.WriteLine("Digite a temperatura em Graus Celsius:");
                        int temp = Convert.ToInt32(Console.ReadLine());
                        temp = (temp * 9 / 5 + 32);
                        Console.WriteLine("A temperatua em Fahrenheit é " + temp);
                        break;
                    case 2:

                        Console.WriteLine("Digite o valor da hora aula em R$:");
                        float haula = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o número de aulas:");
                        float Aula = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o desconto do INSS em %");
                        float INSS = float.Parse(Console.ReadLine());
                        float SB = haula * Aula;
                        float SD = INSS / 100 * SB;
                        float SL = SB - SD;
                        Console.WriteLine("O salário líquido do professor é R$" + SL);
                        break;
                    case 3:
                        Console.WriteLine("Digite um número");
                        Double x = Double.Parse(Console.ReadLine());
                        {
                            if (x >= 0)
                            {
                                Console.Write(Math.Sqrt(x));

                            }
                            else;
                            {
                                x = x * x;
                                Console.Write(+x);
                            }
                        }
                        break;
                    case 4:
                        double areaCirculo = 0;
                        double RaioDoCirculo = 0;
                        Console.WriteLine(" Informe o raio do Círculo : ");
                        RaioDoCirculo = Convert.ToDouble(Console.ReadLine());
                        areaCirculo = Math.PI * Math.Pow(RaioDoCirculo, 2);               
                        Console.WriteLine(" A área do círculo de raio " + RaioDoCirculo.ToString() + " é : " + areaCirculo.ToString());
                        break;
                    case 5:
                        int V = 2022;
                        Console.WriteLine("Digite o ano em que nasceu:");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o ano atual:");
                        int anohj = int.Parse(Console.ReadLine());
                        int ano2 = V - ano;
                        ano = anohj - ano;

                        Console.WriteLine("A idade é " + ano);
                        Console.WriteLine("em 2022 sua idade vai ser " + ano2);

                        break;
                    case 6:

                        Console.WriteLine("Digite o preço de fabrica:\n");
                        double preco = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o percentual de lucro do distribuidor:\n");
                        double LucroD = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o percentual de impostos: \n");
                        double Impst = Convert.ToDouble(Console.ReadLine());
                        //A O  valor  correspondente  ao  lucro  do  distribuidor;
                        double a1 = preco / 100 * LucroD;
                        Console.WriteLine("lucro  do  distribuidor: R$" + a1);
                        //B O valor correspondente aos impostos;
                        double b1 = preco / 100 * Impst;
                        Console.WriteLine("R$" + b1);
                        //C O preço final do veículo.
                        double c1 = preco + a1 + b1;
                        Console.WriteLine("Preço Final do veiculo: R$" + c1);
                      








                        break;
                    case 7:
                        Console.WriteLine("Digite a altura dos degraus da escada em cm");
                        double degraus = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a altura que deseja chegar em cm");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        double objetivo = altura / degraus;
                        Console.WriteLine("Será preciso subir " + objetivo + " degraus");

                        break;
                    case 8:
                        Console.WriteLine("Digite a quantide de horas trabalhadas:");
                        int Horatrabalho = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o salário mínimo:");
                        double Salariomin = Convert.ToDouble(Console.ReadLine());
                        //A a hora trabalhada vale a metade do salário mínimo;
                        double aa = Salariomin / 2;
                        Console.WriteLine("hora trabalhada : R$" + aa);
                        //B  o salário bruto equivale ao número de horas trabalhadas multiplicado pelo valor da hora trabalhada;
                        double bb = Horatrabalho * aa;
                        Console.WriteLine("o salário bruto: R$" + bb);
                        //C  o imposto equivale a 3% do salário bruto;
                        double cc = bb / 100 * 3;
                        Console.WriteLine("imposto: R$" + cc);
                        //d  o salário a receber equivale ao salário bruto menos o imposto.
                        double dd = bb - cc;
                        Console.WriteLine("o salário a receber é: R$" + dd);
                        break;
                    case 9:
                        Random rnd = new Random();
                        int presente = rnd.Next(1, 4);

                        switch (presente)
                        {
                            case 1:
                                Console.WriteLine("Você ganhou uma coxinha de Presente!");
                                break;
                            case 2:
                                Console.WriteLine("Você ganhou um PS4  de Presente!");
                                break;
                            case 3:
                                Console.WriteLine("Você ganhou uma meia de Presente!");
                                break;
                            case 4:
                                Console.WriteLine("Você ganhou uma camisa feia de Presente!");
                                break;
                        }

                        break;

                    case 10:
                        Console.WriteLine("Por favor, digite um número de 1 a 1000");
                        int valor = Convert.ToInt32(Console.ReadLine());

                        {
                            if (valor <= 0 | valor >= 1000)
                                Console.Write("valor incorreto");
                            else
                            {
                                string montagem = string.Empty;
                                if (valor > 0 & valor < 1)
                                {
                                    valor *= 100;
                                }
                                string strValor = valor.ToString("000");
                                int a = Convert.ToInt32(strValor.Substring(0, 1));
                                int b = Convert.ToInt32(strValor.Substring(1, 1));
                                int c = Convert.ToInt32(strValor.Substring(2, 1));

                                if (a == 1) montagem += (b + c == 0) ? "CEM" : "CENTO";
                                else if (a == 2) montagem += "DUZENTOS";
                                else if (a == 3) montagem += "TREZENTOS";
                                else if (a == 4) montagem += "QUATROCENTOS";
                                else if (a == 5) montagem += "QUINHENTOS";
                                else if (a == 6) montagem += "SEISCENTOS";
                                else if (a == 7) montagem += "SETECENTOS";
                                else if (a == 8) montagem += "OITOCENTOS";
                                else if (a == 9) montagem += "NOVECENTOS";


                                if (b == 1)
                                {
                                    if (c == 0) montagem += ((a > 0) ? " E " : string.Empty) + "DEZ";
                                    else if (c == 1) montagem += ((a > 0) ? " E " : string.Empty) + "ONZE";
                                    else if (c == 2) montagem += ((a > 0) ? " E " : string.Empty) + "DOZE";
                                    else if (c == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TREZE";
                                    else if (c == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUATORZE";
                                    else if (c == 5) montagem += ((a > 0) ? " E " : string.Empty) + "QUINZE";
                                    else if (c == 6) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSEIS";
                                    else if (c == 7) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSETE";
                                    else if (c == 8) montagem += ((a > 0) ? " E " : string.Empty) + "DEZOITO";
                                    else if (c == 9) montagem += ((a > 0) ? " E " : string.Empty) + "DEZENOVE";

                                }
                                else if (b == 2) montagem += ((a > 0) ? " E " : string.Empty) + "VINTE";
                                else if (b == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TRINTA";
                                else if (b == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUARENTA";
                                else if (b == 5) montagem += ((a > 0) ? " E " : string.Empty) + "CINQUENTA";
                                else if (b == 6) montagem += ((a > 0) ? " E " : string.Empty) + "SESSENTA";
                                else if (b == 7) montagem += ((a > 0) ? " E " : string.Empty) + "SETENTA";
                                else if (b == 8) montagem += ((a > 0) ? " E " : string.Empty) + "OITENTA";
                                else if (b == 9) montagem += ((a > 0) ? " E " : string.Empty) + "NOVENTA";

                                if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " E ";

                                if (strValor.Substring(1, 1) != "1")
                                    if (c == 1) montagem += "UM";
                                    else if (c == 2) montagem += "DOIS";
                                    else if (c == 3) montagem += "TRÊS";
                                    else if (c == 4) montagem += "QUATRO";
                                    else if (c == 5) montagem += "CINCO";
                                    else if (c == 6) montagem += "SEIS";
                                    else if (c == 7) montagem += "SETE";
                                    else if (c == 8) montagem += "OITO";
                                    else if (c == 9) montagem += "NOVE";
                                Console.Write(montagem);





                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Obrigado pelo seu tempo, caso queira rever as questões rode o código novamente!");
                        break;

                }
            


            }
        }
    }
   
}