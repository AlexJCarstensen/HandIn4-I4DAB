﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace ClassLibrary1
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Handin4DBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Handin4DBEntities object using the connection string found in the 'Handin4DBEntities' section of the application configuration file.
        /// </summary>
        public Handin4DBEntities() : base("name=Handin4DBEntities", "Handin4DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Handin4DBEntities object.
        /// </summary>
        public Handin4DBEntities(string connectionString) : base(connectionString, "Handin4DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Handin4DBEntities object.
        /// </summary>
        public Handin4DBEntities(EntityConnection connection) : base(connection, "Handin4DBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}
