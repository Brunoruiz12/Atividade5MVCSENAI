using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPets.Models;

namespace LHPets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancia do tipo cliente
        Cliente cliente1 = new Cliente(01, "Gabriela Fernandes", "123.456.789-00", "gabriela.fernandes@gmail.com", "Theodoro");
        Cliente cliente2 = new Cliente(02, "Gabriela Fernandes", "123.456.789-00", "gabriela.fernandes@gmail.com", "Nina");
        Cliente cliente3 = new Cliente(03, "Caio lavorato", "789.456.123-55", "caio.lavorato@gmail.com", "berenice");
        Cliente cliente4 = new Cliente(04, "Carla lavorato", "561.524.541.56", "Carla.lavorato@gmail.com", "Cesar");
        Cliente cliente5 = new Cliente(05, "Bruno ruiz", "436.789.561-88", "bruno.machado@gmail.com", "Harry");

     //listaclientes
        List<Cliente> listaCliente = new List<Cliente>();
        listaCliente.Add(cliente1);
        listaCliente.Add(cliente2);
        listaCliente.Add(cliente3);
        listaCliente.Add(cliente4);
        listaCliente.Add(cliente5);

        ViewBag.listaCliente =  listaCliente;


        //istancia do tipo fornecedor e atribuir clientes 
        Fornecedor fornecedor1  = new Fornecedor(01,"C# Pet S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02,"Ctrl Alt Dog", "15.836.698/0001-57", "crtl@alt.dog.br");
        Fornecedor fornecedor3  = new Fornecedor(03,"BootsPets", "40.810.224/0001-09", "boots.pet@gatomania.us");
        Fornecedor fornecedor4  = new Fornecedor(04,"Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5  = new Fornecedor(05,"Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

         //listafornecedor e atribuir os fornecedores

         List<Fornecedor> listaFornecedores = new List<Fornecedor>();
          
          listaFornecedores.Add(fornecedor1);
          listaFornecedores.Add(fornecedor2);
          listaFornecedores.Add(fornecedor3);
          listaFornecedores.Add(fornecedor4);
          listaFornecedores.Add(fornecedor5);

            ViewBag.listafornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
