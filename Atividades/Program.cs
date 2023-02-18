using Microsoft.VisualBasic;
namespace Atividades
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                for (int i = 1; i > 0;)
                {
                    int opcao = Int32.Parse(Interaction.InputBox("ESCOLHA UM EXERCICIO:" +
                        "\n11 12 16 18 \n23 25 26 27 \n31 40 41 42 \n43 44 46 48"));

                    switch (opcao)
                    {
                        case 11:
                            MessageBox.Show("EXERCICIO 11:\n\nAprendendo Algoritmo!!!");
                            break;
                        
                        case 12:
                            MessageBox.Show("EXERCICIO 12:\n\nAprendendo Algoritmo!!! Com Anita e Guto");
                            break;
                        
                        case 16:
                            int z = 10;
                            MessageBox.Show("EXERCICIO 16:\n\nZ = " +z);
                            break;

                        case 18:
                            z = 10;
                            MessageBox.Show("EXERCICIO 18:\n\nZ = " + ++z);
                            break;

                        case 23:
                            int a, d;
                            a = Int32.Parse(Interaction.InputBox("EXERCICIO 23:\n\nUM NUMERO DE TRES CASAS:"));
                            d = (a % 100) / 10;
                            MessageBox.Show("ALGARISMO DA CASA DAS DEZENAS: " + d);
                            break;

                        case 25:
                            int data, dia, mes, ano;
                            data = Int32.Parse(Interaction.InputBox("EXERCICIO 25:\n\nUMA DATA NO FORMATO DDMMAA:"));
                            dia = data / 10000;
                            mes = (data % 10000) / 100;
                            ano = data % 100;
                            MessageBox.Show("Dia: " + dia + "\nMes: " + mes + "\nAno: " + ano);
                            break;

                        case 26:
                            int ndata;
                            data = Int32.Parse(Interaction.InputBox("EXERCICIO 26:\n\nUMA DATA NO FORMATO DDMMAA:"));
                            dia = data / 10000;
                            mes = (data % 10000) / 100;
                            ano = data % 100;
                            ndata = mes * 10000 + dia * 100 + ano;
                            MessageBox.Show("Dia: " + dia + "\nMes: " + mes + "\nAno: " + ano + "\nData MMDDAA: " + ndata);
                            break;
                        case 27:
                            int x = 2, y = 5;
                            MessageBox.Show("EXERCICIO 27:\n\nValor de X: " + x++ + "\nValor de Y: " + y++ + "\n\nNovo Valor de X: " + x + "\nNovo Valor de Y: " + y);
                            break;
                        case 31:
                            float ma;
                            ma = (8 + 7 + 9) / 3;
                            MessageBox.Show("EXERCICIO 31:\n\nMEDIA ARITMETICA DE 7 8 9: " + ma);
                            break;

                        case 40:
                            int quoc, rest, val1, val2;
                            val1 = Int32.Parse(Interaction.InputBox("EXERCICIO 40:\n\nENTRE COM O DIVIDENDO: "));
                            val2 = Int32.Parse(Interaction.InputBox("EXERCICIO 40:\n\nENTRE COM O DIVISOR: "));
                            quoc = val1 / val2;
                            rest = val1 % val2;
                            MessageBox.Show("DIVIDENDO: " + val1 + "\nDIVISOR: " + val2 + "\nQuociente: " + quoc + "\nResto: " + rest);
                            break;

                        case 41:
                            float x1 = float.Parse(Interaction.InputBox("EXERCICIO 41:\n\nENTRE COM O PESO 1: "));
                            float x2 = float.Parse(Interaction.InputBox("ENTRE COM O PESO 2: "));
                            float x3 = float.Parse(Interaction.InputBox("ENTRE COM O PESO 3: "));
                            float x4 = float.Parse(Interaction.InputBox("ENTRE COM O PESO 4: "));
                            float mp = (x1 + (x2 * 2) + (x3 * 3) + (x4 * 4)) / 10;
                            MessageBox.Show("MEDIA PONDERADA: " + mp);
                            break;

                        case 42:
                            double range, angle;
                            angle = double.Parse(Interaction.InputBox("EXERCICIO 42:\n\nENTRE COM UM ANGULO:"));

                            MessageBox.Show("COSSENO: " + Math.Cos(angle) + "\nSENO " + Math.Sin(angle) + "\nTANGENTE: " + Math.Tan(angle ) 
                                + "\nCO-TANGETE: " + (1 / Math.Tan(angle)) + "\nCO-SECANTE: " + (1 / Math.Sin(angle)) + "\nSECANTE: " + (1 / Math.Cos(angle)));
                            break;

                        case 43:
                            double num;
                            num = double.Parse(Interaction.InputBox("EXERCICIO 43:\n\nENTRE COM UM LOGARITMANDO:"));
                            MessageBox.Show("LOGARITMO NA BASE 10: " + Math.Log10(num));
                            break;

                        case 44:
                            double baselog;
                            num = double.Parse(Interaction.InputBox("EXERCICIO 44:\n\nENTRE COM O LOGARITMANDO:"));
                            baselog = double.Parse(Interaction.InputBox("ENTRE COM A BASE:"));
                            MessageBox.Show("LOGARITMO NA BASE " + baselog +" : " + Math.Log(num, baselog));
                            break;

                        case 46:
                            double saldo = double.Parse(Interaction.InputBox("EXERCICIO 46:\n\nENTRE COM SALDO: "));
                            double nsaldo = saldo * 1.01;
                            MessageBox.Show("NOVO SALDO: R$" + nsaldo);
                            break;

                        case 48:
                            double sm = double.Parse(Interaction.InputBox("EXERCICIO 48:\n\nINFORME O VALOR DO SALARIO MINIMO:"));
                            double kw = double.Parse(Interaction.InputBox("INFORME A QUANTIDADE DE KW:"));
                            double preco = sm / 700;
                            double vp = preco * kw;
                            double vd = vp * 0.9;

                            MessageBox.Show("Preco KW: R$" + preco + "\nValor a ser pago: R$" + vp + "\nValor com desconto: R$" + vd);
                            break;

                        default:
                            MessageBox.Show("Opcao invalida, porfavor escolha uma entre as fornecidas ou pressione cancelar para sair!");
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Obrigado!");
            }
        }
    }
}