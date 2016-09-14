﻿using System;
using System.Reflection;

namespace ALinq.Mapping
{
    /// <summary>
    /// Represents the mapping between a field or a property of a domain object into a column of a database table.
    /// </summary>
    public abstract class MetaDataMember
    {
        /// <summary>
        /// Initializes a new instance of the ALinq.Mapping.MetaDataMember class.
        /// </summary>
        protected MetaDataMember()
        {
        }

        /// <summary>
        /// Specifies whether this member is declared by the specified type.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns>true if this member is declared by the specified type; otherwise, false.</returns>
        public abstract bool IsDeclaredBy(MetaType type);

        /// <summary>
        /// Gets the ALinq.Mapping.MetaAssociation that corresponds to this member.
        /// </summary>
        /// <returns>
        /// The corresponding ALinq.Mapping.MetaAssociation if one exists; otherwise, null.
        /// </returns>
        public abstract MetaAssociation Association { get; }

        /// <summary>
        /// Gets the read-back behavior for this member for insert and update operations.
        /// </summary>
        /// <returns>
        /// An ALinq.Mapping.AutoSync enumeration.
        /// </returns>
        public abstract AutoSync AutoSync { get; }

        /// <summary>
        /// Gets whether the value of this member can be assigned the null value.
        /// </summary>
        /// <returns>
        /// true if this member can be assigned the null value; otherwise, false.
        /// </returns>
        public abstract bool CanBeNull { get; }

        /// <summary>
        /// Gets the type of the corresponding database column.
        /// </summary>
        /// <returns>
        /// The type of the database column as a string.
        /// </returns>
        public abstract string DbType { get; }

        /// <summary>
        /// Gets the ALinq.Mapping.MetaType that contains this data member.
        /// </summary>
        /// <returns>
        /// The meta-type that contains the current member.
        /// </returns>
        public abstract MetaType DeclaringType { get; }

        /// <summary>
        /// Gets the accessor that is used to get and set the deferred source of this member.
        /// </summary>
        /// <returns>
        /// The accessor used to access the deferred source for this member.
        /// </returns>
        public abstract MetaAccessor DeferredSourceAccessor { get; }

        /// <summary>
        /// Gets the accessor that is used to get and set the deferred value of this member (without causing fetch).
        /// </summary>
        /// <returns>
        /// The accessor used to access the deferred value for this member.
        /// </returns>
        public abstract MetaAccessor DeferredValueAccessor { get; }

        /// <summary>
        /// Gets the expression that defines a computed column.
        /// </summary>
        /// <returns>
        /// The expression for the computed column as a string.
        /// </returns>
        public abstract string Expression { get; }

        /// <summary>
        /// Gets whether this member defines an association relationship.
        /// </summary>
        /// <returns>
        /// true if this member defines an association relationship; otherwise, false.
        /// </returns>
        public abstract bool IsAssociation { get; }

        /// <summary>
        /// Gets whether this member is automatically generated by the database.
        /// </summary>
        /// <returns>
        /// true if this member is automatically generated by the database; otherwise false.
        /// </returns>
        public abstract bool IsDbGenerated { get; }

        /// <summary>
        /// Gets whether the default behavior is to load this member on a deferred basis.
        /// </summary>
        /// <returns>
        /// true if this member loaded on a deferred basis by default; otherwise, false.
        /// </returns>
        public abstract bool IsDeferred { get; }

        /// <summary>
        /// Gets whether this member represents the inheritance discriminator.
        /// </summary>
        /// <returns>
        /// true if this member represents the inheritance discriminator; otherwise, false.
        /// </returns>
        public abstract bool IsDiscriminator { get; }

        /// <summary>
        /// Gets whether this member is mapped to a column (or constraint).
        /// </summary>
        /// <returns>
        /// true if this member is mapped to a column (or constraint); otherwise, false.
        /// </returns>
        public abstract bool IsPersistent { get; }

        /// <summary>
        /// Gets whether this member is part of the type's identity.
        /// </summary>
        /// <returns>
        /// true if this member is part of the type's identity; otherwise, false.
        /// </returns>
        public abstract bool IsPrimaryKey { get; }

        /// <summary>
        /// Gets whether this member represents the row version or timestamp.
        /// </summary>
        /// <returns>
        /// true if this member represents the row version or timestamp; otherwise, false.
        /// </returns>
        public abstract bool IsVersion { get; }

        /// <summary>
        /// Gets the ALinq.DataContext method that is used to perform load operations.
        /// </summary>
        /// <returns>
        /// The load method as System.Reflection.MethodInfo.
        /// </returns>
        public abstract MethodInfo LoadMethod { get; }

        /// <summary>
        /// Gets the name of the column (or constraint) in the database.
        /// </summary>
        /// <returns>
        /// The name of the column (or constraint) as a string.
        /// </returns>
        public abstract string MappedName { get; }

        /// <summary>
        /// Gets the underlying System.Reflection.MemberInfo.
        /// </summary>
        public abstract MemberInfo Member { get; }

        /// <summary>
        /// Gets the accessor that is used to get or set the value of this member.
        /// </summary>
        /// <returns>
        /// The accessor.
        /// </returns>
        public abstract MetaAccessor MemberAccessor { get; }

        /// <summary>
        /// Gets the name of the member, same as the System.Reflection.MemberInfo name.
        /// </summary>
        /// <returns>
        /// The name, same as the System.Reflection.MemberInfo name.
        /// </returns>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the ordinal position of this member in the default layout of query results.
        /// </summary>
        /// <returns>
        /// The ordinal position.
        /// </returns>
        public abstract int Ordinal { get; }

        /// <summary>
        /// Gets the accessor that is used to get or set the storage value of this member.
        /// </summary>
        /// <returns>
        /// The accessor for the storage value of this member.
        /// </returns>
        public abstract MetaAccessor StorageAccessor { get; }

        /// <summary>
        /// Gets the member that stores the data for this member.
        /// </summary>
        /// <returns>
        /// The storage member.
        /// </returns>
        public abstract MemberInfo StorageMember { get; }

        /// <summary>
        /// Gets the type of this member.
        /// </summary>
        /// <returns>
        /// The type of the current member.
        /// </returns>
        public abstract Type Type { get; }

        /// <summary>
        /// Gets the optimistic concurrency check policy for this member.
        /// </summary>
        /// <returns>
        /// An ALinq.Mapping.UpdateCheck enum.
        /// </returns>
        public abstract UpdateCheck UpdateCheck { get; }
    }
}