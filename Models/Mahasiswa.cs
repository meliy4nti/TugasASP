using System;
using System.ComponentModel.DataAnnotations;
namespace Models
{

public class Mahasiswa
{
[Required(ErrorMessage = "Nama Wajib diisi")]

public string Nama{get;set;}

public string Kelas{get;set;}
[Required(ErrorMessage = "Tempat Lahir Wajib diisi")]
[RegularExpression("^[a-zA-Z ]*$",
ErrorMessage = "Tempat lahir hanya huruf")]

public string TempatLahir{get;set;}
[DataType(DataType.Date)]

public DateTime TglLahir {get;set;}
[Range(100,180,ErrorMessage="Tinggi Badan antara 100-800")]

public int tinggiBadan{get;set;}
[RegularExpression("^[0-9]+$")]

public string Hp {get;set;}
}
}
