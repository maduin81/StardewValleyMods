﻿using StardewValley;
using TehPers.CoreMod.Api.Weighted;
using TehPers.FishingOverhaul.Api;

namespace TehPers.FishingOverhaul.Configs {
    public class WeightedFishData : IWeighted {
        public int Fish { get; }
        public IFishData Data { get; }
        public Farmer Who { get; }

        public WeightedFishData(int fish, IFishData data, Farmer who) {
            this.Fish = fish;
            this.Data = data;
            this.Who = who;
        }

        public double GetWeight() {
            return this.Data.GetWeight(this.Who);
        }

    }
}
