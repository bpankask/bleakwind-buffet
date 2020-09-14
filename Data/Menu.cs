using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class to represent the menu of bleakwind buffet
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets available entrees
        /// </summary>
        /// <returns>IEnumberable of available entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());

            return entrees;
        }

        /// <summary>
        /// Gets available sides in each size
        /// </summary>
        /// <returns>IEnumerable of available sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = Enums.Size.Small;
            DragonbornWaffleFries df2 = new DragonbornWaffleFries();
            df2.Size = Enums.Size.Medium;
            DragonbornWaffleFries df3 = new DragonbornWaffleFries();
            df3.Size = Enums.Size.Large;

            FriedMiraak fm = new FriedMiraak();
            fm.Size = Enums.Size.Small;
            FriedMiraak fm2 = new FriedMiraak();
            fm2.Size = Enums.Size.Medium;
            FriedMiraak fm3 = new FriedMiraak();
            fm3.Size = Enums.Size.Large;

            MadOtarGrits mg = new MadOtarGrits();
            mg.Size = Enums.Size.Small;
            MadOtarGrits mg2 = new MadOtarGrits();
            mg2.Size = Enums.Size.Medium;
            MadOtarGrits mg3 = new MadOtarGrits();
            mg3.Size = Enums.Size.Large;

            VokunSalad vs = new VokunSalad();
            vs.Size = Enums.Size.Small;
            VokunSalad vs2 = new VokunSalad();
            vs2.Size = Enums.Size.Medium;
            VokunSalad vs3 = new VokunSalad();
            vs3.Size = Enums.Size.Large;

            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(df);
            sides.Add(df2);
            sides.Add(df3);

            sides.Add(fm);
            sides.Add(fm2);
            sides.Add(fm3);

            sides.Add(mg);
            sides.Add(mg2);
            sides.Add(mg3);

            sides.Add(vs);
            sides.Add(vs2);
            sides.Add(vs3);

            return sides;
        }

        /// <summary>
        /// Gets available drinks in each size
        /// </summary>
        /// <returns>IEnumberable of available drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Size = Enums.Size.Small;
            AretinoAppleJuice aj2 = new AretinoAppleJuice();
            aj2.Size = Enums.Size.Medium;
            AretinoAppleJuice aj3 = new AretinoAppleJuice();
            aj3.Size = Enums.Size.Large;

            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Enums.Size.Small;
            CandlehearthCoffee cc2 = new CandlehearthCoffee();
            cc2.Size = Enums.Size.Medium;
            CandlehearthCoffee cc3 = new CandlehearthCoffee();
            cc3.Size = Enums.Size.Large;

            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = Enums.Size.Small;
            MarkarthMilk mm2 = new MarkarthMilk();
            mm2.Size = Enums.Size.Medium;
            MarkarthMilk mm3 = new MarkarthMilk();
            mm3.Size = Enums.Size.Large;

            //Three instantiations per flavor
            SailorSoda ssBberry = new SailorSoda();
            ssBberry.Size = Enums.Size.Small;
            ssBberry.Flavor = Enums.SodaFlavor.Blackberry;
            SailorSoda ss2Bberry = new SailorSoda();
            ss2Bberry.Size = Enums.Size.Medium;
            ss2Bberry.Flavor = Enums.SodaFlavor.Blackberry;
            SailorSoda ss3Bberry = new SailorSoda();
            ss3Bberry.Size = Enums.Size.Large;
            ss3Bberry.Flavor = Enums.SodaFlavor.Blackberry;

            SailorSoda ssCherry = new SailorSoda();
            ssCherry.Size = Enums.Size.Small;
            ssCherry.Flavor = Enums.SodaFlavor.Cherry;
            SailorSoda ss2Cherry = new SailorSoda();
            ss2Cherry.Size = Enums.Size.Medium;
            ss2Cherry.Flavor = Enums.SodaFlavor.Cherry;
            SailorSoda ss3Cherry = new SailorSoda();
            ss3Cherry.Size = Enums.Size.Large;
            ss3Cherry.Flavor = Enums.SodaFlavor.Cherry;

            SailorSoda ssGrapeF = new SailorSoda();
            ssGrapeF.Size = Enums.Size.Small;
            ssGrapeF.Flavor = Enums.SodaFlavor.Grapefruit;
            SailorSoda ss2GrapeF = new SailorSoda();
            ss2GrapeF.Size = Enums.Size.Medium;
            ss2GrapeF.Flavor = Enums.SodaFlavor.Grapefruit;
            SailorSoda ss3GrapeF = new SailorSoda();
            ss3GrapeF.Size = Enums.Size.Large;
            ss3GrapeF.Flavor = Enums.SodaFlavor.Grapefruit;

            SailorSoda ssLemon = new SailorSoda();
            ssLemon.Size = Enums.Size.Small;
            ssLemon.Flavor = Enums.SodaFlavor.Lemon;
            SailorSoda ss2Lemon = new SailorSoda();
            ss2Lemon.Size = Enums.Size.Medium;
            ss2Lemon.Flavor = Enums.SodaFlavor.Lemon;
            SailorSoda ss3Lemon = new SailorSoda();
            ss3Lemon.Size = Enums.Size.Large;
            ss3Lemon.Flavor = Enums.SodaFlavor.Lemon;

            SailorSoda ssPeach = new SailorSoda();
            ssPeach.Size = Enums.Size.Small;
            ssPeach.Flavor = Enums.SodaFlavor.Peach;
            SailorSoda ss2Peach = new SailorSoda();
            ss2Peach.Size = Enums.Size.Medium;
            ss2Peach.Flavor = Enums.SodaFlavor.Peach;
            SailorSoda ss3Peach = new SailorSoda();
            ss3Peach.Size = Enums.Size.Large;
            ss3Peach.Flavor = Enums.SodaFlavor.Peach;

            SailorSoda ssWaterM = new SailorSoda();
            ssWaterM.Size = Enums.Size.Small;
            ssWaterM.Flavor = Enums.SodaFlavor.Watermelon;
            SailorSoda ss2WaterM = new SailorSoda();
            ss2WaterM.Size = Enums.Size.Medium;
            ss2WaterM.Flavor = Enums.SodaFlavor.Watermelon;
            SailorSoda ss3WaterM = new SailorSoda();
            ss3WaterM.Size = Enums.Size.Large;
            ss3WaterM.Flavor = Enums.SodaFlavor.Watermelon;

            WarriorWater ww = new WarriorWater();
            ww.Size = Enums.Size.Small;
            WarriorWater ww2 = new WarriorWater();
            ww2.Size = Enums.Size.Medium;
            WarriorWater ww3 = new WarriorWater();
            ww3.Size = Enums.Size.Large;

            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(aj);
            drinks.Add(aj2);
            drinks.Add(aj3);

            drinks.Add(cc);
            drinks.Add(cc2);
            drinks.Add(cc3);

            drinks.Add(mm);
            drinks.Add(mm2);
            drinks.Add(mm3);

            drinks.Add(ssBberry);
            drinks.Add(ss2Bberry);
            drinks.Add(ss3Bberry);
            drinks.Add(ssCherry);
            drinks.Add(ss2Cherry);
            drinks.Add(ss3Cherry);
            drinks.Add(ssGrapeF);
            drinks.Add(ss2GrapeF);
            drinks.Add(ss3GrapeF);
            drinks.Add(ssLemon);
            drinks.Add(ss2Lemon);
            drinks.Add(ss3Lemon);
            drinks.Add(ssPeach);
            drinks.Add(ss2Peach);
            drinks.Add(ss3Peach);
            drinks.Add(ssWaterM);
            drinks.Add(ss2WaterM);
            drinks.Add(ss3WaterM);

            drinks.Add(ww);
            drinks.Add(ww2);
            drinks.Add(ww3);

            return drinks;
        }

        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> entrees = Entrees().ToList();
            List<IOrderItem> sides = Sides().ToList();
            List<IOrderItem> drinks = Drinks().ToList();

            // Adds all menu items to one list
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.AddRange(entrees);
            fullMenu.AddRange(sides);
            fullMenu.AddRange(drinks);

            return fullMenu;
        }
    }
}
