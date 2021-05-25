using System;
using Terraria;
using Terraria.ModLoader;
using ModLibsCore.Libraries.Debug;


namespace ModLibsInterMod {
	/// @private
	partial class ModLibsInterModMod : Mod {
		public static ModLibsInterModMod Instance { get; private set; }



		////////////////

		public override void Load() {
			ModLibsInterModMod.Instance = this;
		}

		////

		public override void Unload() {
			try {
				LogLibraries.Alert( "Unloading mod..." );
			} catch { }

			ModLibsInterModMod.Instance = null;
		}
	}
}
