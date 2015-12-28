using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leveled
{
    class Abilities
    {
        public static List<List<string>> AbilityList = new List<List<string>>();
        public static void CreateAbilities()
        {
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
            AbilityList[10].Add("Potion Master"); //Name
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
            AbilityList[12].Add("Critical Plus"); //Name
            AbilityList[12].Add("52"); //Level Learned
            AbilityList[12].Add("3"); //AP Cost
            AbilityList[12].Add("3"); //Icon
            AbilityList[12].Add("Increases critical chance for all weapons by 3%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[13].Add("Critical Plus"); //Name
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
            AbilityList[15].Add("HP Plus"); //Name
            AbilityList[15].Add("44"); //Level Learned
            AbilityList[15].Add("4"); //AP Cost
            AbilityList[15].Add("5"); //Icon
            AbilityList[15].Add("Increases Max HP by 2%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[16].Add("HP Plus"); //Name
            AbilityList[16].Add("56"); //Level Learned
            AbilityList[16].Add("4"); //AP Cost
            AbilityList[16].Add("5"); //Icon
            AbilityList[16].Add("Increases Max HP by 2%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[17].Add("HP Plus"); //Name
            AbilityList[17].Add("72"); //Level Learned
            AbilityList[17].Add("4"); //AP Cost
            AbilityList[17].Add("5"); //Icon
            AbilityList[17].Add("Increases Max HP by 2%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[18].Add("HP Plus"); //Name
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
            AbilityList[20].Add("MP Plus"); //Name
            AbilityList[20].Add("50"); //Level Learned
            AbilityList[20].Add("5"); //AP Cost
            AbilityList[20].Add("2"); //Icon
            AbilityList[20].Add("Increases Max MP by 1 per star"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[21].Add("MP Plus"); //Name
            AbilityList[21].Add("64"); //Level Learned
            AbilityList[21].Add("5"); //AP Cost
            AbilityList[21].Add("2"); //Icon
            AbilityList[21].Add("Increases Max MP by 1 per star"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[22].Add("MP Plus"); //Name
            AbilityList[22].Add("80"); //Level Learned
            AbilityList[22].Add("5"); //AP Cost
            AbilityList[22].Add("2"); //Icon
            AbilityList[22].Add("Increases Max MP by 1 per star"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[23].Add("MP Plus"); //Name
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
            AbilityList[26].Add("Defense Plus"); //Name
            AbilityList[26].Add("54"); //Level Learned
            AbilityList[26].Add("2"); //AP Cost
            AbilityList[26].Add("4"); //Icon
            AbilityList[26].Add("Increases defense by 5%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[27].Add("Defense Plus"); //Name
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
            AbilityList[29].Add("Power Swing"); //Name
            AbilityList[29].Add("46"); //Level Learned
            AbilityList[29].Add("2"); //AP Cost
            AbilityList[29].Add("1"); //Icon
            AbilityList[29].Add("Increases damage with melee weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[30].Add("Power Swing"); //Name
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
            AbilityList[32].Add("Heavy Magic"); //Name
            AbilityList[32].Add("48"); //Level Learned
            AbilityList[32].Add("2"); //AP Cost
            AbilityList[32].Add("2"); //Icon
            AbilityList[32].Add("Increases damage with magic weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[33].Add("Heavy Magic"); //Name
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
            AbilityList[35].Add("Extra Precision"); //Name
            AbilityList[35].Add("38"); //Level Learned
            AbilityList[35].Add("2"); //AP Cost
            AbilityList[35].Add("3"); //Icon
            AbilityList[35].Add("Increases damage with ranged weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[36].Add("Extra Precision"); //Name
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
            AbilityList[39].Add("EXP Share 2"); //Name
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
            AbilityList[43].Add("Heart Boost 2"); //Name
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
            AbilityList[45].Add("Summon Boost"); //Name
            AbilityList[45].Add("55"); //Level Learned
            AbilityList[45].Add("2"); //AP Cost
            AbilityList[45].Add("7"); //Icon
            AbilityList[45].Add("Increases damage with summoning weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[46].Add("Summon Boost"); //Name
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
            AbilityList[48].Add("Throwing Boost"); //Name
            AbilityList[48].Add("25"); //Level Learned
            AbilityList[48].Add("2"); //AP Cost
            AbilityList[48].Add("8"); //Icon
            AbilityList[48].Add("Increases damage with throwing weapons by 4%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[49].Add("Throwing Boost"); //Name
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
            AbilityList[51].Add("Resist Knockback"); //Name
            AbilityList[51].Add("65"); //Level Learned
            AbilityList[51].Add("3"); //AP Cost
            AbilityList[51].Add("11"); //Icon
            AbilityList[51].Add("Increases Knockback resist by 6%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[52].Add("Resist Knockback"); //Name
            AbilityList[52].Add("86"); //Level Learned
            AbilityList[52].Add("3"); //AP Cost
            AbilityList[52].Add("11"); //Icon
            AbilityList[52].Add("Increases Knockback resist by 6%"); //Discription

            AbilityList.Add(new List<string>());
            AbilityList[53].Add("Vanity Enabler"); //Name
            AbilityList[53].Add("999"); //Level Learned
            AbilityList[53].Add("1"); //AP Cost
            AbilityList[53].Add("15"); //Icon
            AbilityList[53].Add("Your vanity slots will now act as extra slots, enabling stat gains from them.\nCongratulations on your level 1 Moon Lord victory!"); //Discription
        }
    }
}
