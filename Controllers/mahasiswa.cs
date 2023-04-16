using Microsoft.AspNetCore.Mvc;
using tpmodul9_1302210124;

namespace tpmodul9_1302210124.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswa : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Ryan Piskadinata", "1302210124"),
            new Mahasiswa("Muhammad Nurrasyid Wajidi", "1302213xxx"),
            new Mahasiswa("Muhammad Nagif", "1302213xxx"),
            new Mahasiswa("Fadel Alif Sadena", "1302210xxx"),
            new Mahasiswa("Fahryan Anggriantaka", "1302213xxx")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa value)
        {
            dataMahasiswa[id] = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}