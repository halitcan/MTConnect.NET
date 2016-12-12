﻿// Copyright (c) 2016 Feenux LLC, All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System.Xml;
using System.Xml.Serialization;

namespace MTConnect.v13.MTConnectAssets.CuttingTools
{
    public class CuttingItem
    {
        #region "Required"

        /// <summary>
        /// The number or numbers representing the individual cutting item or items on the tool.
        /// </summary>
        [XmlAttribute("indices")]
        public string Indices { get; set; }

        #endregion

        #region "Optional"

        /// <summary>
        /// The manufacturer identifier of this cutting item
        /// </summary>
        [XmlAttribute("itemId")]
        public string ItemId { get; set; }

        /// <summary>
        /// The manufacturers of the cutting item
        /// </summary>
        [XmlAttribute("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// The material composition for this cutting item
        /// </summary>
        [XmlAttribute("manufacturers")]
        public string Manufacturers { get; set; }

        #endregion

        /// <summary>
        /// A free-form description of the cutting item.
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// A free form description of the location on the cutting tool.
        /// </summary>
        [XmlElement("Locus")]
        public string Locus { get; set; }

        /// <summary>
        /// The life of this cutting item.
        /// </summary>
        [XmlElement("ItemLife")]
        public ItemLife ItemLife { get; set; }

        /// <summary>
        /// A collection of measurements relating to this cutting item.
        /// </summary>
        [XmlArray("Measurements")]
        [XmlArrayItem("Measurement", typeof(Measurement))]
        public Measurement[] Measurements { get; set; }
    }
}