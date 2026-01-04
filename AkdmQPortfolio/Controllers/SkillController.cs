using AkdmQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkdmQPortfolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public SkillController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            //tüm yetenekleri listele _portfolyodbContext
            //bizim veri tabanında 10 tane verimiz var bu 10 veriyi liste şeklinde getiriyor
            //4-5 tane veri var.
            var SkillList = _portfolyodbContext.SkillTables.ToList();


            return View(SkillList);
        }

        [HttpGet]
        //HttpGet ile 5 no'lu id ye ait verileri getirdik bu şekilde sayfa ilk açıldığında neyi güncelleyeceğimizi göreceğiz 
        public IActionResult UpdateSkill(int id)
        {   
            //ilgili veriyi veri tabanından buluyoruz dışarıdan aldığımız id değerine göre
            //Güncelleme sayfası ilk açıldığında ilgili verilerin getirilmesi
            var SkillUpdate = _portfolyodbContext.SkillTables.Find(id);
            return View(SkillUpdate);
        }
        [HttpPost]
        //HttpPost ile 5 no'lu id'yi güncelleyeceğiz html de ilgili metin kutularında değişiklikleri yapıp güncelle butonuna basıldığında burası çalışacak.
        public IActionResult UpdateSkill(SkillTable skill)
        {   
            //skill = SkillTable bu classta yer alan verilere göre verilerimiz var
            //Gelen veriyi güncellemek istediğimiz veriyi değiştirdikten sonra bu verinin güncellenmesi

            //Bir verinin güncellemesi için 
            //1.adım veritabanı bağlantısı
            //2.adım güncellenecek veriyi al
            
            _portfolyodbContext.SkillTables.Update(skill);
            //3.güncellenecek veriyi güncelle
            _portfolyodbContext.SaveChanges();
            //4.adım ctrl+s kaydet
            return RedirectToAction("Index");
        }

        //Araştırılacak burada neden httpget kullandık
        public IActionResult DeleteSkill(int id)
        {
            //1.adım veri tabanı bağlantısı
            //2.adım ilgili veriyi bul neye göre --> idye göre
            //3.adım veriyi sil
            //4.adım değişiklikleri kaydet
            //5.adım bitiş

            var value = _portfolyodbContext.SkillTables.Find(id);
            _portfolyodbContext.SkillTables.Remove(value);
            _portfolyodbContext.SaveChanges();

            return RedirectToAction("Index"); 
        }


    }
}
