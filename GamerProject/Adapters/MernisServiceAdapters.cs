using GamerProject.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Adapters
{
    public class MernisServiceAdapters : IGamerCheckService
    {
        public MernisServiceAdapters()
        {
        }

        public bool CheckIfRealGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(TCKimlikNo: Convert.ToInt64(gamer.NationalityId), Ad: gamer.FirstName.ToUpper(), Soyad: gamer.LastName.ToUpper(), DogumYili: gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
