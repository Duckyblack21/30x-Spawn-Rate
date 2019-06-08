using Terraria;
using Terraria.ModLoader;

namespace SpawnBoostMod
{
    class SpawnBoostMod : Mod
    {
        public SpawnBoostMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
            };
        }
    }

    class SpawnRateMultiplierGlobalNPC : GlobalNPC
    {
        static float multiplier = 5f;
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            spawnRate = (int)(spawnRate / 6 );
            maxSpawns = 60;
        }
    }
}