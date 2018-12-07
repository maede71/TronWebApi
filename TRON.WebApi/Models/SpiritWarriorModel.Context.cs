﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TRON.WebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBSWEntities : DbContext
    {
        public DBSWEntities()
            : base("name=DBSWEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CUE_Cuentas> CUE_Cuentas { get; set; }
    
        public virtual int CrearCuenta(string nickname, string address, Nullable<int> puntos)
        {
            var nicknameParameter = nickname != null ?
                new ObjectParameter("nickname", nickname) :
                new ObjectParameter("nickname", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var puntosParameter = puntos.HasValue ?
                new ObjectParameter("puntos", puntos) :
                new ObjectParameter("puntos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CrearCuenta", nicknameParameter, addressParameter, puntosParameter);
        }
    
        public virtual ObjectResult<ListarClasificacion_Result> ListarClasificacion(Nullable<int> valorMaximoRegistros)
        {
            var valorMaximoRegistrosParameter = valorMaximoRegistros.HasValue ?
                new ObjectParameter("ValorMaximoRegistros", valorMaximoRegistros) :
                new ObjectParameter("ValorMaximoRegistros", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarClasificacion_Result>("ListarClasificacion", valorMaximoRegistrosParameter);
        }
    }
}
