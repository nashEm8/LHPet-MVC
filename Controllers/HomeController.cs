using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {


        Cliente c1 = new(01, "Emanuel Azevedo", "999.999.999-99", "emanuel8@outlook.com", "Boneca");
        Cliente c2 = new Cliente(02, "Samuel Azevedo", "111.111.111-11", "samuel19@outlook.com", "Beriluz");
        Cliente c3 = new Cliente(03, "Dinha", "222.222.222-22", "franciscaero20@outlook.com", "Diretor");
        Cliente c4 = new Cliente(04, "Ana Késia", "444.444.444-44", "anakesialima19@outlook.com", "Nala");
        Cliente c5 = new Cliente(05, "David Paulino", "555.555.555-55", "davidpfsc@outlook.com", "Teff");
        
        List<Cliente> listaClientes = [c1, c2, c3, c4, c5];

        ViewBag.listaClientes = listaClientes;

        
        Fornecedor f1 = new Fornecedor(01, "086 Pets", "77.777.777/7777-77", "086pets@gmail.com");
        Fornecedor f2 = new Fornecedor(02, "Dog Feliz", "88.888.888/8888-88", "dogfeliz@gmail.com");
        Fornecedor f3 = new Fornecedor(03, "+Pets", "99.999.999/9999-99","maispets@gmail.com");
        Fornecedor f4 = new Fornecedor(04, "Doguinho", "11.111.111/1111-11", "doguinho@gmail.com");
        Fornecedor f5 = new Fornecedor(05, "Sr. Pets", "22.222.222/2222-22", "srpets@gmail.com");
        
        List<Fornecedor> listaFornecedores = [f1, f2, f3, f4, f5,];

        ViewBag.listaFornecedores = listaFornecedores;
        
        
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
