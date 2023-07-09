using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Mewd.Items.Axe
{
	public class Poisonaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Poison Axe");
			Tooltip.SetDefault("ITS OVER 9000.");
		}

		public override void SetDefaults()
		{
			item.damage = 90;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 580;
			item.useAnimation = 15;
			item.axe = 30;
			item.useStyle = 1;
			item.knockBack = 6f;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(20, 300);
		}

		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(mod);
			modRecipe.AddIngredient(3467, 100);
			modRecipe.AddTile(16);
			modRecipe.SetResult(this);
			modRecipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(10))
			{
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
	}
}
