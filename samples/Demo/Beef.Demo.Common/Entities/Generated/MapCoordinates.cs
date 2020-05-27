/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData;
using Newtonsoft.Json;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Represents the Map Coordinates entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MapCoordinates : EntityBase, IEquatable<MapCoordinates>
    {
        #region Privates

        private decimal _latitude;
        private decimal _longitude;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Latitude.
        /// </summary>
        [JsonProperty("latitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Latitude")]
        public decimal Latitude
        {
            get => _latitude;
            set => SetValue(ref _latitude, value, false, false, nameof(Latitude)); 
        }

        /// <summary>
        /// Gets or sets the Longitude.
        /// </summary>
        [JsonProperty("longitude", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Longitude")]
        public decimal Longitude
        {
            get => _longitude;
            set => SetValue(ref _longitude, value, false, false, nameof(Longitude)); 
        }

        #endregion

        #region IEquatable

        /// <summary>
        /// Determines whether the specified object is equal to the current object by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is MapCoordinates val))
                return false;

            return Equals(val);
        }

        /// <summary>
        /// Determines whether the specified <see cref="MapCoordinates"/> is equal to the current <see cref="MapCoordinates"/> by comparing the values of all the properties.
        /// </summary>
        /// <param name="value">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public bool Equals(MapCoordinates? value)
        {
            if (((object)value!) == ((object)this))
                return true;
            else if (((object)value!) == null)
                return false;

            return base.Equals((object)value)
                && Equals(Latitude, value.Latitude)
                && Equals(Longitude, value.Longitude);
        }

        /// <summary>
        /// Compares two <see cref="MapCoordinates"/> types for equality.
        /// </summary>
        /// <param name="a"><see cref="MapCoordinates"/> A.</param>
        /// <param name="b"><see cref="MapCoordinates"/> B.</param>
        /// <returns><c>true</c> indicates equal; otherwise, <c>false</c> for not equal.</returns>
        public static bool operator == (MapCoordinates? a, MapCoordinates? b) => Equals(a, b);

        /// <summary>
        /// Compares two <see cref="MapCoordinates"/> types for non-equality.
        /// </summary>
        /// <param name="a"><see cref="MapCoordinates"/> A.</param>
        /// <param name="b"><see cref="MapCoordinates"/> B.</param>
        /// <returns><c>true</c> indicates not equal; otherwise, <c>false</c> for equal.</returns>
        public static bool operator != (MapCoordinates? a, MapCoordinates? b) => !Equals(a, b);

        /// <summary>
        /// Returns a hash code for the <see cref="MapCoordinates"/>.
        /// </summary>
        /// <returns>A hash code for the <see cref="MapCoordinates"/>.</returns>
        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Latitude);
            hash.Add(Longitude);
            return base.GetHashCode() ^ hash.ToHashCode();
        }
    
        #endregion
        
        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="MapCoordinates"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="MapCoordinates"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<MapCoordinates>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="MapCoordinates"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="MapCoordinates"/> to copy from.</param>
        public void CopyFrom(MapCoordinates from)
        {
            CopyFrom((EntityBase)from);
            Latitude = from.Latitude;
            Longitude = from.Longitude;

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="MapCoordinates"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="MapCoordinates"/>.</returns>
        public override object Clone()
        {
            var clone = new MapCoordinates();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="MapCoordinates"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            Latitude = Cleaner.Clean(Latitude);
            Longitude = Cleaner.Clean(Longitude);

            OnAfterCleanUp();
        }
    
        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                return Cleaner.IsInitial(Latitude)
                    && Cleaner.IsInitial(Longitude);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(MapCoordinates from);

        #endregion
    } 
}

#nullable restore