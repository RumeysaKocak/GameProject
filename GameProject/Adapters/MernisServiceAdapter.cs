using GameProject.Abstract;
using GameProject.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            ServiceReference1.KPSPublicSoapClient client = new ServiceReference1.KPSPublicSoapClient(ServiceReference1.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(TCKimlikNo: Convert.ToInt64(gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
