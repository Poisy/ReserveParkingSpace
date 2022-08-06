using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddGeneralSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "By", "From", "Shift", "Space", "To" },
                values: new object[,]
                {
                    { new Guid("0e02bf96-cefb-489a-b6ec-bbe24ad83bb5"), new Guid("4c33537b-e856-463b-811e-e8e059750123"), new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), 1, 13, new DateTime(2022, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8cee9c31-fc33-4b1e-b5c8-5867ca342bc9"), new Guid("4c33537b-e856-463b-811e-e8e059750126"), new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, 14, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ba8a454f-6296-4bf8-94dd-77d33beaac0f"), new Guid("4c33537b-e856-463b-811e-e8e059750135"), new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, 4, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("76219002-37b4-455a-b1ec-64fc5fc76471"), new Guid("4c33537b-e856-463b-811e-e8e059750133"), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, 4, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f3e5eebd-8516-47ca-ba5c-9ffa0c112e65"), new Guid("4c33537b-e856-463b-811e-e8e059750102"), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 3, 14, new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("318fc089-aaa9-499f-9cb9-032763e4bfbd"), new Guid("4c33537b-e856-463b-811e-e8e059750132"), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 3, 16, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("34a491cf-ab2a-4bed-8e29-d4a603ca7678"), new Guid("4c33537b-e856-463b-811e-e8e059750131"), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 1, 20, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("bc80c451-c41f-4c54-a255-bddb0b5cedc1"), new Guid("4c33537b-e856-463b-811e-e8e059750100"), new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), 2, 13, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("5270d631-b791-4fb2-8f46-fd34fef92f25"), new Guid("4c33537b-e856-463b-811e-e8e059750137"), new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), 3, 12, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3340e186-8ea4-4bb9-8844-c049dca78e1b"), new Guid("4c33537b-e856-463b-811e-e8e059750104"), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, 6, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("227030ae-e9d6-4381-a3c6-60fb594f90d4"), new Guid("4c33537b-e856-463b-811e-e8e059750121"), new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, 14, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("42afde00-0d7b-4a4a-867b-64b63e45fa6b"), new Guid("4c33537b-e856-463b-811e-e8e059750136"), new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), 3, 2, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3539862d-c6c6-4fa5-9201-33f28f3fb95a"), new Guid("4c33537b-e856-463b-811e-e8e059750113"), new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, 19, new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0bb27d95-9112-400b-a0cb-80bcd4692043"), new Guid("4c33537b-e856-463b-811e-e8e059750138"), new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, 4, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("9a1a7e48-6363-4e84-aafd-d03707850a49"), new Guid("4c33537b-e856-463b-811e-e8e059750128"), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 3, 8, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b9ffcf1a-2116-41d3-bd96-87cf15b963a9"), new Guid("4c33537b-e856-463b-811e-e8e059750142"), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, 9, new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a00e7a40-ebb2-4b52-8ad4-78b400c3b25b"), new Guid("4c33537b-e856-463b-811e-e8e059750115"), new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, 15, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("960198f0-d82e-42db-b1dc-c53f24927cb0"), new Guid("4c33537b-e856-463b-811e-e8e059750106"), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), 1, 14, new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("54300f33-068b-4691-9a84-1d30be9ef8c0"), new Guid("4c33537b-e856-463b-811e-e8e059750146"), new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), 2, 2, new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("09daa148-b3bc-40d4-bdae-ea783b9c97a9"), new Guid("4c33537b-e856-463b-811e-e8e059750122"), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 1, 11, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("40ba4eda-a227-49a8-a2a7-ce79b56252b9"), new Guid("4c33537b-e856-463b-811e-e8e059750144"), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), 2, 8, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7f943342-bb5e-4fa8-befb-b165edb0544a"), new Guid("4c33537b-e856-463b-811e-e8e059750148"), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 1, 6, new DateTime(2022, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2636530b-2f8e-4462-97bc-b7eab1357ad3"), new Guid("4c33537b-e856-463b-811e-e8e059750139"), new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 2, 2, new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("fc58c834-859b-4dd7-a634-2137099d4ba5"), new Guid("4c33537b-e856-463b-811e-e8e059750145"), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), 1, 8, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("d066996a-7b69-4c01-837e-17810f310d37"), new Guid("4c33537b-e856-463b-811e-e8e059750116"), new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, 11, new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ebd338bd-c00c-44d4-948f-0861a5b7bfe6"), new Guid("4c33537b-e856-463b-811e-e8e059750141"), new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, 6, new DateTime(2022, 9, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f17a04b9-799d-4727-a8b4-e3b93ac5c906"), new Guid("4c33537b-e856-463b-811e-e8e059750112"), new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), 1, 3, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("fe96babd-40e5-495c-9833-b3c3bb90375a"), new Guid("4c33537b-e856-463b-811e-e8e059750120"), new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, 12, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f94c4cc6-050b-4033-8f51-7cd3db6c87f7"), new Guid("4c33537b-e856-463b-811e-e8e059750107"), new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), 1, 1, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f18cce82-95f9-4eb2-a906-f6c596e9ca9e"), new Guid("4c33537b-e856-463b-811e-e8e059750134"), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 2, 6, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7037f92d-8032-4da5-872c-7b96fb851ab6"), new Guid("4c33537b-e856-463b-811e-e8e059750127"), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 2, 19, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("433dfacb-5ecc-4d25-88a1-0706ee32fa27"), new Guid("4c33537b-e856-463b-811e-e8e059750119"), new DateTime(2022, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, 9, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("081c27e3-d9cb-451b-b514-8c3f512fb195"), new Guid("4c33537b-e856-463b-811e-e8e059750129"), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, 8, new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("bf7c19da-7bc5-4c91-87b4-ab8a286b0b9f"), new Guid("4c33537b-e856-463b-811e-e8e059750124"), new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), 3, 1, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b850aa6c-f1b8-4fce-b070-770b3a9ae089"), new Guid("4c33537b-e856-463b-811e-e8e059750101"), new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 1, 12, new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7d00dc53-bc23-407e-8521-e2839e391d2b"), new Guid("4c33537b-e856-463b-811e-e8e059750109"), new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 2, 16, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("641d4b01-0954-4c19-9fa0-c6194ab218e6"), new Guid("4c33537b-e856-463b-811e-e8e059750108"), new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 3, 3, new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a9c56b44-13b5-406e-8671-7dee35b5b022"), new Guid("4c33537b-e856-463b-811e-e8e059750111"), new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), 2, 20, new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7e24e3fe-fd1e-44fc-86e9-7ba82c3e9e7c"), new Guid("4c33537b-e856-463b-811e-e8e059750114"), new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, 10, new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0624fc3a-0d96-4e2a-86a2-a899a91121b2"), new Guid("4c33537b-e856-463b-811e-e8e059750117"), new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, 15, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("52fb5e08-9a0d-413a-83fa-98eb82d9f68d"), new Guid("4c33537b-e856-463b-811e-e8e059750149"), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), 3, 17, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2cd312b6-fab5-44dc-acdc-712b45c24b02"), new Guid("4c33537b-e856-463b-811e-e8e059750110"), new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), 1, 16, new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "By", "From", "Shift", "Space", "To" },
                values: new object[,]
                {
                    { new Guid("86939f7a-abd8-48e3-b57d-650a6fcf51ac"), new Guid("4c33537b-e856-463b-811e-e8e059750125"), new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), 1, 6, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("62d0d91a-7456-40df-8f5f-16016e764348"), new Guid("4c33537b-e856-463b-811e-e8e059750147"), new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), 2, 1, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8b98dc6b-c4cd-4e58-b97f-d6a6c2cbb4f7"), new Guid("4c33537b-e856-463b-811e-e8e059750105"), new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), 3, 18, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a94f3495-8696-400a-81c3-3c7a1d4c5fb3"), new Guid("4c33537b-e856-463b-811e-e8e059750118"), new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, 9, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("5803f4c9-84cd-411e-a052-72c4fde616a1"), new Guid("4c33537b-e856-463b-811e-e8e059750103"), new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), 3, 5, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("15ea7fca-ae70-4ba5-b1b1-366ad71750d2"), new Guid("4c33537b-e856-463b-811e-e8e059750140"), new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), 3, 2, new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("67d908df-f45b-4835-89e7-caeb4659d3a4"), new Guid("4c33537b-e856-463b-811e-e8e059750130"), new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), 3, 7, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("668c8cbb-252d-45cc-a45d-87751d075782"), new Guid("4c33537b-e856-463b-811e-e8e059750143"), new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), 1, 15, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Departure", "FirstName", "LastName", "Username" },
                values: new object[,]
                {
                    { new Guid("4c33537b-e856-463b-811e-e8e059750134"), "Economy", "Fname34", "Lname34", "User34" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750133"), "IT", "Fname33", "Lname33", "User33" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750132"), "Economy", "Fname32", "Lname32", "User32" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750131"), "Economy", "Fname31", "Lname31", "User31" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750126"), "Economy", "Fname26", "Lname26", "User26" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750129"), "Economy", "Fname29", "Lname29", "User29" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750128"), "Economy", "Fname28", "Lname28", "User28" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750127"), "IT", "Fname27", "Lname27", "User27" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750130"), "IT", "Fname30", "Lname30", "User30" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750135"), "Economy", "Fname35", "Lname35", "User35" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750147"), "Economy", "Fname47", "Lname47", "User47" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750137"), "Economy", "Fname37", "Lname37", "User37" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750138"), "Economy", "Fname38", "Lname38", "User38" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750139"), "IT", "Fname39", "Lname39", "User39" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750140"), "Economy", "Fname40", "Lname40", "User40" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750141"), "Economy", "Fname41", "Lname41", "User41" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750142"), "IT", "Fname42", "Lname42", "User42" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750143"), "Economy", "Fname43", "Lname43", "User43" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750144"), "Economy", "Fname44", "Lname44", "User44" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750145"), "IT", "Fname45", "Lname45", "User45" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750146"), "Economy", "Fname46", "Lname46", "User46" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750125"), "Economy", "Fname25", "Lname25", "User25" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750136"), "IT", "Fname36", "Lname36", "User36" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750124"), "IT", "Fname24", "Lname24", "User24" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750112"), "IT", "Fname12", "Lname12", "User12" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750122"), "Economy", "Fname22", "Lname22", "User22" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750148"), "IT", "Fname48", "Lname48", "User48" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750100"), "IT", "Fname0", "Lname0", "User0" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750101"), "Economy", "Fname1", "Lname1", "User1" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750102"), "Economy", "Fname2", "Lname2", "User2" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750103"), "IT", "Fname3", "Lname3", "User3" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750104"), "Economy", "Fname4", "Lname4", "User4" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750105"), "Economy", "Fname5", "Lname5", "User5" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750106"), "IT", "Fname6", "Lname6", "User6" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Departure", "FirstName", "LastName", "Username" },
                values: new object[,]
                {
                    { new Guid("4c33537b-e856-463b-811e-e8e059750107"), "Economy", "Fname7", "Lname7", "User7" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750108"), "Economy", "Fname8", "Lname8", "User8" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750123"), "Economy", "Fname23", "Lname23", "User23" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750109"), "IT", "Fname9", "Lname9", "User9" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750111"), "Economy", "Fname11", "Lname11", "User11" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750113"), "Economy", "Fname13", "Lname13", "User13" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750114"), "Economy", "Fname14", "Lname14", "User14" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750115"), "IT", "Fname15", "Lname15", "User15" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750116"), "Economy", "Fname16", "Lname16", "User16" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750117"), "Economy", "Fname17", "Lname17", "User17" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750118"), "IT", "Fname18", "Lname18", "User18" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750119"), "Economy", "Fname19", "Lname19", "User19" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750120"), "Economy", "Fname20", "Lname20", "User20" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750121"), "IT", "Fname21", "Lname21", "User21" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750110"), "Economy", "Fname10", "Lname10", "User10" },
                    { new Guid("4c33537b-e856-463b-811e-e8e059750149"), "Economy", "Fname49", "Lname49", "User49" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("0624fc3a-0d96-4e2a-86a2-a899a91121b2"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("081c27e3-d9cb-451b-b514-8c3f512fb195"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("09daa148-b3bc-40d4-bdae-ea783b9c97a9"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("0bb27d95-9112-400b-a0cb-80bcd4692043"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("0e02bf96-cefb-489a-b6ec-bbe24ad83bb5"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("15ea7fca-ae70-4ba5-b1b1-366ad71750d2"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("227030ae-e9d6-4381-a3c6-60fb594f90d4"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2636530b-2f8e-4462-97bc-b7eab1357ad3"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("2cd312b6-fab5-44dc-acdc-712b45c24b02"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("318fc089-aaa9-499f-9cb9-032763e4bfbd"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("3340e186-8ea4-4bb9-8844-c049dca78e1b"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("34a491cf-ab2a-4bed-8e29-d4a603ca7678"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("3539862d-c6c6-4fa5-9201-33f28f3fb95a"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("40ba4eda-a227-49a8-a2a7-ce79b56252b9"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("42afde00-0d7b-4a4a-867b-64b63e45fa6b"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("433dfacb-5ecc-4d25-88a1-0706ee32fa27"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("5270d631-b791-4fb2-8f46-fd34fef92f25"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("52fb5e08-9a0d-413a-83fa-98eb82d9f68d"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("54300f33-068b-4691-9a84-1d30be9ef8c0"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("5803f4c9-84cd-411e-a052-72c4fde616a1"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("62d0d91a-7456-40df-8f5f-16016e764348"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("641d4b01-0954-4c19-9fa0-c6194ab218e6"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("668c8cbb-252d-45cc-a45d-87751d075782"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("67d908df-f45b-4835-89e7-caeb4659d3a4"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7037f92d-8032-4da5-872c-7b96fb851ab6"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("76219002-37b4-455a-b1ec-64fc5fc76471"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7d00dc53-bc23-407e-8521-e2839e391d2b"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7e24e3fe-fd1e-44fc-86e9-7ba82c3e9e7c"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("7f943342-bb5e-4fa8-befb-b165edb0544a"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("86939f7a-abd8-48e3-b57d-650a6fcf51ac"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("8b98dc6b-c4cd-4e58-b97f-d6a6c2cbb4f7"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("8cee9c31-fc33-4b1e-b5c8-5867ca342bc9"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("960198f0-d82e-42db-b1dc-c53f24927cb0"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("9a1a7e48-6363-4e84-aafd-d03707850a49"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a00e7a40-ebb2-4b52-8ad4-78b400c3b25b"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a94f3495-8696-400a-81c3-3c7a1d4c5fb3"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("a9c56b44-13b5-406e-8671-7dee35b5b022"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("b850aa6c-f1b8-4fce-b070-770b3a9ae089"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("b9ffcf1a-2116-41d3-bd96-87cf15b963a9"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ba8a454f-6296-4bf8-94dd-77d33beaac0f"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("bc80c451-c41f-4c54-a255-bddb0b5cedc1"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("bf7c19da-7bc5-4c91-87b4-ab8a286b0b9f"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("d066996a-7b69-4c01-837e-17810f310d37"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("ebd338bd-c00c-44d4-948f-0861a5b7bfe6"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("f17a04b9-799d-4727-a8b4-e3b93ac5c906"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("f18cce82-95f9-4eb2-a906-f6c596e9ca9e"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("f3e5eebd-8516-47ca-ba5c-9ffa0c112e65"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("f94c4cc6-050b-4033-8f51-7cd3db6c87f7"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("fc58c834-859b-4dd7-a634-2137099d4ba5"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: new Guid("fe96babd-40e5-495c-9833-b3c3bb90375a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750100"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750101"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750102"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750103"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750104"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750105"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750106"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750107"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750108"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750109"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750110"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750112"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750113"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750114"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750115"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750116"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750117"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750118"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750119"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750120"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750121"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750122"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750123"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750124"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750125"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750126"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750127"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750128"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750129"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750130"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750131"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750132"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750133"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750134"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750135"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750136"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750137"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750138"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750139"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750140"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750141"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750142"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750143"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750144"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750145"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750146"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750147"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750148"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c33537b-e856-463b-811e-e8e059750149"));
        }
    }
}
