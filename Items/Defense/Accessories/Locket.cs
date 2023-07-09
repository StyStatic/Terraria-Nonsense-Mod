using Terraria.ModLoader;

namespace Mewd.Items.Defense.Accessories
{
	public class Locket : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Play Deltarune.");
		}

		public override void SetDefaults()
		{
			item.width = 42;
			item.height = 42;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 99;
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(3467, 100);
			modRecipe.AddTile(16);
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}
	}
}