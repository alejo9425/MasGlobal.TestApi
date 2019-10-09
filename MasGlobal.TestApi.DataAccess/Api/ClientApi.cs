
namespace MasGlobal.TestApi.DataAccess.Api
{
    using MasGlobal.TestApi.DTO.Employee;
    using Newtonsoft.Json;
    using Spring.Http;
    using Spring.Rest.Client;
    using Spring.Http.Converters.Json;
    using System.Collections.Generic;

    public class ClientApi
    {
        public List<DTOEmployee> GetEmployees()
        {

            HttpHeaders headers = new HttpHeaders();
            headers.Set("Content-Type", "application/json");
            RestTemplate template = new RestTemplate("http://masglobaltestapi.azurewebsites.net/");
            template.MessageConverters.Add(new DataContractJsonHttpMessageConverter());

            var response = template.GetForObjectAsync<string>("api/Employees");

            List<DTOEmployee> _Employee = JsonConvert.DeserializeObject<List<DTOEmployee>>(response.Result);
            return _Employee;
        }
    }
}
