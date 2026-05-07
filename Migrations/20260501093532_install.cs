    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    #nullable disable

    namespace TaskManager.Migrations
    {
        /// <inheritdoc />
        public partial class install : Migration
        {
            /// <inheritdoc />
            protected override void Up(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.CreateTable(
                    name: "Tasks",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                        TaskTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        TaskCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Tasks", x => x.Id);
                    });

                migrationBuilder.CreateTable(
                    name: "Users",
                    columns: table => new
                    {
                        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                        UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                        Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Users", x => x.Id);
                    });
            }

            /// <inheritdoc />
            protected override void Down(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.DropTable(
                    name: "Tasks");

                migrationBuilder.DropTable(
                    name: "Users");
            }
        }
    }
