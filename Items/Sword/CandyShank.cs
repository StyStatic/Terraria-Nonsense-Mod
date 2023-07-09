using Terraria.ID;
using Terraria.ModLoader;

namespace Mewd.Items.Sword
{
	public class CandyShank : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Candy Shank");
			Tooltip.SetDefault("The Power of Peppermint!");
		}

		public override void SetDefaults()
		{
			item.damage = 56;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 26;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 4f;
			item.value = 60000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(368);
			modRecipe.AddIngredient(3467, 20);
			modRecipe.AddTile(134);
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}
	}
}
