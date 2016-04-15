namespace StardewHealthRegen
{
    using StardewModdingAPI;
    using StardewModdingAPI.Events;

    using StardewValley;

    public class HealthRegen : Mod
    {
        public override void Entry(params object[] objects)
        {
            GameEvents.OneSecondTick += GameEvents_OneSecondTick;
        }

        private static void GameEvents_OneSecondTick(object sender, System.EventArgs e)
        {
            if (Game1.player == null || !Game1.hasLoadedGame)
                return;

            if (Game1.player.health < Game1.player.maxHealth)
            {
                Game1.player.health += 1;
            }
        }
    }
}
