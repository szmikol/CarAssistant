using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssistant
{
    public class Brand
    {
        public enum Alfa_Romeo
        {   
            Alfa_Romeo_0_9,
            Alfa_Romeo_4C,
            Alfa_Romeo_6C,
            Alfa_Romeo_8C,
            Alfa_Romeo_8C_Competizione,
            Alfa_Romeo_12C,
            Alfa_Romeo_15_20_HP,
            Alfa_Romeo_12_HP,
            Alfa_Romeo_15_HP,
            Alfa_Romeo_20_30_HP,
            Alfa_Romeo_24_HP,
            Alfa_Romeo_33,
            Alfa_Romeo_33_Stradale,
            Alfa_Romeo_40_60_HP,
            Alfa_Romeo_75,
            Alfa_Romeo_90,
            Alfa_Romeo_105_115_Series_Coupés,
            Alfa_Romeo_145,
            Alfa_Romeo_146,
            Alfa_Romeo_147,
            Alfa_Romeo_155,
            Alfa_Romeo_156,
            Alfa_Romeo_159,
            Alfa_Romeo_164,
            Alfa_Romeo_166,
            Alfa_Romeo_1750_Berlina,
            Alfa_Romeo_1900,
            Alfa_Romeo_2000,
            Alfa_Romeo_2000_Berlina,
            Alfa_Romeo_2000_GTV,
            Alfa_Romeo_2000_Spider_Veloce,
            Alfa_Romeo_2000_Sportiva,
            Alfa_Romeo_2300,
            Alfa_Romeo_2600,
            Alfa_Romeo_6,
            Alfa_Romeo_Type_937,
            Alfa_Romeo_Alfasud,
            Alfa_Romeo_Alfasud_Sprint,
            Alfa_Romeo_Alfetta,
            Alfa_Romeo_AR6,
            Alfa_Romeo_AR8,
            Alfa_Romeo_Arna,
            Alfa_Romeo_Brera,
            Alfa_Romeo_Dauphine,
            Alfa_Romeo_G1,
            Alfa_Romeo_Giulia,
            Alfa_Romeo_Giulia_952,
            Alfa_Romeo_Giulia_TZ,
            Alfa_Romeo_Giulietta,
            Alfa_Romeo_Giulietta_750_101,
            Alfa_Romeo_Giulietta_116,
            Alfa_Romeo_Giulietta_940,
            Alfa_Romeo_Giulietta_Sprint_Speciale,
            Alfa_Romeo_Gran_Sport_Quattroruote,
            Alfa_Romeo_GT,
            Alfa_Romeo_GT_1300_Junior,
            Alfa_Romeo_GTA,
            Alfa_Romeo_GTV_20,
            Alfa_Romeo_GTV,
            Alfa_Romeo_Matta,
            Alfa_Romeo_MiTo,
            Alfa_Romeo_Montreal,
            Alfa_Romeo_Romeo_RL,
            Alfa_Romeo_RM,
            Alfa_Romeo_Romeo,
            Alfa_Romeo_Spider,
            Alfa_Romeo_Sprint,
            Alfa_Romeo_Stelvio,
            Alfa_Romeo_SZ,
        };
        public enum AMC { };
        public enum Aston_Martin { };
        public enum Audi { };
        public enum Autosan { };
        public enum Bentley‎ { };
        public enum BMW‎ { };
        public enum Bugatti‎ { };
        public enum Buick‎ { };
        public enum Cadillac‎ { };
        public enum Chevrolet‎ { };
        public enum Chrysler‎ { };
        public enum Citroën‎ { };
        public enum Dacia‎ { };
        public enum Daewoo‎ { };
        public enum Dodge‎ { };
        public enum Ferrari‎ { };
        public enum Fiat‎ { };
        public enum Ford‎ { };
        public enum FSO‎ { };
        public enum GAZ‎ { };
        public enum Gumpert { };
        public enum Jelcz‎ { };
        public enum Honda { };
        public enum Hummer‎ { };
        public enum Hyundai { };
        public enum Ikarus‎ { };
        public enum Infiniti { };
        public enum Isuzu‎ { };
        public enum Iveco‎ { };
        public enum Jaguar { };
        public enum Jeep‎ { };
        public enum Kia‎ { };
        public enum Koenigsegg‎ { };
        public enum Lamborghini‎ { };
        public enum Lancia‎ { };
        public enum Land_Rover‎ { };
        public enum Lexus‎ { };
        public enum Lincoln‎ { };
        public enum Lotus { };
        public enum Łada { };
        public enum MAN { };
        public enum Maseratii { };
        public enum Maybach‎ { };
        public enum Mazda‎ { };
        public enum McLaren { };
        public enum Mercedes_Benz‎ { };
        public enum Mini‎ { };
        public enum Mitsubishi { };
        public enum Moskwicz { };
        public enum Neoplan { };
        public enum Nissan { };
        public enum Opel‎ { };
        public enum Pagani‎ { };
        public enum Peugeot‎ { };
        public enum Porsche‎ { };
        public enum Reliant‎ { };
        public enum Renault‎ { };
        public enum Rolls_Royce { };
        public enum Rover‎ { };
        public enum Saab‎ { };
        public enum Saturn { };
        public enum Scania‎ { };
        public enum SEAT { };
        public enum Škoda‎ { };
        public enum Smart‎ { };
        public enum Solaris‎ { };
        public enum SsangYong { };
        public enum Star‎ { };
        public enum Subaru‎ { };
        public enum Suzuki { };
        public enum Tatra { };
        public enum Tesla‎ { };
        public enum Toyota‎ { };
        public enum UAZ { };
        public enum Vauxhall { };
        public enum Volkswagen‎ { };
        public enum Volvo { };
        public enum Zastava‎ { };
        public enum ZiŁ‎ { };
        //Abarth,
        //AC,
        // Acura,
        //AEC‎,
        //Allard‎,
        // Alvis‎, 
        //Amherst‎,
        //   ARO,
        //  Ascari,
        //Austin‎,
        //Auto_Union,
        //Autobianchi,
        //  Avia‎,
        //Bedford‎, 
        //   Benz‎, 
        //Brilliance‎,
        //Bristol‎,
        //British_Motor_Corporation‎,
        // Brockway‎,
        //Büssing‎,
        //BYD‎,
        //Castrosua‎,
        //Caterham‎,
        //Chery‎,
        //Contrac‎,
        //Csepel‎,
        //   DAF‎,
        // Daihatsu‎, 
        //  Daimler‎,
        //   Dallara‎,
        // Darracq‎,
        // De_Tomaso‎,
        //DeSoto,
        //  DKW‎,
        //     DS‎,
        //    Eagle‎,
        //Edsel‎,
        //  Estonia‎,
        //     FAW‎,
        //    GMC‎,
        //  Hillman‎,
        //  Hino‎,
        // Hispano_Suiza‎,
        //    Holden‎, 
        //     HSV‎,
        //     Hudson‎,
        //  IFA,
        //  Innocenti‎,
        //   Intrall‎,
        //  Iran_Khodro‎,
        //   Isdera‎, 
        //   IŻ‎,
        //  Jensen‎,
        //   KrAZ,
        //   Lagonda‎,
        //    Lanchester,
        //    Laraki‎,
        //   Laurin_Klement‎,       
        //    Leyland,
        //     Liebherr,
        //     Ligier‎,
        //    Maruti‎,
        //     Matra,
        //       Melkus‎,
        //   Mercury‎,
        //      MG‎,
        //    Monteverdi,
        //    Moretti‎,
        //    Morgan‎,
        //     Morris,
        //   Noble,
        //  NSU‎,
        //   Oldsmobile‎,
        // Peel‎,
        //  Pierce_Arrow‎,
        //   Packard‎,
        //  Panhard‎,
        //  Panoz‎,
        //   Pegaso‎,
        //   Plymouth‎,
        //   Pontiac,
        //   Proton‎,
        //  Puma,
        //    PZInż,
        //     RAF‎,
        //     Rambler,
        //   Riley,
        //     Roewe,
        //      Ruf‎,
        //    Sisu,
        //  Saleen‎,
        //SAMIL‎,
        //   Gibbs,
        //   LDV‎,
        //  Stanley,
        //   Scion,
        //      Shelby‎,
        //     Simca‎,
        //     Singer‎,
        //      Spyker‎,
        //    Steyr,
        //      Stutz‎,
        //      Talbot,
        //     Tata_Motors‎,
        //      Tofaş‎,
        //     Triumph‎,
        //     TVR,
        //    Ural,
        //     Vector‎,
        //    Veritas,
        //   WaterCar‎,
        // Wiesmann‎,
        // Wolseley,
        //ZAZ‎,
    }
}
