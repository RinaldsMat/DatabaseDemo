﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebStore.Entities;

#nullable disable

namespace WebStore.Migrations
{
    [DbContext(typeof(learningassignment4Context))]
    [Migration("20250409175552_AddOrderTracking")]
    partial class AddOrderTracking
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.HasKey("CategoryId", "ProductId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "ProductId" }, "fk_pc_product");

                    b.ToTable("product_categories", (string)null);
                });

            modelBuilder.Entity("WebStore.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<string>("AddressType")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("address_type");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("country");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("postal_code");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("state");

                    b.Property<string>("Street")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("street");

                    b.HasKey("AddressId");

                    b.HasIndex(new[] { "CustomerId" }, "fk_addresses_customer");

                    b.ToTable("addresses", (string)null);
                });

            modelBuilder.Entity("WebStore.Entities.Carrier", b =>
                {
                    b.Property<int>("CarrierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CarrierName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("carrier_name");

                    b.Property<string>("ContactPhone")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("contact_phone");

                    b.Property<string>("ContactUrl")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("contact_url");

                    b.HasKey("CarrierId")
                        .HasName("carriers_pkey");

                    b.ToTable("carriers", (string)null);
                });

            modelBuilder.Entity("WebStore.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("category_name");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("parent_category_id");

                    b.HasKey("CategoryId");

                    b.HasIndex(new[] { "ParentCategoryId" }, "fk_categories_parent");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("WebStore.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("CustomerId");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("WebStore.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int>("BillingAddressId")
                        .HasColumnType("int")
                        .HasColumnName("billing_address_id");

                    b.Property<int?>("CarrierId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<DateTime?>("DeliveredDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("delivered_date");

                    b.Property<DateTime?>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("order_date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("OrderStatus")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("order_status");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("shipped_date");

                    b.Property<int>("ShippingAddressId")
                        .HasColumnType("int")
                        .HasColumnName("shipping_address_id");

                    b.Property<string>("TrackingNumber")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tracking_number");

                    b.HasKey("OrderId");

                    b.HasIndex("CarrierId");

                    b.HasIndex(new[] { "BillingAddressId" }, "fk_orders_billing_address");

                    b.HasIndex(new[] { "CustomerId" }, "fk_orders_customer");

                    b.HasIndex(new[] { "ShippingAddressId" }, "fk_orders_shipping_address");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("WebStore.Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<decimal?>("Discount")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("discount")
                        .HasDefaultValueSql("'0.00'");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<decimal?>("UnitPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("unit_price");

                    b.HasKey("OrderId", "ProductId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "ProductId" }, "fk_oi_product");

                    b.ToTable("order_items", (string)null);
                });

            modelBuilder.Entity("WebStore.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<decimal?>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("product_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("ProductId");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("WebStore.Entities.staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("staff_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone");

                    b.Property<int>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("store_id");

                    b.HasKey("StaffId");

                    b.HasIndex(new[] { "StoreId" }, "fk_staff_store");

                    b.ToTable("staff");
                });

            modelBuilder.Entity("WebStore.Entities.Stock", b =>
                {
                    b.Property<int>("StoreId")
                        .HasColumnType("int")
                        .HasColumnName("store_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int")
                        .HasColumnName("quantity_in_stock");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("StoreId", "ProductId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "ProductId" }, "fk_stocks_product");

                    b.ToTable("stocks", (string)null);
                });

            modelBuilder.Entity("WebStore.Entities.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("store_id");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("country");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("postal_code");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("store_name");

                    b.Property<string>("Street")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("street");

                    b.HasKey("StoreId");

                    b.ToTable("stores", (string)null);
                });

            modelBuilder.Entity("ProductCategory", b =>
                {
                    b.HasOne("WebStore.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_pc_category");

                    b.HasOne("WebStore.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_pc_product");
                });

            modelBuilder.Entity("WebStore.Entities.Address", b =>
                {
                    b.HasOne("WebStore.Entities.Customer", "Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_addresses_customer");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("WebStore.Entities.Category", b =>
                {
                    b.HasOne("WebStore.Entities.Category", "ParentCategory")
                        .WithMany("InverseParentCategory")
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_categories_parent");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("WebStore.Entities.Order", b =>
                {
                    b.HasOne("WebStore.Entities.Address", "BillingAddress")
                        .WithMany("OrderBillingAddresses")
                        .HasForeignKey("BillingAddressId")
                        .IsRequired()
                        .HasConstraintName("fk_orders_billing_address");

                    b.HasOne("WebStore.Entities.Carrier", "Carrier")
                        .WithMany("Orders")
                        .HasForeignKey("CarrierId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("WebStore.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("fk_orders_customer");

                    b.HasOne("WebStore.Entities.Address", "ShippingAddress")
                        .WithMany("OrderShippingAddresses")
                        .HasForeignKey("ShippingAddressId")
                        .IsRequired()
                        .HasConstraintName("fk_orders_shipping_address");

                    b.Navigation("BillingAddress");

                    b.Navigation("Carrier");

                    b.Navigation("Customer");

                    b.Navigation("ShippingAddress");
                });

            modelBuilder.Entity("WebStore.Entities.OrderItem", b =>
                {
                    b.HasOne("WebStore.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_oi_order");

                    b.HasOne("WebStore.Entities.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_oi_product");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebStore.Entities.staff", b =>
                {
                    b.HasOne("WebStore.Entities.Store", "Store")
                        .WithMany("staff")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_staff_store");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("WebStore.Entities.Stock", b =>
                {
                    b.HasOne("WebStore.Entities.Product", "Product")
                        .WithMany("Stocks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_stocks_product");

                    b.HasOne("WebStore.Entities.Store", "Store")
                        .WithMany("Stocks")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_stocks_store");

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("WebStore.Entities.Address", b =>
                {
                    b.Navigation("OrderBillingAddresses");

                    b.Navigation("OrderShippingAddresses");
                });

            modelBuilder.Entity("WebStore.Entities.Carrier", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebStore.Entities.Category", b =>
                {
                    b.Navigation("InverseParentCategory");
                });

            modelBuilder.Entity("WebStore.Entities.Customer", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebStore.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("WebStore.Entities.Product", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("WebStore.Entities.Store", b =>
                {
                    b.Navigation("Stocks");

                    b.Navigation("staff");
                });
#pragma warning restore 612, 618
        }
    }
}
