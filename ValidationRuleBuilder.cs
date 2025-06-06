using AppSettingsValidator.Models;
using System;
using System.Text.RegularExpressions;

namespace AppSettingsValidator
{
    public static class ValidationRuleBuilder
    {
        // North America
        private static readonly Regex UsPattern = new(@"^\+1[2-9]\d{9}$|^1[2-9]\d{9}$|^[2-9]\d{9}$");
        private static readonly Regex CanadaPattern = new(@"^\+1[2-9]\d{9}$|^1[2-9]\d{9}$|^[2-9]\d{9}$");
        private static readonly Regex MexicoPattern = new(@"^\+52[1-9]\d{9}$|^52[1-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex CubaPattern = new(@"^\+53[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex DominicanPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex JamaicaPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex BahamasPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex BarbadosPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex TrinidadPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex AntiguaPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex DominicaPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex GrenadaPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex StKittsPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex StLuciaPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex StVincentPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex ArubaPattern = new(@"^\+297[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex CuracaoPattern = new(@"^\+599[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex SintMaartenPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex CaymanPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex BermudaPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex TurksPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex VirginIslandsPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex PuertoRicoPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");

        // Central America
        private static readonly Regex BelizePattern = new(@"^\+501[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex CostaRicaPattern = new(@"^\+506[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex ElSalvadorPattern = new(@"^\+503[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex GuatemalaPattern = new(@"^\+502[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex HondurasPattern = new(@"^\+504[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex NicaraguaPattern = new(@"^\+505[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex PanamaPattern = new(@"^\+507[1-9]\d{7}$|^[1-9]\d{7}$");

        // South America
        private static readonly Regex BrazilPattern = new(@"^\+55[1-9]\d{10}$|^[1-9]\d{10}$");
        private static readonly Regex ArgentinaPattern = new(@"^\+54[1-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex ColombiaPattern = new(@"^\+57[1-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex ChilePattern = new(@"^\+56[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex PeruPattern = new(@"^\+51[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex VenezuelaPattern = new(@"^\+58[1-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex EcuadorPattern = new(@"^\+593[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex BoliviaPattern = new(@"^\+591[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex ParaguayPattern = new(@"^\+595[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex UruguayPattern = new(@"^\+598[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex GuyanaPattern = new(@"^\+592[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex SurinamePattern = new(@"^\+597[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex FrenchGuianaPattern = new(@"^\+594[1-9]\d{8}$|^0[1-9]\d{8}$");

        // Europe
        private static readonly Regex UkPattern = new(@"^\+44[1-9]\d{8,9}$|^07\d{9}$|^0[1-9]\d{8,9}$");
        private static readonly Regex GermanyPattern = new(@"^\+49[1-9]\d{8,11}$|^0[1-9]\d{8,11}$");
        private static readonly Regex FrancePattern = new(@"^\+33[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex ItalyPattern = new(@"^\+39[1-9]\d{8,10}$|^0[1-9]\d{8,10}$");
        private static readonly Regex SpainPattern = new(@"^\+34[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex RussiaPattern = new(@"^\+7[1-9]\d{9}$|^8[1-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex NetherlandsPattern = new(@"^\+31[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex BelgiumPattern = new(@"^\+32[1-9]\d{7,8}$|^0[1-9]\d{7,8}$");
        private static readonly Regex SwedenPattern = new(@"^\+46[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex NorwayPattern = new(@"^\+47[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex DenmarkPattern = new(@"^\+45[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex FinlandPattern = new(@"^\+358[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex PolandPattern = new(@"^\+48[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex PortugalPattern = new(@"^\+351[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex GreecePattern = new(@"^\+30[1-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex HungaryPattern = new(@"^\+36[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex CzechPattern = new(@"^\+420[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex AustriaPattern = new(@"^\+43[1-9]\d{10}$|^0[1-9]\d{10}$");
        private static readonly Regex SwitzerlandPattern = new(@"^\+41[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex IrelandPattern = new(@"^\+353[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex RomaniaPattern = new(@"^\+40[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex BulgariaPattern = new(@"^\+359[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex CroatiaPattern = new(@"^\+385[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex SerbiaPattern = new(@"^\+381[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex SloveniaPattern = new(@"^\+386[1-9]\d{7}$|^0[1-9]\d{7}$");
        private static readonly Regex SlovakiaPattern = new(@"^\+421[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex EstoniaPattern = new(@"^\+372[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex LatviaPattern = new(@"^\+371[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex LithuaniaPattern = new(@"^\+370[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex LuxembourgPattern = new(@"^\+352[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex MaltaPattern = new(@"^\+356[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex IcelandPattern = new(@"^\+354[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex CyprusPattern = new(@"^\+357[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex AlbaniaPattern = new(@"^\+355[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex BosniaPattern = new(@"^\+387[1-9]\d{7}$|^0[1-9]\d{7}$");
        private static readonly Regex MontenegroPattern = new(@"^\+382[1-9]\d{7}$|^0[1-9]\d{7}$");
        private static readonly Regex MacedoniaPattern = new(@"^\+389[1-9]\d{7}$|^0[1-9]\d{7}$");
        private static readonly Regex MoldovaPattern = new(@"^\+373[1-9]\d{7}$|^0[1-9]\d{7}$");
        private static readonly Regex UkrainePattern = new(@"^\+380[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex BelarusPattern = new(@"^\+375[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex GeorgiaPattern = new(@"^\+995[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex ArmeniaPattern = new(@"^\+374[1-9]\d{7}$|^0[1-9]\d{7}$");
        private static readonly Regex AzerbaijanPattern = new(@"^\+994[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex KazakhstanPattern = new(@"^\+7[1-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex AndorraPattern = new(@"^\+376[1-9]\d{5}$|^[1-9]\d{5}$");
        private static readonly Regex LiechtensteinPattern = new(@"^\+423[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex MonacoPattern = new(@"^\+377[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex SanMarinoPattern = new(@"^\+378[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex VaticanPattern = new(@"^\+379[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex KosovoPattern = new(@"^\+383[1-9]\d{7}$|^0[1-9]\d{7}$");

        // Asia
        private static readonly Regex ChinaPattern = new(@"^\+86[1-9]\d{9}$|^1[1-9]\d{9}$");
        private static readonly Regex JapanPattern = new(@"^\+81[1-9]\d{8,9}$|^0[1-9]\d{8,9}$");
        private static readonly Regex IndiaPattern = new(@"^\+91[1-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex KoreaPattern = new(@"^\+82[1-9]\d{8,9}$|^0[1-9]\d{8,9}$");
        private static readonly Regex SingaporePattern = new(@"^\+65[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex MalaysiaPattern = new(@"^\+60[1-9]\d{8,9}$|^0[1-9]\d{8,9}$");
        private static readonly Regex ThailandPattern = new(@"^\+66[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex VietnamPattern = new(@"^\+84[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex IndonesiaPattern = new(@"^\+62[1-9]\d{8,11}$|^0[1-9]\d{8,11}$");
        private static readonly Regex PhilippinesPattern = new(@"^\+63[1-9]\d{9}$|^0[1-9]\d{9}$");
        private static readonly Regex TaiwanPattern = new(@"^\+886[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex HongKongPattern = new(@"^\+852[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex MacauPattern = new(@"^\+853[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex PakistanPattern = new(@"^\+92[1-9]\d{9}$|^0[1-9]\d{9}$");
        private static readonly Regex BangladeshPattern = new(@"^\+880[1-9]\d{9}$|^0[1-9]\d{9}$");
        private static readonly Regex SriLankaPattern = new(@"^\+94[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex NepalPattern = new(@"^\+977[1-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex BhutanPattern = new(@"^\+975[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex MaldivesPattern = new(@"^\+960[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex BruneiPattern = new(@"^\+673[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex CambodiaPattern = new(@"^\+855[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex LaosPattern = new(@"^\+856[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex MyanmarPattern = new(@"^\+95[1-9]\d{9}$|^0[1-9]\d{9}$");
        private static readonly Regex MongoliaPattern = new(@"^\+976[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex NorthKoreaPattern = new(@"^\+850[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex TimorLestePattern = new(@"^\+670[1-9]\d{7}$|^[1-9]\d{7}$");

        // Africa
        private static readonly Regex SouthAfricaPattern = new(@"^\+27[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex EgyptPattern = new(@"^\+20[1-9]\d{9}$|^01[1-9]\d{8}$");
        private static readonly Regex NigeriaPattern = new(@"^\+234[1-9]\d{9}$|^0[1-9]\d{9}$");
        private static readonly Regex KenyaPattern = new(@"^\+254[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex MoroccoPattern = new(@"^\+212[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex GhanaPattern = new(@"^\+233[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex EthiopiaPattern = new(@"^\+251[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex TanzaniaPattern = new(@"^\+255[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex UgandaPattern = new(@"^\+256[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex AlgeriaPattern = new(@"^\+213[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex TunisiaPattern = new(@"^\+216[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex SenegalPattern = new(@"^\+221[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex CameroonPattern = new(@"^\+237[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex IvoryCoastPattern = new(@"^\+225[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex AngolaPattern = new(@"^\+244[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex SudanPattern = new(@"^\+249[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex LibyaPattern = new(@"^\+218[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex SomaliaPattern = new(@"^\+252[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex DjiboutiPattern = new(@"^\+253[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex EritreaPattern = new(@"^\+291[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex SouthSudanPattern = new(@"^\+211[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex ChadPattern = new(@"^\+235[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex NigerPattern = new(@"^\+227[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex MaliPattern = new(@"^\+223[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex BurkinaFasoPattern = new(@"^\+226[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex MauritaniaPattern = new(@"^\+222[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex CapeVerdePattern = new(@"^\+238[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex GuineaBissauPattern = new(@"^\+245[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex GuineaPattern = new(@"^\+224[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex SierraLeonePattern = new(@"^\+232[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex LiberiaPattern = new(@"^\+231[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex GambiaPattern = new(@"^\+220[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex BeninPattern = new(@"^\+229[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex TogoPattern = new(@"^\+228[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex CentralAfricanPattern = new(@"^\+236[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex CongoPattern = new(@"^\+242[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex GabonPattern = new(@"^\+241[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex EquatorialGuineaPattern = new(@"^\+240[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex SaoTomePattern = new(@"^\+239[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex ComorosPattern = new(@"^\+269[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex SeychellesPattern = new(@"^\+248[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex MauritiusPattern = new(@"^\+230[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex MadagascarPattern = new(@"^\+261[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex MalawiPattern = new(@"^\+265[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex ZambiaPattern = new(@"^\+260[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex ZimbabwePattern = new(@"^\+263[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex MozambiquePattern = new(@"^\+258[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex EswatiniPattern = new(@"^\+268[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex LesothoPattern = new(@"^\+266[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex BotswanaPattern = new(@"^\+267[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex NamibiaPattern = new(@"^\+264[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex BurundiPattern = new(@"^\+257[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex RwandaPattern = new(@"^\+250[1-9]\d{8}$|^[1-9]\d{8}$");

        // Oceania
        private static readonly Regex AustraliaPattern = new(@"^\+61[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex NewZealandPattern = new(@"^\+64[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex FijiPattern = new(@"^\+679[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex PapuaNewGuineaPattern = new(@"^\+675[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex SamoaPattern = new(@"^\+685[1-9]\d{5}$|^[1-9]\d{5}$");
        private static readonly Regex TongaPattern = new(@"^\+676[1-9]\d{5}$|^[1-9]\d{5}$");
        private static readonly Regex VanuatuPattern = new(@"^\+678[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex SolomonPattern = new(@"^\+677[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex KiribatiPattern = new(@"^\+686[1-9]\d{5}$|^[1-9]\d{5}$");
        private static readonly Regex TuvaluPattern = new(@"^\+688[1-9]\d{5}$|^[1-9]\d{5}$");
        private static readonly Regex NauruPattern = new(@"^\+674[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex PalauPattern = new(@"^\+680[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex MicronesiaPattern = new(@"^\+691[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex MarshallPattern = new(@"^\+692[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex GuamPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex NorthernMarianaPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex AmericanSamoaPattern = new(@"^\+1[2-9]\d{9}$|^[1-9]\d{9}$");
        private static readonly Regex CookIslandsPattern = new(@"^\+682[1-9]\d{5}$|^[1-9]\d{5}$");
        private static readonly Regex NiuePattern = new(@"^\+683[1-9]\d{4}$|^[1-9]\d{4}$");
        private static readonly Regex TokelauPattern = new(@"^\+690[1-9]\d{4}$|^[1-9]\d{4}$");
        private static readonly Regex WallisFutunaPattern = new(@"^\+681[1-9]\d{5}$|^[1-9]\d{5}$");
        private static readonly Regex FrenchPolynesiaPattern = new(@"^\+689[1-9]\d{5}$|^[1-9]\d{5}$");
        private static readonly Regex NewCaledoniaPattern = new(@"^\+687[1-9]\d{5}$|^[1-9]\d{5}$");
        private static readonly Regex PitcairnPattern = new(@"^\+64[1-9]\d{8}$|^[1-9]\d{8}$");

        // Middle East
        private static readonly Regex SaudiArabiaPattern = new(@"^\+966[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex UaePattern = new(@"^\+971[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex IsraelPattern = new(@"^\+972[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex QatarPattern = new(@"^\+974[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex KuwaitPattern = new(@"^\+965[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex BahrainPattern = new(@"^\+973[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex OmanPattern = new(@"^\+968[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex JordanPattern = new(@"^\+962[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex LebanonPattern = new(@"^\+961[1-9]\d{7}$|^0[1-9]\d{7}$");
        private static readonly Regex IranPattern = new(@"^\+98[1-9]\d{9}$|^0[1-9]\d{9}$");
        private static readonly Regex IraqPattern = new(@"^\+964[1-9]\d{9}$|^0[1-9]\d{9}$");
        private static readonly Regex SyriaPattern = new(@"^\+963[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex YemenPattern = new(@"^\+967[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex AfghanistanPattern = new(@"^\+93[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex TurkmenistanPattern = new(@"^\+993[1-9]\d{7}$|^[1-9]\d{7}$");
        private static readonly Regex UzbekistanPattern = new(@"^\+998[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex KyrgyzstanPattern = new(@"^\+996[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex TajikistanPattern = new(@"^\+992[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex TurkeyPattern = new(@"^\+90[1-9]\d{9}$|^0[1-9]\d{9}$");

        // Atlantic Islands
        private static readonly Regex FalklandPattern = new(@"^\+500[1-9]\d{4}$|^[1-9]\d{4}$");
        private static readonly Regex SouthGeorgiaPattern = new(@"^\+500[1-9]\d{4}$|^[1-9]\d{4}$");
        private static readonly Regex StHelenaPattern = new(@"^\+290[1-9]\d{4}$|^[1-9]\d{4}$");
        private static readonly Regex AscensionPattern = new(@"^\+247[1-9]\d{3}$|^[1-9]\d{3}$");
        private static readonly Regex TristanPattern = new(@"^\+290[1-9]\d{4}$|^[1-9]\d{4}$");

        // Indian Ocean
        private static readonly Regex ReunionPattern = new(@"^\+262[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex MayottePattern = new(@"^\+262[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex BritishIndianPattern = new(@"^\+246[1-9]\d{6}$|^[1-9]\d{6}$");
        private static readonly Regex ChristmasPattern = new(@"^\+61[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex CocosPattern = new(@"^\+61[1-9]\d{8}$|^[1-9]\d{8}$");
        private static readonly Regex FrenchSouthernPattern = new(@"^\+262[1-9]\d{8}$|^0[1-9]\d{8}$");

        // Special Administrative Regions
        private static readonly Regex PalestinePattern = new(@"^\+970[1-9]\d{8}$|^0[1-9]\d{8}$");
        private static readonly Regex WesternSaharaPattern = new(@"^\+212[1-9]\d{8}$|^0[1-9]\d{8}$");

        // Generic patterns for other countries
        private static readonly Regex InternationalPattern = new(@"^\+[1-9]\d{1,14}$");
        private static readonly Regex EuPattern = new(@"^\+[3-9]\d{8,14}$|^0[1-9]\d{8,14}$");

        public static ValidationRule Required(string key, string? errorMessage = null)
        {
            return new ValidationRule(
                key,
                value => !string.IsNullOrEmpty(value),
                "Required",
                errorMessage ?? $"Configuration key '{key}' is required"
            );
        }

        public static ValidationRule MinLength(string key, int minLength, string? errorMessage = null)
        {
            return new ValidationRule(
                key,
                value => value?.Length >= minLength,
                "MinLength",
                errorMessage ?? $"Value for key '{key}' must be at least {minLength} characters long"
            );
        }

        public static ValidationRule Email(string key, string? errorMessage = null)
        {
            return new ValidationRule(
                key,
                value => System.Text.RegularExpressions.Regex.IsMatch(value ?? "", @"^[^@\s]+@[^@\s]+\.[^@\s]+$"),
                "Email",
                errorMessage ?? $"Value for key '{key}' must be a valid email address"
            );
        }

        public static ValidationRule Range(string key, int min, int max, string? errorMessage = null)
        {
            return new ValidationRule(
                key,
                value => int.TryParse(value, out int num) && num >= min && num <= max,
                "Range",
                errorMessage ?? $"Value for key '{key}' must be between {min} and {max}"
            );
        }

        public static ValidationRule Boolean(string key, string? errorMessage = null)
        {
            return new ValidationRule(
                key,
                value => bool.TryParse(value, out _),
                "Boolean",
                errorMessage ?? $"Value for key '{key}' must be a valid boolean value"
            );
        }

        public static ValidationRule PhoneNumber(string key, string? region = null, string? errorMessage = null)
        {
            return new ValidationRule(
                key,
                value => IsValidPhoneNumber(value, region ?? string.Empty),
                "PhoneNumber",
                errorMessage ?? $"Value for key '{key}' must be a valid phone number"
            );
        }

        private static bool IsValidPhoneNumber(string value, string region)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            // Remove all non-digit characters except '+' for international format
            var cleanNumber = new string(value.Where(c => char.IsDigit(c) || c == '+').ToArray());

            return region?.ToUpper() switch
            {
                // North America
                "US" => UsPattern.IsMatch(cleanNumber),
                "CA" => CanadaPattern.IsMatch(cleanNumber),
                "MX" => MexicoPattern.IsMatch(cleanNumber),
                "CU" => CubaPattern.IsMatch(cleanNumber),
                "DO" => DominicanPattern.IsMatch(cleanNumber),
                "JM" => JamaicaPattern.IsMatch(cleanNumber),

                // Europe
                "GB" => UkPattern.IsMatch(cleanNumber),
                "UK" => UkPattern.IsMatch(cleanNumber),
                "DE" => GermanyPattern.IsMatch(cleanNumber),
                "FR" => FrancePattern.IsMatch(cleanNumber),
                "IT" => ItalyPattern.IsMatch(cleanNumber),
                "ES" => SpainPattern.IsMatch(cleanNumber),
                "RU" => RussiaPattern.IsMatch(cleanNumber),
                "NL" => NetherlandsPattern.IsMatch(cleanNumber),
                "BE" => BelgiumPattern.IsMatch(cleanNumber),
                "SE" => SwedenPattern.IsMatch(cleanNumber),
                "NO" => NorwayPattern.IsMatch(cleanNumber),
                "DK" => DenmarkPattern.IsMatch(cleanNumber),
                "FI" => FinlandPattern.IsMatch(cleanNumber),
                "PL" => PolandPattern.IsMatch(cleanNumber),
                "PT" => PortugalPattern.IsMatch(cleanNumber),
                "GR" => GreecePattern.IsMatch(cleanNumber),
                "HU" => HungaryPattern.IsMatch(cleanNumber),
                "CZ" => CzechPattern.IsMatch(cleanNumber),
                "AT" => AustriaPattern.IsMatch(cleanNumber),
                "CH" => SwitzerlandPattern.IsMatch(cleanNumber),
                "IE" => IrelandPattern.IsMatch(cleanNumber),

                // Asia
                "CN" => ChinaPattern.IsMatch(cleanNumber),
                "JP" => JapanPattern.IsMatch(cleanNumber),
                "IN" => IndiaPattern.IsMatch(cleanNumber),
                "KR" => KoreaPattern.IsMatch(cleanNumber),
                "SG" => SingaporePattern.IsMatch(cleanNumber),
                "MY" => MalaysiaPattern.IsMatch(cleanNumber),
                "TH" => ThailandPattern.IsMatch(cleanNumber),
                "VN" => VietnamPattern.IsMatch(cleanNumber),
                "ID" => IndonesiaPattern.IsMatch(cleanNumber),
                "PH" => PhilippinesPattern.IsMatch(cleanNumber),
                "TW" => TaiwanPattern.IsMatch(cleanNumber),
                "HK" => HongKongPattern.IsMatch(cleanNumber),
                "PK" => PakistanPattern.IsMatch(cleanNumber),
                "BD" => BangladeshPattern.IsMatch(cleanNumber),
                "LK" => SriLankaPattern.IsMatch(cleanNumber),

                // South America
                "BR" => BrazilPattern.IsMatch(cleanNumber),
                "AR" => ArgentinaPattern.IsMatch(cleanNumber),
                "CO" => ColombiaPattern.IsMatch(cleanNumber),
                "CL" => ChilePattern.IsMatch(cleanNumber),
                "PE" => PeruPattern.IsMatch(cleanNumber),
                "VE" => VenezuelaPattern.IsMatch(cleanNumber),
                "EC" => EcuadorPattern.IsMatch(cleanNumber),
                "BO" => BoliviaPattern.IsMatch(cleanNumber),
                "PY" => ParaguayPattern.IsMatch(cleanNumber),
                "UY" => UruguayPattern.IsMatch(cleanNumber),

                // Africa
                "ZA" => SouthAfricaPattern.IsMatch(cleanNumber),
                "EG" => EgyptPattern.IsMatch(cleanNumber),
                "NG" => NigeriaPattern.IsMatch(cleanNumber),
                "KE" => KenyaPattern.IsMatch(cleanNumber),
                "MA" => MoroccoPattern.IsMatch(cleanNumber),
                "GH" => GhanaPattern.IsMatch(cleanNumber),
                "ET" => EthiopiaPattern.IsMatch(cleanNumber),
                "TZ" => TanzaniaPattern.IsMatch(cleanNumber),
                "UG" => UgandaPattern.IsMatch(cleanNumber),
                "DZ" => AlgeriaPattern.IsMatch(cleanNumber),
                "TN" => TunisiaPattern.IsMatch(cleanNumber),
                "SN" => SenegalPattern.IsMatch(cleanNumber),
                "CM" => CameroonPattern.IsMatch(cleanNumber),
                "CI" => IvoryCoastPattern.IsMatch(cleanNumber),
                "AO" => AngolaPattern.IsMatch(cleanNumber),

                // Oceania
                "AU" => AustraliaPattern.IsMatch(cleanNumber),
                "NZ" => NewZealandPattern.IsMatch(cleanNumber),
                "FJ" => FijiPattern.IsMatch(cleanNumber),
                "PG" => PapuaNewGuineaPattern.IsMatch(cleanNumber),
                "WS" => SamoaPattern.IsMatch(cleanNumber),
                "TO" => TongaPattern.IsMatch(cleanNumber),

                // Middle East
                "SA" => SaudiArabiaPattern.IsMatch(cleanNumber),
                "AE" => UaePattern.IsMatch(cleanNumber),
                "IL" => IsraelPattern.IsMatch(cleanNumber),
                "QA" => QatarPattern.IsMatch(cleanNumber),
                "KW" => KuwaitPattern.IsMatch(cleanNumber),
                "BH" => BahrainPattern.IsMatch(cleanNumber),
                "OM" => OmanPattern.IsMatch(cleanNumber),
                "JO" => JordanPattern.IsMatch(cleanNumber),
                "LB" => LebanonPattern.IsMatch(cleanNumber),
                "IR" => IranPattern.IsMatch(cleanNumber),
                "IQ" => IraqPattern.IsMatch(cleanNumber),
                "SY" => SyriaPattern.IsMatch(cleanNumber),
                "YE" => YemenPattern.IsMatch(cleanNumber),
                "AF" => AfghanistanPattern.IsMatch(cleanNumber),
                "TM" => TurkmenistanPattern.IsMatch(cleanNumber),
                "UZ" => UzbekistanPattern.IsMatch(cleanNumber),
                "KG" => KyrgyzstanPattern.IsMatch(cleanNumber),
                "TJ" => TajikistanPattern.IsMatch(cleanNumber),
                "TR" => TurkeyPattern.IsMatch(cleanNumber),
                "TUR" => TurkeyPattern.IsMatch(cleanNumber),

                // Caribbean
                "AG" => AntiguaPattern.IsMatch(cleanNumber),
                "DM" => DominicaPattern.IsMatch(cleanNumber),
                "GD" => GrenadaPattern.IsMatch(cleanNumber),
                "KN" => StKittsPattern.IsMatch(cleanNumber),
                "LC" => StLuciaPattern.IsMatch(cleanNumber),
                "VC" => StVincentPattern.IsMatch(cleanNumber),
                "AW" => ArubaPattern.IsMatch(cleanNumber),
                "CW" => CuracaoPattern.IsMatch(cleanNumber),
                "SX" => SintMaartenPattern.IsMatch(cleanNumber),
                "KY" => CaymanPattern.IsMatch(cleanNumber),
                "BM" => BermudaPattern.IsMatch(cleanNumber),
                "TC" => TurksPattern.IsMatch(cleanNumber),
                "VG" => VirginIslandsPattern.IsMatch(cleanNumber),
                "VI" => VirginIslandsPattern.IsMatch(cleanNumber),
                "PR" => PuertoRicoPattern.IsMatch(cleanNumber),
                "GP" => FrenchGuianaPattern.IsMatch(cleanNumber),

                // Pacific Islands
                "GU" => GuamPattern.IsMatch(cleanNumber),
                "MP" => NorthernMarianaPattern.IsMatch(cleanNumber),
                "AS" => AmericanSamoaPattern.IsMatch(cleanNumber),
                "CK" => CookIslandsPattern.IsMatch(cleanNumber),
                "NU" => NiuePattern.IsMatch(cleanNumber),
                "TK" => TokelauPattern.IsMatch(cleanNumber),
                "WF" => WallisFutunaPattern.IsMatch(cleanNumber),
                "PF" => FrenchPolynesiaPattern.IsMatch(cleanNumber),
                "NC" => NewCaledoniaPattern.IsMatch(cleanNumber),
                "PN" => PitcairnPattern.IsMatch(cleanNumber),

                // Atlantic Islands
                "FK" => FalklandPattern.IsMatch(cleanNumber),
                "GS" => SouthGeorgiaPattern.IsMatch(cleanNumber),
                "SH" => StHelenaPattern.IsMatch(cleanNumber),
                "AC" => AscensionPattern.IsMatch(cleanNumber),
                "TA" => TristanPattern.IsMatch(cleanNumber),

                // Indian Ocean
                "RE" => ReunionPattern.IsMatch(cleanNumber),
                "YT" => MayottePattern.IsMatch(cleanNumber),
                "IO" => BritishIndianPattern.IsMatch(cleanNumber),
                "CX" => ChristmasPattern.IsMatch(cleanNumber),
                "CC" => CocosPattern.IsMatch(cleanNumber),
                "TF" => FrenchSouthernPattern.IsMatch(cleanNumber),

                // Generic patterns
                "EU" => EuPattern.IsMatch(cleanNumber),

                // Central America
                "BZ" => BelizePattern.IsMatch(cleanNumber),
                "CR" => CostaRicaPattern.IsMatch(cleanNumber),
                "SV" => ElSalvadorPattern.IsMatch(cleanNumber),
                "GT" => GuatemalaPattern.IsMatch(cleanNumber),
                "HN" => HondurasPattern.IsMatch(cleanNumber),
                "NI" => NicaraguaPattern.IsMatch(cleanNumber),
                "PA" => PanamaPattern.IsMatch(cleanNumber),

                // South America (additional)
                "GY" => GuyanaPattern.IsMatch(cleanNumber),
                "SR" => SurinamePattern.IsMatch(cleanNumber),
                "GF" => FrenchGuianaPattern.IsMatch(cleanNumber),

                // Europe (additional)
                "AD" => AndorraPattern.IsMatch(cleanNumber),
                "LI" => LiechtensteinPattern.IsMatch(cleanNumber),
                "MC" => MonacoPattern.IsMatch(cleanNumber),
                "SM" => SanMarinoPattern.IsMatch(cleanNumber),
                "VA" => VaticanPattern.IsMatch(cleanNumber),

                // Asia (additional)
                "BT" => BhutanPattern.IsMatch(cleanNumber),
                "MV" => MaldivesPattern.IsMatch(cleanNumber),
                "BN" => BruneiPattern.IsMatch(cleanNumber),
                "KH" => CambodiaPattern.IsMatch(cleanNumber),
                "LA" => LaosPattern.IsMatch(cleanNumber),
                "MM" => MyanmarPattern.IsMatch(cleanNumber),
                "MN" => MongoliaPattern.IsMatch(cleanNumber),
                "KP" => NorthKoreaPattern.IsMatch(cleanNumber),
                "TL" => TimorLestePattern.IsMatch(cleanNumber),

                // Africa (additional)
                "BI" => BurundiPattern.IsMatch(cleanNumber),
                "KM" => ComorosPattern.IsMatch(cleanNumber),
                "DJ" => DjiboutiPattern.IsMatch(cleanNumber),
                "GQ" => EquatorialGuineaPattern.IsMatch(cleanNumber),
                "ER" => EritreaPattern.IsMatch(cleanNumber),
                "GA" => GabonPattern.IsMatch(cleanNumber),
                "GM" => GambiaPattern.IsMatch(cleanNumber),
                "GN" => GuineaPattern.IsMatch(cleanNumber),
                "GW" => GuineaBissauPattern.IsMatch(cleanNumber),
                "LS" => LesothoPattern.IsMatch(cleanNumber),
                "LR" => LiberiaPattern.IsMatch(cleanNumber),
                "MG" => MadagascarPattern.IsMatch(cleanNumber),
                "MW" => MalawiPattern.IsMatch(cleanNumber),
                "MR" => MauritaniaPattern.IsMatch(cleanNumber),
                "MU" => MauritiusPattern.IsMatch(cleanNumber),
                "MZ" => MozambiquePattern.IsMatch(cleanNumber),
                "NA" => NamibiaPattern.IsMatch(cleanNumber),
                "RW" => RwandaPattern.IsMatch(cleanNumber),
                "ST" => SaoTomePattern.IsMatch(cleanNumber),
                "SC" => SeychellesPattern.IsMatch(cleanNumber),
                "SL" => SierraLeonePattern.IsMatch(cleanNumber),
                "SO" => SomaliaPattern.IsMatch(cleanNumber),
                "SS" => SouthSudanPattern.IsMatch(cleanNumber),
                "SZ" => EswatiniPattern.IsMatch(cleanNumber),
                "TG" => TogoPattern.IsMatch(cleanNumber),
                "ZM" => ZambiaPattern.IsMatch(cleanNumber),
                "ZW" => ZimbabwePattern.IsMatch(cleanNumber),

                _ => InternationalPattern.IsMatch(cleanNumber)
            };
        }

        public static ValidationRule Custom(string key, Func<string, bool> validator, string validationType, string errorMessage)
        {
            return new ValidationRule(key, validator, validationType, errorMessage);
        }
    }
} 