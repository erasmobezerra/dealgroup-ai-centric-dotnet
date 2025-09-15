using System;

public class CleanCode
{
    public static void Main(string[] args)
    {
        // muito subjetivo
        string name = "Felipe";

        // correto
        string userName = "Felipe";
        string productName = "mouse";


        // muito subjetivo
        double tax = 0.1;

        // correto
        double sendingTax = 0.5;
        double sendingTaxBase = 0.1;
        double sendingTazMaximum = 1;


        // número mágico é um número jogado sem sentido
        const double TAX_LIMIT_BY_COUNTRY = 2.0;

        // subjetivo
        if (tax < 2.0)
        {
            // ...
        }

        // sentido para os números de uma maneira clara e objetiva. 
        if (sendingTax < TAX_LIMIT_BY_COUNTRY)
        {
            // ...
        }


        double myST = 3.0; // abreviado e não recomendado
        double userPersonaSendingTax = 3.0; // específico e correto


        double rng = 1; // abreviado
        double range = 1; // subjetivo, intervalo de quê?
        double rangeOfDaysToSendingProduct = 1; // específico e correto
    }

    // receber dados do usuário em um sistema d eenvio, salvar isso em um banco de dados de historico,
    // depois gerar um pedido com codigo de rastreio

    // problemas do código abaixo:
    // 1- nomes subjetivos
    // 2- excesso de parametros
    // 3- nome da funcao esta subjetiva
    // 4- funcao faz tudo 
    public string Sending(string name, string zip, string data, string country)
    {
        // pegar dados do usuario
        string user = name;
        string zipcode = zip;

        // comunicar com o banco de dados
        string date = data;
        string countryy = country;

        // retorna código do pedido
        return "12345";
    }

    // função da maneira certa
    // prefixos
    // - get
    // - load
    // - do / make
    // - delete
    // - save

    public void makeProductOrder()
    {
        getDataFromUserToSending();
        saveToDatabaseHistoric();
        createTicketToOrder();
        
    }
    // colher dados do usuario em um sistema de ennvio
    public string getDataFromUserToSending()
    {
        return "2025-09-15";
    }

    // salvar dados em um banco de dados de historico
    public void saveToDatabaseHistoric()
    {

    }

    //depois gerar um pedido com código de rastreio
    public string createTicketToOrder()
    {
        return "123456";
    }



}



