using GameProject.Abstract;
using GameProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
namespace GameProject.Adapters
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealCustomer(Gamer gamer)
        {


            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.TcNumber),
                gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(),
                gamer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;


        }
    }
}
