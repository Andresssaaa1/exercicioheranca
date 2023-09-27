using Heranca_Pedagio.classes;
try
{
    Console.WriteLine("Qual o tipo do veículo?");
    Console.WriteLine("1- Passeio");
    Console.WriteLine("2- Utilitário");
    Console.WriteLine("3- Ônibus");
    Console.WriteLine("4- Caminhão");
    int carro = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Qual a placa do veiculo");
    string placa = Console.ReadLine();

    Console.WriteLine("Quantos eixos o veiculo tem");
    int eixos = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Qual o tipo do veiculo");
    Console.WriteLine("1_ fisico");
    Console.WriteLine("2_ Juridico");
    Console.WriteLine("3_ Oficial");
    int tipo = Convert.ToInt32(Console.ReadLine());

    if(carro == 1)
    {
        Passeio passeio = new Passeio(placa, eixos, tipo);
        Console.WriteLine(passeio.ValorFinal.ToString("F2"));
    }
    else if(carro == 2)
    {
        Utilitario utilitario = new Utilitario(placa, eixos, tipo);
        Console.WriteLine(utilitario.ValorFinal.ToString("F2"));
    }
    else if(carro == 3)
    {
        Onibus onibus = new Onibus(placa, eixos, tipo);
        Console.WriteLine(onibus.ValorFinal.ToString("F2"));
    }
    else if(carro == 4)
    {
        Caminhao caminhao = new Caminhao(placa, eixos, tipo);
        Console.WriteLine(caminhao.ValorFinal.ToString("F2"));
    }
}
catch(Exception ex)
{
    Console.WriteLine("Erro " + ex);
}