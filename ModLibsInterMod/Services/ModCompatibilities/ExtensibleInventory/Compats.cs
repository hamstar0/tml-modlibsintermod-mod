using System;
using Terraria.ModLoader;
using ModLibsCore.Classes.Errors;


namespace ModLibsInterMod.Services.ModCompatibilities.ExtensibleInventoryCompat {
	/// <summary>
	/// Defines functions for applying any needed inter-mod compatibility adjustments for the Extensible Inventory mod (if active).
	/// </summary>
	public partial class ExtensibleInventoryCompatibilities {
		/// <summary></summary>
		public static void ApplyCompats() {
			Mod eiMod = ModLoader.GetMod( "ExtensibleInventory" );
			if( eiMod == null ) {
				throw new ModLibsException( "Missing Extensible Inventory mod." );
			}
			
			if( ModLoader.GetMod( "kRPG" ) != null ) {
				ExtensibleInventoryCompatibilities.kRPGCompat();
			}
		}
	}
}
