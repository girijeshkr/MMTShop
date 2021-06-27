using System.Collections.Generic;

namespace MMTShop.Common
{
    public class FeaturedProductsSkuRanges
    {
        public List<SkuRanges> SkuRanges { get; set; }

    }
    public class SkuRanges
    {
        public int StartRange { get; set; }

        public int EndRange { get; set; }
    }

}
