using blogcsharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace blogcsharp.Controllers
{
    public class HomeController : Controller
    {
        public List<Wpis> Wpisy = new List<Wpis>();
        public HomeController()
        {
            Wpisy.Add(new Wpis()
            {
                CreateDate = DateTime.Now,
                Description = "Wyspa została odkryta przez Portugalczyków w 1505\r\n                            roku. Skolonizowana została przez Holendrów w 1638 i nazwana imieniem księcia Maurycego\r\n                            Orańskiego. Francuzi opanowali wyspę w XVIII wieku, zmieniając nazwę na Île de France. Nazwa\r\n                            Mauritius została przywrócona w 1810 roku, gdy Brytyjczycy przejęli wyspę. Anglicy znieśli\r\n                            niewolnictwo i zaczęli sprowadzać robotników z Indii.\r\n\r\n                            Mauritius uzyskał niezależność w 1968 roku. 18 kwietnia 1968 roku na podstawie Rezolucji\r\n                            Rady Bezpieczeństwa ONZ nr 249 Mauritius został członkiem ONZ[4].\r\n\r\n                            Kraj stał się republiką w ramach Wspólnoty Narodów w 1992. Jest jednym z nielicznych krajów\r\n                            afrykańskich posiadających stabilną demokrację z regularnie odbywającymi się wolnymi\r\n                            wyborami i przestrzeganymi prawami człowieka. Dzięki rozwiniętemu sektorowi turystycznemu\r\n                            przyciągnął znaczne zagraniczne inwestycje, osiągając tym samym jeden z najwyższych w Afryce\r\n                            dochodów na obywatela.",
                ShortDescription = "Mauritius (fr. Maurice), Republika Mauritiusu[3]\r\n                            (ang. Republic of Mauritius, fr. République de Maurice) – państwo wyspiarskie położone w\r\n                            południowo-zachodniej części Oceanu Indyjskiego, w archipelagu Maskarenów, około 900 km na\r\n                            wschód od Madagaskaru i ok. 170 km na północny wschód od Reunionu. Poza samą wyspą Mauritius\r\n                            do Republiki Mauritiusu należą także: wyspa Rodrigues (w odległości 563 km na wschód od\r\n                            wyspy głównej), archipelag Cargados Carajos (402 km na północ) i Wyspy Agalega (933 km na\r\n                            północ).\r\n                            Mauritius razem z wyspami Reunion i Rodrigues jest częścią archipelagu Maskarenów.\r\n                            Archipelag ten powstał miliony lat temu w wyniku podwodnych erupcji wulkanicznych.",
                ImageUrl = "https://picsum.photos/900/200",
                Name = "Ogólne informacje o Mauritiusie",
                ID = 1,

                Galeria = new List<Obrazek>()  
                
            }) ;

            

            


            Wpisy.Add(new Wpis()
            {
                CreateDate = DateTime.Now,
                Description = "Największy udział w składzie etnicznym ludności mają\r\n                            Kreole i Hindusi. Zamieszkują tu także Europejczycy i niewielka grupa Chińczyków. Ponad\r\n                            połowa ludności to wyznawcy hinduizmu (52%). Duży procent stanowią także katolicy (26%) i\r\n                            muzułmanie (17%).\r\n\r\n                            Językiem urzędowym jest angielski, jednak znaczna część ludności mówi także po francusku. W\r\n                            powszechnym użyciu jest język kreolski, powstały na podstawie francuskiego, oraz różne\r\n                            języki pochodzące z Indii.Mauritius odznacza się wysokim stopniem\r\n                            zurbanizowania. Ludność miejska stanowi ponad 41% wszystkich mieszkańców. Przyrost naturalny\r\n                            jest stosunkowo niski, jak na kraj afrykański.\r\n\r\n                            Ewenementem jest również bardzo niski stopień analfabetyzmu. Wynika to z rozwiniętego i\r\n                            wspieranego przez rząd systemu edukacji. Obejmuje on wszystkie dzieci. Czas końcowych\r\n                            egzaminów w szkołach staje się najważniejszym w roku okresem w życiu wyspy ma charakter\r\n                            narodowego święta.Najbarwniejszą stroną wyspiarskiej kultury jest\r\n                            handel uliczny. Nawoływania i zachęcania kupców i przekupek przy straganach z różnościami,\r\n                            podobnie jak zwyczaj targowania się, należą do nieodłącznych elementów życia mieszkańców\r\n                            Mauritiusa.\r\n\r\n                            Bogata i oryginalna kultura narodowa kultywowana jest przez liczne krajowe zespoły teatralne\r\n                            i grupy folklorystyczne, a także wielu artystów indywidualnych. Bardzo ważną rolę w kulturze\r\n                            i obyczajach wyspy stanowi muzyka i taniec. Tańcem narodowym jest sega. Jest bardzo\r\n                            dynamiczny i żywiołowy, ma swe korzenie w rytmach afrykańskich. Przypomina afrykańską sambę.",
                ShortDescription = "Największy udział w składzie etnicznym ludności mają Kreole i Hindusi. Zamieszkują tu także Europejczycy i niewielka grupa Chińczyków. Ponad połowa ludności to wyznawcy hinduizmu (52%). Duży procent stanowią także katolicy (26%) i muzułmanie (17%). Językiem urzędowym jest angielski, jednak znaczna część ludności mówi także po francusku. W powszechnym użyciu jest język kreolski, powstały na podstawie francuskiego, oraz różne języki pochodzące z Indii. ",
                ImageUrl = "https://picsum.photos/900/200",
                Name = "Kultura na Mauritiusie",
                ID = 2
            });


            Wpisy.Add(new Wpis()
            {
                CreateDate = DateTime.Now,
                Description = "Wyspa została odkryta przez Portugalczyków w 1505\r\n                            roku. Skolonizowana została przez Holendrów w 1638 i nazwana imieniem księcia Maurycego\r\n                            Orańskiego. Francuzi opanowali wyspę w XVIII wieku, zmieniając nazwę na Île de France. Nazwa\r\n                            Mauritius została przywrócona w 1810 roku, gdy Brytyjczycy przejęli wyspę. Anglicy znieśli\r\n                            niewolnictwo i zaczęli sprowadzać robotników z Indii.\r\n\r\n                            Mauritius uzyskał niezależność w 1968 roku. 18 kwietnia 1968 roku na podstawie Rezolucji\r\n                            Rady Bezpieczeństwa ONZ nr 249 Mauritius został członkiem ONZ[4].\r\n\r\n                            Kraj stał się republiką w ramach Wspólnoty Narodów w 1992. Jest jednym z nielicznych krajów\r\n                            afrykańskich posiadających stabilną demokrację z regularnie odbywającymi się wolnymi\r\n                            wyborami i przestrzeganymi prawami człowieka. Dzięki rozwiniętemu sektorowi turystycznemu\r\n                            przyciągnął znaczne zagraniczne inwestycje, osiągając tym samym jeden z najwyższych w Afryce\r\n                            dochodów na obywatela.",
                ShortDescription = "Mauritius (fr. Maurice), Republika Mauritiusu[3]\r\n                            (ang. Republic of Mauritius, fr. République de Maurice) – państwo wyspiarskie położone w\r\n                            południowo-zachodniej części Oceanu Indyjskiego, w archipelagu Maskarenów, około 900 km na\r\n                            wschód od Madagaskaru i ok. 170 km na północny wschód od Reunionu. Poza samą wyspą Mauritius\r\n                            do Republiki Mauritiusu należą także: wyspa Rodrigues (w odległości 563 km na wschód od\r\n                            wyspy głównej), archipelag Cargados Carajos (402 km na północ) i Wyspy Agalega (933 km na\r\n                            północ).\r\n                            Mauritius razem z wyspami Reunion i Rodrigues jest częścią archipelagu Maskarenów.\r\n                            Archipelag ten powstał miliony lat temu w wyniku podwodnych erupcji wulkanicznych.",
                ImageUrl = "https://picsum.photos/900/200",
                Name = "Kuchnia na Mauritiusie",
                ID = 3
            });


            Wpisy.Add(new Wpis()
            {
                CreateDate = DateTime.Now,
                Description = "Wyspa została odkryta przez Portugalczyków w 1505\r\n                            roku. Skolonizowana została przez Holendrów w 1638 i nazwana imieniem księcia Maurycego\r\n                            Orańskiego. Francuzi opanowali wyspę w XVIII wieku, zmieniając nazwę na Île de France. Nazwa\r\n                            Mauritius została przywrócona w 1810 roku, gdy Brytyjczycy przejęli wyspę. Anglicy znieśli\r\n                            niewolnictwo i zaczęli sprowadzać robotników z Indii.\r\n\r\n                            Mauritius uzyskał niezależność w 1968 roku. 18 kwietnia 1968 roku na podstawie Rezolucji\r\n                            Rady Bezpieczeństwa ONZ nr 249 Mauritius został członkiem ONZ[4].\r\n\r\n                            Kraj stał się republiką w ramach Wspólnoty Narodów w 1992. Jest jednym z nielicznych krajów\r\n                            afrykańskich posiadających stabilną demokrację z regularnie odbywającymi się wolnymi\r\n                            wyborami i przestrzeganymi prawami człowieka. Dzięki rozwiniętemu sektorowi turystycznemu\r\n                            przyciągnął znaczne zagraniczne inwestycje, osiągając tym samym jeden z najwyższych w Afryce\r\n                            dochodów na obywatela.",
                ShortDescription = "Mauritius (fr. Maurice), Republika Mauritiusu[3]\r\n                            (ang. Republic of Mauritius, fr. République de Maurice) – państwo wyspiarskie położone w\r\n                            południowo-zachodniej części Oceanu Indyjskiego, w archipelagu Maskarenów, około 900 km na\r\n                            wschód od Madagaskaru i ok. 170 km na północny wschód od Reunionu. Poza samą wyspą Mauritius\r\n                            do Republiki Mauritiusu należą także: wyspa Rodrigues (w odległości 563 km na wschód od\r\n                            wyspy głównej), archipelag Cargados Carajos (402 km na północ) i Wyspy Agalega (933 km na\r\n                            północ).\r\n                            Mauritius razem z wyspami Reunion i Rodrigues jest częścią archipelagu Maskarenów.\r\n                            Archipelag ten powstał miliony lat temu w wyniku podwodnych erupcji wulkanicznych.",
                ImageUrl = "https://picsum.photos/900/200",
                Name = "Ogólne informacje o Mauritiusie",
                ID = 4
            });
            
        }


        // /Home/Index
        public IActionResult Index()
        {
            return View(Wpisy);
        }
        public IActionResult Ogolne()
        {
            return View();
        }
        public IActionResult Artykul(int id)
        {
            var mojwpis = Wpisy.FirstOrDefault(xa=>xa.ID == id);

            return View(mojwpis);
        }      
       
    }
}
