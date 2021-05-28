using System;
using Terraria.ModLoader;


namespace ModLibsInterMod.Libraries.Mods.APIMirrors.ModHelpersAPIMirrors {
	/// <summary>
	/// Provides a mirror of API bindings for ModHelpers mod's Inbox functionality. Respects weak references.
	/// </summary>
	public class InboxAPIMirrorsLibraries {
		/// <summary>
		/// Creates an inbox message. New unread messages will be visible by an inventory screen icon until opened.
		/// Past messages can be viewed.
		/// </summary>
		/// <param name="which">Identifier of a given message. Overrides messages with the given identifier.</param>
		/// <param name="msg">Message body. Plain text only, for now.</param>
		/// <param name="forceUnread">If the message has been read, this will force it to be "unread" again.</param>
		/// <param name="onRun">Code to activate when a given message is read. Parameter `true` if message is unread.</param>
		/// <returns>Note: Returns `true` if call was successful.</returns>
		public static bool SetMessage( string which, string msg, bool forceUnread, Action<bool> onRun = null ) {
			var mod = ModLoader.GetMod( "ModHelpers" );
			if( mod == null ) { return false; }

			InboxAPIMirrorsLibraries.SetMessage_WeakRef( which, msg, forceUnread, onRun );
			return true;
		}

		/// @private
		private static void SetMessage_WeakRef( string which, string msg, bool forceUnread, Action<bool> onRun = null ) {
			var mod = ModLoader.GetMod( "ModHelpers" );
			if( mod == null ) {
				return;
			}

//			ModHelpers.Services.Messages.Inbox.SetMessage( which, msg, forceUnread, onRun );
		}


		////

		/// <summary>
		/// Indicates total unread messages.
		/// </summary>
		/// <returns>Note: Returns `null` if call was unsuccessful.</returns>
		public static int? CountUnreadMessages() {
			var mod = ModLoader.GetMod( "ModHelpers" );
			if( mod == null ) { return null; }

			return InboxAPIMirrorsLibraries.CountUnreadMessages_WeakRef();
		}

		/// @private
		private static int? CountUnreadMessages_WeakRef() {
//			return ModHelpers.Services.Messages.Inbox.CountUnreadMessages();
return null;
		}


		////

		/// <summary>
		/// "Reads" latest message. Will trigger message's `onRun` function, if any.
		/// </summary>
		/// <returns>Note: Returns `null` if call was unsuccessful.</returns>
		public static string DequeueMessage() {
			var mod = ModLoader.GetMod( "ModHelpers" );
			if( mod == null ) { return null; }

			return InboxAPIMirrorsLibraries.DequeueMessage_WeakRef();
		}

		/// @private
		private static string DequeueMessage_WeakRef() {
//			return ModHelpers.Services.Messages.Inbox.DequeueMessage();
return null;
		}


		////

		/// <summary>
		/// Retrieves a given message by it's order position. Does not "read" the message.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="msg">The message. Returns `null` if no message found.</param>
		/// <returns>`true` if unread.</returns>
		public static bool? GetMessageAt( int pos, out string msg ) {
			var mod = ModLoader.GetMod( "ModHelpers" );
			if( mod == null ) {
				msg = "";
				return null;
			}

			return InboxAPIMirrorsLibraries.GetMessageAt_WeakRef( pos, out msg );
		}

		/// @private
		private static bool? GetMessageAt_WeakRef( int pos, out string msg ) {
//			return ModHelpers.Services.Messages.Inbox.GetMessageAt( pos, out msg );
msg = "";
return null;
		}


		////

		/// <summary>
		/// Reads a given message.
		/// </summary>
		/// <param name="which">Identifier of message to read.</param>
		/// <param name="msg">The message. Returns `null` if no message found.</param>
		/// <returns>`true` if unread.</returns>
		public static bool? ReadMessage( string which, out string msg ) {
			var mod = ModLoader.GetMod( "ModHelpers" );
			if( mod == null ) {
				msg = "";
				return null;
			}

			return InboxAPIMirrorsLibraries.ReadMessage_WeakRef( which, out msg );
		}

		/// @private
		private static bool? ReadMessage_WeakRef( string which, out string msg ) {
//			return ModHelpers.Services.Messages.Inbox.ReadMessage( which, out msg );
msg = "";
return null;
		}
	}
}
