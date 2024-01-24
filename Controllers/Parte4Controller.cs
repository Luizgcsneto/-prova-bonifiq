using Microsoft.AspNetCore.Mvc;
using ProvaPub.Models;
using ProvaPub.Repository;
using ProvaPub.Services;
using ProvaPub.Services.Interfaces;

namespace ProvaPub.Controllers
{
	
	/// <summary>
	/// O Código abaixo faz uma chAmada para a regra de negócio que valida se um consumidor pode fazer uma compra.
	/// Crie o teste unitário para esse Service. Se necessário, faça as alterações no código para que seja possível realizar os testes.
	/// Tente criar a maior cobertura possível nos testes.
	/// 
	/// Utilize o framework de testes que desejar. 
	/// Crie o teste na pasta "Tests" da solution
	/// </summary>
	[ApiController]
	[Route("[controller]")]
	public class Parte4Controller :  ControllerBase
	{
        TestDbContext _ctx;
		private readonly ICustomerService _ICustomerService;
        public Parte4Controller(TestDbContext ctx, ICustomerService ICustomerService)
        {
            _ctx = ctx;
			_ICustomerService = ICustomerService;
        }

        [HttpGet("CanPurchase")]
		public async Task<bool> CanPurchase(int customerId, decimal purchaseValue)
		{
			return await _ICustomerService.CanPurchase(customerId, purchaseValue);
		}
	}
}
