﻿using TGS.Interface.Components;

namespace TGS.Server.Components
{
	/// <inheritdoc />
	interface IStaticManager : ITGStatic
	{
		/// <summary>
		/// Creates symlinks for all static files to a <paramref name="path"/>
		/// </summary>
		/// <param name="path">The path to create symlinks in</param>
		void SymlinkTo(string path);

		/// <summary>
		/// Moves the Static directory to the first available Static_BACKUP path in the <see cref="Instance"/> then deleted the old directory if it exists and re-copies it from it's source
		/// </summary>
		void Recreate();
	}
}