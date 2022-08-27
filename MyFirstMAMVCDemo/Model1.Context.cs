﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstMAMVCDemo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MyTestDBEntities : DbContext
    {
        public MyTestDBEntities()
            : base("name=MyTestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<TableLog> TableLogs { get; set; }
        public virtual DbSet<tblCourse> tblCourses { get; set; }
        public virtual DbSet<tblStudent> tblStudents { get; set; }
        public virtual DbSet<View_1> View_1 { get; set; }
    
        [DbFunction("MyTestDBEntities", "SplitString123")]
        public virtual IQueryable<SplitString123_Result> SplitString123(string input, string character)
        {
            var inputParameter = input != null ?
                new ObjectParameter("Input", input) :
                new ObjectParameter("Input", typeof(string));
    
            var characterParameter = character != null ?
                new ObjectParameter("Character", character) :
                new ObjectParameter("Character", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SplitString123_Result>("[MyTestDBEntities].[SplitString123](@Input, @Character)", inputParameter, characterParameter);
        }
    
        public virtual int CursorExample()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CursorExample");
        }
    
        public virtual int Sp_Demo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_Demo");
        }
    
        public virtual ObjectResult<SP_Insert_Result> SP_Insert(string courseName, Nullable<int> studentID)
        {
            var courseNameParameter = courseName != null ?
                new ObjectParameter("CourseName", courseName) :
                new ObjectParameter("CourseName", typeof(string));
    
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Insert_Result>("SP_Insert", courseNameParameter, studentIDParameter);
        }
    }
}
