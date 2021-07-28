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
			Mod mod = ModLoader.GetMod( "Messages" );
			if( mod == null ) {
				return false;
			}

			object parentMsg = mod.Call(
				"GetMessage",
				"Messages - Mod Info"
			);
			
			mod.Call(
				"AddMessage",
				"Inbox Message"+(InboxAPIMirrorsLibraries.InboxCounter+1),  //title
				msg,							//description
				ModLibsInterModMod.Instance,	//modOfOrigin
				which,							//id
				0,								//weight
				parentMsg,						//parentMessage
				true							//alertPlayer
			);

			InboxAPIMirrorsLibraries.InboxCounter++;

			return true;
		}


		////

		/// <summary>
		/// Indicates total unread messages.
		/// </summary>
		/// <returns>Note: Returns `null` if call was unsuccessful.</returns>
		public static int? CountUnreadMessages() {
			Mod mod = ModLoader.GetMod( "Messages" );
			if( mod != null ) {
				return (int)mod.Call( "GetUnreadMessageCount" );
			}

			return null;
		}


		////

		/// <summary>
		/// "Reads" latest message. Will trigger message's `onRun` function, if any.
		/// </summary>
		/// <returns>Note: Returns `null` if call was unsuccessful.</returns>
		public static string DequeueMessage() {
			throw new ModLibsException( "DequeueMessage not available yet." );
		}


		////

		/// <summary>
		/// Retrieves a given message by it's order position. Does not "read" the message.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="msg">The message. Returns `null` if no message found.</param>
		/// <returns>`true` if unread.</returns>
		public static bool? GetMessageAt( int pos, out string msg ) {
			throw new ModLibsException( "GetMessageAt not available yet." );
		}


		////

		/// <summary>
		/// Reads a given message.
		/// </summary>
		/// <param name="which">Identifier of message to read.</param>
		/// <param name="msg">The message. Returns `null` if no message found.</param>
		/// <returns>`true` if unread.</returns>
		public static bool? ReadMessage( string which, out string msg ) {
			throw new ModLibsException( "ReadMessage not available yet." );
		}
	}
}
