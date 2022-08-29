using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace AroFloSharp.Serialization.Models
{
    public class Location
    {
        [JsonProperty("locationid")]
        [XmlElement("locationid")]
        public string LocationId { get; set; }

        [JsonProperty("locationname")]
        [XmlElement("locationname")]
        public string LocationName { get; set; }

        [JsonProperty("gpslat")]
        [XmlElement("gpslat")]
        public double Latitude { get; set; }

        [JsonProperty("gpslong")]
        [XmlElement("gpslong")]
        public double Longitude { get; set; }

        [JsonProperty("postcode")]
        [XmlElement("postcode")]
        public string PostCode { get; set; }

        [JsonProperty("state")]
        [XmlElement("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        [XmlElement("country")]
        public string Country { get; set; }

        [JsonProperty("suburb")]
        [XmlElement("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("archived")]
        [XmlElement("archived")]
        [Obsolete("Use the IsArchived property.", false)]
        [Browsable(false)]
        public string ArchivedString { get; set; }

#pragma warning disable CS0618
        [JsonIgnore]
        [XmlIgnore]
        public bool IsArchived
        {
            get
            {
                if (string.IsNullOrEmpty(ArchivedString))
                {
                    return false;
                }

                switch (ArchivedString.ToLower())
                {
                    case "false":
                        return false;
                    case "true":
                        return true;
                    default:
                        throw new InvalidOperationException("ArchivedString was invalid.");
                }
            }
        }
#pragma warning restore CS0618

        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }
    }
}

// <location>
//   <locationid>JSYqKyBSXFggCg==</locationid>
//   <gpslat>-34.7293199477</gpslat>
//   <postcode>5110</postcode>
//   <sitecontact></sitecontact>
//   <state>SA</state>
//   <suburb>Burton</suburb>
//   <siteemail></siteemail>
//   <customfields></customfields>
//   <linkedto>
//   <linkedtoname>Boral Asphalt SA</linkedtoname>
//   <linkedtoid>JSc6Uy1QTFwgCg==</linkedtoid>
//   <linkedtotype>client</linkedtotype>
//   </linkedto>
//   <locationname>North HUB - Waterloo Corner Road</locationname>
//   <notes></notes>
//   <country>AUSTRALIA</country>
//   <gpslong>138.580861384</gpslong>
//   <address></address>
//   <documentsandphotos></documentsandphotos>
//   <archived>FALSE</archived>
//   <sitephone></sitephone>
// </location>
