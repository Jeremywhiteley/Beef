/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options
#pragma warning disable CA2227, CA1819 // Collection/Array properties should be read only; ignored, as acceptable for a DTO.

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
    /// Represents the Address entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Address : EntityBase, IEquatable<Address>
    {
        #region Privates

        private string? _street;
        private string? _city;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Street.
        /// </summary>
        [JsonProperty("street", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Street")]
        public string? Street
        {
            get => _street;
            set => SetValue(ref _street, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(Street)); 
        }

        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        [JsonProperty("city", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="City")]
        public string? City
        {
            get => _city;
            set => SetValue(ref _city, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(City)); 
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
            if (!(obj is Address val))
                return false;

            return Equals(val);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Address"/> is equal to the current <see cref="Address"/> by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public bool Equals(Address? obj)
        {
            if (((object)obj!) == ((object)this))
                return true;
            else if (((object)obj!) == null)
                return false;

            return base.Equals((object)obj)
                && Equals(Street, obj.Street)
                && Equals(City, obj.City);
        }

        /// <summary>
        /// Compares two <see cref="Address"/> types for equality.
        /// </summary>
        /// <param name="a"><see cref="Address"/> A.</param>
        /// <param name="b"><see cref="Address"/> B.</param>
        /// <returns><c>true</c> indicates equal; otherwise, <c>false</c> for not equal.</returns>
        public static bool operator == (Address? a, Address? b) => Equals(a, b);

        /// <summary>
        /// Compares two <see cref="Address"/> types for non-equality.
        /// </summary>
        /// <param name="a"><see cref="Address"/> A.</param>
        /// <param name="b"><see cref="Address"/> B.</param>
        /// <returns><c>true</c> indicates not equal; otherwise, <c>false</c> for equal.</returns>
        public static bool operator != (Address? a, Address? b) => !Equals(a, b);

        /// <summary>
        /// Returns a hash code for the <see cref="Address"/>.
        /// </summary>
        /// <returns>A hash code for the <see cref="Address"/>.</returns>
        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Street);
            hash.Add(City);
            return base.GetHashCode() ^ hash.ToHashCode();
        }
    
        #endregion
        
        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="Address"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="Address"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<Address>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="Address"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="Address"/> to copy from.</param>
        public void CopyFrom(Address from)
        {
             if (from == null)
                 throw new ArgumentNullException(nameof(from));

            CopyFrom((EntityBase)from);
            Street = from.Street;
            City = from.City;

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="Address"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="Address"/>.</returns>
        public override object Clone()
        {
            var clone = new Address();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="Address"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            Street = Cleaner.Clean(Street, StringTrim.UseDefault, StringTransform.UseDefault);
            City = Cleaner.Clean(City, StringTrim.UseDefault, StringTransform.UseDefault);

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
                return Cleaner.IsInitial(Street)
                    && Cleaner.IsInitial(City);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(Address from);

        #endregion
    } 
}

#pragma warning restore CA2227, CA1819
#pragma warning restore IDE0005
#nullable restore