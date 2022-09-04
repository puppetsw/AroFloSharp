using System;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models
{
    public class Location : AroFloObjectBase
    {
        [JsonPropertyName("locationid")]
        [XmlElement("locationid")]
        public string LocationId { get; set; }

        [JsonPropertyName("locationname")]
        [XmlElement("locationname")]
        public string LocationName { get; set; }

        [JsonPropertyName("gpslat")]
        [XmlElement("gpslat")]
        public double Latitude { get; set; }

        [JsonPropertyName("gpslong")]
        [XmlElement("gpslong")]
        public double Longitude { get; set; }

        [JsonPropertyName("postcode")]
        [XmlElement("postcode")]
        public string PostCode { get; set; }

        [JsonPropertyName("state")]
        [XmlElement("state")]
        public string State { get; set; }

        [JsonPropertyName("country")]
        [XmlElement("country")]
        public string Country { get; set; }

        [JsonPropertyName("suburb")]
        [XmlElement("suburb")]
        public string Suburb { get; set; }

        [JsonPropertyName("archived")]
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

        [JsonPropertyName("address")]
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
