﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    class PSPeeringLocationObject
    {
        public string PeeringLocation { get; set; }

        public string Country { get; set; }

        public int? PeeringDBFacilityId { get; set; }

        public string PeeringDBFacilityLink { get; set; }

        public IList<PSPeeringBandwidthOffer> BandwidthOffers { get; set; }

        public string ExchangeName { get; set; }

        public string MicrosoftIPv4Address { get; set; }

        public string MicrosoftIPv6Address { get; set; }

        public string FacilityIPv4Prefix { get; set; }

        public string FacilityIPv6Prefix { get; set; }

        public string Address { get; set; }

        public PSPeeringLocationObject(PSPeeringLocation location, int i = 0)
        {
            if (location.Direct != null && location.Kind == "Direct")
            {
                this.PeeringDBFacilityId = location.Direct.PeeringFacilities[i].PeeringDBFacilityId;
                this.PeeringDBFacilityLink = location.Direct.PeeringFacilities[i].PeeringDBFacilityLink;
                this.BandwidthOffers = location.Direct.BandwidthOffers;
                this.Country = location.Country;
                this.PeeringLocation = location.Name;
                this.Address = location.Direct.PeeringFacilities[i].Address;
            }

            if (location.Exchange != null && location.Kind == "Exchange")
            {
                this.ExchangeName = location.Exchange.PeeringFacilities[i].ExchangeName;
                this.PeeringDBFacilityId = location.Exchange.PeeringFacilities[i].PeeringDBFacilityId;
                this.PeeringDBFacilityLink = location.Exchange.PeeringFacilities[i].PeeringDBFacilityLink;
                this.MicrosoftIPv4Address = location.Exchange.PeeringFacilities[i].MicrosoftIPv4Address;
                this.MicrosoftIPv6Address = location.Exchange.PeeringFacilities[i].MicrosoftIPv6Address;
                this.FacilityIPv4Prefix = location.Exchange.PeeringFacilities[i].FacilityIPv4Prefix;
                this.FacilityIPv6Prefix = location.Exchange.PeeringFacilities[i].FacilityIPv6Prefix;
                this.Country = location.Country;
                this.PeeringLocation = location.Name;
            }
        }
    }
}