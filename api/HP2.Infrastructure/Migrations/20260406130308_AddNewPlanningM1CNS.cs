using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPlanningM1CNS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "session_id", "course_id", "date", "Description", "end_time", "mode", "room_id", "session_status_id", "session_type_id", "start_time" },
                values: new object[,]
                {
                    { "013253fd-915e-ae02-98e4-8f6204070217", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "017daad5-244e-acd2-1ce4-07c75f5c9f04", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "0307a4e5-0941-b6f9-6e98-e48ede3c5f57", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "042c2061-f2ce-afcc-e0c0-a7bbfcebeb13", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "0733286f-fa6c-43ea-5ca3-7184db85512d", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 13, 30, 0, 0) },
                    { "09d5852e-c85d-b871-49a2-71c8d434e139", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "0b8c5e9e-5f59-32f8-19a0-b9e05ef5e471", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "0c68876d-2d68-d530-2757-956294ff1bed", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "0cbff9d4-4613-2d77-f1a3-6e9f4238a87c", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2026, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 12, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 9, 0, 0, 0) },
                    { "0d647b97-8742-6f60-67ee-364224b37cd3", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "0d9f5e1b-8b16-6512-1aad-b6fc5bdbda7f", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "11219807-2307-1246-8bd9-cd76bf2b52ce", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "1133eac0-f2b9-5576-b0b6-bef1f79782c7", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "114acc04-a14d-ea71-5c54-bb541e5bb9af", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "13000bbc-8fd6-1578-7278-d709f023eed3", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "1491b2d9-7dbd-4050-013b-0d4c38aeb869", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 13, 30, 0, 0) },
                    { "14a89b1a-19ff-ce17-300b-e17e3bd1077f", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "14cf4c2a-44f5-3e25-70c5-a8ad8fd3e3b8", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "15ba8680-1073-bb6c-6f10-054644dff3ca", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "15cfd3d2-8bc4-c1bc-7fd9-d3de7f5d669b", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "15d70dbc-6c98-76b3-999c-21437cc800e5", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "16a954b2-61f0-b37a-7693-a0b61d5aa2e7", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "193842d1-67f8-7b4a-04d4-8ad3f57b6cb5", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "19f8d59a-321f-7873-3ea4-4c981946832d", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "1b0c902d-ad55-90ab-57d4-16427ad6c740", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "1b37d5da-f4b6-cbc0-bbc2-8fee0570e9fb", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 12, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 10, 30, 0, 0) },
                    { "1b80b598-780b-bea4-5a24-19940d4a38e1", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "1d551b56-0c89-92ea-bc4f-58b3b9bad9dc", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "1d78c887-7aa6-132d-0217-f7b43b77bdf8", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "1e6bec97-4c0e-5908-667d-688e7511f7c4", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "1ef93c61-327d-3b0f-db94-04acd6213a5f", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "1fd5f3c7-4c47-19c4-61f0-665a537bec8a", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "23a6ab3d-60bd-4148-2d32-cd648026c5e8", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "249c0eaa-9905-1383-8fca-affda7f85f7b", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "2593023d-cd4b-3a13-8456-8605799c009b", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "2599f89e-0977-b58a-0539-f65697c1c75f", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "25de3c2e-a93d-53f8-6982-c678ad47cc54", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "289a7bd2-5839-a841-3c7a-6cd2cb327c1f", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "29f09856-4a06-7009-67f4-1b47f3735322", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "2a77192f-3516-2af5-1c2f-efb27ff44dff", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "2b56efe3-8b66-93ad-54b4-f5517a0c3cb5", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "2be3fbb7-603a-37b8-9886-8cc179a60c00", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "2db3f185-97dd-9f4e-3813-f595191b3ef8", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "2faf2f20-145f-cd9c-fcfd-afbf11172030", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "3149b3f4-1518-8b57-abdb-7e08d36f7861", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "31684066-8ff8-ec8d-d574-7994a009b471", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "323b5584-bd42-9b8b-ca3b-7683360e02ad", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "32508cd9-8a12-0bba-b62b-aa26d542bf43", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "325dbc6b-3915-11ff-5664-566a43aedcce", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "32e0e5ec-8a8e-9958-11b8-3e1fdf2c9022", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "338ef414-55b6-57f8-6cbe-eba50b6858da", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "33ff2701-91f8-d78b-7a7d-2e8699300904", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "35769633-5a71-b8f5-cd23-34959e70feef", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "35e80a17-a920-4848-28dc-7e49a1b1d450", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "362f0228-aba7-6c24-8de6-b0f8e8f0fca2", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "363f0139-5ea9-5659-b4b6-d31f10c6e1f9", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "3a0dc032-1305-74fb-e0eb-b5d26843dce0", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "3a184df7-7d52-f9c0-8fcf-d65d15495f27", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "3c5a71ba-2254-b3ed-67ec-f64c0106c660", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "3c94d190-986e-a736-87ca-6787d693212a", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "3eb203dd-c874-2718-a2a0-3fc6a3d7ceb8", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "40ced4d1-1d5f-05f9-1ecc-008ece9bf6cf", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "425b45c5-3bf2-b3cc-a8fd-011c300c5b6b", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "42c4e64b-5f37-7428-68d0-ae73dd07c550", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "43218475-c208-8bef-45bb-cead9439d8b2", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "453afb2c-a5b5-3cf4-f188-1fa95fc15824", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "490f3cf5-28f8-dece-4922-52671fb4a199", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "4950a765-76b9-83b3-7de9-af0e949338d0", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "49a1f7aa-8859-4cc4-b546-4549f789bf3f", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "4aff05b1-2e8c-eb11-a7d0-dc28213597fa", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "4c7ef4e4-6089-5b54-70cf-462a7594d3eb", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "4cce25cb-d6a8-8892-ccc2-05059e6a6f16", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "4d46411f-dba7-37ac-8814-c7da719f6e3b", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "4f1f9725-101c-80f7-d008-fcc9271993df", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "50a9ba02-e020-16d3-df51-fb9c4b19bd0c", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "52255222-934c-c40d-8d7f-7c438999b75b", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "53238bae-d873-e113-c07b-94f7384f2a4e", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 0, 0, 0) },
                    { "53bed5c3-f54e-2f3b-5ffb-c3d75fdef22e", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "5582813a-cf75-d0bc-d6ea-164333b8f078", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "55db5c7b-8e15-4375-cc5d-227a06438d38", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "5614c18a-417b-4621-5dd4-a17203b6fd57", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "565b9687-a776-3cef-8994-bc338c6f1895", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "5826bd17-eeda-6222-b4d0-8506d1ea4f1e", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "594df6b5-390a-e031-8c8f-ec7beecf5380", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "5b05b08e-6f73-e22a-e582-c0117147df20", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "5b638516-0759-9513-853d-bbb34b652783", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "5c094776-5acf-2f84-62b1-e51885ebdbbd", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "5d8585f7-072c-3acc-02d3-036830d0eb38", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "5f1cbb5b-c8cc-7cb9-7692-cfff312ba139", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "61a67da9-b7bd-4555-9cf8-c6341152be1e", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "6381a78c-fcd6-d0a1-c4f5-09323d5ec98c", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "6421d373-2d22-5d19-eadb-7e134fb1514e", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "6634a192-1867-c0b7-3d6a-f40e9451b92c", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "68b4d308-be73-447a-aa01-94326f1d8573", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "691660f9-12b9-5e11-9261-206ceacd9e36", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "6a26bb2b-10b3-d20b-576c-06ec7eb6881c", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "6afd119d-e28e-92e8-9e89-1af6996f754c", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "6d007abb-5e1b-17af-b0f7-2c47514aa643", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "6d5ab6db-8f30-6091-2cd9-ea7f969fcbff", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "6e7e7ad1-76f0-2a98-4e52-aad698b8c7ad", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "6eab02e7-1426-0881-1c74-99cbe1c2dabd", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "6f546c47-26f1-7ec9-b641-fc447770b8d5", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 13, 30, 0, 0) },
                    { "6fd6173d-eb18-e8d7-405c-66721548558e", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "6fee2eeb-59d2-0c00-9a1e-8a30811ae17f", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "7094d547-fd86-a3c5-b337-839b1e5c317d", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "718c2d6c-578e-b7c9-1e8d-5bc67c063ea5", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "74775c4f-426a-3783-b04f-ccac0b514278", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "74ace139-e992-d91f-4671-52f639972753", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "7600bbe0-0a15-349a-b9ec-c475880ecfda", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "767d2088-ae6e-01a3-af51-1f15e4010867", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "76c7b55e-03e5-9b52-34d3-5a7ffb9c90b6", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "7755d2e0-e594-43f6-6b2a-97e09a800704", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "77584882-18b2-c070-5e41-8b0e717367db", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "780e8022-e459-3d7f-a36b-47992b26ace5", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "7978f9e1-f848-3ea6-bd32-b7ed5c2ba948", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "798ddc1c-e359-941e-9460-c187af5e53f8", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "79e9a30f-cfe9-2f9d-cac4-f86e3962d70b", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "7aa3c75d-1047-67fb-2ace-ac1a1a10d694", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "7b197240-8dc4-4b9a-bffc-03041ba80ac3", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "7bccd9ff-6129-4373-38f5-54b69ffa2532", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "7d8f0718-91c6-2cab-268a-090d429358b3", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "7e81993e-6a54-b9ca-8ca1-a5dce75296d9", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "7f73fc92-af72-477b-9c37-49b6779a08db", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "80f54d52-7c1f-5ff2-d278-d08cb6fbe663", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "812aabb2-c7f8-2548-e7b2-c7c99cfa0b51", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "82854779-bd50-0aaa-177b-dbe72002170a", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "82a38202-4f6b-41d9-11fc-0c59d2bdb4a2", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "842306fb-458c-d097-eed8-909990df3d1b", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "852e46ab-b00f-8054-4ee1-5649cb845174", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "857d4bd4-f8b9-a253-5f74-06ed5783b8cc", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "85e1b30b-426b-ad04-17fe-fc152cee3378", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "86096d2d-028a-2178-b93d-d09c58fb798a", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "873dd793-925b-cf55-c4ed-19f5ea134c5e", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "882637b6-a3e0-c6f0-5adc-323fbaf06469", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "895ad2cb-c1d9-f871-0b4f-6d588817d0a2", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "89af6c7f-eb9b-700a-1edf-c780be219657", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "8a1b0119-fe28-9d70-3d44-4f08f1cc15dc", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "8b4e0e39-d22a-6b9e-f265-f1e56b32a5ac", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "8cabb15c-08a5-3226-7620-6b7fd82c0ec5", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "8e9adcb0-97f0-f605-d063-0d6f594f51ba", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "8edbb040-f6b6-44c8-881c-6d2a3d8b7775", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "8f6901a4-f5b5-e843-e991-5ecb27c6d119", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "8fce3dc3-2a8b-c124-f96f-6798c213bfc8", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "9343be38-6a9c-9597-308b-b7a380d3341a", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "93acaa36-b84a-93e3-4ab8-bee3839813c8", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "94d53d90-c40d-2c7b-5b09-1fc3733efdde", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "95280675-9478-c286-6e61-5eadb6e04ce7", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "96cf1edd-649d-c6e7-4f3f-63bb525f08b9", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "97732f97-a471-d97e-a1c9-5f1e65501cb8", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "978254e1-40d5-bc41-fd06-9909777893d6", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "98a3af77-666d-b843-1550-1654d066a91b", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "9aec3604-2382-813d-dbe0-e829167d4d03", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "9b04b38a-df80-4890-3b63-b52fc684befc", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "9bb332c5-28e6-8114-a6ad-33361e1c176b", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "9f1d52f5-5854-6344-7ee2-50b3aa2206aa", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a1dcbe22-1a98-b101-6d9d-6a1e43eecad5", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a2eca7c6-6ded-0447-2d46-a31b5047bfb9", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a4637bf4-ac5f-fc18-4f21-5d6060423cac", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "a515b538-facb-a384-2fc0-09bd704b792b", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "a5ba5432-532b-bdc1-4517-8f6657b06ccc", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "a609799e-8e05-578f-a027-ff94df7272f6", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "a6be719c-a6d5-4ec4-f3bc-079e2bc133f7", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a6d90d38-fb40-67d3-9291-4dc9433685ab", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "a8052858-a628-5c78-0ee5-886932034146", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a86586f4-63ee-788f-6c4b-375c8c07cc46", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "a9291ff8-90b2-be6e-9878-5cf2b98adf51", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "aaf5124c-ec73-3718-9708-9cc8a153aa21", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "aafbf12b-4fbf-f7ed-baff-ddb60852ded3", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "ab9e93c1-9054-3de0-5468-8fef169e2733", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "ac1087ea-7cca-ba5d-4716-69ede045aac3", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ac148527-f1ee-3bb8-7a18-397adfdb9684", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "ad51b75b-94ba-2db3-71d6-9937a00564df", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ae09acad-eb08-db70-af74-adc1671104e2", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "ae9de472-6ed6-c56b-17f8-0802b30e0ead", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "afc81f01-6ce3-5947-ba22-725ebff80699", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "b1a62097-cc7c-9e22-017f-ade4e5e982e1", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "b1ab77c6-75e2-be65-fd4d-2216d7df9169", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "b259425c-b08a-20ea-60cc-b695e91844b7", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "b3918eb5-f713-95f5-c1c0-7675b7e0b333", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "b7631fc1-9896-70c6-3e36-19135b902372", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 8, 30, 0, 0) },
                    { "b916b170-861c-b14f-ad0a-9b5bccd2c0ca", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "bb39bb03-38d6-cd02-b341-89e2a660da76", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "bb543979-51da-e0a4-508a-34e41cd9c765", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "bb5e6b6a-0c42-fdab-58c4-fef95fcdc49d", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "bc3ad3db-d8c5-02d3-d06e-5f94d53d9f78", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "bca7d63d-cce4-43ac-f1ce-560fc47e3074", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "bd85547f-e0ea-e2db-db8d-c415c58afb06", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "be7e99bc-ba4d-f226-9d8f-03682d23bee1", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 17, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 14, 0, 0, 0) },
                    { "bed021d1-ed16-adf0-c5b4-2953fa35048b", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "bf1e2694-409a-773f-6c59-a05a8af0527f", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "bf51ec1a-fa3a-3c43-080e-494a6f7e3910", "3aed7e82-31b6-d05a-3f46-f2ef085d313e", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "c15c6cab-3590-2006-a628-67612870eb60", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2026, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 12, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 9, 0, 0, 0) },
                    { "c2516a1f-5f3e-7e0f-7b86-9053846377c1", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "c35fb6be-96f6-0788-f95f-8449add9c5b2", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "c3dd11cd-08a8-d8d0-60c4-add26094c881", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "c565c6ba-ecac-b786-5785-0744bdfcabc2", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "c584e914-d15b-6c1e-b33b-e87707b1c8f0", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "c6a456ad-719f-6857-0f33-b79bec3aec14", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "c6e7c556-e76d-2b22-aced-041ba0d8cb09", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "c8126fe8-b8d9-89f3-fefb-a1e84543f875", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "c9ca3188-8a21-724a-23f6-5d9e402ab287", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "cc712312-dee1-743a-9da4-ee708f3d06e9", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "ccb09398-5ba5-01ed-ab10-93ede45a2ff4", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "d01019f9-5218-71f9-d3a9-35cb7b04b12b", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d0486529-51fc-62a5-004c-ecd5002ccd41", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "d0f8efdd-4c40-b515-a8d1-d855a962a852", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d1ae562d-8ff5-04f9-e4f9-be70373beea0", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "d2041949-1d00-ce16-fc7c-30c218a75f46", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "d32c9013-9fb5-9f83-708d-3e02f83631cd", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "0fc6aed4-11a4-4bca-c1f3-c7060734aa3c", new TimeSpan(0, 13, 30, 0, 0) },
                    { "d3edfa54-1262-d190-899b-a472871c59f9", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "d4a343e2-40d5-57a3-222d-bbcb5fa7a60c", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "d50e4726-2991-977e-1e9d-ccae720f4778", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "d5e30992-c7fc-e449-6e8c-e9ba67574c4c", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d6285f6d-f25b-009c-7042-a47f4b244b68", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "d6442191-6705-0a50-37ea-73d811f12b11", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "d698f229-ec8e-a652-a33c-b1dfd62a38e6", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 10, 15, 0, 0) },
                    { "d8ee1684-8213-4b12-219c-66a273f8d1ec", "49ba4385-063d-7b8d-5f3f-aa1c7f573747", new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "d96fcd78-c30b-080b-c92b-7d26c7dd221c", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 13, 30, 0, 0) },
                    { "da5a50be-4892-2912-7d30-e020f44c2bf3", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "dadf92d7-0a66-08ff-9067-d63a9ac831f9", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "db390cd5-f0eb-b466-37d6-608ce90540a5", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "db8d2ab6-946a-1502-426d-fcb21953e405", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "dc15a337-285f-ef85-0d15-e43c62677ee0", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "dd9e690a-8f67-72b4-629b-15a9d4cdd73a", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ddd77ae8-2557-f2dc-0582-c2c104a0a18b", "fb30b659-6817-4099-e7cb-d7c254532603", new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "dde5dca0-3459-b459-a095-94f8a5eb4711", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "df815484-6a48-1b4e-a7ce-2b2a4a85d3f9", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "dfe2714c-934c-ef19-fe94-6c4db509862a", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "e0bb8201-c45e-a7cc-9a4a-f0921c6fd86c", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "e1738f37-9fc0-61b6-284f-5715db5ab025", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "e2513fbd-3f02-efb1-92e4-4d7524a0a9b4", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 13, 0, 0, 0) },
                    { "e260b095-b963-c13b-b5a2-d609ac8bd890", "e7d426e1-99eb-6a9f-b9b5-99d9b853e3f5", new DateTime(2025, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "e7d00346-218a-3d24-b03b-7d2cfa8d6d7d", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "e9479010-3a2b-6354-2e0c-11b49b24fb5f", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "ea06b88f-d8a1-ee08-bc3c-d84a42ccdacd", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ec071909-de0a-3e67-a7b9-4a4b07d9de99", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "ec341556-c367-708a-11c4-097536f47dcb", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) },
                    { "ec421852-921b-ebfc-d739-8212e4385e64", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "ed3dee0b-d891-bd85-2ec9-065516fcd123", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "ee921d29-66e1-c443-c162-df77ae566e01", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "ef04b83f-9b1d-9814-3a9e-a3c0d292ac3b", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "ef55d5ee-4787-d8c7-b1fc-0862746ac28a", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "f13edc40-466a-6629-9715-d914984c3653", "2d4557a7-a48d-9926-3e2b-bc820396b11a", new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 13, 0, 0, 0) },
                    { "f4c16c8e-12ba-3b16-0555-dcebf1a93e21", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "f509123c-dc8e-d71a-ddbf-4cfe70107308", "3b835d91-4f08-07ef-d4d5-575947097601", new DateTime(2025, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 8, 30, 0, 0) },
                    { "f5bcb9ad-0454-f4d3-389a-3f1d78dc2a1c", "c3cd3947-214d-3130-b938-a5d19a0e8eaa", new DateTime(2025, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "f692a256-8b14-1f69-5d15-3c1942f5c5f5", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "f723976c-ee91-b770-e7cf-4c2ddd2e10cd", "c0452911-4948-9cb2-aed9-7b949c0b6442", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 14, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 13, 0, 0, 0) },
                    { "f8cd0d8c-907b-551d-6211-931279dc0942", "24027d5d-e151-9a00-fd19-ac11d27b8189", new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "fab65069-a16f-8092-41b3-2dfadb5b84c2", "e9cbe024-5789-9dca-e8c8-418b70f033cb", new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 10, 15, 0, 0) },
                    { "fb099bba-fa75-cc47-57ac-dc2ce717cf7e", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "fb4dd0a9-4c1a-c15f-1c5c-83953364fcd2", "cf512e7a-117b-71d0-a07f-43e743dad7eb", new DateTime(2026, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 8, 30, 0, 0) },
                    { "fb91193d-c432-36d3-5e89-59f7ac76cab2", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7f2d1749-7a62-0b12-0f4e-3b943af03674", new TimeSpan(0, 14, 45, 0, 0) },
                    { "fb99eb83-8abc-f0bf-d8d5-d3ea90a38837", "d059db13-ac91-760c-5bf7-6c442946e7bf", new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 30, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "b078845c-908b-88e0-b39f-65cac002c8e9", new TimeSpan(0, 13, 30, 0, 0) },
                    { "fc3c2b4d-ee65-87b1-8670-116de9888753", "731ac32d-6ea9-f15e-7ca2-34f99e840bd3", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "fc5fd85c-a36e-f72e-7eb2-0ae8930091c2", "2f451339-dd0d-df32-93e6-c6e1eeb5e5ba", new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 11, 45, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 10, 15, 0, 0) },
                    { "fc730fac-20a9-8127-7fda-2bd0fbf14448", "014c457e-a48a-d25e-7781-d5e483cb3dd9", new DateTime(2026, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 14, 45, 0, 0) },
                    { "fe2403f2-62c7-83ab-fb2a-f4d6cb4cea82", "2af630c1-de0d-944f-0b87-a73f1c90644f", new DateTime(2025, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 16, 15, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "bf7f6e65-68aa-07ec-c88a-06bc4b897a82", new TimeSpan(0, 14, 45, 0, 0) },
                    { "fef0fe5e-f84c-8548-71ef-b871756abbf6", "03241339-1186-a90f-33bd-a9850f603619", new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 10, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "a51df269-a2de-07cb-14b1-e5c0f041928c", new TimeSpan(0, 8, 30, 0, 0) }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 4, 720, DateTimeKind.Utc).AddTicks(3824), "$2b$12$qwu79tnAuk1RSs2U/or2kOhnXShp7xO22BdyU2gYC0Ivxz272J6VK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 37, 668, DateTimeKind.Utc).AddTicks(7568), "$2b$12$DNikWLOmiOEVNkCWkk6qleTU5mWFviXN4oeaEMh24KooSXq3HthZ." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 55, 356, DateTimeKind.Utc).AddTicks(9958), "$2b$12$ABIzx.P6fhoFBbvuKQ.cXOB5xv9PzFu/P2mnxFMBF4fKgFA8G05sG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 35, 845, DateTimeKind.Utc).AddTicks(8287), "$2b$12$IGj9Fc5lXxIVUtKi0J0b2eLdb3qlKzkh3Eh26VY5ZHTGhyUUtRQYa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 42, 263, DateTimeKind.Utc).AddTicks(2410), "$2b$12$A2CdITa7vh1uZMPrF9sybeKi034g06RrQhlrMDOS7Q/lvhFO.45Oq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 6, 276, DateTimeKind.Utc).AddTicks(4233), "$2b$12$3NtnLla3aC02uayAopV8NeMx99IV4je8HzOIw37v/P3oqb2lQzDAu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 31, 537, DateTimeKind.Utc).AddTicks(1678), "$2b$12$wip9XhcWkLEukzxb03Eo4e.RyqgBr8AovoE9.tOiNRBCGajWIH2gu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 2, 897, DateTimeKind.Utc).AddTicks(7640), "$2b$12$6cEVKzSxofnZ.wP.sjVI/.6zp7JBVgRU5kpxGBFDyq1GUZ4Y9znVC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 45, 317, DateTimeKind.Utc).AddTicks(3332), "$2b$12$HZZ/FBTbDouKSR/SF29HU.s2FUzdaEqWuWGoSJ4G3bp5/GFjVrglK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 7, 188, DateTimeKind.Utc).AddTicks(9269), "$2b$12$ukWvWxIk6GWHOXJ.f/2DKeH8qLf7vX.gGgD0KWmg.Zk9g6Q2VTW/K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 48, 732, DateTimeKind.Utc).AddTicks(4663), "$2b$12$zylFq2VVc7fi5PTG5/CC0eAVRznyZurJcjMa2k1P4ST5FAeKTE4Qy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 33, 59, DateTimeKind.Utc).AddTicks(3150), "$2b$12$xsyfl0yLSeEI71UDXBlwce7qCB01HJpl2UPXVLId3dNPwyGx/PDL6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 53, 22, DateTimeKind.Utc).AddTicks(7449), "$2b$12$p2RCOVxCkt8fnwEAyNb54Oj.qfWUxVGlUJS22m7dXlsG9xmbJLuym" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 41, 44, DateTimeKind.Utc).AddTicks(1754), "$2b$12$gp5CiLcyYn3VYkTkuWrG/u/XlB8lc9veRuTa2yp.Vf8yUZBDOh.9q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 57, 609, DateTimeKind.Utc).AddTicks(2298), "$2b$12$6Wouh20MG7kmVWUlr/k4GuG2Uay9LBejCq3WVEwXjeeXAUc367xTu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 33, 981, DateTimeKind.Utc).AddTicks(6271), "$2b$12$0OwMvsyy7pW8rEwnnDa6Xu6XVxAUczlQdbjVdGTBU1EJf2WbxXq7m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 34, 594, DateTimeKind.Utc).AddTicks(2042), "$2b$12$stW1EfGqtIfkZ0hGZn1oEeuHCtBrz45cirCQHZ0KdZF4s0Gv3tWs." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 1, 363, DateTimeKind.Utc).AddTicks(5591), "$2b$12$lbFHGbM/6dhO8DhRCGA8UeII.Syu2M6gOXEfYdBexBwnInqsmMpBO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 38, 278, DateTimeKind.Utc).AddTicks(2797), "$2b$12$fbJ7Kbf7GFF4AnFTtc2EFeSgBgykA4rVnt1jy2rcJg6.rpY6UCaOi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 59, 227, DateTimeKind.Utc).AddTicks(3094), "$2b$12$4edpQ3GoIReRrn7fj2yM4.2jpgnuefzWbNtPiDLRQ44ximAH.uvfG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 3, 504, DateTimeKind.Utc).AddTicks(3136), "$2b$12$2Ex8HcIS1W5uU/7L1orWS.gnN.mSbL38nRLCzzzzZAEU3ax3gaUIq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 47, 795, DateTimeKind.Utc).AddTicks(7051), "$2b$12$Ac7ZkkhrCOhWamuACX.8/OYl/1Z6pHSbXTCV6A9L7dFBfoTvi3D8O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 6, 884, DateTimeKind.Utc).AddTicks(95), "$2b$12$/p2LM0OQeMEcp8I2BevwoOP/Sm7U5GJRDhqKMe3sedm3AzwA8uopu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 0, 141, DateTimeKind.Utc).AddTicks(8260), "$2b$12$s2sI9em1hQ3e0jHmidXHIOMalilEwBSy8rIGULoQDcrVqDp27Fe9." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 58, 269, DateTimeKind.Utc).AddTicks(8546), "$2b$12$yzAWVOwI0xMTDnk.xuw9kO5ExidMPIDLKmf96Ho.JQDvx8mzTZgG6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 30, 611, DateTimeKind.Utc).AddTicks(9537), "$2b$12$4lmekffBbn1tuYcVVROz9ees7.gmv4oZWtqa5ZFFjYLzMjH228RiO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 40, 739, DateTimeKind.Utc).AddTicks(5096), "$2b$12$hQ/4qy5Y0a3Ya3ubfmxL2eWHTpXptLvJdY.3Eu08T6ZWDPuK6FM3i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 32, 145, DateTimeKind.Utc).AddTicks(5003), "$2b$12$q/3BWntVIOpP3nWcM/EZSuh5PSYfLZi3K8Aecy.VdqKTkIWJ0W3u." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 4, 112, DateTimeKind.Utc).AddTicks(1188), "$2b$12$m2wXI2H9DWl9BMbnbIQzH.nluy6Mvs/Tw3uEWibGTrtFF4lu80.7C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 31, 841, DateTimeKind.Utc).AddTicks(4648), "$2b$12$KKV3QAGgSwJ6/WeqANex1u7eqHFsXpwMdu4914Bf3NN6y6HtgDmGy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 52, 110, DateTimeKind.Utc).AddTicks(1262), "$2b$12$Nd7cHOdIy7MDB0MiuDqRcOV6vNLgjXCg6tDGCDqe9gzG75sGbnAbi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 53, 326, DateTimeKind.Utc).AddTicks(2742), "$2b$12$7HIeFvAbT6MSRQW.N6e3/.lfghmb7hIdLkdkGH.ZrAWXoQUW4Q.Q." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 51, 198, DateTimeKind.Utc).AddTicks(5495), "$2b$12$sK8sUA/ta6pqgdKCw7qope/kt.hbZrIlH/9P0Z4yumLBGw/.lU.OG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 2, 591, DateTimeKind.Utc).AddTicks(7123), "$2b$12$Ae.JLgznwAV/.Ag92x2pp.Q2z4Jh6pmnfO9kZiqW9re2escoWdluy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 49, 948, DateTimeKind.Utc).AddTicks(6842), "$2b$12$bYhjf.Ka3sX6OnzXbl2urOxstkpElnEilpakEqVO.L.GqLTXPsibO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 49, 35, DateTimeKind.Utc).AddTicks(8656), "$2b$12$bd6ke3o4hgVmzapSe7dLHuAiYtkvzapnRzzKQptmjlQCPQzyn.ng2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 35, 205, DateTimeKind.Utc).AddTicks(4994), "$2b$12$8gUjwew8iKE4LEPp5JscrudmrOxfupdhWHSLEbwYbKnL8JMcyuyWW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 32, 449, DateTimeKind.Utc).AddTicks(4350), "$2b$12$6c4wwpFMLnkl8TIVvaU2KetAkK83EyqAZo0K9P1ML7f.p8v.pM3uK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 36, 758, DateTimeKind.Utc).AddTicks(2903), "$2b$12$oudjG9Q8AifcYgx/4lZ3ZuYg48IOz90Eqw.xzJ0ETtlSHsfRQ4gfC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 52, 716, DateTimeKind.Utc).AddTicks(8573), "$2b$12$oI4Dnb.X20BvakDix3l0WuVg1Z52m.FSdkSy4iOJTAwa2MGplDMTC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 3, 808, DateTimeKind.Utc).AddTicks(3076), "$2b$12$qTbrA72mpAzmwxaV5Rttz.32KlZ3HqyzE89jbufMK8VYVK.HKWd4y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 33, 669, DateTimeKind.Utc).AddTicks(1434), "$2b$12$CtjX5JoBhNv015WsnhdcwOwkVsY1HKxs4JGI8b1ZRUo6M8.wIoUTi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 5, 326, DateTimeKind.Utc).AddTicks(7888), "$2b$12$heZY77K1hOajm.I6jQyu7ufB1hqvT25BrkM0Utrrvas3zsN93lR6C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 55, 676, DateTimeKind.Utc).AddTicks(9651), "$2b$12$qxAbUDiQX2IM7iQDYlHKG.zF0HOJWKrXUWfqV4oDSd88yMXq9iGkq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 41, 955, DateTimeKind.Utc).AddTicks(3268), "$2b$12$S5ziojmvzLAer6Qro/nz.u5u55r9N4w0fwTQ6vXH2YSxQBfapThES" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 46, 568, DateTimeKind.Utc).AddTicks(560), "$2b$12$WYFHbiWRFANiWzybQaKxHuS7faytg13h3DILGmuxk519qXbKvz3He" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 6, 580, DateTimeKind.Utc).AddTicks(4314), "$2b$12$GMDc.TULbeLcdlWSADrli.h0QcwnSkJ/pwzNFqgHpxhwL.Yk5P7TC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 58, 619, DateTimeKind.Utc).AddTicks(6670), "$2b$12$cNH0SxJK0bUXuG32Jq6hV.wR.VJiACH6XGdqkn1oQnL4AD86zdLAW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 50, 584, DateTimeKind.Utc).AddTicks(7780), "$2b$12$TOxbmvs.0ZawMqgUYu3g4e4nfke52Zc81Rv47BPQpUnfhlXfKWKHu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 48, 410, DateTimeKind.Utc).AddTicks(5088), "$2b$12$AGfAojF4imdVsCYFBj8taOA6l00aVAlF.T0JjhnOMWe2Y5Ni75vbK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 37, 62, DateTimeKind.Utc).AddTicks(2686), "$2b$12$iWSzTL6F.TiPoUhYgj8f9e8yxONna79cR12UWqetqTRg0PjaaARWS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 38, 597, DateTimeKind.Utc).AddTicks(4748), "$2b$12$9z4.lSAxklq3FXw7B1BBEusv30xq4uE024HFB9krXNP2PHAA9S3f." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 56, 666, DateTimeKind.Utc).AddTicks(4206), "$2b$12$1A0yHNyahLwCvdzDSzyr7OwcodLns2rLTQ.f1HZw9mEej72HNeMNu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 7, 493, DateTimeKind.Utc).AddTicks(4105), "$2b$12$MfxcOjTW8VczlCwPXu7eFutR7VYuD6UQuUVtOpZofVCk2EHbF8YmG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 3, 201, DateTimeKind.Utc).AddTicks(3562), "$2b$12$A0f5wbTPJCWsL69YrTlYqe7vqn25SXDjdMidWxx3IR3QxHQ2simY2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 54, 999, DateTimeKind.Utc).AddTicks(548), "$2b$12$o4EniecZgtU1N/jgrvCiaOA7X5mwXCinHXON5SAhrZWdVcaPbPBz6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 37, 974, DateTimeKind.Utc).AddTicks(1752), "$2b$12$yfSvvAZSI2YSWgUICCccmOx2cNwhPgG35pAjKT8Fjmvuh34D6XyU." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 47, 490, DateTimeKind.Utc).AddTicks(888), "$2b$12$1jevL4qqbJvnTVhfhlcv6uKzBjZnCx5iEgY/aWi1E5.Olup9y.Ury" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 44, 97, DateTimeKind.Utc).AddTicks(4292), "$2b$12$KzizFbgb0yNnx3gJXheL9u701QDpEpv31.HQIX1kRlPknd3VOisJa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 38, 902, DateTimeKind.Utc).AddTicks(6965), "$2b$12$T7c.HqzNuuPuZoyIjW9O2.Kvc9rwzR2hfMctMuxcPOymuQED4hg72" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 51, 502, DateTimeKind.Utc).AddTicks(974), "$2b$12$QAM3bSBt3YhgWcsZUcCG7eZhSb2LToCZmCyukHwdsn58.JIBO/2XC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 50, 254, DateTimeKind.Utc).AddTicks(8988), "$2b$12$iZLvX4Og37WEzKo41TMNZetc8FKJ.BEEc0xoIYGZBJus87wcFmobS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 51, 805, DateTimeKind.Utc).AddTicks(5003), "$2b$12$SqBIBugXt/ulJENtpb6xDeruuCKH/eWPl39xBuqWn1T.uxY3tg/EG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 0, 445, DateTimeKind.Utc).AddTicks(2406), "$2b$12$Bb0pnrRGBzGrMrpM/k2DNOFen3.Z0.VgGhWfIvkslfJhrZQQ6iePW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 57, 943, DateTimeKind.Utc).AddTicks(3778), "$2b$12$4eKRnyq32GrCumvwku/iT.CmtjtO8y95hxMZLRtTSshCZl3eaz4/m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 53, 977, DateTimeKind.Utc).AddTicks(8094), "$2b$12$DH7aFD4a7UcZnqwD4XIfNu2BcoP1sO0AduBWrf8p0U08v6qubj91S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 56, 982, DateTimeKind.Utc).AddTicks(2873), "$2b$12$Ei2c0KnzRF4zGj9Wee703u4WWDhVds4ArQcsGbVWeAjMwglbEIQOy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 44, 704, DateTimeKind.Utc).AddTicks(6461), "$2b$12$sWizKl/K11iP8pfGLACQVe2n43H9r54ySH.P5gTV6cUr9iy4wcl/W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 39, 207, DateTimeKind.Utc).AddTicks(1724), "$2b$12$1J4fVMg0ETlkD1.kRo5E..e/ZSw.SBUYNQYvwY51Eg4Y6L/e69Jiq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 1, 982, DateTimeKind.Utc).AddTicks(7410), "$2b$12$Q4HUbNVpFjtrSaTB6mrP3eYOLT8bFN/0Nl5172QvKqmWfO17R59Sm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 44, 400, DateTimeKind.Utc).AddTicks(9165), "$2b$12$ihfO0a9Qz70Wj73tGqNjAephqBpaK.f8XAhIHuVWYigOhhwgp4H56" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 43, 183, DateTimeKind.Utc).AddTicks(3130), "$2b$12$T7cIC37jvnHQ8xa8S7wRjOyxk.C69dtSxceMSx9Jv9JGgq59g2Ge2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 1, 677, DateTimeKind.Utc).AddTicks(3653), "$2b$12$S6Vm.B2tGYMpq/rqQFGww.A7ReA7qyDnDr6/.kokFivd/jXWrnRva" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 46, 871, DateTimeKind.Utc).AddTicks(6367), "$2b$12$dYxota0lj/stMMk3rTVK9OWdUCESQ/4KTKrCHBvODJ7AY2xk3/lxW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 54, 307, DateTimeKind.Utc).AddTicks(5245), "$2b$12$q4mzOinKASrBpvcEINZJbOpp/6rucWDtyDKhBZA7jYghzev3m7AH." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 43, 486, DateTimeKind.Utc).AddTicks(1194), "$2b$12$T6HJzoYWxcGJT/pfc3tO7OHuUhcoxfNXVmn34FTe7klC5ITR/SSXW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 45, 625, DateTimeKind.Utc).AddTicks(7639), "$2b$12$w1s9wt4JBYl5oYiEk2vZwemNQ3xuW31iOnpgXn1olgVe8dGKl3ST2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 5, 23, DateTimeKind.Utc).AddTicks(7024), "$2b$12$FeeyFNO68ss9xnUU6AeS4.SbxCMIEdvizdOJsZCxYOqZTlbY1.f6y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 2, 287, DateTimeKind.Utc).AddTicks(5205), "$2b$12$ZnY3A3Ca3TZV69kgPevtlOY7Qe/AZtobUt1xhgbii.fxEfSnceOlG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 0, 754, DateTimeKind.Utc).AddTicks(2948), "$2b$12$//ZqQK4jS0S/RRuudyjjjuJOiCHQnWo2j3C1BxDUmKLg76OpbaU.q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 59, 532, DateTimeKind.Utc).AddTicks(2661), "$2b$12$ZTtPruIKIdjYsb7pLA1nkuqaLE0jJXkX5F0D7r0R1.UFMmSmSEJ8W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 54, 642, DateTimeKind.Utc).AddTicks(6641), "$2b$12$4cRPDjgj.880wy6zSFNmseGC7xU0sDOM/0gYJXqIe842A2kY6jbla" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 49, 339, DateTimeKind.Utc).AddTicks(8990), "$2b$12$yWNiD0z.Tu1C6nKlUV9GHOPN.p2zsP.DOIiw0TP1RM5cb8N2kx4Au" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 5, 632, DateTimeKind.Utc).AddTicks(8546), "$2b$12$R8lFhKZWlPq5TUSwDvCx6Oo3aYvVsJ4/bXOjf8vTmLjkTp8rDSMJG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 47, 175, DateTimeKind.Utc).AddTicks(9836), "$2b$12$oWTt9ri9Lm6DwBePQpEm0.2D1.N9mmuoejd7gokttOlKwZJs0m9Ky" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 41, 651, DateTimeKind.Utc).AddTicks(9464), "$2b$12$QyugGu0nWT9dcQa65LvgT.Q6E7C8yucuMF/TnZZOsHBazKTt/jphC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 30, 927, DateTimeKind.Utc).AddTicks(2676), "$2b$12$UV.AvG/B9O/Onw6f7FEaw.jUyj7mBFRqg6uC.g59Nj8zh5oSh4Fn6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 39, 515, DateTimeKind.Utc).AddTicks(6824), "$2b$12$UlobKcOPNel3DUmuPPBcXO6g55.i.kySpAUTmXtYFVZ357y2R9.0m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 56, 345, DateTimeKind.Utc).AddTicks(3354), "$2b$12$0PS/qZMWyYZUb5DpD7knEeH/l/nfQCGX2c16j3Psr3VSf5IoNukM6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 34, 287, DateTimeKind.Utc).AddTicks(7797), "$2b$12$Em0/HhjfAPVmJuOxe9EPQug9U/2wMlkX4LUmZWcXhhho.PalNHHcC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 41, 348, DateTimeKind.Utc).AddTicks(3681), "$2b$12$UUMZ1PSgT9E4Bl7LczbQyOUzW3FJhLUisoQH.oVgHu/mcEDfBOQVC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 52, 414, DateTimeKind.Utc).AddTicks(14), "$2b$12$GTugsG44N4lu0Nm2L5JiDOX0ecvKJKn5RojK.ul7IRFtO8qb6UJpG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 57, 300, DateTimeKind.Utc).AddTicks(8796), "$2b$12$.jjPbSX1GAECeR6ripyZPuMOEbqN01pWWFjudM3Qpt7ZDddcssvM." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 53, 631, DateTimeKind.Utc).AddTicks(4771), "$2b$12$NkoQRK42YZN9tVJxbqG9U.sHPcAp4uT0rJ6GubWCqtbk4Jdclkrzm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 40, 435, DateTimeKind.Utc).AddTicks(3503), "$2b$12$9SYgtXab5H5POgP.xF8oqu5lhMbJTouWPdZf4qtztneKrFW4C/lxm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 56, 27, DateTimeKind.Utc).AddTicks(6511), "$2b$12$C7kuMk5YIi71kkNhlCaNGugycrUQCcdOuhqEl44vV9VaUd6Zb4Iji" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 48, 99, DateTimeKind.Utc).AddTicks(7463), "$2b$12$YK8En1jOAEADuRnmujJ3oOyyN08nAESBN3Xxv2PKiw/AKOX153IXe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 50, 891, DateTimeKind.Utc).AddTicks(4647), "$2b$12$UD0c0iXK5hZDaMi.0CeskeYsKinRM0Q66NVqi5JvkzeV687eL8jCS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 37, 366, DateTimeKind.Utc).AddTicks(1726), "$2b$12$avYMV51bl8apL8wQ3dazEu2Ugs4hywmek6rFMA4NmtmfTiE7xfEPu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 34, 901, DateTimeKind.Utc).AddTicks(1887), "$2b$12$Jq0sAEtEKDAxCfH.90HbvuZ1LVY5c2Uzid9fENkN33sH8aQFM6kF." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 33, 363, DateTimeKind.Utc).AddTicks(6055), "$2b$12$R2p2xumCc7QJswgh1cQH6e7xLzimNgBw3ZAYNUd9.oMwQlPZR6gbm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 49, 644, DateTimeKind.Utc).AddTicks(2362), "$2b$12$EYSoMBDecvCvRWHo/6YWqOzj6RqhZvGYuIduH/m/4vlcQlmE5sYYO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 42, 566, DateTimeKind.Utc).AddTicks(7017), "$2b$12$oHwxLvdiFrrv0.vmpWz6BONlepHfZA0TAfclYGfefsyP7tAWzMU8y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 31, 231, DateTimeKind.Utc).AddTicks(6855), "$2b$12$Mzb.0sUlUjnTNKp9n0lnQeIvLslfXRfuZ1UI9pVSkhRCZ/jWePNMC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 43, 789, DateTimeKind.Utc).AddTicks(1522), "$2b$12$FSHFZGtdZ7M5hN.PHSMqouu.a82UsyCjFZlFiwYEWRLzYpfa0Akpm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 58, 923, DateTimeKind.Utc).AddTicks(9464), "$2b$12$uJybtBPl.640XbFagg9z4elUZWFp8qkvUYg3Vqox6PYM0NfGs1Vle" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 35, 509, DateTimeKind.Utc).AddTicks(6819), "$2b$12$YT7vurcozpJLHloxDtmUge8NS2gAy9Cs2KNFKTuknwwKrxx5gtdXO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 45, 962, DateTimeKind.Utc).AddTicks(4651), "$2b$12$tYu2HG1QbsLbPIOlLZKxUer6hsE7NeUZlyl.jyyOA4FljSRVzCnJu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 46, 265, DateTimeKind.Utc).AddTicks(7962), "$2b$12$REHDRJ6JJnZ3n6zNM2NP/.8Bxi.1jE2c0og.b1mdTL.eiWipD3ciu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 5, 971, DateTimeKind.Utc).AddTicks(7171), "$2b$12$ZqhPlARJ4eBimlw9fgNy4.MhFeyf/lVleq41EJpcdYNi4pi1gKgPi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 45, 10, DateTimeKind.Utc).AddTicks(5081), "$2b$12$1MUyKPdzbOaHcj08Df7KP.6IAbMBdOdQMxdywaogtTAV9WhKa7jXe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 42, 870, DateTimeKind.Utc).AddTicks(5020), "$2b$12$z3xFL8U1vMs16eTu0YlRZu7mJ7EOhQygkKHNHXTmtaRnCFO3WkwUi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 1, 59, DateTimeKind.Utc).AddTicks(666), "$2b$12$xMonLzN9B96DGQATj19MeOJI00XpUgbyfgdaPd.G8slDbb/.zDycW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 40, 129, DateTimeKind.Utc).AddTicks(5995), "$2b$12$esQFVdQ0XXAywbl1FcJ2RubAkeqIBqbwl5yIQvtcyBeBExLsPZTuW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 3, 4, 416, DateTimeKind.Utc).AddTicks(1550), "$2b$12$mWW7zgfrNyHOq3qgvGXL7OsAXXZZFQqk06o.Ov8xeVAOOlxwGbnAi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 59, 836, DateTimeKind.Utc).AddTicks(7344), "$2b$12$7ehvV83hXA3eT1HLs2unAe.Ls/vfulL5umfr.gqHfoPO2BCWUW6Ka" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 36, 454, DateTimeKind.Utc).AddTicks(4034), "$2b$12$5SG0nylSagt5DpZU/L3siuUolpvD.a6N072B3oaag4LPgAC52H4zS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 36, 151, DateTimeKind.Utc).AddTicks(3966), "$2b$12$c4aFf2P3TBVOY5kBp6nThuYuK8Tywjvjxa1kGEB5jS1VlNEcLFCEm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 39, 822, DateTimeKind.Utc).AddTicks(459), "$2b$12$GMJPllS29pTfbzhzBIBl8OC959hCy94r2fuRBpUgzi04iSOqgx50O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 2, 32, 753, DateTimeKind.Utc).AddTicks(7320), "$2b$12$EEwVDQStsSXWQUo/6/3JrOiREpifjUDd.zz5QZV2ZCPtPLIBCX6xC" });

            migrationBuilder.InsertData(
                table: "Attend",
                columns: new[] { "group_id", "session_id" },
                values: new object[,]
                {
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "013253fd-915e-ae02-98e4-8f6204070217" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "017daad5-244e-acd2-1ce4-07c75f5c9f04" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "0307a4e5-0941-b6f9-6e98-e48ede3c5f57" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "042c2061-f2ce-afcc-e0c0-a7bbfcebeb13" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "0733286f-fa6c-43ea-5ca3-7184db85512d" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "09d5852e-c85d-b871-49a2-71c8d434e139" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "0b8c5e9e-5f59-32f8-19a0-b9e05ef5e471" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "0c68876d-2d68-d530-2757-956294ff1bed" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "0cbff9d4-4613-2d77-f1a3-6e9f4238a87c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "0d647b97-8742-6f60-67ee-364224b37cd3" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "0d9f5e1b-8b16-6512-1aad-b6fc5bdbda7f" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "11219807-2307-1246-8bd9-cd76bf2b52ce" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "1133eac0-f2b9-5576-b0b6-bef1f79782c7" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "114acc04-a14d-ea71-5c54-bb541e5bb9af" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "13000bbc-8fd6-1578-7278-d709f023eed3" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "1491b2d9-7dbd-4050-013b-0d4c38aeb869" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "14a89b1a-19ff-ce17-300b-e17e3bd1077f" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "14cf4c2a-44f5-3e25-70c5-a8ad8fd3e3b8" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "15ba8680-1073-bb6c-6f10-054644dff3ca" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "15cfd3d2-8bc4-c1bc-7fd9-d3de7f5d669b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "15d70dbc-6c98-76b3-999c-21437cc800e5" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "16a954b2-61f0-b37a-7693-a0b61d5aa2e7" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "193842d1-67f8-7b4a-04d4-8ad3f57b6cb5" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "19f8d59a-321f-7873-3ea4-4c981946832d" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "1b0c902d-ad55-90ab-57d4-16427ad6c740" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "1b37d5da-f4b6-cbc0-bbc2-8fee0570e9fb" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "1b80b598-780b-bea4-5a24-19940d4a38e1" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "1d551b56-0c89-92ea-bc4f-58b3b9bad9dc" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "1d78c887-7aa6-132d-0217-f7b43b77bdf8" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "1e6bec97-4c0e-5908-667d-688e7511f7c4" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "1ef93c61-327d-3b0f-db94-04acd6213a5f" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "1fd5f3c7-4c47-19c4-61f0-665a537bec8a" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "23a6ab3d-60bd-4148-2d32-cd648026c5e8" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "249c0eaa-9905-1383-8fca-affda7f85f7b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "2593023d-cd4b-3a13-8456-8605799c009b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "2599f89e-0977-b58a-0539-f65697c1c75f" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "25de3c2e-a93d-53f8-6982-c678ad47cc54" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "289a7bd2-5839-a841-3c7a-6cd2cb327c1f" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "29f09856-4a06-7009-67f4-1b47f3735322" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "2a77192f-3516-2af5-1c2f-efb27ff44dff" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "2b56efe3-8b66-93ad-54b4-f5517a0c3cb5" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "2be3fbb7-603a-37b8-9886-8cc179a60c00" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "2db3f185-97dd-9f4e-3813-f595191b3ef8" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "2faf2f20-145f-cd9c-fcfd-afbf11172030" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "3149b3f4-1518-8b57-abdb-7e08d36f7861" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "31684066-8ff8-ec8d-d574-7994a009b471" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "323b5584-bd42-9b8b-ca3b-7683360e02ad" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "32508cd9-8a12-0bba-b62b-aa26d542bf43" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "325dbc6b-3915-11ff-5664-566a43aedcce" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "32e0e5ec-8a8e-9958-11b8-3e1fdf2c9022" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "338ef414-55b6-57f8-6cbe-eba50b6858da" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "33ff2701-91f8-d78b-7a7d-2e8699300904" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "35769633-5a71-b8f5-cd23-34959e70feef" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "35e80a17-a920-4848-28dc-7e49a1b1d450" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "362f0228-aba7-6c24-8de6-b0f8e8f0fca2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "363f0139-5ea9-5659-b4b6-d31f10c6e1f9" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "3a0dc032-1305-74fb-e0eb-b5d26843dce0" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "3a184df7-7d52-f9c0-8fcf-d65d15495f27" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "3c5a71ba-2254-b3ed-67ec-f64c0106c660" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "3c94d190-986e-a736-87ca-6787d693212a" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "3eb203dd-c874-2718-a2a0-3fc6a3d7ceb8" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "40ced4d1-1d5f-05f9-1ecc-008ece9bf6cf" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "425b45c5-3bf2-b3cc-a8fd-011c300c5b6b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "42c4e64b-5f37-7428-68d0-ae73dd07c550" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "43218475-c208-8bef-45bb-cead9439d8b2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "453afb2c-a5b5-3cf4-f188-1fa95fc15824" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "490f3cf5-28f8-dece-4922-52671fb4a199" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "4950a765-76b9-83b3-7de9-af0e949338d0" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "49a1f7aa-8859-4cc4-b546-4549f789bf3f" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "4aff05b1-2e8c-eb11-a7d0-dc28213597fa" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "4c7ef4e4-6089-5b54-70cf-462a7594d3eb" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "4cce25cb-d6a8-8892-ccc2-05059e6a6f16" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "4d46411f-dba7-37ac-8814-c7da719f6e3b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "4f1f9725-101c-80f7-d008-fcc9271993df" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "50a9ba02-e020-16d3-df51-fb9c4b19bd0c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "52255222-934c-c40d-8d7f-7c438999b75b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "53238bae-d873-e113-c07b-94f7384f2a4e" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "53bed5c3-f54e-2f3b-5ffb-c3d75fdef22e" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "5582813a-cf75-d0bc-d6ea-164333b8f078" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "55db5c7b-8e15-4375-cc5d-227a06438d38" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "5614c18a-417b-4621-5dd4-a17203b6fd57" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "565b9687-a776-3cef-8994-bc338c6f1895" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "5826bd17-eeda-6222-b4d0-8506d1ea4f1e" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "594df6b5-390a-e031-8c8f-ec7beecf5380" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "5b05b08e-6f73-e22a-e582-c0117147df20" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "5b638516-0759-9513-853d-bbb34b652783" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "5c094776-5acf-2f84-62b1-e51885ebdbbd" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "5d8585f7-072c-3acc-02d3-036830d0eb38" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "5f1cbb5b-c8cc-7cb9-7692-cfff312ba139" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "61a67da9-b7bd-4555-9cf8-c6341152be1e" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6381a78c-fcd6-d0a1-c4f5-09323d5ec98c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6421d373-2d22-5d19-eadb-7e134fb1514e" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6634a192-1867-c0b7-3d6a-f40e9451b92c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "68b4d308-be73-447a-aa01-94326f1d8573" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "691660f9-12b9-5e11-9261-206ceacd9e36" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6a26bb2b-10b3-d20b-576c-06ec7eb6881c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6afd119d-e28e-92e8-9e89-1af6996f754c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6d007abb-5e1b-17af-b0f7-2c47514aa643" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6d5ab6db-8f30-6091-2cd9-ea7f969fcbff" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6e7e7ad1-76f0-2a98-4e52-aad698b8c7ad" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6eab02e7-1426-0881-1c74-99cbe1c2dabd" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6f546c47-26f1-7ec9-b641-fc447770b8d5" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6fd6173d-eb18-e8d7-405c-66721548558e" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "6fee2eeb-59d2-0c00-9a1e-8a30811ae17f" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "7094d547-fd86-a3c5-b337-839b1e5c317d" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "718c2d6c-578e-b7c9-1e8d-5bc67c063ea5" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "74775c4f-426a-3783-b04f-ccac0b514278" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "74ace139-e992-d91f-4671-52f639972753" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "7600bbe0-0a15-349a-b9ec-c475880ecfda" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "767d2088-ae6e-01a3-af51-1f15e4010867" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "76c7b55e-03e5-9b52-34d3-5a7ffb9c90b6" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "7755d2e0-e594-43f6-6b2a-97e09a800704" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "77584882-18b2-c070-5e41-8b0e717367db" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "780e8022-e459-3d7f-a36b-47992b26ace5" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "7978f9e1-f848-3ea6-bd32-b7ed5c2ba948" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "798ddc1c-e359-941e-9460-c187af5e53f8" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "79e9a30f-cfe9-2f9d-cac4-f86e3962d70b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "7aa3c75d-1047-67fb-2ace-ac1a1a10d694" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "7b197240-8dc4-4b9a-bffc-03041ba80ac3" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "7bccd9ff-6129-4373-38f5-54b69ffa2532" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "7d8f0718-91c6-2cab-268a-090d429358b3" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "7e81993e-6a54-b9ca-8ca1-a5dce75296d9" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "7f73fc92-af72-477b-9c37-49b6779a08db" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "80f54d52-7c1f-5ff2-d278-d08cb6fbe663" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "812aabb2-c7f8-2548-e7b2-c7c99cfa0b51" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "82854779-bd50-0aaa-177b-dbe72002170a" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "82a38202-4f6b-41d9-11fc-0c59d2bdb4a2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "842306fb-458c-d097-eed8-909990df3d1b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "852e46ab-b00f-8054-4ee1-5649cb845174" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "857d4bd4-f8b9-a253-5f74-06ed5783b8cc" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "85e1b30b-426b-ad04-17fe-fc152cee3378" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "86096d2d-028a-2178-b93d-d09c58fb798a" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "873dd793-925b-cf55-c4ed-19f5ea134c5e" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "882637b6-a3e0-c6f0-5adc-323fbaf06469" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "895ad2cb-c1d9-f871-0b4f-6d588817d0a2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "89af6c7f-eb9b-700a-1edf-c780be219657" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "8a1b0119-fe28-9d70-3d44-4f08f1cc15dc" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "8b4e0e39-d22a-6b9e-f265-f1e56b32a5ac" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "8cabb15c-08a5-3226-7620-6b7fd82c0ec5" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "8e9adcb0-97f0-f605-d063-0d6f594f51ba" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "8edbb040-f6b6-44c8-881c-6d2a3d8b7775" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "8f6901a4-f5b5-e843-e991-5ecb27c6d119" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "8fce3dc3-2a8b-c124-f96f-6798c213bfc8" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "9343be38-6a9c-9597-308b-b7a380d3341a" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "93acaa36-b84a-93e3-4ab8-bee3839813c8" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "94d53d90-c40d-2c7b-5b09-1fc3733efdde" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "95280675-9478-c286-6e61-5eadb6e04ce7" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "96cf1edd-649d-c6e7-4f3f-63bb525f08b9" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "97732f97-a471-d97e-a1c9-5f1e65501cb8" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "978254e1-40d5-bc41-fd06-9909777893d6" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "98a3af77-666d-b843-1550-1654d066a91b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "9aec3604-2382-813d-dbe0-e829167d4d03" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "9b04b38a-df80-4890-3b63-b52fc684befc" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "9bb332c5-28e6-8114-a6ad-33361e1c176b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "9f1d52f5-5854-6344-7ee2-50b3aa2206aa" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a1dcbe22-1a98-b101-6d9d-6a1e43eecad5" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a2eca7c6-6ded-0447-2d46-a31b5047bfb9" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a4637bf4-ac5f-fc18-4f21-5d6060423cac" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a515b538-facb-a384-2fc0-09bd704b792b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a5ba5432-532b-bdc1-4517-8f6657b06ccc" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a609799e-8e05-578f-a027-ff94df7272f6" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a6be719c-a6d5-4ec4-f3bc-079e2bc133f7" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a6d90d38-fb40-67d3-9291-4dc9433685ab" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a8052858-a628-5c78-0ee5-886932034146" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a86586f4-63ee-788f-6c4b-375c8c07cc46" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "a9291ff8-90b2-be6e-9878-5cf2b98adf51" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "aaf5124c-ec73-3718-9708-9cc8a153aa21" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "aafbf12b-4fbf-f7ed-baff-ddb60852ded3" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ab9e93c1-9054-3de0-5468-8fef169e2733" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ac1087ea-7cca-ba5d-4716-69ede045aac3" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ac148527-f1ee-3bb8-7a18-397adfdb9684" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ad51b75b-94ba-2db3-71d6-9937a00564df" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ae09acad-eb08-db70-af74-adc1671104e2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ae9de472-6ed6-c56b-17f8-0802b30e0ead" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "afc81f01-6ce3-5947-ba22-725ebff80699" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "b1a62097-cc7c-9e22-017f-ade4e5e982e1" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "b1ab77c6-75e2-be65-fd4d-2216d7df9169" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "b259425c-b08a-20ea-60cc-b695e91844b7" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "b3918eb5-f713-95f5-c1c0-7675b7e0b333" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "b7631fc1-9896-70c6-3e36-19135b902372" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "b916b170-861c-b14f-ad0a-9b5bccd2c0ca" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "bb39bb03-38d6-cd02-b341-89e2a660da76" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "bb543979-51da-e0a4-508a-34e41cd9c765" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "bb5e6b6a-0c42-fdab-58c4-fef95fcdc49d" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "bc3ad3db-d8c5-02d3-d06e-5f94d53d9f78" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "bca7d63d-cce4-43ac-f1ce-560fc47e3074" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "bd85547f-e0ea-e2db-db8d-c415c58afb06" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "be7e99bc-ba4d-f226-9d8f-03682d23bee1" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "bed021d1-ed16-adf0-c5b4-2953fa35048b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "bf1e2694-409a-773f-6c59-a05a8af0527f" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "bf51ec1a-fa3a-3c43-080e-494a6f7e3910" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "c15c6cab-3590-2006-a628-67612870eb60" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "c2516a1f-5f3e-7e0f-7b86-9053846377c1" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "c35fb6be-96f6-0788-f95f-8449add9c5b2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "c3dd11cd-08a8-d8d0-60c4-add26094c881" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "c565c6ba-ecac-b786-5785-0744bdfcabc2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "c584e914-d15b-6c1e-b33b-e87707b1c8f0" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "c6a456ad-719f-6857-0f33-b79bec3aec14" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "c6e7c556-e76d-2b22-aced-041ba0d8cb09" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "c8126fe8-b8d9-89f3-fefb-a1e84543f875" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "c9ca3188-8a21-724a-23f6-5d9e402ab287" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "cc712312-dee1-743a-9da4-ee708f3d06e9" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ccb09398-5ba5-01ed-ab10-93ede45a2ff4" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d01019f9-5218-71f9-d3a9-35cb7b04b12b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d0486529-51fc-62a5-004c-ecd5002ccd41" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d0f8efdd-4c40-b515-a8d1-d855a962a852" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d1ae562d-8ff5-04f9-e4f9-be70373beea0" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d2041949-1d00-ce16-fc7c-30c218a75f46" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d32c9013-9fb5-9f83-708d-3e02f83631cd" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d3edfa54-1262-d190-899b-a472871c59f9" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d4a343e2-40d5-57a3-222d-bbcb5fa7a60c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d50e4726-2991-977e-1e9d-ccae720f4778" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d5e30992-c7fc-e449-6e8c-e9ba67574c4c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d6285f6d-f25b-009c-7042-a47f4b244b68" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d6442191-6705-0a50-37ea-73d811f12b11" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d698f229-ec8e-a652-a33c-b1dfd62a38e6" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d8ee1684-8213-4b12-219c-66a273f8d1ec" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "d96fcd78-c30b-080b-c92b-7d26c7dd221c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "da5a50be-4892-2912-7d30-e020f44c2bf3" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "dadf92d7-0a66-08ff-9067-d63a9ac831f9" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "db390cd5-f0eb-b466-37d6-608ce90540a5" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "db8d2ab6-946a-1502-426d-fcb21953e405" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "dc15a337-285f-ef85-0d15-e43c62677ee0" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "dd9e690a-8f67-72b4-629b-15a9d4cdd73a" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ddd77ae8-2557-f2dc-0582-c2c104a0a18b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "dde5dca0-3459-b459-a095-94f8a5eb4711" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "df815484-6a48-1b4e-a7ce-2b2a4a85d3f9" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "dfe2714c-934c-ef19-fe94-6c4db509862a" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "e0bb8201-c45e-a7cc-9a4a-f0921c6fd86c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "e1738f37-9fc0-61b6-284f-5715db5ab025" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "e2513fbd-3f02-efb1-92e4-4d7524a0a9b4" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "e260b095-b963-c13b-b5a2-d609ac8bd890" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "e7d00346-218a-3d24-b03b-7d2cfa8d6d7d" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "e9479010-3a2b-6354-2e0c-11b49b24fb5f" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ea06b88f-d8a1-ee08-bc3c-d84a42ccdacd" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ec071909-de0a-3e67-a7b9-4a4b07d9de99" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ec341556-c367-708a-11c4-097536f47dcb" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ec421852-921b-ebfc-d739-8212e4385e64" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ed3dee0b-d891-bd85-2ec9-065516fcd123" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ee921d29-66e1-c443-c162-df77ae566e01" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ef04b83f-9b1d-9814-3a9e-a3c0d292ac3b" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "ef55d5ee-4787-d8c7-b1fc-0862746ac28a" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "f13edc40-466a-6629-9715-d914984c3653" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "f4c16c8e-12ba-3b16-0555-dcebf1a93e21" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "f509123c-dc8e-d71a-ddbf-4cfe70107308" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "f5bcb9ad-0454-f4d3-389a-3f1d78dc2a1c" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "f692a256-8b14-1f69-5d15-3c1942f5c5f5" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "f723976c-ee91-b770-e7cf-4c2ddd2e10cd" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "f8cd0d8c-907b-551d-6211-931279dc0942" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "fab65069-a16f-8092-41b3-2dfadb5b84c2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "fb099bba-fa75-cc47-57ac-dc2ce717cf7e" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "fb4dd0a9-4c1a-c15f-1c5c-83953364fcd2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "fb91193d-c432-36d3-5e89-59f7ac76cab2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "fb99eb83-8abc-f0bf-d8d5-d3ea90a38837" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "fc3c2b4d-ee65-87b1-8670-116de9888753" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "fc5fd85c-a36e-f72e-7eb2-0ae8930091c2" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "fc730fac-20a9-8127-7fda-2bd0fbf14448" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "fe2403f2-62c7-83ab-fb2a-f4d6cb4cea82" },
                    { "e61277a9-9d07-5b53-e623-528bf88a6962", "fef0fe5e-f84c-8548-71ef-b871756abbf6" }
                });

            migrationBuilder.InsertData(
                table: "Teach",
                columns: new[] { "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "013253fd-915e-ae02-98e4-8f6204070217", "296e74bd-c209-7f7c-d030-28e85a1aad75" },
                    { "017daad5-244e-acd2-1ce4-07c75f5c9f04", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "0307a4e5-0941-b6f9-6e98-e48ede3c5f57", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "042c2061-f2ce-afcc-e0c0-a7bbfcebeb13", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "0733286f-fa6c-43ea-5ca3-7184db85512d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "09d5852e-c85d-b871-49a2-71c8d434e139", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "0b8c5e9e-5f59-32f8-19a0-b9e05ef5e471", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "0c68876d-2d68-d530-2757-956294ff1bed", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "0cbff9d4-4613-2d77-f1a3-6e9f4238a87c", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "0d647b97-8742-6f60-67ee-364224b37cd3", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "0d9f5e1b-8b16-6512-1aad-b6fc5bdbda7f", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "11219807-2307-1246-8bd9-cd76bf2b52ce", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "1133eac0-f2b9-5576-b0b6-bef1f79782c7", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "114acc04-a14d-ea71-5c54-bb541e5bb9af", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "13000bbc-8fd6-1578-7278-d709f023eed3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "1491b2d9-7dbd-4050-013b-0d4c38aeb869", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "14a89b1a-19ff-ce17-300b-e17e3bd1077f", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "14cf4c2a-44f5-3e25-70c5-a8ad8fd3e3b8", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "15ba8680-1073-bb6c-6f10-054644dff3ca", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "15cfd3d2-8bc4-c1bc-7fd9-d3de7f5d669b", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "15d70dbc-6c98-76b3-999c-21437cc800e5", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "16a954b2-61f0-b37a-7693-a0b61d5aa2e7", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "193842d1-67f8-7b4a-04d4-8ad3f57b6cb5", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "19f8d59a-321f-7873-3ea4-4c981946832d", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "1b0c902d-ad55-90ab-57d4-16427ad6c740", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "1b37d5da-f4b6-cbc0-bbc2-8fee0570e9fb", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "1b80b598-780b-bea4-5a24-19940d4a38e1", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "1d551b56-0c89-92ea-bc4f-58b3b9bad9dc", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "1d78c887-7aa6-132d-0217-f7b43b77bdf8", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "1e6bec97-4c0e-5908-667d-688e7511f7c4", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "1ef93c61-327d-3b0f-db94-04acd6213a5f", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "1fd5f3c7-4c47-19c4-61f0-665a537bec8a", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "23a6ab3d-60bd-4148-2d32-cd648026c5e8", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "249c0eaa-9905-1383-8fca-affda7f85f7b", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "2593023d-cd4b-3a13-8456-8605799c009b", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "2599f89e-0977-b58a-0539-f65697c1c75f", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "25de3c2e-a93d-53f8-6982-c678ad47cc54", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "289a7bd2-5839-a841-3c7a-6cd2cb327c1f", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "29f09856-4a06-7009-67f4-1b47f3735322", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "2a77192f-3516-2af5-1c2f-efb27ff44dff", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "2b56efe3-8b66-93ad-54b4-f5517a0c3cb5", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "2be3fbb7-603a-37b8-9886-8cc179a60c00", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "2db3f185-97dd-9f4e-3813-f595191b3ef8", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "2faf2f20-145f-cd9c-fcfd-afbf11172030", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "3149b3f4-1518-8b57-abdb-7e08d36f7861", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "31684066-8ff8-ec8d-d574-7994a009b471", "296e74bd-c209-7f7c-d030-28e85a1aad75" },
                    { "323b5584-bd42-9b8b-ca3b-7683360e02ad", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "32508cd9-8a12-0bba-b62b-aa26d542bf43", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "325dbc6b-3915-11ff-5664-566a43aedcce", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "32e0e5ec-8a8e-9958-11b8-3e1fdf2c9022", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "338ef414-55b6-57f8-6cbe-eba50b6858da", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "33ff2701-91f8-d78b-7a7d-2e8699300904", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "35769633-5a71-b8f5-cd23-34959e70feef", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "35e80a17-a920-4848-28dc-7e49a1b1d450", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "362f0228-aba7-6c24-8de6-b0f8e8f0fca2", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "363f0139-5ea9-5659-b4b6-d31f10c6e1f9", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "3a0dc032-1305-74fb-e0eb-b5d26843dce0", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "3a184df7-7d52-f9c0-8fcf-d65d15495f27", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "3c5a71ba-2254-b3ed-67ec-f64c0106c660", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "3c94d190-986e-a736-87ca-6787d693212a", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "3eb203dd-c874-2718-a2a0-3fc6a3d7ceb8", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "40ced4d1-1d5f-05f9-1ecc-008ece9bf6cf", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "425b45c5-3bf2-b3cc-a8fd-011c300c5b6b", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "42c4e64b-5f37-7428-68d0-ae73dd07c550", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "43218475-c208-8bef-45bb-cead9439d8b2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "453afb2c-a5b5-3cf4-f188-1fa95fc15824", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "490f3cf5-28f8-dece-4922-52671fb4a199", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "4950a765-76b9-83b3-7de9-af0e949338d0", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "49a1f7aa-8859-4cc4-b546-4549f789bf3f", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "4aff05b1-2e8c-eb11-a7d0-dc28213597fa", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "4c7ef4e4-6089-5b54-70cf-462a7594d3eb", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "4cce25cb-d6a8-8892-ccc2-05059e6a6f16", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "4d46411f-dba7-37ac-8814-c7da719f6e3b", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "4f1f9725-101c-80f7-d008-fcc9271993df", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "50a9ba02-e020-16d3-df51-fb9c4b19bd0c", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "52255222-934c-c40d-8d7f-7c438999b75b", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "53238bae-d873-e113-c07b-94f7384f2a4e", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "53bed5c3-f54e-2f3b-5ffb-c3d75fdef22e", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "5582813a-cf75-d0bc-d6ea-164333b8f078", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "55db5c7b-8e15-4375-cc5d-227a06438d38", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "5614c18a-417b-4621-5dd4-a17203b6fd57", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "565b9687-a776-3cef-8994-bc338c6f1895", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "5826bd17-eeda-6222-b4d0-8506d1ea4f1e", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "594df6b5-390a-e031-8c8f-ec7beecf5380", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "5b05b08e-6f73-e22a-e582-c0117147df20", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "5b638516-0759-9513-853d-bbb34b652783", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "5c094776-5acf-2f84-62b1-e51885ebdbbd", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "5d8585f7-072c-3acc-02d3-036830d0eb38", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "5f1cbb5b-c8cc-7cb9-7692-cfff312ba139", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "61a67da9-b7bd-4555-9cf8-c6341152be1e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "6381a78c-fcd6-d0a1-c4f5-09323d5ec98c", "296e74bd-c209-7f7c-d030-28e85a1aad75" },
                    { "6421d373-2d22-5d19-eadb-7e134fb1514e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "6634a192-1867-c0b7-3d6a-f40e9451b92c", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "68b4d308-be73-447a-aa01-94326f1d8573", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "691660f9-12b9-5e11-9261-206ceacd9e36", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "6a26bb2b-10b3-d20b-576c-06ec7eb6881c", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "6afd119d-e28e-92e8-9e89-1af6996f754c", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "6d007abb-5e1b-17af-b0f7-2c47514aa643", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "6d5ab6db-8f30-6091-2cd9-ea7f969fcbff", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "6e7e7ad1-76f0-2a98-4e52-aad698b8c7ad", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "6eab02e7-1426-0881-1c74-99cbe1c2dabd", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "6f546c47-26f1-7ec9-b641-fc447770b8d5", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "6fd6173d-eb18-e8d7-405c-66721548558e", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "6fee2eeb-59d2-0c00-9a1e-8a30811ae17f", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "7094d547-fd86-a3c5-b337-839b1e5c317d", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "718c2d6c-578e-b7c9-1e8d-5bc67c063ea5", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "74775c4f-426a-3783-b04f-ccac0b514278", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "74ace139-e992-d91f-4671-52f639972753", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "7600bbe0-0a15-349a-b9ec-c475880ecfda", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "767d2088-ae6e-01a3-af51-1f15e4010867", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "76c7b55e-03e5-9b52-34d3-5a7ffb9c90b6", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "7755d2e0-e594-43f6-6b2a-97e09a800704", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "77584882-18b2-c070-5e41-8b0e717367db", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "780e8022-e459-3d7f-a36b-47992b26ace5", "296e74bd-c209-7f7c-d030-28e85a1aad75" },
                    { "7978f9e1-f848-3ea6-bd32-b7ed5c2ba948", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "798ddc1c-e359-941e-9460-c187af5e53f8", "296e74bd-c209-7f7c-d030-28e85a1aad75" },
                    { "79e9a30f-cfe9-2f9d-cac4-f86e3962d70b", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "7aa3c75d-1047-67fb-2ace-ac1a1a10d694", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "7b197240-8dc4-4b9a-bffc-03041ba80ac3", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "7bccd9ff-6129-4373-38f5-54b69ffa2532", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "7d8f0718-91c6-2cab-268a-090d429358b3", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "7e81993e-6a54-b9ca-8ca1-a5dce75296d9", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "7f73fc92-af72-477b-9c37-49b6779a08db", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "80f54d52-7c1f-5ff2-d278-d08cb6fbe663", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "812aabb2-c7f8-2548-e7b2-c7c99cfa0b51", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "82854779-bd50-0aaa-177b-dbe72002170a", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "82a38202-4f6b-41d9-11fc-0c59d2bdb4a2", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "842306fb-458c-d097-eed8-909990df3d1b", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "852e46ab-b00f-8054-4ee1-5649cb845174", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "857d4bd4-f8b9-a253-5f74-06ed5783b8cc", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "85e1b30b-426b-ad04-17fe-fc152cee3378", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "86096d2d-028a-2178-b93d-d09c58fb798a", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "873dd793-925b-cf55-c4ed-19f5ea134c5e", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "882637b6-a3e0-c6f0-5adc-323fbaf06469", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "895ad2cb-c1d9-f871-0b4f-6d588817d0a2", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "89af6c7f-eb9b-700a-1edf-c780be219657", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "8a1b0119-fe28-9d70-3d44-4f08f1cc15dc", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "8b4e0e39-d22a-6b9e-f265-f1e56b32a5ac", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "8cabb15c-08a5-3226-7620-6b7fd82c0ec5", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "8e9adcb0-97f0-f605-d063-0d6f594f51ba", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "8edbb040-f6b6-44c8-881c-6d2a3d8b7775", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "8f6901a4-f5b5-e843-e991-5ecb27c6d119", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "8fce3dc3-2a8b-c124-f96f-6798c213bfc8", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "9343be38-6a9c-9597-308b-b7a380d3341a", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "93acaa36-b84a-93e3-4ab8-bee3839813c8", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "94d53d90-c40d-2c7b-5b09-1fc3733efdde", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "95280675-9478-c286-6e61-5eadb6e04ce7", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "96cf1edd-649d-c6e7-4f3f-63bb525f08b9", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "97732f97-a471-d97e-a1c9-5f1e65501cb8", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "978254e1-40d5-bc41-fd06-9909777893d6", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "98a3af77-666d-b843-1550-1654d066a91b", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "9aec3604-2382-813d-dbe0-e829167d4d03", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "9b04b38a-df80-4890-3b63-b52fc684befc", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "9bb332c5-28e6-8114-a6ad-33361e1c176b", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "9f1d52f5-5854-6344-7ee2-50b3aa2206aa", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "a1dcbe22-1a98-b101-6d9d-6a1e43eecad5", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "a2eca7c6-6ded-0447-2d46-a31b5047bfb9", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "a4637bf4-ac5f-fc18-4f21-5d6060423cac", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "a515b538-facb-a384-2fc0-09bd704b792b", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "a5ba5432-532b-bdc1-4517-8f6657b06ccc", "296e74bd-c209-7f7c-d030-28e85a1aad75" },
                    { "a609799e-8e05-578f-a027-ff94df7272f6", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "a6be719c-a6d5-4ec4-f3bc-079e2bc133f7", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "a6d90d38-fb40-67d3-9291-4dc9433685ab", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "a8052858-a628-5c78-0ee5-886932034146", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "a86586f4-63ee-788f-6c4b-375c8c07cc46", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "a9291ff8-90b2-be6e-9878-5cf2b98adf51", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "aaf5124c-ec73-3718-9708-9cc8a153aa21", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "aafbf12b-4fbf-f7ed-baff-ddb60852ded3", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "ab9e93c1-9054-3de0-5468-8fef169e2733", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "ac1087ea-7cca-ba5d-4716-69ede045aac3", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "ac148527-f1ee-3bb8-7a18-397adfdb9684", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "ad51b75b-94ba-2db3-71d6-9937a00564df", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "ae09acad-eb08-db70-af74-adc1671104e2", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "ae9de472-6ed6-c56b-17f8-0802b30e0ead", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "afc81f01-6ce3-5947-ba22-725ebff80699", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "b1a62097-cc7c-9e22-017f-ade4e5e982e1", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "b1ab77c6-75e2-be65-fd4d-2216d7df9169", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "b259425c-b08a-20ea-60cc-b695e91844b7", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "b3918eb5-f713-95f5-c1c0-7675b7e0b333", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "b7631fc1-9896-70c6-3e36-19135b902372", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "b916b170-861c-b14f-ad0a-9b5bccd2c0ca", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "bb39bb03-38d6-cd02-b341-89e2a660da76", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "bb543979-51da-e0a4-508a-34e41cd9c765", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "bb5e6b6a-0c42-fdab-58c4-fef95fcdc49d", "296e74bd-c209-7f7c-d030-28e85a1aad75" },
                    { "bc3ad3db-d8c5-02d3-d06e-5f94d53d9f78", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "bca7d63d-cce4-43ac-f1ce-560fc47e3074", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "bd85547f-e0ea-e2db-db8d-c415c58afb06", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "be7e99bc-ba4d-f226-9d8f-03682d23bee1", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "bed021d1-ed16-adf0-c5b4-2953fa35048b", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "bf1e2694-409a-773f-6c59-a05a8af0527f", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "bf51ec1a-fa3a-3c43-080e-494a6f7e3910", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" },
                    { "c15c6cab-3590-2006-a628-67612870eb60", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "c2516a1f-5f3e-7e0f-7b86-9053846377c1", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "c35fb6be-96f6-0788-f95f-8449add9c5b2", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "c3dd11cd-08a8-d8d0-60c4-add26094c881", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "c565c6ba-ecac-b786-5785-0744bdfcabc2", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "c584e914-d15b-6c1e-b33b-e87707b1c8f0", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "c6a456ad-719f-6857-0f33-b79bec3aec14", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "c6e7c556-e76d-2b22-aced-041ba0d8cb09", "296e74bd-c209-7f7c-d030-28e85a1aad75" },
                    { "c8126fe8-b8d9-89f3-fefb-a1e84543f875", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "c9ca3188-8a21-724a-23f6-5d9e402ab287", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "cc712312-dee1-743a-9da4-ee708f3d06e9", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "ccb09398-5ba5-01ed-ab10-93ede45a2ff4", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "d01019f9-5218-71f9-d3a9-35cb7b04b12b", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "d0486529-51fc-62a5-004c-ecd5002ccd41", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "d0f8efdd-4c40-b515-a8d1-d855a962a852", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "d1ae562d-8ff5-04f9-e4f9-be70373beea0", "296e74bd-c209-7f7c-d030-28e85a1aad75" },
                    { "d2041949-1d00-ce16-fc7c-30c218a75f46", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "d32c9013-9fb5-9f83-708d-3e02f83631cd", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "d3edfa54-1262-d190-899b-a472871c59f9", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "d4a343e2-40d5-57a3-222d-bbcb5fa7a60c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "d50e4726-2991-977e-1e9d-ccae720f4778", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "d5e30992-c7fc-e449-6e8c-e9ba67574c4c", "8e1a2182-9af2-5229-2104-66051e4b6220" },
                    { "d6285f6d-f25b-009c-7042-a47f4b244b68", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "d6442191-6705-0a50-37ea-73d811f12b11", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "d698f229-ec8e-a652-a33c-b1dfd62a38e6", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "d8ee1684-8213-4b12-219c-66a273f8d1ec", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "d96fcd78-c30b-080b-c92b-7d26c7dd221c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "da5a50be-4892-2912-7d30-e020f44c2bf3", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "dadf92d7-0a66-08ff-9067-d63a9ac831f9", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "db390cd5-f0eb-b466-37d6-608ce90540a5", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "db8d2ab6-946a-1502-426d-fcb21953e405", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "dc15a337-285f-ef85-0d15-e43c62677ee0", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "dd9e690a-8f67-72b4-629b-15a9d4cdd73a", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "ddd77ae8-2557-f2dc-0582-c2c104a0a18b", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "dde5dca0-3459-b459-a095-94f8a5eb4711", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "df815484-6a48-1b4e-a7ce-2b2a4a85d3f9", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "dfe2714c-934c-ef19-fe94-6c4db509862a", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "e0bb8201-c45e-a7cc-9a4a-f0921c6fd86c", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "e1738f37-9fc0-61b6-284f-5715db5ab025", "296e74bd-c209-7f7c-d030-28e85a1aad75" },
                    { "e2513fbd-3f02-efb1-92e4-4d7524a0a9b4", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "e260b095-b963-c13b-b5a2-d609ac8bd890", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "e7d00346-218a-3d24-b03b-7d2cfa8d6d7d", "9ade6863-7e26-4864-6736-dc579f1c7a31" },
                    { "e9479010-3a2b-6354-2e0c-11b49b24fb5f", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "ea06b88f-d8a1-ee08-bc3c-d84a42ccdacd", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "ec071909-de0a-3e67-a7b9-4a4b07d9de99", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "ec341556-c367-708a-11c4-097536f47dcb", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "ec421852-921b-ebfc-d739-8212e4385e64", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "ed3dee0b-d891-bd85-2ec9-065516fcd123", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" },
                    { "ee921d29-66e1-c443-c162-df77ae566e01", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "ef04b83f-9b1d-9814-3a9e-a3c0d292ac3b", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "ef55d5ee-4787-d8c7-b1fc-0862746ac28a", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "f13edc40-466a-6629-9715-d914984c3653", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "f4c16c8e-12ba-3b16-0555-dcebf1a93e21", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "f509123c-dc8e-d71a-ddbf-4cfe70107308", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "f5bcb9ad-0454-f4d3-389a-3f1d78dc2a1c", "015a9397-c5c4-4b03-eb4f-86048ec621f6" },
                    { "f692a256-8b14-1f69-5d15-3c1942f5c5f5", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "f723976c-ee91-b770-e7cf-4c2ddd2e10cd", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" },
                    { "f8cd0d8c-907b-551d-6211-931279dc0942", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "fab65069-a16f-8092-41b3-2dfadb5b84c2", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "fb099bba-fa75-cc47-57ac-dc2ce717cf7e", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "fb4dd0a9-4c1a-c15f-1c5c-83953364fcd2", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "fb91193d-c432-36d3-5e89-59f7ac76cab2", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "fb99eb83-8abc-f0bf-d8d5-d3ea90a38837", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "fc3c2b4d-ee65-87b1-8670-116de9888753", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "fc5fd85c-a36e-f72e-7eb2-0ae8930091c2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "fc730fac-20a9-8127-7fda-2bd0fbf14448", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "fe2403f2-62c7-83ab-fb2a-f4d6cb4cea82", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "fef0fe5e-f84c-8548-71ef-b871756abbf6", "296e74bd-c209-7f7c-d030-28e85a1aad75" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "013253fd-915e-ae02-98e4-8f6204070217" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "017daad5-244e-acd2-1ce4-07c75f5c9f04" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "0307a4e5-0941-b6f9-6e98-e48ede3c5f57" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "042c2061-f2ce-afcc-e0c0-a7bbfcebeb13" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "0733286f-fa6c-43ea-5ca3-7184db85512d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "09d5852e-c85d-b871-49a2-71c8d434e139" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "0b8c5e9e-5f59-32f8-19a0-b9e05ef5e471" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "0c68876d-2d68-d530-2757-956294ff1bed" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "0cbff9d4-4613-2d77-f1a3-6e9f4238a87c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "0d647b97-8742-6f60-67ee-364224b37cd3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "0d9f5e1b-8b16-6512-1aad-b6fc5bdbda7f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "11219807-2307-1246-8bd9-cd76bf2b52ce" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "1133eac0-f2b9-5576-b0b6-bef1f79782c7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "114acc04-a14d-ea71-5c54-bb541e5bb9af" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "13000bbc-8fd6-1578-7278-d709f023eed3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "1491b2d9-7dbd-4050-013b-0d4c38aeb869" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "14a89b1a-19ff-ce17-300b-e17e3bd1077f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "14cf4c2a-44f5-3e25-70c5-a8ad8fd3e3b8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "15ba8680-1073-bb6c-6f10-054644dff3ca" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "15cfd3d2-8bc4-c1bc-7fd9-d3de7f5d669b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "15d70dbc-6c98-76b3-999c-21437cc800e5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "16a954b2-61f0-b37a-7693-a0b61d5aa2e7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "193842d1-67f8-7b4a-04d4-8ad3f57b6cb5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "19f8d59a-321f-7873-3ea4-4c981946832d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "1b0c902d-ad55-90ab-57d4-16427ad6c740" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "1b37d5da-f4b6-cbc0-bbc2-8fee0570e9fb" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "1b80b598-780b-bea4-5a24-19940d4a38e1" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "1d551b56-0c89-92ea-bc4f-58b3b9bad9dc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "1d78c887-7aa6-132d-0217-f7b43b77bdf8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "1e6bec97-4c0e-5908-667d-688e7511f7c4" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "1ef93c61-327d-3b0f-db94-04acd6213a5f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "1fd5f3c7-4c47-19c4-61f0-665a537bec8a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "23a6ab3d-60bd-4148-2d32-cd648026c5e8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "249c0eaa-9905-1383-8fca-affda7f85f7b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "2593023d-cd4b-3a13-8456-8605799c009b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "2599f89e-0977-b58a-0539-f65697c1c75f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "25de3c2e-a93d-53f8-6982-c678ad47cc54" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "289a7bd2-5839-a841-3c7a-6cd2cb327c1f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "29f09856-4a06-7009-67f4-1b47f3735322" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "2a77192f-3516-2af5-1c2f-efb27ff44dff" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "2b56efe3-8b66-93ad-54b4-f5517a0c3cb5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "2be3fbb7-603a-37b8-9886-8cc179a60c00" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "2db3f185-97dd-9f4e-3813-f595191b3ef8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "2faf2f20-145f-cd9c-fcfd-afbf11172030" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "3149b3f4-1518-8b57-abdb-7e08d36f7861" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "31684066-8ff8-ec8d-d574-7994a009b471" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "323b5584-bd42-9b8b-ca3b-7683360e02ad" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "32508cd9-8a12-0bba-b62b-aa26d542bf43" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "325dbc6b-3915-11ff-5664-566a43aedcce" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "32e0e5ec-8a8e-9958-11b8-3e1fdf2c9022" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "338ef414-55b6-57f8-6cbe-eba50b6858da" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "33ff2701-91f8-d78b-7a7d-2e8699300904" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "35769633-5a71-b8f5-cd23-34959e70feef" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "35e80a17-a920-4848-28dc-7e49a1b1d450" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "362f0228-aba7-6c24-8de6-b0f8e8f0fca2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "363f0139-5ea9-5659-b4b6-d31f10c6e1f9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "3a0dc032-1305-74fb-e0eb-b5d26843dce0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "3a184df7-7d52-f9c0-8fcf-d65d15495f27" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "3c5a71ba-2254-b3ed-67ec-f64c0106c660" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "3c94d190-986e-a736-87ca-6787d693212a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "3eb203dd-c874-2718-a2a0-3fc6a3d7ceb8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "40ced4d1-1d5f-05f9-1ecc-008ece9bf6cf" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "425b45c5-3bf2-b3cc-a8fd-011c300c5b6b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "42c4e64b-5f37-7428-68d0-ae73dd07c550" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "43218475-c208-8bef-45bb-cead9439d8b2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "453afb2c-a5b5-3cf4-f188-1fa95fc15824" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "490f3cf5-28f8-dece-4922-52671fb4a199" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "4950a765-76b9-83b3-7de9-af0e949338d0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "49a1f7aa-8859-4cc4-b546-4549f789bf3f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "4aff05b1-2e8c-eb11-a7d0-dc28213597fa" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "4c7ef4e4-6089-5b54-70cf-462a7594d3eb" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "4cce25cb-d6a8-8892-ccc2-05059e6a6f16" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "4d46411f-dba7-37ac-8814-c7da719f6e3b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "4f1f9725-101c-80f7-d008-fcc9271993df" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "50a9ba02-e020-16d3-df51-fb9c4b19bd0c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "52255222-934c-c40d-8d7f-7c438999b75b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "53238bae-d873-e113-c07b-94f7384f2a4e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "53bed5c3-f54e-2f3b-5ffb-c3d75fdef22e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "5582813a-cf75-d0bc-d6ea-164333b8f078" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "55db5c7b-8e15-4375-cc5d-227a06438d38" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "5614c18a-417b-4621-5dd4-a17203b6fd57" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "565b9687-a776-3cef-8994-bc338c6f1895" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "5826bd17-eeda-6222-b4d0-8506d1ea4f1e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "594df6b5-390a-e031-8c8f-ec7beecf5380" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "5b05b08e-6f73-e22a-e582-c0117147df20" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "5b638516-0759-9513-853d-bbb34b652783" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "5c094776-5acf-2f84-62b1-e51885ebdbbd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "5d8585f7-072c-3acc-02d3-036830d0eb38" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "5f1cbb5b-c8cc-7cb9-7692-cfff312ba139" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "61a67da9-b7bd-4555-9cf8-c6341152be1e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6381a78c-fcd6-d0a1-c4f5-09323d5ec98c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6421d373-2d22-5d19-eadb-7e134fb1514e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6634a192-1867-c0b7-3d6a-f40e9451b92c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "68b4d308-be73-447a-aa01-94326f1d8573" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "691660f9-12b9-5e11-9261-206ceacd9e36" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6a26bb2b-10b3-d20b-576c-06ec7eb6881c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6afd119d-e28e-92e8-9e89-1af6996f754c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6d007abb-5e1b-17af-b0f7-2c47514aa643" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6d5ab6db-8f30-6091-2cd9-ea7f969fcbff" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6e7e7ad1-76f0-2a98-4e52-aad698b8c7ad" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6eab02e7-1426-0881-1c74-99cbe1c2dabd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6f546c47-26f1-7ec9-b641-fc447770b8d5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6fd6173d-eb18-e8d7-405c-66721548558e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "6fee2eeb-59d2-0c00-9a1e-8a30811ae17f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "7094d547-fd86-a3c5-b337-839b1e5c317d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "718c2d6c-578e-b7c9-1e8d-5bc67c063ea5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "74775c4f-426a-3783-b04f-ccac0b514278" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "74ace139-e992-d91f-4671-52f639972753" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "7600bbe0-0a15-349a-b9ec-c475880ecfda" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "767d2088-ae6e-01a3-af51-1f15e4010867" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "76c7b55e-03e5-9b52-34d3-5a7ffb9c90b6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "7755d2e0-e594-43f6-6b2a-97e09a800704" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "77584882-18b2-c070-5e41-8b0e717367db" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "780e8022-e459-3d7f-a36b-47992b26ace5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "7978f9e1-f848-3ea6-bd32-b7ed5c2ba948" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "798ddc1c-e359-941e-9460-c187af5e53f8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "79e9a30f-cfe9-2f9d-cac4-f86e3962d70b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "7aa3c75d-1047-67fb-2ace-ac1a1a10d694" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "7b197240-8dc4-4b9a-bffc-03041ba80ac3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "7bccd9ff-6129-4373-38f5-54b69ffa2532" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "7d8f0718-91c6-2cab-268a-090d429358b3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "7e81993e-6a54-b9ca-8ca1-a5dce75296d9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "7f73fc92-af72-477b-9c37-49b6779a08db" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "80f54d52-7c1f-5ff2-d278-d08cb6fbe663" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "812aabb2-c7f8-2548-e7b2-c7c99cfa0b51" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "82854779-bd50-0aaa-177b-dbe72002170a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "82a38202-4f6b-41d9-11fc-0c59d2bdb4a2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "842306fb-458c-d097-eed8-909990df3d1b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "852e46ab-b00f-8054-4ee1-5649cb845174" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "857d4bd4-f8b9-a253-5f74-06ed5783b8cc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "85e1b30b-426b-ad04-17fe-fc152cee3378" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "86096d2d-028a-2178-b93d-d09c58fb798a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "873dd793-925b-cf55-c4ed-19f5ea134c5e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "882637b6-a3e0-c6f0-5adc-323fbaf06469" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "895ad2cb-c1d9-f871-0b4f-6d588817d0a2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "89af6c7f-eb9b-700a-1edf-c780be219657" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "8a1b0119-fe28-9d70-3d44-4f08f1cc15dc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "8b4e0e39-d22a-6b9e-f265-f1e56b32a5ac" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "8cabb15c-08a5-3226-7620-6b7fd82c0ec5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "8e9adcb0-97f0-f605-d063-0d6f594f51ba" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "8edbb040-f6b6-44c8-881c-6d2a3d8b7775" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "8f6901a4-f5b5-e843-e991-5ecb27c6d119" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "8fce3dc3-2a8b-c124-f96f-6798c213bfc8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "9343be38-6a9c-9597-308b-b7a380d3341a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "93acaa36-b84a-93e3-4ab8-bee3839813c8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "94d53d90-c40d-2c7b-5b09-1fc3733efdde" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "95280675-9478-c286-6e61-5eadb6e04ce7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "96cf1edd-649d-c6e7-4f3f-63bb525f08b9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "97732f97-a471-d97e-a1c9-5f1e65501cb8" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "978254e1-40d5-bc41-fd06-9909777893d6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "98a3af77-666d-b843-1550-1654d066a91b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "9aec3604-2382-813d-dbe0-e829167d4d03" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "9b04b38a-df80-4890-3b63-b52fc684befc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "9bb332c5-28e6-8114-a6ad-33361e1c176b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "9f1d52f5-5854-6344-7ee2-50b3aa2206aa" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a1dcbe22-1a98-b101-6d9d-6a1e43eecad5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a2eca7c6-6ded-0447-2d46-a31b5047bfb9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a4637bf4-ac5f-fc18-4f21-5d6060423cac" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a515b538-facb-a384-2fc0-09bd704b792b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a5ba5432-532b-bdc1-4517-8f6657b06ccc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a609799e-8e05-578f-a027-ff94df7272f6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a6be719c-a6d5-4ec4-f3bc-079e2bc133f7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a6d90d38-fb40-67d3-9291-4dc9433685ab" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a8052858-a628-5c78-0ee5-886932034146" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a86586f4-63ee-788f-6c4b-375c8c07cc46" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "a9291ff8-90b2-be6e-9878-5cf2b98adf51" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "aaf5124c-ec73-3718-9708-9cc8a153aa21" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "aafbf12b-4fbf-f7ed-baff-ddb60852ded3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ab9e93c1-9054-3de0-5468-8fef169e2733" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ac1087ea-7cca-ba5d-4716-69ede045aac3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ac148527-f1ee-3bb8-7a18-397adfdb9684" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ad51b75b-94ba-2db3-71d6-9937a00564df" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ae09acad-eb08-db70-af74-adc1671104e2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ae9de472-6ed6-c56b-17f8-0802b30e0ead" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "afc81f01-6ce3-5947-ba22-725ebff80699" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "b1a62097-cc7c-9e22-017f-ade4e5e982e1" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "b1ab77c6-75e2-be65-fd4d-2216d7df9169" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "b259425c-b08a-20ea-60cc-b695e91844b7" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "b3918eb5-f713-95f5-c1c0-7675b7e0b333" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "b7631fc1-9896-70c6-3e36-19135b902372" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "b916b170-861c-b14f-ad0a-9b5bccd2c0ca" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "bb39bb03-38d6-cd02-b341-89e2a660da76" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "bb543979-51da-e0a4-508a-34e41cd9c765" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "bb5e6b6a-0c42-fdab-58c4-fef95fcdc49d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "bc3ad3db-d8c5-02d3-d06e-5f94d53d9f78" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "bca7d63d-cce4-43ac-f1ce-560fc47e3074" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "bd85547f-e0ea-e2db-db8d-c415c58afb06" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "be7e99bc-ba4d-f226-9d8f-03682d23bee1" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "bed021d1-ed16-adf0-c5b4-2953fa35048b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "bf1e2694-409a-773f-6c59-a05a8af0527f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "bf51ec1a-fa3a-3c43-080e-494a6f7e3910" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "c15c6cab-3590-2006-a628-67612870eb60" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "c2516a1f-5f3e-7e0f-7b86-9053846377c1" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "c35fb6be-96f6-0788-f95f-8449add9c5b2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "c3dd11cd-08a8-d8d0-60c4-add26094c881" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "c565c6ba-ecac-b786-5785-0744bdfcabc2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "c584e914-d15b-6c1e-b33b-e87707b1c8f0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "c6a456ad-719f-6857-0f33-b79bec3aec14" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "c6e7c556-e76d-2b22-aced-041ba0d8cb09" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "c8126fe8-b8d9-89f3-fefb-a1e84543f875" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "c9ca3188-8a21-724a-23f6-5d9e402ab287" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "cc712312-dee1-743a-9da4-ee708f3d06e9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ccb09398-5ba5-01ed-ab10-93ede45a2ff4" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d01019f9-5218-71f9-d3a9-35cb7b04b12b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d0486529-51fc-62a5-004c-ecd5002ccd41" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d0f8efdd-4c40-b515-a8d1-d855a962a852" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d1ae562d-8ff5-04f9-e4f9-be70373beea0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d2041949-1d00-ce16-fc7c-30c218a75f46" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d32c9013-9fb5-9f83-708d-3e02f83631cd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d3edfa54-1262-d190-899b-a472871c59f9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d4a343e2-40d5-57a3-222d-bbcb5fa7a60c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d50e4726-2991-977e-1e9d-ccae720f4778" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d5e30992-c7fc-e449-6e8c-e9ba67574c4c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d6285f6d-f25b-009c-7042-a47f4b244b68" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d6442191-6705-0a50-37ea-73d811f12b11" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d698f229-ec8e-a652-a33c-b1dfd62a38e6" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d8ee1684-8213-4b12-219c-66a273f8d1ec" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "d96fcd78-c30b-080b-c92b-7d26c7dd221c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "da5a50be-4892-2912-7d30-e020f44c2bf3" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "dadf92d7-0a66-08ff-9067-d63a9ac831f9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "db390cd5-f0eb-b466-37d6-608ce90540a5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "db8d2ab6-946a-1502-426d-fcb21953e405" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "dc15a337-285f-ef85-0d15-e43c62677ee0" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "dd9e690a-8f67-72b4-629b-15a9d4cdd73a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ddd77ae8-2557-f2dc-0582-c2c104a0a18b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "dde5dca0-3459-b459-a095-94f8a5eb4711" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "df815484-6a48-1b4e-a7ce-2b2a4a85d3f9" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "dfe2714c-934c-ef19-fe94-6c4db509862a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "e0bb8201-c45e-a7cc-9a4a-f0921c6fd86c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "e1738f37-9fc0-61b6-284f-5715db5ab025" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "e2513fbd-3f02-efb1-92e4-4d7524a0a9b4" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "e260b095-b963-c13b-b5a2-d609ac8bd890" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "e7d00346-218a-3d24-b03b-7d2cfa8d6d7d" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "e9479010-3a2b-6354-2e0c-11b49b24fb5f" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ea06b88f-d8a1-ee08-bc3c-d84a42ccdacd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ec071909-de0a-3e67-a7b9-4a4b07d9de99" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ec341556-c367-708a-11c4-097536f47dcb" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ec421852-921b-ebfc-d739-8212e4385e64" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ed3dee0b-d891-bd85-2ec9-065516fcd123" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ee921d29-66e1-c443-c162-df77ae566e01" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ef04b83f-9b1d-9814-3a9e-a3c0d292ac3b" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "ef55d5ee-4787-d8c7-b1fc-0862746ac28a" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "f13edc40-466a-6629-9715-d914984c3653" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "f4c16c8e-12ba-3b16-0555-dcebf1a93e21" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "f509123c-dc8e-d71a-ddbf-4cfe70107308" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "f5bcb9ad-0454-f4d3-389a-3f1d78dc2a1c" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "f692a256-8b14-1f69-5d15-3c1942f5c5f5" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "f723976c-ee91-b770-e7cf-4c2ddd2e10cd" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "f8cd0d8c-907b-551d-6211-931279dc0942" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "fab65069-a16f-8092-41b3-2dfadb5b84c2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "fb099bba-fa75-cc47-57ac-dc2ce717cf7e" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "fb4dd0a9-4c1a-c15f-1c5c-83953364fcd2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "fb91193d-c432-36d3-5e89-59f7ac76cab2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "fb99eb83-8abc-f0bf-d8d5-d3ea90a38837" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "fc3c2b4d-ee65-87b1-8670-116de9888753" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "fc5fd85c-a36e-f72e-7eb2-0ae8930091c2" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "fc730fac-20a9-8127-7fda-2bd0fbf14448" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "fe2403f2-62c7-83ab-fb2a-f4d6cb4cea82" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "e61277a9-9d07-5b53-e623-528bf88a6962", "fef0fe5e-f84c-8548-71ef-b871756abbf6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "013253fd-915e-ae02-98e4-8f6204070217", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "017daad5-244e-acd2-1ce4-07c75f5c9f04", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0307a4e5-0941-b6f9-6e98-e48ede3c5f57", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "042c2061-f2ce-afcc-e0c0-a7bbfcebeb13", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0733286f-fa6c-43ea-5ca3-7184db85512d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "09d5852e-c85d-b871-49a2-71c8d434e139", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0b8c5e9e-5f59-32f8-19a0-b9e05ef5e471", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0c68876d-2d68-d530-2757-956294ff1bed", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0cbff9d4-4613-2d77-f1a3-6e9f4238a87c", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0d647b97-8742-6f60-67ee-364224b37cd3", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0d9f5e1b-8b16-6512-1aad-b6fc5bdbda7f", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "11219807-2307-1246-8bd9-cd76bf2b52ce", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1133eac0-f2b9-5576-b0b6-bef1f79782c7", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "114acc04-a14d-ea71-5c54-bb541e5bb9af", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "13000bbc-8fd6-1578-7278-d709f023eed3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1491b2d9-7dbd-4050-013b-0d4c38aeb869", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "14a89b1a-19ff-ce17-300b-e17e3bd1077f", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "14cf4c2a-44f5-3e25-70c5-a8ad8fd3e3b8", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "15ba8680-1073-bb6c-6f10-054644dff3ca", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "15cfd3d2-8bc4-c1bc-7fd9-d3de7f5d669b", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "15d70dbc-6c98-76b3-999c-21437cc800e5", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "16a954b2-61f0-b37a-7693-a0b61d5aa2e7", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "193842d1-67f8-7b4a-04d4-8ad3f57b6cb5", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "19f8d59a-321f-7873-3ea4-4c981946832d", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1b0c902d-ad55-90ab-57d4-16427ad6c740", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1b37d5da-f4b6-cbc0-bbc2-8fee0570e9fb", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1b80b598-780b-bea4-5a24-19940d4a38e1", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1d551b56-0c89-92ea-bc4f-58b3b9bad9dc", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1d78c887-7aa6-132d-0217-f7b43b77bdf8", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1e6bec97-4c0e-5908-667d-688e7511f7c4", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1ef93c61-327d-3b0f-db94-04acd6213a5f", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1fd5f3c7-4c47-19c4-61f0-665a537bec8a", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "23a6ab3d-60bd-4148-2d32-cd648026c5e8", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "249c0eaa-9905-1383-8fca-affda7f85f7b", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2593023d-cd4b-3a13-8456-8605799c009b", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2599f89e-0977-b58a-0539-f65697c1c75f", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "25de3c2e-a93d-53f8-6982-c678ad47cc54", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "289a7bd2-5839-a841-3c7a-6cd2cb327c1f", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "29f09856-4a06-7009-67f4-1b47f3735322", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2a77192f-3516-2af5-1c2f-efb27ff44dff", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2b56efe3-8b66-93ad-54b4-f5517a0c3cb5", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2be3fbb7-603a-37b8-9886-8cc179a60c00", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2db3f185-97dd-9f4e-3813-f595191b3ef8", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2faf2f20-145f-cd9c-fcfd-afbf11172030", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3149b3f4-1518-8b57-abdb-7e08d36f7861", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "31684066-8ff8-ec8d-d574-7994a009b471", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "323b5584-bd42-9b8b-ca3b-7683360e02ad", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "32508cd9-8a12-0bba-b62b-aa26d542bf43", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "325dbc6b-3915-11ff-5664-566a43aedcce", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "32e0e5ec-8a8e-9958-11b8-3e1fdf2c9022", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "338ef414-55b6-57f8-6cbe-eba50b6858da", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "33ff2701-91f8-d78b-7a7d-2e8699300904", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "35769633-5a71-b8f5-cd23-34959e70feef", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "35e80a17-a920-4848-28dc-7e49a1b1d450", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "362f0228-aba7-6c24-8de6-b0f8e8f0fca2", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "363f0139-5ea9-5659-b4b6-d31f10c6e1f9", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3a0dc032-1305-74fb-e0eb-b5d26843dce0", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3a184df7-7d52-f9c0-8fcf-d65d15495f27", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3c5a71ba-2254-b3ed-67ec-f64c0106c660", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3c94d190-986e-a736-87ca-6787d693212a", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3eb203dd-c874-2718-a2a0-3fc6a3d7ceb8", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "40ced4d1-1d5f-05f9-1ecc-008ece9bf6cf", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "425b45c5-3bf2-b3cc-a8fd-011c300c5b6b", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "42c4e64b-5f37-7428-68d0-ae73dd07c550", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "43218475-c208-8bef-45bb-cead9439d8b2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "453afb2c-a5b5-3cf4-f188-1fa95fc15824", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "490f3cf5-28f8-dece-4922-52671fb4a199", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4950a765-76b9-83b3-7de9-af0e949338d0", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "49a1f7aa-8859-4cc4-b546-4549f789bf3f", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4aff05b1-2e8c-eb11-a7d0-dc28213597fa", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4c7ef4e4-6089-5b54-70cf-462a7594d3eb", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4cce25cb-d6a8-8892-ccc2-05059e6a6f16", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4d46411f-dba7-37ac-8814-c7da719f6e3b", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4f1f9725-101c-80f7-d008-fcc9271993df", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "50a9ba02-e020-16d3-df51-fb9c4b19bd0c", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "52255222-934c-c40d-8d7f-7c438999b75b", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "53238bae-d873-e113-c07b-94f7384f2a4e", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "53bed5c3-f54e-2f3b-5ffb-c3d75fdef22e", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5582813a-cf75-d0bc-d6ea-164333b8f078", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "55db5c7b-8e15-4375-cc5d-227a06438d38", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5614c18a-417b-4621-5dd4-a17203b6fd57", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "565b9687-a776-3cef-8994-bc338c6f1895", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5826bd17-eeda-6222-b4d0-8506d1ea4f1e", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "594df6b5-390a-e031-8c8f-ec7beecf5380", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5b05b08e-6f73-e22a-e582-c0117147df20", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5b638516-0759-9513-853d-bbb34b652783", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5c094776-5acf-2f84-62b1-e51885ebdbbd", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5d8585f7-072c-3acc-02d3-036830d0eb38", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5f1cbb5b-c8cc-7cb9-7692-cfff312ba139", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "61a67da9-b7bd-4555-9cf8-c6341152be1e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6381a78c-fcd6-d0a1-c4f5-09323d5ec98c", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6421d373-2d22-5d19-eadb-7e134fb1514e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6634a192-1867-c0b7-3d6a-f40e9451b92c", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "68b4d308-be73-447a-aa01-94326f1d8573", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "691660f9-12b9-5e11-9261-206ceacd9e36", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6a26bb2b-10b3-d20b-576c-06ec7eb6881c", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6afd119d-e28e-92e8-9e89-1af6996f754c", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6d007abb-5e1b-17af-b0f7-2c47514aa643", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6d5ab6db-8f30-6091-2cd9-ea7f969fcbff", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6e7e7ad1-76f0-2a98-4e52-aad698b8c7ad", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6eab02e7-1426-0881-1c74-99cbe1c2dabd", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6f546c47-26f1-7ec9-b641-fc447770b8d5", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6fd6173d-eb18-e8d7-405c-66721548558e", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6fee2eeb-59d2-0c00-9a1e-8a30811ae17f", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7094d547-fd86-a3c5-b337-839b1e5c317d", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "718c2d6c-578e-b7c9-1e8d-5bc67c063ea5", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "74775c4f-426a-3783-b04f-ccac0b514278", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "74ace139-e992-d91f-4671-52f639972753", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7600bbe0-0a15-349a-b9ec-c475880ecfda", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "767d2088-ae6e-01a3-af51-1f15e4010867", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "76c7b55e-03e5-9b52-34d3-5a7ffb9c90b6", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7755d2e0-e594-43f6-6b2a-97e09a800704", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "77584882-18b2-c070-5e41-8b0e717367db", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "780e8022-e459-3d7f-a36b-47992b26ace5", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7978f9e1-f848-3ea6-bd32-b7ed5c2ba948", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "798ddc1c-e359-941e-9460-c187af5e53f8", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "79e9a30f-cfe9-2f9d-cac4-f86e3962d70b", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7aa3c75d-1047-67fb-2ace-ac1a1a10d694", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7b197240-8dc4-4b9a-bffc-03041ba80ac3", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7bccd9ff-6129-4373-38f5-54b69ffa2532", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7d8f0718-91c6-2cab-268a-090d429358b3", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7e81993e-6a54-b9ca-8ca1-a5dce75296d9", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7f73fc92-af72-477b-9c37-49b6779a08db", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "80f54d52-7c1f-5ff2-d278-d08cb6fbe663", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "812aabb2-c7f8-2548-e7b2-c7c99cfa0b51", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "82854779-bd50-0aaa-177b-dbe72002170a", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "82a38202-4f6b-41d9-11fc-0c59d2bdb4a2", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "842306fb-458c-d097-eed8-909990df3d1b", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "852e46ab-b00f-8054-4ee1-5649cb845174", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "857d4bd4-f8b9-a253-5f74-06ed5783b8cc", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "85e1b30b-426b-ad04-17fe-fc152cee3378", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "86096d2d-028a-2178-b93d-d09c58fb798a", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "873dd793-925b-cf55-c4ed-19f5ea134c5e", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "882637b6-a3e0-c6f0-5adc-323fbaf06469", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "895ad2cb-c1d9-f871-0b4f-6d588817d0a2", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "89af6c7f-eb9b-700a-1edf-c780be219657", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8a1b0119-fe28-9d70-3d44-4f08f1cc15dc", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8b4e0e39-d22a-6b9e-f265-f1e56b32a5ac", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8cabb15c-08a5-3226-7620-6b7fd82c0ec5", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8e9adcb0-97f0-f605-d063-0d6f594f51ba", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8edbb040-f6b6-44c8-881c-6d2a3d8b7775", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8f6901a4-f5b5-e843-e991-5ecb27c6d119", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8fce3dc3-2a8b-c124-f96f-6798c213bfc8", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9343be38-6a9c-9597-308b-b7a380d3341a", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "93acaa36-b84a-93e3-4ab8-bee3839813c8", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "94d53d90-c40d-2c7b-5b09-1fc3733efdde", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "95280675-9478-c286-6e61-5eadb6e04ce7", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "96cf1edd-649d-c6e7-4f3f-63bb525f08b9", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "97732f97-a471-d97e-a1c9-5f1e65501cb8", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "978254e1-40d5-bc41-fd06-9909777893d6", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "98a3af77-666d-b843-1550-1654d066a91b", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9aec3604-2382-813d-dbe0-e829167d4d03", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9b04b38a-df80-4890-3b63-b52fc684befc", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9bb332c5-28e6-8114-a6ad-33361e1c176b", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9f1d52f5-5854-6344-7ee2-50b3aa2206aa", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a1dcbe22-1a98-b101-6d9d-6a1e43eecad5", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a2eca7c6-6ded-0447-2d46-a31b5047bfb9", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a4637bf4-ac5f-fc18-4f21-5d6060423cac", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a515b538-facb-a384-2fc0-09bd704b792b", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a5ba5432-532b-bdc1-4517-8f6657b06ccc", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a609799e-8e05-578f-a027-ff94df7272f6", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a6be719c-a6d5-4ec4-f3bc-079e2bc133f7", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a6d90d38-fb40-67d3-9291-4dc9433685ab", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a8052858-a628-5c78-0ee5-886932034146", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a86586f4-63ee-788f-6c4b-375c8c07cc46", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a9291ff8-90b2-be6e-9878-5cf2b98adf51", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "aaf5124c-ec73-3718-9708-9cc8a153aa21", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "aafbf12b-4fbf-f7ed-baff-ddb60852ded3", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ab9e93c1-9054-3de0-5468-8fef169e2733", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ac1087ea-7cca-ba5d-4716-69ede045aac3", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ac148527-f1ee-3bb8-7a18-397adfdb9684", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ad51b75b-94ba-2db3-71d6-9937a00564df", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ae09acad-eb08-db70-af74-adc1671104e2", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ae9de472-6ed6-c56b-17f8-0802b30e0ead", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "afc81f01-6ce3-5947-ba22-725ebff80699", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b1a62097-cc7c-9e22-017f-ade4e5e982e1", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b1ab77c6-75e2-be65-fd4d-2216d7df9169", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b259425c-b08a-20ea-60cc-b695e91844b7", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b3918eb5-f713-95f5-c1c0-7675b7e0b333", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b7631fc1-9896-70c6-3e36-19135b902372", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b916b170-861c-b14f-ad0a-9b5bccd2c0ca", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bb39bb03-38d6-cd02-b341-89e2a660da76", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bb543979-51da-e0a4-508a-34e41cd9c765", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bb5e6b6a-0c42-fdab-58c4-fef95fcdc49d", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bc3ad3db-d8c5-02d3-d06e-5f94d53d9f78", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bca7d63d-cce4-43ac-f1ce-560fc47e3074", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd85547f-e0ea-e2db-db8d-c415c58afb06", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "be7e99bc-ba4d-f226-9d8f-03682d23bee1", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bed021d1-ed16-adf0-c5b4-2953fa35048b", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bf1e2694-409a-773f-6c59-a05a8af0527f", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bf51ec1a-fa3a-3c43-080e-494a6f7e3910", "8c62f6c8-d791-e825-bdef-5c14bf5ce951" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c15c6cab-3590-2006-a628-67612870eb60", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c2516a1f-5f3e-7e0f-7b86-9053846377c1", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c35fb6be-96f6-0788-f95f-8449add9c5b2", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c3dd11cd-08a8-d8d0-60c4-add26094c881", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c565c6ba-ecac-b786-5785-0744bdfcabc2", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c584e914-d15b-6c1e-b33b-e87707b1c8f0", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c6a456ad-719f-6857-0f33-b79bec3aec14", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c6e7c556-e76d-2b22-aced-041ba0d8cb09", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c8126fe8-b8d9-89f3-fefb-a1e84543f875", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c9ca3188-8a21-724a-23f6-5d9e402ab287", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cc712312-dee1-743a-9da4-ee708f3d06e9", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ccb09398-5ba5-01ed-ab10-93ede45a2ff4", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d01019f9-5218-71f9-d3a9-35cb7b04b12b", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d0486529-51fc-62a5-004c-ecd5002ccd41", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d0f8efdd-4c40-b515-a8d1-d855a962a852", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d1ae562d-8ff5-04f9-e4f9-be70373beea0", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d2041949-1d00-ce16-fc7c-30c218a75f46", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d32c9013-9fb5-9f83-708d-3e02f83631cd", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d3edfa54-1262-d190-899b-a472871c59f9", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d4a343e2-40d5-57a3-222d-bbcb5fa7a60c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d50e4726-2991-977e-1e9d-ccae720f4778", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d5e30992-c7fc-e449-6e8c-e9ba67574c4c", "8e1a2182-9af2-5229-2104-66051e4b6220" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d6285f6d-f25b-009c-7042-a47f4b244b68", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d6442191-6705-0a50-37ea-73d811f12b11", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d698f229-ec8e-a652-a33c-b1dfd62a38e6", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d8ee1684-8213-4b12-219c-66a273f8d1ec", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d96fcd78-c30b-080b-c92b-7d26c7dd221c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "da5a50be-4892-2912-7d30-e020f44c2bf3", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dadf92d7-0a66-08ff-9067-d63a9ac831f9", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "db390cd5-f0eb-b466-37d6-608ce90540a5", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "db8d2ab6-946a-1502-426d-fcb21953e405", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dc15a337-285f-ef85-0d15-e43c62677ee0", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dd9e690a-8f67-72b4-629b-15a9d4cdd73a", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ddd77ae8-2557-f2dc-0582-c2c104a0a18b", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dde5dca0-3459-b459-a095-94f8a5eb4711", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "df815484-6a48-1b4e-a7ce-2b2a4a85d3f9", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dfe2714c-934c-ef19-fe94-6c4db509862a", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e0bb8201-c45e-a7cc-9a4a-f0921c6fd86c", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e1738f37-9fc0-61b6-284f-5715db5ab025", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e2513fbd-3f02-efb1-92e4-4d7524a0a9b4", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e260b095-b963-c13b-b5a2-d609ac8bd890", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e7d00346-218a-3d24-b03b-7d2cfa8d6d7d", "9ade6863-7e26-4864-6736-dc579f1c7a31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e9479010-3a2b-6354-2e0c-11b49b24fb5f", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ea06b88f-d8a1-ee08-bc3c-d84a42ccdacd", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ec071909-de0a-3e67-a7b9-4a4b07d9de99", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ec341556-c367-708a-11c4-097536f47dcb", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ec421852-921b-ebfc-d739-8212e4385e64", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ed3dee0b-d891-bd85-2ec9-065516fcd123", "d3f7232a-7eb6-649e-c1fc-ad010f705d7a" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ee921d29-66e1-c443-c162-df77ae566e01", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ef04b83f-9b1d-9814-3a9e-a3c0d292ac3b", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ef55d5ee-4787-d8c7-b1fc-0862746ac28a", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f13edc40-466a-6629-9715-d914984c3653", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f4c16c8e-12ba-3b16-0555-dcebf1a93e21", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f509123c-dc8e-d71a-ddbf-4cfe70107308", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f5bcb9ad-0454-f4d3-389a-3f1d78dc2a1c", "015a9397-c5c4-4b03-eb4f-86048ec621f6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f692a256-8b14-1f69-5d15-3c1942f5c5f5", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f723976c-ee91-b770-e7cf-4c2ddd2e10cd", "7f2e2223-eda8-2785-2b9f-2f6cbfecc012" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f8cd0d8c-907b-551d-6211-931279dc0942", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fab65069-a16f-8092-41b3-2dfadb5b84c2", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fb099bba-fa75-cc47-57ac-dc2ce717cf7e", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fb4dd0a9-4c1a-c15f-1c5c-83953364fcd2", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fb91193d-c432-36d3-5e89-59f7ac76cab2", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fb99eb83-8abc-f0bf-d8d5-d3ea90a38837", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fc3c2b4d-ee65-87b1-8670-116de9888753", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fc5fd85c-a36e-f72e-7eb2-0ae8930091c2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fc730fac-20a9-8127-7fda-2bd0fbf14448", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fe2403f2-62c7-83ab-fb2a-f4d6cb4cea82", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fef0fe5e-f84c-8548-71ef-b871756abbf6", "296e74bd-c209-7f7c-d030-28e85a1aad75" });

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "013253fd-915e-ae02-98e4-8f6204070217");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "017daad5-244e-acd2-1ce4-07c75f5c9f04");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0307a4e5-0941-b6f9-6e98-e48ede3c5f57");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "042c2061-f2ce-afcc-e0c0-a7bbfcebeb13");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0733286f-fa6c-43ea-5ca3-7184db85512d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "09d5852e-c85d-b871-49a2-71c8d434e139");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0b8c5e9e-5f59-32f8-19a0-b9e05ef5e471");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0c68876d-2d68-d530-2757-956294ff1bed");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0cbff9d4-4613-2d77-f1a3-6e9f4238a87c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0d647b97-8742-6f60-67ee-364224b37cd3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0d9f5e1b-8b16-6512-1aad-b6fc5bdbda7f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11219807-2307-1246-8bd9-cd76bf2b52ce");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1133eac0-f2b9-5576-b0b6-bef1f79782c7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "114acc04-a14d-ea71-5c54-bb541e5bb9af");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "13000bbc-8fd6-1578-7278-d709f023eed3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1491b2d9-7dbd-4050-013b-0d4c38aeb869");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "14a89b1a-19ff-ce17-300b-e17e3bd1077f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "14cf4c2a-44f5-3e25-70c5-a8ad8fd3e3b8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15ba8680-1073-bb6c-6f10-054644dff3ca");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15cfd3d2-8bc4-c1bc-7fd9-d3de7f5d669b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15d70dbc-6c98-76b3-999c-21437cc800e5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "16a954b2-61f0-b37a-7693-a0b61d5aa2e7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "193842d1-67f8-7b4a-04d4-8ad3f57b6cb5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "19f8d59a-321f-7873-3ea4-4c981946832d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b0c902d-ad55-90ab-57d4-16427ad6c740");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b37d5da-f4b6-cbc0-bbc2-8fee0570e9fb");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b80b598-780b-bea4-5a24-19940d4a38e1");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1d551b56-0c89-92ea-bc4f-58b3b9bad9dc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1d78c887-7aa6-132d-0217-f7b43b77bdf8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e6bec97-4c0e-5908-667d-688e7511f7c4");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1ef93c61-327d-3b0f-db94-04acd6213a5f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1fd5f3c7-4c47-19c4-61f0-665a537bec8a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "23a6ab3d-60bd-4148-2d32-cd648026c5e8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "249c0eaa-9905-1383-8fca-affda7f85f7b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2593023d-cd4b-3a13-8456-8605799c009b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2599f89e-0977-b58a-0539-f65697c1c75f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "25de3c2e-a93d-53f8-6982-c678ad47cc54");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "289a7bd2-5839-a841-3c7a-6cd2cb327c1f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "29f09856-4a06-7009-67f4-1b47f3735322");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2a77192f-3516-2af5-1c2f-efb27ff44dff");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b56efe3-8b66-93ad-54b4-f5517a0c3cb5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2be3fbb7-603a-37b8-9886-8cc179a60c00");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2db3f185-97dd-9f4e-3813-f595191b3ef8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2faf2f20-145f-cd9c-fcfd-afbf11172030");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3149b3f4-1518-8b57-abdb-7e08d36f7861");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "31684066-8ff8-ec8d-d574-7994a009b471");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "323b5584-bd42-9b8b-ca3b-7683360e02ad");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "32508cd9-8a12-0bba-b62b-aa26d542bf43");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "325dbc6b-3915-11ff-5664-566a43aedcce");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "32e0e5ec-8a8e-9958-11b8-3e1fdf2c9022");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "338ef414-55b6-57f8-6cbe-eba50b6858da");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33ff2701-91f8-d78b-7a7d-2e8699300904");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35769633-5a71-b8f5-cd23-34959e70feef");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35e80a17-a920-4848-28dc-7e49a1b1d450");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "362f0228-aba7-6c24-8de6-b0f8e8f0fca2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "363f0139-5ea9-5659-b4b6-d31f10c6e1f9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3a0dc032-1305-74fb-e0eb-b5d26843dce0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3a184df7-7d52-f9c0-8fcf-d65d15495f27");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c5a71ba-2254-b3ed-67ec-f64c0106c660");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c94d190-986e-a736-87ca-6787d693212a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3eb203dd-c874-2718-a2a0-3fc6a3d7ceb8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "40ced4d1-1d5f-05f9-1ecc-008ece9bf6cf");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "425b45c5-3bf2-b3cc-a8fd-011c300c5b6b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "42c4e64b-5f37-7428-68d0-ae73dd07c550");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "43218475-c208-8bef-45bb-cead9439d8b2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "453afb2c-a5b5-3cf4-f188-1fa95fc15824");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "490f3cf5-28f8-dece-4922-52671fb4a199");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4950a765-76b9-83b3-7de9-af0e949338d0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "49a1f7aa-8859-4cc4-b546-4549f789bf3f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4aff05b1-2e8c-eb11-a7d0-dc28213597fa");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4c7ef4e4-6089-5b54-70cf-462a7594d3eb");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4cce25cb-d6a8-8892-ccc2-05059e6a6f16");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4d46411f-dba7-37ac-8814-c7da719f6e3b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4f1f9725-101c-80f7-d008-fcc9271993df");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50a9ba02-e020-16d3-df51-fb9c4b19bd0c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52255222-934c-c40d-8d7f-7c438999b75b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "53238bae-d873-e113-c07b-94f7384f2a4e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "53bed5c3-f54e-2f3b-5ffb-c3d75fdef22e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5582813a-cf75-d0bc-d6ea-164333b8f078");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "55db5c7b-8e15-4375-cc5d-227a06438d38");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5614c18a-417b-4621-5dd4-a17203b6fd57");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "565b9687-a776-3cef-8994-bc338c6f1895");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5826bd17-eeda-6222-b4d0-8506d1ea4f1e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "594df6b5-390a-e031-8c8f-ec7beecf5380");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b05b08e-6f73-e22a-e582-c0117147df20");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b638516-0759-9513-853d-bbb34b652783");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c094776-5acf-2f84-62b1-e51885ebdbbd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5d8585f7-072c-3acc-02d3-036830d0eb38");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5f1cbb5b-c8cc-7cb9-7692-cfff312ba139");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61a67da9-b7bd-4555-9cf8-c6341152be1e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6381a78c-fcd6-d0a1-c4f5-09323d5ec98c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6421d373-2d22-5d19-eadb-7e134fb1514e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6634a192-1867-c0b7-3d6a-f40e9451b92c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "68b4d308-be73-447a-aa01-94326f1d8573");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "691660f9-12b9-5e11-9261-206ceacd9e36");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a26bb2b-10b3-d20b-576c-06ec7eb6881c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6afd119d-e28e-92e8-9e89-1af6996f754c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d007abb-5e1b-17af-b0f7-2c47514aa643");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d5ab6db-8f30-6091-2cd9-ea7f969fcbff");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e7e7ad1-76f0-2a98-4e52-aad698b8c7ad");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6eab02e7-1426-0881-1c74-99cbe1c2dabd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6f546c47-26f1-7ec9-b641-fc447770b8d5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6fd6173d-eb18-e8d7-405c-66721548558e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6fee2eeb-59d2-0c00-9a1e-8a30811ae17f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7094d547-fd86-a3c5-b337-839b1e5c317d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "718c2d6c-578e-b7c9-1e8d-5bc67c063ea5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "74775c4f-426a-3783-b04f-ccac0b514278");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "74ace139-e992-d91f-4671-52f639972753");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7600bbe0-0a15-349a-b9ec-c475880ecfda");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "767d2088-ae6e-01a3-af51-1f15e4010867");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "76c7b55e-03e5-9b52-34d3-5a7ffb9c90b6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7755d2e0-e594-43f6-6b2a-97e09a800704");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77584882-18b2-c070-5e41-8b0e717367db");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "780e8022-e459-3d7f-a36b-47992b26ace5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7978f9e1-f848-3ea6-bd32-b7ed5c2ba948");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "798ddc1c-e359-941e-9460-c187af5e53f8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "79e9a30f-cfe9-2f9d-cac4-f86e3962d70b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7aa3c75d-1047-67fb-2ace-ac1a1a10d694");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7b197240-8dc4-4b9a-bffc-03041ba80ac3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7bccd9ff-6129-4373-38f5-54b69ffa2532");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7d8f0718-91c6-2cab-268a-090d429358b3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7e81993e-6a54-b9ca-8ca1-a5dce75296d9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7f73fc92-af72-477b-9c37-49b6779a08db");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "80f54d52-7c1f-5ff2-d278-d08cb6fbe663");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "812aabb2-c7f8-2548-e7b2-c7c99cfa0b51");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "82854779-bd50-0aaa-177b-dbe72002170a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "82a38202-4f6b-41d9-11fc-0c59d2bdb4a2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "842306fb-458c-d097-eed8-909990df3d1b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "852e46ab-b00f-8054-4ee1-5649cb845174");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "857d4bd4-f8b9-a253-5f74-06ed5783b8cc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "85e1b30b-426b-ad04-17fe-fc152cee3378");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "86096d2d-028a-2178-b93d-d09c58fb798a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "873dd793-925b-cf55-c4ed-19f5ea134c5e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "882637b6-a3e0-c6f0-5adc-323fbaf06469");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "895ad2cb-c1d9-f871-0b4f-6d588817d0a2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "89af6c7f-eb9b-700a-1edf-c780be219657");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8a1b0119-fe28-9d70-3d44-4f08f1cc15dc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8b4e0e39-d22a-6b9e-f265-f1e56b32a5ac");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8cabb15c-08a5-3226-7620-6b7fd82c0ec5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e9adcb0-97f0-f605-d063-0d6f594f51ba");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8edbb040-f6b6-44c8-881c-6d2a3d8b7775");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8f6901a4-f5b5-e843-e991-5ecb27c6d119");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8fce3dc3-2a8b-c124-f96f-6798c213bfc8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9343be38-6a9c-9597-308b-b7a380d3341a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "93acaa36-b84a-93e3-4ab8-bee3839813c8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "94d53d90-c40d-2c7b-5b09-1fc3733efdde");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "95280675-9478-c286-6e61-5eadb6e04ce7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "96cf1edd-649d-c6e7-4f3f-63bb525f08b9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "97732f97-a471-d97e-a1c9-5f1e65501cb8");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "978254e1-40d5-bc41-fd06-9909777893d6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98a3af77-666d-b843-1550-1654d066a91b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9aec3604-2382-813d-dbe0-e829167d4d03");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9b04b38a-df80-4890-3b63-b52fc684befc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9bb332c5-28e6-8114-a6ad-33361e1c176b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9f1d52f5-5854-6344-7ee2-50b3aa2206aa");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a1dcbe22-1a98-b101-6d9d-6a1e43eecad5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a2eca7c6-6ded-0447-2d46-a31b5047bfb9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a4637bf4-ac5f-fc18-4f21-5d6060423cac");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a515b538-facb-a384-2fc0-09bd704b792b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5ba5432-532b-bdc1-4517-8f6657b06ccc");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a609799e-8e05-578f-a027-ff94df7272f6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6be719c-a6d5-4ec4-f3bc-079e2bc133f7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6d90d38-fb40-67d3-9291-4dc9433685ab");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a8052858-a628-5c78-0ee5-886932034146");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a86586f4-63ee-788f-6c4b-375c8c07cc46");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a9291ff8-90b2-be6e-9878-5cf2b98adf51");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aaf5124c-ec73-3718-9708-9cc8a153aa21");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aafbf12b-4fbf-f7ed-baff-ddb60852ded3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ab9e93c1-9054-3de0-5468-8fef169e2733");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac1087ea-7cca-ba5d-4716-69ede045aac3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac148527-f1ee-3bb8-7a18-397adfdb9684");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad51b75b-94ba-2db3-71d6-9937a00564df");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ae09acad-eb08-db70-af74-adc1671104e2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ae9de472-6ed6-c56b-17f8-0802b30e0ead");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "afc81f01-6ce3-5947-ba22-725ebff80699");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1a62097-cc7c-9e22-017f-ade4e5e982e1");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1ab77c6-75e2-be65-fd4d-2216d7df9169");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b259425c-b08a-20ea-60cc-b695e91844b7");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b3918eb5-f713-95f5-c1c0-7675b7e0b333");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b7631fc1-9896-70c6-3e36-19135b902372");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b916b170-861c-b14f-ad0a-9b5bccd2c0ca");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb39bb03-38d6-cd02-b341-89e2a660da76");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb543979-51da-e0a4-508a-34e41cd9c765");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb5e6b6a-0c42-fdab-58c4-fef95fcdc49d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bc3ad3db-d8c5-02d3-d06e-5f94d53d9f78");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bca7d63d-cce4-43ac-f1ce-560fc47e3074");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd85547f-e0ea-e2db-db8d-c415c58afb06");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "be7e99bc-ba4d-f226-9d8f-03682d23bee1");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bed021d1-ed16-adf0-c5b4-2953fa35048b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf1e2694-409a-773f-6c59-a05a8af0527f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf51ec1a-fa3a-3c43-080e-494a6f7e3910");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c15c6cab-3590-2006-a628-67612870eb60");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c2516a1f-5f3e-7e0f-7b86-9053846377c1");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c35fb6be-96f6-0788-f95f-8449add9c5b2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c3dd11cd-08a8-d8d0-60c4-add26094c881");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c565c6ba-ecac-b786-5785-0744bdfcabc2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c584e914-d15b-6c1e-b33b-e87707b1c8f0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c6a456ad-719f-6857-0f33-b79bec3aec14");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c6e7c556-e76d-2b22-aced-041ba0d8cb09");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c8126fe8-b8d9-89f3-fefb-a1e84543f875");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c9ca3188-8a21-724a-23f6-5d9e402ab287");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cc712312-dee1-743a-9da4-ee708f3d06e9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ccb09398-5ba5-01ed-ab10-93ede45a2ff4");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d01019f9-5218-71f9-d3a9-35cb7b04b12b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0486529-51fc-62a5-004c-ecd5002ccd41");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0f8efdd-4c40-b515-a8d1-d855a962a852");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d1ae562d-8ff5-04f9-e4f9-be70373beea0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d2041949-1d00-ce16-fc7c-30c218a75f46");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d32c9013-9fb5-9f83-708d-3e02f83631cd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d3edfa54-1262-d190-899b-a472871c59f9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d4a343e2-40d5-57a3-222d-bbcb5fa7a60c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d50e4726-2991-977e-1e9d-ccae720f4778");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d5e30992-c7fc-e449-6e8c-e9ba67574c4c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6285f6d-f25b-009c-7042-a47f4b244b68");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6442191-6705-0a50-37ea-73d811f12b11");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d698f229-ec8e-a652-a33c-b1dfd62a38e6");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d8ee1684-8213-4b12-219c-66a273f8d1ec");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d96fcd78-c30b-080b-c92b-7d26c7dd221c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da5a50be-4892-2912-7d30-e020f44c2bf3");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dadf92d7-0a66-08ff-9067-d63a9ac831f9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "db390cd5-f0eb-b466-37d6-608ce90540a5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "db8d2ab6-946a-1502-426d-fcb21953e405");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dc15a337-285f-ef85-0d15-e43c62677ee0");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dd9e690a-8f67-72b4-629b-15a9d4cdd73a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ddd77ae8-2557-f2dc-0582-c2c104a0a18b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dde5dca0-3459-b459-a095-94f8a5eb4711");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "df815484-6a48-1b4e-a7ce-2b2a4a85d3f9");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dfe2714c-934c-ef19-fe94-6c4db509862a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0bb8201-c45e-a7cc-9a4a-f0921c6fd86c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e1738f37-9fc0-61b6-284f-5715db5ab025");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e2513fbd-3f02-efb1-92e4-4d7524a0a9b4");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e260b095-b963-c13b-b5a2-d609ac8bd890");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7d00346-218a-3d24-b03b-7d2cfa8d6d7d");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e9479010-3a2b-6354-2e0c-11b49b24fb5f");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ea06b88f-d8a1-ee08-bc3c-d84a42ccdacd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec071909-de0a-3e67-a7b9-4a4b07d9de99");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec341556-c367-708a-11c4-097536f47dcb");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec421852-921b-ebfc-d739-8212e4385e64");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed3dee0b-d891-bd85-2ec9-065516fcd123");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ee921d29-66e1-c443-c162-df77ae566e01");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ef04b83f-9b1d-9814-3a9e-a3c0d292ac3b");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ef55d5ee-4787-d8c7-b1fc-0862746ac28a");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f13edc40-466a-6629-9715-d914984c3653");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f4c16c8e-12ba-3b16-0555-dcebf1a93e21");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f509123c-dc8e-d71a-ddbf-4cfe70107308");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f5bcb9ad-0454-f4d3-389a-3f1d78dc2a1c");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f692a256-8b14-1f69-5d15-3c1942f5c5f5");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f723976c-ee91-b770-e7cf-4c2ddd2e10cd");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8cd0d8c-907b-551d-6211-931279dc0942");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fab65069-a16f-8092-41b3-2dfadb5b84c2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb099bba-fa75-cc47-57ac-dc2ce717cf7e");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb4dd0a9-4c1a-c15f-1c5c-83953364fcd2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb91193d-c432-36d3-5e89-59f7ac76cab2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb99eb83-8abc-f0bf-d8d5-d3ea90a38837");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc3c2b4d-ee65-87b1-8670-116de9888753");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc5fd85c-a36e-f72e-7eb2-0ae8930091c2");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc730fac-20a9-8127-7fda-2bd0fbf14448");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fe2403f2-62c7-83ab-fb2a-f4d6cb4cea82");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fef0fe5e-f84c-8548-71ef-b871756abbf6");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 31, 735, DateTimeKind.Utc).AddTicks(1144), "$2b$12$dOett./jZjU0fGM.nO4Ze.0SdQz10JNLI1Dwnurfoc8dRX93IhiI2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 3, 764, DateTimeKind.Utc).AddTicks(6237), "$2b$12$oWSnwZLd3zGHM8rouU4Bf.TD7Yg3zuOHLldtr6EAzGOTQEtU3RDUq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 21, 976, DateTimeKind.Utc).AddTicks(2485), "$2b$12$JfcKGM7U.auJUoC1sT/kBOCpZ6nvIrxuOgrWcM7YKOJEn5B.Mp2WS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 1, 847, DateTimeKind.Utc).AddTicks(9500), "$2b$12$VN.h6J8F8/9RXH1y8cjbTu/RN49fsv9U4BBRMDIPNhdEqW34FzZ66" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 8, 637, DateTimeKind.Utc).AddTicks(7940), "$2b$12$aUrqfcUM/LAmJeSSMVJTHumshXWJ0zVkqF1kRLpRxhxrv0V/MS3gy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 33, 290, DateTimeKind.Utc).AddTicks(2174), "$2b$12$6krsyy5Fzj1k/K39LQ2DMuRbs7spO2dhPPi5wzrlOJnH/TGrqpDT6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 57, 403, DateTimeKind.Utc).AddTicks(3692), "$2b$12$ehIU9dZbgFOLU.fmT0Dk5uQYLn6IZT6bKCjDHV2vVddb8L9WiMYcW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 29, 860, DateTimeKind.Utc).AddTicks(8046), "$2b$12$TSUvJUsBvoOr5y20c7O3Pe.z0G3hihZP4iCrsY4FtbEahptPs3ONC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 11, 791, DateTimeKind.Utc).AddTicks(1272), "$2b$12$J0hONoOO6Ckd81eZOV0jaeOkUctKg.72wMpXyWyUw811FWRT1Luee" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 34, 273, DateTimeKind.Utc).AddTicks(3034), "$2b$12$Uzn3GWW5G5VlVBKkru8VMOGHd7aL4p49vGT5umnCEpRfWdBb526hq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 15, 300, DateTimeKind.Utc).AddTicks(9973), "$2b$12$qublyqFbB/wdCHSyir3S3.DMOYlBLaSLAQoagRJ7nn3QTt//eI33K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 58, 993, DateTimeKind.Utc).AddTicks(4970), "$2b$12$L/OXhnHyMzCBuzFuTSM3Suisil2lSMmzVyuA5bDU0n1jHs0o9hXJa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 19, 772, DateTimeKind.Utc).AddTicks(2737), "$2b$12$gqjf6eHPPo8nFVWXfr9pjus5gcuROWByPF2zmwdCAcf6NWJ.UOsq2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 7, 376, DateTimeKind.Utc).AddTicks(4997), "$2b$12$8R.Vz9t3nDIszNWNiXG7Tugfp7Y7awlXvb6WAvlVMRvdZSqCfo/Uq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 24, 216, DateTimeKind.Utc).AddTicks(5501), "$2b$12$v.O64l55iKczyWM6F5uRBOIS2TOOTLF/UIQifztMm3PnqJZu6anhi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 59, 944, DateTimeKind.Utc).AddTicks(194), "$2b$12$8GCXerJH8eOd4BBXNc7O2.8AI.GTkybyuqnfgYDFhgms/zpbVpxD6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 0, 576, DateTimeKind.Utc).AddTicks(5826), "$2b$12$UP4a47igidM09zAFgdoWXO9m5AAtsIs9WcLBOxgWtgNBiZUFRI0HS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 28, 227, DateTimeKind.Utc).AddTicks(6866), "$2b$12$MvuWzTDXNMyhgnmvbUNWsuqRmpWfEb/tfOlcWkLhkCZQtiEjBwhuS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 4, 452, DateTimeKind.Utc).AddTicks(5104), "$2b$12$3hAlgwVNjJm9x3BcENuzMu4XPAtS6HbxBKZP/dUNC8s0c6L4ekt0i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 25, 882, DateTimeKind.Utc).AddTicks(2144), "$2b$12$ThOo9Mrkk7GXSfEGbufpJuP8.8zY7NN6wlZwdYosOyMfhX..gqfni" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 30, 481, DateTimeKind.Utc).AddTicks(5382), "$2b$12$ib8hyVEHZpcPcSM6JPs0pOou2s9PUmyRS4TLZivnxx/7N9aYheWre" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 14, 357, DateTimeKind.Utc).AddTicks(5796), "$2b$12$Kged9gZSk.hM39mCXLA5zuY7r0LI7GmnUFI1l1LCMIw/dlRvyxEa." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 33, 919, DateTimeKind.Utc).AddTicks(8337), "$2b$12$eZa3Bq5DWLpHR1tajHI5cOzmHbD1BgcCI2cxwRlTgum5rVMVQyx5." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 26, 917, DateTimeKind.Utc).AddTicks(6193), "$2b$12$5.em.fh0eVKdKNokhXNnvOeed.nMMidEa5K8.Mueucq9retvS4.Fi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 24, 863, DateTimeKind.Utc).AddTicks(657), "$2b$12$l3uthPPhV1hE4wMKKeW05OXDiSAJXvZObd0.t50ZpJeppYSCMwbLe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 56, 419, DateTimeKind.Utc).AddTicks(3846), "$2b$12$YNWcQOYPfrb1sfl3BZCCWu7htvrWvgDEXTzcOsaQVGJ2Vln95YOoK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 7, 53, DateTimeKind.Utc).AddTicks(5590), "$2b$12$yMTDTXQU7x2c.JfyRTyi1uyd6cYndu/75gPgBFR.SobeaiXYaob12" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 58, 38, DateTimeKind.Utc).AddTicks(2959), "$2b$12$6ZLSU5V7R7D7JaC/HppIceViFPjTZsc84gqKSlXuvedzNnSVMO4LO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 31, 111, DateTimeKind.Utc).AddTicks(3518), "$2b$12$MUi9vZv6Tr3JQbGjj1LJ7OItwX8Xd.wher6uAPaDGtbYUL4mi76NC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 57, 720, DateTimeKind.Utc).AddTicks(3967), "$2b$12$5CUOXxtc9491CpKBGLb01OV4occkxHwib3gO8WAoDXYtdCKIWmf6m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 18, 828, DateTimeKind.Utc).AddTicks(7168), "$2b$12$rXASeZruYpSnV3qH2Ah4yOtXHi.IsvaRUm9H2nK3.SqlgBAUVYe/y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 20, 92, DateTimeKind.Utc).AddTicks(1848), "$2b$12$eRLSOHujueZKQNb9OdxvXuL84HBZ.ldWkBcwL09r9Gzl09wrRFFSC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 17, 882, DateTimeKind.Utc).AddTicks(71), "$2b$12$8SxjYSaLel86iSqzvpGKLOUUHwi8n1sl4mWvlW49rfw399PNhxPL." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 29, 525, DateTimeKind.Utc).AddTicks(5480), "$2b$12$Y0cjV31UiDUrVjZaXGYR0OTWjkqeRkrxh.hR8MyMFLF5dK2bZG7mS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 16, 570, DateTimeKind.Utc).AddTicks(4672), "$2b$12$wCa1nxKiNXYfOrFRfNeTU.xeqWcQvf.kh/6DzN1qgHj.TUtqc78ke" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 15, 616, DateTimeKind.Utc).AddTicks(4576), "$2b$12$tyYC9RQP/xpp7reWNXrt1.8CxwZhYXt7CkJGHRmlH.W36.xv0GBzG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 1, 208, DateTimeKind.Utc).AddTicks(6411), "$2b$12$7mVqqurXSCUclXv659As9uNNpa/yxAUSARhs.MZO.fOViNgLicDPW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 58, 353, DateTimeKind.Utc).AddTicks(2714), "$2b$12$eGdhAj.kOOGW0jePzWXcdOHaCiYp8YUh0iwh5.tBB3HhnBUyCZDd2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 2, 806, DateTimeKind.Utc).AddTicks(5166), "$2b$12$dAA2y5Hp/Di91Y8oSXx8UetUy/uZMwLHC/akO/5Mt75xdviHZPjZ6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 19, 456, DateTimeKind.Utc).AddTicks(8816), "$2b$12$Jx55x6/p/IS1PLMIecM82.RRcsbRbl30pkvcAsiTLGGLWaa78Iaay" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 30, 792, DateTimeKind.Utc).AddTicks(6837), "$2b$12$8nqF2eCaEW2HsDEkLN47m.BoX6j7nqXJOjHkIx8vTkEalA4t72.D." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 59, 636, DateTimeKind.Utc).AddTicks(1181), "$2b$12$Wydx1xCvPDFWAzkZ76fsZuXyfwOiml5VJ0jP2b.78MznmG5csUFGe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 32, 351, DateTimeKind.Utc).AddTicks(4859), "$2b$12$80HpqclVagWeiqIW/z8AU.y3seXV3v7Vqo3uSKw8q1pC4CgpD2Jr6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 22, 292, DateTimeKind.Utc).AddTicks(398), "$2b$12$dJ9tEBu3nOpZ6rolwYCp5OkDhROySm4l9IxOGKKcZjeAZYP9fcEEq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 8, 321, DateTimeKind.Utc).AddTicks(680), "$2b$12$b9w6Z741HCumVLbCCS.h2.x38sejnenY0z1ofuvPZFG7Dmqz7lF2i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 13, 42, DateTimeKind.Utc).AddTicks(8861), "$2b$12$E9I/oUEt7ePFlWoe.slG4.t3WbLVyyUzC54ig.Rl2o9vBhKivehDm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 33, 612, DateTimeKind.Utc).AddTicks(4859), "$2b$12$82wssYwQfo57x7pCxenkiupHoVKwpi3naoCSk6.GYQhBR.T2f3Eky" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 25, 185, DateTimeKind.Utc).AddTicks(3206), "$2b$12$vZtwIaJiMW7te6fgAKDg8uRWlxCDzrWXHijEdu3kYonQyPVcXN2IC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 17, 234, DateTimeKind.Utc).AddTicks(3172), "$2b$12$4R/K2tHTCdhdANINi1if2upKQYH3z47RPQJ0HbjXhSPhKMKDR7MAi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 14, 986, DateTimeKind.Utc).AddTicks(3411), "$2b$12$o8Cxhkv5.U0I5lu8zfEt9OBG4HEDeNuvSk4EoXnq.G4NC6yy/xBry" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 3, 124, DateTimeKind.Utc).AddTicks(5630), "$2b$12$RIDr1Xl7mo7DDT9O2uDcY.qtdL/Rc/0KuKHs374LO8.46h.XE5V32" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 4, 796, DateTimeKind.Utc).AddTicks(5968), "$2b$12$k3NG4a2FxOqhivNFahQbiunaV/IcjIEK0o3/HnY5MNe1B1rkiVnbq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 23, 243, DateTimeKind.Utc).AddTicks(178), "$2b$12$6tqS371pUtEDKty8OqDEkeIjxkjYTy/Mskx6eBEIwil9SD7SRHwOK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 34, 589, DateTimeKind.Utc).AddTicks(1968), "$2b$12$vuSy/qpsir1BLiDt.w4/tu.wzP7X.Oi9Riqoeu3WnKVUo8ORW7v86" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 30, 173, DateTimeKind.Utc).AddTicks(5973), "$2b$12$.bpsmRiOaNkin00NTOw0quCJ0wAR4BkA2yXDApwOxUOI.HATTps3u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 21, 660, DateTimeKind.Utc).AddTicks(2217), "$2b$12$ZiLDyy/UWhYPUWfH4Rhyj.iHzVO8gXyi4ziiEUIeKoS77eE3.0bru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 4, 110, DateTimeKind.Utc).AddTicks(673), "$2b$12$l3bAHZtaOf6v1wlTuofppOtN3gHa.XfbNUewwza8/W74TeDut9gY2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 14, 9, DateTimeKind.Utc).AddTicks(5110), "$2b$12$zeeFz4FKASJnLxYO/yG/s.BbflWzGDSR74qWn8ki7FRwX.6.Fkrae" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 10, 529, DateTimeKind.Utc).AddTicks(2660), "$2b$12$bpYWpSmPK8HEJUCSp4ti0OLzGOxQ3XVVCNs8VEkdrvYesXd7JZiKm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 5, 134, DateTimeKind.Utc).AddTicks(1187), "$2b$12$zmQGOpjEXl1LC1jwSRtQke5sSgX.Mc62cRrPyEj7LFBO5HL/8ZgWu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 18, 194, DateTimeKind.Utc).AddTicks(7091), "$2b$12$f1k4FfpdcyRzkUfwdjVFpOBWDZxN68XT3FHEJkG5KEmm15uISiRUa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 16, 911, DateTimeKind.Utc).AddTicks(1698), "$2b$12$NsoVygewzmugj2ouBZhF6..GoPkhAD7ZXA2emaagwVhJRqH9vwndm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 18, 513, DateTimeKind.Utc).AddTicks(3028), "$2b$12$ZTQzLYiUlhE6KmoqUs56oefdQ1V9FwVt1lD1y/9gAS4c/UY0B0Tmq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 27, 253, DateTimeKind.Utc).AddTicks(1866), "$2b$12$IJ1uKYtmnRI3QM6T/dQZjujWZm9gAwOquJKHaKgNzydXSAeUbIZdu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 24, 537, DateTimeKind.Utc).AddTicks(5786), "$2b$12$h3big89J302lJtfgjvAS6.Na2OM8TvgUJPJcsvKTl0RQmxepikgiO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 20, 715, DateTimeKind.Utc).AddTicks(4492), "$2b$12$aezUsCPAQ9YiyVbBTAPbbe2JamodiVPCnaqWo2LJTBQ.1BVwryVIq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 23, 556, DateTimeKind.Utc).AddTicks(803), "$2b$12$SQOMFzJMcCcy1AYcpKlRwOorRkqiid3nUWUvsxxOzfBHU1gJsGywO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 11, 159, DateTimeKind.Utc).AddTicks(4746), "$2b$12$aBSEbuhYtzJkE5e7gLqw0.l5CyixKGBaGOngrgO5VKPXXH0CwuecS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 5, 455, DateTimeKind.Utc).AddTicks(4542), "$2b$12$OkS8.bfzVRwdVIhkpJK7DeWcIaaaTxCHr90cq/j7Ho.C/hv0f6NAu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 28, 883, DateTimeKind.Utc).AddTicks(7892), "$2b$12$gjzmA5lUdUIbJj11w.R79e5IGH7W/JqAn96dcXx5LTWkyhNRJysFG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 10, 840, DateTimeKind.Utc).AddTicks(8904), "$2b$12$61DCtqriSKQj2KstKooM2uYu2vJ5qn76TjnOjERPGQvavfaq0haWK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 9, 581, DateTimeKind.Utc).AddTicks(8515), "$2b$12$deJgw3JmVSQzXZ95skFk8ePLpULZ99u/CzVVkq38dHoztVMgONV8G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 28, 567, DateTimeKind.Utc).AddTicks(5444), "$2b$12$KBOuKfbSfNuonTe0BlAN/uK4iOPEoS6teJTrjPc7wPXcnmm8AjSA2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 13, 366, DateTimeKind.Utc).AddTicks(1617), "$2b$12$mZLm5VzcyUA1QgGkahVPIuZLXSJP1fUyD3DOblvfk9.VGjkjfNZOi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 21, 29, DateTimeKind.Utc).AddTicks(5418), "$2b$12$T4AZMz4wcs79qFDvQx1Z1OvlaYEQQvMskV4eFJbhXFG.MDbSV7Tw6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 9, 899, DateTimeKind.Utc).AddTicks(6886), "$2b$12$fsApyLOeD7VK2VXVrXIyq.YGDXSA0wO.2t/00pUgINoUJDgclJWZq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 12, 101, DateTimeKind.Utc).AddTicks(8003), "$2b$12$woxFeduxoD36U0o3UWNmDOoChLpD5TiaDiiJlN6bbSr3lsM1OUlsu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 32, 43, DateTimeKind.Utc).AddTicks(7604), "$2b$12$0YwiGPTj1vSRIbbqlFSt6eV.Ah.M84gfAL9NsAOTIRY5ly5EZF6I." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 29, 209, DateTimeKind.Utc).AddTicks(3424), "$2b$12$tx6v.3j1emQCsfXuoCSwUezMKw8wS5HVrsJEbXDoyVZtOCykfH33." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 27, 579, DateTimeKind.Utc).AddTicks(360), "$2b$12$ShNzQhIPZGsur9OUpY/wDOpQ3vsR3C9QpUuMymigJmqQp7C9Cyyqa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 26, 223, DateTimeKind.Utc).AddTicks(1142), "$2b$12$hklz2sKrGZKrtgEqBD1tVu4uJ/AtSgAmWYkhuqwR5G8.WPwV0L0Y." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 21, 345, DateTimeKind.Utc).AddTicks(3243), "$2b$12$BrnXJffLA6Ha8VdrY4fjD..n.ScBnctlcxeVQyIE5k5zz1.47AQu2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 15, 933, DateTimeKind.Utc).AddTicks(7995), "$2b$12$vtBGLqot873xxG6HXlQeQu93JUz/gkt.OMPadTCetas5kyVDqOFFK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 32, 658, DateTimeKind.Utc).AddTicks(185), "$2b$12$8DS.5s1A9Xvefj5oid65weUiIzHEgifI0yluvuz14h0LejDAq71MS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 13, 682, DateTimeKind.Utc).AddTicks(5326), "$2b$12$rU7YNmshzQUyrXTStV4nl.NqSLTVZSug0Jw0y3DlYiSZTW8zJ8FFu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 8, 9, DateTimeKind.Utc).AddTicks(8492), "$2b$12$IbIXcFyT0/ilfKJgQxi0n.gMFZdcHZMrFmDkPptbZ19zgJv4xk/0O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 56, 764, DateTimeKind.Utc).AddTicks(8245), "$2b$12$BqQKxzVUHUXB3rj8e2KxDen0FP5Aos/xLHJhcx5enbY.9HbYh/iDm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 5, 773, DateTimeKind.Utc).AddTicks(2446), "$2b$12$KEmqKWw.kgG1ARX2F0spKeTCVW.kG/lWQFiXacLssVUrGMyxbGeVu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 22, 927, DateTimeKind.Utc).AddTicks(7675), "$2b$12$7C0yp7peW/kfrLXZjDNKfuUNsZPpddEX1L77xbwPEJw9WbrJM//LG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 0, 267, DateTimeKind.Utc).AddTicks(5321), "$2b$12$5PSOQSCqjrjyhKvysmkSm.BU3FkzV/k.HUCGY6vDGy1LwYCdF1EiW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 7, 695, DateTimeKind.Utc).AddTicks(1648), "$2b$12$MogOh3QG0UyHGxbTbdtlC.JHMgGoQIEcWdr1drUQ5sfYUyNwnWCu2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 19, 139, DateTimeKind.Utc).AddTicks(5665), "$2b$12$93ZPs7co2pmtwbue59zkNeEJY6Vo6Hi9K7CQEu0rbPnva.a.DWsPa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 23, 866, DateTimeKind.Utc).AddTicks(636), "$2b$12$lcZWBeDMIgtm55mNevhMfOnw.xNq0EQ.qrSDoEhMBmtr2cLqAKjvm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 20, 405, DateTimeKind.Utc).AddTicks(1836), "$2b$12$neFyJZa/n/0U8NApNj1cTOmAbS/bd5cj.piVZO7/Feh/YkeO1jMPy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 6, 725, DateTimeKind.Utc).AddTicks(6350), "$2b$12$EN7I.ysvFrcJBmhW6KGgxeLjH3BrvzfITn8.3c15ZINXoIjdSTC4." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 22, 617, DateTimeKind.Utc).AddTicks(2629), "$2b$12$mU/fc68VBKkTs38QVlFJYe1eAEDM7FkdBJ2pDUJjnUjeqTu0wowbK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 14, 672, DateTimeKind.Utc).AddTicks(2448), "$2b$12$QRlvh9IHnYedeYIkOesOUOsgF2.3a2KbQiGtAYgXK3DfDEzHHdRi." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 17, 551, DateTimeKind.Utc).AddTicks(2728), "$2b$12$iN3yMYY15SxoylYutFkRv.FqTGcJ39oLzVMcLytkl/MH9Oc3pqhru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 3, 439, DateTimeKind.Utc).AddTicks(5567), "$2b$12$vcjw688fomL7SnHsF0ZMUe24sG44rK5LANcuVIjbywEzIU.33Dsly" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 0, 890, DateTimeKind.Utc).AddTicks(6902), "$2b$12$7mI9XrrO63AZMmfzU6vrnuU8qYVplLi5BQDcWBvLYswOxv5oDXPDC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 59, 315, DateTimeKind.Utc).AddTicks(8761), "$2b$12$xPJLcgP43i7EjoomQK0BsOjgDv.kEybgqmvcZwi4J4IIOQBa4TPoe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 16, 251, DateTimeKind.Utc).AddTicks(2131), "$2b$12$m6rZ6cf33aE.bfERydpxfuSQHRBc2PJrrcS0Ryl98BsSSecJQatNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 8, 953, DateTimeKind.Utc).AddTicks(6338), "$2b$12$NXNOexqCI0rtWpJvEBhUfuaXicqesC/q/Uor5Ou3Lc.QlWwQr1DLe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 57, 93, DateTimeKind.Utc).AddTicks(9823), "$2b$12$dF4fgt0Rz/XWIdtIMO4XFuVAbCkwbBhRRsQVJspDtTp7n1q6tjs5K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 10, 216, DateTimeKind.Utc).AddTicks(6510), "$2b$12$p5C0vtuycQA8T6jOJ1ysHeF.iHQh8GtqcW.DEBORjbw8gx5dwZin6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 25, 532, DateTimeKind.Utc).AddTicks(8724), "$2b$12$wtxrFjX46h2YMCrfRoigvuw9sQ9lomvCfeV9dYtiDoc9.1uIuqa6e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 1, 522, DateTimeKind.Utc).AddTicks(8207), "$2b$12$CMrQ1kVqD/pg/wTx5IH4buYIGTm1SVJ.1fmZ48PZKQJux1Af5s3Yi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 12, 415, DateTimeKind.Utc).AddTicks(5806), "$2b$12$0W8uV5pkqxGoHjfUSVcMh.P.DIvyn6D2Svu2OdSrXmkirRnB0c.z6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 12, 731, DateTimeKind.Utc).AddTicks(5560), "$2b$12$rFRISiYqTrUFJnNcU7OoOuwC8Rt45MK7LHH9XCsfjS63Yf/Uijkpi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 32, 978, DateTimeKind.Utc).AddTicks(4813), "$2b$12$3YS2aTpZdMLZpEgj2Zzbmeq./7/X3ZSbjsa8bn5E.xdnVPUmfw5cu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 11, 474, DateTimeKind.Utc).AddTicks(4548), "$2b$12$EGrF1XmRGZsOSSENWJEh9upMKweOv0licAaVLUGw.I6bOM2q6lbgi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 9, 270, DateTimeKind.Utc).AddTicks(5667), "$2b$12$gGt/OEOG3fK2H8ct9kVBB.zkgWxwZ2UbG2Anx4aCfXwOclF5WIQ7a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 27, 898, DateTimeKind.Utc).AddTicks(948), "$2b$12$/IPkSg5KMXBJNA7jgbmhRO7x2LBtvPX6gGZ0r1V13jX1PKjIKFjoS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 6, 405, DateTimeKind.Utc).AddTicks(8668), "$2b$12$SKQcVvHT0JwBiibm4ODkWuIOu4WEmUZWiKWiV/LGHPUS3HKOW8gka" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 31, 425, DateTimeKind.Utc).AddTicks(8176), "$2b$12$DG5ews3fqu0TVrHvE6PGMOPOeIwkFto0YIMShO1Cysz3jS.KaWFAu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 26, 561, DateTimeKind.Utc).AddTicks(4723), "$2b$12$jdtEz2Lx9SPOZxQhF88pKe7OF3HI0KlKD733Y5Gj9tCiWk2PLHHli" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 2, 482, DateTimeKind.Utc).AddTicks(318), "$2b$12$fFmf1LPVUzyJsK5Jyt7Zruj5Wbh5YDqJpdmPzdhfb2Qg2yUaqVeZW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 2, 162, DateTimeKind.Utc).AddTicks(4279), "$2b$12$ejb0yuz9U091vyTn/nDNtOlLMVq/GX3K2yac1L9U816FUci8uapaS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 23, 6, 91, DateTimeKind.Utc).AddTicks(6604), "$2b$12$m6ZfV5kMf0IQWqDxdD33WupJJYopqZeEN7X.kLbyCjMv76k05sPSq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 12, 22, 58, 672, DateTimeKind.Utc).AddTicks(1569), "$2b$12$hibXGfQWEjA.3Hvss5DJQOIfJGhTqkSicd8mCFNquLULjzaOC1GAu" });
        }
    }
}
