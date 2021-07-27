using System;
using Terraria.ModLoader;
using ModLibsCore.Classes.Errors;


namespace ModLibsInterMod.Libraries.Mods.APIMirrors.ModHelpersAPIMirrors {
	/// <summary>
	/// Provides a mirror of API bindings for ModHelpers mod's Inbox functionality. Respects weak references.
	/// </summary>
	public class InboxAPIMirrorsLibraries {
		private static int InboxCounter = 0;



		////////////////

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
			var mod = ModLoader.GetMod( "Messages" );
			if( mod != null ) {
				InboxAPIMirrorsLibraries.SetMessage_WeakRef( which, msg, forceUnread, onRun );
			}

			return mod != null;
		}

		/// @private
		private static void SetMessage_WeakRef( string which, string msg, bool forceUnread, Action<bool> onRun = null ) {
			Messages.MessagesAPI.AddMessage(
				title: "Inbox Message"+(InboxAPIMirrorsLibraries.InboxCounter+1),
				description: msg,
				modOfOrigin: ModLibsInterModMod.Instance,
				result: out _,
				id: which,
				parent: Messages.MessagesAPI.ModInfoCategoryMsg
			);

			InboxAPIMirrorsLibraries.InboxCounter++;
		}


		////

		/// <summary>
		/// Indicates total unread messages.
		/// </summary>
		/// <returns>Note: Returns `null` if call was unsuccessful.</returns>
		public static int? CountUnreadMessages() {
			var mod = ModLoader.GetMod( "Messages" );
			if( mod != null ) {
				return InboxAPIMirrorsLibraries.CountUnreadMessages_WeakRef();
			}

			return null;
		}

		/// @private
		private static int CountUnreadMessages_WeakRef() {
			return Messages.MessagesAPI.GetUnreadMessageIDs().Count;
		}


		////

		/// <summary>
		/// "Reads" latest message. Will trigger message's `onRun` function, if any.
		/// </summary>
		/// <returns>Note: Returns `null` if call was unsuccessful.</returns>
		public static string DequeueMessage() {
			var mod = ModLoader.GetMod( "Messages" );
			if( mod == null ) { return null; }

			return InboxAPIMirrorsLibraries.DequeueMessage_WeakRef();
		}

		/// @private
		private static string DequeueMessage_WeakRef() {
			throw new ModLibsException( "DequeueMessage not available yet." );
//			return ModHelpers.Services.Messages.Inbox.DequeueMessage();
		}


		////

		/// <summary>
		/// Retrieves a given message by it's order position. Does not "read" the message.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="msg">The message. Returns `null` if no message found.</param>
		/// <returns>`true` if unread.</returns>
		public static bool? GetMessageAt( int pos, out string msg ) {
			var mod = ModLoader.GetMod( "Messages" );
			if( mod == null ) {
				msg = "";
				return null;
			}

			return InboxAPIMirrorsLibraries.GetMessageAt_WeakRef( pos, out msg );
		}

		/// @private
		private static bool? GetMessageAt_WeakRef( int pos, out string msg ) {
			throw new ModLibsException( "GetMessageAt not available yet." );
//			return ModHelpers.Services.Messages.Inbox.GetMessageAt( pos, out msg );
		}


		////

		/// <summary>
		/// Reads a given message.
		/// </summary>
		/// <param name="which">Identifier of message to read.</param>
		/// <param name="msg">The message. Returns `null` if no message found.</param>
		/// <returns>`true` if unread.</returns>
		public static bool? ReadMessage( string which, out string msg ) {
			var mod = ModLoader.GetMod( "Messages" );
			if( mod == null ) {
				msg = "";
				return null;
			}

			return InboxAPIMirrorsLibraries.ReadMessage_WeakRef( which, out msg );
		}

		/// @private
		private static bool? ReadMessage_WeakRef( string which, out string msg ) {
			throw new ModLibsException( "ReadMessage not available yet." );
		}
	}
}
