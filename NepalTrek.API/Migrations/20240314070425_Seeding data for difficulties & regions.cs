using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NepalTrek.API.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdatafordifficultiesregions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("20ce24f5-2c3b-4054-993d-5f50e4d842a3"), "Medium" },
                    { new Guid("96458856-4c06-4885-8e74-858340ef700e"), "Easy" },
                    { new Guid("9ecb8c2e-01e5-443c-aef3-46b00a4077c0"), "Hard" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("1c9aa80b-846c-42cd-a86b-af91cb3d22a0"), "MCT", "Manaslu Circuit Trek", "https://www.nepalfootprintholiday.com/wp-content/uploads/2022/06/manaslu-trek-photo.webp" },
                    { new Guid("4a44a12c-4ecc-44ad-9576-5b87d4c88776"), "MBC", "Machhapuchhare Base Camp", "https://www.environmentaltrekking.com/public/uploads/machhapuchhre-base-camp-trek1.jpg" },
                    { new Guid("9cc9aabe-887d-42dc-abc5-d01051ef1be9"), "LVT", "Langtang Valley Trek", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.magicalsummits.com%2Flangtang-valley-trek%2F&psig=AOvVaw0b8m52a_8I4LgEhEw2Hvyg&ust=1710485873372000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCMDy8cqW84QDFQAAAAAdAAAAABAE" },
                    { new Guid("eaf3f13e-a9ba-4b61-abf5-12e1bddc7e7c"), "EBC", "Everest Base Camp", "https://worldalpinetreks.com/uploads/2022/11/everest-base-camp-short-trek-scaled-e1641875466943.jpg" },
                    { new Guid("ffc0b296-6648-4aab-9dc3-4af94ef23dd0"), "ABC", "Annapurna Base Camp", "https://www.marveladventure.com/uploads/editors/Annapurna-Base-Camp-Trek-in-January-and-February-1.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("20ce24f5-2c3b-4054-993d-5f50e4d842a3"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("96458856-4c06-4885-8e74-858340ef700e"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("9ecb8c2e-01e5-443c-aef3-46b00a4077c0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1c9aa80b-846c-42cd-a86b-af91cb3d22a0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("4a44a12c-4ecc-44ad-9576-5b87d4c88776"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("9cc9aabe-887d-42dc-abc5-d01051ef1be9"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("eaf3f13e-a9ba-4b61-abf5-12e1bddc7e7c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ffc0b296-6648-4aab-9dc3-4af94ef23dd0"));
        }
    }
}
