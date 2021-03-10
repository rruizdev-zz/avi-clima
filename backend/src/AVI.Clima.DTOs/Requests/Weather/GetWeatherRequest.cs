﻿using AVI.Clima.DTOs.Responses.Weather;
using MediatR;

namespace AVI.Clima.DTOs.Requests.Weather
{
    public class GetWeatherRequest : IRequest<GetWeatherResponse>
    {
    }
}
