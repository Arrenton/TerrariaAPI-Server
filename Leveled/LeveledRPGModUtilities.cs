using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Terraria.ID;
using Terraria.Utilities;

namespace Terraria.Leveled
{
    class Abilities
    {
        public static List<List<string>> AbilityList = new List<List<string>>();
        public static List<List<string>> AbilityListZeroEXP = new List<List<string>>();
        public static void CreateAbilities()
        {
            CreateZeroAbilities();
            AbilityList.Add(new List<string>());
            AbilityList[0].Add("Null"); //Name
            AbilityList[0].Add("999999"); //Level Learned
            AbilityList[0].Add("99"); //AP Cost
            AbilityList[0].Add("15"); //Icon
            AbilityList[0].Add("How did you even get this?\nHAX!!!\nShame on you!"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[1].Add("Endure"); //Name
            AbilityList[1].Add("60"); //Level Learned
            AbilityList[1].Add("5"); //AP Cost
            AbilityList[1].Add("14"); //Icon
            AbilityList[1].Add("Retain 1 HP if you take a fatal blow. (60 Sec cooldown.)"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[2].Add("Berserk"); //Name
            AbilityList[2].Add("24"); //Level Learned
            AbilityList[2].Add("2"); //AP Cost
            AbilityList[2].Add("7"); //Icon
            AbilityList[2].Add("Increases Mana regeneration when HP is below 20%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[3].Add("Defender"); //Name
            AbilityList[3].Add("18"); //Level Learned
            AbilityList[3].Add("2"); //AP Cost
            AbilityList[3].Add("9"); //Icon
            AbilityList[3].Add("Boosts Vitality by 7 when HP is below 20%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[4].Add("Warrior's Rage"); //Name
            AbilityList[4].Add("28"); //Level Learned
            AbilityList[4].Add("2"); //AP Cost
            AbilityList[4].Add("6"); //Icon
            AbilityList[4].Add("Boosts Strength and Thrown by 7 when HP is below 20%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[5].Add("Wizard's Fury"); //Name
            AbilityList[5].Add("29"); //Level Learned
            AbilityList[5].Add("2"); //AP Cost
            AbilityList[5].Add("7"); //Icon
            AbilityList[5].Add("Boosts Magic and Summon by 7 when HP is below 20%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[6].Add("Ranger's Last Stand"); //Name
            AbilityList[6].Add("30"); //Level Learned
            AbilityList[6].Add("2"); //AP Cost
            AbilityList[6].Add("8"); //Icon
            AbilityList[6].Add("Boosts Ranged by 7 when HP is below 20%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[7].Add("Scan"); //Name
            AbilityList[7].Add("6"); //Level Learned
            AbilityList[7].Add("1"); //AP Cost
            AbilityList[7].Add("15"); //Icon
            AbilityList[7].Add("Shows the status for the target you attack."); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[8].Add("Experience Boost"); //Name
            AbilityList[8].Add("20"); //Level Learned
            AbilityList[8].Add("3"); //AP Cost
            AbilityList[8].Add("15"); //Icon
            AbilityList[8].Add("Boosts EXP gain by 50% when HP is below 20%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[9].Add("Potion Master"); //Name
            AbilityList[9].Add("16"); //Level Learned
            AbilityList[9].Add("4"); //AP Cost
            AbilityList[9].Add("10"); //Icon
            AbilityList[9].Add("Increases the effectiveness of recovery potions by 20%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[10].Add("Potion Master II"); //Name
            AbilityList[10].Add("74"); //Level Learned
            AbilityList[10].Add("4"); //AP Cost
            AbilityList[10].Add("10"); //Icon
            AbilityList[10].Add("Increases the effectiveness of recovery potions by 20%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[11].Add("Critical Plus"); //Name
            AbilityList[11].Add("32"); //Level Learned
            AbilityList[11].Add("3"); //AP Cost
            AbilityList[11].Add("3"); //Icon
            AbilityList[11].Add("Increases critical chance for all weapons by 3%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[12].Add("Critical Plus II"); //Name
            AbilityList[12].Add("52"); //Level Learned
            AbilityList[12].Add("3"); //AP Cost
            AbilityList[12].Add("3"); //Icon
            AbilityList[12].Add("Increases critical chance for all weapons by 3%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[13].Add("Critical Plus III"); //Name
            AbilityList[13].Add("76"); //Level Learned
            AbilityList[13].Add("3"); //AP Cost
            AbilityList[13].Add("3"); //Icon
            AbilityList[13].Add("Increases critical chance for all weapons by 3%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[14].Add("HP Plus"); //Name
            AbilityList[14].Add("36"); //Level Learned
            AbilityList[14].Add("4"); //AP Cost
            AbilityList[14].Add("5"); //Icon
            AbilityList[14].Add("Increases Max HP by 2%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[15].Add("HP Plus II"); //Name
            AbilityList[15].Add("44"); //Level Learned
            AbilityList[15].Add("4"); //AP Cost
            AbilityList[15].Add("5"); //Icon
            AbilityList[15].Add("Increases Max HP by 2%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[16].Add("HP Plus III"); //Name
            AbilityList[16].Add("56"); //Level Learned
            AbilityList[16].Add("4"); //AP Cost
            AbilityList[16].Add("5"); //Icon
            AbilityList[16].Add("Increases Max HP by 2%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[17].Add("HP Plus IV"); //Name
            AbilityList[17].Add("72"); //Level Learned
            AbilityList[17].Add("4"); //AP Cost
            AbilityList[17].Add("5"); //Icon
            AbilityList[17].Add("Increases Max HP by 2%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[18].Add("HP Plus V"); //Name
            AbilityList[18].Add("88"); //Level Learned
            AbilityList[18].Add("4"); //AP Cost
            AbilityList[18].Add("5"); //Icon
            AbilityList[18].Add("Increases Max HP by 2%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[19].Add("MP Plus"); //Name
            AbilityList[19].Add("40"); //Level Learned
            AbilityList[19].Add("5"); //AP Cost
            AbilityList[19].Add("2"); //Icon
            AbilityList[19].Add("Increases Max MP by 1 per star"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[20].Add("MP Plus II"); //Name
            AbilityList[20].Add("50"); //Level Learned
            AbilityList[20].Add("5"); //AP Cost
            AbilityList[20].Add("2"); //Icon
            AbilityList[20].Add("Increases Max MP by 1 per star"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[21].Add("MP Plus III"); //Name
            AbilityList[21].Add("64"); //Level Learned
            AbilityList[21].Add("5"); //AP Cost
            AbilityList[21].Add("2"); //Icon
            AbilityList[21].Add("Increases Max MP by 1 per star"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[22].Add("MP Plus IV"); //Name
            AbilityList[22].Add("80"); //Level Learned
            AbilityList[22].Add("5"); //AP Cost
            AbilityList[22].Add("2"); //Icon
            AbilityList[22].Add("Increases Max MP by 1 per star"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[23].Add("MP Plus V"); //Name
            AbilityList[23].Add("96"); //Level Learned
            AbilityList[23].Add("5"); //AP Cost
            AbilityList[23].Add("2"); //Icon
            AbilityList[23].Add("Increases Max MP by 1 per star"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[24].Add("Dash"); //Name
            AbilityList[24].Add("78"); //Level Learned
            AbilityList[24].Add("3"); //AP Cost
            AbilityList[24].Add("2"); //Icon
            AbilityList[24].Add("Increases movement speed by 15%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[25].Add("Defense Plus"); //Name
            AbilityList[25].Add("22"); //Level Learned
            AbilityList[25].Add("2"); //AP Cost
            AbilityList[25].Add("4"); //Icon
            AbilityList[25].Add("Increases defense by 5%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[26].Add("Defense Plus II"); //Name
            AbilityList[26].Add("54"); //Level Learned
            AbilityList[26].Add("2"); //AP Cost
            AbilityList[26].Add("4"); //Icon
            AbilityList[26].Add("Increases defense by 5%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[27].Add("Defense Plus III"); //Name
            AbilityList[27].Add("82"); //Level Learned
            AbilityList[27].Add("2"); //AP Cost
            AbilityList[27].Add("4"); //Icon
            AbilityList[27].Add("Increases defense by 5%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[28].Add("Power Swing"); //Name
            AbilityList[28].Add("14"); //Level Learned
            AbilityList[28].Add("2"); //AP Cost
            AbilityList[28].Add("1"); //Icon
            AbilityList[28].Add("Increases damage with melee weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[29].Add("Power Swing II"); //Name
            AbilityList[29].Add("46"); //Level Learned
            AbilityList[29].Add("2"); //AP Cost
            AbilityList[29].Add("1"); //Icon
            AbilityList[29].Add("Increases damage with melee weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[30].Add("Power Swing III"); //Name
            AbilityList[30].Add("70"); //Level Learned
            AbilityList[30].Add("2"); //AP Cost
            AbilityList[30].Add("1"); //Icon
            AbilityList[30].Add("Increases damage with melee weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[31].Add("Heavy Magic"); //Name
            AbilityList[31].Add("34"); //Level Learned
            AbilityList[31].Add("2"); //AP Cost
            AbilityList[31].Add("2"); //Icon
            AbilityList[31].Add("Increases damage with magic weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[32].Add("Heavy Magic II"); //Name
            AbilityList[32].Add("48"); //Level Learned
            AbilityList[32].Add("2"); //AP Cost
            AbilityList[32].Add("2"); //Icon
            AbilityList[32].Add("Increases damage with magic weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[33].Add("Heavy Magic III"); //Name
            AbilityList[33].Add("84"); //Level Learned
            AbilityList[33].Add("2"); //AP Cost
            AbilityList[33].Add("2"); //Icon
            AbilityList[33].Add("Increases damage with magic weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[34].Add("Extra Precision"); //Name
            AbilityList[34].Add("26"); //Level Learned
            AbilityList[34].Add("2"); //AP Cost
            AbilityList[34].Add("3"); //Icon
            AbilityList[34].Add("Increases damage with ranged weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[35].Add("Extra Precision II"); //Name
            AbilityList[35].Add("38"); //Level Learned
            AbilityList[35].Add("2"); //AP Cost
            AbilityList[35].Add("3"); //Icon
            AbilityList[35].Add("Increases damage with ranged weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[36].Add("Extra Precision III"); //Name
            AbilityList[36].Add("68"); //Level Learned
            AbilityList[36].Add("2"); //AP Cost
            AbilityList[36].Add("3"); //Icon
            AbilityList[36].Add("Increases damage with ranged weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[37].Add("Minion Boost"); //Name
            AbilityList[37].Add("42"); //Level Learned
            AbilityList[37].Add("6"); //AP Cost
            AbilityList[37].Add("7"); //Icon
            AbilityList[37].Add("Increases max minions by 1"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[38].Add("EXP Share"); //Name
            AbilityList[38].Add("10"); //Level Learned
            AbilityList[38].Add("4"); //AP Cost
            AbilityList[38].Add("15"); //Icon
            AbilityList[38].Add("Recieve 10% of all EXP gained by other party members. (Minimum 1 EXP)"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[39].Add("EXP Share II"); //Name
            AbilityList[39].Add("58"); //Level Learned
            AbilityList[39].Add("8"); //AP Cost
            AbilityList[39].Add("15"); //Icon
            AbilityList[39].Add("Recieve 25% of all EXP gained by other party members. (Minimum 1 EXP)"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[40].Add("Treasure Magnet"); //Name
            AbilityList[40].Add("62"); //Level Learned
            AbilityList[40].Add("3"); //AP Cost
            AbilityList[40].Add("15"); //Icon
            AbilityList[40].Add("Draws in nearby items to you."); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[41].Add("MP Rage"); //Name
            AbilityList[41].Add("66"); //Level Learned
            AbilityList[41].Add("4"); //AP Cost
            AbilityList[41].Add("7"); //Icon
            AbilityList[41].Add("Restores mana when damaged."); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[42].Add("Heart Boost"); //Name
            AbilityList[42].Add("35"); //Level Learned
            AbilityList[42].Add("3"); //AP Cost
            AbilityList[42].Add("10"); //Icon
            AbilityList[42].Add("Increases recovery rate from hearts by 10%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[43].Add("Heart Boost II"); //Name
            AbilityList[43].Add("98"); //Level Learned
            AbilityList[43].Add("4"); //AP Cost
            AbilityList[43].Add("10"); //Icon
            AbilityList[43].Add("Increases recovery rate from hearts by 15%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[44].Add("Summon Boost"); //Name
            AbilityList[44].Add("39"); //Level Learned
            AbilityList[44].Add("2"); //AP Cost
            AbilityList[44].Add("7"); //Icon
            AbilityList[44].Add("Increases damage with summoning weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[45].Add("Summon Boost II"); //Name
            AbilityList[45].Add("55"); //Level Learned
            AbilityList[45].Add("2"); //AP Cost
            AbilityList[45].Add("7"); //Icon
            AbilityList[45].Add("Increases damage with summoning weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[46].Add("Summon Boost III"); //Name
            AbilityList[46].Add("81"); //Level Learned
            AbilityList[46].Add("2"); //AP Cost
            AbilityList[46].Add("7"); //Icon
            AbilityList[46].Add("Increases damage with summoning weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[47].Add("Throwing Boost"); //Name
            AbilityList[47].Add("8"); //Level Learned
            AbilityList[47].Add("2"); //AP Cost
            AbilityList[47].Add("8"); //Icon
            AbilityList[47].Add("Increases damage with throwing weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[48].Add("Throwing Boost II"); //Name
            AbilityList[48].Add("25"); //Level Learned
            AbilityList[48].Add("2"); //AP Cost
            AbilityList[48].Add("8"); //Icon
            AbilityList[48].Add("Increases damage with throwing weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[49].Add("Throwing Boost III"); //Name
            AbilityList[49].Add("57"); //Level Learned
            AbilityList[49].Add("2"); //AP Cost
            AbilityList[49].Add("8"); //Icon
            AbilityList[49].Add("Increases damage with throwing weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[50].Add("Resist Knockback"); //Name
            AbilityList[50].Add("33"); //Level Learned
            AbilityList[50].Add("3"); //AP Cost
            AbilityList[50].Add("11"); //Icon
            AbilityList[50].Add("Increases Knockback resist by 6%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[51].Add("Resist Knockback II"); //Name
            AbilityList[51].Add("65"); //Level Learned
            AbilityList[51].Add("3"); //AP Cost
            AbilityList[51].Add("11"); //Icon
            AbilityList[51].Add("Increases Knockback resist by 6%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[52].Add("Resist Knockback III"); //Name
            AbilityList[52].Add("86"); //Level Learned
            AbilityList[52].Add("3"); //AP Cost
            AbilityList[52].Add("11"); //Icon
            AbilityList[52].Add("Increases Knockback resist by 6%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[53].Add("Social Slot Enabler"); //Name
            AbilityList[53].Add("999"); //Level Learned
            AbilityList[53].Add("1"); //AP Cost
            AbilityList[53].Add("15"); //Icon
            AbilityList[53].Add("Your social slots will now act as extra slots, enabling stat gains from them.\nCongratulations on your level 1 Moon Lord victory!"); //Discription
        }
        public static void CreateZeroAbilities()
        {
            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[0].Add("Null"); //Name
            AbilityListZeroEXP[0].Add("999999"); //Level Learned
            AbilityListZeroEXP[0].Add("99"); //AP Cost
            AbilityListZeroEXP[0].Add("15"); //Icon
            AbilityListZeroEXP[0].Add("How did you even get this?\nHAX!!!\nShame on you!"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[1].Add("Endure"); //Name
            AbilityListZeroEXP[1].Add("60"); //Level Learned
            AbilityListZeroEXP[1].Add("5"); //AP Cost
            AbilityListZeroEXP[1].Add("14"); //Icon
            AbilityListZeroEXP[1].Add("Retain 1 HP if you take a fatal blow. (60 Sec cooldown.)"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[2].Add("Berserk"); //Name
            AbilityListZeroEXP[2].Add("1"); //Level Learned
            AbilityListZeroEXP[2].Add("2"); //AP Cost
            AbilityListZeroEXP[2].Add("7"); //Icon
            AbilityListZeroEXP[2].Add("Increases Mana regeneration when HP is below 20%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[3].Add("Defender"); //Name
            AbilityListZeroEXP[3].Add("1"); //Level Learned
            AbilityListZeroEXP[3].Add("2"); //AP Cost
            AbilityListZeroEXP[3].Add("9"); //Icon
            AbilityListZeroEXP[3].Add("Boosts Vitality by 7 when HP is below 20%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[4].Add("Warrior's Rage"); //Name
            AbilityListZeroEXP[4].Add("1"); //Level Learned
            AbilityListZeroEXP[4].Add("2"); //AP Cost
            AbilityListZeroEXP[4].Add("6"); //Icon
            AbilityListZeroEXP[4].Add("Boosts Strength and Thrown by 7 when HP is below 20%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[5].Add("Wizard's Fury"); //Name
            AbilityListZeroEXP[5].Add("1"); //Level Learned
            AbilityListZeroEXP[5].Add("2"); //AP Cost
            AbilityListZeroEXP[5].Add("7"); //Icon
            AbilityListZeroEXP[5].Add("Boosts Magic and Summon by 7 when HP is below 20%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[6].Add("Ranger's Last Stand"); //Name
            AbilityListZeroEXP[6].Add("1"); //Level Learned
            AbilityListZeroEXP[6].Add("2"); //AP Cost
            AbilityListZeroEXP[6].Add("8"); //Icon
            AbilityListZeroEXP[6].Add("Boosts Ranged by 7 when HP is below 20%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[7].Add("Scan"); //Name
            AbilityListZeroEXP[7].Add("1"); //Level Learned
            AbilityListZeroEXP[7].Add("1"); //AP Cost
            AbilityListZeroEXP[7].Add("15"); //Icon
            AbilityListZeroEXP[7].Add("Shows the status for the target you attack."); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[8].Add("Experience Boost"); //Name
            AbilityListZeroEXP[8].Add("20"); //Level Learned
            AbilityListZeroEXP[8].Add("3"); //AP Cost
            AbilityListZeroEXP[8].Add("15"); //Icon
            AbilityListZeroEXP[8].Add("Boosts EXP gain by 50% when HP is below 20%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[9].Add("Potion Master"); //Name
            AbilityListZeroEXP[9].Add("1"); //Level Learned
            AbilityListZeroEXP[9].Add("4"); //AP Cost
            AbilityListZeroEXP[9].Add("10"); //Icon
            AbilityListZeroEXP[9].Add("Increases the effectiveness of recovery potions by 20%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[10].Add("Potion Master II"); //Name
            AbilityListZeroEXP[10].Add("74"); //Level Learned
            AbilityListZeroEXP[10].Add("4"); //AP Cost
            AbilityListZeroEXP[10].Add("10"); //Icon
            AbilityListZeroEXP[10].Add("Increases the effectiveness of recovery potions by 20%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[11].Add("Critical Plus"); //Name
            AbilityListZeroEXP[11].Add("1"); //Level Learned
            AbilityListZeroEXP[11].Add("3"); //AP Cost
            AbilityListZeroEXP[11].Add("3"); //Icon
            AbilityListZeroEXP[11].Add("Increases critical chance for all weapons by 3%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[12].Add("Critical Plus II"); //Name
            AbilityListZeroEXP[12].Add("52"); //Level Learned
            AbilityListZeroEXP[12].Add("3"); //AP Cost
            AbilityListZeroEXP[12].Add("3"); //Icon
            AbilityListZeroEXP[12].Add("Increases critical chance for all weapons by 3%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[13].Add("Critical Plus III"); //Name
            AbilityListZeroEXP[13].Add("76"); //Level Learned
            AbilityListZeroEXP[13].Add("3"); //AP Cost
            AbilityListZeroEXP[13].Add("3"); //Icon
            AbilityListZeroEXP[13].Add("Increases critical chance for all weapons by 3%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[14].Add("HP Plus"); //Name
            AbilityListZeroEXP[14].Add("1"); //Level Learned
            AbilityListZeroEXP[14].Add("4"); //AP Cost
            AbilityListZeroEXP[14].Add("5"); //Icon
            AbilityListZeroEXP[14].Add("Increases Max HP by 2%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[15].Add("HP Plus II"); //Name
            AbilityListZeroEXP[15].Add("44"); //Level Learned
            AbilityListZeroEXP[15].Add("4"); //AP Cost
            AbilityListZeroEXP[15].Add("5"); //Icon
            AbilityListZeroEXP[15].Add("Increases Max HP by 2%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[16].Add("HP Plus III"); //Name
            AbilityListZeroEXP[16].Add("56"); //Level Learned
            AbilityListZeroEXP[16].Add("4"); //AP Cost
            AbilityListZeroEXP[16].Add("5"); //Icon
            AbilityListZeroEXP[16].Add("Increases Max HP by 2%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[17].Add("HP Plus IV"); //Name
            AbilityListZeroEXP[17].Add("72"); //Level Learned
            AbilityListZeroEXP[17].Add("4"); //AP Cost
            AbilityListZeroEXP[17].Add("5"); //Icon
            AbilityListZeroEXP[17].Add("Increases Max HP by 2%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[18].Add("HP Plus V"); //Name
            AbilityListZeroEXP[18].Add("88"); //Level Learned
            AbilityListZeroEXP[18].Add("4"); //AP Cost
            AbilityListZeroEXP[18].Add("5"); //Icon
            AbilityListZeroEXP[18].Add("Increases Max HP by 2%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[19].Add("MP Plus"); //Name
            AbilityListZeroEXP[19].Add("1"); //Level Learned
            AbilityListZeroEXP[19].Add("5"); //AP Cost
            AbilityListZeroEXP[19].Add("2"); //Icon
            AbilityListZeroEXP[19].Add("Increases Max MP by 1 per star"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[20].Add("MP Plus II"); //Name
            AbilityListZeroEXP[20].Add("50"); //Level Learned
            AbilityListZeroEXP[20].Add("5"); //AP Cost
            AbilityListZeroEXP[20].Add("2"); //Icon
            AbilityListZeroEXP[20].Add("Increases Max MP by 1 per star"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[21].Add("MP Plus III"); //Name
            AbilityListZeroEXP[21].Add("64"); //Level Learned
            AbilityListZeroEXP[21].Add("5"); //AP Cost
            AbilityListZeroEXP[21].Add("2"); //Icon
            AbilityListZeroEXP[21].Add("Increases Max MP by 1 per star"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[22].Add("MP Plus IV"); //Name
            AbilityListZeroEXP[22].Add("80"); //Level Learned
            AbilityListZeroEXP[22].Add("5"); //AP Cost
            AbilityListZeroEXP[22].Add("2"); //Icon
            AbilityListZeroEXP[22].Add("Increases Max MP by 1 per star"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[23].Add("MP Plus V"); //Name
            AbilityListZeroEXP[23].Add("96"); //Level Learned
            AbilityListZeroEXP[23].Add("5"); //AP Cost
            AbilityListZeroEXP[23].Add("2"); //Icon
            AbilityListZeroEXP[23].Add("Increases Max MP by 1 per star"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[24].Add("Dash"); //Name
            AbilityListZeroEXP[24].Add("1"); //Level Learned
            AbilityListZeroEXP[24].Add("3"); //AP Cost
            AbilityListZeroEXP[24].Add("2"); //Icon
            AbilityListZeroEXP[24].Add("Increases movement speed by 15%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[25].Add("Defense Plus"); //Name
            AbilityListZeroEXP[25].Add("1"); //Level Learned
            AbilityListZeroEXP[25].Add("2"); //AP Cost
            AbilityListZeroEXP[25].Add("4"); //Icon
            AbilityListZeroEXP[25].Add("Increases defense by 5%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[26].Add("Defense Plus II"); //Name
            AbilityListZeroEXP[26].Add("54"); //Level Learned
            AbilityListZeroEXP[26].Add("2"); //AP Cost
            AbilityListZeroEXP[26].Add("4"); //Icon
            AbilityListZeroEXP[26].Add("Increases defense by 5%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[27].Add("Defense Plus III"); //Name
            AbilityListZeroEXP[27].Add("82"); //Level Learned
            AbilityListZeroEXP[27].Add("2"); //AP Cost
            AbilityListZeroEXP[27].Add("4"); //Icon
            AbilityListZeroEXP[27].Add("Increases defense by 5%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[28].Add("Power Swing"); //Name
            AbilityListZeroEXP[28].Add("1"); //Level Learned
            AbilityListZeroEXP[28].Add("2"); //AP Cost
            AbilityListZeroEXP[28].Add("1"); //Icon
            AbilityListZeroEXP[28].Add("Increases damage with melee weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[29].Add("Power Swing II"); //Name
            AbilityListZeroEXP[29].Add("46"); //Level Learned
            AbilityListZeroEXP[29].Add("2"); //AP Cost
            AbilityListZeroEXP[29].Add("1"); //Icon
            AbilityListZeroEXP[29].Add("Increases damage with melee weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[30].Add("Power Swing III"); //Name
            AbilityListZeroEXP[30].Add("70"); //Level Learned
            AbilityListZeroEXP[30].Add("2"); //AP Cost
            AbilityListZeroEXP[30].Add("1"); //Icon
            AbilityListZeroEXP[30].Add("Increases damage with melee weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[31].Add("Heavy Magic"); //Name
            AbilityListZeroEXP[31].Add("1"); //Level Learned
            AbilityListZeroEXP[31].Add("2"); //AP Cost
            AbilityListZeroEXP[31].Add("2"); //Icon
            AbilityListZeroEXP[31].Add("Increases damage with magic weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[32].Add("Heavy Magic II"); //Name
            AbilityListZeroEXP[32].Add("48"); //Level Learned
            AbilityListZeroEXP[32].Add("2"); //AP Cost
            AbilityListZeroEXP[32].Add("2"); //Icon
            AbilityListZeroEXP[32].Add("Increases damage with magic weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[33].Add("Heavy Magic III"); //Name
            AbilityListZeroEXP[33].Add("84"); //Level Learned
            AbilityListZeroEXP[33].Add("2"); //AP Cost
            AbilityListZeroEXP[33].Add("2"); //Icon
            AbilityListZeroEXP[33].Add("Increases damage with magic weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[34].Add("Extra Precision"); //Name
            AbilityListZeroEXP[34].Add("1"); //Level Learned
            AbilityListZeroEXP[34].Add("2"); //AP Cost
            AbilityListZeroEXP[34].Add("3"); //Icon
            AbilityListZeroEXP[34].Add("Increases damage with ranged weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[35].Add("Extra Precision II"); //Name
            AbilityListZeroEXP[35].Add("38"); //Level Learned
            AbilityListZeroEXP[35].Add("2"); //AP Cost
            AbilityListZeroEXP[35].Add("3"); //Icon
            AbilityListZeroEXP[35].Add("Increases damage with ranged weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[36].Add("Extra Precision III"); //Name
            AbilityListZeroEXP[36].Add("68"); //Level Learned
            AbilityListZeroEXP[36].Add("2"); //AP Cost
            AbilityListZeroEXP[36].Add("3"); //Icon
            AbilityListZeroEXP[36].Add("Increases damage with ranged weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[37].Add("Minion Boost"); //Name
            AbilityListZeroEXP[37].Add("1"); //Level Learned
            AbilityListZeroEXP[37].Add("6"); //AP Cost
            AbilityListZeroEXP[37].Add("7"); //Icon
            AbilityListZeroEXP[37].Add("Increases max minions by 1"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[38].Add("EXP Share"); //Name
            AbilityListZeroEXP[38].Add("10"); //Level Learned
            AbilityListZeroEXP[38].Add("4"); //AP Cost
            AbilityListZeroEXP[38].Add("15"); //Icon
            AbilityListZeroEXP[38].Add("Recieve 10% of all EXP gained by other party members. (Minimum 1 EXP)"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[39].Add("EXP Share II"); //Name
            AbilityListZeroEXP[39].Add("58"); //Level Learned
            AbilityListZeroEXP[39].Add("8"); //AP Cost
            AbilityListZeroEXP[39].Add("15"); //Icon
            AbilityListZeroEXP[39].Add("Recieve 25% of all EXP gained by other party members. (Minimum 1 EXP)"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[40].Add("Treasure Magnet"); //Name
            AbilityListZeroEXP[40].Add("1"); //Level Learned
            AbilityListZeroEXP[40].Add("3"); //AP Cost
            AbilityListZeroEXP[40].Add("15"); //Icon
            AbilityListZeroEXP[40].Add("Draws in nearby items to you."); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[41].Add("MP Rage"); //Name
            AbilityListZeroEXP[41].Add("66"); //Level Learned
            AbilityListZeroEXP[41].Add("4"); //AP Cost
            AbilityListZeroEXP[41].Add("7"); //Icon
            AbilityListZeroEXP[41].Add("Restores mana when damaged."); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[42].Add("Heart Boost"); //Name
            AbilityListZeroEXP[42].Add("1"); //Level Learned
            AbilityListZeroEXP[42].Add("3"); //AP Cost
            AbilityListZeroEXP[42].Add("10"); //Icon
            AbilityListZeroEXP[42].Add("Increases recovery rate from hearts by 10%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[43].Add("Heart Boost II"); //Name
            AbilityListZeroEXP[43].Add("98"); //Level Learned
            AbilityListZeroEXP[43].Add("4"); //AP Cost
            AbilityListZeroEXP[43].Add("10"); //Icon
            AbilityListZeroEXP[43].Add("Increases recovery rate from hearts by 15%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[44].Add("Summon Boost"); //Name
            AbilityListZeroEXP[44].Add("1"); //Level Learned
            AbilityListZeroEXP[44].Add("2"); //AP Cost
            AbilityListZeroEXP[44].Add("7"); //Icon
            AbilityListZeroEXP[44].Add("Increases damage with summoning weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[45].Add("Summon Boost II"); //Name
            AbilityListZeroEXP[45].Add("55"); //Level Learned
            AbilityListZeroEXP[45].Add("2"); //AP Cost
            AbilityListZeroEXP[45].Add("7"); //Icon
            AbilityListZeroEXP[45].Add("Increases damage with summoning weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[46].Add("Summon Boost III"); //Name
            AbilityListZeroEXP[46].Add("81"); //Level Learned
            AbilityListZeroEXP[46].Add("2"); //AP Cost
            AbilityListZeroEXP[46].Add("7"); //Icon
            AbilityListZeroEXP[46].Add("Increases damage with summoning weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[47].Add("Throwing Boost"); //Name
            AbilityListZeroEXP[47].Add("1"); //Level Learned
            AbilityListZeroEXP[47].Add("2"); //AP Cost
            AbilityListZeroEXP[47].Add("8"); //Icon
            AbilityListZeroEXP[47].Add("Increases damage with throwing weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[48].Add("Throwing Boost II"); //Name
            AbilityListZeroEXP[48].Add("25"); //Level Learned
            AbilityListZeroEXP[48].Add("2"); //AP Cost
            AbilityListZeroEXP[48].Add("8"); //Icon
            AbilityListZeroEXP[48].Add("Increases damage with throwing weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[49].Add("Throwing Boost III"); //Name
            AbilityListZeroEXP[49].Add("57"); //Level Learned
            AbilityListZeroEXP[49].Add("2"); //AP Cost
            AbilityListZeroEXP[49].Add("8"); //Icon
            AbilityListZeroEXP[49].Add("Increases damage with throwing weapons by 4%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[50].Add("Resist Knockback"); //Name
            AbilityListZeroEXP[50].Add("1"); //Level Learned
            AbilityListZeroEXP[50].Add("3"); //AP Cost
            AbilityListZeroEXP[50].Add("11"); //Icon
            AbilityListZeroEXP[50].Add("Increases Knockback resist by 6%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[51].Add("Resist Knockback II"); //Name
            AbilityListZeroEXP[51].Add("1"); //Level Learned
            AbilityListZeroEXP[51].Add("3"); //AP Cost
            AbilityListZeroEXP[51].Add("11"); //Icon
            AbilityListZeroEXP[51].Add("Increases Knockback resist by 6%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[52].Add("Resist Knockback III"); //Name
            AbilityListZeroEXP[52].Add("1"); //Level Learned
            AbilityListZeroEXP[52].Add("3"); //AP Cost
            AbilityListZeroEXP[52].Add("11"); //Icon
            AbilityListZeroEXP[52].Add("Increases Knockback resist by 6%"); //Discription

            AbilityListZeroEXP.Add(new List<string>());
            AbilityListZeroEXP[53].Add("Social Slot Enabler"); //Name
            AbilityListZeroEXP[53].Add("999"); //Level Learned
            AbilityListZeroEXP[53].Add("1"); //AP Cost
            AbilityListZeroEXP[53].Add("15"); //Icon
            AbilityListZeroEXP[53].Add("Your social slots will now act as extra slots, enabling stat gains from them.\nCongratulations on your level 1 Moon Lord victory!"); //Discription
        }
    }
    class LeveledRPGModUtilities
	{
		public static void saveEXP(bool useCloudSaving, string path)
		{
			//if (useCloudSaving && SocialAPI.Cloud == null)
			//{
			//	return;
			//}
			string text = path.Substring(0, path.Length - 4);
			string str = string.Concat(new object[]
			{
				text,
				".lvl" 
			});

			byte[] array = null;
			int num = 0;
			using (MemoryStream memoryStream = new MemoryStream(2000000))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
				{
					BitsByte bb = 0;
					binaryWriter.Write(Main.CriticalMode);
					binaryWriter.Write(Main.worldID);
					binaryWriter.Write(50);
					for (int i = 0; i < Main.maxTilesX; i++)
					{
						for (int j = 0; j < Main.maxTilesY; j += 8)
						{
							bb[0] = WorldSpawned(Main.tile[i, j], Main.tile2[i, j]);
							if ((j + 1) <= Main.maxTilesY)
								bb[1] = WorldSpawned(Main.tile[i, j + 1], Main.tile2[i, j + 1]);
							if ((j + 2) <= Main.maxTilesY)
								bb[2] = WorldSpawned(Main.tile[i, j + 2], Main.tile2[i, j + 2]);
							if ((j + 3) <= Main.maxTilesY)
								bb[3] = WorldSpawned(Main.tile[i, j + 3], Main.tile2[i, j + 3]);
							if ((j + 4) <= Main.maxTilesY)
								bb[4] = WorldSpawned(Main.tile[i, j + 4], Main.tile2[i, j + 4]);
							if ((j + 5) <= Main.maxTilesY)
								bb[5] = WorldSpawned(Main.tile[i, j + 5], Main.tile2[i, j + 5]);
							if ((j + 6) <= Main.maxTilesY)
								bb[6] = WorldSpawned(Main.tile[i, j + 6], Main.tile2[i, j + 6]);
							if ((j + 7) <= Main.maxTilesY)
								bb[7] = WorldSpawned(Main.tile[i, j + 7], Main.tile2[i, j + 7]);
							binaryWriter.Write(bb);
						}
					}
				}
				array = memoryStream.ToArray();
				num = array.Length;
			}
			if (array == null)
			{
				return;
            }
            FileUtilities.Write(str, array, num);
        }

		public static bool WorldSpawned(Tile tile, Tile tile2)
		{
			int type = tile.type;
			if ((TileID.Sets.Ore[type] || (type == TileID.Obsidian) || (type == TileID.Sapphire) || (type == TileID.Ruby) || (type == TileID.Emerald) || (type == TileID.Topaz) || (type == TileID.Amethyst) || (type == TileID.Diamond) || (type == TileID.ExposedGems)) && WorldGen.GeneratingWorld)
			{
				return true;
			}
            if (tile2.Worldspawned && !WorldGen.GeneratingWorld)
            {
                return true;
            }
			return false;
		}
	}
}
