using AVI.Clima.DTOs.Responses.Forecast;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVI.Clima.DTOs.Requests.Forecast
{
    public class GetRequest : IRequest<GetResponse>
    {
    }
}
