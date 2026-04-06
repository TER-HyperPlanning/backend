using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewBuildingIBGBI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "bc224e06-c4ec-98e8-c492-0a528471d3eb");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "105f2e79-3a04-c9be-ebe1-241b17a81848",
                columns: new[] { "capacity", "room_type_id" },
                values: new object[] { 36, "2ebbc802-19e3-1c66-7809-e0126364f9f3" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "room_id", "building_id", "capacity", "is_available", "room_number", "room_type_id" },
                values: new object[] { "93a4338a-6691-98fc-6919-1f94663cd1ae", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 50, true, "IBGBI-10", "d1026790-e6d8-e5a5-d486-fcd720c78c6d" });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "000e4bd2-bf61-3b76-d413-c78ebd570ff6",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "002a1014-a1e2-26f4-5676-8024dd9afa89",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0048393d-d5a2-01af-d913-bc890fe8b2ae",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "00ab48c5-13f7-71a7-c1a4-2bac922ac15a",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "00e55ffe-e77a-1041-83fe-f230819a98a6",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "013253fd-915e-ae02-98e4-8f6204070217",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "013a00ac-ac8b-5c01-8a57-5e3a952f41c6",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "015728e2-d208-f4cc-9b3c-b972b482801b",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "017daad5-244e-acd2-1ce4-07c75f5c9f04",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "023ec71a-737d-43c8-3e94-e93046aab748",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "02a2a3e4-b5c0-289c-5dfd-95324e623d49",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "02a38241-54e3-fc1c-a085-db7381eef5d9",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "02b8e933-beee-fd21-e81d-20c13cc2b9d9",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0307a4e5-0941-b6f9-6e98-e48ede3c5f57",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "035596ea-77a5-4678-2440-1215400176b5",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "03a99c53-fb54-e2d7-6a4a-3c27563d7b9c",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "03ce2aa5-d5db-91db-2360-24f91d8fffae",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "04231bab-5384-c392-08c9-c01c6bb0cabc",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "042bb7cc-acb9-432e-6025-f01f85edc241",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "042c2061-f2ce-afcc-e0c0-a7bbfcebeb13",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "04ccea8a-4e53-42db-c31a-0e8f2c805783",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "053f68e1-2f0e-089c-76f7-de930e8668f9",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "05bd8efd-7965-885a-712a-23b65c741a8d",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "05c1638f-8bd7-6101-ecb2-b86c4e36c561",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0619bcc0-e7d2-f53d-c4e0-62615a60b730",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0633fa76-26c4-bbb8-04b7-ac2dffc5035d",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "06798c1e-baee-3f07-8608-65bfd694a86c",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0685daf3-3082-e3a4-9172-380bdece93e0",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "06db607d-9866-9b91-3737-5d793f448048",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "06fbdd75-3178-994f-2bc4-64827db7e420",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0733286f-fa6c-43ea-5ca3-7184db85512d",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "078427d0-9b6a-f123-fccb-8e5843a2e640",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "07a3cd0f-fe14-505c-acdf-f777e37778f1",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "07f20e2d-9dba-3c0d-6168-ee83fdae9385",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "08859e7a-33b4-e98b-b9ef-f754da6f424b",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0993178d-8c63-8c40-84f9-5f0d8407806a",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "099762c5-ed02-bda8-408f-10c6f211f013",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "09d5852e-c85d-b871-49a2-71c8d434e139",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "09db97d8-0c10-1a21-a3b2-f3c20dfe9541",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0a613941-9193-abf4-25ce-a79ed34acf0f",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ab1812f-650e-a53a-7a38-d1191221716b",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0abc4d04-e557-58b6-e4bc-7e52cfede4f0",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0b0eee80-ebc9-0e27-a0d3-4124d340c71d",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0b13de7b-3a06-5d38-eccf-e9bb8db4be94",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0b8c5e9e-5f59-32f8-19a0-b9e05ef5e471",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0bc8e3a7-1aed-9f32-20e8-ab95b541caba",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0be92ebb-39d3-323f-c309-af2cbab9b45d",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0c1cbf11-dddf-ea21-7833-1a99cf78dca5",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0c68876d-2d68-d530-2757-956294ff1bed",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0c81ee88-383d-927c-6006-4e96a8d886ec",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ca13d95-21d4-4344-4fdc-3f66b69dbcea",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ca55a2b-4b81-c691-b83c-cb46471e0616",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0cbe619e-67d3-8823-4c65-dec3ac8099dc",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0cbff9d4-4613-2d77-f1a3-6e9f4238a87c",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0cd4c552-ef7a-3da8-74d3-a0393d836d30",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0cf2cc5d-7bc0-f1d6-49b8-99c8e5afc22b",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0d323073-926c-387a-6b75-477f3b92ea32",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0d5335ac-dc82-6607-9000-ce5fb7df023d",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0d647b97-8742-6f60-67ee-364224b37cd3",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0d9f5e1b-8b16-6512-1aad-b6fc5bdbda7f",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0db5aa4c-b64c-85d3-5b73-cd92292e43ea",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0dfce57e-1c19-b29b-f7ab-cd26312b81cd",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0e09a6c4-a5a1-ce41-7427-98ad5a20a6e6",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0e69e155-7e89-ecf9-0898-eae3fde0a324",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0f278cb7-49d5-fcc9-b743-6c6f611b8aac",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0f3ee739-6e6d-b37c-3e2c-e659b8890a09",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0f702402-059d-f301-63c5-f10eae2added",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0fc4bc8b-3404-5c3c-c5d7-09b74f410c03",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ffa3237-44c6-cbc5-cbe1-753b3c1f3f53",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ffbb5cb-67c7-7591-771c-7e61e0be9564",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "109e11b9-63ad-7b2a-f996-09c4ec8a2ddb",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "10c6170d-a542-dc14-754f-794aa16ea0cf",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "10d1bbd1-75e6-a8a3-c89e-ecba202d1271",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11065baf-e680-3a0f-0ba7-1eca5f0d5203",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11182c03-8ce7-41a0-f2c1-7ecfa75f99a7",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "111c4df3-ceba-47aa-1a5d-c7d24b08f76d",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11219807-2307-1246-8bd9-cd76bf2b52ce",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1133eac0-f2b9-5576-b0b6-bef1f79782c7",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "114acc04-a14d-ea71-5c54-bb541e5bb9af",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11a47728-c8f9-ee9b-363a-3a89d6c24797",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11ac6e88-a54d-0fb7-d0af-0368bd55f51f",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "13000bbc-8fd6-1578-7278-d709f023eed3",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "13665640-d5be-7545-5e75-b567631717d7",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "13a85b72-767a-1cfd-2772-a56d405675b9",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "14371330-5831-44bc-b927-34fc4f913bd8",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1452324b-c53c-15c4-079f-4a2000e03019",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1452a1c0-db9d-3a7a-f9e0-7f084ab80c38",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "14594ac9-3b25-cc82-e23a-685226c86538",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1491b2d9-7dbd-4050-013b-0d4c38aeb869",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1497fba7-91b9-0f9e-413b-a1a7a9487f45",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "14a89b1a-19ff-ce17-300b-e17e3bd1077f",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "14cf4c2a-44f5-3e25-70c5-a8ad8fd3e3b8",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1541dee3-e76c-2918-1744-06067e21c1cd",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15ba8680-1073-bb6c-6f10-054644dff3ca",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15c2362e-1b5a-491d-5f6c-db02bc21d939",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15cfd3d2-8bc4-c1bc-7fd9-d3de7f5d669b",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15d70dbc-6c98-76b3-999c-21437cc800e5",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "165b9f17-2130-1b34-da4c-1235fc6ec986",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "165be93e-3f49-13b1-427e-af18f7d6db8f",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "16a954b2-61f0-b37a-7693-a0b61d5aa2e7",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "176b9a55-95f2-70a6-0d8a-c46a6f228bea",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "17a6c3f8-2b19-7397-ad33-b2feb16a9099",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "17ab550a-68a1-728d-c3c0-64c7bc72f3fe",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1828a070-068b-a95d-05bd-97d1aa5306cf",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "18293f33-cf24-6dd0-fea8-750eb629c0de",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "193842d1-67f8-7b4a-04d4-8ad3f57b6cb5",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1938cefe-5dda-eac2-4a89-86d4cc2bbb41",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "19861494-33f0-13d8-932c-2acfcf2fa18c",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1991eb73-cae3-7444-3c1a-3d87acba57be",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "19f2fad4-a69b-5816-5671-7dca8e1f05c3",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "19f8d59a-321f-7873-3ea4-4c981946832d",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1ad7828c-e3fc-0069-ba6d-6413bb488575",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1aeee50c-ccc4-bda1-52a4-8d413ffe2055",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b0c902d-ad55-90ab-57d4-16427ad6c740",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b1697a9-3a2d-fc57-4a13-6eb57d67f819",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b18563a-1928-a0b5-9eda-0ef8fb473839",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b37d5da-f4b6-cbc0-bbc2-8fee0570e9fb",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b469f60-28a6-bd81-827d-cb90da561d66",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b80b598-780b-bea4-5a24-19940d4a38e1",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b84325f-12c9-a783-29b9-032c0e6283aa",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1bbc66ba-4b6b-7bf9-811a-aa8003d6db9c",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1c4cacfb-dee9-07de-5cbc-d5ab91b33773",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1c9c63bf-825c-13f7-fa0e-9f0699f61ecb",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1cd5ed06-8055-c77f-14d6-607ba085772a",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1d041991-5f0e-c23a-8999-aa6d5e5cec41",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1d551b56-0c89-92ea-bc4f-58b3b9bad9dc",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1d78c887-7aa6-132d-0217-f7b43b77bdf8",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e1026b2-758a-9beb-93e2-fcf2b936ed82",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e356af5-9fbd-d306-bbc5-eea3d0b204ad",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e3e3715-aa40-0575-a36e-ef450c9b5da9",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e5eea31-29c3-bc5d-2667-842eff3b544c",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e6bec97-4c0e-5908-667d-688e7511f7c4",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e95312c-bb54-5051-1d8b-87fa3be05371",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1edd5504-cbdd-721e-c3f8-b14406688ec9",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1ef93c61-327d-3b0f-db94-04acd6213a5f",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1f060a0e-833b-9361-4a59-0ffc6ca53af2",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1f0d2ada-0af7-a1a9-d34f-e43e47f0979e",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1f87bcd1-4567-9f7a-a2c7-c8251419643f",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1f8a6626-6c38-0826-4f7a-1fe34136607b",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1fb7b886-b13d-200f-7df6-7ebda0de9ccc",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1fd5f3c7-4c47-19c4-61f0-665a537bec8a",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1fef362a-d1da-0a5a-84f5-8ae89094daf4",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "203aa879-6750-f0f8-e036-86cdd107e764",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "20bc4068-6c4b-48cf-0ba4-b953363e5612",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "20ce0656-3d5a-66ab-6bc6-0e90ad09655b",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "21ba83f0-c8cf-756e-d382-667683820599",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "223a8207-25d6-87ed-d8df-1f94d1643ea6",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "22c1caa2-aa3b-3e37-6efb-8fb7c07f54ca",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2310c342-bed5-4b9f-eba2-02e50ce02e57",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "235b3715-edf8-71b1-9850-c2f6c754d99d",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "23a6ab3d-60bd-4148-2d32-cd648026c5e8",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "23e9499b-6128-466d-0897-a5ce91f4b27f",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "242b487a-a475-5d9e-2a03-0165d13def70",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "24716457-7da0-153f-e697-5e69fd4f68a5",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "247dc0f6-eef0-6e27-4369-628fd9529420",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "248bcdbe-1d25-60a0-8656-ea43b2f22920",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "249c0eaa-9905-1383-8fca-affda7f85f7b",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "24b13c0b-cd96-240d-8ff3-07cf4869adf6",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "24bcccd5-f382-001f-3b8b-a41142e49777",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2592466e-b4d4-4655-9eb3-6de7071ccf75",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2593023d-cd4b-3a13-8456-8605799c009b",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2599f89e-0977-b58a-0539-f65697c1c75f",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "25ca8467-94d9-d697-0db9-bb34a8898197",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "25de3c2e-a93d-53f8-6982-c678ad47cc54",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2605d9e6-c136-20c8-1831-a1f1ffd05ec7",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "26e71ee0-59e5-f793-1413-af5ba2a87427",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "270e2f52-215b-943b-b615-1e38fb4c7556",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "27157c99-c60c-e69d-0cf7-6d49797717a7",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "27347831-35fb-67fa-ab30-fe2735abbbd8",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "27716c75-581a-0d58-d5ab-87df37bf11e8",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "288acd27-59ec-b9f5-160f-bf6e569dbf73",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "289a7bd2-5839-a841-3c7a-6cd2cb327c1f",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "28b5dbc2-f5fe-d1df-1276-f0264e5fc36d",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "28cc2966-659a-7c43-550d-d3e856e6eb75",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "29b71050-1d78-d4d7-0445-b899e17f1db0",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "29f09856-4a06-7009-67f4-1b47f3735322",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2a77192f-3516-2af5-1c2f-efb27ff44dff",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2a81166d-6b54-e987-5809-652afadd1182",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2adde9fd-954c-932b-bf95-c574715ee59d",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b072eec-8afc-2975-cf37-acd3112a3d9b",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b1ce470-481f-5868-f4ac-26e876e4d79b",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b31955f-a738-1fa4-4987-be8592ce1b8a",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b44db07-ee64-2813-e9fa-ce30cebaf996",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b487ea0-27ba-1111-671a-8ccb8a808f19",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b56efe3-8b66-93ad-54b4-f5517a0c3cb5",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b9b9d22-41a9-95c7-6b24-f4c5298461af",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2bac5ce4-8231-3998-2ea3-87b0bde58d1e",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2bb47397-839a-9256-9cb2-7ca19bbe6f6d",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2bc5029e-ee0a-db1a-2963-e27f328bac06",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2be3fbb7-603a-37b8-9886-8cc179a60c00",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2c5e7c40-eda0-861b-ff60-079cbd28d62b",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2cac977d-cbd4-6830-a4c6-2736101a2a7d",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2ccff467-3ffe-b229-11db-213c0682008f",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2cdc1759-9120-bd86-70c9-29940340600c",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2d665373-ba63-11d2-7115-31a5237bae96",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2d9a3c10-b1dd-f004-0f69-2e3a4bae5c5c",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2db3f185-97dd-9f4e-3813-f595191b3ef8",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2dd686c2-90fb-215c-484b-6abf33d7f0f2",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2ef053bb-a426-74eb-6498-47e542671a5a",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2faf2f20-145f-cd9c-fcfd-afbf11172030",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "301879b0-e7b7-d685-5fdd-159039ab1c6e",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "30cfbc43-c39f-1c34-2f9b-6d3ba13b0491",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "30ee3b1a-608c-9029-ef9d-8dd126d7f341",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "310d584e-ee15-57c7-df8f-f1c01f89f816",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3149b3f4-1518-8b57-abdb-7e08d36f7861",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "31684066-8ff8-ec8d-d574-7994a009b471",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3177b094-26b1-b068-a92e-12b1ea020c51",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3188ef65-4dde-15ad-a99a-83fd6b6c05a2",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3211d60a-a2cc-4aae-e597-0618dc72fd91",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "323b5584-bd42-9b8b-ca3b-7683360e02ad",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "32508cd9-8a12-0bba-b62b-aa26d542bf43",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "325dbc6b-3915-11ff-5664-566a43aedcce",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "32b099e1-a3d1-4e0f-9e32-56ec913b08fa",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "32e0e5ec-8a8e-9958-11b8-3e1fdf2c9022",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3314a49f-fc9c-d196-f080-0c1e65a5a038",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33312525-f896-88de-5e90-c76df14354c5",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "333a9e97-7b22-78cf-a2aa-054acbed29d6",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33629096-47e0-4ae4-df4f-b9b15bb01a06",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "338ef414-55b6-57f8-6cbe-eba50b6858da",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33efd6cb-b6fa-3383-51f3-b5ce1564e043",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33f0f8bf-b751-8c08-8a5b-e17c5202ed70",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33f920d8-24ba-7fe2-fbe5-526c65aa2bdd",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33ff2701-91f8-d78b-7a7d-2e8699300904",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "340655f6-6a9a-041d-d548-9f80b12ee00b",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "343485f2-93dc-aaa9-691f-56d436492103",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "34589856-41ec-1fe4-bead-01c2aabcc0be",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3466fafe-c40d-640d-c381-e20bff70199d",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3467ad0e-4caa-a9d4-ebe6-b07c78d758be",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "34dcfbf0-bd44-0123-ea20-2bd73d504f1a",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "354a73fb-281a-99ef-71f4-9ad6a1e08a4c",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35769633-5a71-b8f5-cd23-34959e70feef",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35adacf1-d9c3-d92e-2f59-fd496b6a14db",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35e71e41-a081-6192-0f17-52d5393f92b5",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35e80a17-a920-4848-28dc-7e49a1b1d450",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35e93169-58a9-c08d-87f1-0d1c042b0251",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3617723f-5fa3-13c5-747b-af12024e1739",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "362f0228-aba7-6c24-8de6-b0f8e8f0fca2",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "363f0139-5ea9-5659-b4b6-d31f10c6e1f9",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "36be623a-fb8e-cd56-cde4-c36170c3cf97",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "36cb5434-204a-2ad5-b1cf-9a6bd9ba6770",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "36d84ce4-f349-afc4-6458-0cf8242cb742",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "36e83abd-b95b-2bff-8076-d432a0d126c1",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "376435b2-4f87-d45c-9d3b-0f1a7fe26993",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "37911dff-a5ea-8f4b-e8d4-4de521d88fab",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "37b5538d-83d9-db1e-c957-873f1f52b8e1",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "384a335b-ead6-a595-1afa-792fa5f1d8fa",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "397f99a4-3024-f200-35b2-f51bb3d1cf79",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "399b3fe0-a8db-f30b-561a-3eb2fa5d587a",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3a0dc032-1305-74fb-e0eb-b5d26843dce0",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3a184df7-7d52-f9c0-8fcf-d65d15495f27",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3a67330d-23e1-7ead-b469-1adf44300612",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3aa7cd04-b4c2-cc6f-b69c-a73c4dc31b69",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3ab9aedd-197d-0954-7869-508b7381ec26",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3acb1297-0683-abbf-a79d-69f0b1ad4148",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3acd0cbf-4f81-b141-b5a4-1deadee54db7",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3ad232de-dead-1de3-4ef2-1a7a1bcae815",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3adb884d-00f4-7452-b153-172589985de0",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3b42cda1-04cd-5377-70ca-5f9c09522015",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3bd48e65-a546-53b8-11be-9168f9315439",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c122b19-bfc4-fb31-c031-d4b1358f661b",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c384aff-7c16-316e-ecdf-de092cb63839",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c4db87f-2c67-8431-5028-cc295a2e3087",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c5a71ba-2254-b3ed-67ec-f64c0106c660",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c94d190-986e-a736-87ca-6787d693212a",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3da16659-e34c-a32c-0e88-f464e813b606",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3daa9c94-3bcc-6c93-feb2-3993755d253c",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3eb203dd-c874-2718-a2a0-3fc6a3d7ceb8",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3eb63cdb-d52f-72b1-555a-1bc3287a6e99",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3f839a52-c325-f2fb-b74a-c0f31808b557",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3f9e18bc-c609-f0d0-483b-5f0556b93e84",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3fabeb71-515f-89d9-ecf0-4d6b037af7ae",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3fd7aae0-706d-4df7-780b-8c5cfcb6ab66",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3fdd2de5-bb97-965d-f358-ec57017062f4",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "40117d71-595a-6295-3368-573796c9d3d0",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "40137d15-bd16-30bb-80eb-aaabd3357137",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "407db42d-79bc-62a6-64fb-a6ab14427749",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "40ced4d1-1d5f-05f9-1ecc-008ece9bf6cf",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "40e36724-7177-87ba-60aa-341036c6b39b",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "412ef48d-01be-55ef-5ebb-4a78431136ee",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4130b3b8-0f16-7f94-ecb6-b80ac3484799",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "41423551-0d9c-1b89-9f3c-278ac6132d5d",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "41642e34-9703-f9d5-55bd-7ac4c5079cd9",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "42046a6e-e4b1-6bd2-f0ac-7fab8592bd81",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "42106e06-e42c-bd1e-46a0-67b8b2b6e778",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "425b45c5-3bf2-b3cc-a8fd-011c300c5b6b",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "42731d85-ee9c-0bcb-db2a-ad4c0139f1c8",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "42c4e64b-5f37-7428-68d0-ae73dd07c550",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "43218475-c208-8bef-45bb-cead9439d8b2",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "43370ead-9fca-c16d-cee6-46c82788d337",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4348c7b6-2fba-b089-89ea-ad326215028e",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "43dba54c-ac20-eaf1-aa78-e5651b270a61",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "44800357-71fc-c57d-1016-c7b84070e5c2",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "44aaf7b1-791f-8f82-c0da-7ebb41fd7242",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "453afb2c-a5b5-3cf4-f188-1fa95fc15824",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4557c67c-df81-999d-af4c-0c484bf21983",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45677706-dac8-31fd-82ca-b5df09b381cb",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45af8d84-cfe9-7ed6-18a6-0d89016bac6d",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45ddd76f-2146-20dd-4044-b056b0e89930",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45ef5fb7-f21c-293d-6e77-44f359cf722d",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45f1ab9e-4cf6-ec9c-2b17-9c7adc6a6cc6",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4655bd8a-abe0-ed09-0f95-f22d7f8c4bfb",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "47a84f5f-69f6-8c41-882a-0fff04c088e1",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4800826f-b48f-aadb-b458-46bac3bc0611",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4861c780-d273-deea-e35d-cf133bd5d84b",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "489eb465-3148-2790-459d-d37743bc1fc9",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "48bf7f82-1ca6-e351-83a6-20588e74f9d9",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "48dee733-5e65-095e-5b98-ad2f3413f250",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "48f9091e-884f-1bab-5878-b6544c8c0ca7",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4903fa5b-de46-5fc6-a28e-0f0cd0ba7c7d",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "490f3cf5-28f8-dece-4922-52671fb4a199",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4950a765-76b9-83b3-7de9-af0e949338d0",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "49a1f7aa-8859-4cc4-b546-4549f789bf3f",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "49cbfa48-c9a4-d8f0-1a8a-1191d3b61d23",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "49ecaafc-2f2f-0847-81e7-c35e1457f586",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4a0b0ab1-e8fd-2434-c11b-1eaeb07577de",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4a1350c1-b7cd-0abf-d114-716504b16a7c",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4a9e4b89-4361-e36c-5dbd-676385437cbf",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4acd9232-d4af-fc54-d001-272120ba0f3e",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4af77d70-a98f-9201-b485-970850a53a5c",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4aff05b1-2e8c-eb11-a7d0-dc28213597fa",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4b064eb6-10c3-39c3-883d-0424a8ea810b",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4b3fa2e9-13d6-815a-1991-3379fa24d213",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4bb433c3-a8fa-e9a9-f04d-6d14ec42d99e",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4c06ca35-0b79-9303-ec17-10272993b89d",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4c6b6e9f-a614-de54-097f-4c095f09b343",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4c74eddf-31df-3d9c-e01a-935aab29f802",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4c7ef4e4-6089-5b54-70cf-462a7594d3eb",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4caafe08-88b8-f527-d617-30c43c95947c",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4cce25cb-d6a8-8892-ccc2-05059e6a6f16",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4cd5f36a-93f7-1b54-cabe-8128f0dfd674",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4d46411f-dba7-37ac-8814-c7da719f6e3b",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4d6e2979-5e0f-7179-fc23-21591767c6a0",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4d9df844-c4f0-ce33-a95f-e2649dbd9854",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4dd2b11e-e285-eba7-7e11-217a1f1a5016",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4dfa6633-4102-2dee-0768-2c3ef94f351a",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4e6ad58e-34f9-3aad-d394-6c22e98c28e6",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4f1f9725-101c-80f7-d008-fcc9271993df",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4f38e6b1-dfdf-7780-0780-cb4f8418ae41",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4f96e085-90db-e38e-531a-45f6abfbd4b5",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50278dc0-3ccf-66c5-6639-d8cf2c3a45c3",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50385077-0e40-cb7c-79ec-81004f9f179d",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50a492c3-36be-2556-07f7-c1fda62c78c4",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50a9ba02-e020-16d3-df51-fb9c4b19bd0c",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50f1a91d-4f22-2c4d-0480-c8e86f8ab6ba",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5119b0f0-763d-45e9-dabe-2e015463004e",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "517524cf-4d05-9889-8a60-d07b7a0f367e",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "517d614e-6c9e-a398-06b0-84ea43f5fbb1",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52255222-934c-c40d-8d7f-7c438999b75b",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52337c23-7694-cbf4-76c9-3dd7f121c476",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52659ecb-a874-76cd-e727-9e93c72dd9e6",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "528cf0ef-0ad8-1440-1a6a-d89ca66b78ef",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52c0092b-3071-650e-6b40-8244f7ac1aef",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52d399ad-652e-4ce7-48e7-3fa9dd24c080",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52fbee5e-6035-a389-1fd4-f2baa360ea71",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "53238bae-d873-e113-c07b-94f7384f2a4e",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "532a40a7-77e5-d8ad-e9d1-5ac05b8f1fb5",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "535ed2b9-1619-fa69-a7d6-d003ca7cc32d",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "53bed5c3-f54e-2f3b-5ffb-c3d75fdef22e",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "54525cf0-f107-52d9-4701-d3383da2ebd4",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "551de7b1-1efb-00d3-f4ff-d63b63ca6e0d",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "55803d94-5a30-5537-708f-9a29af0bb608",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5582813a-cf75-d0bc-d6ea-164333b8f078",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "55c095c0-7bb3-4b1a-b7da-0ed8c7aae43d",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "55db5c7b-8e15-4375-cc5d-227a06438d38",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5614c18a-417b-4621-5dd4-a17203b6fd57",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "564788db-7533-ad1d-c822-688c966ea182",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "565b9687-a776-3cef-8994-bc338c6f1895",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "573e2677-41f8-31b7-9951-eb1100b2132b",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "57ab359d-3846-c2bb-ed46-058d12813eb3",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "57be9b47-7cba-8ebb-640f-e274971152ab",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5826bd17-eeda-6222-b4d0-8506d1ea4f1e",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "58a7df68-456d-7aa3-efad-177a80a25161",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "58ee5b4f-5255-02ce-b2d5-07a5c8ca7673",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "58f82817-6b56-5845-ddcd-66f0bd8d2507",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5928a75b-88dd-4a5d-ca54-6d5bfaeab6bc",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5949817d-4426-d92c-eda5-7bc93010d7e7",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "594df6b5-390a-e031-8c8f-ec7beecf5380",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5957a8bc-301f-1380-2254-00291df2e665",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "597d6d71-d02d-d972-6906-47dd94af9989",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "59c71829-01cb-a709-8f65-a8cf0f64dc53",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5a62f7f4-969e-0b36-2084-91de9f91eb34",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5ad840f7-830d-9cc3-11cd-89d244507f8e",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5ae81cf8-1483-9145-cede-a1d072e27dfd",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5afcde0e-518b-b54d-5cbc-9d0ee6d09abc",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b05b08e-6f73-e22a-e582-c0117147df20",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b638516-0759-9513-853d-bbb34b652783",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b97e945-8f27-29fd-ec32-62918c44a2a1",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5bd1054f-c06a-0ff4-2abd-fa8f91162e23",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5bd766de-0af8-d57c-839b-1f71e24d41df",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c070507-4cfc-7437-9688-8a3fa0311229",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c094776-5acf-2f84-62b1-e51885ebdbbd",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c0ab620-2b3b-61a8-a149-bf9a95ed8c03",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c440b1b-c528-b1b7-ea36-c8c51c52f6a9",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c67d3c5-f64b-9042-df1c-37f8122fe8e8",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5cb76838-2148-bb64-3c35-e732e56238c5",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5d8585f7-072c-3acc-02d3-036830d0eb38",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5dcdfe18-06f9-b671-59c0-c7e656362b2c",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5de5e483-bf65-3751-6439-ad5bc91a890e",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5e21308f-4214-8f32-e85e-871599e6ea4f",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5e5deff5-dce3-e6a2-8a29-aac24511322b",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5e723d74-3882-b8f0-da81-d00da0032a50",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5ed13f71-f910-0a19-70e6-0faab831b589",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5ed55ffa-6d07-4409-9736-539634c6519e",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5f1cbb5b-c8cc-7cb9-7692-cfff312ba139",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5f1d392b-0667-4d12-0a56-37baeeb0c07e",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5fe273b4-6a9f-14d0-d400-f08ffd526565",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "60262794-ee53-dba4-eb1b-246ed566d3fd",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "60472859-d8c8-a48d-4c3f-0ac18643491a",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "605d659e-d34f-bd06-e1d2-4bbf5318d9a1",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "615d8d49-decb-4eff-c9c9-de1e24273327",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "619c84fd-6150-21b7-bd5f-a666274bf036",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61a2c1d3-96fb-71aa-55cf-33c674680627",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61a67da9-b7bd-4555-9cf8-c6341152be1e",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61aa8a00-ffc8-ba2a-7999-86e7ab9329be",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61da36ee-00e0-0352-ec61-5f9548d15e87",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "628d5b85-fb1d-3be2-1666-dd4ae4465c58",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "62938ab1-4fd0-e0fb-b4db-53f0c3b577bd",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "62fdcdb2-318a-1eaa-c2de-ed7d5eb26b05",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "631019a5-52aa-5f92-b516-9f02ab27fd0e",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6310db55-a6fe-ae83-48e1-fc37011d4eee",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6344f8e3-c5ea-1555-cbac-9e3b7119042d",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "636bc089-f22c-d241-d427-55e90deab83f",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6381a78c-fcd6-d0a1-c4f5-09323d5ec98c",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "63c687a3-67c0-9d3e-4bda-fc7d26ed4e96",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "63d0e165-8c30-09b2-576d-a0517c4317d8",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6421d373-2d22-5d19-eadb-7e134fb1514e",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "64232e02-58b1-49f9-ed14-4ed2bc2cca29",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6430ecc4-8bfd-8a62-c7ff-1a819c81ab12",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "64890546-473f-78ec-18bf-42d299263657",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "649dd080-3292-2b16-97b7-60ecd19a904a",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "64a414ca-6f58-a78e-c856-aba5693b7f85",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "64ae45c7-d78f-ee6d-73c9-f4f9332e8811",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "650b7207-a5d4-bd7d-fe95-4a204c5e1f01",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "65112f17-919e-e28a-43e8-66e00db57053",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "657a5804-95d2-bbc9-e3a8-cb27991a4ff7",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "659905ce-facb-f42b-f4d6-ecd3d6706d97",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "659b5c09-04de-fbc5-5d98-c280c5e543fb",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "65e2490c-565c-d5f9-ec8e-2a2b48a9c11e",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6634a192-1867-c0b7-3d6a-f40e9451b92c",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "66fa9dea-3125-099e-2915-800b6c650d6a",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "67ace8f4-0f30-1cd2-b6ca-071e23ec2cba",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "67b95201-3952-6712-2715-889888ee7c95",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "68043ff2-95b0-99fe-0120-ed51205672e6",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "68197b26-afb3-63db-fdc3-8ab2d84279f9",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "68b4d308-be73-447a-aa01-94326f1d8573",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "691660f9-12b9-5e11-9261-206ceacd9e36",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "691e9c06-10d6-afd3-febd-fe572554fe00",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "698fabe1-43b4-9c65-86f3-65500666149f",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a26bb2b-10b3-d20b-576c-06ec7eb6881c",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a312723-378f-452f-ccee-cc8c2ce7a27a",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a3a2ef3-ae9a-b881-f025-d9d175543545",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a4b6dc5-d135-c9c8-6a3f-fd8e21e92ecf",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6aaafb5e-3b19-91f7-797c-e91862088611",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6ab02906-d2b9-2266-4136-3128f38d5164",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6afd119d-e28e-92e8-9e89-1af6996f754c",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6bfdf32c-e8fe-bdea-51c7-38c5b5992127",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6c176ab9-ca29-361a-d27f-4b7f010acd63",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6c37f867-5e6f-aba4-91b9-2db24521f2f7",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6c73b437-0d0e-1091-b034-f182d80f695a",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6ce3d657-e3d0-f6f4-b29a-e5144ca560bb",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d007abb-5e1b-17af-b0f7-2c47514aa643",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d35848e-614b-c210-ba42-5c08c34d2f65",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d5a8c03-1246-423a-3765-15c893dd78d0",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d5ab6db-8f30-6091-2cd9-ea7f969fcbff",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d69d35f-822f-3f97-7cb7-b3d3e83a8517",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d8a71bd-3b1b-2819-0f1c-7c6f1615f245",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d939689-22dd-f3e4-a21a-3c69ccfbf67b",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6db8b590-545c-5247-9e1a-c51a90a3b619",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6dd43e6c-86b7-54bf-9bdb-5e5ea47a9faa",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e049a5b-951d-3381-65f9-bc0fb565cf54",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e46aee9-cbc0-b0ce-c256-31361c943394",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e67b748-ff2b-dba8-5308-a0b92b14a1b8",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e7e7ad1-76f0-2a98-4e52-aad698b8c7ad",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e9db836-8335-157d-2b66-184effda711e",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6eab02e7-1426-0881-1c74-99cbe1c2dabd",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6eeab54d-48f6-9f68-1ca3-b7ed0c89b7cc",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6eefda18-8285-6969-b21e-451d7bd76697",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6f1680fa-747d-53dc-d2ab-105243a1b1cb",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6f3d10e1-f4dc-ca79-50d4-821d2875c8ad",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6f546c47-26f1-7ec9-b641-fc447770b8d5",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6fb07aea-339c-0332-ca91-4987f543bf5b",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6fd6173d-eb18-e8d7-405c-66721548558e",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6fee2eeb-59d2-0c00-9a1e-8a30811ae17f",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "702ad6f4-0053-c792-b343-3b85849c4fdf",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "704c020a-6dcb-018e-ce54-64db11060b68",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "706afcff-0cdb-6977-d5d9-770b0d8252dd",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7094d547-fd86-a3c5-b337-839b1e5c317d",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "70ee2824-090e-3fe4-2794-10f0c7f3f893",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "70f7cb1f-f577-22e4-c388-755432d785ca",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "70fb017b-27b3-32f4-e15b-031807d3041f",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7114d482-e272-ec02-9e73-d02be9daad85",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "718c2d6c-578e-b7c9-1e8d-5bc67c063ea5",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "71f57d4d-faa9-0cc6-82c1-fd3dd9f6c1c7",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "72266131-6cd1-0f73-3a4d-fb15c51f80a2",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "72a781ee-c6f9-c7a3-a6bb-dd39961e522e",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "733a7970-863f-19e0-960b-550ffd7ebfb6",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "73532c4d-af3e-83d4-8425-4cc26ab37aba",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7354251b-296b-caf2-433f-8b6ba2905cbc",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "73aa21b6-6e89-d724-606a-ff4a561441d6",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "73b44f51-5601-290c-5594-135cc98de227",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "73c7563d-39e9-4606-310e-2e3e31c378c6",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "73ef9028-ebb9-10e0-b568-0ab21799c6da",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7418f241-6776-9e6d-a053-48ac126562e8",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "74547088-2cd4-0ff4-8bff-433423e5485a",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "74775c4f-426a-3783-b04f-ccac0b514278",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "749b811e-fb13-4288-9280-1a0ac6ae1357",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "74ace139-e992-d91f-4671-52f639972753",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "75a4e70d-830c-2c84-3356-f012e00406b8",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "75d76d46-7571-e18b-fd80-49ee8d62880c",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7600bbe0-0a15-349a-b9ec-c475880ecfda",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "764f2bb3-6cc5-14e4-6520-336d80427992",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "765a6d8c-c0fe-7187-2aa2-2346375627a4",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "767d2088-ae6e-01a3-af51-1f15e4010867",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "76c7b55e-03e5-9b52-34d3-5a7ffb9c90b6",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7755d2e0-e594-43f6-6b2a-97e09a800704",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77584882-18b2-c070-5e41-8b0e717367db",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77a22aa9-21ba-43c1-f6c1-a77408c21ec3",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77c5543b-1580-7852-0a87-da9c7abcbbbd",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77d7f16d-5ae4-b603-5a85-8890f1777158",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77d8f4d1-c71b-c484-866c-ad2bbcee8d58",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77f874fa-2a1f-f514-bfce-3249bea7bc6d",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7808c1db-a570-ab1d-bbf9-a18cb5faa033",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "780e8022-e459-3d7f-a36b-47992b26ace5",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7872c32e-8849-26d9-8279-dae0014cea81",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "788469c6-d6ea-88f6-9d4d-2e8a0b8595cf",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "789d8ffd-898f-2aaf-f340-7783135e9a27",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "78aaeff9-5997-2b9e-dfff-14892277163a",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "78ecaeff-34c8-c97c-b69b-0c6690b4a848",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "790b09e5-5227-33d7-cef6-21f1a8781425",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "790b2537-789c-2d30-aa17-fddb3dcc7e87",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7978f9e1-f848-3ea6-bd32-b7ed5c2ba948",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "798ddc1c-e359-941e-9460-c187af5e53f8",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "79a2515b-c784-5fe3-20cb-1548b67dc9d2",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "79c2c8a5-b015-8ddf-6df6-251e26904dd1",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "79e9a30f-cfe9-2f9d-cac4-f86e3962d70b",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7a234537-baf1-3524-b7d5-0e086755bc47",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7a29af3a-374b-0d68-6adc-9c128bf68f2c",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7aa3c75d-1047-67fb-2ace-ac1a1a10d694",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7af052a9-7122-b61f-8b11-5da686e42f4e",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7b197240-8dc4-4b9a-bffc-03041ba80ac3",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7b4684bc-9aaa-ec77-cfca-3e170f437cd5",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7b74c4aa-8c1c-1d43-85aa-3121fe4fe06a",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7b8b3263-39e1-5145-8a7c-922bed22cd08",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7bccd9ff-6129-4373-38f5-54b69ffa2532",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7bcf80e6-7fe2-ee24-8917-ba84ceac6c5a",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7bf67481-3314-0261-b2db-78df2fd64956",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7c202e76-1853-732e-dcdc-f6e289162c30",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7c49616d-c28b-639c-b997-9247505f7659",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7c99bc64-53c3-b876-5543-b8721c0c8a16",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7ce29b8b-2433-0bb3-0654-d50cd8f1c886",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7cfb27d0-bb0c-81fc-f02b-7413a98009de",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7d00f71a-6a3c-8b68-5e9c-fcde4ffa7c54",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7d2fcf3c-c09c-4be8-846f-685bc9a41b10",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7d8f0718-91c6-2cab-268a-090d429358b3",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7d9ad1c8-2f22-2da1-d373-f6781481e17c",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7defdd5c-80d9-8643-cc16-c5adc0cc4c1b",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7e4c29f7-67f4-b4c5-da5c-c943f154140f",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7e81993e-6a54-b9ca-8ca1-a5dce75296d9",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7ed7d5ba-b85a-94dc-e41a-951452adfd76",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7ee8ecf2-a327-72a4-39a3-f550b848e994",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7efbbcae-7986-422f-1648-599c8cfe7a32",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7f73fc92-af72-477b-9c37-49b6779a08db",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7faf4a2b-6a73-9282-20ba-8a3719341d59",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7ff81ee8-300d-ddc6-319d-7dfa7218fd58",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "80c3af1f-291c-f372-0d38-df362469d385",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "80f54d52-7c1f-5ff2-d278-d08cb6fbe663",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "812aabb2-c7f8-2548-e7b2-c7c99cfa0b51",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8158f792-971e-e8e6-ba64-89beee817448",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "81a26782-c24b-32fc-fb34-09efe90725d6",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "82854779-bd50-0aaa-177b-dbe72002170a",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "82a38202-4f6b-41d9-11fc-0c59d2bdb4a2",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "83518af5-9c7e-aad5-b0fb-0d174cb1a74e",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8364106c-5f3a-598b-2ac0-3ed214205fef",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8390a9f6-0a93-19fe-59e1-f9f55f5ddd6c",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "83a735ff-5494-6d25-e97e-1be7ce62985c",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "842306fb-458c-d097-eed8-909990df3d1b",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "844e7674-593d-adb3-1440-7f2a1fab57a4",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "849b1616-601b-3dd9-557b-16d80403b1dc",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "852e46ab-b00f-8054-4ee1-5649cb845174",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "856171a7-b9ac-4830-b2d8-9cee3fdcade6",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "857d4bd4-f8b9-a253-5f74-06ed5783b8cc",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "85e1b30b-426b-ad04-17fe-fc152cee3378",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "85e9cab9-5ab3-16a3-f659-b25df501f9b6",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "86096d2d-028a-2178-b93d-d09c58fb798a",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "873dd793-925b-cf55-c4ed-19f5ea134c5e",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8766a212-9831-5865-4645-404c346353e0",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "87a71430-351f-537e-026b-c5b519494fd1",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "87e48982-f0da-a5f3-0b94-9ea581b65f84",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "882637b6-a3e0-c6f0-5adc-323fbaf06469",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "882e9f04-341b-9074-4919-525657521655",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "88e3cad7-af87-576b-bb83-de3ae351486f",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "89236d18-091b-053a-c75b-c954fd17ee0b",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "895409e2-f453-7a65-bb3d-25c0b35987f2",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "895ad2cb-c1d9-f871-0b4f-6d588817d0a2",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8976f83c-4baf-c2f0-376f-a1e360cd7ef0",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "89af6c7f-eb9b-700a-1edf-c780be219657",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8a1b0119-fe28-9d70-3d44-4f08f1cc15dc",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8a6cc122-2f10-d00a-54f5-d2ac0bc48657",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8aa6d384-bddc-d1af-b54c-f4cbd87e1b21",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8b4e0e39-d22a-6b9e-f265-f1e56b32a5ac",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8bd34289-d07c-921a-c6cd-bb4b146fdcc3",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8c563a6c-a539-9b23-d004-3a0ef5546057",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8c6aca27-a8a8-0c0f-1002-e52f6eb2561b",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8c8d06a6-6fdd-1dc7-20a0-b47fab0ab94a",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8cabb15c-08a5-3226-7620-6b7fd82c0ec5",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8cc8c34e-a72a-148b-03b0-f8ee5fd74ca2",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8d189383-f0b2-811e-27a7-413d45d77bc7",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8d236de0-d974-e10a-d60c-6eb6d6ee45ba",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8d39f934-18e4-6144-1d94-ded1104d046b",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8da9b865-ec75-e977-9c4c-609e2b0b4bbd",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e09b870-6631-2b58-4357-c8e2715354f3",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e209ba0-d4c5-1bc4-1217-b046044b7cbd",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e772a62-3558-8178-332b-ef9bf71b93f9",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e7a8865-e1aa-c65a-3f83-fb8382e84b73",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e9adcb0-97f0-f605-d063-0d6f594f51ba",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8edbb040-f6b6-44c8-881c-6d2a3d8b7775",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8f187890-6338-7017-fcdb-cc73df76c12c",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8f6901a4-f5b5-e843-e991-5ecb27c6d119",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8fce3dc3-2a8b-c124-f96f-6798c213bfc8",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8ff68495-91b6-7636-684d-e74d8db1cef3",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8ff891c5-6be8-cf4d-c081-c3c877e21d1b",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8ffc693b-16b1-8101-db46-047a98051af7",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "90ef151a-2989-8953-bd19-90dd0821143c",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9142fa69-f76a-2c3c-9edf-e1ea105e8777",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "91484a1a-e66b-ea1c-e668-ebda717c8296",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "91e6ee14-7d3d-ee2a-2bde-63a3eb189429",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "91fc97eb-284d-bef1-4eaf-5747976f12d9",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "920e03ce-033c-892e-20e8-77ddbceea7f0",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "925fc124-3408-8dcd-0b80-2ad17a2218d2",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "931bb5b1-8d67-df23-2e78-3b0217c0f969",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "93214a61-c357-cf55-06ef-5783ca945672",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9343be38-6a9c-9597-308b-b7a380d3341a",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "935c4906-2965-0faa-073b-4831ee9f3c48",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9393cf6b-216f-c5f2-04d3-406717d50b39",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "93acaa36-b84a-93e3-4ab8-bee3839813c8",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "93d0406d-f2df-c05b-dac7-dec3c4a393cf",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9419d91c-fb6e-946f-bacf-338bbfb69b57",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "943d07bf-bcbe-a81e-c8d4-d99669e31e47",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "945a3a2c-b742-5cf0-08ae-46eb85a20a36",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "94979f01-8535-6f55-3aab-464911fb78c0",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9499db5d-73f2-29e0-6699-6fee9b30efcc",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "94d53d90-c40d-2c7b-5b09-1fc3733efdde",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "95280675-9478-c286-6e61-5eadb6e04ce7",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "95faa871-f826-133a-4557-00411db6d5e4",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9651c893-06d6-049d-48ea-4068fa9fe013",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "96accc97-fd14-14a7-0273-6fc98af06c35",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "96b1462d-19ec-a38c-05a7-8c261b7ce639",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "96b814eb-178a-5fe2-b4a6-eb71b6006fa1",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "96cf1edd-649d-c6e7-4f3f-63bb525f08b9",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "976eb95f-a41f-94a7-82e2-873bf9bfc785",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "97732f97-a471-d97e-a1c9-5f1e65501cb8",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9776757b-2364-91f1-48aa-936b7a307f23",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "977d8ebf-94c1-c3a2-81ce-59267542cbe8",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "978254e1-40d5-bc41-fd06-9909777893d6",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "978d0096-a189-7be1-55f4-a61ca61d2828",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "97fab13c-da56-de8c-5ef3-69bd1e7add0a",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "981623f7-68c2-156e-a5d8-a788517c404b",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98330ae1-f241-43dc-0ce5-867ab32eaa69",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "985812bb-b587-86fc-300c-964d20bb99fe",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98a3af77-666d-b843-1550-1654d066a91b",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98a8f4b6-5e8d-2f6c-8758-6666656e481a",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98f3fdc5-c2cd-f68b-96bd-732dd43c8529",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9929577e-537b-4402-8863-02367ce84100",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9971fa58-a988-4a0b-0bde-87bf140e6b77",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "99c374fa-121a-7538-fd9f-bf18f9ea5cf7",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9a12324c-a9b6-7e20-cdf2-3558d46754ca",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9a87aa15-1dd8-4cbb-afbc-52337f77c2ff",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9ad1b67e-6011-dbfc-53db-ddffab249a2d",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9aec3604-2382-813d-dbe0-e829167d4d03",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9af6f1ff-5c76-981f-16b1-cff0e00e7faa",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9b04b38a-df80-4890-3b63-b52fc684befc",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9b05b001-4131-ed42-634c-10196745c2d2",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9b3bd5a9-f7ad-eece-81d5-eb1e34b3e9cc",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9bb332c5-28e6-8114-a6ad-33361e1c176b",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9be5709b-502b-5fd9-98fc-1c1603a3dfc6",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9c811b0b-75ce-1d6f-75bc-1c02b0f27f3c",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9c845855-86f5-5a7c-6a9a-ab196a2fc168",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d09c449-338c-e3e8-fc9f-e17d64f8f16e",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d1207eb-453a-4a13-6571-c8cfdaa7475e",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d166c70-6599-8896-04d0-2e1ba4a2d6f1",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d2229a0-0c0a-04e6-50eb-b3326b957e75",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d3d2f6d-074a-0e8a-04a1-d64fad0a7ca5",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d3e3ff9-91de-1594-7dc2-e2f7a5061c3b",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9dcbb2e1-1288-8061-7552-95fc4a54127f",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9dd52fbd-e3a2-3778-9def-1607fcba8a14",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9e0619e1-68a6-7aa1-4f4e-dac1debb97f7",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9e3a1c36-c83f-de64-7a15-a427c2d53ea7",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9e55967e-b361-b475-1d74-2da173a313ab",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9eceb91a-7f9b-fbe9-d071-540a01948571",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9f1d52f5-5854-6344-7ee2-50b3aa2206aa",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9f4ba66e-d795-ba79-1eeb-aeaf122bb208",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9f916438-7378-7ef4-3477-18e3cddb2269",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9fb457e2-45bd-9c59-9632-dd2b36d435f2",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9fb4b466-3355-d007-8bb4-c2e7e89e162b",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9fbe4a5d-79e8-a1d5-96bf-b6ae2b148923",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a01d958e-0edf-8a1b-bc3e-145b9c05df56",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a0670202-2854-2e50-8de5-c40c09ce45d4",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a0923ee7-dc84-4fb7-e960-64ba86e14501",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a0f2d093-4ef8-8c6e-433d-875f5fae4ae6",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a1727d12-0880-697a-bcde-439c0a59fdd3",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a1dcbe22-1a98-b101-6d9d-6a1e43eecad5",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a1f1d7a7-bddb-23c9-a786-8be00afca275",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a1f48c0f-fc61-d167-ac87-a547004aa023",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a228ae2d-6872-3077-746d-e7caa9826050",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a2dc9424-44ed-80c3-e2bf-2fc537ce7c31",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a2e87a66-9129-c8b4-8f19-1a7b0003f9b4",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a2ebb53b-d53f-3243-6067-58d54306b7f3",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a2eca7c6-6ded-0447-2d46-a31b5047bfb9",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a37ff634-cd9b-ef97-1174-7895dac5142a",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a39e1659-d76f-b466-dcb4-6e403c08235e",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a41f5899-263a-2ba5-d89f-83fcb8615004",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a4637bf4-ac5f-fc18-4f21-5d6060423cac",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a495bac9-3238-682a-599e-35d35bd1036b",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a515b538-facb-a384-2fc0-09bd704b792b",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a59870d1-3aa1-1ffd-b0b0-5f0eef5f14e4",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5ad0348-d074-cc01-5380-d87b5fe5dc57",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5ba5432-532b-bdc1-4517-8f6657b06ccc",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a609799e-8e05-578f-a027-ff94df7272f6",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a641cfbd-2305-0897-a54f-d1a0e015567d",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6b88a34-bff2-5a6e-e081-eb70e4b95923",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6be719c-a6d5-4ec4-f3bc-079e2bc133f7",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6d90d38-fb40-67d3-9291-4dc9433685ab",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6df2aeb-dc33-065d-ecc9-bf2472024f34",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6e15963-ccee-056e-b08a-7b411a5faed5",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a7e8a312-e5ac-380e-64c0-58e134a0eb3a",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a8052858-a628-5c78-0ee5-886932034146",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a82312a1-29aa-9773-85f5-3a79b946447e",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a863f7db-1c08-8196-e4aa-bcf376564646",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a86586f4-63ee-788f-6c4b-375c8c07cc46",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a88474d9-7b40-75c4-103c-4756fefc5223",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a8f123f3-2c9d-cb4d-78c6-e2bb98db1086",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a9291ff8-90b2-be6e-9878-5cf2b98adf51",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a987acc4-6719-b547-a33c-941a36a8ac2d",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a9c039df-e5b6-5874-9c20-40b1c8c81a18",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa1b61b5-90b5-7fd4-8e47-7cc758c171b3",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa49daba-9688-5282-f7cd-bfe0c428aeeb",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa4ed2bf-8bc8-d627-2ea1-3ee37624ec07",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa4fa9c2-81bc-294d-cb27-c2b5b55fab2b",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa5e6d3e-6879-9a9d-240a-c4b8d59d977d",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa6a64b5-3b0b-91f4-304e-d1ed6e61b739",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa82c6fe-d9f7-88da-7fee-a67349427ee2",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa88e20b-3b6d-c95b-ee9e-10884cef9b2e",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aaa7c802-aa97-7cc2-008c-ddd99d2619b6",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aaf5124c-ec73-3718-9708-9cc8a153aa21",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aafbf12b-4fbf-f7ed-baff-ddb60852ded3",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ab988871-3db3-91fd-fdc6-c24dc63b2ff3",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ab9e93c1-9054-3de0-5468-8fef169e2733",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abc1a019-0ef7-cbc6-fcf3-2c8326df2fe4",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abc6b243-5588-2a14-659b-cd1c72698bf6",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abe48f70-3ab3-97c0-8f2d-1177d099731d",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abf10a27-3ac6-2e58-96f8-def34af99ffe",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abfa578c-1059-0e95-41fc-6b4a6cc5bd35",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac0253b9-9c01-e7da-03cf-d4e1caf7b942",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac1087ea-7cca-ba5d-4716-69ede045aac3",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac148527-f1ee-3bb8-7a18-397adfdb9684",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac61a898-07d6-ed31-0122-23756b48dd8b",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad086427-ad88-1b14-74dc-3c734d9f8fb0",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad3ad1fb-e09d-f4dc-0ea3-acb109796d53",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad51b75b-94ba-2db3-71d6-9937a00564df",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad71caea-fef3-33df-80d7-ea9d6752f176",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ae09acad-eb08-db70-af74-adc1671104e2",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ae34c999-ba3a-c1f3-e075-87b6f4725ded",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ae9de472-6ed6-c56b-17f8-0802b30e0ead",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "af3d7485-acdb-8cea-67a2-6784f57fb5af",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "afa4b9cb-8ae5-b1b6-05c9-c43ea90ecc50",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "afc81f01-6ce3-5947-ba22-725ebff80699",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "afcb9307-adeb-3d34-6fb9-8d01b5be2c0c",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b0bec8c1-1cef-e9a5-e823-63e2e2ab1135",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b0c8310c-b20f-5bc3-0552-639e3266a07d",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b138dcf7-c96a-95da-7950-ca0ebeca603b",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1a62097-cc7c-9e22-017f-ade4e5e982e1",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1a95a03-38ca-ee92-017c-5209fe2a86e6",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1ab77c6-75e2-be65-fd4d-2216d7df9169",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1c46032-68bc-da8b-5947-ff34f797a32a",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1de73bb-c73a-7b74-9abb-430fa0a812a0",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b2019509-d822-c669-e919-c21274fa48df",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b20737f2-721e-1d65-17b2-417ab128a58f",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b259425c-b08a-20ea-60cc-b695e91844b7",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b26a3004-88ee-88e6-1eb6-595becec2c64",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b383ee88-a3d4-9a92-14b8-4ad063d05858",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b3918eb5-f713-95f5-c1c0-7675b7e0b333",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b3a131b9-2c77-3894-f208-cb79d39faca2",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b3a8c3e6-2323-b55f-9c32-0b87693deb72",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b4099952-0caf-5f86-08f7-1c232720eb99",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b4d3824a-cc8b-bf10-4c1a-b8023aea893f",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b5308f06-151e-ee1d-d1d9-567a5c3df214",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b585a522-6b7d-2bde-80fe-59857d64cf59",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b5e54f3a-245f-7903-3b7d-8ef6772d70e7",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b626dd2e-0dd8-c1b3-7fde-7d858fef9eb3",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b646c1a0-6866-82ac-52d3-c26c028a197a",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b648d7d6-c04b-1683-2bcc-c8232f2c923a",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b6529d06-a4e4-da6f-c704-7b54408823c0",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b6835bb5-93f3-8590-0e25-4aff27981c88",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b69ab90b-0cb8-a678-d160-a4290766c7a2",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b6ca8d56-55ba-aa23-f316-c621e9fa525e",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b738fca4-5187-2cb8-fe64-bf110f27dc19",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b73fb90a-f41a-0c50-2dd7-6d2cda329ea9",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b7631fc1-9896-70c6-3e36-19135b902372",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b79bbe9d-8926-288f-0bdc-9007eb0b656c",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b7ae36e0-29fa-4028-0fd4-b1091ee273e1",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b7c2ed29-9ab4-253a-3902-2ea7f8883136",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b7c7c612-25de-0378-1236-e22ea28f2392",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b8335c2e-5946-1e3c-cb33-6a72acf2ab96",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b8e523c8-720d-5eba-96c4-ae0d83ad93f3",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b916b170-861c-b14f-ad0a-9b5bccd2c0ca",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b970a475-9dd6-744c-7ced-6d58019d3405",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b9740ffe-3edf-4783-e5ad-69012f24a391",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b9d4219c-8c1a-8d68-660a-7023a9845a4d",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ba235bd2-9ad8-ed2e-d547-fbd573117230",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ba37947b-1f2e-485d-f50c-42898aaa6e37",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bac11962-0b4b-4272-9fdc-b90833ccc3d9",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb2fb4ac-48e3-3274-181a-669eb9886be5",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb39bb03-38d6-cd02-b341-89e2a660da76",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb543979-51da-e0a4-508a-34e41cd9c765",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb5e6b6a-0c42-fdab-58c4-fef95fcdc49d",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bbd0e05f-b5c7-8e18-6176-871218610a2e",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bc03355c-95ff-090e-9a1c-0d49a206877f",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bc3ad3db-d8c5-02d3-d06e-5f94d53d9f78",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bca7d63d-cce4-43ac-f1ce-560fc47e3074",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd079d7b-b8ac-b648-0a0f-fa0d75c647d2",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd194d03-59f8-3e62-32e6-fe4f7a3b879b",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd2342ba-3dc5-ee86-3dfd-38ca414e3fca",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd26c6ec-d165-4279-e832-a0635cb9a1e5",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd3a37e9-fe59-1c15-b82a-aecb60558898",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd5c5e1b-5be8-03c6-a5e2-39063b12d65e",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd7b5900-f38f-a528-65ab-0f8b01b90cb2",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd85547f-e0ea-e2db-db8d-c415c58afb06",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bdd09408-1595-3d9e-9ba2-750a734e3f90",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "be411d6d-d6d1-2bba-cdad-e1e26eb2fe26",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "be61e608-afde-b945-5418-34c42cb5e6f4",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "be7e99bc-ba4d-f226-9d8f-03682d23bee1",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "be8499f8-c80d-6ecf-0314-d9a438061154",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bed021d1-ed16-adf0-c5b4-2953fa35048b",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bed3ffa9-e96c-f7e5-eb1b-e22f1ec71421",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bee84641-bdce-70e8-0ace-d087d9da4db5",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf02e8ed-6ab9-9191-d50a-9c05cf34fcef",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf1e2694-409a-773f-6c59-a05a8af0527f",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf51ec1a-fa3a-3c43-080e-494a6f7e3910",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf542d10-d3a3-6bc7-9bfc-b0462086ba9b",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf65da75-e34e-5685-f57a-537b8330d101",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf6fb6f0-aad6-0f75-373b-ab2ab4178d70",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bfbb1b2d-d452-df85-a892-80cd96cb1a40",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c0028500-4cdc-8005-bb90-ed6399529b3f",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c025d9b6-56e5-4289-89de-69f2f2d1d013",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c054a00b-472b-2614-aac5-8337913cbe70",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c0c452c8-6e09-202a-74cc-724212b93b85",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c105f40c-b412-3a64-e00a-cb1f14df7cd8",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c10a0baa-1e4b-54ba-5d59-5c584d8ae3ec",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c15c6cab-3590-2006-a628-67612870eb60",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c1e277d7-04c2-6cc6-1b93-4ff3c54ddb94",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c1e8cee8-7fa3-ab3e-3d0f-19a001c7da9e",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c2516a1f-5f3e-7e0f-7b86-9053846377c1",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c28daec1-e191-6f96-c9e0-cdf380630667",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c2d41dbc-aa10-040e-97a1-2860c38dbebb",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c300e4b1-5f24-736a-923e-7115fe5334bc",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c35fb6be-96f6-0788-f95f-8449add9c5b2",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c39afa7f-074f-a2f8-f8fc-90cc3e6a54ee",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c3dd11cd-08a8-d8d0-60c4-add26094c881",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c3f29e56-c774-c1c8-366d-35e9ddfc64be",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c437ad27-25ad-790e-ec14-e4cbb2c7d54f",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c470d37a-a616-4624-0e1b-a3d600ba3c08",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c49feb4a-a697-d42a-ade9-8a8f6028bbfc",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c4a2bdcd-3c48-1161-a825-b48ae0fb9ac3",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c4ad7e6d-a8dc-0bf8-e6a1-968fd7fdc033",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c4b97e73-7182-c9d9-9bf7-916db4bdf6b3",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c565c6ba-ecac-b786-5785-0744bdfcabc2",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c584e914-d15b-6c1e-b33b-e87707b1c8f0",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c5a0b44d-30ce-829b-93a7-716afe1e5163",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c65167ab-7aa0-3908-3e63-2698d06fa1b4",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c6653eba-2cc3-e374-c025-ae329ebbf8d8",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c68eb13d-eb1e-60a6-afc5-9de883024f84",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c6a456ad-719f-6857-0f33-b79bec3aec14",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c6e7c556-e76d-2b22-aced-041ba0d8cb09",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c754ff77-bd29-b62c-e3f4-7e929c78193d",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c757b477-07a8-d325-d4cf-a0a78e352f66",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c76ae261-cb00-12d7-5c66-3d30e05f23d6",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c7a68e32-cda7-b864-e7f1-ba2ae5fab309",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c7ab8857-b59a-c7dc-145b-8da6ed190264",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c7e266d7-3097-a994-1174-d3cf1608c41e",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c8006108-d31d-3fc3-8118-4a00aa1228c8",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c8126fe8-b8d9-89f3-fefb-a1e84543f875",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c83566fe-4da0-b680-43f1-aaa1880db549",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c888fa0e-3ba4-8446-ca99-35f2dd69819a",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c8e06257-6008-61b4-4b53-278d79854078",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c93aedf9-5f94-9dc3-c599-63c7235e54e4",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c97ef879-1ae7-589a-9725-ef5fe4f47e85",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c9ca3188-8a21-724a-23f6-5d9e402ab287",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c9db2283-f63a-871f-3474-0b3644830bf8",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ca104199-0e3b-a9a0-6541-971afcce8f96",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ca31003d-2c4d-41c8-9b9b-4c61347b3f44",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cb2ddc10-0f7b-7b6c-7e76-161e2e263da6",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cb756fbc-e28a-18c4-0a8e-c104792fbada",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cb92b727-b9cb-e73a-c23c-624b67d66994",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cbff8567-0725-b204-ba70-6b3ea17679a2",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cc712312-dee1-743a-9da4-ee708f3d06e9",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cc89b80d-6432-18eb-4c1f-89d48642289d",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ccb09398-5ba5-01ed-ab10-93ede45a2ff4",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cce2ada9-2f2d-ce10-1509-2e3988f0040e",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cd47af08-b065-d7f9-957b-4331cf499a84",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cd4a2b32-4de8-cae4-d813-3a9c528bce84",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cd59ec50-30b7-b08d-51c9-6737e46ecec3",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cd6145b8-b05b-310c-edc1-da36803950e4",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cddca3c6-4ac5-3ec4-fdd8-d62cbe543812",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cdf74965-81e4-ec2d-fd36-05903f3fbe71",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ce26811b-de02-7e83-9dd1-d5b4e63396eb",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ce4dfd1e-ad1b-0639-3694-5546f628cf6e",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cea089c4-c5e0-a538-e43e-7048c208f45a",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cf215fc0-30a2-fdbb-17b9-a258935ddd43",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cf463be9-848e-d83d-031a-db82bbcfed79",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cfb44862-44a4-9cc9-5636-6fc938d47be3",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d01019f9-5218-71f9-d3a9-35cb7b04b12b",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0425968-0a5c-0a9f-3897-b55f4e22a274",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0486529-51fc-62a5-004c-ecd5002ccd41",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d051e973-698c-58dd-bda6-63d696077ad3",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d06748a1-c551-6392-95b4-d0e7a67383f6",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d07bb88c-bdf7-0c6b-a371-44ce794f7d3e",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0800444-ea17-8385-2966-5647abb78f15",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0f8efdd-4c40-b515-a8d1-d855a962a852",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d1190b2d-d5e9-c76b-ea3d-31e651790ee8",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d127ff74-4b39-8bf8-4b33-1af8efd9efff",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d18e41b8-a3ed-9a53-f1f7-f4e1e0202350",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d1ae562d-8ff5-04f9-e4f9-be70373beea0",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d1e7ae5b-ecf3-3ada-6070-e654f99464ad",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d2041949-1d00-ce16-fc7c-30c218a75f46",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d2844c21-9623-3690-da1c-07bedb8fd532",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d2e5a5cc-7ca8-1bdd-b989-bd9c35ca0e88",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d32c9013-9fb5-9f83-708d-3e02f83631cd",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d332aa9e-04b4-1dc0-9881-7194bbeda63a",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d39c0714-beb7-9fc0-1fba-437d66426189",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d3edfa54-1262-d190-899b-a472871c59f9",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d40ea291-f121-99ab-8c7c-e499118cd3a7",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d4144d95-6eac-a753-921d-02e02afe2119",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d4a343e2-40d5-57a3-222d-bbcb5fa7a60c",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d4f123f5-ec66-2062-e7da-d35c3ee57eee",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d508b9db-de89-6123-1deb-4b5f7249f988",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d50e4726-2991-977e-1e9d-ccae720f4778",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d5b77a0d-04a0-3b51-f809-cfce6748812e",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d5e30992-c7fc-e449-6e8c-e9ba67574c4c",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6004a9b-1c74-80de-a857-6060eaf7261d",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d61088ca-985d-c689-4c0c-2ce37f50a00c",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6285f6d-f25b-009c-7042-a47f4b244b68",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6442191-6705-0a50-37ea-73d811f12b11",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6592817-12c5-1929-7656-0bc610ac5bb8",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d698f229-ec8e-a652-a33c-b1dfd62a38e6",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d7752dd6-7176-d04e-be06-8422283faab2",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d79229ae-1dc6-e19a-a307-1c8215d7bdef",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d7fdd83a-70db-66ab-6375-91cd319db355",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d810fb97-00e7-f2a0-0985-acffaf11b187",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d831506a-6778-5bd4-2143-28c488fe9e7b",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d83838d3-3621-3fda-ad42-8f16cec8bf79",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d83d4cf6-076e-8942-5a26-f3fb3c195bbf",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d887248e-7c1b-b541-76ce-6a1429625aa7",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d8ee1684-8213-4b12-219c-66a273f8d1ec",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d9396d48-fd20-a52d-70b5-3f2085f7cfec",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d94c652d-8be7-8ec6-cdba-d641297dbc74",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d96fcd78-c30b-080b-c92b-7d26c7dd221c",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d98440e4-8439-0fca-2b5b-30b2faeaba66",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d9891b95-d26a-cf80-2598-1080cbf310e2",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d98cfb9e-8181-7920-8a9c-c2092b81eb58",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da070f81-6d82-9edc-c029-7bd7b5d43338",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da0ad3cf-fc00-dadd-8d17-4fbe6f9aed62",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da5a50be-4892-2912-7d30-e020f44c2bf3",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da84b1ef-0ad9-c9b2-327a-56053940ceb8",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da917375-989e-aa66-3705-7fb13adc13b7",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dadf92d7-0a66-08ff-9067-d63a9ac831f9",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "db390cd5-f0eb-b466-37d6-608ce90540a5",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "db8cd639-647a-8b58-26e1-09ded6668cba",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "db8d2ab6-946a-1502-426d-fcb21953e405",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dbeff87e-c0f9-b272-f6fd-f93bea7b83d9",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dc15a337-285f-ef85-0d15-e43c62677ee0",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dd76ab4a-daa4-0ab8-7dcf-0ca198195586",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dd7b1eba-70ca-c8a5-de20-f8c2047dadb8",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dd9e690a-8f67-72b4-629b-15a9d4cdd73a",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ddc05051-6ba0-9876-0a13-ebc3052d2b4e",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ddd77ae8-2557-f2dc-0582-c2c104a0a18b",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dde5dca0-3459-b459-a095-94f8a5eb4711",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "de4618b3-b26c-8e28-0a99-ae5525670cd5",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "defe453a-4213-5afd-20dc-aefb4eeeb502",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "df6e2e51-1635-c552-c2e4-47c20b623af6",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "df7466ab-6cd7-323b-3000-734d0a87e629",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "df815484-6a48-1b4e-a7ce-2b2a4a85d3f9",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dfa77c24-d946-d3aa-8143-2d2980309d6b",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dfe2714c-934c-ef19-fe94-6c4db509862a",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dfec1294-1db0-ea7b-c54a-a137d116774f",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0040706-d0e4-ad04-5abf-740f695c492a",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0131722-ea70-562d-4144-e87cb9f0a371",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e01ac753-8bdc-ade4-9669-938d4fadda18",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e02b7f77-b4c9-bc10-276e-685319e06cae",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0423095-2fec-629c-28ab-8d15fc453cf0",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e04a9235-6450-7289-01d9-1e0c6d60181e",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0a5ac38-0109-c23b-cdf9-bfcc771a6956",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0bb8201-c45e-a7cc-9a4a-f0921c6fd86c",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e1738f37-9fc0-61b6-284f-5715db5ab025",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e18dbcea-eaac-9968-dad6-da60b8861e2f",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e1ae903b-0fa1-0b1a-7c79-50c21c2fda45",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e1cc35de-1693-fdc6-8795-0119f8f61623",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e22fb966-0110-6a37-fc00-b5c46fd4578e",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e2513fbd-3f02-efb1-92e4-4d7524a0a9b4",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e260b095-b963-c13b-b5a2-d609ac8bd890",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e291f668-1c34-8928-0af9-193ae7989012",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e29f5f7f-1c7a-cc69-3cb1-b84d99512a10",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e328a9be-6a04-0357-bd9b-ca8071994c53",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e3444b28-a5e6-7291-e9e2-d64fc228bdec",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e3893a5c-c4c9-6ce1-3d22-7f941a507391",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e40c1a85-5a5d-9c2a-9e5a-b2bbed317175",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e44ff3f4-6ff9-8af0-f12a-63b3268c710c",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e49eb41a-61e5-1afa-fd1b-c583e74a569d",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e4b69797-276b-44dc-f691-2839ccadbc59",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e549f908-0b9f-bc96-93e7-a3debcc701cd",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e5534c19-113d-4705-a9f8-5a5534f534bf",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e67311fd-9bd2-4e5f-8279-73123894a17a",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e68df90b-de60-3d0b-5d70-a90a988ef8a4",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7669321-e9ba-fae5-d9b9-0942e2f9593a",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e792e81e-cd41-7b11-d310-735b5b93ea00",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7ac8242-2bdf-3ea8-34ed-376cd6d4cc6d",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7aecb95-46e3-43fc-9a35-83a34ad22e20",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7ce4d59-52f1-7d88-511d-9ea255446f58",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7d00346-218a-3d24-b03b-7d2cfa8d6d7d",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7f5a5c0-3320-133a-03ea-46152f54fcc5",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8595792-3dcd-28dd-a32f-ee89cc5050d0",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8aa53f2-71ed-412c-f7d0-671d062a1adb",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8ac214e-c699-744e-3b46-e21d641f0d18",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8e08ba6-7aaa-47b0-1ba8-5672399ddd9c",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e91072de-8876-66b5-cceb-4cfa6eb00b82",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e915fc4f-2425-c1b9-7448-6f93374f4d93",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e9479010-3a2b-6354-2e0c-11b49b24fb5f",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e98c5f67-be73-b56b-ad1b-5fceac952155",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e992a0f0-7cfc-f1ea-667c-c308c7560737",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e9b49c47-9e7e-988a-005a-a02d777ea1f9",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e9db33d6-c21d-844e-fbab-1988c3f1c501",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e9f13ccf-286c-0d42-6c91-e3359652d4cd",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ea01f8ea-b73e-be93-9a72-7db9fa21dd8c",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ea06b88f-d8a1-ee08-bc3c-d84a42ccdacd",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb190148-b365-1499-4bcf-34a8307d3ae5",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb44ddfb-46e3-45d5-0bc5-a67ff08455e0",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb74d34d-f692-9e7a-adfd-1de4eef6aba8",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb78f89d-1cd7-e3c4-6b6f-df1c818c8923",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec052380-b3a0-1f11-1ad7-005fbf8520e7",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec071909-de0a-3e67-a7b9-4a4b07d9de99",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec0e1add-4586-37c1-c972-fbf0ede0a017",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec341556-c367-708a-11c4-097536f47dcb",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec377fb2-efe2-8cb4-6918-92157e4f1d7e",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec3fb212-0f7b-d271-15be-97e7221bf8eb",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec421852-921b-ebfc-d739-8212e4385e64",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec46c0fe-0b44-80a4-27fb-211fc8190195",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec4fae02-dbe6-d8aa-4d3d-da1c38fb7f7c",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec725cd5-16d9-76f8-27ad-d5aa62b86c1b",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eca547a0-40bb-5380-51c1-a0b8b2aae5cc",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eccdc834-73c7-adb9-9ff5-6255b7257146",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ecd3fefe-805d-9d96-cdef-0e211ce2b325",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed370274-74ed-1323-4d72-4c21d1e54c40",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed3daf70-fcb0-7b32-f292-becdb3eb3eb3",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed3dee0b-d891-bd85-2ec9-065516fcd123",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed67f473-5441-c705-b174-e26119a10316",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "edfda5e7-5084-880a-022d-29069aa5cbfa",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ee921d29-66e1-c443-c162-df77ae566e01",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eef85155-102e-817b-0de0-1e2e035404d7",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ef04b83f-9b1d-9814-3a9e-a3c0d292ac3b",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ef55d5ee-4787-d8c7-b1fc-0862746ac28a",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "efa6a2ea-b018-6b26-35e2-0f08ee59c252",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "efcddc9c-0e5f-4f7d-4e5a-46ec6a58cf1d",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f03e93c5-dcf8-3a1e-2f1c-000716f66d54",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f0848734-7d3c-b628-05cd-7a6ca1c722d2",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f129bad2-788c-bc9e-89cf-60039b8e604a",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f13edc40-466a-6629-9715-d914984c3653",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f14fc5c6-c061-1111-1e79-f268130aaa74",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f16f91c3-4de3-d09f-4071-921f313f15a8",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f1707df7-3aa5-d08c-ea15-5bd6269c6cd3",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f24c8abc-3f83-5162-2e6c-56859c5c056b",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f2faa893-22a8-48ff-393f-8dfc73243f38",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f2ffd04c-6cf2-db85-a42a-bdb85851cef7",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f3330572-03f4-2a9a-420d-89184937e983",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f35fc12e-5b3c-7ab7-e448-9886aecaf91f",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f38c5421-4043-dd86-739b-482957ece852",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f3b1abe6-fc82-148f-0715-4d25554e7fa3",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f3b3e51e-629c-d167-01db-a6540d350738",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f3d7ae6b-ddba-8629-83fc-ae8f9886be54",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f4036de1-b230-f445-d572-9bec69e6a56e",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f488335a-15f8-d88c-f1fc-d8ac3ededede",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f4c16c8e-12ba-3b16-0555-dcebf1a93e21",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f4eb2e87-4c7f-9905-8766-781d4216435d",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f4f79db4-c716-dc61-8d96-d799e6eddb0b",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f509123c-dc8e-d71a-ddbf-4cfe70107308",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f5577ba1-f957-c451-3959-13895ccf1ea2",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f59455ff-4ce7-d960-dc83-0e9693fa47a6",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f5bcb9ad-0454-f4d3-389a-3f1d78dc2a1c",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f5c88e5a-1efe-cb47-c7e0-bcfbc8aefd93",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f602e4c9-bc99-4d36-b8af-7f9dcb88d01c",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f692a256-8b14-1f69-5d15-3c1942f5c5f5",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f7033651-e69a-4324-fbe2-d0182b44a808",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f723976c-ee91-b770-e7cf-4c2ddd2e10cd",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f73614e3-a6cb-cdc5-75a8-c08b2fe4c92a",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f74652db-dc7b-535b-b335-595d87ad4277",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f7502be8-0a9a-4d63-69fe-fba66d3fc191",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f7600ea7-76bb-6fcd-502e-3d05ba22f7ba",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f7875753-a25c-5e48-6009-e5dbdd89d86e",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f7d79b48-ad63-002b-60ba-4123bbf5360d",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f81f9d3a-35d8-f873-8f95-45726a1387a3",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8b8d47a-0316-4cc5-a914-350faf2c957c",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8cd0d8c-907b-551d-6211-931279dc0942",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8e08047-e9c3-3ba5-8214-30b29b7ecef6",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8eda48e-36b2-3c80-2a8d-45ed824d3d02",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f924287c-92a5-420a-b3f5-7bde43c642f4",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f92a4c83-bd81-146d-45f4-e2016cdd6977",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f95addc7-9b43-8f11-22be-04c9b277bbbe",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f97fe6d6-e68f-132f-a21f-88b4705f83c3",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f99189a8-8e1c-7ffe-37d4-46c412273281",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f9b4af5d-0d8d-5c46-59aa-0b304f0f0af5",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f9cc2ba2-445c-28f5-a52c-68f5d9e61374",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f9f1b201-c78a-46fd-3f7d-701f0cb9d80b",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fa2ae8ae-2b5c-ccb1-c6a2-0177edcd92fa",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fa8863c0-67b0-85c7-5ff5-bf270e35170e",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fa95ca2d-6015-d738-9bbe-e8cba5195c60",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "faa58a8c-d950-2e5f-5a1e-2fb3331958ca",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fab65069-a16f-8092-41b3-2dfadb5b84c2",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "facd8efd-669a-9b98-99a2-ddfd592532dd",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb099bba-fa75-cc47-57ac-dc2ce717cf7e",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb2537bc-4439-2071-55a0-b6407e36e5e0",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb4dd0a9-4c1a-c15f-1c5c-83953364fcd2",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb69fb25-869d-236e-a158-a728d21dbd94",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb91193d-c432-36d3-5e89-59f7ac76cab2",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb91b8eb-0efc-685a-ad59-fcfc7dfeaac5",
                column: "room_id",
                value: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb99eb83-8abc-f0bf-d8d5-d3ea90a38837",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc38688b-a5a5-0a3e-f73f-a130d3c1ade0",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc3c2b4d-ee65-87b1-8670-116de9888753",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc5fd85c-a36e-f72e-7eb2-0ae8930091c2",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc730fac-20a9-8127-7fda-2bd0fbf14448",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fcbbff35-ac21-d887-426b-fc0c5af9fa0d",
                column: "room_id",
                value: "ba6e201b-edf9-7aea-a09f-4bb2fed50891");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fcbeb7c4-fd9c-40cc-b15e-4ddf4d47233b",
                column: "room_id",
                value: "694b7a35-1915-d0fb-02e2-562a6b6b3ad0");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fccf2bf5-babb-d0ec-0d0b-e5f0b0d63701",
                column: "room_id",
                value: "9ec3581b-fe27-3e4a-2d4e-98c4abb15ae9");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fd1bee15-e7b2-9c75-8f36-bf9c4510c9c5",
                column: "room_id",
                value: "61eea842-d7b8-3f75-7a50-f17d467e2f82");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fe2403f2-62c7-83ab-fb2a-f4d6cb4cea82",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fe6057a4-b3fd-e417-393e-2376770b33da",
                column: "room_id",
                value: "305290d1-3c50-8f7d-1f6a-898cc87f8f5c");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fea0de9b-2eaa-f28c-2118-dc74ea12b4b5",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "feb625e2-f58f-10a5-c43f-6d3c4c346780",
                column: "room_id",
                value: "5863a804-6ac2-3f05-38ed-472541726740");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fef0fe5e-f84c-8548-71ef-b871756abbf6",
                column: "room_id",
                value: "222025a7-66a4-9b58-2958-eb835bd75046");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ff23d1fd-2e9a-7c35-f281-1467d5db28ee",
                column: "room_id",
                value: "91263188-230c-ee00-ed2e-9eda780a61de");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ffaf6dcf-a818-b063-4229-9fa3525404e2",
                column: "room_id",
                value: "105f2e79-3a04-c9be-ebe1-241b17a81848");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 53, 407, DateTimeKind.Utc).AddTicks(6818), "$2b$12$XCBSr.a4fc4TI/u7VrpdAOE/hIWC/gMZmY6nGAlv0VqGAW/AuQOPC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 24, 425, DateTimeKind.Utc).AddTicks(8858), "$2b$12$Qhm6Tz1Hd3v0ZpNFyOF0HOB4KrVVWbqmMKZHyiAfrTgoywL3VIItK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 43, 440, DateTimeKind.Utc).AddTicks(6983), "$2b$12$0U6L5Y8ziGsbt5f9VlQCDOHRUZ4ot0t/FPpOaGF5fvboPbSshilTK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 22, 367, DateTimeKind.Utc).AddTicks(2479), "$2b$12$TKJjcwKhjkN59ytfJ4xGTeKcTHd1xN6.JPpLOqjFRoHRtGM03NMyy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 29, 421, DateTimeKind.Utc).AddTicks(413), "$2b$12$LcsvxHHoG.sUNAf7/s737ujveO3iDT0BstsClp7aFoZunlNOAC8Gu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 55, 213, DateTimeKind.Utc).AddTicks(7551), "$2b$12$CqSpYD7iEzs9KCUxobbA2.NTB5ZcDZ67dt1NQKgd4RHNbPc3lFz8O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 17, 486, DateTimeKind.Utc).AddTicks(7383), "$2b$12$TXLTdC10zVAPFErLilDRlO3MkqDV1WXXntMQV6USV5TePDUjQcL3q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 51, 396, DateTimeKind.Utc).AddTicks(2171), "$2b$12$eGyOF6BX0CI2JJUUn.Q1d.yxKwNngHjfwlPYR.j7VHkCQ7D6k14Pm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 32, 838, DateTimeKind.Utc).AddTicks(7859), "$2b$12$dxDBkMbUkDRy/UmLKKXX8u/yr7b2Bu1aJ3BVEjkhK9T8cPxmGPO1S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 56, 193, DateTimeKind.Utc).AddTicks(1498), "$2b$12$IFho0FW4M8pCz0DbKswfpOl4QCZYK7kSYul1YDs4/FiJIErvn1sFS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 36, 461, DateTimeKind.Utc).AddTicks(8273), "$2b$12$QbZtHTSlT7Kh8CLNPwunj.S2NCzofhyL3r9gUmIOOBtpHVT7GtZfG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 19, 70, DateTimeKind.Utc).AddTicks(2108), "$2b$12$xCZ0jW7P8eBhmWzuF4BZ6eiek6a6OyfMIMu8zI0VARZACdB7/EPUq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 41, 55, DateTimeKind.Utc).AddTicks(9244), "$2b$12$TwvR2vzqsa19mU2KVTW4I.Zd8Cvb3RY4eE82DQk4hRavnkCtBXdZK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 28, 84, DateTimeKind.Utc).AddTicks(2137), "$2b$12$1XJ5oWG8lhpBAicr/NZB.uOZ2EL/OOoWcnCcl4VIBNt8cPa14xh/y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 45, 696, DateTimeKind.Utc).AddTicks(8177), "$2b$12$2/9bTh.s37XF9aGlilpFWu3f/z1h5j3eLPNTsmEJsEGasNYhBYabe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 20, 171, DateTimeKind.Utc).AddTicks(9615), "$2b$12$lbuQMlOPpO6rFkQMsty2tOZSkta7i9BGF7vgGeUvGPMJkyF40w9Zy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 20, 886, DateTimeKind.Utc).AddTicks(7323), "$2b$12$b9SvjQXMHZSNzjXMnoYfquRyVS0HMYOCfd/lFACqPAXk4GSfWbz.2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 49, 629, DateTimeKind.Utc).AddTicks(9306), "$2b$12$dzCfAP8DZntHiD10qFsf8.C86TRwPuoeb2CGzjysnFwE9liR/XVbG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 25, 80, DateTimeKind.Utc).AddTicks(2341), "$2b$12$GULcqrvZK384R4SehvhhsuosD4OXGvYg1hdR1k1VvqzE9cZSIwuja" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 47, 307, DateTimeKind.Utc).AddTicks(1231), "$2b$12$TAeKsyb48AQUKxieAg/HGej2T8uw0VnGjTZL2AMVbaxDrqVZQTDSC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 52, 68, DateTimeKind.Utc).AddTicks(3563), "$2b$12$AxRq.zDMZG6Ziub0NB56qe41WU29ErjLGDA1.P8KFe206P2UiPyuC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 35, 480, DateTimeKind.Utc).AddTicks(1136), "$2b$12$aKo36kLbL5Umu/BOBMp2V.TW42JuANBhUZRr9A5.rl5UdLqR5I9k." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 55, 874, DateTimeKind.Utc).AddTicks(6124), "$2b$12$XrO5KEgjpaEnqYWKElmXO.6FPc2khuWD8u1dtiGcVTpCIhkzstHyO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 48, 332, DateTimeKind.Utc).AddTicks(6035), "$2b$12$1DVqt0E7iWrEyQ1Gy2YrneFGxqc3w7N7bA2JEpgoBJKhx57RK5/dy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 46, 332, DateTimeKind.Utc).AddTicks(6930), "$2b$12$lu3JnL9/jf0a7x63TMjENuLWcoCdMn1ZaUN0ohXKwD77b72t45AAW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 16, 524, DateTimeKind.Utc).AddTicks(752), "$2b$12$AV2ROq5n28sch8Ft.4XfvOhKZ8l6Gr9E.KheT.jKf418HA9FjOR8a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 27, 732, DateTimeKind.Utc).AddTicks(5175), "$2b$12$P.sjdSLu9WcOnUQiD1edGOj80cNIhX5kPMKFc30zsnydlG96Dmy6S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 18, 138, DateTimeKind.Utc).AddTicks(7160), "$2b$12$quMa0pIiaih3za0JAm9BG.Zocn5uBbhnzurKzza/RsuSP5DhkuFwm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 52, 748, DateTimeKind.Utc).AddTicks(5925), "$2b$12$TyX6At5s3Z.Bl0ZoCQZ6Uusv.Dsp2ynWgh86TajvDKxbWXgWPbfS6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 17, 805, DateTimeKind.Utc).AddTicks(1424), "$2b$12$RkqT5Lq6pP44tzrceLdQDOEHZSfDTpVajeIcFkVY0bxOwt7e3szDG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 40, 51, DateTimeKind.Utc).AddTicks(196), "$2b$12$vcw4y1TFzQin1poUPsOVfeoeA3pGqz4J486Y0DNmOxbvqBwHCf7gi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 41, 385, DateTimeKind.Utc).AddTicks(9077), "$2b$12$MbO0aCzGZh0fHure4DmbUevaTw7ueSwLI1Qr0DlrKjzHJCQDpm/Oi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 39, 36, DateTimeKind.Utc).AddTicks(362), "$2b$12$TDT/lpnghaESZYgf8vPktuK.j1o6ailG629FjitjTAC68eXnF4spO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 51, 20, DateTimeKind.Utc).AddTicks(2917), "$2b$12$AFZdvlUJKyPBz3kAGrpe1uNegWuUtY4A1agyPgJzfJ/hWyzje58Qq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 37, 743, DateTimeKind.Utc).AddTicks(1454), "$2b$12$TdWSzgfGwR0KuZNKpSl.luSuwzmOIaBEdP9bOppYSXTR3wNkz2tj." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 36, 789, DateTimeKind.Utc).AddTicks(8233), "$2b$12$8eJfv4kzOLFXXy/JuBHvx.zXub88NQGGyoPT546B/3Ss32mWqW5ZO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 21, 620, DateTimeKind.Utc).AddTicks(3201), "$2b$12$A3QAtMo40R2oN7OS23RakehGiWjg39p98Ne6mBuPFCxY//XSrCwwa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 18, 454, DateTimeKind.Utc).AddTicks(8191), "$2b$12$3OPMXTIBlHIxeKL/KrudrORb0l5LE.WkAaGy8LPAoIHM8EUTgRo3y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 23, 437, DateTimeKind.Utc).AddTicks(5806), "$2b$12$rWXQsHhy3PjKk6m9e42o5uOqp2GhkUSBeFu6r3gNZqRowOWGNp.p." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 40, 727, DateTimeKind.Utc).AddTicks(2925), "$2b$12$ib6U0R2PXZ5vrhKAqgXbieoTBPexm2Pjf.Jp.l71q1YtwQpAZsFfy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 52, 401, DateTimeKind.Utc).AddTicks(4138), "$2b$12$GkoXyBF.oTa4pcUYaYFbYe13.AqugjHVe5np8/Tkwdv7BceH2C/e6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 19, 701, DateTimeKind.Utc).AddTicks(9102), "$2b$12$qwxjYvhCdmpUQte1sHyF1.Dez6.yIX2/Md1KZ550Ytj/TgUIuEWUS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 54, 120, DateTimeKind.Utc).AddTicks(1702), "$2b$12$GDm1PR8S5ud9gbddLLCV2egoYMqJpQqiMuvwlzfgLwZP2OmeXzILC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 43, 756, DateTimeKind.Utc).AddTicks(8996), "$2b$12$o3HaoxxuADbzwcNRfze2le3EpGVD3ffBezCOqKbTSdP0zvoxlaneG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 29, 103, DateTimeKind.Utc).AddTicks(7492), "$2b$12$7p6.H0jZBXX7PmNzJSwhA.hVnfGvG3SNyJ0wq/bf2hzQJJTmR7iNG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 34, 162, DateTimeKind.Utc).AddTicks(767), "$2b$12$2jp7tgWlvn60oEsjqwevJ.S2H0UOUSsVZCOjadLTAGO/Ys57zv/be" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 55, 551, DateTimeKind.Utc).AddTicks(727), "$2b$12$ix2sXJZW2oZsj6ozMOK1K.Af.f8NzHjIxncOtER85xGjExPUg3yz." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 46, 641, DateTimeKind.Utc).AddTicks(6636), "$2b$12$XmptYhHefOPBHgDksDROe.jKa8N5L8/8meA3TkOmwUhR8Tj21..Y2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 38, 385, DateTimeKind.Utc).AddTicks(4762), "$2b$12$LnSMwJom2zvyL68gcK7djOBgzI/TO4NtslYYfe2OMo3JhcLzxJQkm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 36, 106, DateTimeKind.Utc).AddTicks(7458), "$2b$12$jtyOVIApsaf0o9dd5zODA.3z1j8/SEicriwPcpyHtmqrHPhj48.qu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 23, 773, DateTimeKind.Utc).AddTicks(3998), "$2b$12$jBB.TrIFDoCvXzfsZeBPsOPCim10vp6qMLOLeztwYkpa/d/i8acUO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 25, 414, DateTimeKind.Utc).AddTicks(4821), "$2b$12$19yvVmn8axlUsW49qcZMqewSLntzgCo6nmEux2bN4Lvxq0VwM4y.6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 44, 731, DateTimeKind.Utc).AddTicks(1740), "$2b$12$gJOrqSdyn/XC/sOHHcw3h.NIPHxUfB9ZSr8qduhpinmGKV8NUA5G." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 56, 525, DateTimeKind.Utc).AddTicks(7999), "$2b$12$l3t.5VJY81qc0SIL.nMS6.SZloT9JxzNKVC/HYj5pc4iBbgKof7Uy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 51, 721, DateTimeKind.Utc).AddTicks(5037), "$2b$12$bNaTpOc1JEEsrvOOS9wwAuov63p3oFBIgDcuFwJQ53HkxeULFSpKq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 43, 113, DateTimeKind.Utc).AddTicks(474), "$2b$12$jNSJkfHbXHBtL4n1XQKTKeOT2q298FuYjy7tYJJREtTRorMpEeQVC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 24, 758, DateTimeKind.Utc).AddTicks(1226), "$2b$12$rTDFs.scZMKbI81BHJUc/usJgpMm7mcvXlvn9curgB7Dmc7lMrJRm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 35, 160, DateTimeKind.Utc).AddTicks(8300), "$2b$12$Xaq28KjlTwGBh06TvOLO7udnQUF9K/wdDBPO1fKGlcoFxXcCuD3Va" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 31, 459, DateTimeKind.Utc).AddTicks(7283), "$2b$12$Fkw.B1Rpu9.jvbIP6P6XWOOOjFN0z6LJOVUVaADO7j327M.38tsUe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 25, 767, DateTimeKind.Utc).AddTicks(4961), "$2b$12$SWrhcFsmKQZquyPwMAOYBOyXyk6AzRqTeqNVnDA8FpeF/Dzsui2P6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 39, 370, DateTimeKind.Utc).AddTicks(7716), "$2b$12$Nc.6M1FbE5c6t5VMaRqlJ..bbm0YSyPoyZ4ixu4ABLir.Y8p2/VW." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 38, 66, DateTimeKind.Utc).AddTicks(6166), "$2b$12$Rjq8BwP4nZm5tCFI2ShgKeReTA2KoI1KomraE7.x3mn9Yg5Q4sJiW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 39, 697, DateTimeKind.Utc).AddTicks(1729), "$2b$12$/8HRxic2bkw1BquQGww/IOFZjV.66DPB7onvM29XSFqWlzPfFhvU2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 48, 652, DateTimeKind.Utc).AddTicks(6787), "$2b$12$04rPy9QMygPuhCJuEe6NH.4GAW/8HqPcwSUb2Nq5Px8EnkNspu7cG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 46, 8, DateTimeKind.Utc).AddTicks(7742), "$2b$12$6qQ8bxg/XSDcCU8qQZBgNOUjAv04YgosKXIvTM4AzAdfKtpnxvWr." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 42, 91, DateTimeKind.Utc).AddTicks(9108), "$2b$12$wFkXTl43acDPbZUZ5bWspe/yThqAmfCe9Yruv15VCUO7SfhTGdawS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 45, 66, DateTimeKind.Utc).AddTicks(466), "$2b$12$HAsS/xo6kjoX5OvOuwwuhuBb0xIVIJcuElM/qRqdOmMB7PB2QGfjm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 32, 150, DateTimeKind.Utc).AddTicks(3422), "$2b$12$ChaLVc5DSRftM60Q1eYPbOhs9EUbhsKmDcK6geY60.iPxOsN9GrE." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 26, 107, DateTimeKind.Utc).AddTicks(5998), "$2b$12$oSeTxuHcc7IJEfPgWyfvCe4RUXXbSa4UB.kwNO3IHNQBcVCZEnQZy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 50, 339, DateTimeKind.Utc).AddTicks(782), "$2b$12$GQARe2E3ojIjtOGRWI7l0uyUOXBy3duZ.MuPcl2kFc6W3WgWXAGcC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 31, 795, DateTimeKind.Utc).AddTicks(2789), "$2b$12$cv6uh.fr8oO3eAesQDaeSOrWa9pMtBObJfqrkVv7U01KC7aJFowWa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 30, 464, DateTimeKind.Utc).AddTicks(2036), "$2b$12$l3D3oczhwZmmshHergkM8uxKz/tSaM1Q5PfQ/Y8Iql0rcjhQvFlSu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 50, 0, DateTimeKind.Utc).AddTicks(8402), "$2b$12$qeMJp17HSVjk42npWrsZEuXU7LFC9hAUzIWdvybLrARZGGL7PuRjO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 34, 474, DateTimeKind.Utc).AddTicks(6819), "$2b$12$q5OIMMKJVDXjPrH9yLklKOkiJhfDt2BXTk.f7c7fJ45lRedUyU3J6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 42, 426, DateTimeKind.Utc).AddTicks(4592), "$2b$12$FI7NonmHHTDXxz/6uM/yyua6tt7zKxQyyvDt24JZH3vNuIhpz2Edu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 30, 779, DateTimeKind.Utc).AddTicks(9621), "$2b$12$C.3gmOu6uFS9fKsZWS.BVeSDVpwlVbx/11psUx9a32ImanviqqFAK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 33, 173, DateTimeKind.Utc).AddTicks(5185), "$2b$12$SUuOYoFVFRD0AQhFgGBkGOu6l5IkpJGg2fmKzZnHQ/CIVHYFfO9RO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 53, 777, DateTimeKind.Utc).AddTicks(2999), "$2b$12$laLyxdC987sy.laFCm0Ilu2Jjw2nMLV2ICxSRuSUcfAYjB5HJK2.K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 50, 674, DateTimeKind.Utc).AddTicks(4918), "$2b$12$O289tt5GrfLjuIlnOoBWxeToqlTChdgVoDwio5kyg4trFVRQwKQY6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 48, 981, DateTimeKind.Utc).AddTicks(3346), "$2b$12$e/1zHISZJHi7AKPhU4vDsu9sAGfHc33odG1aRXQP1MbJVVG9ziJGy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 47, 675, DateTimeKind.Utc).AddTicks(6633), "$2b$12$MbkdN5wMhDb4gXGexj3Xe.5U7bg/dh7J9Jgb22DkjyJK4gv5sbqMW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 42, 779, DateTimeKind.Utc).AddTicks(4278), "$2b$12$V4h4UUdqHha.tReBVQFxieNYA0YMPRofa8QHSQ878q8HjPs05nccy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 37, 112, DateTimeKind.Utc).AddTicks(2449), "$2b$12$AdoYS6KHBtu/KHwHHnBNvuq7N9.TT9HHH0iYTjWmCWZ2DZbGgI/Cy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 54, 500, DateTimeKind.Utc).AddTicks(1819), "$2b$12$dSoqe0VUZFwwXrcJwojvOOjQP7GXL4QXEoAryCS9XHHkg1UQ5Eaj." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 34, 806, DateTimeKind.Utc).AddTicks(1778), "$2b$12$XbE9WxdNGi/YoCI8c5PdXOhvKts4Uwx1fHhUJ/LlEIBdE1pQHjuMK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 28, 747, DateTimeKind.Utc).AddTicks(1814), "$2b$12$CupTkdlR0lt4MUL9BDORuO9Q9/cxvM6LqWvdE7QouLQ.cz3Tqvty2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 16, 833, DateTimeKind.Utc).AddTicks(7352), "$2b$12$pGb1EWcTfwgUrxuYtZXJhezE7L658luhHPTM/FW6NX4X0TBizD1vu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 26, 432, DateTimeKind.Utc).AddTicks(8819), "$2b$12$GLbho7ZZyRbufL7J8NA9cOW0CqpmbtzPTAZFNtdU4EvZPlRopK3w6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 44, 399, DateTimeKind.Utc).AddTicks(6256), "$2b$12$YsaL0ijrWn0nRB/oNVNc5OJtHV6NTXLP1WEKdnkGre6tdRM9O5YXC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 20, 518, DateTimeKind.Utc).AddTicks(1799), "$2b$12$NHTwKq9RI9.t2C0wf8m4wuwPLNSs/azLPQfvag1J28u.Qyhg.1Utq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 28, 415, DateTimeKind.Utc).AddTicks(6012), "$2b$12$YKxLFumWLlFtPKi1dE1HHezxdUtMfWHNY2qX2aumUaYkxfKJUV7vC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 40, 387, DateTimeKind.Utc).AddTicks(5979), "$2b$12$Wcc0LITvjc5g3YXC//eX4ex59r/65clzZFMlh12eTMa32YFk5zaoq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 45, 375, DateTimeKind.Utc).AddTicks(3408), "$2b$12$S5P7paO0hLubAc9Lj0pSquPPUuHS7X9qUvhjo7x.qRmHgejQ1KR4y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 41, 736, DateTimeKind.Utc).AddTicks(642), "$2b$12$pSL1ra67.67B5FvD6pQKSOP2HxZBfYHg1Gqv0ratm5og2NY5W2NYC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 27, 407, DateTimeKind.Utc).AddTicks(3719), "$2b$12$jmpynGwffLdCJznVk6SrZe155CmbSbjaJjN38HcjJIsGUjiwHmkcq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 44, 76, DateTimeKind.Utc).AddTicks(3591), "$2b$12$17BMuXoMAoRpZX4NWEueheC6aQFbnzdtogdz8TptAh.ZAopj97oaa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 35, 796, DateTimeKind.Utc).AddTicks(3653), "$2b$12$7vheHqa4mrlQ2sLGRG6eTOiF4ZFrbbL45J5YJFJRI4fdXjq3nDLyu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 38, 696, DateTimeKind.Utc).AddTicks(9704), "$2b$12$cYp4Dh34D0n57.18e3n94e6lpTquhX785xEWIvsRhpc116LTOv7Ry" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 24, 100, DateTimeKind.Utc).AddTicks(2808), "$2b$12$KzlEse98aDn7aQCSWKWAUO9b5jkbP.xkQbkMcqwPZM0YNmCcgyoYC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 21, 245, DateTimeKind.Utc).AddTicks(9377), "$2b$12$rwXv0ZCR/ztoWIVH96eAeevKOrCMCGWq512u7CWVG92AmlZtkfLgq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 19, 388, DateTimeKind.Utc).AddTicks(2301), "$2b$12$LwKQGle0KkbO/dyO3bOOZu6vjemAS9ZfJU6Hk0nYNzQyx4hQwqDfW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 37, 420, DateTimeKind.Utc).AddTicks(6758), "$2b$12$CQ.J2B/DiJthYU24ZaH/5.yXBIcPWMsc8EDmWjkuMegWLBMyAdWDK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 29, 757, DateTimeKind.Utc).AddTicks(8496), "$2b$12$8hlISYnYczk82SOrt1buceGl9Unt9K4wDcCc74AKuOKWoxoIoSmRu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 17, 146, DateTimeKind.Utc).AddTicks(8187), "$2b$12$1zpUmWUaTQczC2nyc/EmTe3T5uqGeWUENMwAcXW7WuOIZ0tqOAJV6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 31, 116, DateTimeKind.Utc).AddTicks(2654), "$2b$12$FxaIT5KyQw2qB60jJGTxQOgd4iwVkX4Fur.dzg0bA19PAAPY.BnSG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 46, 968, DateTimeKind.Utc).AddTicks(2597), "$2b$12$HygKCxCgFvk3pdcuqYGtjOyqz3nhuWrhS.GOKtMwhZVLJDwhyDMQa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 22, 8, DateTimeKind.Utc).AddTicks(7033), "$2b$12$AWSI0j7HtdAdqOJlcf3Fj.JOlbIAy8Wck8QC7Xv44GGOp9GfREvcO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 33, 508, DateTimeKind.Utc).AddTicks(4033), "$2b$12$30zJUM/e8GxJTqWm5cwPQOjtqXEO//y.UxFpOFdy/M.78/gS69voa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 33, 829, DateTimeKind.Utc).AddTicks(8354), "$2b$12$/pI85NQf01KL4uxX7tilIeQbzAsR4DLY72VWyqz4BdkOxm1bptdyG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 54, 859, DateTimeKind.Utc).AddTicks(1231), "$2b$12$3UEoukUqlaKXHY7HuoEq2eEQXKlPX/o6.iStbeT1SsVYL2.8uGnFi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 32, 483, DateTimeKind.Utc).AddTicks(2746), "$2b$12$giOBYf7sd0OQQZf1Qsgr..3ogezbKf1lBIUi6qN1Lufva.rS8lesa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 30, 115, DateTimeKind.Utc).AddTicks(6305), "$2b$12$3MlhRkDHl5x.xf6PadFOdeZpx6/uZMN0WqeQnLyPq8a8IzqvE7KHy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 49, 308, DateTimeKind.Utc).AddTicks(5548), "$2b$12$PePvwl8FiIu.Z8OgbuSnEuIEUFsYu7epie9mFa8ReH/YtTmEE8n.m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 27, 75, DateTimeKind.Utc).AddTicks(4847), "$2b$12$u2VFloRI43jW4e/xmLzQ0.Ufegt99C7VYu1b1ndWWS2u.2dk2TKz6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 53, 81, DateTimeKind.Utc).AddTicks(6367), "$2b$12$qBEqzJo8qlJ/y9mnPxiwq.OXJ8GN/H0bS1a8RR8BdY6oGFEPGLPGW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 47, 995, DateTimeKind.Utc).AddTicks(2761), "$2b$12$yoDqwNCTPecrJMH1G.MZMuN8D16yB4bgI4KAiUQOzT/Kobq.QEhpK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 23, 109, DateTimeKind.Utc).AddTicks(5736), "$2b$12$v5WrjRmmNVIYHd2PDqnwJezvcBvE1Xn0fi2a19wU4J98yOqxn1QAa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 22, 766, DateTimeKind.Utc).AddTicks(5140), "$2b$12$U67a5McM78sgAfdVgePh5eCsdFkzUcQQk3zfuitnQIY6ycSK/771S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 26, 758, DateTimeKind.Utc).AddTicks(1330), "$2b$12$I0D1sR1Km0c1lVrTmtf8hOnyVs7CztG1ZJnk49fY60vXV/f34P8Q6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 14, 37, 18, 762, DateTimeKind.Utc).AddTicks(2456), "$2b$12$q7FPXP3YZlJ57S0bCv8MKOBI7f4.PQDV/WJVLP1tX98aBqL5hhMBi" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "93a4338a-6691-98fc-6919-1f94663cd1ae");

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "room_id",
                keyValue: "105f2e79-3a04-c9be-ebe1-241b17a81848",
                columns: new[] { "capacity", "room_type_id" },
                values: new object[] { 50, "d1026790-e6d8-e5a5-d486-fcd720c78c6d" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "room_id", "building_id", "capacity", "is_available", "room_number", "room_type_id" },
                values: new object[] { "bc224e06-c4ec-98e8-c492-0a528471d3eb", "c3372749-b5f6-f0e6-e628-e79b82b17dc7", 36, true, "IBGBI-0", "2ebbc802-19e3-1c66-7809-e0126364f9f3" });

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "000e4bd2-bf61-3b76-d413-c78ebd570ff6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "002a1014-a1e2-26f4-5676-8024dd9afa89",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0048393d-d5a2-01af-d913-bc890fe8b2ae",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "00ab48c5-13f7-71a7-c1a4-2bac922ac15a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "00e55ffe-e77a-1041-83fe-f230819a98a6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "013253fd-915e-ae02-98e4-8f6204070217",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "013a00ac-ac8b-5c01-8a57-5e3a952f41c6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "015728e2-d208-f4cc-9b3c-b972b482801b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "017daad5-244e-acd2-1ce4-07c75f5c9f04",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "023ec71a-737d-43c8-3e94-e93046aab748",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "02a2a3e4-b5c0-289c-5dfd-95324e623d49",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "02a38241-54e3-fc1c-a085-db7381eef5d9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "02b8e933-beee-fd21-e81d-20c13cc2b9d9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0307a4e5-0941-b6f9-6e98-e48ede3c5f57",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "035596ea-77a5-4678-2440-1215400176b5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "03a99c53-fb54-e2d7-6a4a-3c27563d7b9c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "03ce2aa5-d5db-91db-2360-24f91d8fffae",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "04231bab-5384-c392-08c9-c01c6bb0cabc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "042bb7cc-acb9-432e-6025-f01f85edc241",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "042c2061-f2ce-afcc-e0c0-a7bbfcebeb13",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "04ccea8a-4e53-42db-c31a-0e8f2c805783",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "053f68e1-2f0e-089c-76f7-de930e8668f9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "05bd8efd-7965-885a-712a-23b65c741a8d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "05c1638f-8bd7-6101-ecb2-b86c4e36c561",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0619bcc0-e7d2-f53d-c4e0-62615a60b730",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0633fa76-26c4-bbb8-04b7-ac2dffc5035d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "06798c1e-baee-3f07-8608-65bfd694a86c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0685daf3-3082-e3a4-9172-380bdece93e0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "06db607d-9866-9b91-3737-5d793f448048",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "06fbdd75-3178-994f-2bc4-64827db7e420",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0733286f-fa6c-43ea-5ca3-7184db85512d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "078427d0-9b6a-f123-fccb-8e5843a2e640",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "07a3cd0f-fe14-505c-acdf-f777e37778f1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "07f20e2d-9dba-3c0d-6168-ee83fdae9385",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "08859e7a-33b4-e98b-b9ef-f754da6f424b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0993178d-8c63-8c40-84f9-5f0d8407806a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "099762c5-ed02-bda8-408f-10c6f211f013",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "09d5852e-c85d-b871-49a2-71c8d434e139",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "09db97d8-0c10-1a21-a3b2-f3c20dfe9541",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0a613941-9193-abf4-25ce-a79ed34acf0f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ab1812f-650e-a53a-7a38-d1191221716b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0abc4d04-e557-58b6-e4bc-7e52cfede4f0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0b0eee80-ebc9-0e27-a0d3-4124d340c71d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0b13de7b-3a06-5d38-eccf-e9bb8db4be94",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0b8c5e9e-5f59-32f8-19a0-b9e05ef5e471",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0bc8e3a7-1aed-9f32-20e8-ab95b541caba",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0be92ebb-39d3-323f-c309-af2cbab9b45d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0c1cbf11-dddf-ea21-7833-1a99cf78dca5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0c68876d-2d68-d530-2757-956294ff1bed",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0c81ee88-383d-927c-6006-4e96a8d886ec",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ca13d95-21d4-4344-4fdc-3f66b69dbcea",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ca55a2b-4b81-c691-b83c-cb46471e0616",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0cbe619e-67d3-8823-4c65-dec3ac8099dc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0cbff9d4-4613-2d77-f1a3-6e9f4238a87c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0cd4c552-ef7a-3da8-74d3-a0393d836d30",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0cf2cc5d-7bc0-f1d6-49b8-99c8e5afc22b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0d323073-926c-387a-6b75-477f3b92ea32",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0d5335ac-dc82-6607-9000-ce5fb7df023d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0d647b97-8742-6f60-67ee-364224b37cd3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0d9f5e1b-8b16-6512-1aad-b6fc5bdbda7f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0db5aa4c-b64c-85d3-5b73-cd92292e43ea",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0dfce57e-1c19-b29b-f7ab-cd26312b81cd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0e09a6c4-a5a1-ce41-7427-98ad5a20a6e6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0e69e155-7e89-ecf9-0898-eae3fde0a324",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0f278cb7-49d5-fcc9-b743-6c6f611b8aac",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0f3ee739-6e6d-b37c-3e2c-e659b8890a09",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0f702402-059d-f301-63c5-f10eae2added",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0fc4bc8b-3404-5c3c-c5d7-09b74f410c03",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ffa3237-44c6-cbc5-cbe1-753b3c1f3f53",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "0ffbb5cb-67c7-7591-771c-7e61e0be9564",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "109e11b9-63ad-7b2a-f996-09c4ec8a2ddb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "10c6170d-a542-dc14-754f-794aa16ea0cf",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "10d1bbd1-75e6-a8a3-c89e-ecba202d1271",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11065baf-e680-3a0f-0ba7-1eca5f0d5203",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11182c03-8ce7-41a0-f2c1-7ecfa75f99a7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "111c4df3-ceba-47aa-1a5d-c7d24b08f76d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11219807-2307-1246-8bd9-cd76bf2b52ce",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1133eac0-f2b9-5576-b0b6-bef1f79782c7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "114acc04-a14d-ea71-5c54-bb541e5bb9af",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11a47728-c8f9-ee9b-363a-3a89d6c24797",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "11ac6e88-a54d-0fb7-d0af-0368bd55f51f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "13000bbc-8fd6-1578-7278-d709f023eed3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "13665640-d5be-7545-5e75-b567631717d7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "13a85b72-767a-1cfd-2772-a56d405675b9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "14371330-5831-44bc-b927-34fc4f913bd8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1452324b-c53c-15c4-079f-4a2000e03019",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1452a1c0-db9d-3a7a-f9e0-7f084ab80c38",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "14594ac9-3b25-cc82-e23a-685226c86538",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1491b2d9-7dbd-4050-013b-0d4c38aeb869",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1497fba7-91b9-0f9e-413b-a1a7a9487f45",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "14a89b1a-19ff-ce17-300b-e17e3bd1077f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "14cf4c2a-44f5-3e25-70c5-a8ad8fd3e3b8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1541dee3-e76c-2918-1744-06067e21c1cd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15ba8680-1073-bb6c-6f10-054644dff3ca",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15c2362e-1b5a-491d-5f6c-db02bc21d939",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15cfd3d2-8bc4-c1bc-7fd9-d3de7f5d669b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "15d70dbc-6c98-76b3-999c-21437cc800e5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "165b9f17-2130-1b34-da4c-1235fc6ec986",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "165be93e-3f49-13b1-427e-af18f7d6db8f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "16a954b2-61f0-b37a-7693-a0b61d5aa2e7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "176b9a55-95f2-70a6-0d8a-c46a6f228bea",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "17a6c3f8-2b19-7397-ad33-b2feb16a9099",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "17ab550a-68a1-728d-c3c0-64c7bc72f3fe",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1828a070-068b-a95d-05bd-97d1aa5306cf",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "18293f33-cf24-6dd0-fea8-750eb629c0de",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "193842d1-67f8-7b4a-04d4-8ad3f57b6cb5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1938cefe-5dda-eac2-4a89-86d4cc2bbb41",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "19861494-33f0-13d8-932c-2acfcf2fa18c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1991eb73-cae3-7444-3c1a-3d87acba57be",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "19f2fad4-a69b-5816-5671-7dca8e1f05c3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "19f8d59a-321f-7873-3ea4-4c981946832d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1ad7828c-e3fc-0069-ba6d-6413bb488575",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1aeee50c-ccc4-bda1-52a4-8d413ffe2055",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b0c902d-ad55-90ab-57d4-16427ad6c740",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b1697a9-3a2d-fc57-4a13-6eb57d67f819",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b18563a-1928-a0b5-9eda-0ef8fb473839",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b37d5da-f4b6-cbc0-bbc2-8fee0570e9fb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b469f60-28a6-bd81-827d-cb90da561d66",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b80b598-780b-bea4-5a24-19940d4a38e1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1b84325f-12c9-a783-29b9-032c0e6283aa",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1bbc66ba-4b6b-7bf9-811a-aa8003d6db9c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1c4cacfb-dee9-07de-5cbc-d5ab91b33773",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1c9c63bf-825c-13f7-fa0e-9f0699f61ecb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1cd5ed06-8055-c77f-14d6-607ba085772a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1d041991-5f0e-c23a-8999-aa6d5e5cec41",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1d551b56-0c89-92ea-bc4f-58b3b9bad9dc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1d78c887-7aa6-132d-0217-f7b43b77bdf8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e1026b2-758a-9beb-93e2-fcf2b936ed82",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e356af5-9fbd-d306-bbc5-eea3d0b204ad",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e3e3715-aa40-0575-a36e-ef450c9b5da9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e5eea31-29c3-bc5d-2667-842eff3b544c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e6bec97-4c0e-5908-667d-688e7511f7c4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1e95312c-bb54-5051-1d8b-87fa3be05371",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1edd5504-cbdd-721e-c3f8-b14406688ec9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1ef93c61-327d-3b0f-db94-04acd6213a5f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1f060a0e-833b-9361-4a59-0ffc6ca53af2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1f0d2ada-0af7-a1a9-d34f-e43e47f0979e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1f87bcd1-4567-9f7a-a2c7-c8251419643f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1f8a6626-6c38-0826-4f7a-1fe34136607b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1fb7b886-b13d-200f-7df6-7ebda0de9ccc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1fd5f3c7-4c47-19c4-61f0-665a537bec8a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1fef362a-d1da-0a5a-84f5-8ae89094daf4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "203aa879-6750-f0f8-e036-86cdd107e764",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "20bc4068-6c4b-48cf-0ba4-b953363e5612",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "20ce0656-3d5a-66ab-6bc6-0e90ad09655b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "21ba83f0-c8cf-756e-d382-667683820599",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "223a8207-25d6-87ed-d8df-1f94d1643ea6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "22c1caa2-aa3b-3e37-6efb-8fb7c07f54ca",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2310c342-bed5-4b9f-eba2-02e50ce02e57",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "235b3715-edf8-71b1-9850-c2f6c754d99d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "23a6ab3d-60bd-4148-2d32-cd648026c5e8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "23e9499b-6128-466d-0897-a5ce91f4b27f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "242b487a-a475-5d9e-2a03-0165d13def70",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "24716457-7da0-153f-e697-5e69fd4f68a5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "247dc0f6-eef0-6e27-4369-628fd9529420",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "248bcdbe-1d25-60a0-8656-ea43b2f22920",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "249c0eaa-9905-1383-8fca-affda7f85f7b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "24b13c0b-cd96-240d-8ff3-07cf4869adf6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "24bcccd5-f382-001f-3b8b-a41142e49777",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2592466e-b4d4-4655-9eb3-6de7071ccf75",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2593023d-cd4b-3a13-8456-8605799c009b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2599f89e-0977-b58a-0539-f65697c1c75f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "25ca8467-94d9-d697-0db9-bb34a8898197",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "25de3c2e-a93d-53f8-6982-c678ad47cc54",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2605d9e6-c136-20c8-1831-a1f1ffd05ec7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "26e71ee0-59e5-f793-1413-af5ba2a87427",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "270e2f52-215b-943b-b615-1e38fb4c7556",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "27157c99-c60c-e69d-0cf7-6d49797717a7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "27347831-35fb-67fa-ab30-fe2735abbbd8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "27716c75-581a-0d58-d5ab-87df37bf11e8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "288acd27-59ec-b9f5-160f-bf6e569dbf73",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "289a7bd2-5839-a841-3c7a-6cd2cb327c1f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "28b5dbc2-f5fe-d1df-1276-f0264e5fc36d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "28cc2966-659a-7c43-550d-d3e856e6eb75",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "29b71050-1d78-d4d7-0445-b899e17f1db0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "29f09856-4a06-7009-67f4-1b47f3735322",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2a77192f-3516-2af5-1c2f-efb27ff44dff",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2a81166d-6b54-e987-5809-652afadd1182",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2adde9fd-954c-932b-bf95-c574715ee59d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b072eec-8afc-2975-cf37-acd3112a3d9b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b1ce470-481f-5868-f4ac-26e876e4d79b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b31955f-a738-1fa4-4987-be8592ce1b8a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b44db07-ee64-2813-e9fa-ce30cebaf996",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b487ea0-27ba-1111-671a-8ccb8a808f19",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b56efe3-8b66-93ad-54b4-f5517a0c3cb5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2b9b9d22-41a9-95c7-6b24-f4c5298461af",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2bac5ce4-8231-3998-2ea3-87b0bde58d1e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2bb47397-839a-9256-9cb2-7ca19bbe6f6d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2bc5029e-ee0a-db1a-2963-e27f328bac06",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2be3fbb7-603a-37b8-9886-8cc179a60c00",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2c5e7c40-eda0-861b-ff60-079cbd28d62b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2cac977d-cbd4-6830-a4c6-2736101a2a7d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2ccff467-3ffe-b229-11db-213c0682008f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2cdc1759-9120-bd86-70c9-29940340600c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2d665373-ba63-11d2-7115-31a5237bae96",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2d9a3c10-b1dd-f004-0f69-2e3a4bae5c5c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2db3f185-97dd-9f4e-3813-f595191b3ef8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2dd686c2-90fb-215c-484b-6abf33d7f0f2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2ef053bb-a426-74eb-6498-47e542671a5a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "2faf2f20-145f-cd9c-fcfd-afbf11172030",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "301879b0-e7b7-d685-5fdd-159039ab1c6e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "30cfbc43-c39f-1c34-2f9b-6d3ba13b0491",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "30ee3b1a-608c-9029-ef9d-8dd126d7f341",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "310d584e-ee15-57c7-df8f-f1c01f89f816",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3149b3f4-1518-8b57-abdb-7e08d36f7861",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "31684066-8ff8-ec8d-d574-7994a009b471",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3177b094-26b1-b068-a92e-12b1ea020c51",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3188ef65-4dde-15ad-a99a-83fd6b6c05a2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3211d60a-a2cc-4aae-e597-0618dc72fd91",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "323b5584-bd42-9b8b-ca3b-7683360e02ad",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "32508cd9-8a12-0bba-b62b-aa26d542bf43",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "325dbc6b-3915-11ff-5664-566a43aedcce",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "32b099e1-a3d1-4e0f-9e32-56ec913b08fa",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "32e0e5ec-8a8e-9958-11b8-3e1fdf2c9022",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3314a49f-fc9c-d196-f080-0c1e65a5a038",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33312525-f896-88de-5e90-c76df14354c5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "333a9e97-7b22-78cf-a2aa-054acbed29d6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33629096-47e0-4ae4-df4f-b9b15bb01a06",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "338ef414-55b6-57f8-6cbe-eba50b6858da",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33efd6cb-b6fa-3383-51f3-b5ce1564e043",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33f0f8bf-b751-8c08-8a5b-e17c5202ed70",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33f920d8-24ba-7fe2-fbe5-526c65aa2bdd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "33ff2701-91f8-d78b-7a7d-2e8699300904",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "340655f6-6a9a-041d-d548-9f80b12ee00b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "343485f2-93dc-aaa9-691f-56d436492103",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "34589856-41ec-1fe4-bead-01c2aabcc0be",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3466fafe-c40d-640d-c381-e20bff70199d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3467ad0e-4caa-a9d4-ebe6-b07c78d758be",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "34dcfbf0-bd44-0123-ea20-2bd73d504f1a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "354a73fb-281a-99ef-71f4-9ad6a1e08a4c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35769633-5a71-b8f5-cd23-34959e70feef",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35adacf1-d9c3-d92e-2f59-fd496b6a14db",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35e71e41-a081-6192-0f17-52d5393f92b5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35e80a17-a920-4848-28dc-7e49a1b1d450",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "35e93169-58a9-c08d-87f1-0d1c042b0251",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3617723f-5fa3-13c5-747b-af12024e1739",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "362f0228-aba7-6c24-8de6-b0f8e8f0fca2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "363f0139-5ea9-5659-b4b6-d31f10c6e1f9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "36be623a-fb8e-cd56-cde4-c36170c3cf97",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "36cb5434-204a-2ad5-b1cf-9a6bd9ba6770",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "36d84ce4-f349-afc4-6458-0cf8242cb742",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "36e83abd-b95b-2bff-8076-d432a0d126c1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "376435b2-4f87-d45c-9d3b-0f1a7fe26993",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "37911dff-a5ea-8f4b-e8d4-4de521d88fab",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "37b5538d-83d9-db1e-c957-873f1f52b8e1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "384a335b-ead6-a595-1afa-792fa5f1d8fa",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "397f99a4-3024-f200-35b2-f51bb3d1cf79",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "399b3fe0-a8db-f30b-561a-3eb2fa5d587a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3a0dc032-1305-74fb-e0eb-b5d26843dce0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3a184df7-7d52-f9c0-8fcf-d65d15495f27",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3a67330d-23e1-7ead-b469-1adf44300612",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3aa7cd04-b4c2-cc6f-b69c-a73c4dc31b69",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3ab9aedd-197d-0954-7869-508b7381ec26",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3acb1297-0683-abbf-a79d-69f0b1ad4148",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3acd0cbf-4f81-b141-b5a4-1deadee54db7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3ad232de-dead-1de3-4ef2-1a7a1bcae815",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3adb884d-00f4-7452-b153-172589985de0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3b42cda1-04cd-5377-70ca-5f9c09522015",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3bd48e65-a546-53b8-11be-9168f9315439",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c122b19-bfc4-fb31-c031-d4b1358f661b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c384aff-7c16-316e-ecdf-de092cb63839",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c4db87f-2c67-8431-5028-cc295a2e3087",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c5a71ba-2254-b3ed-67ec-f64c0106c660",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3c94d190-986e-a736-87ca-6787d693212a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3da16659-e34c-a32c-0e88-f464e813b606",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3daa9c94-3bcc-6c93-feb2-3993755d253c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3eb203dd-c874-2718-a2a0-3fc6a3d7ceb8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3eb63cdb-d52f-72b1-555a-1bc3287a6e99",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3f839a52-c325-f2fb-b74a-c0f31808b557",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3f9e18bc-c609-f0d0-483b-5f0556b93e84",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3fabeb71-515f-89d9-ecf0-4d6b037af7ae",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3fd7aae0-706d-4df7-780b-8c5cfcb6ab66",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "3fdd2de5-bb97-965d-f358-ec57017062f4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "40117d71-595a-6295-3368-573796c9d3d0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "40137d15-bd16-30bb-80eb-aaabd3357137",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "407db42d-79bc-62a6-64fb-a6ab14427749",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "40ced4d1-1d5f-05f9-1ecc-008ece9bf6cf",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "40e36724-7177-87ba-60aa-341036c6b39b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "412ef48d-01be-55ef-5ebb-4a78431136ee",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4130b3b8-0f16-7f94-ecb6-b80ac3484799",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "41423551-0d9c-1b89-9f3c-278ac6132d5d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "41642e34-9703-f9d5-55bd-7ac4c5079cd9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "42046a6e-e4b1-6bd2-f0ac-7fab8592bd81",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "42106e06-e42c-bd1e-46a0-67b8b2b6e778",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "425b45c5-3bf2-b3cc-a8fd-011c300c5b6b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "42731d85-ee9c-0bcb-db2a-ad4c0139f1c8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "42c4e64b-5f37-7428-68d0-ae73dd07c550",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "43218475-c208-8bef-45bb-cead9439d8b2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "43370ead-9fca-c16d-cee6-46c82788d337",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4348c7b6-2fba-b089-89ea-ad326215028e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "43dba54c-ac20-eaf1-aa78-e5651b270a61",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "44800357-71fc-c57d-1016-c7b84070e5c2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "44aaf7b1-791f-8f82-c0da-7ebb41fd7242",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "453afb2c-a5b5-3cf4-f188-1fa95fc15824",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4557c67c-df81-999d-af4c-0c484bf21983",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45677706-dac8-31fd-82ca-b5df09b381cb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45af8d84-cfe9-7ed6-18a6-0d89016bac6d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45ddd76f-2146-20dd-4044-b056b0e89930",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45ef5fb7-f21c-293d-6e77-44f359cf722d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "45f1ab9e-4cf6-ec9c-2b17-9c7adc6a6cc6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4655bd8a-abe0-ed09-0f95-f22d7f8c4bfb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "47a84f5f-69f6-8c41-882a-0fff04c088e1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4800826f-b48f-aadb-b458-46bac3bc0611",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4861c780-d273-deea-e35d-cf133bd5d84b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "489eb465-3148-2790-459d-d37743bc1fc9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "48bf7f82-1ca6-e351-83a6-20588e74f9d9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "48dee733-5e65-095e-5b98-ad2f3413f250",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "48f9091e-884f-1bab-5878-b6544c8c0ca7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4903fa5b-de46-5fc6-a28e-0f0cd0ba7c7d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "490f3cf5-28f8-dece-4922-52671fb4a199",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4950a765-76b9-83b3-7de9-af0e949338d0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "49a1f7aa-8859-4cc4-b546-4549f789bf3f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "49cbfa48-c9a4-d8f0-1a8a-1191d3b61d23",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "49ecaafc-2f2f-0847-81e7-c35e1457f586",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4a0b0ab1-e8fd-2434-c11b-1eaeb07577de",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4a1350c1-b7cd-0abf-d114-716504b16a7c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4a9e4b89-4361-e36c-5dbd-676385437cbf",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4acd9232-d4af-fc54-d001-272120ba0f3e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4af77d70-a98f-9201-b485-970850a53a5c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4aff05b1-2e8c-eb11-a7d0-dc28213597fa",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4b064eb6-10c3-39c3-883d-0424a8ea810b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4b3fa2e9-13d6-815a-1991-3379fa24d213",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4bb433c3-a8fa-e9a9-f04d-6d14ec42d99e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4c06ca35-0b79-9303-ec17-10272993b89d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4c6b6e9f-a614-de54-097f-4c095f09b343",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4c74eddf-31df-3d9c-e01a-935aab29f802",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4c7ef4e4-6089-5b54-70cf-462a7594d3eb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4caafe08-88b8-f527-d617-30c43c95947c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4cce25cb-d6a8-8892-ccc2-05059e6a6f16",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4cd5f36a-93f7-1b54-cabe-8128f0dfd674",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4d46411f-dba7-37ac-8814-c7da719f6e3b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4d6e2979-5e0f-7179-fc23-21591767c6a0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4d9df844-c4f0-ce33-a95f-e2649dbd9854",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4dd2b11e-e285-eba7-7e11-217a1f1a5016",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4dfa6633-4102-2dee-0768-2c3ef94f351a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4e6ad58e-34f9-3aad-d394-6c22e98c28e6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4f1f9725-101c-80f7-d008-fcc9271993df",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4f38e6b1-dfdf-7780-0780-cb4f8418ae41",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "4f96e085-90db-e38e-531a-45f6abfbd4b5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50278dc0-3ccf-66c5-6639-d8cf2c3a45c3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50385077-0e40-cb7c-79ec-81004f9f179d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50a492c3-36be-2556-07f7-c1fda62c78c4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50a9ba02-e020-16d3-df51-fb9c4b19bd0c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "50f1a91d-4f22-2c4d-0480-c8e86f8ab6ba",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5119b0f0-763d-45e9-dabe-2e015463004e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "517524cf-4d05-9889-8a60-d07b7a0f367e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "517d614e-6c9e-a398-06b0-84ea43f5fbb1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52255222-934c-c40d-8d7f-7c438999b75b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52337c23-7694-cbf4-76c9-3dd7f121c476",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52659ecb-a874-76cd-e727-9e93c72dd9e6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "528cf0ef-0ad8-1440-1a6a-d89ca66b78ef",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52c0092b-3071-650e-6b40-8244f7ac1aef",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52d399ad-652e-4ce7-48e7-3fa9dd24c080",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "52fbee5e-6035-a389-1fd4-f2baa360ea71",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "53238bae-d873-e113-c07b-94f7384f2a4e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "532a40a7-77e5-d8ad-e9d1-5ac05b8f1fb5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "535ed2b9-1619-fa69-a7d6-d003ca7cc32d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "53bed5c3-f54e-2f3b-5ffb-c3d75fdef22e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "54525cf0-f107-52d9-4701-d3383da2ebd4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "551de7b1-1efb-00d3-f4ff-d63b63ca6e0d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "55803d94-5a30-5537-708f-9a29af0bb608",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5582813a-cf75-d0bc-d6ea-164333b8f078",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "55c095c0-7bb3-4b1a-b7da-0ed8c7aae43d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "55db5c7b-8e15-4375-cc5d-227a06438d38",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5614c18a-417b-4621-5dd4-a17203b6fd57",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "564788db-7533-ad1d-c822-688c966ea182",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "565b9687-a776-3cef-8994-bc338c6f1895",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "573e2677-41f8-31b7-9951-eb1100b2132b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "57ab359d-3846-c2bb-ed46-058d12813eb3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "57be9b47-7cba-8ebb-640f-e274971152ab",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5826bd17-eeda-6222-b4d0-8506d1ea4f1e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "58a7df68-456d-7aa3-efad-177a80a25161",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "58ee5b4f-5255-02ce-b2d5-07a5c8ca7673",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "58f82817-6b56-5845-ddcd-66f0bd8d2507",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5928a75b-88dd-4a5d-ca54-6d5bfaeab6bc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5949817d-4426-d92c-eda5-7bc93010d7e7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "594df6b5-390a-e031-8c8f-ec7beecf5380",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5957a8bc-301f-1380-2254-00291df2e665",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "597d6d71-d02d-d972-6906-47dd94af9989",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "59c71829-01cb-a709-8f65-a8cf0f64dc53",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5a62f7f4-969e-0b36-2084-91de9f91eb34",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5ad840f7-830d-9cc3-11cd-89d244507f8e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5ae81cf8-1483-9145-cede-a1d072e27dfd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5afcde0e-518b-b54d-5cbc-9d0ee6d09abc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b05b08e-6f73-e22a-e582-c0117147df20",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b638516-0759-9513-853d-bbb34b652783",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5b97e945-8f27-29fd-ec32-62918c44a2a1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5bd1054f-c06a-0ff4-2abd-fa8f91162e23",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5bd766de-0af8-d57c-839b-1f71e24d41df",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c070507-4cfc-7437-9688-8a3fa0311229",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c094776-5acf-2f84-62b1-e51885ebdbbd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c0ab620-2b3b-61a8-a149-bf9a95ed8c03",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c440b1b-c528-b1b7-ea36-c8c51c52f6a9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5c67d3c5-f64b-9042-df1c-37f8122fe8e8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5cb76838-2148-bb64-3c35-e732e56238c5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5d8585f7-072c-3acc-02d3-036830d0eb38",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5dcdfe18-06f9-b671-59c0-c7e656362b2c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5de5e483-bf65-3751-6439-ad5bc91a890e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5e21308f-4214-8f32-e85e-871599e6ea4f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5e5deff5-dce3-e6a2-8a29-aac24511322b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5e723d74-3882-b8f0-da81-d00da0032a50",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5ed13f71-f910-0a19-70e6-0faab831b589",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5ed55ffa-6d07-4409-9736-539634c6519e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5f1cbb5b-c8cc-7cb9-7692-cfff312ba139",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5f1d392b-0667-4d12-0a56-37baeeb0c07e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "5fe273b4-6a9f-14d0-d400-f08ffd526565",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "60262794-ee53-dba4-eb1b-246ed566d3fd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "60472859-d8c8-a48d-4c3f-0ac18643491a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "605d659e-d34f-bd06-e1d2-4bbf5318d9a1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "615d8d49-decb-4eff-c9c9-de1e24273327",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "619c84fd-6150-21b7-bd5f-a666274bf036",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61a2c1d3-96fb-71aa-55cf-33c674680627",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61a67da9-b7bd-4555-9cf8-c6341152be1e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61aa8a00-ffc8-ba2a-7999-86e7ab9329be",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "61da36ee-00e0-0352-ec61-5f9548d15e87",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "628d5b85-fb1d-3be2-1666-dd4ae4465c58",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "62938ab1-4fd0-e0fb-b4db-53f0c3b577bd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "62fdcdb2-318a-1eaa-c2de-ed7d5eb26b05",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "631019a5-52aa-5f92-b516-9f02ab27fd0e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6310db55-a6fe-ae83-48e1-fc37011d4eee",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6344f8e3-c5ea-1555-cbac-9e3b7119042d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "636bc089-f22c-d241-d427-55e90deab83f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6381a78c-fcd6-d0a1-c4f5-09323d5ec98c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "63c687a3-67c0-9d3e-4bda-fc7d26ed4e96",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "63d0e165-8c30-09b2-576d-a0517c4317d8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6421d373-2d22-5d19-eadb-7e134fb1514e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "64232e02-58b1-49f9-ed14-4ed2bc2cca29",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6430ecc4-8bfd-8a62-c7ff-1a819c81ab12",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "64890546-473f-78ec-18bf-42d299263657",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "649dd080-3292-2b16-97b7-60ecd19a904a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "64a414ca-6f58-a78e-c856-aba5693b7f85",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "64ae45c7-d78f-ee6d-73c9-f4f9332e8811",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "650b7207-a5d4-bd7d-fe95-4a204c5e1f01",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "65112f17-919e-e28a-43e8-66e00db57053",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "657a5804-95d2-bbc9-e3a8-cb27991a4ff7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "659905ce-facb-f42b-f4d6-ecd3d6706d97",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "659b5c09-04de-fbc5-5d98-c280c5e543fb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "65e2490c-565c-d5f9-ec8e-2a2b48a9c11e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6634a192-1867-c0b7-3d6a-f40e9451b92c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "66fa9dea-3125-099e-2915-800b6c650d6a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "67ace8f4-0f30-1cd2-b6ca-071e23ec2cba",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "67b95201-3952-6712-2715-889888ee7c95",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "68043ff2-95b0-99fe-0120-ed51205672e6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "68197b26-afb3-63db-fdc3-8ab2d84279f9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "68b4d308-be73-447a-aa01-94326f1d8573",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "691660f9-12b9-5e11-9261-206ceacd9e36",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "691e9c06-10d6-afd3-febd-fe572554fe00",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "698fabe1-43b4-9c65-86f3-65500666149f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a26bb2b-10b3-d20b-576c-06ec7eb6881c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a312723-378f-452f-ccee-cc8c2ce7a27a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a3a2ef3-ae9a-b881-f025-d9d175543545",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6a4b6dc5-d135-c9c8-6a3f-fd8e21e92ecf",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6aaafb5e-3b19-91f7-797c-e91862088611",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6ab02906-d2b9-2266-4136-3128f38d5164",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6afd119d-e28e-92e8-9e89-1af6996f754c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6bfdf32c-e8fe-bdea-51c7-38c5b5992127",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6c176ab9-ca29-361a-d27f-4b7f010acd63",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6c37f867-5e6f-aba4-91b9-2db24521f2f7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6c73b437-0d0e-1091-b034-f182d80f695a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6ce3d657-e3d0-f6f4-b29a-e5144ca560bb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d007abb-5e1b-17af-b0f7-2c47514aa643",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d35848e-614b-c210-ba42-5c08c34d2f65",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d5a8c03-1246-423a-3765-15c893dd78d0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d5ab6db-8f30-6091-2cd9-ea7f969fcbff",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d69d35f-822f-3f97-7cb7-b3d3e83a8517",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d8a71bd-3b1b-2819-0f1c-7c6f1615f245",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6d939689-22dd-f3e4-a21a-3c69ccfbf67b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6db8b590-545c-5247-9e1a-c51a90a3b619",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6dd43e6c-86b7-54bf-9bdb-5e5ea47a9faa",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e049a5b-951d-3381-65f9-bc0fb565cf54",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e46aee9-cbc0-b0ce-c256-31361c943394",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e67b748-ff2b-dba8-5308-a0b92b14a1b8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e7e7ad1-76f0-2a98-4e52-aad698b8c7ad",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6e9db836-8335-157d-2b66-184effda711e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6eab02e7-1426-0881-1c74-99cbe1c2dabd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6eeab54d-48f6-9f68-1ca3-b7ed0c89b7cc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6eefda18-8285-6969-b21e-451d7bd76697",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6f1680fa-747d-53dc-d2ab-105243a1b1cb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6f3d10e1-f4dc-ca79-50d4-821d2875c8ad",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6f546c47-26f1-7ec9-b641-fc447770b8d5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6fb07aea-339c-0332-ca91-4987f543bf5b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6fd6173d-eb18-e8d7-405c-66721548558e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6fee2eeb-59d2-0c00-9a1e-8a30811ae17f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "702ad6f4-0053-c792-b343-3b85849c4fdf",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "704c020a-6dcb-018e-ce54-64db11060b68",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "706afcff-0cdb-6977-d5d9-770b0d8252dd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7094d547-fd86-a3c5-b337-839b1e5c317d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "70ee2824-090e-3fe4-2794-10f0c7f3f893",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "70f7cb1f-f577-22e4-c388-755432d785ca",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "70fb017b-27b3-32f4-e15b-031807d3041f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7114d482-e272-ec02-9e73-d02be9daad85",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "718c2d6c-578e-b7c9-1e8d-5bc67c063ea5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "71f57d4d-faa9-0cc6-82c1-fd3dd9f6c1c7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "72266131-6cd1-0f73-3a4d-fb15c51f80a2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "72a781ee-c6f9-c7a3-a6bb-dd39961e522e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "733a7970-863f-19e0-960b-550ffd7ebfb6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "73532c4d-af3e-83d4-8425-4cc26ab37aba",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7354251b-296b-caf2-433f-8b6ba2905cbc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "73aa21b6-6e89-d724-606a-ff4a561441d6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "73b44f51-5601-290c-5594-135cc98de227",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "73c7563d-39e9-4606-310e-2e3e31c378c6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "73ef9028-ebb9-10e0-b568-0ab21799c6da",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7418f241-6776-9e6d-a053-48ac126562e8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "74547088-2cd4-0ff4-8bff-433423e5485a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "74775c4f-426a-3783-b04f-ccac0b514278",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "749b811e-fb13-4288-9280-1a0ac6ae1357",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "74ace139-e992-d91f-4671-52f639972753",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "75a4e70d-830c-2c84-3356-f012e00406b8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "75d76d46-7571-e18b-fd80-49ee8d62880c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7600bbe0-0a15-349a-b9ec-c475880ecfda",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "764f2bb3-6cc5-14e4-6520-336d80427992",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "765a6d8c-c0fe-7187-2aa2-2346375627a4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "767d2088-ae6e-01a3-af51-1f15e4010867",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "76c7b55e-03e5-9b52-34d3-5a7ffb9c90b6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7755d2e0-e594-43f6-6b2a-97e09a800704",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77584882-18b2-c070-5e41-8b0e717367db",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77a22aa9-21ba-43c1-f6c1-a77408c21ec3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77c5543b-1580-7852-0a87-da9c7abcbbbd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77d7f16d-5ae4-b603-5a85-8890f1777158",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77d8f4d1-c71b-c484-866c-ad2bbcee8d58",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "77f874fa-2a1f-f514-bfce-3249bea7bc6d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7808c1db-a570-ab1d-bbf9-a18cb5faa033",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "780e8022-e459-3d7f-a36b-47992b26ace5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7872c32e-8849-26d9-8279-dae0014cea81",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "788469c6-d6ea-88f6-9d4d-2e8a0b8595cf",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "789d8ffd-898f-2aaf-f340-7783135e9a27",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "78aaeff9-5997-2b9e-dfff-14892277163a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "78ecaeff-34c8-c97c-b69b-0c6690b4a848",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "790b09e5-5227-33d7-cef6-21f1a8781425",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "790b2537-789c-2d30-aa17-fddb3dcc7e87",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7978f9e1-f848-3ea6-bd32-b7ed5c2ba948",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "798ddc1c-e359-941e-9460-c187af5e53f8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "79a2515b-c784-5fe3-20cb-1548b67dc9d2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "79c2c8a5-b015-8ddf-6df6-251e26904dd1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "79e9a30f-cfe9-2f9d-cac4-f86e3962d70b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7a234537-baf1-3524-b7d5-0e086755bc47",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7a29af3a-374b-0d68-6adc-9c128bf68f2c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7aa3c75d-1047-67fb-2ace-ac1a1a10d694",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7af052a9-7122-b61f-8b11-5da686e42f4e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7b197240-8dc4-4b9a-bffc-03041ba80ac3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7b4684bc-9aaa-ec77-cfca-3e170f437cd5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7b74c4aa-8c1c-1d43-85aa-3121fe4fe06a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7b8b3263-39e1-5145-8a7c-922bed22cd08",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7bccd9ff-6129-4373-38f5-54b69ffa2532",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7bcf80e6-7fe2-ee24-8917-ba84ceac6c5a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7bf67481-3314-0261-b2db-78df2fd64956",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7c202e76-1853-732e-dcdc-f6e289162c30",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7c49616d-c28b-639c-b997-9247505f7659",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7c99bc64-53c3-b876-5543-b8721c0c8a16",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7ce29b8b-2433-0bb3-0654-d50cd8f1c886",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7cfb27d0-bb0c-81fc-f02b-7413a98009de",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7d00f71a-6a3c-8b68-5e9c-fcde4ffa7c54",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7d2fcf3c-c09c-4be8-846f-685bc9a41b10",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7d8f0718-91c6-2cab-268a-090d429358b3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7d9ad1c8-2f22-2da1-d373-f6781481e17c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7defdd5c-80d9-8643-cc16-c5adc0cc4c1b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7e4c29f7-67f4-b4c5-da5c-c943f154140f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7e81993e-6a54-b9ca-8ca1-a5dce75296d9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7ed7d5ba-b85a-94dc-e41a-951452adfd76",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7ee8ecf2-a327-72a4-39a3-f550b848e994",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7efbbcae-7986-422f-1648-599c8cfe7a32",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7f73fc92-af72-477b-9c37-49b6779a08db",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7faf4a2b-6a73-9282-20ba-8a3719341d59",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "7ff81ee8-300d-ddc6-319d-7dfa7218fd58",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "80c3af1f-291c-f372-0d38-df362469d385",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "80f54d52-7c1f-5ff2-d278-d08cb6fbe663",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "812aabb2-c7f8-2548-e7b2-c7c99cfa0b51",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8158f792-971e-e8e6-ba64-89beee817448",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "81a26782-c24b-32fc-fb34-09efe90725d6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "82854779-bd50-0aaa-177b-dbe72002170a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "82a38202-4f6b-41d9-11fc-0c59d2bdb4a2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "83518af5-9c7e-aad5-b0fb-0d174cb1a74e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8364106c-5f3a-598b-2ac0-3ed214205fef",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8390a9f6-0a93-19fe-59e1-f9f55f5ddd6c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "83a735ff-5494-6d25-e97e-1be7ce62985c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "842306fb-458c-d097-eed8-909990df3d1b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "844e7674-593d-adb3-1440-7f2a1fab57a4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "849b1616-601b-3dd9-557b-16d80403b1dc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "852e46ab-b00f-8054-4ee1-5649cb845174",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "856171a7-b9ac-4830-b2d8-9cee3fdcade6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "857d4bd4-f8b9-a253-5f74-06ed5783b8cc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "85e1b30b-426b-ad04-17fe-fc152cee3378",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "85e9cab9-5ab3-16a3-f659-b25df501f9b6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "86096d2d-028a-2178-b93d-d09c58fb798a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "873dd793-925b-cf55-c4ed-19f5ea134c5e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8766a212-9831-5865-4645-404c346353e0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "87a71430-351f-537e-026b-c5b519494fd1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "87e48982-f0da-a5f3-0b94-9ea581b65f84",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "882637b6-a3e0-c6f0-5adc-323fbaf06469",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "882e9f04-341b-9074-4919-525657521655",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "88e3cad7-af87-576b-bb83-de3ae351486f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "89236d18-091b-053a-c75b-c954fd17ee0b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "895409e2-f453-7a65-bb3d-25c0b35987f2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "895ad2cb-c1d9-f871-0b4f-6d588817d0a2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8976f83c-4baf-c2f0-376f-a1e360cd7ef0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "89af6c7f-eb9b-700a-1edf-c780be219657",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8a1b0119-fe28-9d70-3d44-4f08f1cc15dc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8a6cc122-2f10-d00a-54f5-d2ac0bc48657",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8aa6d384-bddc-d1af-b54c-f4cbd87e1b21",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8b4e0e39-d22a-6b9e-f265-f1e56b32a5ac",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8bd34289-d07c-921a-c6cd-bb4b146fdcc3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8c563a6c-a539-9b23-d004-3a0ef5546057",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8c6aca27-a8a8-0c0f-1002-e52f6eb2561b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8c8d06a6-6fdd-1dc7-20a0-b47fab0ab94a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8cabb15c-08a5-3226-7620-6b7fd82c0ec5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8cc8c34e-a72a-148b-03b0-f8ee5fd74ca2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8d189383-f0b2-811e-27a7-413d45d77bc7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8d236de0-d974-e10a-d60c-6eb6d6ee45ba",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8d39f934-18e4-6144-1d94-ded1104d046b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8da9b865-ec75-e977-9c4c-609e2b0b4bbd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e09b870-6631-2b58-4357-c8e2715354f3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e209ba0-d4c5-1bc4-1217-b046044b7cbd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e772a62-3558-8178-332b-ef9bf71b93f9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e7a8865-e1aa-c65a-3f83-fb8382e84b73",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8e9adcb0-97f0-f605-d063-0d6f594f51ba",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8edbb040-f6b6-44c8-881c-6d2a3d8b7775",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8f187890-6338-7017-fcdb-cc73df76c12c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8f6901a4-f5b5-e843-e991-5ecb27c6d119",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8fce3dc3-2a8b-c124-f96f-6798c213bfc8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8ff68495-91b6-7636-684d-e74d8db1cef3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8ff891c5-6be8-cf4d-c081-c3c877e21d1b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8ffc693b-16b1-8101-db46-047a98051af7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "90ef151a-2989-8953-bd19-90dd0821143c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9142fa69-f76a-2c3c-9edf-e1ea105e8777",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "91484a1a-e66b-ea1c-e668-ebda717c8296",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "91e6ee14-7d3d-ee2a-2bde-63a3eb189429",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "91fc97eb-284d-bef1-4eaf-5747976f12d9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "920e03ce-033c-892e-20e8-77ddbceea7f0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "925fc124-3408-8dcd-0b80-2ad17a2218d2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "931bb5b1-8d67-df23-2e78-3b0217c0f969",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "93214a61-c357-cf55-06ef-5783ca945672",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9343be38-6a9c-9597-308b-b7a380d3341a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "935c4906-2965-0faa-073b-4831ee9f3c48",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9393cf6b-216f-c5f2-04d3-406717d50b39",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "93acaa36-b84a-93e3-4ab8-bee3839813c8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "93d0406d-f2df-c05b-dac7-dec3c4a393cf",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9419d91c-fb6e-946f-bacf-338bbfb69b57",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "943d07bf-bcbe-a81e-c8d4-d99669e31e47",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "945a3a2c-b742-5cf0-08ae-46eb85a20a36",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "94979f01-8535-6f55-3aab-464911fb78c0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9499db5d-73f2-29e0-6699-6fee9b30efcc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "94d53d90-c40d-2c7b-5b09-1fc3733efdde",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "95280675-9478-c286-6e61-5eadb6e04ce7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "95faa871-f826-133a-4557-00411db6d5e4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9651c893-06d6-049d-48ea-4068fa9fe013",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "96accc97-fd14-14a7-0273-6fc98af06c35",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "96b1462d-19ec-a38c-05a7-8c261b7ce639",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "96b814eb-178a-5fe2-b4a6-eb71b6006fa1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "96cf1edd-649d-c6e7-4f3f-63bb525f08b9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "976eb95f-a41f-94a7-82e2-873bf9bfc785",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "97732f97-a471-d97e-a1c9-5f1e65501cb8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9776757b-2364-91f1-48aa-936b7a307f23",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "977d8ebf-94c1-c3a2-81ce-59267542cbe8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "978254e1-40d5-bc41-fd06-9909777893d6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "978d0096-a189-7be1-55f4-a61ca61d2828",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "97fab13c-da56-de8c-5ef3-69bd1e7add0a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "981623f7-68c2-156e-a5d8-a788517c404b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98330ae1-f241-43dc-0ce5-867ab32eaa69",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "985812bb-b587-86fc-300c-964d20bb99fe",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98a3af77-666d-b843-1550-1654d066a91b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98a8f4b6-5e8d-2f6c-8758-6666656e481a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "98f3fdc5-c2cd-f68b-96bd-732dd43c8529",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9929577e-537b-4402-8863-02367ce84100",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9971fa58-a988-4a0b-0bde-87bf140e6b77",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "99c374fa-121a-7538-fd9f-bf18f9ea5cf7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9a12324c-a9b6-7e20-cdf2-3558d46754ca",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9a87aa15-1dd8-4cbb-afbc-52337f77c2ff",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9ad1b67e-6011-dbfc-53db-ddffab249a2d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9aec3604-2382-813d-dbe0-e829167d4d03",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9af6f1ff-5c76-981f-16b1-cff0e00e7faa",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9b04b38a-df80-4890-3b63-b52fc684befc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9b05b001-4131-ed42-634c-10196745c2d2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9b3bd5a9-f7ad-eece-81d5-eb1e34b3e9cc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9bb332c5-28e6-8114-a6ad-33361e1c176b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9be5709b-502b-5fd9-98fc-1c1603a3dfc6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9c811b0b-75ce-1d6f-75bc-1c02b0f27f3c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9c845855-86f5-5a7c-6a9a-ab196a2fc168",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d09c449-338c-e3e8-fc9f-e17d64f8f16e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d1207eb-453a-4a13-6571-c8cfdaa7475e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d166c70-6599-8896-04d0-2e1ba4a2d6f1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d2229a0-0c0a-04e6-50eb-b3326b957e75",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d3d2f6d-074a-0e8a-04a1-d64fad0a7ca5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9d3e3ff9-91de-1594-7dc2-e2f7a5061c3b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9dcbb2e1-1288-8061-7552-95fc4a54127f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9dd52fbd-e3a2-3778-9def-1607fcba8a14",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9e0619e1-68a6-7aa1-4f4e-dac1debb97f7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9e3a1c36-c83f-de64-7a15-a427c2d53ea7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9e55967e-b361-b475-1d74-2da173a313ab",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9eceb91a-7f9b-fbe9-d071-540a01948571",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9f1d52f5-5854-6344-7ee2-50b3aa2206aa",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9f4ba66e-d795-ba79-1eeb-aeaf122bb208",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9f916438-7378-7ef4-3477-18e3cddb2269",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9fb457e2-45bd-9c59-9632-dd2b36d435f2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9fb4b466-3355-d007-8bb4-c2e7e89e162b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "9fbe4a5d-79e8-a1d5-96bf-b6ae2b148923",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a01d958e-0edf-8a1b-bc3e-145b9c05df56",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a0670202-2854-2e50-8de5-c40c09ce45d4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a0923ee7-dc84-4fb7-e960-64ba86e14501",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a0f2d093-4ef8-8c6e-433d-875f5fae4ae6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a1727d12-0880-697a-bcde-439c0a59fdd3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a1dcbe22-1a98-b101-6d9d-6a1e43eecad5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a1f1d7a7-bddb-23c9-a786-8be00afca275",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a1f48c0f-fc61-d167-ac87-a547004aa023",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a228ae2d-6872-3077-746d-e7caa9826050",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a2dc9424-44ed-80c3-e2bf-2fc537ce7c31",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a2e87a66-9129-c8b4-8f19-1a7b0003f9b4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a2ebb53b-d53f-3243-6067-58d54306b7f3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a2eca7c6-6ded-0447-2d46-a31b5047bfb9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a37ff634-cd9b-ef97-1174-7895dac5142a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a39e1659-d76f-b466-dcb4-6e403c08235e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a41f5899-263a-2ba5-d89f-83fcb8615004",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a4637bf4-ac5f-fc18-4f21-5d6060423cac",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a495bac9-3238-682a-599e-35d35bd1036b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a515b538-facb-a384-2fc0-09bd704b792b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a59870d1-3aa1-1ffd-b0b0-5f0eef5f14e4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5ad0348-d074-cc01-5380-d87b5fe5dc57",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a5ba5432-532b-bdc1-4517-8f6657b06ccc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a609799e-8e05-578f-a027-ff94df7272f6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a641cfbd-2305-0897-a54f-d1a0e015567d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6b88a34-bff2-5a6e-e081-eb70e4b95923",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6be719c-a6d5-4ec4-f3bc-079e2bc133f7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6d90d38-fb40-67d3-9291-4dc9433685ab",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6df2aeb-dc33-065d-ecc9-bf2472024f34",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a6e15963-ccee-056e-b08a-7b411a5faed5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a7e8a312-e5ac-380e-64c0-58e134a0eb3a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a8052858-a628-5c78-0ee5-886932034146",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a82312a1-29aa-9773-85f5-3a79b946447e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a863f7db-1c08-8196-e4aa-bcf376564646",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a86586f4-63ee-788f-6c4b-375c8c07cc46",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a88474d9-7b40-75c4-103c-4756fefc5223",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a8f123f3-2c9d-cb4d-78c6-e2bb98db1086",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a9291ff8-90b2-be6e-9878-5cf2b98adf51",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a987acc4-6719-b547-a33c-941a36a8ac2d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "a9c039df-e5b6-5874-9c20-40b1c8c81a18",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa1b61b5-90b5-7fd4-8e47-7cc758c171b3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa49daba-9688-5282-f7cd-bfe0c428aeeb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa4ed2bf-8bc8-d627-2ea1-3ee37624ec07",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa4fa9c2-81bc-294d-cb27-c2b5b55fab2b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa5e6d3e-6879-9a9d-240a-c4b8d59d977d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa6a64b5-3b0b-91f4-304e-d1ed6e61b739",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa82c6fe-d9f7-88da-7fee-a67349427ee2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aa88e20b-3b6d-c95b-ee9e-10884cef9b2e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aaa7c802-aa97-7cc2-008c-ddd99d2619b6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aaf5124c-ec73-3718-9708-9cc8a153aa21",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "aafbf12b-4fbf-f7ed-baff-ddb60852ded3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ab988871-3db3-91fd-fdc6-c24dc63b2ff3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ab9e93c1-9054-3de0-5468-8fef169e2733",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abc1a019-0ef7-cbc6-fcf3-2c8326df2fe4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abc6b243-5588-2a14-659b-cd1c72698bf6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abe48f70-3ab3-97c0-8f2d-1177d099731d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abf10a27-3ac6-2e58-96f8-def34af99ffe",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "abfa578c-1059-0e95-41fc-6b4a6cc5bd35",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac0253b9-9c01-e7da-03cf-d4e1caf7b942",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac1087ea-7cca-ba5d-4716-69ede045aac3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac148527-f1ee-3bb8-7a18-397adfdb9684",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ac61a898-07d6-ed31-0122-23756b48dd8b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad086427-ad88-1b14-74dc-3c734d9f8fb0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad3ad1fb-e09d-f4dc-0ea3-acb109796d53",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad51b75b-94ba-2db3-71d6-9937a00564df",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ad71caea-fef3-33df-80d7-ea9d6752f176",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ae09acad-eb08-db70-af74-adc1671104e2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ae34c999-ba3a-c1f3-e075-87b6f4725ded",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ae9de472-6ed6-c56b-17f8-0802b30e0ead",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "af3d7485-acdb-8cea-67a2-6784f57fb5af",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "afa4b9cb-8ae5-b1b6-05c9-c43ea90ecc50",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "afc81f01-6ce3-5947-ba22-725ebff80699",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "afcb9307-adeb-3d34-6fb9-8d01b5be2c0c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b0bec8c1-1cef-e9a5-e823-63e2e2ab1135",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b0c8310c-b20f-5bc3-0552-639e3266a07d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b138dcf7-c96a-95da-7950-ca0ebeca603b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1a62097-cc7c-9e22-017f-ade4e5e982e1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1a95a03-38ca-ee92-017c-5209fe2a86e6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1ab77c6-75e2-be65-fd4d-2216d7df9169",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1c46032-68bc-da8b-5947-ff34f797a32a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b1de73bb-c73a-7b74-9abb-430fa0a812a0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b2019509-d822-c669-e919-c21274fa48df",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b20737f2-721e-1d65-17b2-417ab128a58f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b259425c-b08a-20ea-60cc-b695e91844b7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b26a3004-88ee-88e6-1eb6-595becec2c64",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b383ee88-a3d4-9a92-14b8-4ad063d05858",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b3918eb5-f713-95f5-c1c0-7675b7e0b333",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b3a131b9-2c77-3894-f208-cb79d39faca2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b3a8c3e6-2323-b55f-9c32-0b87693deb72",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b4099952-0caf-5f86-08f7-1c232720eb99",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b4d3824a-cc8b-bf10-4c1a-b8023aea893f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b5308f06-151e-ee1d-d1d9-567a5c3df214",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b585a522-6b7d-2bde-80fe-59857d64cf59",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b5e54f3a-245f-7903-3b7d-8ef6772d70e7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b626dd2e-0dd8-c1b3-7fde-7d858fef9eb3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b646c1a0-6866-82ac-52d3-c26c028a197a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b648d7d6-c04b-1683-2bcc-c8232f2c923a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b6529d06-a4e4-da6f-c704-7b54408823c0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b6835bb5-93f3-8590-0e25-4aff27981c88",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b69ab90b-0cb8-a678-d160-a4290766c7a2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b6ca8d56-55ba-aa23-f316-c621e9fa525e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b738fca4-5187-2cb8-fe64-bf110f27dc19",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b73fb90a-f41a-0c50-2dd7-6d2cda329ea9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b7631fc1-9896-70c6-3e36-19135b902372",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b79bbe9d-8926-288f-0bdc-9007eb0b656c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b7ae36e0-29fa-4028-0fd4-b1091ee273e1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b7c2ed29-9ab4-253a-3902-2ea7f8883136",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b7c7c612-25de-0378-1236-e22ea28f2392",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b8335c2e-5946-1e3c-cb33-6a72acf2ab96",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b8e523c8-720d-5eba-96c4-ae0d83ad93f3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b916b170-861c-b14f-ad0a-9b5bccd2c0ca",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b970a475-9dd6-744c-7ced-6d58019d3405",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b9740ffe-3edf-4783-e5ad-69012f24a391",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "b9d4219c-8c1a-8d68-660a-7023a9845a4d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ba235bd2-9ad8-ed2e-d547-fbd573117230",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ba37947b-1f2e-485d-f50c-42898aaa6e37",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bac11962-0b4b-4272-9fdc-b90833ccc3d9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb2fb4ac-48e3-3274-181a-669eb9886be5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb39bb03-38d6-cd02-b341-89e2a660da76",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb543979-51da-e0a4-508a-34e41cd9c765",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bb5e6b6a-0c42-fdab-58c4-fef95fcdc49d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bbd0e05f-b5c7-8e18-6176-871218610a2e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bc03355c-95ff-090e-9a1c-0d49a206877f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bc3ad3db-d8c5-02d3-d06e-5f94d53d9f78",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bca7d63d-cce4-43ac-f1ce-560fc47e3074",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd079d7b-b8ac-b648-0a0f-fa0d75c647d2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd194d03-59f8-3e62-32e6-fe4f7a3b879b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd2342ba-3dc5-ee86-3dfd-38ca414e3fca",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd26c6ec-d165-4279-e832-a0635cb9a1e5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd3a37e9-fe59-1c15-b82a-aecb60558898",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd5c5e1b-5be8-03c6-a5e2-39063b12d65e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd7b5900-f38f-a528-65ab-0f8b01b90cb2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bd85547f-e0ea-e2db-db8d-c415c58afb06",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bdd09408-1595-3d9e-9ba2-750a734e3f90",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "be411d6d-d6d1-2bba-cdad-e1e26eb2fe26",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "be61e608-afde-b945-5418-34c42cb5e6f4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "be7e99bc-ba4d-f226-9d8f-03682d23bee1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "be8499f8-c80d-6ecf-0314-d9a438061154",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bed021d1-ed16-adf0-c5b4-2953fa35048b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bed3ffa9-e96c-f7e5-eb1b-e22f1ec71421",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bee84641-bdce-70e8-0ace-d087d9da4db5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf02e8ed-6ab9-9191-d50a-9c05cf34fcef",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf1e2694-409a-773f-6c59-a05a8af0527f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf51ec1a-fa3a-3c43-080e-494a6f7e3910",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf542d10-d3a3-6bc7-9bfc-b0462086ba9b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf65da75-e34e-5685-f57a-537b8330d101",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bf6fb6f0-aad6-0f75-373b-ab2ab4178d70",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "bfbb1b2d-d452-df85-a892-80cd96cb1a40",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c0028500-4cdc-8005-bb90-ed6399529b3f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c025d9b6-56e5-4289-89de-69f2f2d1d013",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c054a00b-472b-2614-aac5-8337913cbe70",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c0c452c8-6e09-202a-74cc-724212b93b85",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c105f40c-b412-3a64-e00a-cb1f14df7cd8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c10a0baa-1e4b-54ba-5d59-5c584d8ae3ec",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c15c6cab-3590-2006-a628-67612870eb60",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c1e277d7-04c2-6cc6-1b93-4ff3c54ddb94",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c1e8cee8-7fa3-ab3e-3d0f-19a001c7da9e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c2516a1f-5f3e-7e0f-7b86-9053846377c1",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c28daec1-e191-6f96-c9e0-cdf380630667",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c2d41dbc-aa10-040e-97a1-2860c38dbebb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c300e4b1-5f24-736a-923e-7115fe5334bc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c35fb6be-96f6-0788-f95f-8449add9c5b2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c39afa7f-074f-a2f8-f8fc-90cc3e6a54ee",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c3dd11cd-08a8-d8d0-60c4-add26094c881",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c3f29e56-c774-c1c8-366d-35e9ddfc64be",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c437ad27-25ad-790e-ec14-e4cbb2c7d54f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c470d37a-a616-4624-0e1b-a3d600ba3c08",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c49feb4a-a697-d42a-ade9-8a8f6028bbfc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c4a2bdcd-3c48-1161-a825-b48ae0fb9ac3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c4ad7e6d-a8dc-0bf8-e6a1-968fd7fdc033",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c4b97e73-7182-c9d9-9bf7-916db4bdf6b3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c565c6ba-ecac-b786-5785-0744bdfcabc2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c584e914-d15b-6c1e-b33b-e87707b1c8f0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c5a0b44d-30ce-829b-93a7-716afe1e5163",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c65167ab-7aa0-3908-3e63-2698d06fa1b4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c6653eba-2cc3-e374-c025-ae329ebbf8d8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c68eb13d-eb1e-60a6-afc5-9de883024f84",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c6a456ad-719f-6857-0f33-b79bec3aec14",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c6e7c556-e76d-2b22-aced-041ba0d8cb09",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c754ff77-bd29-b62c-e3f4-7e929c78193d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c757b477-07a8-d325-d4cf-a0a78e352f66",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c76ae261-cb00-12d7-5c66-3d30e05f23d6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c7a68e32-cda7-b864-e7f1-ba2ae5fab309",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c7ab8857-b59a-c7dc-145b-8da6ed190264",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c7e266d7-3097-a994-1174-d3cf1608c41e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c8006108-d31d-3fc3-8118-4a00aa1228c8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c8126fe8-b8d9-89f3-fefb-a1e84543f875",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c83566fe-4da0-b680-43f1-aaa1880db549",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c888fa0e-3ba4-8446-ca99-35f2dd69819a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c8e06257-6008-61b4-4b53-278d79854078",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c93aedf9-5f94-9dc3-c599-63c7235e54e4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c97ef879-1ae7-589a-9725-ef5fe4f47e85",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c9ca3188-8a21-724a-23f6-5d9e402ab287",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "c9db2283-f63a-871f-3474-0b3644830bf8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ca104199-0e3b-a9a0-6541-971afcce8f96",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ca31003d-2c4d-41c8-9b9b-4c61347b3f44",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cb2ddc10-0f7b-7b6c-7e76-161e2e263da6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cb756fbc-e28a-18c4-0a8e-c104792fbada",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cb92b727-b9cb-e73a-c23c-624b67d66994",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cbff8567-0725-b204-ba70-6b3ea17679a2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cc712312-dee1-743a-9da4-ee708f3d06e9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cc89b80d-6432-18eb-4c1f-89d48642289d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ccb09398-5ba5-01ed-ab10-93ede45a2ff4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cce2ada9-2f2d-ce10-1509-2e3988f0040e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cd47af08-b065-d7f9-957b-4331cf499a84",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cd4a2b32-4de8-cae4-d813-3a9c528bce84",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cd59ec50-30b7-b08d-51c9-6737e46ecec3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cd6145b8-b05b-310c-edc1-da36803950e4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cddca3c6-4ac5-3ec4-fdd8-d62cbe543812",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cdf74965-81e4-ec2d-fd36-05903f3fbe71",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ce26811b-de02-7e83-9dd1-d5b4e63396eb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ce4dfd1e-ad1b-0639-3694-5546f628cf6e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cea089c4-c5e0-a538-e43e-7048c208f45a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cf215fc0-30a2-fdbb-17b9-a258935ddd43",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cf463be9-848e-d83d-031a-db82bbcfed79",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "cfb44862-44a4-9cc9-5636-6fc938d47be3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d01019f9-5218-71f9-d3a9-35cb7b04b12b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0425968-0a5c-0a9f-3897-b55f4e22a274",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0486529-51fc-62a5-004c-ecd5002ccd41",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d051e973-698c-58dd-bda6-63d696077ad3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d06748a1-c551-6392-95b4-d0e7a67383f6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d07bb88c-bdf7-0c6b-a371-44ce794f7d3e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0800444-ea17-8385-2966-5647abb78f15",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d0f8efdd-4c40-b515-a8d1-d855a962a852",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d1190b2d-d5e9-c76b-ea3d-31e651790ee8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d127ff74-4b39-8bf8-4b33-1af8efd9efff",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d18e41b8-a3ed-9a53-f1f7-f4e1e0202350",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d1ae562d-8ff5-04f9-e4f9-be70373beea0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d1e7ae5b-ecf3-3ada-6070-e654f99464ad",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d2041949-1d00-ce16-fc7c-30c218a75f46",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d2844c21-9623-3690-da1c-07bedb8fd532",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d2e5a5cc-7ca8-1bdd-b989-bd9c35ca0e88",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d32c9013-9fb5-9f83-708d-3e02f83631cd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d332aa9e-04b4-1dc0-9881-7194bbeda63a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d39c0714-beb7-9fc0-1fba-437d66426189",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d3edfa54-1262-d190-899b-a472871c59f9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d40ea291-f121-99ab-8c7c-e499118cd3a7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d4144d95-6eac-a753-921d-02e02afe2119",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d4a343e2-40d5-57a3-222d-bbcb5fa7a60c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d4f123f5-ec66-2062-e7da-d35c3ee57eee",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d508b9db-de89-6123-1deb-4b5f7249f988",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d50e4726-2991-977e-1e9d-ccae720f4778",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d5b77a0d-04a0-3b51-f809-cfce6748812e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d5e30992-c7fc-e449-6e8c-e9ba67574c4c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6004a9b-1c74-80de-a857-6060eaf7261d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d61088ca-985d-c689-4c0c-2ce37f50a00c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6285f6d-f25b-009c-7042-a47f4b244b68",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6442191-6705-0a50-37ea-73d811f12b11",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d6592817-12c5-1929-7656-0bc610ac5bb8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d698f229-ec8e-a652-a33c-b1dfd62a38e6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d7752dd6-7176-d04e-be06-8422283faab2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d79229ae-1dc6-e19a-a307-1c8215d7bdef",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d7fdd83a-70db-66ab-6375-91cd319db355",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d810fb97-00e7-f2a0-0985-acffaf11b187",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d831506a-6778-5bd4-2143-28c488fe9e7b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d83838d3-3621-3fda-ad42-8f16cec8bf79",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d83d4cf6-076e-8942-5a26-f3fb3c195bbf",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d887248e-7c1b-b541-76ce-6a1429625aa7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d8ee1684-8213-4b12-219c-66a273f8d1ec",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d9396d48-fd20-a52d-70b5-3f2085f7cfec",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d94c652d-8be7-8ec6-cdba-d641297dbc74",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d96fcd78-c30b-080b-c92b-7d26c7dd221c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d98440e4-8439-0fca-2b5b-30b2faeaba66",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d9891b95-d26a-cf80-2598-1080cbf310e2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "d98cfb9e-8181-7920-8a9c-c2092b81eb58",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da070f81-6d82-9edc-c029-7bd7b5d43338",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da0ad3cf-fc00-dadd-8d17-4fbe6f9aed62",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da5a50be-4892-2912-7d30-e020f44c2bf3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da84b1ef-0ad9-c9b2-327a-56053940ceb8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "da917375-989e-aa66-3705-7fb13adc13b7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dadf92d7-0a66-08ff-9067-d63a9ac831f9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "db390cd5-f0eb-b466-37d6-608ce90540a5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "db8cd639-647a-8b58-26e1-09ded6668cba",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "db8d2ab6-946a-1502-426d-fcb21953e405",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dbeff87e-c0f9-b272-f6fd-f93bea7b83d9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dc15a337-285f-ef85-0d15-e43c62677ee0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dd76ab4a-daa4-0ab8-7dcf-0ca198195586",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dd7b1eba-70ca-c8a5-de20-f8c2047dadb8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dd9e690a-8f67-72b4-629b-15a9d4cdd73a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ddc05051-6ba0-9876-0a13-ebc3052d2b4e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ddd77ae8-2557-f2dc-0582-c2c104a0a18b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dde5dca0-3459-b459-a095-94f8a5eb4711",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "de4618b3-b26c-8e28-0a99-ae5525670cd5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "defe453a-4213-5afd-20dc-aefb4eeeb502",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "df6e2e51-1635-c552-c2e4-47c20b623af6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "df7466ab-6cd7-323b-3000-734d0a87e629",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "df815484-6a48-1b4e-a7ce-2b2a4a85d3f9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dfa77c24-d946-d3aa-8143-2d2980309d6b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dfe2714c-934c-ef19-fe94-6c4db509862a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "dfec1294-1db0-ea7b-c54a-a137d116774f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0040706-d0e4-ad04-5abf-740f695c492a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0131722-ea70-562d-4144-e87cb9f0a371",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e01ac753-8bdc-ade4-9669-938d4fadda18",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e02b7f77-b4c9-bc10-276e-685319e06cae",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0423095-2fec-629c-28ab-8d15fc453cf0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e04a9235-6450-7289-01d9-1e0c6d60181e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0a5ac38-0109-c23b-cdf9-bfcc771a6956",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e0bb8201-c45e-a7cc-9a4a-f0921c6fd86c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e1738f37-9fc0-61b6-284f-5715db5ab025",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e18dbcea-eaac-9968-dad6-da60b8861e2f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e1ae903b-0fa1-0b1a-7c79-50c21c2fda45",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e1cc35de-1693-fdc6-8795-0119f8f61623",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e22fb966-0110-6a37-fc00-b5c46fd4578e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e2513fbd-3f02-efb1-92e4-4d7524a0a9b4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e260b095-b963-c13b-b5a2-d609ac8bd890",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e291f668-1c34-8928-0af9-193ae7989012",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e29f5f7f-1c7a-cc69-3cb1-b84d99512a10",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e328a9be-6a04-0357-bd9b-ca8071994c53",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e3444b28-a5e6-7291-e9e2-d64fc228bdec",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e3893a5c-c4c9-6ce1-3d22-7f941a507391",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e40c1a85-5a5d-9c2a-9e5a-b2bbed317175",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e44ff3f4-6ff9-8af0-f12a-63b3268c710c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e49eb41a-61e5-1afa-fd1b-c583e74a569d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e4b69797-276b-44dc-f691-2839ccadbc59",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e549f908-0b9f-bc96-93e7-a3debcc701cd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e5534c19-113d-4705-a9f8-5a5534f534bf",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e67311fd-9bd2-4e5f-8279-73123894a17a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e68df90b-de60-3d0b-5d70-a90a988ef8a4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7669321-e9ba-fae5-d9b9-0942e2f9593a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e792e81e-cd41-7b11-d310-735b5b93ea00",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7ac8242-2bdf-3ea8-34ed-376cd6d4cc6d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7aecb95-46e3-43fc-9a35-83a34ad22e20",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7ce4d59-52f1-7d88-511d-9ea255446f58",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7d00346-218a-3d24-b03b-7d2cfa8d6d7d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e7f5a5c0-3320-133a-03ea-46152f54fcc5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8595792-3dcd-28dd-a32f-ee89cc5050d0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8aa53f2-71ed-412c-f7d0-671d062a1adb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8ac214e-c699-744e-3b46-e21d641f0d18",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e8e08ba6-7aaa-47b0-1ba8-5672399ddd9c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e91072de-8876-66b5-cceb-4cfa6eb00b82",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e915fc4f-2425-c1b9-7448-6f93374f4d93",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e9479010-3a2b-6354-2e0c-11b49b24fb5f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e98c5f67-be73-b56b-ad1b-5fceac952155",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e992a0f0-7cfc-f1ea-667c-c308c7560737",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e9b49c47-9e7e-988a-005a-a02d777ea1f9",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e9db33d6-c21d-844e-fbab-1988c3f1c501",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "e9f13ccf-286c-0d42-6c91-e3359652d4cd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ea01f8ea-b73e-be93-9a72-7db9fa21dd8c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ea06b88f-d8a1-ee08-bc3c-d84a42ccdacd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb190148-b365-1499-4bcf-34a8307d3ae5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb44ddfb-46e3-45d5-0bc5-a67ff08455e0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb74d34d-f692-9e7a-adfd-1de4eef6aba8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eb78f89d-1cd7-e3c4-6b6f-df1c818c8923",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec052380-b3a0-1f11-1ad7-005fbf8520e7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec071909-de0a-3e67-a7b9-4a4b07d9de99",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec0e1add-4586-37c1-c972-fbf0ede0a017",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec341556-c367-708a-11c4-097536f47dcb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec377fb2-efe2-8cb4-6918-92157e4f1d7e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec3fb212-0f7b-d271-15be-97e7221bf8eb",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec421852-921b-ebfc-d739-8212e4385e64",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec46c0fe-0b44-80a4-27fb-211fc8190195",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec4fae02-dbe6-d8aa-4d3d-da1c38fb7f7c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ec725cd5-16d9-76f8-27ad-d5aa62b86c1b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eca547a0-40bb-5380-51c1-a0b8b2aae5cc",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eccdc834-73c7-adb9-9ff5-6255b7257146",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ecd3fefe-805d-9d96-cdef-0e211ce2b325",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed370274-74ed-1323-4d72-4c21d1e54c40",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed3daf70-fcb0-7b32-f292-becdb3eb3eb3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed3dee0b-d891-bd85-2ec9-065516fcd123",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ed67f473-5441-c705-b174-e26119a10316",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "edfda5e7-5084-880a-022d-29069aa5cbfa",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ee921d29-66e1-c443-c162-df77ae566e01",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "eef85155-102e-817b-0de0-1e2e035404d7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ef04b83f-9b1d-9814-3a9e-a3c0d292ac3b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ef55d5ee-4787-d8c7-b1fc-0862746ac28a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "efa6a2ea-b018-6b26-35e2-0f08ee59c252",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "efcddc9c-0e5f-4f7d-4e5a-46ec6a58cf1d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f03e93c5-dcf8-3a1e-2f1c-000716f66d54",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f0848734-7d3c-b628-05cd-7a6ca1c722d2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f129bad2-788c-bc9e-89cf-60039b8e604a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f13edc40-466a-6629-9715-d914984c3653",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f14fc5c6-c061-1111-1e79-f268130aaa74",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f16f91c3-4de3-d09f-4071-921f313f15a8",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f1707df7-3aa5-d08c-ea15-5bd6269c6cd3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f24c8abc-3f83-5162-2e6c-56859c5c056b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f2faa893-22a8-48ff-393f-8dfc73243f38",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f2ffd04c-6cf2-db85-a42a-bdb85851cef7",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f3330572-03f4-2a9a-420d-89184937e983",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f35fc12e-5b3c-7ab7-e448-9886aecaf91f",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f38c5421-4043-dd86-739b-482957ece852",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f3b1abe6-fc82-148f-0715-4d25554e7fa3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f3b3e51e-629c-d167-01db-a6540d350738",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f3d7ae6b-ddba-8629-83fc-ae8f9886be54",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f4036de1-b230-f445-d572-9bec69e6a56e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f488335a-15f8-d88c-f1fc-d8ac3ededede",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f4c16c8e-12ba-3b16-0555-dcebf1a93e21",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f4eb2e87-4c7f-9905-8766-781d4216435d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f4f79db4-c716-dc61-8d96-d799e6eddb0b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f509123c-dc8e-d71a-ddbf-4cfe70107308",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f5577ba1-f957-c451-3959-13895ccf1ea2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f59455ff-4ce7-d960-dc83-0e9693fa47a6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f5bcb9ad-0454-f4d3-389a-3f1d78dc2a1c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f5c88e5a-1efe-cb47-c7e0-bcfbc8aefd93",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f602e4c9-bc99-4d36-b8af-7f9dcb88d01c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f692a256-8b14-1f69-5d15-3c1942f5c5f5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f7033651-e69a-4324-fbe2-d0182b44a808",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f723976c-ee91-b770-e7cf-4c2ddd2e10cd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f73614e3-a6cb-cdc5-75a8-c08b2fe4c92a",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f74652db-dc7b-535b-b335-595d87ad4277",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f7502be8-0a9a-4d63-69fe-fba66d3fc191",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f7600ea7-76bb-6fcd-502e-3d05ba22f7ba",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f7875753-a25c-5e48-6009-e5dbdd89d86e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f7d79b48-ad63-002b-60ba-4123bbf5360d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f81f9d3a-35d8-f873-8f95-45726a1387a3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8b8d47a-0316-4cc5-a914-350faf2c957c",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8cd0d8c-907b-551d-6211-931279dc0942",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8e08047-e9c3-3ba5-8214-30b29b7ecef6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f8eda48e-36b2-3c80-2a8d-45ed824d3d02",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f924287c-92a5-420a-b3f5-7bde43c642f4",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f92a4c83-bd81-146d-45f4-e2016cdd6977",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f95addc7-9b43-8f11-22be-04c9b277bbbe",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f97fe6d6-e68f-132f-a21f-88b4705f83c3",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f99189a8-8e1c-7ffe-37d4-46c412273281",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f9b4af5d-0d8d-5c46-59aa-0b304f0f0af5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f9cc2ba2-445c-28f5-a52c-68f5d9e61374",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "f9f1b201-c78a-46fd-3f7d-701f0cb9d80b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fa2ae8ae-2b5c-ccb1-c6a2-0177edcd92fa",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fa8863c0-67b0-85c7-5ff5-bf270e35170e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fa95ca2d-6015-d738-9bbe-e8cba5195c60",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "faa58a8c-d950-2e5f-5a1e-2fb3331958ca",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fab65069-a16f-8092-41b3-2dfadb5b84c2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "facd8efd-669a-9b98-99a2-ddfd592532dd",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb099bba-fa75-cc47-57ac-dc2ce717cf7e",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb2537bc-4439-2071-55a0-b6407e36e5e0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb4dd0a9-4c1a-c15f-1c5c-83953364fcd2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb69fb25-869d-236e-a158-a728d21dbd94",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb91193d-c432-36d3-5e89-59f7ac76cab2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb91b8eb-0efc-685a-ad59-fcfc7dfeaac5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fb99eb83-8abc-f0bf-d8d5-d3ea90a38837",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc38688b-a5a5-0a3e-f73f-a130d3c1ade0",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc3c2b4d-ee65-87b1-8670-116de9888753",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc5fd85c-a36e-f72e-7eb2-0ae8930091c2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fc730fac-20a9-8127-7fda-2bd0fbf14448",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fcbbff35-ac21-d887-426b-fc0c5af9fa0d",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fcbeb7c4-fd9c-40cc-b15e-4ddf4d47233b",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fccf2bf5-babb-d0ec-0d0b-e5f0b0d63701",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fd1bee15-e7b2-9c75-8f36-bf9c4510c9c5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fe2403f2-62c7-83ab-fb2a-f4d6cb4cea82",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fe6057a4-b3fd-e417-393e-2376770b33da",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fea0de9b-2eaa-f28c-2118-dc74ea12b4b5",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "feb625e2-f58f-10a5-c43f-6d3c4c346780",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "fef0fe5e-f84c-8548-71ef-b871756abbf6",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ff23d1fd-2e9a-7c35-f281-1467d5db28ee",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "ffaf6dcf-a818-b063-4229-9fa3525404e2",
                column: "room_id",
                value: "02bcf600-5d44-cca7-8b68-e763b00a6339");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "011f7dd9-fd3a-3d41-6190-1f4489c299e9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 15, 209, DateTimeKind.Utc).AddTicks(137), "$2b$12$K9wvCrdpSeJY5z0Dm0oUEepcxfTpvvqi7/tbwtkk0VE9VMQvMNoga" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "015a9397-c5c4-4b03-eb4f-86048ec621f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 45, 160, DateTimeKind.Utc).AddTicks(9000), "$2b$12$0u0woLz8oae8YSk75HaN9.Z.y4XqtX3nUISFmokIPlytPMZldJvOq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 4, 727, DateTimeKind.Utc).AddTicks(2340), "$2b$12$A4D21iMDzT0iClwYPY664uBeOi08dpVjmcZyPdoCxoFa18fGjYMte" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 42, 985, DateTimeKind.Utc).AddTicks(9392), "$2b$12$mBpRxZMD6v6mvLCjTVx73OviVGtRLdjpfPJtmoEhbl9ATKXxY3SM6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 50, 426, DateTimeKind.Utc).AddTicks(1008), "$2b$12$Ryv8HemTV4xZ0Hspdip7fum9Drm9Ahk.ykVssCpAIV6p7hoG8j.1q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0a3f73e7-67a8-750c-576a-49c22125bac7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 16, 983, DateTimeKind.Utc).AddTicks(5341), "$2b$12$Xbxa8B80hZP4yKBJ0iAK2uzXbVqa.ia2CU8/s5dQEiIuaGTfElmPm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 37, 977, DateTimeKind.Utc).AddTicks(8597), "$2b$12$oafla47Al9U8gYLM6BCtH.wX9sfjCUocs6eYWOFjMxarZq7g5dWSG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b48ba68-2d76-43aa-8392-7b40b1aa1e19",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 13, 235, DateTimeKind.Utc).AddTicks(2590), "$2b$12$ld6V.Og/iN3.QM6Y/0w4P.4q1lHoMAOyxxFTzidekUsYJysFxabC6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 53, 779, DateTimeKind.Utc).AddTicks(4294), "$2b$12$h1hcwQ8.baw56HFXrU8BVOESsrc5X/.4cFShZrWeWbtwQCQXgWQCa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "129452cc-6c9b-3726-5c96-54b67ac3b884",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 18, 124, DateTimeKind.Utc).AddTicks(3076), "$2b$12$eE2wSoNsafAHxO3OAAZcCuLGowwsrt363XAt4890.CiKBhODtrFGS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 57, 640, DateTimeKind.Utc).AddTicks(2661), "$2b$12$Z9XFwT.i6xGiWSQs17ospeBi/0OR02dAt5t6Mm5SAygELGGdkt9DS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 39, 818, DateTimeKind.Utc).AddTicks(5804), "$2b$12$PX.AOrsIiMLUJ8S2Y2RZ.e2Auyx.trXtqV88ByZPtpbdk1z0K5iK2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 2, 348, DateTimeKind.Utc).AddTicks(6671), "$2b$12$3cqVW5gJ5hEQd00qOy0UaO/OQN0UGG8rZqJ6q.lVVYrxpKoVO1IuW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 49, 4, DateTimeKind.Utc).AddTicks(3635), "$2b$12$2XS2.CN/Yd0UBFpHtPWys.vv.OcGSrsX5IqbhgYtJAwnDKg5laxxW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 7, 245, DateTimeKind.Utc).AddTicks(8128), "$2b$12$b9ziRPr4Pybc6BKC.BOJnOfpaQFMdoZXsOas4D.SZckEgM0JOVj7G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 40, 940, DateTimeKind.Utc).AddTicks(8394), "$2b$12$y7.uKxXWF6iIbdtEvbxxzu5duBkzgI3JhVoEzh.gzOoE/92snhLMe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 41, 650, DateTimeKind.Utc).AddTicks(2370), "$2b$12$bryiHQYJqbQW2vssl1Fwwed.YF9NJuxRt18TfkZYBqV9hpYBqLulu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "288bdacf-8acb-a8d1-59f9-94f0cccb2086",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 11, 511, DateTimeKind.Utc).AddTicks(8408), "$2b$12$XtlXgnZKy8U79DCyMwmTteIoeUaS/nFQOvVLmWT4A0OpV6WaSz6XO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "296e74bd-c209-7f7c-d030-28e85a1aad75",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 45, 902, DateTimeKind.Utc).AddTicks(67), "$2b$12$g3zEwJzcVYsWWX/QazQ20uZQG/TaxCcW3gcMuD4IMcU61EBHa2qm6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2b5c3a92-dc35-b1bd-16c3-b0f8a21f29f6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 9, 54, DateTimeKind.Utc).AddTicks(9778), "$2b$12$eNKa8rP3vNnx7lknYoYb5OibfwlbzivoRmqM5afZoxWURqeTBw9Pa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "2fa22e35-4eb2-7351-ee0e-a523ac305c44",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 13, 887, DateTimeKind.Utc).AddTicks(8502), "$2b$12$b/V.WSBTsLTakhg0/U3ZUuQHw/ZZDHIepzOTMPV0oC6BZ6Dk0cS7W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 56, 541, DateTimeKind.Utc).AddTicks(8208), "$2b$12$ZP.vZrVWrYeOSm0LyJG.3O8lNASRJx5LpygF77vJUdXqFjofyG6fi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "373399d1-2bd2-aee5-629b-43f96da8f03e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 17, 756, DateTimeKind.Utc).AddTicks(784), "$2b$12$v85.endPno3OySdYW4dB..c5OcEP7k9AwHPlmtcOZid5C2Ervyhfa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3769412b-799f-6b72-f74f-9b9b735058c2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 10, 92, DateTimeKind.Utc).AddTicks(2980), "$2b$12$ZIUQyxsqg2tc8TY359ZBgueiZDp3s2VHY1jeR3ijCJevoYukuzO5e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 7, 991, DateTimeKind.Utc).AddTicks(1286), "$2b$12$4.clcUHdu8EDMeFXlxOL4erkDNcZsWrswEGxTAhCCdbACb0CXksZu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 36, 764, DateTimeKind.Utc).AddTicks(6875), "$2b$12$Lxng1TOQvIWIbf2pgp4v.e.d9xAKfZsdHYqIYasWyc/GZd2u8O7Cy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 48, 644, DateTimeKind.Utc).AddTicks(6941), "$2b$12$7wzZlPDsv6sF7fcLVRu12OPiEXkFYyAZ4vyc5s0sbnutdArla1KSu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 38, 694, DateTimeKind.Utc).AddTicks(1289), "$2b$12$6kImQpC3/FQIt1EVq34Dp.fG2C6uolFwigyNOScXQ.0dVyPwxxQnO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "476292a1-d3ae-cacd-a58c-2d14790da8eb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 14, 566, DateTimeKind.Utc).AddTicks(4388), "$2b$12$W/nBvH/vCCQXufanBfqpWuA.2bC7d4.hiUVTnhHgBNvG94CuAHXu6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 38, 342, DateTimeKind.Utc).AddTicks(724), "$2b$12$gsn2Ii.zmnwO1gNEAMi9gOjPy1xWwoAK8XYQTX9IOPVN1lY5vlKr." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 1, 233, DateTimeKind.Utc).AddTicks(3415), "$2b$12$lsJ6M7GFNUxwJtwH0eDFee.EyM358Hq9Wws442ZfKcf29DhidIrJy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 2, 726, DateTimeKind.Utc).AddTicks(3170), "$2b$12$Jrot.2qA.jRYed20.2jRmOgnH31wRqctrIdzJn7T/wrpND/u6q8Km" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 0, 210, DateTimeKind.Utc).AddTicks(6048), "$2b$12$5ud1uiUK2f6B192ZSTMyFOopdjMjCeva/Feto1b6bVsnWSRdtjnD2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "539ead07-d571-367b-79f7-68b21513886b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 12, 873, DateTimeKind.Utc).AddTicks(966), "$2b$12$mMDklhnhkpiDBk/YPSIml.JbMP3CsXijJweIPsqZPPpO0k83m9sxm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 58, 929, DateTimeKind.Utc).AddTicks(803), "$2b$12$51qPNe3kqJ3JDxBin2Ev3OObmnzxQtQ6GLy4WkSr6229ExkMrFy4K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 57, 969, DateTimeKind.Utc).AddTicks(6368), "$2b$12$90Yk4O9aeUfbpwO5l92PAuwxWVJiJWMyKKd7XibFnb.XLmjOTNn3S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 42, 348, DateTimeKind.Utc).AddTicks(1242), "$2b$12$B3xY2GQ25XGd32WxipBr6eabdRbMWjy31M9knbz1dOI.BvqkRVtbS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 39, 73, DateTimeKind.Utc).AddTicks(9918), "$2b$12$WGSvkvE0ZEKUd0X71J1ROeYsMDKlGArAEEJhGj/48dP8ioj6LFCDe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 44, 68, DateTimeKind.Utc).AddTicks(9660), "$2b$12$sKP.HVCOUsRnnKFLblNHLeWCMcczTTa9yUrqERKDKxnsKgpCj/E6m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 1, 965, DateTimeKind.Utc).AddTicks(8700), "$2b$12$WAZ64Go3aSteX0/7HsatheLrEBiKluJVtxV6khLYglQkyV0SPlsHK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "62f48843-9c38-a162-72b9-af6d09b80de3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 14, 212, DateTimeKind.Utc).AddTicks(656), "$2b$12$ITh5SfCzMr2370yh3ysEfeYVYAAx4WDc36EiKEHN5YPFspYGYA0ua" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 40, 570, DateTimeKind.Utc).AddTicks(5051), "$2b$12$IWdmBrbeiDm7dMkmsJHAmekNPCIS56Z70Ywbo6OGjFNZGOKpM6vWK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "65aa7c04-2529-20cc-46f7-47c22df3e1d0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 15, 938, DateTimeKind.Utc).AddTicks(7510), "$2b$12$DWWgZ43iVyvnppAidoAk2.uVL820HcjnWJEzIVs9hZsF2jhrV3NAa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 5, 32, DateTimeKind.Utc).AddTicks(8789), "$2b$12$VXjOQFZCJY3oo0lHz8G9neByyuwQAzlN5b0bxvnWdCqRsArsgLYoC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 50, 81, DateTimeKind.Utc).AddTicks(625), "$2b$12$KmHLZYduWQ/davpHPfj.J.0UAsl6wlB1HtoJqGsEhxTVNXmywhuaW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 55, 151, DateTimeKind.Utc).AddTicks(7801), "$2b$12$sXN7UEU3CutZ8CzIsTpzXuYeSlZHLlhoPGTytLasPTUwkFTWd3gc2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6dcd090f-508b-7888-b458-17aeea49123a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 17, 349, DateTimeKind.Utc).AddTicks(3700), "$2b$12$8yBU7WqpBlL/ZRIAjSCdTOBfHsy.6XsPMHlEcr9kNMUIJW085vL/." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6e5a0735-7928-5aca-b192-5e455fca402a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 8, 333, DateTimeKind.Utc).AddTicks(1481), "$2b$12$HvowmTuXbTY.FlZpSalzqukElxHpMbDxI351Hv1kIDMZPFEom84ZO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 59, 567, DateTimeKind.Utc).AddTicks(4139), "$2b$12$Ms1TsjiuQbxV6HXUkVkYCurDe8o/XTyu4fq3WxUwdVNzOb55xiiQO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 57, 269, DateTimeKind.Utc).AddTicks(9520), "$2b$12$wbdY4CajK8nypmeFze.Qb.XFkzCfBQTGRn6cVW9qllTkzPQ2998jS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 44, 412, DateTimeKind.Utc).AddTicks(7945), "$2b$12$qCRm6lh.x.vAhW9rIGwMfe5jZaa8e0FonmFVY9ankiLgbx2Lw8NDO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7f2e2223-eda8-2785-2b9f-2f6cbfecc012",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 46, 262, DateTimeKind.Utc).AddTicks(2877), "$2b$12$ERMkZH71SKCFX/N3/YH2M.awVskqLDIQd4hmd2TkC6ksdwBMZklmC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 6, 116, DateTimeKind.Utc).AddTicks(4802), "$2b$12$num0Iitcv2OWAxY5IvIaO.2j/opIXnEmOCvXIpjA2lTFns5siJ9ae" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8976fc22-4f3c-f5a6-a6d7-81058525ac85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 18, 482, DateTimeKind.Utc).AddTicks(8952), "$2b$12$c2lHE9y7Qo71APdOtvXXIuDeOsd5lnCqo5leL7FrNA6ZDu88ldZg2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8b8636d1-c1b0-1104-ebb5-a8e7e20d35ae",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 13, 580, DateTimeKind.Utc).AddTicks(1489), "$2b$12$hr5HUf3gXs7focwqY0/l9OVK80sNPaXyJhKRfqYgy/ek6e9K3X43K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 4, 420, DateTimeKind.Utc).AddTicks(3194), "$2b$12$dWjJW635L8.PyLnPR8daJ.VW963oL1Jfy6HhrcshUcLAnd4dXJZfS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c62f6c8-d791-e825-bdef-5c14bf5ce951",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 45, 533, DateTimeKind.Utc).AddTicks(9294), "$2b$12$Axmuk88GG.GjA2/Sd9rHNuqva/svNd2E.rn8yyqFOBxCW9fDaHiVy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 56, 184, DateTimeKind.Utc).AddTicks(7518), "$2b$12$m6oouoBtl2xS5bOzvbW0t.Uumbq49HojfWFQa.4wiLvdJUotm2md." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 52, 393, DateTimeKind.Utc).AddTicks(8896), "$2b$12$F16muJSXoTamEDffW.UVJOXobG8eJUVVg.DolHTFvx8crCEuL5nWa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e1a2182-9af2-5229-2104-66051e4b6220",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 46, 593, DateTimeKind.Utc).AddTicks(8075), "$2b$12$6oOjSpBin8i.zq026B4g2uglxDU.vxsIrf83sQT36UGm.3225.H3K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 0, 517, DateTimeKind.Utc).AddTicks(8358), "$2b$12$WMi44tAhVo0bJQTk3jIEX.SpIbJ55nIINpWMcZH8DXCwIGo1zmh3O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 59, 259, DateTimeKind.Utc).AddTicks(3164), "$2b$12$LTCyY5V3TpgN3HDmZFDplesAdGIqW3WsxeIi7Ay7Cegzj6bCy16Pu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 0, 846, DateTimeKind.Utc).AddTicks(2502), "$2b$12$.fFVvReHfaqll8lqguroQ.pLjSB49IIdpbOz6/aiorL3xcJjw/VSe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "953715b4-1d71-3023-7048-42579385f359",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 10, 442, DateTimeKind.Utc).AddTicks(9698), "$2b$12$81cLA5qiIR/NROz6yO4fhOMY.JrltG27I.BkbLd.m0xxGyQMwlvy2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 7, 639, DateTimeKind.Utc).AddTicks(6832), "$2b$12$hOsKgNu2t7jZNojpqepFweMS9EBiz6Zpp8Vgwje8M3JsS/aV1jNEe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 3, 445, DateTimeKind.Utc).AddTicks(345), "$2b$12$xzYQ.38XntQf2D4/B5CTFOldbNqtYyir9hSc.Nzu/88lBTXORyt3y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 6, 503, DateTimeKind.Utc).AddTicks(6521), "$2b$12$Bz6E0WjceKzoEVkyCEguWeBw5aB5.o6WtQxw5jMtuD.VncrtSZuQG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 53, 112, DateTimeKind.Utc).AddTicks(1203), "$2b$12$fLkRoWIbQ/SfgHsdEhh4.OdBGtSub/77DhWfLQ6VKKRaUdGeNUNca" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9ade6863-7e26-4864-6736-dc579f1c7a31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 46, 946, DateTimeKind.Utc).AddTicks(8997), "$2b$12$vw0Q6OpLTwdFlM6qR52pcO8iTUkw8zbuYa7xsdiLrVtT.XDi5b/OS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9dd3d6be-aadd-a804-775f-b0817d3508fc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 12, 233, DateTimeKind.Utc).AddTicks(8309), "$2b$12$HoTe5ng.XwBmLuo0f2tw4OQiGGBj1wz5Rp7Y9TWAm5aXcl3y71mzm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 52, 757, DateTimeKind.Utc).AddTicks(618), "$2b$12$u4Ig1jbzs0pO6/1A22ycTuj4w.R/eg1WR.w5oRkNTqkmNCuDRyd/2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 51, 456, DateTimeKind.Utc).AddTicks(6065), "$2b$12$4rKAEBsFfv5b0rJ1MtgnrOFTF3uSV4G.n12ddMyjm9qpE006irngm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f3e92f6-ee55-979e-23b7-f713245738cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 11, 881, DateTimeKind.Utc).AddTicks(4956), "$2b$12$2KTK/JAS3TwG9CSivpxS3eBjAOkzhZeqWs.zi2XNZgosUMeJzYvYK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 55, 534, DateTimeKind.Utc).AddTicks(5824), "$2b$12$bfbYfG5IosC4ad6Pim8I5ufpvki.nfzff/e.kig6qb9n5ZVdfyC3C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 3, 783, DateTimeKind.Utc).AddTicks(4935), "$2b$12$YRbCKpbwzznVByFKvwofX.u4pxvVmil64mstAvACKmcAlyM7Bk5be" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 51, 764, DateTimeKind.Utc).AddTicks(4093), "$2b$12$OM.wn8GRA/4M2mImSSl.U.mW0A8eZ3dqDtlw9u9es/OKI5qIRBpge" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 54, 134, DateTimeKind.Utc).AddTicks(2897), "$2b$12$vX3eMscWS9Flio9AGi5aO.uubLBfdxUCp2uHmO78YDlmHPaCkjudG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a70a25e3-1d3d-3e25-2f6d-c728283dce2c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 15, 566, DateTimeKind.Utc).AddTicks(7735), "$2b$12$CCb2ZvkGaY9ZUqUkd2dOnOQmf5E7BviUxiukvoSXn3js8cw8DfzeW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a81af79f-d5c1-b515-0d1e-fe2dbabc780d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 12, 551, DateTimeKind.Utc).AddTicks(339), "$2b$12$QYppc4mXixn8gqCunvesG.kMA0TvLmaBGtv35mCuF3QHd16tT4VFa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a894def6-b00b-6103-0ac7-92aa2bf2a079",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 10, 796, DateTimeKind.Utc).AddTicks(2908), "$2b$12$SxRk5tBssxJ4IrhE/N4RXu//6N3yQFtdUa2mNy/3wQNBmJCl./Mhy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ada69e11-1e1e-3387-80da-a6afa8505ba2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 9, 422, DateTimeKind.Utc).AddTicks(5089), "$2b$12$.luKQWUlRT30vhUt8.kwIuK/BdyvBUduRfq47qCgVXyh9I0E6dWhe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 4, 95, DateTimeKind.Utc).AddTicks(1787), "$2b$12$6pvxgHVPhFqQXfV0/U.MAOpkuoDyUXpkMq/Xup16Sj2vsRJignA1i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 58, 303, DateTimeKind.Utc).AddTicks(8760), "$2b$12$P.0WV1SXtaFjmUPByMDvQ.K/61aYJrNoFkyRJqZC7xJbFBV8DlHb." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "afa4fe08-4af6-cc2b-778f-115de345ebba",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 16, 259, DateTimeKind.Utc).AddTicks(7829), "$2b$12$nPIRJnVswC5foDpdh49m5OooIPI9AIo6QmWKc9afNTpesutUQzyHy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 55, 843, DateTimeKind.Utc).AddTicks(3303), "$2b$12$xtLIX9264Epp7mx8hFjmheiB2roUQhnVyEzgRGZb0g4UiUqdx0QjG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 49, 708, DateTimeKind.Utc).AddTicks(9852), "$2b$12$RdLcr1TM.iDTiCo8DUgvCeGysUGI1LLKwmT/JujvjuJWJxs6.OSM." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 37, 163, DateTimeKind.Utc).AddTicks(9391), "$2b$12$mv8u/5TGK5AbU9u7V9gVluYRRC46wbDfa1rZf1yH4yPYYZrd96ngC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 47, 315, DateTimeKind.Utc).AddTicks(2432), "$2b$12$bQXpNEqcGj76z7wzNV.DMevh/uRBWJkAcA3wM8NVJPwZpjIKMIUzu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 5, 733, DateTimeKind.Utc).AddTicks(1355), "$2b$12$KLdoa0K1aAtox8JZMpNLgeOZh1No37OimsxCa8iETlKndZQ4yQEO." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 41, 302, DateTimeKind.Utc).AddTicks(9534), "$2b$12$b1ovxdcDvfwRxjJxqnKW8OvzViledHAusb6VCB7dIEYgi6Kj9UgQS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 49, 345, DateTimeKind.Utc).AddTicks(3208), "$2b$12$xEXu3we9TDoQ4sIzRvRA4uXGpvk4OhJULU.JsvHzDjy8VFDmNmRWS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 1, 596, DateTimeKind.Utc).AddTicks(1376), "$2b$12$QVc0jrAMurLKOcuMvjdbUOTN1TeolrHvCGYtSi0ZDloK8EUH/YYfi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 6, 893, DateTimeKind.Utc).AddTicks(9332), "$2b$12$zDuPAIiF38SVal3XE3LM2eaOc85U3pi4XlRb5ebaiQ0c12Z4I8JxK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 3, 109, DateTimeKind.Utc).AddTicks(6750), "$2b$12$iNPAKYnrZkOJhpXmpq.9UOS7F7fSsqSpyCIpFT4zdjRweC8lCDGYC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 48, 311, DateTimeKind.Utc).AddTicks(5127), "$2b$12$bkJ27Jz5gCMH3gLc3jGQPOnYSvylNxntVYMhvrXgeazd47xPdTiAO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 5, 369, DateTimeKind.Utc).AddTicks(6219), "$2b$12$qmVMaUtW7oPZe7gBiE.mH.2knw1zVryaVxVENSGlUjlXc/dFWzls6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 56, 917, DateTimeKind.Utc).AddTicks(3594), "$2b$12$/LanjQLXD0zD6..wzE8xTuQWY5BIRRpF4odplkpzIS6O7wIf93txm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 59, 891, DateTimeKind.Utc).AddTicks(6059), "$2b$12$jlxMyoZkBhSCLTnTNJo6H.tkPZaK8foz/Z1eK5FfzmJB7aSM4.dee" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d3f7232a-7eb6-649e-c1fc-ad010f705d7a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 44, 795, DateTimeKind.Utc).AddTicks(3589), "$2b$12$sp.KtH79ucbk2TZ6cZM63etlJkEL6/CsoJZDfSd.X.9vnYKc6tcf6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 41, 975, DateTimeKind.Utc).AddTicks(6175), "$2b$12$NS1XAQq29ShRuEuYdNRTUupasFSesbA1.dYyIJxcm9HZHfHHSi0li" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 40, 191, DateTimeKind.Utc).AddTicks(4433), "$2b$12$40Bbs/Qn9gNY/odSuYqaJ.SSeKhZLACTeEQNcQZgG.hJt7p28rCsO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 58, 617, DateTimeKind.Utc).AddTicks(5745), "$2b$12$.tiNMDMG8DXjdP45hZw2w.mwktFyasimN3imq3f2dMH41unloGItK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 50, 774, DateTimeKind.Utc).AddTicks(3580), "$2b$12$Sz2iSwZifNZn5Bqaee2g8uwoXE6DOoC63byKGtpFyC6U8TqcnXM.q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 37, 613, DateTimeKind.Utc).AddTicks(4615), "$2b$12$1npmEXJNkZXgVxWTj6h0w.VHHkBWFKYc6e2o3ESMlBRbSNW7J8Vnu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 52, 77, DateTimeKind.Utc).AddTicks(7830), "$2b$12$fxyxnJ66.rFK8GEMFlGT6evMhOhwZhfmXI1nS5oGLHGgDuLTSCQSG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd288475-9710-eabb-7cca-449e335c3070",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 8, 708, DateTimeKind.Utc).AddTicks(5364), "$2b$12$gOZA2VSjOANgwrEx9.dvCOFlqSvZgFXWhR5rmNnSXzT4yyhU1RdsK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 42, 653, DateTimeKind.Utc).AddTicks(4760), "$2b$12$kmhXRNZnG.uFHNnl9WmkyOtlXw/gu3vcsyoY8jBf6D6RzorZYekcu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 54, 445, DateTimeKind.Utc).AddTicks(5986), "$2b$12$RdOB7lngzLDgNnGIna72deaK/wBv1kq7CHI61P5XlZjow945dmSAO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 54, 782, DateTimeKind.Utc).AddTicks(590), "$2b$12$0Cm24pLhZCWdqJ4CzGkWnO9nkyDfWdsDua3UP1H22eshXlp7qs/1y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e48c4173-bb79-99df-4cdb-550c4acb9bfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 16, 611, DateTimeKind.Utc).AddTicks(6710), "$2b$12$T05iY6xu/WRpwf3Tgci.jO4OR7ByjfhVeczGG9gItfZe.2r4XN20." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 53, 471, DateTimeKind.Utc).AddTicks(7387), "$2b$12$sbLV.9tu5DLfPz6Wzpoh9eKdxkCBzy00wiC9vgd82UGiRFeBsHNNu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 51, 143, DateTimeKind.Utc).AddTicks(32), "$2b$12$b9yth3L8ooMtBN6tzkvEXe.vKpt0.GhWYKC8al2GIpxFJbQ.q6ZlC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ecd9a403-0fa0-120e-0580-76ac458c1397",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 11, 159, DateTimeKind.Utc).AddTicks(326), "$2b$12$mBQOc7HYUj9oWmrp8G.PY..2Y0l4YI76u9XnHf/jt.C1PXWysVac." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 47, 957, DateTimeKind.Utc).AddTicks(6159), "$2b$12$w/ndP1Qt0CIliSbrFWqRO.s5tnDqpGgLIP4TtB2SiMAxS64NHLNAG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f0af01b8-a5e4-18f8-889c-4863d1166ca9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 14, 904, DateTimeKind.Utc).AddTicks(3523), "$2b$12$KRtpBkZu41K7MjOsmvjvtugOt/98jfmZh/GW1AVGAaTUvgiZGil7i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f828e1ce-18e1-0c76-9535-92a277f7875a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 39, 9, 752, DateTimeKind.Utc).AddTicks(2452), "$2b$12$MOg78XCkkDOugLMSADX4oezY5ZfoiQf0PcIboZ6oCSBpzeWddErEe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 43, 707, DateTimeKind.Utc).AddTicks(2626), "$2b$12$zmcwzfNlMgdblze0./0wp.qKHdMDX6zfdk78XcBoeuhOAL8bVJjSS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 43, 366, DateTimeKind.Utc).AddTicks(5229), "$2b$12$HeTTmrx1vWinjTlbPoQGfuTSFp281BGSfw7bCC/8J1UX.1HGrrgLG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 47, 652, DateTimeKind.Utc).AddTicks(7195), "$2b$12$36jYT4JSdqFygiuFdFa.J.1CkyKXCJmoy/n5O6mDUOqunF5h9af2S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 13, 38, 39, 447, DateTimeKind.Utc).AddTicks(4611), "$2b$12$U9DewoeuLNmjq9ly9jALN.vpPv477Xl5Hu9uxAJeFrl0VxqGkUJDS" });
        }
    }
}
