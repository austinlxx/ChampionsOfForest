﻿namespace ChampionsOfForest.Items
{
    internal class StatActions
    {
        public static void AddVitality(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.vitality += (int)f;
        }
        public static void RemoveVitality(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.vitality -= (int)f;
        }
        public static void AddStrenght(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.strenght += (int)f;
        }
        public static void RemoveStrenght(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.strenght -= (int)f;
        }
        public static void AddAgility(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.agility += (int)f;
        }
        public static void RemoveAgility(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.agility -= (int)f;
        }
        public static void AddIntelligence(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.intelligence += (int)f;
        }
        public static void RemoveIntelligence(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.intelligence -= (int)f;
        }
        public static void AddHealth(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.HealthBonus += (int)f;
        }
        public static void RemoveHealth(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.HealthBonus -= (int)f;
        }
        public static void AddEnergy(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.EnergyBonus += (int)f;
        }
        public static void RemoveEnergy(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.EnergyBonus += (int)f;
        }
        public static void AddHPRegen(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.LifeRegen += f;
        }
        public static void RemoveHPRegen(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.LifeRegen -= f;
        }
        public static void AddERegen(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.EnergyRegen += f;
        }
        public static void RemoveERegen(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.EnergyRegen -= f;
        }
        public static void AddEnergyRegenPercent(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.EnergyRegenPercent += f;
        }
        public static void RemoveEnergyRegenPercent(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.EnergyRegenPercent -= f;
        }
        public static void AddHealthRegenPercent(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.HealthRegenPercent += f;
        }
        public static void RemoveHealthRegenPercent(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.HealthRegenPercent -= f;
        }
        public static void AddDamageReduction(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.DamageReduction *= 1 - f;
        }
        public static void RemoveDamageReduction(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.DamageReduction /= 1 - f;
        }
        public static void AddCritChance(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.CritChance += f;
        }
        public static void RemoveCritChance(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.CritChance -= f;
        }
        public static void AddCritDamage(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.CritDamage += f;
        }
        public static void RemoveCritDamage(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.CritDamage -= f;
        }
        public static void AddLifeOnHit(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.LifeOnHit += f;
        }
        public static void RemoveLifeOnHit(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.LifeOnHit -= f;
        }
        public static void AddDodgeChance(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.DodgeChance += f;
        }
        public static void RemoveDodgeChance(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.DodgeChance -= f;
        }
        public static void AddArmor(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.Armor += (int)f;
        }
        public static void RemoveArmor(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.Armor -= (int)f;
        }
        public static void AddMagicResistance(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.MagicResistance += f;
        }
        public static void RemoveMagicResistance(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.MagicResistance -= f;
        }
        public static void AddAttackSpeed(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.AttackSpeed += f;
        }
        public static void RemoveAttackSpeed(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.AttackSpeed -= f;
        }
        public static void AddExpFactor(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.ExpFactor += f;
        }
        public static void RemoveExpFactor(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.ExpFactor -= f;
        }
        public static void AddMaxMassacreTime(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.MaxMassacreTime += f;
        }
        public static void RemoveMaxMassacreTime(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.MaxMassacreTime -= f;
        }
        public static void AddSpellDamageAmplifier(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.SpellDamageAmplifier += f;
        }
        public static void RemoveSpellDamageAmplifier(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.SpellDamageAmplifier -= f;
        }
        public static void AddMeeleDamageAmplifier(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.MeeleDamageAmplifier += f;
        }
        public static void RemoveMeeleDamageAmplifier(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.MeeleDamageAmplifier -= f;
        }
        public static void AddRangedDamageAmplifier(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.RangedDamageAmplifier += f;
        }
        public static void RemoveRangedDamageAmplifier(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.RangedDamageAmplifier -= f;
        }
        public static void AddSpellDamageBonus(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.SpellDamageBonus += f;
        }
        public static void RemoveSpellDamageBonus(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.SpellDamageBonus -= f;
        }
        public static void AddMeeleDamageBonus(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.MeeleDamageBonus += f;
        }
        public static void RemoveMeeleDamageBonus(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.MeeleDamageBonus -= f;
        }
        public static void AddRangedDamageBonus(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.RangedDamageBonus += f;
        }
        public static void RemoveRangedDamageBonus(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.RangedDamageBonus -= f;
        }
        public static void AddEnergyPerAgility(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.EnergyPerAgility += f;
        }
        public static void RemoveEnergyPerAgility(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.EnergyPerAgility -= f;
        }
        public static void AddHealthPerVitality(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.HealthPerVitality += f;
        }
        public static void RemoveHealthPerVitality(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.HealthPerVitality -= f;
        }
        public static void AddSpellDamageperInt(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.SpellDamageperInt += f;
        }
        public static void RemoveSpellDamageperInt(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.SpellDamageperInt -= f;
        }
        public static void AddDamagePerStrenght(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.DamagePerStrenght += f;
        }
        public static void RemoveDamagePerStrenght(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.DamagePerStrenght -= f;
        }
        public static void AddHealingMultipier(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.HealingMultipier += f;
        }
        public static void RemoveHealingMultipier(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.HealingMultipier -= f;
        }
        public static void AddMoveSpeed(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.MoveSpeed += f;
        }
        public static void RemoveMoveSpeed(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.MoveSpeed -= f;
        }

        //   public static void Add(float f)
        //{
        //    ChampionsOfForest.ModdedPlayer.instance. += f;
        //}
        //public static void Remove(float f)
        //{
        //    ChampionsOfForest.ModdedPlayer.instance. -= f;
        //}


        public static void PERMANENT_perkPointIncrease(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.PermanentBonusPerkPoints += (int)f;
        }
        public static void PERMANENT_expIncrease(float f)
        {
            ChampionsOfForest.ModdedPlayer.instance.AddFinalExperience((long)f);
        }






    }
}
