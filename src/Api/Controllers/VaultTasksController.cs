using Bit.Api.Models;
using Bit.Api.Models.Response;
using Bit.Core.Exceptions;
using Bit.Core.Repositories;
using Bit.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bit.Api.Controllers;

[Route("vault-tasks")]
[Authorize("Application")]
public class VaultTasksController : Controller
{
    private readonly IVaultTaskService _vaultTaskService;

    public VaultTasksController(IVaultTaskService vaultTaskService)
    {
        _vaultTaskService = vaultTaskService;
    }

    [HttpGet("user/{id}")]
    public async Task<string> GetVaultTasks(string id) {}
    [HttpPost("user/{id}")]
    public async Task<bool> UpdateVaultTask(string id, VaultTasksRequestModel req) {}

}
