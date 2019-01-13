﻿using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using TehPers.CoreMod.Api.Drawing;
using TehPers.CoreMod.Api.Items;
using TehPers.CoreMod.Api.Json;

namespace TehPers.CoreMod.Api {
    public interface ICoreApi {
        /// <summary>The mod that owns this core API object.</summary>
        IMod Owner { get; }

        /// <summary>The drawing API which can be used to override draw calls to <see cref="SpriteBatch"/>.</summary>
        IDrawingApi Drawing { get; }

        /// <summary>The item API which can be used to create new items in the game.</summary>
        IItemApi Items { get; }

        /// <summary>The JSON API which can be used to create and read commented JSON files.</summary>
        IJsonApi Json { get; }
    }
}