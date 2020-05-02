using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceNet.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "product",
            columns: new[] { "ProductId", "Name", "Image", "Detail", "Price", "Shipping_Cost" },
            values: new object[] { 1, "IPhone", "www.iphone.com/iphonex", "It is new Apple Product", 1500, 70 });

            migrationBuilder.InsertData(
            table: "cart",
            columns: new[] { "CartId", "ProductId", "UserId", "Quantity" },
            values: new object[] { 1, 1, 1, 7 });

            migrationBuilder.InsertData(
            table: "user",
            columns: new[] { "UserId", "Email", "Password", "Shipping_address", "Billing_address", "Purchase_history" },
            values: new object[] { 1, "Sukhchain@gmail.com", "12QYGEvv456", "University", "Weber St", "Samsung S10" });

            migrationBuilder.InsertData(
            table: "comment",
            columns: new[] { "CommentId", "ProductId", "UserId", "Rating", "Image", "Description" },
            values: new object[] { 1, 1, 1, 9, "www.Samsung.com/S10.jpg", "I love this Phone" });
        }
    

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "product",
            columns: new[] { "ProductId", "Name", "Image", "Detail", "Price", "Shipping_Cost" },
            values: new object[] { 1, "IPhone", "www.iphone.com/iphonex", "It is new Apple Product", 1500, 70 });

            migrationBuilder.InsertData(
            table: "cart",
            columns: new[] { "CartId", "ProductId", "UserId", "Quantity" },
            values: new object[] { 1, 1, 1, 7 });


            migrationBuilder.InsertData(
            table: "user",
            columns: new[] { "UserId", "Email", "Password", "Shipping_address", "Billing_address", "Purchase_history" },
            values: new object[] { 1, "Sukhchain@gmail.com", "12QYGEvv456", "University", "Weber St", "Samsung S10" });

            migrationBuilder.InsertData(
            table: "comment",
            columns: new[] { "CommentId", "ProductId", "UserId", "Rating", "Image", "Description" },
            values: new object[] { 1, 1, 1, 9, "www.Samsung.com/S10.jpg", "I love this Phone" });
        }
    }
}
