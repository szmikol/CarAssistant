﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CarAssistant
{
    public class Model
    {
        public string WhichModel;
        
            
        public Model()
        {

        }

        public void WhichType(string Input)
        {
            
        }
                
        public enum Alfa_Romeo
            {
            [Description("0-9")] Alfa_Romeo_0_9,
            [Description("4C")] Alfa_Romeo_4C,
            [Description("6C")] Alfa_Romeo_6C,
            [Description("8C")] Alfa_Romeo_8C,
            [Description("8C Competizione")] Alfa_Romeo_8C_Competizione,
            [Description("12C")] Alfa_Romeo_12C,
            [Description("15/20 HP")] Alfa_Romeo_15_20_HP,
            [Description("12 HP")] Alfa_Romeo_12_HP,
            [Description("15 HP")] Alfa_Romeo_15_HP,
            [Description("20/30 HP")] Alfa_Romeo_20_30_HP,
            [Description("24 HP")] Alfa_Romeo_24_HP,
            [Description("33")] Alfa_Romeo_33,
            [Description("33 Stradale")] Alfa_Romeo_33_Stradale,
            [Description("40/60 HP")] Alfa_Romeo_40_60_HP,
            [Description("75")] Alfa_Romeo_75,
            [Description("90")] Alfa_Romeo_90,
            [Description("105/115 Series Coupés")] Alfa_Romeo_105_115_Series_Coupés,
            [Description("145")] Alfa_Romeo_145,
            [Description("146")] Alfa_Romeo_146,
            [Description("147")] Alfa_Romeo_147,
            [Description("155")] Alfa_Romeo_155,
            [Description("156")] Alfa_Romeo_156,
            [Description("159")] Alfa_Romeo_159,
            [Description("164")] Alfa_Romeo_164,
            [Description("166")] Alfa_Romeo_166,
            [Description("1750 Berlina")] Alfa_Romeo_1750_Berlina,
            [Description("1900")] Alfa_Romeo_1900,
            [Description("2000")] Alfa_Romeo_2000,
            [Description("2000 Berlina")] Alfa_Romeo_2000_Berlina,
            [Description("2000 GTV")] Alfa_Romeo_2000_GTV,
            [Description("2000 Spider Veloce")] Alfa_Romeo_2000_Spider_Veloce,
            [Description("2000 Sportiva")] Alfa_Romeo_2000_Sportiva,
            [Description("2300")] Alfa_Romeo_2300,
            [Description("2600")] Alfa_Romeo_2600,
            [Description("Alfa 6")] Alfa_Romeo_Alfa_6,
            [Description("Type 937")] Alfa_Romeo_Type_937,
            [Description("Alfasud")] Alfa_Romeo_Alfasud,
            [Description("Alfasud Sprint")] Alfa_Romeo_Alfasud_Sprint,
            [Description("Alfetta")] Alfa_Romeo_Alfetta,
            [Description("AR6")] Alfa_Romeo_AR6,
            [Description("AR8")] Alfa_Romeo_AR8,
            [Description("Arna")] Alfa_Romeo_Arna,
            [Description("Brera")] Alfa_Romeo_Brera,
            [Description("Dauphine")] Alfa_Romeo_Dauphine,
            [Description("G1")] Alfa_Romeo_G1,
            [Description("Giulia")] Alfa_Romeo_Giulia,
            [Description("Giulia (952)")] Alfa_Romeo_Giulia_952,
            [Description("Giulia TZ")] Alfa_Romeo_Giulia_TZ,
            [Description("Giulietta")] Alfa_Romeo_Giulietta,
            [Description("Giulietta (750/101)")] Alfa_Romeo_Giulietta_750_101,
            [Description("Giulietta (116)")] Alfa_Romeo_Giulietta_116,
            [Description("Giulietta (940)")] Alfa_Romeo_Giulietta_940,
            [Description("Giulietta Sprint Speciale")] Alfa_Romeo_Giulietta_Sprint_Speciale,
            [Description("Gran Sport Quuattroruote")] Alfa_Romeo_Gran_Sport_Quattroruote,
            [Description("GT")] Alfa_Romeo_GT,
            [Description("GT 1300 Junior")] Alfa_Romeo_GT_1300_Junior,
            [Description("GTA")] Alfa_Romeo_GTA,
            [Description("GTV 2.0")] Alfa_Romeo_GTV_20,
            [Description("GTV")] Alfa_Romeo_GTV,
            [Description("Matta")] Alfa_Romeo_Matta,
            [Description("MiTo")] Alfa_Romeo_MiTo,
            [Description("Montreal")] Alfa_Romeo_Montreal,
            [Description("Romeo RL")] Alfa_Romeo_Romeo_RL,
            [Description("RM")] Alfa_Romeo_RM,
            [Description("Romeo")] Alfa_Romeo_Romeo,
            [Description("Spider")] Alfa_Romeo_Spider,
            [Description("Sprint")] Alfa_Romeo_Sprint,
            [Description("Stelvio")] Alfa_Romeo_Stelvio,
            [Description("SZ")] Alfa_Romeo_SZ,
        };

        public enum Aston_Martin { };        
        public enum Audi { };
        public enum Bentley‎ { };
        public enum BMW‎ { };
        public enum Bugatti‎ { };
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
        public enum Gumpert { };
        public enum Jelcz‎ { };
        public enum Honda { };
        public enum Hummer‎ { };
        public enum Hyundai { };
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
        public enum Maserati { };
        public enum Mazda‎ { };
        public enum McLaren { };
        public enum Mercedes_Benz‎ { };
        public enum Mini‎ { };
        public enum Mitsubishi { };
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
        public enum Scania‎ { };
        public enum Seat { };
        public enum Škoda‎ { };
        public enum Smart‎ { };
        public enum Subaru‎ { };
        public enum Suzuki { };
        public enum Tesla‎ { };
        public enum Toyota‎ { };
        public enum Volkswagen‎ { };
        public enum Volvo { };
      
        
        //public enum Autosan { };
        //public enum Buick‎ { };
        //public enum AMC { };
        //public enum GAZ‎ { };
        //public enum Ikarus‎ { };
        //public enum Maybach‎ { };
        //public enum Moskwicz { };
        // public enum Neoplan { };
        //public enum Saturn { };
        //public enum Solaris‎ { };
        //public enum SsangYong { };
        //public enum Star‎ { };
        //public enum Tatra { };
        //public enum UAZ { };
        //public enum Vauxhall { };
        //public enum Zastava‎ { };
        //public enum ZiŁ‎ { };
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

