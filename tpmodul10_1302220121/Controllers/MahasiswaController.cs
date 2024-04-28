using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302220121.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : Controller
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa {Nama = "Mochammad Rizky Septian", Nim = "1302220121"},
            new Mahasiswa {Nama = "Muhammad Rafif AryaSatya Purnomo ", Nim = "1302220003"},
            new Mahasiswa {Nama = "Muhammad Ghaziveda Belvanaufal", Nim = "1302220011"},
            new Mahasiswa {Nama = "Daffa Adrianto Effendi", Nim = "1302220151"},
            new Mahasiswa {Nama = "Muhammad Ghiyats Fatiha", Nim = "1302220109"},
            new Mahasiswa {Nama = "Reihan Ramdhana Anwari ", Nim = "1302220048"},
            new Mahasiswa {Nama = "Muhammad Zidan Siva Fajar ", Nim = "1302223039"}
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> GetMahasiswa()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa GetMahasiswa(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void PostMahasiswa(Mahasiswa mahasiswa)
        {
            dataMahasiswa.Add(mahasiswa);
        }

        [HttpPut("{id}")]
        public void PutMahasiswa(int id, Mahasiswa mahasiswa)
        {
            dataMahasiswa[id] = mahasiswa;
        }

        [HttpDelete("{id}")]
        public void DeleteMahasiswa(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }

    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
    }
}
