using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ApiFury.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Server = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    token = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyVillages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    IdVillage = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyVillages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyVillages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    TaskAttack = table.Column<string>(nullable: true),
                    TaskTransport = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Villages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PlayerName = table.Column<string>(nullable: true),
                    Villageid = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ArgX = table.Column<short>(nullable: false),
                    ArgY = table.Column<short>(nullable: false),
                    IsEmpty = table.Column<bool>(nullable: false),
                    Population = table.Column<short>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Villages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskAttacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    taskId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAttacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskAttacks_Tasks_taskId",
                        column: x => x.taskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "taskTransports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    taskId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taskTransports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_taskTransports_Tasks_taskId",
                        column: x => x.taskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attack",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Troop_1 = table.Column<int>(nullable: false),
                    Troop_2 = table.Column<int>(nullable: false),
                    Troop_3 = table.Column<int>(nullable: false),
                    Troop_4 = table.Column<int>(nullable: false),
                    Troop_5 = table.Column<int>(nullable: false),
                    Troop_6 = table.Column<int>(nullable: false),
                    Troop_7 = table.Column<int>(nullable: false),
                    Troop_8 = table.Column<int>(nullable: false),
                    Troop_9 = table.Column<int>(nullable: false),
                    SourceVillage = table.Column<string>(nullable: false),
                    DestinationVillage = table.Column<string>(nullable: false),
                    TaskAttackId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attack", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attack_TaskAttacks_TaskAttackId",
                        column: x => x.TaskAttackId,
                        principalTable: "TaskAttacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ResourceWood = table.Column<int>(nullable: false),
                    ResourceIron = table.Column<int>(nullable: false),
                    ResourceClay = table.Column<int>(nullable: false),
                    ResourceCrop = table.Column<int>(nullable: false),
                    FromVillage = table.Column<string>(nullable: false),
                    DestinationVillage = table.Column<string>(nullable: false),
                    TaskTransportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transport_taskTransports_TaskTransportId",
                        column: x => x.TaskTransportId,
                        principalTable: "taskTransports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attack_TaskAttackId",
                table: "Attack",
                column: "TaskAttackId");

            migrationBuilder.CreateIndex(
                name: "IX_MyVillages_UserId",
                table: "MyVillages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAttacks_taskId",
                table: "TaskAttacks",
                column: "taskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_taskTransports_taskId",
                table: "taskTransports",
                column: "taskId");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_TaskTransportId",
                table: "Transport",
                column: "TaskTransportId");

            migrationBuilder.CreateIndex(
                name: "IX_Villages_UserId",
                table: "Villages",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attack");

            migrationBuilder.DropTable(
                name: "MyVillages");

            migrationBuilder.DropTable(
                name: "Transport");

            migrationBuilder.DropTable(
                name: "Villages");

            migrationBuilder.DropTable(
                name: "TaskAttacks");

            migrationBuilder.DropTable(
                name: "taskTransports");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
