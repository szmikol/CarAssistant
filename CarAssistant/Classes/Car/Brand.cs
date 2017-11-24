﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;



namespace CarAssistant
{
    public enum Brand
    {
        [Description("Alfa Romeo")] Alfa_Romeo,
        [Description("Aston Martin")] Aston_Martin,
        [Description("Audi")] Audi,
        [Description("Bentley")] Bentley,
        [Description("BMW")] BMW‎,
        [Description("Bugatti")] Bugatti,
        [Description("Cadillac")] Cadillac‎,
        [Description("Chevrolet")] Chevrolet‎,
        [Description("Chrysler")] Chrysler‎,
        [Description("Citroen")] Citroën‎,
        [Description("Dacia")] Dacia‎,
        [Description("Daewoo")] Daewoo‎,
        [Description("Dodge")] Dodge‎,
        [Description("Ferrari")] Ferrari‎,
        [Description("Fiat")] Fiat‎,
        [Description("Ford")] Ford‎,
        [Description("FSO")] FSO‎,
        [Description("Gumpert")] Gumpert,
        [Description("Jelcz")] Jelcz‎,
        [Description("Honda")] Honda,
        [Description("Hummer")] Hummer‎,
        [Description("Hyundai")] Hyundai,
        [Description("Infiniti")] Infiniti,
        [Description("Isuzu")] Isuzu‎,
        [Description("Iveco")] Iveco‎,
        [Description("Jaguar")] Jaguar,
        [Description("Jeep")] Jeep,
        [Description("Kia")] Kia‎,
        [Description("Koenigsegg")] Koenigsegg‎,
        [Description("Lamborghini")] Lamborghini‎,
        [Description("Lancia")] Lancia‎,
        [Description("Land Rover")] Land_Rover‎,
        [Description("Lexus")] Lexus‎,
        [Description("Lincoln")] Lincoln‎,
        [Description("Lotus")] Lotus,
        [Description("Łada")] Łada,
        [Description("MAN")] MAN,
        [Description("Maserati")] Maserati,
        [Description("Mazda")] Mazda‎,
        [Description("McLaren")] McLaren,
        [Description("Mercedes-Benz")] Mercedes_Benz‎,
        [Description("Mini")] Mini‎,
        [Description("Mitsubishi")] Mitsubishi,
        [Description("Nissan")] Nissan,
        [Description("Opel")] Opel‎,
        [Description("Pagani")] Pagani,
        [Description("Peugot")] Peugeot‎,
        [Description("Porsche")] Porsche‎,
        [Description("Reliant")] Reliant,
        [Description("Renault")] Renault,
        [Description("Rolls Royce")] Rolls_Royce,
        [Description("Rover")] Rover‎,
        [Description("Saab")] Saab,
        [Description("Scania")] Scania,
        [Description("Seat")] Seat,
        [Description("Škoda")] Škoda‎,
        [Description("Smart")] Smart,      
        [Description("Subaru")] Subaru,
        [Description("Suzuki")] Suzuki,        
        [Description("Tesla")] Tesla,
        [Description("Toyota")] Toyota‎,       
        [Description("Volkswagen")] Volkswagen,
        [Description("Volvo")] Volvo,


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
