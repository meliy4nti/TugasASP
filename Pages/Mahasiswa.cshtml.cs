using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Models;

namespace AbsenOnline.Page
{
    public class MahasiswaModel : PageModel
    {
        
    private readonly ILogger<MahasiswaModel>_logger;
    public MahasiswaModel (ILogger<MahasiswaModel> logger)
    {
        _logger = logger;
    }



        public void OnGet()
        {
        }


 [BindProperty]

public Mahasiswa Mhs { get; set; }

public IActionResult OnPost ()
{
TempData["namaMahasiswa"] = Mhs.Nama;
TempData["kelasMahasiswa"] = Mhs.Kelas;
TempData["tempatMahasiswa"] = Mhs.TempatLahir;
TempData["tglMahasiswa"] = Mhs.TglLahir;
return Page ();
    }


}
}
