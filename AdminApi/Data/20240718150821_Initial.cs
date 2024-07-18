using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogHistory",
                columns: table => new
                {
                    LogId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogCode = table.Column<string>(nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    LogInTime = table.Column<DateTime>(nullable: false),
                    LogOutTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogHistory", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(nullable: false),
                    MenuTitle = table.Column<string>(maxLength: 100, nullable: false),
                    URL = table.Column<string>(maxLength: 500, nullable: true),
                    IsSubMenu = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    IconClass = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroup",
                columns: table => new
                {
                    MenuGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGroupName = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroup", x => x.MenuGroupID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroupWiseMenuMapping",
                columns: table => new
                {
                    MenuGroupWiseMenuMappingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGroupId = table.Column<int>(nullable: false),
                    MenuId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroupWiseMenuMapping", x => x.MenuGroupWiseMenuMappingId);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 100, nullable: false),
                    RoleDesc = table.Column<string>(maxLength: 500, nullable: true),
                    MenuGroupId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    ImagePath = table.Column<string>(maxLength: 500, nullable: true),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    LastPasswordChangeDate = table.Column<DateTime>(nullable: true),
                    PasswordChangedBy = table.Column<int>(nullable: true),
                    IsPasswordChange = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuID", "AddedBy", "DateAdded", "IconClass", "IsActive", "IsMigrationData", "IsSubMenu", "LastUpdatedBy", "LastUpdatedDate", "MenuTitle", "ParentID", "SortOrder", "URL" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 18, 20, 38, 20, 141, DateTimeKind.Local).AddTicks(7285), "fas fa-home", true, true, 0, null, null, "Dashboard", 0, 1, "/DashBoard/Index" },
                    { 10, 1, new DateTime(2024, 7, 18, 20, 38, 20, 141, DateTimeKind.Local).AddTicks(9270), "", true, true, 0, null, null, "Change Password", 9, 0, "/User/ChangePassword" },
                    { 8, 1, new DateTime(2024, 7, 18, 20, 38, 20, 141, DateTimeKind.Local).AddTicks(9263), "", true, true, 0, null, null, "Profile", 5, 0, "/User/UserProfile" },
                    { 7, 1, new DateTime(2024, 7, 18, 20, 38, 20, 141, DateTimeKind.Local).AddTicks(9260), "", true, true, 0, null, null, "Role List", 5, 0, "/User/RoleList" },
                    { 6, 1, new DateTime(2024, 7, 18, 20, 38, 20, 141, DateTimeKind.Local).AddTicks(9257), "", true, true, 0, null, null, "User List", 5, 0, "/User/UserList" },
                    { 9, 1, new DateTime(2024, 7, 18, 20, 38, 20, 141, DateTimeKind.Local).AddTicks(9267), "fas fa-wrench", true, true, 1, null, null, "Settings", 0, 4, "" },
                    { 4, 1, new DateTime(2024, 7, 18, 20, 38, 20, 141, DateTimeKind.Local).AddTicks(9250), "", true, true, 0, null, null, "Menu Group List", 2, 0, "/Menu/MenuGroupList" },
                    { 3, 1, new DateTime(2024, 7, 18, 20, 38, 20, 141, DateTimeKind.Local).AddTicks(9245), "", true, true, 0, null, null, "Menu List", 2, 0, "/Menu/MenuList" },
                    { 2, 1, new DateTime(2024, 7, 18, 20, 38, 20, 141, DateTimeKind.Local).AddTicks(9232), "fas fa-ellipsis-v", true, true, 1, null, null, "Menu", 0, 2, "" },
                    { 5, 1, new DateTime(2024, 7, 18, 20, 38, 20, 141, DateTimeKind.Local).AddTicks(9253), "fas fa-user", true, true, 1, null, null, "User", 0, 3, "" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroup",
                columns: new[] { "MenuGroupID", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "LastUpdatedBy", "LastUpdatedDate", "MenuGroupName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 18, 20, 38, 20, 127, DateTimeKind.Local).AddTicks(4683), true, true, null, null, "Super Admin Group" },
                    { 2, 1, new DateTime(2024, 7, 18, 20, 38, 20, 130, DateTimeKind.Local).AddTicks(762), true, true, null, null, "User Group" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroupWiseMenuMapping",
                columns: new[] { "MenuGroupWiseMenuMappingId", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "MenuGroupId", "MenuId" },
                values: new object[,]
                {
                    { 7, 1, new DateTime(2024, 7, 18, 20, 38, 20, 145, DateTimeKind.Local).AddTicks(4040), true, true, 1, 10 },
                    { 10, 1, new DateTime(2024, 7, 18, 20, 38, 20, 145, DateTimeKind.Local).AddTicks(4050), true, true, 2, 10 },
                    { 9, 1, new DateTime(2024, 7, 18, 20, 38, 20, 145, DateTimeKind.Local).AddTicks(4047), true, true, 2, 8 },
                    { 8, 1, new DateTime(2024, 7, 18, 20, 38, 20, 145, DateTimeKind.Local).AddTicks(4043), true, true, 2, 1 },
                    { 6, 1, new DateTime(2024, 7, 18, 20, 38, 20, 145, DateTimeKind.Local).AddTicks(4036), true, true, 1, 8 },
                    { 1, 1, new DateTime(2024, 7, 18, 20, 38, 20, 145, DateTimeKind.Local).AddTicks(2017), true, true, 1, 1 },
                    { 4, 1, new DateTime(2024, 7, 18, 20, 38, 20, 145, DateTimeKind.Local).AddTicks(4029), true, true, 1, 6 },
                    { 3, 1, new DateTime(2024, 7, 18, 20, 38, 20, 145, DateTimeKind.Local).AddTicks(4024), true, true, 1, 4 },
                    { 2, 1, new DateTime(2024, 7, 18, 20, 38, 20, 145, DateTimeKind.Local).AddTicks(4009), true, true, 1, 3 },
                    { 5, 1, new DateTime(2024, 7, 18, 20, 38, 20, 145, DateTimeKind.Local).AddTicks(4033), true, true, 1, 7 }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleId", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "LastUpdatedBy", "LastUpdatedDate", "MenuGroupId", "RoleDesc", "RoleName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 18, 20, 38, 20, 134, DateTimeKind.Local).AddTicks(7230), true, true, null, null, 1, null, "Admin" },
                    { 2, 1, new DateTime(2024, 7, 18, 20, 38, 20, 134, DateTimeKind.Local).AddTicks(9173), true, true, null, null, 2, null, "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AddedBy", "DateAdded", "DateOfBirth", "Email", "FullName", "ImagePath", "IsActive", "IsMigrationData", "IsPasswordChange", "LastPasswordChangeDate", "LastUpdatedBy", "LastUpdatedDate", "Mobile", "Password", "PasswordChangedBy", "UserName", "UserRoleId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 18, 20, 38, 20, 137, DateTimeKind.Local).AddTicks(4459), null, null, "Appman", null, true, true, false, null, null, null, null, "Appman@2019", null, "developer", 1 },
                    { 2, 1, new DateTime(2024, 7, 18, 20, 38, 20, 137, DateTimeKind.Local).AddTicks(7691), null, null, "Helen Smith", null, true, true, false, null, null, null, null, "user@2020", null, "user@2020", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogHistory");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "MenuGroup");

            migrationBuilder.DropTable(
                name: "MenuGroupWiseMenuMapping");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
