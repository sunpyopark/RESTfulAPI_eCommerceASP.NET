using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceNet.Data.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
           table: "product",
           columns: new[] { "ProductId", "Name", "Image", "Detail", "Price", "Shipping_Cost" },
           values: new object[] { 2, "SamsungS9", "www.samsung.com/samsungs9.jpg", "It is new Samsung Product", 1200, 45 });

            migrationBuilder.InsertData(
            table: "cart",
            columns: new[] { "CartId", "ProductId", "UserId", "Quantity" },
            values: new object[] { 2, 2, 2, 5 });

            migrationBuilder.InsertData(
            table: "user",
            columns: new[] { "UserId", "Email", "Password", "Shipping_address", "Billing_address", "Purchase_history" },
            values: new object[] { 2, "Simran@gmail.com", "12QYGEvv456", "Glen Forest", "Grove St", "OnePlus3" });

            migrationBuilder.InsertData(
            table: "comment",
            columns: new[] { "CommentId", "ProductId", "UserId", "Rating", "Image", "Description" },
            values: new object[] { 2, 2, 2, 6, "www.Oneplus.com/10.jpg", "I love this Mobile" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
          table: "product",
          columns: new[] { "ProductId", "Name", "Image", "Detail", "Price", "Shipping_Cost" },
          values: new object[] { 2, "SamsungS9", "www.samsung.com/samsungs9.jpg", "It is new Samsung Product", 1200, 45 });

            migrationBuilder.InsertData(
            table: "cart",
            columns: new[] { "CartId", "ProductId", "UserId", "Quantity" },
            values: new object[] { 2, 2, 2, 5 });

            migrationBuilder.InsertData(
            table: "user",
            columns: new[] { "UserId", "Email", "Password", "Shipping_address", "Billing_address", "Purchase_history" },
            values: new object[] { 2, "Simran@gmail.com", "12QYGEvv456", "Glen Forest", "Grove St", "OnePlus3" });

            migrationBuilder.InsertData(
            table: "comment",
            columns: new[] { "CommentId", "ProductId", "UserId", "Rating", "Image", "Description" },
            values: new object[] { 2, 2, 2, 6, "www.Oneplus.com/10.jpg", "I love this Mobile" });
        }
    }
}
