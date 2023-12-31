﻿using Microsoft.AspNetCore.Mvc;
using portal_roadtrip.Application.DTO;
using portal_roadtrip.Application.Interfaces;
using portal_roadtrip.Domain.Entities;

namespace portal_roadtrip.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PontoEmbarqueController : ControllerBase
{
    private readonly IPontoEmbarqueService PontoEmbarqueService;
    public PontoEmbarqueController(IPontoEmbarqueService pontoEmbarqueService)
    {
        PontoEmbarqueService = pontoEmbarqueService;
    }

    [HttpGet("ListarPontoEmbarques")]
    public async Task<List<PontoEmbarque>> ListarPontoEmbarques()
    {
        return await PontoEmbarqueService.ListarPontoEmbarques();
    }

    [HttpGet("ListarPontoEmbarquesPorEvento/{eventoId}")]
    public async Task<List<PontoEmbarqueEventoDTO>> ListarPontoEmbarquesPorEvento( int eventoId)
    {
        return await PontoEmbarqueService.ListarPontoEmbarquesPorEvento(eventoId);
    }
    
}
