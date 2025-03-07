﻿using System.Net.Mime;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LaCunaServer.Server.Api.Models.Client;
using LaCunaServer.Server.Api.Models.Multiplayer;
using LaCunaServer.Server.Api.Models.Multiplayer.Data;
using LaCunaServer.Server.Api.Services.Auth.Entity;
using LaCunaServer.Server.Api.Services.Auth.User;

namespace LaCunaServer.Server.Api.Controllers;

[Route("MultiplayerServer")]
[ApiController]
[Authorize(AuthenticationSchemes = EntityAuthenticationOptions.DefaultScheme)]
public class MultiplayerController : Controller
{
    private readonly ILogger<MultiplayerController> _logger;

    public MultiplayerController(ILogger<MultiplayerController> logger)
    {
        _logger = logger;
    }

    [HttpPost("ListQosServersForTitle")]
    [Produces(MediaTypeNames.Application.Json)]
    [Authorize(AuthenticationSchemes = UserAuthenticationOptions.DefaultScheme)]
    public IActionResult ListQosServersForTitle(FListQosServersForTitleRequest request)
    {
        return Ok(new ClientResponse<object>
        {
            Code = 200,
            Status = "OK",
            Data = new FListQosServersForTitleResponse
            {
                PageSize = 1,
                QosServers = new List<FQosServer>
                {
                    new FQosServer
                    {
                        Region = "NorthEurope",
                        ServerUrl = "127.0.0.1"
                    }
                }
            }
        });
    }
}