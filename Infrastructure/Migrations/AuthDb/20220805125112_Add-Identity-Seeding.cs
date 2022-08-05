using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations.AuthDb
{
    public partial class AddIdentitySeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4c33537b-e856-463b-811e-e8e059750100", 0, "def5f381-8bd7-411a-96bd-24cf7e483943", null, false, false, null, null, "USER0", "AQAAAAEAACcQAAAAEKz+ICfYoZH4U3z0ULoLtbMWLW6xir2QzqOw008j1Q80ZBa9I/DnAGiNEW+rr/ORYA==", null, false, "ef890307-cd3a-4214-8812-73eba8c16faf", false, "User0" },
                    { "4c33537b-e856-463b-811e-e8e059750127", 0, "aaff4803-0e78-4076-82c0-7cab81b88291", null, false, false, null, null, "USER27", "AQAAAAEAACcQAAAAEHMMLC0+2w3ciXMrflKTMYMolcHqx843eNZLn5gWEGgy5GhoJ2YNXSK51lMxDcBhnw==", null, false, "03fcf0eb-8898-4db9-a73d-7cf96136c675", false, "User27" },
                    { "4c33537b-e856-463b-811e-e8e059750128", 0, "9f0f31e0-4cef-4fdb-9dfd-73b55de4e11f", null, false, false, null, null, "USER28", "AQAAAAEAACcQAAAAEAeD450g4ZFUV1U2QgwaTC+32CIcYjRRIVmD4EEUGmLufVR2/qAwHAlydCIR/2J1cQ==", null, false, "8edf1702-e65a-4dae-94ad-66463fff0425", false, "User28" },
                    { "4c33537b-e856-463b-811e-e8e059750129", 0, "fa60d808-4fd6-4fd4-a926-79c6c73cc461", null, false, false, null, null, "USER29", "AQAAAAEAACcQAAAAECzmRDrAET4q5Uh4G1uEKpJ699ZAqlfO9NJ8J+QMOGUntnAjbNS805Wo8BRKjgnDlw==", null, false, "43786612-5da4-4c4c-9e29-f8b8702707d9", false, "User29" },
                    { "4c33537b-e856-463b-811e-e8e059750130", 0, "c9156ee8-28f4-414b-b91c-63090bb47fff", null, false, false, null, null, "USER30", "AQAAAAEAACcQAAAAEFFeNlOhleIZvJ5Gvt+/SA589QICEvS5o/JsVzcHLTkkFqWYGJ5iEfZLBIeG1l+aQg==", null, false, "ebb2608c-8d30-441f-b995-9a3e9198c2be", false, "User30" },
                    { "4c33537b-e856-463b-811e-e8e059750131", 0, "049f753b-71a0-431a-95c0-8f29269abd03", null, false, false, null, null, "USER31", "AQAAAAEAACcQAAAAEEQunnf0G57MUQc0yC3Da8psdBZQRxCQ0C/7LQPL/8NIrAhlGYfmXoVDNPhwGd2OtA==", null, false, "854c7fcc-8907-4e02-bd15-f6e43b89a1ad", false, "User31" },
                    { "4c33537b-e856-463b-811e-e8e059750132", 0, "1498094d-6e3a-4b95-8604-35c9f7952543", null, false, false, null, null, "USER32", "AQAAAAEAACcQAAAAEHzIN2+3KF/JCPHjgO4ANT2WdfAdW8hiPiqy9REP8t9Lolo6a8xRYdY9VBiKcOhnSg==", null, false, "a8a99801-81a5-4e19-94c8-bdf0697baf81", false, "User32" },
                    { "4c33537b-e856-463b-811e-e8e059750133", 0, "1af35845-50de-40e7-8de7-0bc1f1a7b5fb", null, false, false, null, null, "USER33", "AQAAAAEAACcQAAAAEHZHQReXSwakuvjeXfdt4S6lt2X/bx4phBBDTxbPO+/9ja7sfrgVqLu4WN9XsYeUAw==", null, false, "11778c0d-b4de-4f01-bb28-887aa1026747", false, "User33" },
                    { "4c33537b-e856-463b-811e-e8e059750134", 0, "9067953e-524a-4d3d-9517-fec8f75e3e5f", null, false, false, null, null, "USER34", "AQAAAAEAACcQAAAAEB6JVPcJzOgmsABGhIm+0dCdXMbmzjox6oypQwD8tvRSTDFRYK47HvwufCGMguhDVg==", null, false, "b442651a-c7e1-4d8d-890e-55af26d96a0e", false, "User34" },
                    { "4c33537b-e856-463b-811e-e8e059750135", 0, "33ba4c7d-29aa-4260-93d1-2836651d7420", null, false, false, null, null, "USER35", "AQAAAAEAACcQAAAAEBMSw2bRl5fzCysHh0r3yaWEbzdXSqFP4m1c3OlCCK34CwYg4E81BGLK42anXhapjA==", null, false, "44f7f252-7d48-45d4-b187-561e21aa6103", false, "User35" },
                    { "4c33537b-e856-463b-811e-e8e059750136", 0, "dd2ab228-5205-4db6-89ab-06aefb0224cb", null, false, false, null, null, "USER36", "AQAAAAEAACcQAAAAEKCY2MVGdutMJ6bt0W9o7JGeqOlAH1H9P5yJ99UsMdHQ7EHcI8FktT2ghmlcRBOWuA==", null, false, "96c43098-6df8-4fdb-a66e-60afbd026fb1", false, "User36" },
                    { "4c33537b-e856-463b-811e-e8e059750137", 0, "b8f34b06-eb92-4516-873c-47885d42fade", null, false, false, null, null, "USER37", "AQAAAAEAACcQAAAAEOfeH7z0wmZO7ZsHZHAdx9t12j3++Ed7Z+P78RIjzC3YmlEJBaQzEOt7Ijy0xeSUtg==", null, false, "3fabe98b-d417-49fe-be6e-53ee4e54fd9e", false, "User37" },
                    { "4c33537b-e856-463b-811e-e8e059750138", 0, "e45fbd09-7b83-4fbf-a7b1-705c4465f59f", null, false, false, null, null, "USER38", "AQAAAAEAACcQAAAAEMTO1iPOwEQ3UOqc0uEuZATnHgsj45xzO2aZCDvAJAZrU0DLJ3W2+QKYCedscGsOJQ==", null, false, "b53a7f02-8203-41e4-bfcc-7db0770469d4", false, "User38" },
                    { "4c33537b-e856-463b-811e-e8e059750139", 0, "1e874145-5e5e-43cc-b73c-e985aff30f38", null, false, false, null, null, "USER39", "AQAAAAEAACcQAAAAEHdpBDzKgFGAVPUgGQ7qiYrhIwRw8+xxCvKOAEuUb5428s7FiNcxUnGA/c7i1roPRQ==", null, false, "5ca3c8ec-d796-4b61-b4d9-c7f456877570", false, "User39" },
                    { "4c33537b-e856-463b-811e-e8e059750140", 0, "1f373008-a2f3-4b08-bb89-ceba7789f874", null, false, false, null, null, "USER40", "AQAAAAEAACcQAAAAEPADTw7JYpD2NnCDEeV7TMKZBq1HbfpZg/rHDELRIoR19jrLruUdSIn9k/bVY1Pl4Q==", null, false, "d15649d1-fb1c-4bc0-b07e-49deec62eeab", false, "User40" },
                    { "4c33537b-e856-463b-811e-e8e059750141", 0, "0c17995c-d0dc-4c47-b52d-0a76b1c42ab5", null, false, false, null, null, "USER41", "AQAAAAEAACcQAAAAEFSAWMxRP5wjRUXU1rA7xbb0UZhe1+g3OdEyPxmYAXqG25EoOJtpSqKbcywgXeUwlA==", null, false, "7444c9f1-e377-4c33-8a2f-d796c7141b4e", false, "User41" },
                    { "4c33537b-e856-463b-811e-e8e059750142", 0, "4524ad59-f345-42a3-a3de-664248e0b402", null, false, false, null, null, "USER42", "AQAAAAEAACcQAAAAENike4JHnn4bVm4J8yCR35V1k8hCTnGAbu4n9WLlbmPLZwJTy7rn4XUhCC3+HfW4QA==", null, false, "32954478-3b1f-4197-90b0-b3cb8c04fcea", false, "User42" },
                    { "4c33537b-e856-463b-811e-e8e059750143", 0, "04d36fad-0338-4c86-a14c-eec524c516a6", null, false, false, null, null, "USER43", "AQAAAAEAACcQAAAAEEbAl1fDSlY9XNVf4EYwUXDM+RpEhWk7TyqiV9LkxEmWpuqwBnY/UUSrJUi9W4ZWnA==", null, false, "def61888-5f68-4931-8a45-938dba408ffa", false, "User43" },
                    { "4c33537b-e856-463b-811e-e8e059750144", 0, "a5eae11e-4022-4c84-a5fe-cd782b0b9788", null, false, false, null, null, "USER44", "AQAAAAEAACcQAAAAEIbQkF4bJzEiL0Q5RSEBlXTshquxHx67w0fk91VyN7qMq2Z9eeDPXnquAbLoTBNh1g==", null, false, "53f1b8ca-2c24-40e7-a844-f4abef71d081", false, "User44" },
                    { "4c33537b-e856-463b-811e-e8e059750145", 0, "7512574a-f29b-47de-80b2-26ae9d54f3b6", null, false, false, null, null, "USER45", "AQAAAAEAACcQAAAAEL6BtDoMiw4DmKJN4u0Nym4n2r9L54f0N+1QQVGQuNEEgr1DmSVIREQfjvZCmJvjjA==", null, false, "4ce49785-df2e-490e-8729-ab64e1a15c86", false, "User45" },
                    { "4c33537b-e856-463b-811e-e8e059750146", 0, "1815526c-9140-4de4-b17a-766856017d9a", null, false, false, null, null, "USER46", "AQAAAAEAACcQAAAAEMMR8dcY3EJzIkjNTSK6CZnHJCri6ZKcQWAPrlFfw37No9pVo7wlpjzR5L+V6ty3Jg==", null, false, "01ff8ec7-9add-4a1c-b4b6-5dfb7497eb55", false, "User46" },
                    { "4c33537b-e856-463b-811e-e8e059750147", 0, "1cf18a2b-90aa-4fd6-a478-f5f98c0d070f", null, false, false, null, null, "USER47", "AQAAAAEAACcQAAAAEJglCsqv7TbzNN0xRnTfrmXDYSMg8i8ZDjdpgeNTspsOV1OIA0EnpYqXxhMC18J73w==", null, false, "a269a279-e8ed-4aed-898c-92fb0b63a1d2", false, "User47" },
                    { "4c33537b-e856-463b-811e-e8e059750126", 0, "f10646cf-df0a-4cb0-812c-a09310aff518", null, false, false, null, null, "USER26", "AQAAAAEAACcQAAAAEKA+2XTozLtEnDZp1/fva7KZ7qqg+kHj9JuP2hX89jRlDgCwokz9hKRZ+2F7Nh/PAA==", null, false, "4ef50547-4616-4fea-9458-850832f198ef", false, "User26" },
                    { "4c33537b-e856-463b-811e-e8e059750125", 0, "9a87d0f5-6e3a-478c-93b3-3d42395619bc", null, false, false, null, null, "USER25", "AQAAAAEAACcQAAAAEBca7yRKC3grP6YegKkWgQ74RnepFVnDfXq5rZ4d5sxI1YxYQNct09decYdC9Uf5Dg==", null, false, "f03aa8da-c9b8-4f5d-8293-d7a831f1fe14", false, "User25" },
                    { "4c33537b-e856-463b-811e-e8e059750124", 0, "5a63fde9-4767-4168-950b-ea1ebf6ea0f4", null, false, false, null, null, "USER24", "AQAAAAEAACcQAAAAEJNqNNByqJh7MtvEX8ksD1cCSFde1E0rS9RZWPDLzoaFes4yj5GFQOfhWa1tsj6/MQ==", null, false, "6d0bef11-ca13-445b-9813-396de3981ab4", false, "User24" },
                    { "4c33537b-e856-463b-811e-e8e059750123", 0, "71058a8a-4b8a-4b1a-9cdd-6a0a57e9fd91", null, false, false, null, null, "USER23", "AQAAAAEAACcQAAAAECK8XGvDJdsGK9bR+tZdn4A3gdR9reyOf5lj7j4Dk/Y9Z/lavGYT1Iz3oYTAqhguxQ==", null, false, "ce173c2e-adda-4ed7-942e-c5d08f428fab", false, "User23" },
                    { "4c33537b-e856-463b-811e-e8e059750101", 0, "10a300b1-9224-4af1-aff3-07bd7b56b2e1", null, false, false, null, null, "USER1", "AQAAAAEAACcQAAAAEA0jyd8dQoGyhuM/zNN6tHKmmh68Gnm+pcBBYchYvbXYVRbVgYEzxzPXhSaMu0fA0g==", null, false, "2abfe258-2acd-4e99-a273-698fd526bc37", false, "User1" },
                    { "4c33537b-e856-463b-811e-e8e059750102", 0, "c1543d87-8261-4f72-8d03-295d60ec83fc", null, false, false, null, null, "USER2", "AQAAAAEAACcQAAAAENwdMuc7gXEK2CfUzEyNPwonLyR+mM1HojsHf69RW5Atzzq7fQ4XbFjJYJMLTpE47w==", null, false, "e2c59100-ebef-4bc0-ac4e-563702ae9782", false, "User2" },
                    { "4c33537b-e856-463b-811e-e8e059750103", 0, "ae3b2cc3-55b3-4bcf-89d3-0de54f39ca10", null, false, false, null, null, "USER3", "AQAAAAEAACcQAAAAELLlGQat9QSWxo3AUEYS1Ow1mR18+oiOcVXc9tilHYZXz+nnQBy9wMT8IH5xoeht9Q==", null, false, "0319e2a6-71a8-46c7-ba16-bbd6a8f84441", false, "User3" },
                    { "4c33537b-e856-463b-811e-e8e059750104", 0, "f57e3413-7d42-47a7-9542-5ec940a6bedc", null, false, false, null, null, "USER4", "AQAAAAEAACcQAAAAEKVy81o3R9+mfNXdReDlBEBCbuz1zGIDxQcJC85NunMNO9un+VdfTQG8RMkTlUi1JQ==", null, false, "a433435e-0941-4cfd-9066-d42f3343c1c2", false, "User4" },
                    { "4c33537b-e856-463b-811e-e8e059750105", 0, "f3f5601d-1491-4801-bba5-b89fbb7715ad", null, false, false, null, null, "USER5", "AQAAAAEAACcQAAAAEDeTc6y5oQzadX2ngg2kIHlYKGNJr4lWIPGQRtq1lxgGFSGNoUKH2+3xymVVhqFHyA==", null, false, "8dd6632d-5be1-401b-bbb5-a60d96570f32", false, "User5" },
                    { "4c33537b-e856-463b-811e-e8e059750106", 0, "28f0f467-0f28-46e8-b267-4198a0c6d5d3", null, false, false, null, null, "USER6", "AQAAAAEAACcQAAAAED48cutvOeSKIcP5bg1sHRPOE+6pDz07nZuxBjhxONi4tJS5DhJk4B/BaXI6NOrcRw==", null, false, "22eadf52-39dc-4ed0-8526-64316a952b45", false, "User6" },
                    { "4c33537b-e856-463b-811e-e8e059750107", 0, "e19c3dcd-c6c1-4193-a87b-bb5db7103c89", null, false, false, null, null, "USER7", "AQAAAAEAACcQAAAAEA7/AijF3fOM0JNf7Qn4poyBelMuqwYFSe9VYlcWh3sLVnq8UJFhe/uYPZrYsnMzjg==", null, false, "3c481ed4-f247-44bb-a9d4-0d9ccf45a71e", false, "User7" },
                    { "4c33537b-e856-463b-811e-e8e059750108", 0, "39373f11-7396-491a-af36-1f063997b527", null, false, false, null, null, "USER8", "AQAAAAEAACcQAAAAEPY/Z+tC+i6+JHyv/JG/Jr++MuHadtq7VVnpkk0WO82MloVkAWG+xbUN0MPf24QGuA==", null, false, "672207a2-5cfd-4951-8a69-f1bc8ccb405f", false, "User8" },
                    { "4c33537b-e856-463b-811e-e8e059750109", 0, "ee883a1e-a4bb-4164-bcfc-3a5c8ade57b9", null, false, false, null, null, "USER9", "AQAAAAEAACcQAAAAEFbtRm1GayNmw5OlfNiG4RNSWLdDBoBt4xazLzMwEz7pYtqisYFot8E1FpPAza9LOQ==", null, false, "3e93c0e9-2a23-40ce-99d3-2a83d4423949", false, "User9" },
                    { "4c33537b-e856-463b-811e-e8e059750110", 0, "53eac1a6-fd88-4980-9dc2-492b49c241d5", null, false, false, null, null, "USER10", "AQAAAAEAACcQAAAAEAlCa2ygZMcaMi8oal51ZB1wfJvfr33hHvElX0d9O54mYEKQ3D6/a8lZuykJ8M0lEg==", null, false, "913ca758-e315-4a65-972a-56c50a96ac1e", false, "User10" },
                    { "4c33537b-e856-463b-811e-e8e059750148", 0, "af5c625f-ded5-434c-a21d-37c108ad7cd7", null, false, false, null, null, "USER48", "AQAAAAEAACcQAAAAEFHUo22y9qKnDDwiYgGMEf6GmcXU/M3XlwJ5dFdfSuxz3FDGZxdtYzO6l9wyCK0Q3g==", null, false, "24a304a1-c781-4e35-9a86-777fd50b965f", false, "User48" },
                    { "4c33537b-e856-463b-811e-e8e059750111", 0, "1fe25d04-b638-43da-882b-06e486c829e1", null, false, false, null, null, "USER11", "AQAAAAEAACcQAAAAEFxaSVoyT6NyKQsG+ObdlU+lggtj2dc23/WHbLHWrK9KuKkxl88gNPJQGA18OhFeQA==", null, false, "30da87c5-45d0-4999-a1b6-5698178530e3", false, "User11" },
                    { "4c33537b-e856-463b-811e-e8e059750113", 0, "a43843c9-27bb-4201-a228-be88966bbd10", null, false, false, null, null, "USER13", "AQAAAAEAACcQAAAAEMbHfzfP9+wqcADQ0Up9EBn7wi7krUeKrFpOjkn48D54u7AbIOnnGPpnWBIJTGa/EQ==", null, false, "b618b1a3-2af2-4d08-9745-5e1c11fe7b0d", false, "User13" },
                    { "4c33537b-e856-463b-811e-e8e059750114", 0, "522fd93f-ce1c-437a-9c22-c709965931f2", null, false, false, null, null, "USER14", "AQAAAAEAACcQAAAAEMHHVnGZQcT/628qm5PwGtjGHpU9/VVagbY6ii0dKbBX9W67o7532T7AgCGlOwu3Vw==", null, false, "d84ea3f8-4d34-4fd6-a6f6-7c656b756520", false, "User14" },
                    { "4c33537b-e856-463b-811e-e8e059750115", 0, "3361ca60-97ca-4b0f-9af7-465c0f5a4a19", null, false, false, null, null, "USER15", "AQAAAAEAACcQAAAAEOUgwclb4qgHzTBGUZqhqgWwMZf5jodvDPZw0XrlCv2UWLYbzfX+BGe1Tt1Zt2VYqg==", null, false, "b99e7ba1-f8f2-4c70-afca-2758a81b2be2", false, "User15" },
                    { "4c33537b-e856-463b-811e-e8e059750116", 0, "b663effd-4513-4793-b5c7-d7150bd4ea87", null, false, false, null, null, "USER16", "AQAAAAEAACcQAAAAEA2lqVYa5YYpvag41/N2KPmEqHrKGuFqRlZJkTuQC0OJP6p946JrSG0ZDvZuk7RpBA==", null, false, "b5dc8d1f-20f0-40fc-b7cb-1baf5849cb2f", false, "User16" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4c33537b-e856-463b-811e-e8e059750117", 0, "0de1929f-b4fa-46c5-add8-c1280e3b594c", null, false, false, null, null, "USER17", "AQAAAAEAACcQAAAAEPRPNrLu7lCS6xAS1whHpNkVcjFfLELDNMc65jk1KbMWkEsWcfo2vqlB39uVviTGdA==", null, false, "577313c4-f1aa-477f-913a-245b3eeea97b", false, "User17" },
                    { "4c33537b-e856-463b-811e-e8e059750118", 0, "8f897587-e76c-4a70-a2cb-305fef1e7222", null, false, false, null, null, "USER18", "AQAAAAEAACcQAAAAEBlUi0mdx7CeFbPdS5vOgzBwVomnpHfNuqf0vvegqUFXRSKcSWTVQx6i0D/P34FiIQ==", null, false, "d921be7f-114a-4b60-9e76-2883e5536294", false, "User18" },
                    { "4c33537b-e856-463b-811e-e8e059750119", 0, "5e4493d6-620a-4f26-bcbc-5929fd270e43", null, false, false, null, null, "USER19", "AQAAAAEAACcQAAAAENqU0o73Vol+hIVQujRBpG9jhao9ddZwvzphK+z6I+OxOSFrLd3AwZrpFbOJAcTD1g==", null, false, "8a691dc8-c39a-4f99-b244-ee03369206da", false, "User19" },
                    { "4c33537b-e856-463b-811e-e8e059750120", 0, "35593337-a543-4696-846a-b6892a2bec6c", null, false, false, null, null, "USER20", "AQAAAAEAACcQAAAAEI8/pdCpSUpx3pCXU3KxiNQUXr64f9Vb2Ngiq5ftqekdBxMoUpqAkhj48yPe103Faw==", null, false, "4f1e3968-28ec-4f5c-8454-ebdd74b4c1b4", false, "User20" },
                    { "4c33537b-e856-463b-811e-e8e059750121", 0, "03aa2eba-f45b-4986-902f-bdce2928235a", null, false, false, null, null, "USER21", "AQAAAAEAACcQAAAAEOKphDACUW5qqnpLYmYO1HrJ3vZFepVb4GH14yVTgyg4htpi4dbpss5lkM5lIqamjw==", null, false, "bcecbfe3-81b4-4e88-b63f-8f85b5f1ff89", false, "User21" },
                    { "4c33537b-e856-463b-811e-e8e059750122", 0, "e002f0c8-6164-42ed-8d04-3af4be897d03", null, false, false, null, null, "USER22", "AQAAAAEAACcQAAAAEA2nc66J3DPetXkusI7IDZJPVRpr/MZw4QxebDTS+5NjpJrH8e9RRGDUiRhNvnWhpQ==", null, false, "40741fe9-6b28-48cd-aa94-39718eee6677", false, "User22" },
                    { "4c33537b-e856-463b-811e-e8e059750112", 0, "3d91760b-34a8-44ea-8a9f-7c288e5bcac0", null, false, false, null, null, "USER12", "AQAAAAEAACcQAAAAEBwCoSZJ65uLofGeFkRbDuLvUWCB8JgA41ojgdgnu0Uo5liXHzGJh72NwKbPT5aE5w==", null, false, "9d8c3591-9a32-4200-bb69-648e3c670e92", false, "User12" },
                    { "4c33537b-e856-463b-811e-e8e059750149", 0, "12d6f2ba-f6a8-421b-b823-78f527258d6f", null, false, false, null, null, "USER49", "AQAAAAEAACcQAAAAEIVeeZ0QvmvgjHsIRQibyDd0erpt8N/SqzQ9J2u4t5Ib7UmTKD4nZ8ct49CBDwb36w==", null, false, "813c6108-8a70-45d9-a080-ecb33ed3d141", false, "User49" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750100");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750101");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750102");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750103");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750104");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750105");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750106");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750107");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750108");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750109");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750110");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750112");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750113");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750114");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750115");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750116");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750117");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750118");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750119");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750120");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750121");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750122");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750123");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750124");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750125");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750126");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750127");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750128");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750129");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750130");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750131");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750132");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750133");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750134");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750135");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750136");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750137");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750138");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750139");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750140");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750141");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750142");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750143");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750144");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750145");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750146");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750147");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750148");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c33537b-e856-463b-811e-e8e059750149");
        }
    }
}
