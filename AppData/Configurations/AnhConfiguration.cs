﻿using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Configurations
{
    internal class AnhConfiguration : IEntityTypeConfiguration<Anh>
    {
        public void Configure(EntityTypeBuilder<Anh> builder)
        {
            builder.ToTable("Anh");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.DuongDan).HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int").IsRequired();
            builder.HasOne(x => x.MauSac).WithMany(x => x.Anhs).HasForeignKey(x => x.IDMauSac);
            builder.HasOne(x => x.SanPham).WithMany(x => x.Anhs).HasForeignKey(x => x.IDSanPham);
        }
    }
}
