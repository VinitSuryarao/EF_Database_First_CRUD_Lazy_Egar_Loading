//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Database_First
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MDSEntities : DbContext
    {
        public MDSEntities()
            : base("name=MDSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_Address> tb_Address { get; set; }
        public virtual DbSet<tb_Client> tb_Client { get; set; }
    
        public virtual ObjectResult<sp_ClientMaster_Result> sp_ClientMaster(string ps_Mode, Nullable<int> pn_ClientNo, string ps_ClientCode, string ps_ClientName)
        {
            var ps_ModeParameter = ps_Mode != null ?
                new ObjectParameter("Ps_Mode", ps_Mode) :
                new ObjectParameter("Ps_Mode", typeof(string));
    
            var pn_ClientNoParameter = pn_ClientNo.HasValue ?
                new ObjectParameter("Pn_ClientNo", pn_ClientNo) :
                new ObjectParameter("Pn_ClientNo", typeof(int));
    
            var ps_ClientCodeParameter = ps_ClientCode != null ?
                new ObjectParameter("Ps_ClientCode", ps_ClientCode) :
                new ObjectParameter("Ps_ClientCode", typeof(string));
    
            var ps_ClientNameParameter = ps_ClientName != null ?
                new ObjectParameter("Ps_ClientName", ps_ClientName) :
                new ObjectParameter("Ps_ClientName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ClientMaster_Result>("sp_ClientMaster", ps_ModeParameter, pn_ClientNoParameter, ps_ClientCodeParameter, ps_ClientNameParameter);
        }
    
        public virtual int sp_AddRecord(string ps_ClientCode, string ps_ClientName)
        {
            var ps_ClientCodeParameter = ps_ClientCode != null ?
                new ObjectParameter("Ps_ClientCode", ps_ClientCode) :
                new ObjectParameter("Ps_ClientCode", typeof(string));
    
            var ps_ClientNameParameter = ps_ClientName != null ?
                new ObjectParameter("Ps_ClientName", ps_ClientName) :
                new ObjectParameter("Ps_ClientName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddRecord", ps_ClientCodeParameter, ps_ClientNameParameter);
        }
    
        public virtual int sp_DeleteRecord(Nullable<int> pn_ClientNo)
        {
            var pn_ClientNoParameter = pn_ClientNo.HasValue ?
                new ObjectParameter("Pn_ClientNo", pn_ClientNo) :
                new ObjectParameter("Pn_ClientNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteRecord", pn_ClientNoParameter);
        }
    
        public virtual ObjectResult<tb_Client> sp_ReadRecord(Nullable<int> pn_ClientNo)
        {
            var pn_ClientNoParameter = pn_ClientNo.HasValue ?
                new ObjectParameter("Pn_ClientNo", pn_ClientNo) :
                new ObjectParameter("Pn_ClientNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tb_Client>("sp_ReadRecord", pn_ClientNoParameter);
        }
    
        public virtual ObjectResult<tb_Client> sp_ReadRecord(Nullable<int> pn_ClientNo, MergeOption mergeOption)
        {
            var pn_ClientNoParameter = pn_ClientNo.HasValue ?
                new ObjectParameter("Pn_ClientNo", pn_ClientNo) :
                new ObjectParameter("Pn_ClientNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tb_Client>("sp_ReadRecord", mergeOption, pn_ClientNoParameter);
        }
    
        public virtual int sp_UpdateRecord(Nullable<int> pn_ClientNo, string ps_ClientName)
        {
            var pn_ClientNoParameter = pn_ClientNo.HasValue ?
                new ObjectParameter("Pn_ClientNo", pn_ClientNo) :
                new ObjectParameter("Pn_ClientNo", typeof(int));
    
            var ps_ClientNameParameter = ps_ClientName != null ?
                new ObjectParameter("Ps_ClientName", ps_ClientName) :
                new ObjectParameter("Ps_ClientName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateRecord", pn_ClientNoParameter, ps_ClientNameParameter);
        }
    }
}
