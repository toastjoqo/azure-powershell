// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support
{

    /// <summary>The data sync option.</summary>
    public partial struct DataSyncStatus :
        System.IEquatable<DataSyncStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DataSyncStatus ForDownTime = @"ForDownTime";

        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DataSyncStatus ForSynchronization = @"ForSynchronization";

        /// <summary>the value for an instance of the <see cref="DataSyncStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DataSyncStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DataSyncStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DataSyncStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DataSyncStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DataSyncStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DataSyncStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DataSyncStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DataSyncStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DataSyncStatus && Equals((DataSyncStatus)obj);
        }

        /// <summary>Returns hashCode for enum DataSyncStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DataSyncStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DataSyncStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DataSyncStatus" />.</param>

        public static implicit operator DataSyncStatus(string value)
        {
            return new DataSyncStatus(value);
        }

        /// <summary>Implicit operator to convert DataSyncStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DataSyncStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DataSyncStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DataSyncStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DataSyncStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DataSyncStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DataSyncStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DataSyncStatus e1, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DataSyncStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}