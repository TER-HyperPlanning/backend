using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPlanningGroupBM1ILSD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "8d1a51f4-7532-f767-7fb9-bb9829556752" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "64b93cdc-56f3-906f-6e4c-2adfe2184501", "1340bb3f-f749-7b9c-e64c-32cc1e407f57" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0048393d-d5a2-01af-d913-bc890fe8b2ae", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "00e55ffe-e77a-1041-83fe-f230819a98a6", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "013a00ac-ac8b-5c01-8a57-5e3a952f41c6", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "015728e2-d208-f4cc-9b3c-b972b482801b", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "02a2a3e4-b5c0-289c-5dfd-95324e623d49", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "02b8e933-beee-fd21-e81d-20c13cc2b9d9", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "035596ea-77a5-4678-2440-1215400176b5", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "03a99c53-fb54-e2d7-6a4a-3c27563d7b9c", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "042bb7cc-acb9-432e-6025-f01f85edc241", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "04ccea8a-4e53-42db-c31a-0e8f2c805783", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "053f68e1-2f0e-089c-76f7-de930e8668f9", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "05bd8efd-7965-885a-712a-23b65c741a8d", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "05c1638f-8bd7-6101-ecb2-b86c4e36c561", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0633fa76-26c4-bbb8-04b7-ac2dffc5035d", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "06db607d-9866-9b91-3737-5d793f448048", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "078427d0-9b6a-f123-fccb-8e5843a2e640", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "07a3cd0f-fe14-505c-acdf-f777e37778f1", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "07f20e2d-9dba-3c0d-6168-ee83fdae9385", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "08859e7a-33b4-e98b-b9ef-f754da6f424b", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0993178d-8c63-8c40-84f9-5f0d8407806a", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0a613941-9193-abf4-25ce-a79ed34acf0f", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0ab1812f-650e-a53a-7a38-d1191221716b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0abc4d04-e557-58b6-e4bc-7e52cfede4f0", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0b0eee80-ebc9-0e27-a0d3-4124d340c71d", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0b13de7b-3a06-5d38-eccf-e9bb8db4be94", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0bc8e3a7-1aed-9f32-20e8-ab95b541caba", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0be92ebb-39d3-323f-c309-af2cbab9b45d", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0c81ee88-383d-927c-6006-4e96a8d886ec", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0ca55a2b-4b81-c691-b83c-cb46471e0616", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0cd4c552-ef7a-3da8-74d3-a0393d836d30", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0cf2cc5d-7bc0-f1d6-49b8-99c8e5afc22b", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0d5335ac-dc82-6607-9000-ce5fb7df023d", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0e09a6c4-a5a1-ce41-7427-98ad5a20a6e6", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0f278cb7-49d5-fcc9-b743-6c6f611b8aac", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0f702402-059d-f301-63c5-f10eae2added", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "10c6170d-a542-dc14-754f-794aa16ea0cf", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "11065baf-e680-3a0f-0ba7-1eca5f0d5203", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "11a47728-c8f9-ee9b-363a-3a89d6c24797", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "11ac6e88-a54d-0fb7-d0af-0368bd55f51f", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1340bb3f-f749-7b9c-e64c-32cc1e407f57", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "13665640-d5be-7545-5e75-b567631717d7", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1452324b-c53c-15c4-079f-4a2000e03019", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1497fba7-91b9-0f9e-413b-a1a7a9487f45", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "165b9f17-2130-1b34-da4c-1235fc6ec986", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "165be93e-3f49-13b1-427e-af18f7d6db8f", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "176b9a55-95f2-70a6-0d8a-c46a6f228bea", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "17ab550a-68a1-728d-c3c0-64c7bc72f3fe", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1828a070-068b-a95d-05bd-97d1aa5306cf", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "18293f33-cf24-6dd0-fea8-750eb629c0de", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "19f2fad4-a69b-5816-5671-7dca8e1f05c3", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1aeee50c-ccc4-bda1-52a4-8d413ffe2055", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1b1697a9-3a2d-fc57-4a13-6eb57d67f819", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1b84325f-12c9-a783-29b9-032c0e6283aa", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1c4cacfb-dee9-07de-5cbc-d5ab91b33773", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1c9c63bf-825c-13f7-fa0e-9f0699f61ecb", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1cd5ed06-8055-c77f-14d6-607ba085772a", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1d041991-5f0e-c23a-8999-aa6d5e5cec41", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1e356af5-9fbd-d306-bbc5-eea3d0b204ad", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1e5eea31-29c3-bc5d-2667-842eff3b544c", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1e95312c-bb54-5051-1d8b-87fa3be05371", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1edd5504-cbdd-721e-c3f8-b14406688ec9", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1f060a0e-833b-9361-4a59-0ffc6ca53af2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1f0d2ada-0af7-a1a9-d34f-e43e47f0979e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1f87bcd1-4567-9f7a-a2c7-c8251419643f", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1fb7b886-b13d-200f-7df6-7ebda0de9ccc", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1fef362a-d1da-0a5a-84f5-8ae89094daf4", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "20ce0656-3d5a-66ab-6bc6-0e90ad09655b", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "21ba83f0-c8cf-756e-d382-667683820599", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "22c1caa2-aa3b-3e37-6efb-8fb7c07f54ca", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2310c342-bed5-4b9f-eba2-02e50ce02e57", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "235b3715-edf8-71b1-9850-c2f6c754d99d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "248bcdbe-1d25-60a0-8656-ea43b2f22920", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2592466e-b4d4-4655-9eb3-6de7071ccf75", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2605d9e6-c136-20c8-1831-a1f1ffd05ec7", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "27157c99-c60c-e69d-0cf7-6d49797717a7", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "27347831-35fb-67fa-ab30-fe2735abbbd8", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "288acd27-59ec-b9f5-160f-bf6e569dbf73", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "28b5dbc2-f5fe-d1df-1276-f0264e5fc36d", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "28cc2966-659a-7c43-550d-d3e856e6eb75", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "29b71050-1d78-d4d7-0445-b899e17f1db0", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2a81166d-6b54-e987-5809-652afadd1182", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2adde9fd-954c-932b-bf95-c574715ee59d", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2b072eec-8afc-2975-cf37-acd3112a3d9b", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2b1ce470-481f-5868-f4ac-26e876e4d79b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2b9b9d22-41a9-95c7-6b24-f4c5298461af", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2bb47397-839a-9256-9cb2-7ca19bbe6f6d", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2c5e7c40-eda0-861b-ff60-079cbd28d62b", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2ccff467-3ffe-b229-11db-213c0682008f", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2cdc1759-9120-bd86-70c9-29940340600c", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2d9a3c10-b1dd-f004-0f69-2e3a4bae5c5c", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2dd686c2-90fb-215c-484b-6abf33d7f0f2", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2ef053bb-a426-74eb-6498-47e542671a5a", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3177b094-26b1-b068-a92e-12b1ea020c51", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3188ef65-4dde-15ad-a99a-83fd6b6c05a2", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3211d60a-a2cc-4aae-e597-0618dc72fd91", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "32b099e1-a3d1-4e0f-9e32-56ec913b08fa", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "333a9e97-7b22-78cf-a2aa-054acbed29d6", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "33629096-47e0-4ae4-df4f-b9b15bb01a06", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "33efd6cb-b6fa-3383-51f3-b5ce1564e043", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3467ad0e-4caa-a9d4-ebe6-b07c78d758be", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "34dcfbf0-bd44-0123-ea20-2bd73d504f1a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "35adacf1-d9c3-d92e-2f59-fd496b6a14db", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3617723f-5fa3-13c5-747b-af12024e1739", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "36d84ce4-f349-afc4-6458-0cf8242cb742", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "36e83abd-b95b-2bff-8076-d432a0d126c1", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "376435b2-4f87-d45c-9d3b-0f1a7fe26993", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "37b5538d-83d9-db1e-c957-873f1f52b8e1", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "384a335b-ead6-a595-1afa-792fa5f1d8fa", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "399b3fe0-a8db-f30b-561a-3eb2fa5d587a", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3a67330d-23e1-7ead-b469-1adf44300612", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3aa7cd04-b4c2-cc6f-b69c-a73c4dc31b69", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3ad232de-dead-1de3-4ef2-1a7a1bcae815", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3adb884d-00f4-7452-b153-172589985de0", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3b42cda1-04cd-5377-70ca-5f9c09522015", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3bd48e65-a546-53b8-11be-9168f9315439", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3c384aff-7c16-316e-ecdf-de092cb63839", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3c4db87f-2c67-8431-5028-cc295a2e3087", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3da16659-e34c-a32c-0e88-f464e813b606", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3eb63cdb-d52f-72b1-555a-1bc3287a6e99", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3f839a52-c325-f2fb-b74a-c0f31808b557", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "40137d15-bd16-30bb-80eb-aaabd3357137", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "412ef48d-01be-55ef-5ebb-4a78431136ee", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "42046a6e-e4b1-6bd2-f0ac-7fab8592bd81", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "43370ead-9fca-c16d-cee6-46c82788d337", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "43dba54c-ac20-eaf1-aa78-e5651b270a61", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "44aaf7b1-791f-8f82-c0da-7ebb41fd7242", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4557c67c-df81-999d-af4c-0c484bf21983", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "45af8d84-cfe9-7ed6-18a6-0d89016bac6d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "45ddd76f-2146-20dd-4044-b056b0e89930", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "45ef5fb7-f21c-293d-6e77-44f359cf722d", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "45f1ab9e-4cf6-ec9c-2b17-9c7adc6a6cc6", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4655bd8a-abe0-ed09-0f95-f22d7f8c4bfb", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "489eb465-3148-2790-459d-d37743bc1fc9", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "48bf7f82-1ca6-e351-83a6-20588e74f9d9", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4903fa5b-de46-5fc6-a28e-0f0cd0ba7c7d", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "49cbfa48-c9a4-d8f0-1a8a-1191d3b61d23", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4a1350c1-b7cd-0abf-d114-716504b16a7c", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4a9e4b89-4361-e36c-5dbd-676385437cbf", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4acd9232-d4af-fc54-d001-272120ba0f3e", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4af77d70-a98f-9201-b485-970850a53a5c", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4b064eb6-10c3-39c3-883d-0424a8ea810b", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4b3fa2e9-13d6-815a-1991-3379fa24d213", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4c6b6e9f-a614-de54-097f-4c095f09b343", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4c74eddf-31df-3d9c-e01a-935aab29f802", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4caafe08-88b8-f527-d617-30c43c95947c", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4cd5f36a-93f7-1b54-cabe-8128f0dfd674", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4dd2b11e-e285-eba7-7e11-217a1f1a5016", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4dfa6633-4102-2dee-0768-2c3ef94f351a", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4e6ad58e-34f9-3aad-d394-6c22e98c28e6", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4f96e085-90db-e38e-531a-45f6abfbd4b5", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "50278dc0-3ccf-66c5-6639-d8cf2c3a45c3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5119b0f0-763d-45e9-dabe-2e015463004e", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "52337c23-7694-cbf4-76c9-3dd7f121c476", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "52659ecb-a874-76cd-e727-9e93c72dd9e6", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "528cf0ef-0ad8-1440-1a6a-d89ca66b78ef", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "532a40a7-77e5-d8ad-e9d1-5ac05b8f1fb5", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "55803d94-5a30-5537-708f-9a29af0bb608", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "564788db-7533-ad1d-c822-688c966ea182", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "573e2677-41f8-31b7-9951-eb1100b2132b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "57ab359d-3846-c2bb-ed46-058d12813eb3", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "57be9b47-7cba-8ebb-640f-e274971152ab", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "58ee5b4f-5255-02ce-b2d5-07a5c8ca7673", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5928a75b-88dd-4a5d-ca54-6d5bfaeab6bc", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5949817d-4426-d92c-eda5-7bc93010d7e7", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "597d6d71-d02d-d972-6906-47dd94af9989", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5a62f7f4-969e-0b36-2084-91de9f91eb34", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5ae81cf8-1483-9145-cede-a1d072e27dfd", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5bd766de-0af8-d57c-839b-1f71e24d41df", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5c070507-4cfc-7437-9688-8a3fa0311229", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5c440b1b-c528-b1b7-ea36-c8c51c52f6a9", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5c67d3c5-f64b-9042-df1c-37f8122fe8e8", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5cb76838-2148-bb64-3c35-e732e56238c5", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5de5e483-bf65-3751-6439-ad5bc91a890e", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5e21308f-4214-8f32-e85e-871599e6ea4f", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "60472859-d8c8-a48d-4c3f-0ac18643491a", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "61a2c1d3-96fb-71aa-55cf-33c674680627", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "628d5b85-fb1d-3be2-1666-dd4ae4465c58", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "631019a5-52aa-5f92-b516-9f02ab27fd0e", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "63c687a3-67c0-9d3e-4bda-fc7d26ed4e96", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "63d0e165-8c30-09b2-576d-a0517c4317d8", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "64232e02-58b1-49f9-ed14-4ed2bc2cca29", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6430ecc4-8bfd-8a62-c7ff-1a819c81ab12", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "64ae45c7-d78f-ee6d-73c9-f4f9332e8811", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "657a5804-95d2-bbc9-e3a8-cb27991a4ff7", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "67ace8f4-0f30-1cd2-b6ca-071e23ec2cba", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "68043ff2-95b0-99fe-0120-ed51205672e6", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "698fabe1-43b4-9c65-86f3-65500666149f", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6a312723-378f-452f-ccee-cc8c2ce7a27a", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6a3a2ef3-ae9a-b881-f025-d9d175543545", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6c176ab9-ca29-361a-d27f-4b7f010acd63", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6d35848e-614b-c210-ba42-5c08c34d2f65", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6d8a71bd-3b1b-2819-0f1c-7c6f1615f245", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6db8b590-545c-5247-9e1a-c51a90a3b619", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6e9db836-8335-157d-2b66-184effda711e", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6f1680fa-747d-53dc-d2ab-105243a1b1cb", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "70ee2824-090e-3fe4-2794-10f0c7f3f893", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "70fb017b-27b3-32f4-e15b-031807d3041f", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "71f57d4d-faa9-0cc6-82c1-fd3dd9f6c1c7", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "72a781ee-c6f9-c7a3-a6bb-dd39961e522e", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "733a7970-863f-19e0-960b-550ffd7ebfb6", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "73532c4d-af3e-83d4-8425-4cc26ab37aba", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "73aa21b6-6e89-d724-606a-ff4a561441d6", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "73b44f51-5601-290c-5594-135cc98de227", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "73c7563d-39e9-4606-310e-2e3e31c378c6", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "73ef9028-ebb9-10e0-b568-0ab21799c6da", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "749b811e-fb13-4288-9280-1a0ac6ae1357", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "75a4e70d-830c-2c84-3356-f012e00406b8", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "764f2bb3-6cc5-14e4-6520-336d80427992", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "765a6d8c-c0fe-7187-2aa2-2346375627a4", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "77d7f16d-5ae4-b603-5a85-8890f1777158", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "77d8f4d1-c71b-c484-866c-ad2bbcee8d58", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "77f874fa-2a1f-f514-bfce-3249bea7bc6d", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7872c32e-8849-26d9-8279-dae0014cea81", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "789d8ffd-898f-2aaf-f340-7783135e9a27", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "78aaeff9-5997-2b9e-dfff-14892277163a", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "78ecaeff-34c8-c97c-b69b-0c6690b4a848", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "790b2537-789c-2d30-aa17-fddb3dcc7e87", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "79a2515b-c784-5fe3-20cb-1548b67dc9d2", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "79c2c8a5-b015-8ddf-6df6-251e26904dd1", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7a234537-baf1-3524-b7d5-0e086755bc47", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7a29af3a-374b-0d68-6adc-9c128bf68f2c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7b8b3263-39e1-5145-8a7c-922bed22cd08", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7d9ad1c8-2f22-2da1-d373-f6781481e17c", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7ed7d5ba-b85a-94dc-e41a-951452adfd76", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7ee8ecf2-a327-72a4-39a3-f550b848e994", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7ff81ee8-300d-ddc6-319d-7dfa7218fd58", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "81a26782-c24b-32fc-fb34-09efe90725d6", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8364106c-5f3a-598b-2ac0-3ed214205fef", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8390a9f6-0a93-19fe-59e1-f9f55f5ddd6c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "844e7674-593d-adb3-1440-7f2a1fab57a4", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "849b1616-601b-3dd9-557b-16d80403b1dc", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "856171a7-b9ac-4830-b2d8-9cee3fdcade6", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "87e48982-f0da-a5f3-0b94-9ea581b65f84", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "882e9f04-341b-9074-4919-525657521655", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "895409e2-f453-7a65-bb3d-25c0b35987f2", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8976f83c-4baf-c2f0-376f-a1e360cd7ef0", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8a6cc122-2f10-d00a-54f5-d2ac0bc48657", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8aa6d384-bddc-d1af-b54c-f4cbd87e1b21", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8bd34289-d07c-921a-c6cd-bb4b146fdcc3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8c6aca27-a8a8-0c0f-1002-e52f6eb2561b", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8cc8c34e-a72a-148b-03b0-f8ee5fd74ca2", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8d189383-f0b2-811e-27a7-413d45d77bc7", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8d1a51f4-7532-f767-7fb9-bb9829556752", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8d236de0-d974-e10a-d60c-6eb6d6ee45ba", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8d39f934-18e4-6144-1d94-ded1104d046b", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8da9b865-ec75-e977-9c4c-609e2b0b4bbd", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8e09b870-6631-2b58-4357-c8e2715354f3", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8e209ba0-d4c5-1bc4-1217-b046044b7cbd", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8e7a8865-e1aa-c65a-3f83-fb8382e84b73", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8ff68495-91b6-7636-684d-e74d8db1cef3", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8ff891c5-6be8-cf4d-c081-c3c877e21d1b", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8ffc693b-16b1-8101-db46-047a98051af7", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "90ef151a-2989-8953-bd19-90dd0821143c", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "91e6ee14-7d3d-ee2a-2bde-63a3eb189429", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "91fc97eb-284d-bef1-4eaf-5747976f12d9", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "935c4906-2965-0faa-073b-4831ee9f3c48", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9419d91c-fb6e-946f-bacf-338bbfb69b57", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "945a3a2c-b742-5cf0-08ae-46eb85a20a36", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9499db5d-73f2-29e0-6699-6fee9b30efcc", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9651c893-06d6-049d-48ea-4068fa9fe013", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "96b1462d-19ec-a38c-05a7-8c261b7ce639", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "96b814eb-178a-5fe2-b4a6-eb71b6006fa1", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "978d0096-a189-7be1-55f4-a61ca61d2828", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "985812bb-b587-86fc-300c-964d20bb99fe", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "98a8f4b6-5e8d-2f6c-8758-6666656e481a", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "98f3fdc5-c2cd-f68b-96bd-732dd43c8529", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9971fa58-a988-4a0b-0bde-87bf140e6b77", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9a87aa15-1dd8-4cbb-afbc-52337f77c2ff", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9ad1b67e-6011-dbfc-53db-ddffab249a2d", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9af6f1ff-5c76-981f-16b1-cff0e00e7faa", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9b05b001-4131-ed42-634c-10196745c2d2", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9b3bd5a9-f7ad-eece-81d5-eb1e34b3e9cc", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9c811b0b-75ce-1d6f-75bc-1c02b0f27f3c", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9c845855-86f5-5a7c-6a9a-ab196a2fc168", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9d09c449-338c-e3e8-fc9f-e17d64f8f16e", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9d1207eb-453a-4a13-6571-c8cfdaa7475e", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9d2229a0-0c0a-04e6-50eb-b3326b957e75", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9d3d2f6d-074a-0e8a-04a1-d64fad0a7ca5", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9dcbb2e1-1288-8061-7552-95fc4a54127f", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9dd52fbd-e3a2-3778-9def-1607fcba8a14", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9e3a1c36-c83f-de64-7a15-a427c2d53ea7", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9e55967e-b361-b475-1d74-2da173a313ab", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9eceb91a-7f9b-fbe9-d071-540a01948571", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9fb457e2-45bd-9c59-9632-dd2b36d435f2", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a0670202-2854-2e50-8de5-c40c09ce45d4", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a0923ee7-dc84-4fb7-e960-64ba86e14501", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a0f2d093-4ef8-8c6e-433d-875f5fae4ae6", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a1f1d7a7-bddb-23c9-a786-8be00afca275", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a1f48c0f-fc61-d167-ac87-a547004aa023", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a228ae2d-6872-3077-746d-e7caa9826050", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a2dc9424-44ed-80c3-e2bf-2fc537ce7c31", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a2e87a66-9129-c8b4-8f19-1a7b0003f9b4", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a2ebb53b-d53f-3243-6067-58d54306b7f3", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a37ff634-cd9b-ef97-1174-7895dac5142a", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a39e1659-d76f-b466-dcb4-6e403c08235e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a41f5899-263a-2ba5-d89f-83fcb8615004", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a59870d1-3aa1-1ffd-b0b0-5f0eef5f14e4", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a5ad0348-d074-cc01-5380-d87b5fe5dc57", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a6df2aeb-dc33-065d-ecc9-bf2472024f34", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a6e15963-ccee-056e-b08a-7b411a5faed5", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a7e8a312-e5ac-380e-64c0-58e134a0eb3a", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a82312a1-29aa-9773-85f5-3a79b946447e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a88474d9-7b40-75c4-103c-4756fefc5223", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a987acc4-6719-b547-a33c-941a36a8ac2d", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a9c039df-e5b6-5874-9c20-40b1c8c81a18", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "aa1b61b5-90b5-7fd4-8e47-7cc758c171b3", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "aa4fa9c2-81bc-294d-cb27-c2b5b55fab2b", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "aa5e6d3e-6879-9a9d-240a-c4b8d59d977d", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ab988871-3db3-91fd-fdc6-c24dc63b2ff3", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "abc1a019-0ef7-cbc6-fcf3-2c8326df2fe4", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "abc6b243-5588-2a14-659b-cd1c72698bf6", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "abf10a27-3ac6-2e58-96f8-def34af99ffe", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "abfa578c-1059-0e95-41fc-6b4a6cc5bd35", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ac61a898-07d6-ed31-0122-23756b48dd8b", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ad086427-ad88-1b14-74dc-3c734d9f8fb0", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ad3ad1fb-e09d-f4dc-0ea3-acb109796d53", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "af3d7485-acdb-8cea-67a2-6784f57fb5af", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b138dcf7-c96a-95da-7950-ca0ebeca603b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b1a95a03-38ca-ee92-017c-5209fe2a86e6", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b1c46032-68bc-da8b-5947-ff34f797a32a", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b20737f2-721e-1d65-17b2-417ab128a58f", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b383ee88-a3d4-9a92-14b8-4ad063d05858", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b3a131b9-2c77-3894-f208-cb79d39faca2", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b3a8c3e6-2323-b55f-9c32-0b87693deb72", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b4d3824a-cc8b-bf10-4c1a-b8023aea893f", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b5308f06-151e-ee1d-d1d9-567a5c3df214", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b585a522-6b7d-2bde-80fe-59857d64cf59", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b5e54f3a-245f-7903-3b7d-8ef6772d70e7", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b646c1a0-6866-82ac-52d3-c26c028a197a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b648d7d6-c04b-1683-2bcc-c8232f2c923a", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b738fca4-5187-2cb8-fe64-bf110f27dc19", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b73fb90a-f41a-0c50-2dd7-6d2cda329ea9", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b79bbe9d-8926-288f-0bdc-9007eb0b656c", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b7ae36e0-29fa-4028-0fd4-b1091ee273e1", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b9740ffe-3edf-4783-e5ad-69012f24a391", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ba235bd2-9ad8-ed2e-d547-fbd573117230", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bb2fb4ac-48e3-3274-181a-669eb9886be5", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd079d7b-b8ac-b648-0a0f-fa0d75c647d2", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd194d03-59f8-3e62-32e6-fe4f7a3b879b", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd2342ba-3dc5-ee86-3dfd-38ca414e3fca", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd26c6ec-d165-4279-e832-a0635cb9a1e5", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd3a37e9-fe59-1c15-b82a-aecb60558898", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd5c5e1b-5be8-03c6-a5e2-39063b12d65e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bdd09408-1595-3d9e-9ba2-750a734e3f90", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "be8499f8-c80d-6ecf-0314-d9a438061154", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bed3ffa9-e96c-f7e5-eb1b-e22f1ec71421", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bf02e8ed-6ab9-9191-d50a-9c05cf34fcef", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bf542d10-d3a3-6bc7-9bfc-b0462086ba9b", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c0028500-4cdc-8005-bb90-ed6399529b3f", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c025d9b6-56e5-4289-89de-69f2f2d1d013", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c054a00b-472b-2614-aac5-8337913cbe70", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c0c452c8-6e09-202a-74cc-724212b93b85", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c105f40c-b412-3a64-e00a-cb1f14df7cd8", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c10a0baa-1e4b-54ba-5d59-5c584d8ae3ec", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c3f29e56-c774-c1c8-366d-35e9ddfc64be", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c437ad27-25ad-790e-ec14-e4cbb2c7d54f", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c470d37a-a616-4624-0e1b-a3d600ba3c08", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c49feb4a-a697-d42a-ade9-8a8f6028bbfc", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c4b97e73-7182-c9d9-9bf7-916db4bdf6b3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c5a0b44d-30ce-829b-93a7-716afe1e5163", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c65167ab-7aa0-3908-3e63-2698d06fa1b4", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c757b477-07a8-d325-d4cf-a0a78e352f66", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c7a68e32-cda7-b864-e7f1-ba2ae5fab309", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c7e266d7-3097-a994-1174-d3cf1608c41e", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c8006108-d31d-3fc3-8118-4a00aa1228c8", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c83566fe-4da0-b680-43f1-aaa1880db549", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c888fa0e-3ba4-8446-ca99-35f2dd69819a", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c8e06257-6008-61b4-4b53-278d79854078", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c93aedf9-5f94-9dc3-c599-63c7235e54e4", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c9db2283-f63a-871f-3474-0b3644830bf8", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ca31003d-2c4d-41c8-9b9b-4c61347b3f44", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cbff8567-0725-b204-ba70-6b3ea17679a2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cc89b80d-6432-18eb-4c1f-89d48642289d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cce2ada9-2f2d-ce10-1509-2e3988f0040e", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cd47af08-b065-d7f9-957b-4331cf499a84", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cd4a2b32-4de8-cae4-d813-3a9c528bce84", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cfb44862-44a4-9cc9-5636-6fc938d47be3", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d0425968-0a5c-0a9f-3897-b55f4e22a274", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d051e973-698c-58dd-bda6-63d696077ad3", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d07bb88c-bdf7-0c6b-a371-44ce794f7d3e", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d2e5a5cc-7ca8-1bdd-b989-bd9c35ca0e88", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d39c0714-beb7-9fc0-1fba-437d66426189", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d4f123f5-ec66-2062-e7da-d35c3ee57eee", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d6004a9b-1c74-80de-a857-6060eaf7261d", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d6592817-12c5-1929-7656-0bc610ac5bb8", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d7752dd6-7176-d04e-be06-8422283faab2", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d7fdd83a-70db-66ab-6375-91cd319db355", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d810fb97-00e7-f2a0-0985-acffaf11b187", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d83d4cf6-076e-8942-5a26-f3fb3c195bbf", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d887248e-7c1b-b541-76ce-6a1429625aa7", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d9396d48-fd20-a52d-70b5-3f2085f7cfec", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "da917375-989e-aa66-3705-7fb13adc13b7", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "db8cd639-647a-8b58-26e1-09ded6668cba", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ddc05051-6ba0-9876-0a13-ebc3052d2b4e", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "de4618b3-b26c-8e28-0a99-ae5525670cd5", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "df6e2e51-1635-c552-c2e4-47c20b623af6", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "df7466ab-6cd7-323b-3000-734d0a87e629", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dfa77c24-d946-d3aa-8143-2d2980309d6b", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e02b7f77-b4c9-bc10-276e-685319e06cae", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e0423095-2fec-629c-28ab-8d15fc453cf0", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e04a9235-6450-7289-01d9-1e0c6d60181e", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e0a5ac38-0109-c23b-cdf9-bfcc771a6956", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e1cc35de-1693-fdc6-8795-0119f8f61623", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e291f668-1c34-8928-0af9-193ae7989012", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e29f5f7f-1c7a-cc69-3cb1-b84d99512a10", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e3444b28-a5e6-7291-e9e2-d64fc228bdec", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e44ff3f4-6ff9-8af0-f12a-63b3268c710c", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e4b69797-276b-44dc-f691-2839ccadbc59", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e549f908-0b9f-bc96-93e7-a3debcc701cd", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e5534c19-113d-4705-a9f8-5a5534f534bf", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e792e81e-cd41-7b11-d310-735b5b93ea00", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e7ac8242-2bdf-3ea8-34ed-376cd6d4cc6d", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e8e08ba6-7aaa-47b0-1ba8-5672399ddd9c", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e91072de-8876-66b5-cceb-4cfa6eb00b82", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e915fc4f-2425-c1b9-7448-6f93374f4d93", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e992a0f0-7cfc-f1ea-667c-c308c7560737", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e9db33d6-c21d-844e-fbab-1988c3f1c501", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ea01f8ea-b73e-be93-9a72-7db9fa21dd8c", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eb190148-b365-1499-4bcf-34a8307d3ae5", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ec46c0fe-0b44-80a4-27fb-211fc8190195", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ec4fae02-dbe6-d8aa-4d3d-da1c38fb7f7c", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ec725cd5-16d9-76f8-27ad-d5aa62b86c1b", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eccdc834-73c7-adb9-9ff5-6255b7257146", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ed3daf70-fcb0-7b32-f292-becdb3eb3eb3", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ed67f473-5441-c705-b174-e26119a10316", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "edfda5e7-5084-880a-022d-29069aa5cbfa", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eef85155-102e-817b-0de0-1e2e035404d7", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "efa6a2ea-b018-6b26-35e2-0f08ee59c252", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f129bad2-788c-bc9e-89cf-60039b8e604a", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f14fc5c6-c061-1111-1e79-f268130aaa74", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f16f91c3-4de3-d09f-4071-921f313f15a8", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f1707df7-3aa5-d08c-ea15-5bd6269c6cd3", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f24c8abc-3f83-5162-2e6c-56859c5c056b", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f2ffd04c-6cf2-db85-a42a-bdb85851cef7", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f3b1abe6-fc82-148f-0715-4d25554e7fa3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f3b3e51e-629c-d167-01db-a6540d350738", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f59455ff-4ce7-d960-dc83-0e9693fa47a6", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f602e4c9-bc99-4d36-b8af-7f9dcb88d01c", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f7033651-e69a-4324-fbe2-d0182b44a808", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f74652db-dc7b-535b-b335-595d87ad4277", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f7502be8-0a9a-4d63-69fe-fba66d3fc191", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f7875753-a25c-5e48-6009-e5dbdd89d86e", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f81f9d3a-35d8-f873-8f95-45726a1387a3", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f8eda48e-36b2-3c80-2a8d-45ed824d3d02", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f95addc7-9b43-8f11-22be-04c9b277bbbe", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f9f1b201-c78a-46fd-3f7d-701f0cb9d80b", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fa8863c0-67b0-85c7-5ff5-bf270e35170e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fa95ca2d-6015-d738-9bbe-e8cba5195c60", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "faa58a8c-d950-2e5f-5a1e-2fb3331958ca", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fb2537bc-4439-2071-55a0-b6407e36e5e0", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fc38688b-a5a5-0a3e-f73f-a130d3c1ade0", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fcbbff35-ac21-d887-426b-fc0c5af9fa0d", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fcbeb7c4-fd9c-40cc-b15e-4ddf4d47233b", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fd1bee15-e7b2-9c75-8f36-bf9c4510c9c5", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fea0de9b-2eaa-f28c-2118-dc74ea12b4b5", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "1340bb3f-f749-7b9c-e64c-32cc1e407f57");

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "8d1a51f4-7532-f767-7fb9-bb9829556752");

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "session_id", "course_id", "date", "Description", "end_time", "mode", "room_id", "session_status_id", "session_type_id", "start_time" },
                values: new object[] { "6eeab54d-48f6-9f68-1ca3-b7ed0c89b7cc", "f8c83971-d090-c665-8911-cd645e1a3c87", new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 18, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7d12ed93-7363-9686-49c3-77ad3ccb2da0", new TimeSpan(0, 8, 30, 0, 0) });

            if (migrationBuilder.ActiveProvider == "__skip_legacy_teach_seed__")
            {
            migrationBuilder.InsertData(
                table: "Teach",
                columns: new[] { "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "0048393d-d5a2-01af-d913-bc890fe8b2ae", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "00e55ffe-e77a-1041-83fe-f230819a98a6", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "013a00ac-ac8b-5c01-8a57-5e3a952f41c6", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "015728e2-d208-f4cc-9b3c-b972b482801b", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "02a2a3e4-b5c0-289c-5dfd-95324e623d49", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "02b8e933-beee-fd21-e81d-20c13cc2b9d9", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "035596ea-77a5-4678-2440-1215400176b5", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "03a99c53-fb54-e2d7-6a4a-3c27563d7b9c", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "042bb7cc-acb9-432e-6025-f01f85edc241", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "04ccea8a-4e53-42db-c31a-0e8f2c805783", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "053f68e1-2f0e-089c-76f7-de930e8668f9", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "05bd8efd-7965-885a-712a-23b65c741a8d", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "05c1638f-8bd7-6101-ecb2-b86c4e36c561", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "0633fa76-26c4-bbb8-04b7-ac2dffc5035d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "06db607d-9866-9b91-3737-5d793f448048", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "078427d0-9b6a-f123-fccb-8e5843a2e640", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "07a3cd0f-fe14-505c-acdf-f777e37778f1", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "07f20e2d-9dba-3c0d-6168-ee83fdae9385", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "08859e7a-33b4-e98b-b9ef-f754da6f424b", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "0993178d-8c63-8c40-84f9-5f0d8407806a", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "0a613941-9193-abf4-25ce-a79ed34acf0f", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "0ab1812f-650e-a53a-7a38-d1191221716b", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "0abc4d04-e557-58b6-e4bc-7e52cfede4f0", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "0b0eee80-ebc9-0e27-a0d3-4124d340c71d", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "0b13de7b-3a06-5d38-eccf-e9bb8db4be94", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "0bc8e3a7-1aed-9f32-20e8-ab95b541caba", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "0be92ebb-39d3-323f-c309-af2cbab9b45d", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "0c81ee88-383d-927c-6006-4e96a8d886ec", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "0ca55a2b-4b81-c691-b83c-cb46471e0616", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "0cd4c552-ef7a-3da8-74d3-a0393d836d30", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "0cf2cc5d-7bc0-f1d6-49b8-99c8e5afc22b", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "0d5335ac-dc82-6607-9000-ce5fb7df023d", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "0e09a6c4-a5a1-ce41-7427-98ad5a20a6e6", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "0f278cb7-49d5-fcc9-b743-6c6f611b8aac", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "0f702402-059d-f301-63c5-f10eae2added", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "10c6170d-a542-dc14-754f-794aa16ea0cf", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "11065baf-e680-3a0f-0ba7-1eca5f0d5203", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "11a47728-c8f9-ee9b-363a-3a89d6c24797", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "11ac6e88-a54d-0fb7-d0af-0368bd55f51f", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "13665640-d5be-7545-5e75-b567631717d7", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "1452324b-c53c-15c4-079f-4a2000e03019", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "1497fba7-91b9-0f9e-413b-a1a7a9487f45", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "165b9f17-2130-1b34-da4c-1235fc6ec986", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "165be93e-3f49-13b1-427e-af18f7d6db8f", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "176b9a55-95f2-70a6-0d8a-c46a6f228bea", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "17ab550a-68a1-728d-c3c0-64c7bc72f3fe", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "1828a070-068b-a95d-05bd-97d1aa5306cf", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "18293f33-cf24-6dd0-fea8-750eb629c0de", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "19f2fad4-a69b-5816-5671-7dca8e1f05c3", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "1aeee50c-ccc4-bda1-52a4-8d413ffe2055", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "1b1697a9-3a2d-fc57-4a13-6eb57d67f819", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "1b84325f-12c9-a783-29b9-032c0e6283aa", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "1c4cacfb-dee9-07de-5cbc-d5ab91b33773", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "1c9c63bf-825c-13f7-fa0e-9f0699f61ecb", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "1cd5ed06-8055-c77f-14d6-607ba085772a", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "1d041991-5f0e-c23a-8999-aa6d5e5cec41", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "1e356af5-9fbd-d306-bbc5-eea3d0b204ad", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "1e5eea31-29c3-bc5d-2667-842eff3b544c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "1e95312c-bb54-5051-1d8b-87fa3be05371", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "1edd5504-cbdd-721e-c3f8-b14406688ec9", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "1f060a0e-833b-9361-4a59-0ffc6ca53af2", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "1f0d2ada-0af7-a1a9-d34f-e43e47f0979e", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "1f87bcd1-4567-9f7a-a2c7-c8251419643f", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "1fb7b886-b13d-200f-7df6-7ebda0de9ccc", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "1fef362a-d1da-0a5a-84f5-8ae89094daf4", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "20ce0656-3d5a-66ab-6bc6-0e90ad09655b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "21ba83f0-c8cf-756e-d382-667683820599", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "22c1caa2-aa3b-3e37-6efb-8fb7c07f54ca", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "2310c342-bed5-4b9f-eba2-02e50ce02e57", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "235b3715-edf8-71b1-9850-c2f6c754d99d", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "248bcdbe-1d25-60a0-8656-ea43b2f22920", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "2592466e-b4d4-4655-9eb3-6de7071ccf75", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "2605d9e6-c136-20c8-1831-a1f1ffd05ec7", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "27157c99-c60c-e69d-0cf7-6d49797717a7", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "27347831-35fb-67fa-ab30-fe2735abbbd8", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "288acd27-59ec-b9f5-160f-bf6e569dbf73", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "28b5dbc2-f5fe-d1df-1276-f0264e5fc36d", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "28cc2966-659a-7c43-550d-d3e856e6eb75", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "29b71050-1d78-d4d7-0445-b899e17f1db0", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "2a81166d-6b54-e987-5809-652afadd1182", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "2adde9fd-954c-932b-bf95-c574715ee59d", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "2b072eec-8afc-2975-cf37-acd3112a3d9b", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "2b1ce470-481f-5868-f4ac-26e876e4d79b", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "2b9b9d22-41a9-95c7-6b24-f4c5298461af", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "2bb47397-839a-9256-9cb2-7ca19bbe6f6d", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "2c5e7c40-eda0-861b-ff60-079cbd28d62b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "2ccff467-3ffe-b229-11db-213c0682008f", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "2cdc1759-9120-bd86-70c9-29940340600c", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "2d9a3c10-b1dd-f004-0f69-2e3a4bae5c5c", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "2dd686c2-90fb-215c-484b-6abf33d7f0f2", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "2ef053bb-a426-74eb-6498-47e542671a5a", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "3177b094-26b1-b068-a92e-12b1ea020c51", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "3188ef65-4dde-15ad-a99a-83fd6b6c05a2", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "3211d60a-a2cc-4aae-e597-0618dc72fd91", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "32b099e1-a3d1-4e0f-9e32-56ec913b08fa", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "333a9e97-7b22-78cf-a2aa-054acbed29d6", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "33629096-47e0-4ae4-df4f-b9b15bb01a06", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "33efd6cb-b6fa-3383-51f3-b5ce1564e043", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "3467ad0e-4caa-a9d4-ebe6-b07c78d758be", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "34dcfbf0-bd44-0123-ea20-2bd73d504f1a", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "35adacf1-d9c3-d92e-2f59-fd496b6a14db", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "3617723f-5fa3-13c5-747b-af12024e1739", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "36d84ce4-f349-afc4-6458-0cf8242cb742", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "36e83abd-b95b-2bff-8076-d432a0d126c1", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "376435b2-4f87-d45c-9d3b-0f1a7fe26993", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "37b5538d-83d9-db1e-c957-873f1f52b8e1", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "384a335b-ead6-a595-1afa-792fa5f1d8fa", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "399b3fe0-a8db-f30b-561a-3eb2fa5d587a", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "3a67330d-23e1-7ead-b469-1adf44300612", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "3aa7cd04-b4c2-cc6f-b69c-a73c4dc31b69", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "3ad232de-dead-1de3-4ef2-1a7a1bcae815", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "3adb884d-00f4-7452-b153-172589985de0", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "3b42cda1-04cd-5377-70ca-5f9c09522015", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "3bd48e65-a546-53b8-11be-9168f9315439", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "3c384aff-7c16-316e-ecdf-de092cb63839", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "3c4db87f-2c67-8431-5028-cc295a2e3087", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "3da16659-e34c-a32c-0e88-f464e813b606", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "3eb63cdb-d52f-72b1-555a-1bc3287a6e99", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "3f839a52-c325-f2fb-b74a-c0f31808b557", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "40137d15-bd16-30bb-80eb-aaabd3357137", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "412ef48d-01be-55ef-5ebb-4a78431136ee", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "42046a6e-e4b1-6bd2-f0ac-7fab8592bd81", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "43370ead-9fca-c16d-cee6-46c82788d337", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "43dba54c-ac20-eaf1-aa78-e5651b270a61", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "44aaf7b1-791f-8f82-c0da-7ebb41fd7242", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "4557c67c-df81-999d-af4c-0c484bf21983", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "45af8d84-cfe9-7ed6-18a6-0d89016bac6d", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "45ddd76f-2146-20dd-4044-b056b0e89930", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "45ef5fb7-f21c-293d-6e77-44f359cf722d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "45f1ab9e-4cf6-ec9c-2b17-9c7adc6a6cc6", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "4655bd8a-abe0-ed09-0f95-f22d7f8c4bfb", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "489eb465-3148-2790-459d-d37743bc1fc9", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "48bf7f82-1ca6-e351-83a6-20588e74f9d9", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "4903fa5b-de46-5fc6-a28e-0f0cd0ba7c7d", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "49cbfa48-c9a4-d8f0-1a8a-1191d3b61d23", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "4a1350c1-b7cd-0abf-d114-716504b16a7c", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "4a9e4b89-4361-e36c-5dbd-676385437cbf", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "4acd9232-d4af-fc54-d001-272120ba0f3e", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "4af77d70-a98f-9201-b485-970850a53a5c", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "4b064eb6-10c3-39c3-883d-0424a8ea810b", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "4b3fa2e9-13d6-815a-1991-3379fa24d213", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "4c6b6e9f-a614-de54-097f-4c095f09b343", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "4c74eddf-31df-3d9c-e01a-935aab29f802", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "4caafe08-88b8-f527-d617-30c43c95947c", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "4cd5f36a-93f7-1b54-cabe-8128f0dfd674", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "4dd2b11e-e285-eba7-7e11-217a1f1a5016", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "4dfa6633-4102-2dee-0768-2c3ef94f351a", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "4e6ad58e-34f9-3aad-d394-6c22e98c28e6", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "4f96e085-90db-e38e-531a-45f6abfbd4b5", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "50278dc0-3ccf-66c5-6639-d8cf2c3a45c3", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "5119b0f0-763d-45e9-dabe-2e015463004e", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "52337c23-7694-cbf4-76c9-3dd7f121c476", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "52659ecb-a874-76cd-e727-9e93c72dd9e6", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "528cf0ef-0ad8-1440-1a6a-d89ca66b78ef", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "532a40a7-77e5-d8ad-e9d1-5ac05b8f1fb5", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "55803d94-5a30-5537-708f-9a29af0bb608", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "564788db-7533-ad1d-c822-688c966ea182", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "573e2677-41f8-31b7-9951-eb1100b2132b", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "57ab359d-3846-c2bb-ed46-058d12813eb3", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "57be9b47-7cba-8ebb-640f-e274971152ab", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "58ee5b4f-5255-02ce-b2d5-07a5c8ca7673", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "5928a75b-88dd-4a5d-ca54-6d5bfaeab6bc", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "5949817d-4426-d92c-eda5-7bc93010d7e7", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "597d6d71-d02d-d972-6906-47dd94af9989", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "5a62f7f4-969e-0b36-2084-91de9f91eb34", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "5ae81cf8-1483-9145-cede-a1d072e27dfd", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "5bd766de-0af8-d57c-839b-1f71e24d41df", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "5c070507-4cfc-7437-9688-8a3fa0311229", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "5c440b1b-c528-b1b7-ea36-c8c51c52f6a9", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "5c67d3c5-f64b-9042-df1c-37f8122fe8e8", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "5cb76838-2148-bb64-3c35-e732e56238c5", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "5de5e483-bf65-3751-6439-ad5bc91a890e", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "5e21308f-4214-8f32-e85e-871599e6ea4f", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "60472859-d8c8-a48d-4c3f-0ac18643491a", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "61a2c1d3-96fb-71aa-55cf-33c674680627", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "628d5b85-fb1d-3be2-1666-dd4ae4465c58", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "631019a5-52aa-5f92-b516-9f02ab27fd0e", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "63c687a3-67c0-9d3e-4bda-fc7d26ed4e96", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "63d0e165-8c30-09b2-576d-a0517c4317d8", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "64232e02-58b1-49f9-ed14-4ed2bc2cca29", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "6430ecc4-8bfd-8a62-c7ff-1a819c81ab12", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "64ae45c7-d78f-ee6d-73c9-f4f9332e8811", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "657a5804-95d2-bbc9-e3a8-cb27991a4ff7", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "67ace8f4-0f30-1cd2-b6ca-071e23ec2cba", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "68043ff2-95b0-99fe-0120-ed51205672e6", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "698fabe1-43b4-9c65-86f3-65500666149f", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "6a312723-378f-452f-ccee-cc8c2ce7a27a", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "6a3a2ef3-ae9a-b881-f025-d9d175543545", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "6c176ab9-ca29-361a-d27f-4b7f010acd63", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "6d35848e-614b-c210-ba42-5c08c34d2f65", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "6d8a71bd-3b1b-2819-0f1c-7c6f1615f245", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "6db8b590-545c-5247-9e1a-c51a90a3b619", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "6e9db836-8335-157d-2b66-184effda711e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "6f1680fa-747d-53dc-d2ab-105243a1b1cb", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "70ee2824-090e-3fe4-2794-10f0c7f3f893", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "70fb017b-27b3-32f4-e15b-031807d3041f", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "71f57d4d-faa9-0cc6-82c1-fd3dd9f6c1c7", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "72a781ee-c6f9-c7a3-a6bb-dd39961e522e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "733a7970-863f-19e0-960b-550ffd7ebfb6", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "73532c4d-af3e-83d4-8425-4cc26ab37aba", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "73aa21b6-6e89-d724-606a-ff4a561441d6", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "73b44f51-5601-290c-5594-135cc98de227", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "73c7563d-39e9-4606-310e-2e3e31c378c6", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "73ef9028-ebb9-10e0-b568-0ab21799c6da", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "749b811e-fb13-4288-9280-1a0ac6ae1357", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "75a4e70d-830c-2c84-3356-f012e00406b8", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "764f2bb3-6cc5-14e4-6520-336d80427992", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "765a6d8c-c0fe-7187-2aa2-2346375627a4", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "77d7f16d-5ae4-b603-5a85-8890f1777158", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "77d8f4d1-c71b-c484-866c-ad2bbcee8d58", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "77f874fa-2a1f-f514-bfce-3249bea7bc6d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "7872c32e-8849-26d9-8279-dae0014cea81", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "789d8ffd-898f-2aaf-f340-7783135e9a27", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "78aaeff9-5997-2b9e-dfff-14892277163a", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "78ecaeff-34c8-c97c-b69b-0c6690b4a848", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "790b2537-789c-2d30-aa17-fddb3dcc7e87", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "79a2515b-c784-5fe3-20cb-1548b67dc9d2", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "79c2c8a5-b015-8ddf-6df6-251e26904dd1", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "7a234537-baf1-3524-b7d5-0e086755bc47", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "7a29af3a-374b-0d68-6adc-9c128bf68f2c", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "7b8b3263-39e1-5145-8a7c-922bed22cd08", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "7d9ad1c8-2f22-2da1-d373-f6781481e17c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "7ed7d5ba-b85a-94dc-e41a-951452adfd76", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "7ee8ecf2-a327-72a4-39a3-f550b848e994", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "7ff81ee8-300d-ddc6-319d-7dfa7218fd58", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "81a26782-c24b-32fc-fb34-09efe90725d6", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "8364106c-5f3a-598b-2ac0-3ed214205fef", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "8390a9f6-0a93-19fe-59e1-f9f55f5ddd6c", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "844e7674-593d-adb3-1440-7f2a1fab57a4", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "849b1616-601b-3dd9-557b-16d80403b1dc", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "856171a7-b9ac-4830-b2d8-9cee3fdcade6", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "87e48982-f0da-a5f3-0b94-9ea581b65f84", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "882e9f04-341b-9074-4919-525657521655", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "895409e2-f453-7a65-bb3d-25c0b35987f2", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "8976f83c-4baf-c2f0-376f-a1e360cd7ef0", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "8a6cc122-2f10-d00a-54f5-d2ac0bc48657", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "8aa6d384-bddc-d1af-b54c-f4cbd87e1b21", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "8bd34289-d07c-921a-c6cd-bb4b146fdcc3", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "8c6aca27-a8a8-0c0f-1002-e52f6eb2561b", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "8cc8c34e-a72a-148b-03b0-f8ee5fd74ca2", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "8d189383-f0b2-811e-27a7-413d45d77bc7", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "8d236de0-d974-e10a-d60c-6eb6d6ee45ba", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "8d39f934-18e4-6144-1d94-ded1104d046b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "8da9b865-ec75-e977-9c4c-609e2b0b4bbd", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "8e09b870-6631-2b58-4357-c8e2715354f3", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "8e209ba0-d4c5-1bc4-1217-b046044b7cbd", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "8e7a8865-e1aa-c65a-3f83-fb8382e84b73", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "8ff68495-91b6-7636-684d-e74d8db1cef3", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "8ff891c5-6be8-cf4d-c081-c3c877e21d1b", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "8ffc693b-16b1-8101-db46-047a98051af7", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "90ef151a-2989-8953-bd19-90dd0821143c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "91e6ee14-7d3d-ee2a-2bde-63a3eb189429", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "91fc97eb-284d-bef1-4eaf-5747976f12d9", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "935c4906-2965-0faa-073b-4831ee9f3c48", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "9419d91c-fb6e-946f-bacf-338bbfb69b57", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "945a3a2c-b742-5cf0-08ae-46eb85a20a36", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "9499db5d-73f2-29e0-6699-6fee9b30efcc", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "9651c893-06d6-049d-48ea-4068fa9fe013", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "96b1462d-19ec-a38c-05a7-8c261b7ce639", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "96b814eb-178a-5fe2-b4a6-eb71b6006fa1", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "978d0096-a189-7be1-55f4-a61ca61d2828", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "985812bb-b587-86fc-300c-964d20bb99fe", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "98a8f4b6-5e8d-2f6c-8758-6666656e481a", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "98f3fdc5-c2cd-f68b-96bd-732dd43c8529", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "9971fa58-a988-4a0b-0bde-87bf140e6b77", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "9a87aa15-1dd8-4cbb-afbc-52337f77c2ff", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "9ad1b67e-6011-dbfc-53db-ddffab249a2d", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "9af6f1ff-5c76-981f-16b1-cff0e00e7faa", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "9b05b001-4131-ed42-634c-10196745c2d2", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "9b3bd5a9-f7ad-eece-81d5-eb1e34b3e9cc", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "9c811b0b-75ce-1d6f-75bc-1c02b0f27f3c", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "9c845855-86f5-5a7c-6a9a-ab196a2fc168", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "9d09c449-338c-e3e8-fc9f-e17d64f8f16e", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "9d1207eb-453a-4a13-6571-c8cfdaa7475e", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "9d2229a0-0c0a-04e6-50eb-b3326b957e75", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "9d3d2f6d-074a-0e8a-04a1-d64fad0a7ca5", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "9dcbb2e1-1288-8061-7552-95fc4a54127f", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "9dd52fbd-e3a2-3778-9def-1607fcba8a14", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "9e3a1c36-c83f-de64-7a15-a427c2d53ea7", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "9e55967e-b361-b475-1d74-2da173a313ab", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "9eceb91a-7f9b-fbe9-d071-540a01948571", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "9fb457e2-45bd-9c59-9632-dd2b36d435f2", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "a0670202-2854-2e50-8de5-c40c09ce45d4", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "a0923ee7-dc84-4fb7-e960-64ba86e14501", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "a0f2d093-4ef8-8c6e-433d-875f5fae4ae6", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "a1f1d7a7-bddb-23c9-a786-8be00afca275", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "a1f48c0f-fc61-d167-ac87-a547004aa023", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "a228ae2d-6872-3077-746d-e7caa9826050", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "a2dc9424-44ed-80c3-e2bf-2fc537ce7c31", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "a2e87a66-9129-c8b4-8f19-1a7b0003f9b4", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "a2ebb53b-d53f-3243-6067-58d54306b7f3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "a37ff634-cd9b-ef97-1174-7895dac5142a", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "a39e1659-d76f-b466-dcb4-6e403c08235e", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "a41f5899-263a-2ba5-d89f-83fcb8615004", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "a59870d1-3aa1-1ffd-b0b0-5f0eef5f14e4", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "a5ad0348-d074-cc01-5380-d87b5fe5dc57", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "a6df2aeb-dc33-065d-ecc9-bf2472024f34", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "a6e15963-ccee-056e-b08a-7b411a5faed5", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "a7e8a312-e5ac-380e-64c0-58e134a0eb3a", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "a82312a1-29aa-9773-85f5-3a79b946447e", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "a88474d9-7b40-75c4-103c-4756fefc5223", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "a987acc4-6719-b547-a33c-941a36a8ac2d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "a9c039df-e5b6-5874-9c20-40b1c8c81a18", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "aa1b61b5-90b5-7fd4-8e47-7cc758c171b3", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "aa4fa9c2-81bc-294d-cb27-c2b5b55fab2b", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "aa5e6d3e-6879-9a9d-240a-c4b8d59d977d", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "ab988871-3db3-91fd-fdc6-c24dc63b2ff3", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "abc1a019-0ef7-cbc6-fcf3-2c8326df2fe4", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "abc6b243-5588-2a14-659b-cd1c72698bf6", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "abf10a27-3ac6-2e58-96f8-def34af99ffe", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "abfa578c-1059-0e95-41fc-6b4a6cc5bd35", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "ac61a898-07d6-ed31-0122-23756b48dd8b", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "ad086427-ad88-1b14-74dc-3c734d9f8fb0", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "ad3ad1fb-e09d-f4dc-0ea3-acb109796d53", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "af3d7485-acdb-8cea-67a2-6784f57fb5af", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "b138dcf7-c96a-95da-7950-ca0ebeca603b", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "b1a95a03-38ca-ee92-017c-5209fe2a86e6", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "b1c46032-68bc-da8b-5947-ff34f797a32a", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "b20737f2-721e-1d65-17b2-417ab128a58f", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "b383ee88-a3d4-9a92-14b8-4ad063d05858", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "b3a131b9-2c77-3894-f208-cb79d39faca2", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "b3a8c3e6-2323-b55f-9c32-0b87693deb72", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "b4d3824a-cc8b-bf10-4c1a-b8023aea893f", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "b5308f06-151e-ee1d-d1d9-567a5c3df214", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "b585a522-6b7d-2bde-80fe-59857d64cf59", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "b5e54f3a-245f-7903-3b7d-8ef6772d70e7", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "b646c1a0-6866-82ac-52d3-c26c028a197a", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "b648d7d6-c04b-1683-2bcc-c8232f2c923a", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "b738fca4-5187-2cb8-fe64-bf110f27dc19", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "b73fb90a-f41a-0c50-2dd7-6d2cda329ea9", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "b79bbe9d-8926-288f-0bdc-9007eb0b656c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "b7ae36e0-29fa-4028-0fd4-b1091ee273e1", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "b9740ffe-3edf-4783-e5ad-69012f24a391", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "ba235bd2-9ad8-ed2e-d547-fbd573117230", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "bb2fb4ac-48e3-3274-181a-669eb9886be5", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "bd079d7b-b8ac-b648-0a0f-fa0d75c647d2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "bd194d03-59f8-3e62-32e6-fe4f7a3b879b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "bd2342ba-3dc5-ee86-3dfd-38ca414e3fca", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "bd26c6ec-d165-4279-e832-a0635cb9a1e5", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "bd3a37e9-fe59-1c15-b82a-aecb60558898", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "bd5c5e1b-5be8-03c6-a5e2-39063b12d65e", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "bdd09408-1595-3d9e-9ba2-750a734e3f90", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "be8499f8-c80d-6ecf-0314-d9a438061154", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "bed3ffa9-e96c-f7e5-eb1b-e22f1ec71421", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "bf02e8ed-6ab9-9191-d50a-9c05cf34fcef", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "bf542d10-d3a3-6bc7-9bfc-b0462086ba9b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "c0028500-4cdc-8005-bb90-ed6399529b3f", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "c025d9b6-56e5-4289-89de-69f2f2d1d013", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "c054a00b-472b-2614-aac5-8337913cbe70", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "c0c452c8-6e09-202a-74cc-724212b93b85", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "c105f40c-b412-3a64-e00a-cb1f14df7cd8", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "c10a0baa-1e4b-54ba-5d59-5c584d8ae3ec", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "c3f29e56-c774-c1c8-366d-35e9ddfc64be", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "c437ad27-25ad-790e-ec14-e4cbb2c7d54f", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "c470d37a-a616-4624-0e1b-a3d600ba3c08", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "c49feb4a-a697-d42a-ade9-8a8f6028bbfc", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "c4b97e73-7182-c9d9-9bf7-916db4bdf6b3", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "c5a0b44d-30ce-829b-93a7-716afe1e5163", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "c65167ab-7aa0-3908-3e63-2698d06fa1b4", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "c757b477-07a8-d325-d4cf-a0a78e352f66", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "c7a68e32-cda7-b864-e7f1-ba2ae5fab309", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "c7e266d7-3097-a994-1174-d3cf1608c41e", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "c8006108-d31d-3fc3-8118-4a00aa1228c8", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "c83566fe-4da0-b680-43f1-aaa1880db549", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "c888fa0e-3ba4-8446-ca99-35f2dd69819a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "c8e06257-6008-61b4-4b53-278d79854078", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "c93aedf9-5f94-9dc3-c599-63c7235e54e4", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "c9db2283-f63a-871f-3474-0b3644830bf8", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "ca31003d-2c4d-41c8-9b9b-4c61347b3f44", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "cbff8567-0725-b204-ba70-6b3ea17679a2", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "cc89b80d-6432-18eb-4c1f-89d48642289d", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "cce2ada9-2f2d-ce10-1509-2e3988f0040e", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "cd47af08-b065-d7f9-957b-4331cf499a84", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "cd4a2b32-4de8-cae4-d813-3a9c528bce84", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "cfb44862-44a4-9cc9-5636-6fc938d47be3", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "d0425968-0a5c-0a9f-3897-b55f4e22a274", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "d051e973-698c-58dd-bda6-63d696077ad3", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "d07bb88c-bdf7-0c6b-a371-44ce794f7d3e", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "d2e5a5cc-7ca8-1bdd-b989-bd9c35ca0e88", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "d39c0714-beb7-9fc0-1fba-437d66426189", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "d4f123f5-ec66-2062-e7da-d35c3ee57eee", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "d6004a9b-1c74-80de-a857-6060eaf7261d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "d6592817-12c5-1929-7656-0bc610ac5bb8", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "d7752dd6-7176-d04e-be06-8422283faab2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "d7fdd83a-70db-66ab-6375-91cd319db355", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "d810fb97-00e7-f2a0-0985-acffaf11b187", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "d83d4cf6-076e-8942-5a26-f3fb3c195bbf", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "d887248e-7c1b-b541-76ce-6a1429625aa7", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "d9396d48-fd20-a52d-70b5-3f2085f7cfec", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "da917375-989e-aa66-3705-7fb13adc13b7", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "db8cd639-647a-8b58-26e1-09ded6668cba", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "ddc05051-6ba0-9876-0a13-ebc3052d2b4e", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "de4618b3-b26c-8e28-0a99-ae5525670cd5", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "df6e2e51-1635-c552-c2e4-47c20b623af6", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "df7466ab-6cd7-323b-3000-734d0a87e629", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "dfa77c24-d946-d3aa-8143-2d2980309d6b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "e02b7f77-b4c9-bc10-276e-685319e06cae", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "e0423095-2fec-629c-28ab-8d15fc453cf0", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "e04a9235-6450-7289-01d9-1e0c6d60181e", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "e0a5ac38-0109-c23b-cdf9-bfcc771a6956", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "e1cc35de-1693-fdc6-8795-0119f8f61623", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "e291f668-1c34-8928-0af9-193ae7989012", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "e29f5f7f-1c7a-cc69-3cb1-b84d99512a10", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "e3444b28-a5e6-7291-e9e2-d64fc228bdec", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "e44ff3f4-6ff9-8af0-f12a-63b3268c710c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "e4b69797-276b-44dc-f691-2839ccadbc59", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "e549f908-0b9f-bc96-93e7-a3debcc701cd", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "e5534c19-113d-4705-a9f8-5a5534f534bf", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "e792e81e-cd41-7b11-d310-735b5b93ea00", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "e7ac8242-2bdf-3ea8-34ed-376cd6d4cc6d", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "e8e08ba6-7aaa-47b0-1ba8-5672399ddd9c", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "e91072de-8876-66b5-cceb-4cfa6eb00b82", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "e915fc4f-2425-c1b9-7448-6f93374f4d93", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "e992a0f0-7cfc-f1ea-667c-c308c7560737", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "e9db33d6-c21d-844e-fbab-1988c3f1c501", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "ea01f8ea-b73e-be93-9a72-7db9fa21dd8c", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "eb190148-b365-1499-4bcf-34a8307d3ae5", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "ec46c0fe-0b44-80a4-27fb-211fc8190195", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "ec4fae02-dbe6-d8aa-4d3d-da1c38fb7f7c", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "ec725cd5-16d9-76f8-27ad-d5aa62b86c1b", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "eccdc834-73c7-adb9-9ff5-6255b7257146", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "ed3daf70-fcb0-7b32-f292-becdb3eb3eb3", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "ed67f473-5441-c705-b174-e26119a10316", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "edfda5e7-5084-880a-022d-29069aa5cbfa", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "eef85155-102e-817b-0de0-1e2e035404d7", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "efa6a2ea-b018-6b26-35e2-0f08ee59c252", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "f129bad2-788c-bc9e-89cf-60039b8e604a", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "f14fc5c6-c061-1111-1e79-f268130aaa74", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "f16f91c3-4de3-d09f-4071-921f313f15a8", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "f1707df7-3aa5-d08c-ea15-5bd6269c6cd3", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "f24c8abc-3f83-5162-2e6c-56859c5c056b", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "f2ffd04c-6cf2-db85-a42a-bdb85851cef7", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "f3b1abe6-fc82-148f-0715-4d25554e7fa3", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "f3b3e51e-629c-d167-01db-a6540d350738", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "f59455ff-4ce7-d960-dc83-0e9693fa47a6", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "f602e4c9-bc99-4d36-b8af-7f9dcb88d01c", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "f7033651-e69a-4324-fbe2-d0182b44a808", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "f74652db-dc7b-535b-b335-595d87ad4277", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "f7502be8-0a9a-4d63-69fe-fba66d3fc191", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "f7875753-a25c-5e48-6009-e5dbdd89d86e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "f81f9d3a-35d8-f873-8f95-45726a1387a3", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "f8eda48e-36b2-3c80-2a8d-45ed824d3d02", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "f95addc7-9b43-8f11-22be-04c9b277bbbe", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "f9f1b201-c78a-46fd-3f7d-701f0cb9d80b", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "fa8863c0-67b0-85c7-5ff5-bf270e35170e", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "fa95ca2d-6015-d738-9bbe-e8cba5195c60", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "faa58a8c-d950-2e5f-5a1e-2fb3331958ca", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "fb2537bc-4439-2071-55a0-b6407e36e5e0", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "fc38688b-a5a5-0a3e-f73f-a130d3c1ade0", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "fcbbff35-ac21-d887-426b-fc0c5af9fa0d", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "fcbeb7c4-fd9c-40cc-b15e-4ddf4d47233b", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "fd1bee15-e7b2-9c75-8f36-bf9c4510c9c5", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "fea0de9b-2eaa-f28c-2118-dc74ea12b4b5", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" }
                });
            }

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 33, 656, DateTimeKind.Utc).AddTicks(8649), "$2b$12$eA6MmIa4ff3XEPO9dLIcf.buOsbfM/10NCGoVRSbSHlK9vTQHER6O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 16, 2, DateTimeKind.Utc).AddTicks(5889), "$2b$12$AkXDLEdlmLAyGMb2ROowJ.S3yG41mnoXa6LrEaZ9I5EyAnxYRWvMO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 20, 381, DateTimeKind.Utc).AddTicks(2088), "$2b$12$uq1N7.2Lgx/9fXCqxBeo6.XP6ow2GgARG.chahegYpp5Z1xUKuSCC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 11, 552, DateTimeKind.Utc).AddTicks(6152), "$2b$12$1WEQBTNbNLFDpgMCZL0r1uirAFI6B0djHSbuePyS1tshHe5pZMo6O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 23, 474, DateTimeKind.Utc).AddTicks(7978), "$2b$12$DH/5WOultgP8joxyDDw.VO5uPzYkqhY2AbPG24AGYieGrmMtfmYhm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 27, 93, DateTimeKind.Utc).AddTicks(165), "$2b$12$WGGcv3b8Q4LE3X2R1NCQoe/94OJEZNv.UrNwssJmGiMrV6Q9AuW32" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 13, 206, DateTimeKind.Utc).AddTicks(3458), "$2b$12$wEKQJDVi9/NZv11KI4AzieQmJtAkxTROmMWYIFwqJp75y3A1BAoZq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 31, 457, DateTimeKind.Utc).AddTicks(7531), "$2b$12$55hAm7nh9LBEqx.ojMU9K.fWvCJMmd8awGh3kCL6ZmL2qKi86e/NK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 19, 148, DateTimeKind.Utc).AddTicks(8609), "$2b$12$3Tjc9R7KYDd9T7P1zfop.uZYdkUPHOpTkJUVlCrCNLP09e5g2y1p." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 35, 799, DateTimeKind.Utc).AddTicks(6040), "$2b$12$ahyA9.NYyIilrEyZ6j9qs.NdxrvQ1CliVbVgOrUuTcp0BCcLqvY9i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 14, 122, DateTimeKind.Utc).AddTicks(632), "$2b$12$GYuNq2IaFkSIHVlJTItND.nAkvgU083vyeL5X3zRsFBHOyGIzd.ui" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 14, 769, DateTimeKind.Utc).AddTicks(3114), "$2b$12$w52aJJ3.HV1QyWi7.T/37.DM20.t7CmPr5P3kaF7bpxQUo1YIKbze" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 26, 48, DateTimeKind.Utc).AddTicks(1905), "$2b$12$yzAWvlqYbWaB46yJQj2GoOlq9n7ha.CKV.G97NjJ8OBxsHQ2mOY62" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 36, 408, DateTimeKind.Utc).AddTicks(2230), "$2b$12$TLhIc5Lcv7QveYWE/Ekz1exlthrHFjNyWlAjF0COEt19fG0pmpLNK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 10, 584, DateTimeKind.Utc).AddTicks(6976), "$2b$12$bUCBmCBsLQawv7fcyigTw.BOA4ChTj61YILafxAkIqHDHwni2uBbC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 18, 804, DateTimeKind.Utc).AddTicks(4685), "$2b$12$IwSehoTQ7oKCHJIy9ACy3.hCtrR9aW0bQdmbkLBU0Cu4tuFQ1O7c6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 12, 273, DateTimeKind.Utc).AddTicks(5938), "$2b$12$tRs2IFENYOAlfI8QS0NS4OTD7x9mJQ5MKQQtoBr1mzng3T4GlAwQa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 11, 906, DateTimeKind.Utc).AddTicks(902), "$2b$12$qxrnbkp7JMWDI7GQV0AU/eVG1wIpNo4zSipYv7yLw7ovsZ2oDPKlK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 30, 544, DateTimeKind.Utc).AddTicks(4161), "$2b$12$uVNIqDnkhcflDzVUVubnYepBEa9NNXwbCEp6uBXaVk1ARXPiqyB5C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 31, 783, DateTimeKind.Utc).AddTicks(1535), "$2b$12$4D2BoK6htEib9yKON..7TOc49t.W9GU2SuTCdceUxV7S6X.yBkV3u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 29, 619, DateTimeKind.Utc).AddTicks(6093), "$2b$12$MXeBLS5jxZxuZMk/.soov.5jRJVq/G1988Ut.akMgb8IduJP9Xnxm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 28, 332, DateTimeKind.Utc).AddTicks(7672), "$2b$12$9Iwpw9XPw8E.omF1ABQoR.2H3xrVMQo4cXDc9vB0FY38/lvykmtt2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 27, 402, DateTimeKind.Utc).AddTicks(7835), "$2b$12$p4sM.1z3YI3hV3URHM88aOKky0gZSpvqKOnJXIgeK8lh4Uk9aTT5q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 15, 384, DateTimeKind.Utc).AddTicks(8004), "$2b$12$fA5bQjZHI8Pgo2srBrMh1u.BoOHmA8cgRXhBx6pVgXyTJPqcyrWuS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 12, 584, DateTimeKind.Utc).AddTicks(3207), "$2b$12$zNttUXdDeTjLpdgKYHNoJuuMHw9uwgBJmelLHuBz9xNBZijI37f5i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 16, 960, DateTimeKind.Utc).AddTicks(7882), "$2b$12$0CDCQ7CzSL28DiacJqFfH.SwDc.E2J0pC8bJ/KrqBY2k5/.mttcPC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 31, 154, DateTimeKind.Utc).AddTicks(2905), "$2b$12$8amiJ6jKX1uIlwbGWpunK.IZJRHuoy7qbe0nRPkSgXp2f1n5yp1fi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 13, 817, DateTimeKind.Utc).AddTicks(9959), "$2b$12$DP7lp2MRlZdQ6WaYXL7fHuz65pjeG.LhYF4TJsPKJXvrZZcHh4vlW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 33, 963, DateTimeKind.Utc).AddTicks(2091), "$2b$12$MPaRXHGV42AV2c5aVHKfDOHz.yb0M2rtYfW2REAfNpMwIhmVjCmgC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 20, 74, DateTimeKind.Utc).AddTicks(237), "$2b$12$j/4Ewe0guZKiOXpMM4.i2uoCAge7jQLklnIA2OZbowxk7XLR.NvtG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 24, 747, DateTimeKind.Utc).AddTicks(2211), "$2b$12$rSeF6hWyM0a1bw2qrfKuxOKVfKkY03K.GiqNTJs435GeoROg6v6EO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 28, 951, DateTimeKind.Utc).AddTicks(8654), "$2b$12$/uNsPPjnMB9Hgh62BKpXFOkWc71ouao/aS08Ovm/xUmuALCP3YVVS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 26, 786, DateTimeKind.Utc).AddTicks(4541), "$2b$12$2DHWSzgQNaxughclh2I2J.5Qhp2HjQ1hZBJI2mwnzTRvwnFJvjMjO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 17, 264, DateTimeKind.Utc).AddTicks(2966), "$2b$12$tXgL5jtcbJgCG/rZFxy5NewtLbJHv27QxfbbiXMKtW4iae.uJeVKC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 34, 885, DateTimeKind.Utc).AddTicks(902), "$2b$12$R0GkpgOVv6EOnRrxamcA2Oc2naMzFE9zyUEQmKYPF7d5jHd2ctRCi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 33, 350, DateTimeKind.Utc).AddTicks(3521), "$2b$12$5M9ht/Foda3iiH9/nLN8EOkPkxvxcpSv3KSCxlDcLirNvwNGj9tdK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 25, 684, DateTimeKind.Utc).AddTicks(7425), "$2b$12$I3gTdG/OeZk1zPJfjqzikeBfICW.7yRt/YSxS2sAGkHgGxOET.5Ma" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 22, 241, DateTimeKind.Utc).AddTicks(4557), "$2b$12$LLVv48iDwGCGm..omH0FmeaHtbu3.ljON3K9CGRJYol/WJJBCQrmS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 29, 927, DateTimeKind.Utc).AddTicks(1437), "$2b$12$9UOQPFROhxCiyj81s1Lj4.V4arQ824hV5/QFaVkw3/x9S5hiri24W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 28, 638, DateTimeKind.Utc).AddTicks(6761), "$2b$12$zqUzs.P.NjzkAVkVpb6n3uF.Wqxh3n8r3i0z1FOdVCJimorQqWjOW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 30, 235, DateTimeKind.Utc).AddTicks(6219), "$2b$12$UG0rrekuE3zWfk9B/RIQqeJ6lWN3w6zelhNqu51xPDWn.9VqjPUA6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 36, 102, DateTimeKind.Utc).AddTicks(8616), "$2b$12$ny78aN8qQMfBHlx4u7NAV.NL4mMZQogHqUFYM2ql0G29kjiJITWES" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 32, 434, DateTimeKind.Utc).AddTicks(5864), "$2b$12$datZPoFZN3y7jQTLavJ7PeimIJXXDof/7/dbW9cHy/Es559IbQqaG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 35, 189, DateTimeKind.Utc).AddTicks(8327), "$2b$12$1qaflst.afGhgTwLWtTnc.pS4FDhf2RNuA.0xh5sRBDl.etZi4aRu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 22, 856, DateTimeKind.Utc).AddTicks(2007), "$2b$12$ROuTVnmOHbyPSsNsFiqd5ege6dUfeZYol104MAJkqmSjOHWemUnoS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 22, 545, DateTimeKind.Utc).AddTicks(1432), "$2b$12$wIxoH6hAyksJ0LUBUPA.iu0qHi2XCoIyaOF6o1uXz5m4Jpc0G7axG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 21, 296, DateTimeKind.Utc).AddTicks(9819), "$2b$12$1mIZT8m8QjhBn/UmGzr4GeVj/TdYo8X.8i0672IwNq/N5l5h5X4ry" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 25, 60, DateTimeKind.Utc).AddTicks(3686), "$2b$12$4sP2pZZJwmT4Oeex1JmSxOXn2.9XtxTANNq2aG5OKxrIxxwn65sAq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 32, 740, DateTimeKind.Utc).AddTicks(1506), "$2b$12$9Zg03xpVHazlnaQQ/jv7XeSoQVO151Qz9k8aLzwDK32.hjm6Q.NxS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 21, 599, DateTimeKind.Utc).AddTicks(8927), "$2b$12$2XnngQ6NFKVbjS9iWGL3/u0WUFCR/AiJgrpd4rhawS/yp0.mFLEEu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 23, 781, DateTimeKind.Utc).AddTicks(8687), "$2b$12$Uk6AdIrFZIsxvXZUVo6f8ektWQFMFPDAA6USzOjaAwbfbpfJ9Fw6C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 33, 46, DateTimeKind.Utc).AddTicks(4847), "$2b$12$eQbEDzh7kB5.bmN5dZdCn.JkN6s0JvE3ZuA3EPhhiZWPwDanofwXu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 27, 716, DateTimeKind.Utc).AddTicks(3182), "$2b$12$DK4gqyHJ.TGZ81Tlma15S.wMV6VLZOKq1BeKjbMcn7oAxJ1/HkUQO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 25, 371, DateTimeKind.Utc).AddTicks(1239), "$2b$12$lhXRngynOmvJId.2r3ki4u9ngFIsapfMzjHOpp/bJzVMdDg3L2jBu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 19, 766, DateTimeKind.Utc).AddTicks(2385), "$2b$12$PpKE4Mr1pGeWXwyFoNC4Qu.XwTk.7SC.mPJB8hRG4RWIpDb8hI8re" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 10, 917, DateTimeKind.Utc).AddTicks(3316), "$2b$12$QKYH2T96URUXChEzJyVlQu.YzwSL5p1rneD.iBaPH4vywPNVPOHw." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 17, 574, DateTimeKind.Utc).AddTicks(93), "$2b$12$LidGby.Q/b4RG2V86Xi.gepndBrSDWetTZ.PcGrYl4V21tbdHtm4e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 34, 580, DateTimeKind.Utc).AddTicks(1040), "$2b$12$u4ty04tHRtgmDWF2YTe.RePny4F33nsIC7yM66mSxK.K6uD13Mebq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 14, 427, DateTimeKind.Utc).AddTicks(9084), "$2b$12$.j3ekM0u3hh62qGtSaHUKuuMgf9kvlA9L8EJUnc4zQlBH9ySzeV/G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 19, 457, DateTimeKind.Utc).AddTicks(7695), "$2b$12$77bMGUcG/ajF3LZ1X6nWDOIgpIBY8AnJR7ZvwH.Fns/Wt45y20qha" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 30, 847, DateTimeKind.Utc).AddTicks(9321), "$2b$12$Qmiv2zJGaqRDMZoNgBEhhOqgQ9zx42sK7kWAwsqQbxOMsRmEK9V5S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 35, 494, DateTimeKind.Utc).AddTicks(5938), "$2b$12$a9z868butV8BAkAfGfvZHOnrcmPJUZVu/Nen0SIhOTx3DbFKj.K9O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 32, 88, DateTimeKind.Utc).AddTicks(8158), "$2b$12$Kw0uXmIGWWBSNDSVJUPFzuvuCCCnaQ1QFUDuaDz4pL02f5oxM6V4i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 18, 498, DateTimeKind.Utc).AddTicks(2368), "$2b$12$ARXtd8Ab7/Bgleub1YwZ5OaDOkYFgRfAxlXaIZLUIwacq4GAMwYMO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 34, 268, DateTimeKind.Utc).AddTicks(2519), "$2b$12$N0Z//KaKBpN1RFs4r31Ztu8G5o7zIiedBsFgRqS9oienwjhMmVu0." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 26, 428, DateTimeKind.Utc).AddTicks(8131), "$2b$12$9Vwv9IlVfPE4w5hgp75AGeWW.7leW6GOswaVLjainwa.gtk1R6dYS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 29, 299, DateTimeKind.Utc).AddTicks(8037), "$2b$12$CKrJamyg.pEJBswtsE/K6eEJdI2mi6TExI7yzittG7rRrMLN5rHa2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 15, 79, DateTimeKind.Utc).AddTicks(6087), "$2b$12$DPApV36ZNJRPr/yYaLCqjuPxuWGG3n1iJauFMdrIme2RIUmIiFJ2y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 13, 511, DateTimeKind.Utc).AddTicks(7885), "$2b$12$zD77PJlsoKscKZNtcvBFyuWXCiF64PHq.SuhUOmuTvejTJ67o8ahu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 28, 24, DateTimeKind.Utc).AddTicks(3391), "$2b$12$GeXkLP2qL01FGMmSpAcJnuajstmDFUbWXqf99wQLMSR2ylbSrNEs." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 20, 685, DateTimeKind.Utc).AddTicks(5082), "$2b$12$L6cxEgQhfesL.UwhGoaY9Oa1XZoCqNm6AqFsjYpdvYMbozzWnAem2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 11, 242, DateTimeKind.Utc).AddTicks(1075), "$2b$12$SgnUMuGfzwRKdK/clte3XufubAwz16Ch/7BkZfwWXliZ5wipGQEK2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 21, 934, DateTimeKind.Utc).AddTicks(8447), "$2b$12$5e3ju/K3QtVIMqLWSFKNOeRjlCKEIqx3AbSnUFe1YF4u6IZEzVe9e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 15, 696, DateTimeKind.Utc).AddTicks(9662), "$2b$12$klMG1.VNSDkEeWRjs9b/t.Higph3XWN2Z5obcA.jxK2uz1Vu0099i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 24, 115, DateTimeKind.Utc).AddTicks(5339), "$2b$12$xMYfuKlVDSqL2hG7T3VBnelZ4jEZ.0obbsEfH2tu2UcZLDipLIdPK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 24, 440, DateTimeKind.Utc).AddTicks(3272), "$2b$12$1EYHgINqd1RiUEcJ1vk2VORvmQWJKJY8upRgsF8/o94p/Uod8fw5m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 23, 164, DateTimeKind.Utc).AddTicks(2917), "$2b$12$7K92YjEzDnUsHJA591hmyuUADdsiwOwJIEfEw86IOGk.YmYXVbQ7K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 20, 988, DateTimeKind.Utc).AddTicks(2633), "$2b$12$lsBVLcASaKDhsR/jnupRCeRaKcE0pHDqxjnEe8r86vYCtslx52o4G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 18, 189, DateTimeKind.Utc).AddTicks(2199), "$2b$12$ThZoOglzqBNKdmTmCQArnODLFALZ4hLAau47GRRWwwcL0HIJTkGje" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 16, 617, DateTimeKind.Utc).AddTicks(365), "$2b$12$adQdWKuBhvavdYyk15.9Y.tEz808uMrOCdTmDOklStpn6vcO1YuXO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 16, 308, DateTimeKind.Utc).AddTicks(7457), "$2b$12$pmlij6xtLAvRd4lQzbSFE.zSZtHqAEnWyDpNL7uOCGnlByeHv7VX." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 17, 881, DateTimeKind.Utc).AddTicks(1486), "$2b$12$UI1kRuje/digLh78HIMNdeDQIKvE2EQvfDzEyoZ6UbIrwrwEOb2BG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 23, 12, 894, DateTimeKind.Utc).AddTicks(5239), "$2b$12$TtBoR105YKMVCJ3MTNgL9e5roDri1joDo6/hynJEJCt/Yblpib5sS" });

            migrationBuilder.InsertData(
                table: "Attend",
                columns: new[] { "group_id", "session_id" },
                values: new object[,]
                {
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "6eeab54d-48f6-9f68-1ca3-b7ed0c89b7cc" },
                    { "64b93cdc-56f3-906f-6e4c-2adfe2184501", "6eeab54d-48f6-9f68-1ca3-b7ed0c89b7cc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "57bf1149-8880-c27c-d603-3546214d03a8", "6eeab54d-48f6-9f68-1ca3-b7ed0c89b7cc" });

            migrationBuilder.DeleteData(
                table: "Attend",
                keyColumns: new[] { "group_id", "session_id" },
                keyValues: new object[] { "64b93cdc-56f3-906f-6e4c-2adfe2184501", "6eeab54d-48f6-9f68-1ca3-b7ed0c89b7cc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0048393d-d5a2-01af-d913-bc890fe8b2ae", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "00e55ffe-e77a-1041-83fe-f230819a98a6", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "013a00ac-ac8b-5c01-8a57-5e3a952f41c6", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "015728e2-d208-f4cc-9b3c-b972b482801b", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "02a2a3e4-b5c0-289c-5dfd-95324e623d49", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "02b8e933-beee-fd21-e81d-20c13cc2b9d9", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "035596ea-77a5-4678-2440-1215400176b5", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "03a99c53-fb54-e2d7-6a4a-3c27563d7b9c", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "042bb7cc-acb9-432e-6025-f01f85edc241", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "04ccea8a-4e53-42db-c31a-0e8f2c805783", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "053f68e1-2f0e-089c-76f7-de930e8668f9", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "05bd8efd-7965-885a-712a-23b65c741a8d", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "05c1638f-8bd7-6101-ecb2-b86c4e36c561", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0633fa76-26c4-bbb8-04b7-ac2dffc5035d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "06db607d-9866-9b91-3737-5d793f448048", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "078427d0-9b6a-f123-fccb-8e5843a2e640", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "07a3cd0f-fe14-505c-acdf-f777e37778f1", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "07f20e2d-9dba-3c0d-6168-ee83fdae9385", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "08859e7a-33b4-e98b-b9ef-f754da6f424b", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0993178d-8c63-8c40-84f9-5f0d8407806a", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0a613941-9193-abf4-25ce-a79ed34acf0f", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0ab1812f-650e-a53a-7a38-d1191221716b", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0abc4d04-e557-58b6-e4bc-7e52cfede4f0", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0b0eee80-ebc9-0e27-a0d3-4124d340c71d", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0b13de7b-3a06-5d38-eccf-e9bb8db4be94", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0bc8e3a7-1aed-9f32-20e8-ab95b541caba", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0be92ebb-39d3-323f-c309-af2cbab9b45d", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0c81ee88-383d-927c-6006-4e96a8d886ec", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0ca55a2b-4b81-c691-b83c-cb46471e0616", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0cd4c552-ef7a-3da8-74d3-a0393d836d30", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0cf2cc5d-7bc0-f1d6-49b8-99c8e5afc22b", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0d5335ac-dc82-6607-9000-ce5fb7df023d", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0e09a6c4-a5a1-ce41-7427-98ad5a20a6e6", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0f278cb7-49d5-fcc9-b743-6c6f611b8aac", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "0f702402-059d-f301-63c5-f10eae2added", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "10c6170d-a542-dc14-754f-794aa16ea0cf", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "11065baf-e680-3a0f-0ba7-1eca5f0d5203", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "11a47728-c8f9-ee9b-363a-3a89d6c24797", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "11ac6e88-a54d-0fb7-d0af-0368bd55f51f", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "13665640-d5be-7545-5e75-b567631717d7", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1452324b-c53c-15c4-079f-4a2000e03019", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1497fba7-91b9-0f9e-413b-a1a7a9487f45", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "165b9f17-2130-1b34-da4c-1235fc6ec986", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "165be93e-3f49-13b1-427e-af18f7d6db8f", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "176b9a55-95f2-70a6-0d8a-c46a6f228bea", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "17ab550a-68a1-728d-c3c0-64c7bc72f3fe", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1828a070-068b-a95d-05bd-97d1aa5306cf", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "18293f33-cf24-6dd0-fea8-750eb629c0de", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "19f2fad4-a69b-5816-5671-7dca8e1f05c3", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1aeee50c-ccc4-bda1-52a4-8d413ffe2055", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1b1697a9-3a2d-fc57-4a13-6eb57d67f819", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1b84325f-12c9-a783-29b9-032c0e6283aa", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1c4cacfb-dee9-07de-5cbc-d5ab91b33773", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1c9c63bf-825c-13f7-fa0e-9f0699f61ecb", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1cd5ed06-8055-c77f-14d6-607ba085772a", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1d041991-5f0e-c23a-8999-aa6d5e5cec41", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1e356af5-9fbd-d306-bbc5-eea3d0b204ad", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1e5eea31-29c3-bc5d-2667-842eff3b544c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1e95312c-bb54-5051-1d8b-87fa3be05371", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1edd5504-cbdd-721e-c3f8-b14406688ec9", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1f060a0e-833b-9361-4a59-0ffc6ca53af2", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1f0d2ada-0af7-a1a9-d34f-e43e47f0979e", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1f87bcd1-4567-9f7a-a2c7-c8251419643f", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1fb7b886-b13d-200f-7df6-7ebda0de9ccc", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "1fef362a-d1da-0a5a-84f5-8ae89094daf4", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "20ce0656-3d5a-66ab-6bc6-0e90ad09655b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "21ba83f0-c8cf-756e-d382-667683820599", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "22c1caa2-aa3b-3e37-6efb-8fb7c07f54ca", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2310c342-bed5-4b9f-eba2-02e50ce02e57", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "235b3715-edf8-71b1-9850-c2f6c754d99d", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "248bcdbe-1d25-60a0-8656-ea43b2f22920", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2592466e-b4d4-4655-9eb3-6de7071ccf75", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2605d9e6-c136-20c8-1831-a1f1ffd05ec7", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "27157c99-c60c-e69d-0cf7-6d49797717a7", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "27347831-35fb-67fa-ab30-fe2735abbbd8", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "288acd27-59ec-b9f5-160f-bf6e569dbf73", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "28b5dbc2-f5fe-d1df-1276-f0264e5fc36d", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "28cc2966-659a-7c43-550d-d3e856e6eb75", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "29b71050-1d78-d4d7-0445-b899e17f1db0", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2a81166d-6b54-e987-5809-652afadd1182", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2adde9fd-954c-932b-bf95-c574715ee59d", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2b072eec-8afc-2975-cf37-acd3112a3d9b", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2b1ce470-481f-5868-f4ac-26e876e4d79b", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2b9b9d22-41a9-95c7-6b24-f4c5298461af", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2bb47397-839a-9256-9cb2-7ca19bbe6f6d", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2c5e7c40-eda0-861b-ff60-079cbd28d62b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2ccff467-3ffe-b229-11db-213c0682008f", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2cdc1759-9120-bd86-70c9-29940340600c", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2d9a3c10-b1dd-f004-0f69-2e3a4bae5c5c", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2dd686c2-90fb-215c-484b-6abf33d7f0f2", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "2ef053bb-a426-74eb-6498-47e542671a5a", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3177b094-26b1-b068-a92e-12b1ea020c51", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3188ef65-4dde-15ad-a99a-83fd6b6c05a2", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3211d60a-a2cc-4aae-e597-0618dc72fd91", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "32b099e1-a3d1-4e0f-9e32-56ec913b08fa", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "333a9e97-7b22-78cf-a2aa-054acbed29d6", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "33629096-47e0-4ae4-df4f-b9b15bb01a06", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "33efd6cb-b6fa-3383-51f3-b5ce1564e043", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3467ad0e-4caa-a9d4-ebe6-b07c78d758be", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "34dcfbf0-bd44-0123-ea20-2bd73d504f1a", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "35adacf1-d9c3-d92e-2f59-fd496b6a14db", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3617723f-5fa3-13c5-747b-af12024e1739", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "36d84ce4-f349-afc4-6458-0cf8242cb742", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "36e83abd-b95b-2bff-8076-d432a0d126c1", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "376435b2-4f87-d45c-9d3b-0f1a7fe26993", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "37b5538d-83d9-db1e-c957-873f1f52b8e1", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "384a335b-ead6-a595-1afa-792fa5f1d8fa", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "399b3fe0-a8db-f30b-561a-3eb2fa5d587a", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3a67330d-23e1-7ead-b469-1adf44300612", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3aa7cd04-b4c2-cc6f-b69c-a73c4dc31b69", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3ad232de-dead-1de3-4ef2-1a7a1bcae815", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3adb884d-00f4-7452-b153-172589985de0", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3b42cda1-04cd-5377-70ca-5f9c09522015", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3bd48e65-a546-53b8-11be-9168f9315439", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3c384aff-7c16-316e-ecdf-de092cb63839", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3c4db87f-2c67-8431-5028-cc295a2e3087", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3da16659-e34c-a32c-0e88-f464e813b606", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3eb63cdb-d52f-72b1-555a-1bc3287a6e99", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "3f839a52-c325-f2fb-b74a-c0f31808b557", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "40137d15-bd16-30bb-80eb-aaabd3357137", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "412ef48d-01be-55ef-5ebb-4a78431136ee", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "42046a6e-e4b1-6bd2-f0ac-7fab8592bd81", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "43370ead-9fca-c16d-cee6-46c82788d337", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "43dba54c-ac20-eaf1-aa78-e5651b270a61", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "44aaf7b1-791f-8f82-c0da-7ebb41fd7242", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4557c67c-df81-999d-af4c-0c484bf21983", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "45af8d84-cfe9-7ed6-18a6-0d89016bac6d", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "45ddd76f-2146-20dd-4044-b056b0e89930", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "45ef5fb7-f21c-293d-6e77-44f359cf722d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "45f1ab9e-4cf6-ec9c-2b17-9c7adc6a6cc6", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4655bd8a-abe0-ed09-0f95-f22d7f8c4bfb", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "489eb465-3148-2790-459d-d37743bc1fc9", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "48bf7f82-1ca6-e351-83a6-20588e74f9d9", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4903fa5b-de46-5fc6-a28e-0f0cd0ba7c7d", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "49cbfa48-c9a4-d8f0-1a8a-1191d3b61d23", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4a1350c1-b7cd-0abf-d114-716504b16a7c", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4a9e4b89-4361-e36c-5dbd-676385437cbf", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4acd9232-d4af-fc54-d001-272120ba0f3e", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4af77d70-a98f-9201-b485-970850a53a5c", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4b064eb6-10c3-39c3-883d-0424a8ea810b", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4b3fa2e9-13d6-815a-1991-3379fa24d213", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4c6b6e9f-a614-de54-097f-4c095f09b343", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4c74eddf-31df-3d9c-e01a-935aab29f802", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4caafe08-88b8-f527-d617-30c43c95947c", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4cd5f36a-93f7-1b54-cabe-8128f0dfd674", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4dd2b11e-e285-eba7-7e11-217a1f1a5016", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4dfa6633-4102-2dee-0768-2c3ef94f351a", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4e6ad58e-34f9-3aad-d394-6c22e98c28e6", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "4f96e085-90db-e38e-531a-45f6abfbd4b5", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "50278dc0-3ccf-66c5-6639-d8cf2c3a45c3", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5119b0f0-763d-45e9-dabe-2e015463004e", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "52337c23-7694-cbf4-76c9-3dd7f121c476", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "52659ecb-a874-76cd-e727-9e93c72dd9e6", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "528cf0ef-0ad8-1440-1a6a-d89ca66b78ef", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "532a40a7-77e5-d8ad-e9d1-5ac05b8f1fb5", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "55803d94-5a30-5537-708f-9a29af0bb608", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "564788db-7533-ad1d-c822-688c966ea182", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "573e2677-41f8-31b7-9951-eb1100b2132b", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "57ab359d-3846-c2bb-ed46-058d12813eb3", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "57be9b47-7cba-8ebb-640f-e274971152ab", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "58ee5b4f-5255-02ce-b2d5-07a5c8ca7673", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5928a75b-88dd-4a5d-ca54-6d5bfaeab6bc", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5949817d-4426-d92c-eda5-7bc93010d7e7", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "597d6d71-d02d-d972-6906-47dd94af9989", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5a62f7f4-969e-0b36-2084-91de9f91eb34", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5ae81cf8-1483-9145-cede-a1d072e27dfd", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5bd766de-0af8-d57c-839b-1f71e24d41df", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5c070507-4cfc-7437-9688-8a3fa0311229", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5c440b1b-c528-b1b7-ea36-c8c51c52f6a9", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5c67d3c5-f64b-9042-df1c-37f8122fe8e8", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5cb76838-2148-bb64-3c35-e732e56238c5", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5de5e483-bf65-3751-6439-ad5bc91a890e", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "5e21308f-4214-8f32-e85e-871599e6ea4f", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "60472859-d8c8-a48d-4c3f-0ac18643491a", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "61a2c1d3-96fb-71aa-55cf-33c674680627", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "628d5b85-fb1d-3be2-1666-dd4ae4465c58", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "631019a5-52aa-5f92-b516-9f02ab27fd0e", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "63c687a3-67c0-9d3e-4bda-fc7d26ed4e96", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "63d0e165-8c30-09b2-576d-a0517c4317d8", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "64232e02-58b1-49f9-ed14-4ed2bc2cca29", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6430ecc4-8bfd-8a62-c7ff-1a819c81ab12", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "64ae45c7-d78f-ee6d-73c9-f4f9332e8811", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "657a5804-95d2-bbc9-e3a8-cb27991a4ff7", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "67ace8f4-0f30-1cd2-b6ca-071e23ec2cba", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "68043ff2-95b0-99fe-0120-ed51205672e6", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "698fabe1-43b4-9c65-86f3-65500666149f", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6a312723-378f-452f-ccee-cc8c2ce7a27a", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6a3a2ef3-ae9a-b881-f025-d9d175543545", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6c176ab9-ca29-361a-d27f-4b7f010acd63", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6d35848e-614b-c210-ba42-5c08c34d2f65", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6d8a71bd-3b1b-2819-0f1c-7c6f1615f245", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6db8b590-545c-5247-9e1a-c51a90a3b619", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6e9db836-8335-157d-2b66-184effda711e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "6f1680fa-747d-53dc-d2ab-105243a1b1cb", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "70ee2824-090e-3fe4-2794-10f0c7f3f893", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "70fb017b-27b3-32f4-e15b-031807d3041f", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "71f57d4d-faa9-0cc6-82c1-fd3dd9f6c1c7", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "72a781ee-c6f9-c7a3-a6bb-dd39961e522e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "733a7970-863f-19e0-960b-550ffd7ebfb6", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "73532c4d-af3e-83d4-8425-4cc26ab37aba", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "73aa21b6-6e89-d724-606a-ff4a561441d6", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "73b44f51-5601-290c-5594-135cc98de227", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "73c7563d-39e9-4606-310e-2e3e31c378c6", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "73ef9028-ebb9-10e0-b568-0ab21799c6da", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "749b811e-fb13-4288-9280-1a0ac6ae1357", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "75a4e70d-830c-2c84-3356-f012e00406b8", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "764f2bb3-6cc5-14e4-6520-336d80427992", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "765a6d8c-c0fe-7187-2aa2-2346375627a4", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "77d7f16d-5ae4-b603-5a85-8890f1777158", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "77d8f4d1-c71b-c484-866c-ad2bbcee8d58", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "77f874fa-2a1f-f514-bfce-3249bea7bc6d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7872c32e-8849-26d9-8279-dae0014cea81", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "789d8ffd-898f-2aaf-f340-7783135e9a27", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "78aaeff9-5997-2b9e-dfff-14892277163a", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "78ecaeff-34c8-c97c-b69b-0c6690b4a848", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "790b2537-789c-2d30-aa17-fddb3dcc7e87", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "79a2515b-c784-5fe3-20cb-1548b67dc9d2", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "79c2c8a5-b015-8ddf-6df6-251e26904dd1", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7a234537-baf1-3524-b7d5-0e086755bc47", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7a29af3a-374b-0d68-6adc-9c128bf68f2c", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7b8b3263-39e1-5145-8a7c-922bed22cd08", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7d9ad1c8-2f22-2da1-d373-f6781481e17c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7ed7d5ba-b85a-94dc-e41a-951452adfd76", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7ee8ecf2-a327-72a4-39a3-f550b848e994", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "7ff81ee8-300d-ddc6-319d-7dfa7218fd58", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "81a26782-c24b-32fc-fb34-09efe90725d6", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8364106c-5f3a-598b-2ac0-3ed214205fef", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8390a9f6-0a93-19fe-59e1-f9f55f5ddd6c", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "844e7674-593d-adb3-1440-7f2a1fab57a4", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "849b1616-601b-3dd9-557b-16d80403b1dc", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "856171a7-b9ac-4830-b2d8-9cee3fdcade6", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "87e48982-f0da-a5f3-0b94-9ea581b65f84", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "882e9f04-341b-9074-4919-525657521655", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "895409e2-f453-7a65-bb3d-25c0b35987f2", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8976f83c-4baf-c2f0-376f-a1e360cd7ef0", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8a6cc122-2f10-d00a-54f5-d2ac0bc48657", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8aa6d384-bddc-d1af-b54c-f4cbd87e1b21", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8bd34289-d07c-921a-c6cd-bb4b146fdcc3", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8c6aca27-a8a8-0c0f-1002-e52f6eb2561b", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8cc8c34e-a72a-148b-03b0-f8ee5fd74ca2", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8d189383-f0b2-811e-27a7-413d45d77bc7", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8d236de0-d974-e10a-d60c-6eb6d6ee45ba", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8d39f934-18e4-6144-1d94-ded1104d046b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8da9b865-ec75-e977-9c4c-609e2b0b4bbd", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8e09b870-6631-2b58-4357-c8e2715354f3", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8e209ba0-d4c5-1bc4-1217-b046044b7cbd", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8e7a8865-e1aa-c65a-3f83-fb8382e84b73", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8ff68495-91b6-7636-684d-e74d8db1cef3", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8ff891c5-6be8-cf4d-c081-c3c877e21d1b", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "8ffc693b-16b1-8101-db46-047a98051af7", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "90ef151a-2989-8953-bd19-90dd0821143c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "91e6ee14-7d3d-ee2a-2bde-63a3eb189429", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "91fc97eb-284d-bef1-4eaf-5747976f12d9", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "935c4906-2965-0faa-073b-4831ee9f3c48", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9419d91c-fb6e-946f-bacf-338bbfb69b57", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "945a3a2c-b742-5cf0-08ae-46eb85a20a36", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9499db5d-73f2-29e0-6699-6fee9b30efcc", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9651c893-06d6-049d-48ea-4068fa9fe013", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "96b1462d-19ec-a38c-05a7-8c261b7ce639", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "96b814eb-178a-5fe2-b4a6-eb71b6006fa1", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "978d0096-a189-7be1-55f4-a61ca61d2828", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "985812bb-b587-86fc-300c-964d20bb99fe", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "98a8f4b6-5e8d-2f6c-8758-6666656e481a", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "98f3fdc5-c2cd-f68b-96bd-732dd43c8529", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9971fa58-a988-4a0b-0bde-87bf140e6b77", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9a87aa15-1dd8-4cbb-afbc-52337f77c2ff", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9ad1b67e-6011-dbfc-53db-ddffab249a2d", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9af6f1ff-5c76-981f-16b1-cff0e00e7faa", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9b05b001-4131-ed42-634c-10196745c2d2", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9b3bd5a9-f7ad-eece-81d5-eb1e34b3e9cc", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9c811b0b-75ce-1d6f-75bc-1c02b0f27f3c", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9c845855-86f5-5a7c-6a9a-ab196a2fc168", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9d09c449-338c-e3e8-fc9f-e17d64f8f16e", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9d1207eb-453a-4a13-6571-c8cfdaa7475e", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9d2229a0-0c0a-04e6-50eb-b3326b957e75", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9d3d2f6d-074a-0e8a-04a1-d64fad0a7ca5", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9dcbb2e1-1288-8061-7552-95fc4a54127f", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9dd52fbd-e3a2-3778-9def-1607fcba8a14", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9e3a1c36-c83f-de64-7a15-a427c2d53ea7", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9e55967e-b361-b475-1d74-2da173a313ab", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9eceb91a-7f9b-fbe9-d071-540a01948571", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "9fb457e2-45bd-9c59-9632-dd2b36d435f2", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a0670202-2854-2e50-8de5-c40c09ce45d4", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a0923ee7-dc84-4fb7-e960-64ba86e14501", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a0f2d093-4ef8-8c6e-433d-875f5fae4ae6", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a1f1d7a7-bddb-23c9-a786-8be00afca275", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a1f48c0f-fc61-d167-ac87-a547004aa023", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a228ae2d-6872-3077-746d-e7caa9826050", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a2dc9424-44ed-80c3-e2bf-2fc537ce7c31", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a2e87a66-9129-c8b4-8f19-1a7b0003f9b4", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a2ebb53b-d53f-3243-6067-58d54306b7f3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a37ff634-cd9b-ef97-1174-7895dac5142a", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a39e1659-d76f-b466-dcb4-6e403c08235e", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a41f5899-263a-2ba5-d89f-83fcb8615004", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a59870d1-3aa1-1ffd-b0b0-5f0eef5f14e4", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a5ad0348-d074-cc01-5380-d87b5fe5dc57", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a6df2aeb-dc33-065d-ecc9-bf2472024f34", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a6e15963-ccee-056e-b08a-7b411a5faed5", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a7e8a312-e5ac-380e-64c0-58e134a0eb3a", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a82312a1-29aa-9773-85f5-3a79b946447e", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a88474d9-7b40-75c4-103c-4756fefc5223", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a987acc4-6719-b547-a33c-941a36a8ac2d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "a9c039df-e5b6-5874-9c20-40b1c8c81a18", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "aa1b61b5-90b5-7fd4-8e47-7cc758c171b3", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "aa4fa9c2-81bc-294d-cb27-c2b5b55fab2b", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "aa5e6d3e-6879-9a9d-240a-c4b8d59d977d", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ab988871-3db3-91fd-fdc6-c24dc63b2ff3", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "abc1a019-0ef7-cbc6-fcf3-2c8326df2fe4", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "abc6b243-5588-2a14-659b-cd1c72698bf6", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "abf10a27-3ac6-2e58-96f8-def34af99ffe", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "abfa578c-1059-0e95-41fc-6b4a6cc5bd35", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ac61a898-07d6-ed31-0122-23756b48dd8b", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ad086427-ad88-1b14-74dc-3c734d9f8fb0", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ad3ad1fb-e09d-f4dc-0ea3-acb109796d53", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "af3d7485-acdb-8cea-67a2-6784f57fb5af", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b138dcf7-c96a-95da-7950-ca0ebeca603b", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b1a95a03-38ca-ee92-017c-5209fe2a86e6", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b1c46032-68bc-da8b-5947-ff34f797a32a", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b20737f2-721e-1d65-17b2-417ab128a58f", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b383ee88-a3d4-9a92-14b8-4ad063d05858", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b3a131b9-2c77-3894-f208-cb79d39faca2", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b3a8c3e6-2323-b55f-9c32-0b87693deb72", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b4d3824a-cc8b-bf10-4c1a-b8023aea893f", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b5308f06-151e-ee1d-d1d9-567a5c3df214", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b585a522-6b7d-2bde-80fe-59857d64cf59", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b5e54f3a-245f-7903-3b7d-8ef6772d70e7", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b646c1a0-6866-82ac-52d3-c26c028a197a", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b648d7d6-c04b-1683-2bcc-c8232f2c923a", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b738fca4-5187-2cb8-fe64-bf110f27dc19", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b73fb90a-f41a-0c50-2dd7-6d2cda329ea9", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b79bbe9d-8926-288f-0bdc-9007eb0b656c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b7ae36e0-29fa-4028-0fd4-b1091ee273e1", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "b9740ffe-3edf-4783-e5ad-69012f24a391", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ba235bd2-9ad8-ed2e-d547-fbd573117230", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bb2fb4ac-48e3-3274-181a-669eb9886be5", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd079d7b-b8ac-b648-0a0f-fa0d75c647d2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd194d03-59f8-3e62-32e6-fe4f7a3b879b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd2342ba-3dc5-ee86-3dfd-38ca414e3fca", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd26c6ec-d165-4279-e832-a0635cb9a1e5", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd3a37e9-fe59-1c15-b82a-aecb60558898", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bd5c5e1b-5be8-03c6-a5e2-39063b12d65e", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bdd09408-1595-3d9e-9ba2-750a734e3f90", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "be8499f8-c80d-6ecf-0314-d9a438061154", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bed3ffa9-e96c-f7e5-eb1b-e22f1ec71421", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bf02e8ed-6ab9-9191-d50a-9c05cf34fcef", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "bf542d10-d3a3-6bc7-9bfc-b0462086ba9b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c0028500-4cdc-8005-bb90-ed6399529b3f", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c025d9b6-56e5-4289-89de-69f2f2d1d013", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c054a00b-472b-2614-aac5-8337913cbe70", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c0c452c8-6e09-202a-74cc-724212b93b85", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c105f40c-b412-3a64-e00a-cb1f14df7cd8", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c10a0baa-1e4b-54ba-5d59-5c584d8ae3ec", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c3f29e56-c774-c1c8-366d-35e9ddfc64be", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c437ad27-25ad-790e-ec14-e4cbb2c7d54f", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c470d37a-a616-4624-0e1b-a3d600ba3c08", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c49feb4a-a697-d42a-ade9-8a8f6028bbfc", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c4b97e73-7182-c9d9-9bf7-916db4bdf6b3", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c5a0b44d-30ce-829b-93a7-716afe1e5163", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c65167ab-7aa0-3908-3e63-2698d06fa1b4", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c757b477-07a8-d325-d4cf-a0a78e352f66", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c7a68e32-cda7-b864-e7f1-ba2ae5fab309", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c7e266d7-3097-a994-1174-d3cf1608c41e", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c8006108-d31d-3fc3-8118-4a00aa1228c8", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c83566fe-4da0-b680-43f1-aaa1880db549", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c888fa0e-3ba4-8446-ca99-35f2dd69819a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c8e06257-6008-61b4-4b53-278d79854078", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c93aedf9-5f94-9dc3-c599-63c7235e54e4", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "c9db2283-f63a-871f-3474-0b3644830bf8", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ca31003d-2c4d-41c8-9b9b-4c61347b3f44", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cbff8567-0725-b204-ba70-6b3ea17679a2", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cc89b80d-6432-18eb-4c1f-89d48642289d", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cce2ada9-2f2d-ce10-1509-2e3988f0040e", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cd47af08-b065-d7f9-957b-4331cf499a84", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cd4a2b32-4de8-cae4-d813-3a9c528bce84", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "cfb44862-44a4-9cc9-5636-6fc938d47be3", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d0425968-0a5c-0a9f-3897-b55f4e22a274", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d051e973-698c-58dd-bda6-63d696077ad3", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d07bb88c-bdf7-0c6b-a371-44ce794f7d3e", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d2e5a5cc-7ca8-1bdd-b989-bd9c35ca0e88", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d39c0714-beb7-9fc0-1fba-437d66426189", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d4f123f5-ec66-2062-e7da-d35c3ee57eee", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d6004a9b-1c74-80de-a857-6060eaf7261d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d6592817-12c5-1929-7656-0bc610ac5bb8", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d7752dd6-7176-d04e-be06-8422283faab2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d7fdd83a-70db-66ab-6375-91cd319db355", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d810fb97-00e7-f2a0-0985-acffaf11b187", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d83d4cf6-076e-8942-5a26-f3fb3c195bbf", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d887248e-7c1b-b541-76ce-6a1429625aa7", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "d9396d48-fd20-a52d-70b5-3f2085f7cfec", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "da917375-989e-aa66-3705-7fb13adc13b7", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "db8cd639-647a-8b58-26e1-09ded6668cba", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ddc05051-6ba0-9876-0a13-ebc3052d2b4e", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "de4618b3-b26c-8e28-0a99-ae5525670cd5", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "df6e2e51-1635-c552-c2e4-47c20b623af6", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "df7466ab-6cd7-323b-3000-734d0a87e629", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "dfa77c24-d946-d3aa-8143-2d2980309d6b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e02b7f77-b4c9-bc10-276e-685319e06cae", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e0423095-2fec-629c-28ab-8d15fc453cf0", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e04a9235-6450-7289-01d9-1e0c6d60181e", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e0a5ac38-0109-c23b-cdf9-bfcc771a6956", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e1cc35de-1693-fdc6-8795-0119f8f61623", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e291f668-1c34-8928-0af9-193ae7989012", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e29f5f7f-1c7a-cc69-3cb1-b84d99512a10", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e3444b28-a5e6-7291-e9e2-d64fc228bdec", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e44ff3f4-6ff9-8af0-f12a-63b3268c710c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e4b69797-276b-44dc-f691-2839ccadbc59", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e549f908-0b9f-bc96-93e7-a3debcc701cd", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e5534c19-113d-4705-a9f8-5a5534f534bf", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e792e81e-cd41-7b11-d310-735b5b93ea00", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e7ac8242-2bdf-3ea8-34ed-376cd6d4cc6d", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e8e08ba6-7aaa-47b0-1ba8-5672399ddd9c", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e91072de-8876-66b5-cceb-4cfa6eb00b82", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e915fc4f-2425-c1b9-7448-6f93374f4d93", "14185a87-c07d-c0db-e37b-536e871528f2" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e992a0f0-7cfc-f1ea-667c-c308c7560737", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "e9db33d6-c21d-844e-fbab-1988c3f1c501", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ea01f8ea-b73e-be93-9a72-7db9fa21dd8c", "63d58b13-c957-6ee8-4ed6-303e20d09973" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eb190148-b365-1499-4bcf-34a8307d3ae5", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ec46c0fe-0b44-80a4-27fb-211fc8190195", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ec4fae02-dbe6-d8aa-4d3d-da1c38fb7f7c", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ec725cd5-16d9-76f8-27ad-d5aa62b86c1b", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eccdc834-73c7-adb9-9ff5-6255b7257146", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ed3daf70-fcb0-7b32-f292-becdb3eb3eb3", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "ed67f473-5441-c705-b174-e26119a10316", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "edfda5e7-5084-880a-022d-29069aa5cbfa", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "eef85155-102e-817b-0de0-1e2e035404d7", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "efa6a2ea-b018-6b26-35e2-0f08ee59c252", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f129bad2-788c-bc9e-89cf-60039b8e604a", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f14fc5c6-c061-1111-1e79-f268130aaa74", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f16f91c3-4de3-d09f-4071-921f313f15a8", "1dbea3b9-23c2-3605-d494-ca1c7124c184" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f1707df7-3aa5-d08c-ea15-5bd6269c6cd3", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f24c8abc-3f83-5162-2e6c-56859c5c056b", "041d01e0-b34f-4331-85d9-9453132f67b6" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f2ffd04c-6cf2-db85-a42a-bdb85851cef7", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f3b1abe6-fc82-148f-0715-4d25554e7fa3", "455c6918-8f55-8171-e3b6-573e17977cfc" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f3b3e51e-629c-d167-01db-a6540d350738", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f59455ff-4ce7-d960-dc83-0e9693fa47a6", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f602e4c9-bc99-4d36-b8af-7f9dcb88d01c", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f7033651-e69a-4324-fbe2-d0182b44a808", "26d3840f-0826-0efe-7045-e23034efc8cd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f74652db-dc7b-535b-b335-595d87ad4277", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f7502be8-0a9a-4d63-69fe-fba66d3fc191", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f7875753-a25c-5e48-6009-e5dbdd89d86e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f81f9d3a-35d8-f873-8f95-45726a1387a3", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f8eda48e-36b2-3c80-2a8d-45ed824d3d02", "606137a2-9de4-e505-00ba-117bc0f24b82" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f95addc7-9b43-8f11-22be-04c9b277bbbe", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "f9f1b201-c78a-46fd-3f7d-701f0cb9d80b", "f8360932-cad7-22ba-add7-d31883af9229" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fa8863c0-67b0-85c7-5ff5-bf270e35170e", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fa95ca2d-6015-d738-9bbe-e8cba5195c60", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "faa58a8c-d950-2e5f-5a1e-2fb3331958ca", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fb2537bc-4439-2071-55a0-b6407e36e5e0", "ff7eb421-56b5-3bbe-779c-355ceed7246b" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fc38688b-a5a5-0a3e-f73f-a130d3c1ade0", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fcbbff35-ac21-d887-426b-fc0c5af9fa0d", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fcbeb7c4-fd9c-40cc-b15e-4ddf4d47233b", "7ac11e50-5cbb-c818-9b31-5e91770eece0" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fd1bee15-e7b2-9c75-8f36-bf9c4510c9c5", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" });

            migrationBuilder.DeleteData(
                table: "Teach",
                keyColumns: new[] { "session_id", "teacher_id" },
                keyValues: new object[] { "fea0de9b-2eaa-f28c-2118-dc74ea12b4b5", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" });

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "session_id",
                keyValue: "6eeab54d-48f6-9f68-1ca3-b7ed0c89b7cc");

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "session_id", "course_id", "date", "Description", "end_time", "mode", "room_id", "session_status_id", "session_type_id", "start_time" },
                values: new object[,]
                {
                    { "1340bb3f-f749-7b9c-e64c-32cc1e407f57", "f8c83971-d090-c665-8911-cd645e1a3c87", new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 18, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7d12ed93-7363-9686-49c3-77ad3ccb2da0", new TimeSpan(0, 8, 30, 0, 0) },
                    { "8d1a51f4-7532-f767-7fb9-bb9829556752", "f8c83971-d090-c665-8911-cd645e1a3c87", new DateTime(2026, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new TimeSpan(0, 18, 0, 0, 0), "PRESENTIAL", "02bcf600-5d44-cca7-8b68-e763b00a6339", "09de5696-05df-5b4a-ca95-666d0306b369", "7d12ed93-7363-9686-49c3-77ad3ccb2da0", new TimeSpan(0, 8, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Teach",
                columns: new[] { "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "0048393d-d5a2-01af-d913-bc890fe8b2ae", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "00e55ffe-e77a-1041-83fe-f230819a98a6", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "013a00ac-ac8b-5c01-8a57-5e3a952f41c6", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "015728e2-d208-f4cc-9b3c-b972b482801b", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "02a2a3e4-b5c0-289c-5dfd-95324e623d49", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "02b8e933-beee-fd21-e81d-20c13cc2b9d9", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "035596ea-77a5-4678-2440-1215400176b5", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "03a99c53-fb54-e2d7-6a4a-3c27563d7b9c", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "042bb7cc-acb9-432e-6025-f01f85edc241", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "04ccea8a-4e53-42db-c31a-0e8f2c805783", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "053f68e1-2f0e-089c-76f7-de930e8668f9", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "05bd8efd-7965-885a-712a-23b65c741a8d", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "05c1638f-8bd7-6101-ecb2-b86c4e36c561", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "0633fa76-26c4-bbb8-04b7-ac2dffc5035d", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "06db607d-9866-9b91-3737-5d793f448048", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "078427d0-9b6a-f123-fccb-8e5843a2e640", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "07a3cd0f-fe14-505c-acdf-f777e37778f1", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "07f20e2d-9dba-3c0d-6168-ee83fdae9385", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "08859e7a-33b4-e98b-b9ef-f754da6f424b", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "0993178d-8c63-8c40-84f9-5f0d8407806a", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "0a613941-9193-abf4-25ce-a79ed34acf0f", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "0ab1812f-650e-a53a-7a38-d1191221716b", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "0abc4d04-e557-58b6-e4bc-7e52cfede4f0", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "0b0eee80-ebc9-0e27-a0d3-4124d340c71d", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "0b13de7b-3a06-5d38-eccf-e9bb8db4be94", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "0bc8e3a7-1aed-9f32-20e8-ab95b541caba", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "0be92ebb-39d3-323f-c309-af2cbab9b45d", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "0c81ee88-383d-927c-6006-4e96a8d886ec", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "0ca55a2b-4b81-c691-b83c-cb46471e0616", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "0cd4c552-ef7a-3da8-74d3-a0393d836d30", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "0cf2cc5d-7bc0-f1d6-49b8-99c8e5afc22b", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "0d5335ac-dc82-6607-9000-ce5fb7df023d", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "0e09a6c4-a5a1-ce41-7427-98ad5a20a6e6", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "0f278cb7-49d5-fcc9-b743-6c6f611b8aac", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "0f702402-059d-f301-63c5-f10eae2added", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "10c6170d-a542-dc14-754f-794aa16ea0cf", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "11065baf-e680-3a0f-0ba7-1eca5f0d5203", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "11a47728-c8f9-ee9b-363a-3a89d6c24797", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "11ac6e88-a54d-0fb7-d0af-0368bd55f51f", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "13665640-d5be-7545-5e75-b567631717d7", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "1452324b-c53c-15c4-079f-4a2000e03019", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "1497fba7-91b9-0f9e-413b-a1a7a9487f45", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "165b9f17-2130-1b34-da4c-1235fc6ec986", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "165be93e-3f49-13b1-427e-af18f7d6db8f", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "176b9a55-95f2-70a6-0d8a-c46a6f228bea", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "17ab550a-68a1-728d-c3c0-64c7bc72f3fe", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "1828a070-068b-a95d-05bd-97d1aa5306cf", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "18293f33-cf24-6dd0-fea8-750eb629c0de", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "19f2fad4-a69b-5816-5671-7dca8e1f05c3", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "1aeee50c-ccc4-bda1-52a4-8d413ffe2055", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "1b1697a9-3a2d-fc57-4a13-6eb57d67f819", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "1b84325f-12c9-a783-29b9-032c0e6283aa", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "1c4cacfb-dee9-07de-5cbc-d5ab91b33773", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "1c9c63bf-825c-13f7-fa0e-9f0699f61ecb", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "1cd5ed06-8055-c77f-14d6-607ba085772a", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "1d041991-5f0e-c23a-8999-aa6d5e5cec41", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "1e356af5-9fbd-d306-bbc5-eea3d0b204ad", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "1e5eea31-29c3-bc5d-2667-842eff3b544c", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "1e95312c-bb54-5051-1d8b-87fa3be05371", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "1edd5504-cbdd-721e-c3f8-b14406688ec9", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "1f060a0e-833b-9361-4a59-0ffc6ca53af2", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "1f0d2ada-0af7-a1a9-d34f-e43e47f0979e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "1f87bcd1-4567-9f7a-a2c7-c8251419643f", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "1fb7b886-b13d-200f-7df6-7ebda0de9ccc", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "1fef362a-d1da-0a5a-84f5-8ae89094daf4", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "20ce0656-3d5a-66ab-6bc6-0e90ad09655b", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "21ba83f0-c8cf-756e-d382-667683820599", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "22c1caa2-aa3b-3e37-6efb-8fb7c07f54ca", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "2310c342-bed5-4b9f-eba2-02e50ce02e57", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "235b3715-edf8-71b1-9850-c2f6c754d99d", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "248bcdbe-1d25-60a0-8656-ea43b2f22920", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "2592466e-b4d4-4655-9eb3-6de7071ccf75", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "2605d9e6-c136-20c8-1831-a1f1ffd05ec7", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "27157c99-c60c-e69d-0cf7-6d49797717a7", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "27347831-35fb-67fa-ab30-fe2735abbbd8", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "288acd27-59ec-b9f5-160f-bf6e569dbf73", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "28b5dbc2-f5fe-d1df-1276-f0264e5fc36d", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "28cc2966-659a-7c43-550d-d3e856e6eb75", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "29b71050-1d78-d4d7-0445-b899e17f1db0", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "2a81166d-6b54-e987-5809-652afadd1182", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "2adde9fd-954c-932b-bf95-c574715ee59d", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "2b072eec-8afc-2975-cf37-acd3112a3d9b", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "2b1ce470-481f-5868-f4ac-26e876e4d79b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "2b9b9d22-41a9-95c7-6b24-f4c5298461af", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "2bb47397-839a-9256-9cb2-7ca19bbe6f6d", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "2c5e7c40-eda0-861b-ff60-079cbd28d62b", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "2ccff467-3ffe-b229-11db-213c0682008f", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "2cdc1759-9120-bd86-70c9-29940340600c", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "2d9a3c10-b1dd-f004-0f69-2e3a4bae5c5c", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "2dd686c2-90fb-215c-484b-6abf33d7f0f2", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "2ef053bb-a426-74eb-6498-47e542671a5a", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "3177b094-26b1-b068-a92e-12b1ea020c51", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "3188ef65-4dde-15ad-a99a-83fd6b6c05a2", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "3211d60a-a2cc-4aae-e597-0618dc72fd91", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "32b099e1-a3d1-4e0f-9e32-56ec913b08fa", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "333a9e97-7b22-78cf-a2aa-054acbed29d6", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "33629096-47e0-4ae4-df4f-b9b15bb01a06", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "33efd6cb-b6fa-3383-51f3-b5ce1564e043", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "3467ad0e-4caa-a9d4-ebe6-b07c78d758be", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "34dcfbf0-bd44-0123-ea20-2bd73d504f1a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "35adacf1-d9c3-d92e-2f59-fd496b6a14db", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "3617723f-5fa3-13c5-747b-af12024e1739", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "36d84ce4-f349-afc4-6458-0cf8242cb742", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "36e83abd-b95b-2bff-8076-d432a0d126c1", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "376435b2-4f87-d45c-9d3b-0f1a7fe26993", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "37b5538d-83d9-db1e-c957-873f1f52b8e1", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "384a335b-ead6-a595-1afa-792fa5f1d8fa", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "399b3fe0-a8db-f30b-561a-3eb2fa5d587a", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "3a67330d-23e1-7ead-b469-1adf44300612", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "3aa7cd04-b4c2-cc6f-b69c-a73c4dc31b69", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "3ad232de-dead-1de3-4ef2-1a7a1bcae815", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "3adb884d-00f4-7452-b153-172589985de0", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "3b42cda1-04cd-5377-70ca-5f9c09522015", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "3bd48e65-a546-53b8-11be-9168f9315439", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "3c384aff-7c16-316e-ecdf-de092cb63839", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "3c4db87f-2c67-8431-5028-cc295a2e3087", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "3da16659-e34c-a32c-0e88-f464e813b606", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "3eb63cdb-d52f-72b1-555a-1bc3287a6e99", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "3f839a52-c325-f2fb-b74a-c0f31808b557", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "40137d15-bd16-30bb-80eb-aaabd3357137", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "412ef48d-01be-55ef-5ebb-4a78431136ee", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "42046a6e-e4b1-6bd2-f0ac-7fab8592bd81", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "43370ead-9fca-c16d-cee6-46c82788d337", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "43dba54c-ac20-eaf1-aa78-e5651b270a61", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "44aaf7b1-791f-8f82-c0da-7ebb41fd7242", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "4557c67c-df81-999d-af4c-0c484bf21983", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "45af8d84-cfe9-7ed6-18a6-0d89016bac6d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "45ddd76f-2146-20dd-4044-b056b0e89930", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "45ef5fb7-f21c-293d-6e77-44f359cf722d", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "45f1ab9e-4cf6-ec9c-2b17-9c7adc6a6cc6", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "4655bd8a-abe0-ed09-0f95-f22d7f8c4bfb", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "489eb465-3148-2790-459d-d37743bc1fc9", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "48bf7f82-1ca6-e351-83a6-20588e74f9d9", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "4903fa5b-de46-5fc6-a28e-0f0cd0ba7c7d", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "49cbfa48-c9a4-d8f0-1a8a-1191d3b61d23", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "4a1350c1-b7cd-0abf-d114-716504b16a7c", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "4a9e4b89-4361-e36c-5dbd-676385437cbf", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "4acd9232-d4af-fc54-d001-272120ba0f3e", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "4af77d70-a98f-9201-b485-970850a53a5c", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "4b064eb6-10c3-39c3-883d-0424a8ea810b", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "4b3fa2e9-13d6-815a-1991-3379fa24d213", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "4c6b6e9f-a614-de54-097f-4c095f09b343", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "4c74eddf-31df-3d9c-e01a-935aab29f802", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "4caafe08-88b8-f527-d617-30c43c95947c", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "4cd5f36a-93f7-1b54-cabe-8128f0dfd674", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "4dd2b11e-e285-eba7-7e11-217a1f1a5016", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "4dfa6633-4102-2dee-0768-2c3ef94f351a", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "4e6ad58e-34f9-3aad-d394-6c22e98c28e6", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "4f96e085-90db-e38e-531a-45f6abfbd4b5", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "50278dc0-3ccf-66c5-6639-d8cf2c3a45c3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "5119b0f0-763d-45e9-dabe-2e015463004e", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "52337c23-7694-cbf4-76c9-3dd7f121c476", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "52659ecb-a874-76cd-e727-9e93c72dd9e6", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "528cf0ef-0ad8-1440-1a6a-d89ca66b78ef", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "532a40a7-77e5-d8ad-e9d1-5ac05b8f1fb5", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "55803d94-5a30-5537-708f-9a29af0bb608", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "564788db-7533-ad1d-c822-688c966ea182", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "573e2677-41f8-31b7-9951-eb1100b2132b", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "57ab359d-3846-c2bb-ed46-058d12813eb3", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "57be9b47-7cba-8ebb-640f-e274971152ab", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "58ee5b4f-5255-02ce-b2d5-07a5c8ca7673", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "5928a75b-88dd-4a5d-ca54-6d5bfaeab6bc", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "5949817d-4426-d92c-eda5-7bc93010d7e7", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "597d6d71-d02d-d972-6906-47dd94af9989", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "5a62f7f4-969e-0b36-2084-91de9f91eb34", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "5ae81cf8-1483-9145-cede-a1d072e27dfd", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "5bd766de-0af8-d57c-839b-1f71e24d41df", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "5c070507-4cfc-7437-9688-8a3fa0311229", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "5c440b1b-c528-b1b7-ea36-c8c51c52f6a9", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "5c67d3c5-f64b-9042-df1c-37f8122fe8e8", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "5cb76838-2148-bb64-3c35-e732e56238c5", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "5de5e483-bf65-3751-6439-ad5bc91a890e", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "5e21308f-4214-8f32-e85e-871599e6ea4f", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "60472859-d8c8-a48d-4c3f-0ac18643491a", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "61a2c1d3-96fb-71aa-55cf-33c674680627", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "628d5b85-fb1d-3be2-1666-dd4ae4465c58", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "631019a5-52aa-5f92-b516-9f02ab27fd0e", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "63c687a3-67c0-9d3e-4bda-fc7d26ed4e96", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "63d0e165-8c30-09b2-576d-a0517c4317d8", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "64232e02-58b1-49f9-ed14-4ed2bc2cca29", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "6430ecc4-8bfd-8a62-c7ff-1a819c81ab12", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "64ae45c7-d78f-ee6d-73c9-f4f9332e8811", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "657a5804-95d2-bbc9-e3a8-cb27991a4ff7", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "67ace8f4-0f30-1cd2-b6ca-071e23ec2cba", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "68043ff2-95b0-99fe-0120-ed51205672e6", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "698fabe1-43b4-9c65-86f3-65500666149f", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "6a312723-378f-452f-ccee-cc8c2ce7a27a", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "6a3a2ef3-ae9a-b881-f025-d9d175543545", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "6c176ab9-ca29-361a-d27f-4b7f010acd63", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "6d35848e-614b-c210-ba42-5c08c34d2f65", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "6d8a71bd-3b1b-2819-0f1c-7c6f1615f245", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "6db8b590-545c-5247-9e1a-c51a90a3b619", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "6e9db836-8335-157d-2b66-184effda711e", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "6f1680fa-747d-53dc-d2ab-105243a1b1cb", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "70ee2824-090e-3fe4-2794-10f0c7f3f893", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "70fb017b-27b3-32f4-e15b-031807d3041f", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "71f57d4d-faa9-0cc6-82c1-fd3dd9f6c1c7", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "72a781ee-c6f9-c7a3-a6bb-dd39961e522e", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "733a7970-863f-19e0-960b-550ffd7ebfb6", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "73532c4d-af3e-83d4-8425-4cc26ab37aba", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "73aa21b6-6e89-d724-606a-ff4a561441d6", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "73b44f51-5601-290c-5594-135cc98de227", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "73c7563d-39e9-4606-310e-2e3e31c378c6", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "73ef9028-ebb9-10e0-b568-0ab21799c6da", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "749b811e-fb13-4288-9280-1a0ac6ae1357", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "75a4e70d-830c-2c84-3356-f012e00406b8", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "764f2bb3-6cc5-14e4-6520-336d80427992", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "765a6d8c-c0fe-7187-2aa2-2346375627a4", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "77d7f16d-5ae4-b603-5a85-8890f1777158", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "77d8f4d1-c71b-c484-866c-ad2bbcee8d58", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "77f874fa-2a1f-f514-bfce-3249bea7bc6d", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "7872c32e-8849-26d9-8279-dae0014cea81", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "789d8ffd-898f-2aaf-f340-7783135e9a27", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "78aaeff9-5997-2b9e-dfff-14892277163a", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "78ecaeff-34c8-c97c-b69b-0c6690b4a848", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "790b2537-789c-2d30-aa17-fddb3dcc7e87", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "79a2515b-c784-5fe3-20cb-1548b67dc9d2", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "79c2c8a5-b015-8ddf-6df6-251e26904dd1", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "7a234537-baf1-3524-b7d5-0e086755bc47", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "7a29af3a-374b-0d68-6adc-9c128bf68f2c", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "7b8b3263-39e1-5145-8a7c-922bed22cd08", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "7d9ad1c8-2f22-2da1-d373-f6781481e17c", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "7ed7d5ba-b85a-94dc-e41a-951452adfd76", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "7ee8ecf2-a327-72a4-39a3-f550b848e994", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "7ff81ee8-300d-ddc6-319d-7dfa7218fd58", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "81a26782-c24b-32fc-fb34-09efe90725d6", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "8364106c-5f3a-598b-2ac0-3ed214205fef", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "8390a9f6-0a93-19fe-59e1-f9f55f5ddd6c", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "844e7674-593d-adb3-1440-7f2a1fab57a4", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "849b1616-601b-3dd9-557b-16d80403b1dc", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "856171a7-b9ac-4830-b2d8-9cee3fdcade6", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "87e48982-f0da-a5f3-0b94-9ea581b65f84", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "882e9f04-341b-9074-4919-525657521655", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "895409e2-f453-7a65-bb3d-25c0b35987f2", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "8976f83c-4baf-c2f0-376f-a1e360cd7ef0", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "8a6cc122-2f10-d00a-54f5-d2ac0bc48657", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "8aa6d384-bddc-d1af-b54c-f4cbd87e1b21", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "8bd34289-d07c-921a-c6cd-bb4b146fdcc3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "8c6aca27-a8a8-0c0f-1002-e52f6eb2561b", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "8cc8c34e-a72a-148b-03b0-f8ee5fd74ca2", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "8d189383-f0b2-811e-27a7-413d45d77bc7", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "8d236de0-d974-e10a-d60c-6eb6d6ee45ba", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "8d39f934-18e4-6144-1d94-ded1104d046b", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "8da9b865-ec75-e977-9c4c-609e2b0b4bbd", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "8e09b870-6631-2b58-4357-c8e2715354f3", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "8e209ba0-d4c5-1bc4-1217-b046044b7cbd", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "8e7a8865-e1aa-c65a-3f83-fb8382e84b73", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "8ff68495-91b6-7636-684d-e74d8db1cef3", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "8ff891c5-6be8-cf4d-c081-c3c877e21d1b", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "8ffc693b-16b1-8101-db46-047a98051af7", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "90ef151a-2989-8953-bd19-90dd0821143c", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "91e6ee14-7d3d-ee2a-2bde-63a3eb189429", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "91fc97eb-284d-bef1-4eaf-5747976f12d9", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "935c4906-2965-0faa-073b-4831ee9f3c48", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "9419d91c-fb6e-946f-bacf-338bbfb69b57", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "945a3a2c-b742-5cf0-08ae-46eb85a20a36", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "9499db5d-73f2-29e0-6699-6fee9b30efcc", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "9651c893-06d6-049d-48ea-4068fa9fe013", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "96b1462d-19ec-a38c-05a7-8c261b7ce639", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "96b814eb-178a-5fe2-b4a6-eb71b6006fa1", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "978d0096-a189-7be1-55f4-a61ca61d2828", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "985812bb-b587-86fc-300c-964d20bb99fe", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "98a8f4b6-5e8d-2f6c-8758-6666656e481a", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "98f3fdc5-c2cd-f68b-96bd-732dd43c8529", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "9971fa58-a988-4a0b-0bde-87bf140e6b77", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "9a87aa15-1dd8-4cbb-afbc-52337f77c2ff", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "9ad1b67e-6011-dbfc-53db-ddffab249a2d", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "9af6f1ff-5c76-981f-16b1-cff0e00e7faa", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "9b05b001-4131-ed42-634c-10196745c2d2", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "9b3bd5a9-f7ad-eece-81d5-eb1e34b3e9cc", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "9c811b0b-75ce-1d6f-75bc-1c02b0f27f3c", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "9c845855-86f5-5a7c-6a9a-ab196a2fc168", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "9d09c449-338c-e3e8-fc9f-e17d64f8f16e", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "9d1207eb-453a-4a13-6571-c8cfdaa7475e", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "9d2229a0-0c0a-04e6-50eb-b3326b957e75", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "9d3d2f6d-074a-0e8a-04a1-d64fad0a7ca5", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "9dcbb2e1-1288-8061-7552-95fc4a54127f", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "9dd52fbd-e3a2-3778-9def-1607fcba8a14", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "9e3a1c36-c83f-de64-7a15-a427c2d53ea7", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "9e55967e-b361-b475-1d74-2da173a313ab", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "9eceb91a-7f9b-fbe9-d071-540a01948571", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "9fb457e2-45bd-9c59-9632-dd2b36d435f2", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "a0670202-2854-2e50-8de5-c40c09ce45d4", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "a0923ee7-dc84-4fb7-e960-64ba86e14501", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "a0f2d093-4ef8-8c6e-433d-875f5fae4ae6", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "a1f1d7a7-bddb-23c9-a786-8be00afca275", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "a1f48c0f-fc61-d167-ac87-a547004aa023", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "a228ae2d-6872-3077-746d-e7caa9826050", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "a2dc9424-44ed-80c3-e2bf-2fc537ce7c31", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "a2e87a66-9129-c8b4-8f19-1a7b0003f9b4", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "a2ebb53b-d53f-3243-6067-58d54306b7f3", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "a37ff634-cd9b-ef97-1174-7895dac5142a", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "a39e1659-d76f-b466-dcb4-6e403c08235e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "a41f5899-263a-2ba5-d89f-83fcb8615004", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "a59870d1-3aa1-1ffd-b0b0-5f0eef5f14e4", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "a5ad0348-d074-cc01-5380-d87b5fe5dc57", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "a6df2aeb-dc33-065d-ecc9-bf2472024f34", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "a6e15963-ccee-056e-b08a-7b411a5faed5", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "a7e8a312-e5ac-380e-64c0-58e134a0eb3a", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "a82312a1-29aa-9773-85f5-3a79b946447e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "a88474d9-7b40-75c4-103c-4756fefc5223", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "a987acc4-6719-b547-a33c-941a36a8ac2d", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "a9c039df-e5b6-5874-9c20-40b1c8c81a18", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "aa1b61b5-90b5-7fd4-8e47-7cc758c171b3", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "aa4fa9c2-81bc-294d-cb27-c2b5b55fab2b", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "aa5e6d3e-6879-9a9d-240a-c4b8d59d977d", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "ab988871-3db3-91fd-fdc6-c24dc63b2ff3", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "abc1a019-0ef7-cbc6-fcf3-2c8326df2fe4", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "abc6b243-5588-2a14-659b-cd1c72698bf6", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "abf10a27-3ac6-2e58-96f8-def34af99ffe", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "abfa578c-1059-0e95-41fc-6b4a6cc5bd35", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "ac61a898-07d6-ed31-0122-23756b48dd8b", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "ad086427-ad88-1b14-74dc-3c734d9f8fb0", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "ad3ad1fb-e09d-f4dc-0ea3-acb109796d53", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "af3d7485-acdb-8cea-67a2-6784f57fb5af", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "b138dcf7-c96a-95da-7950-ca0ebeca603b", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "b1a95a03-38ca-ee92-017c-5209fe2a86e6", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "b1c46032-68bc-da8b-5947-ff34f797a32a", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "b20737f2-721e-1d65-17b2-417ab128a58f", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "b383ee88-a3d4-9a92-14b8-4ad063d05858", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "b3a131b9-2c77-3894-f208-cb79d39faca2", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "b3a8c3e6-2323-b55f-9c32-0b87693deb72", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "b4d3824a-cc8b-bf10-4c1a-b8023aea893f", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "b5308f06-151e-ee1d-d1d9-567a5c3df214", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "b585a522-6b7d-2bde-80fe-59857d64cf59", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "b5e54f3a-245f-7903-3b7d-8ef6772d70e7", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "b646c1a0-6866-82ac-52d3-c26c028a197a", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "b648d7d6-c04b-1683-2bcc-c8232f2c923a", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "b738fca4-5187-2cb8-fe64-bf110f27dc19", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "b73fb90a-f41a-0c50-2dd7-6d2cda329ea9", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "b79bbe9d-8926-288f-0bdc-9007eb0b656c", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "b7ae36e0-29fa-4028-0fd4-b1091ee273e1", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "b9740ffe-3edf-4783-e5ad-69012f24a391", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "ba235bd2-9ad8-ed2e-d547-fbd573117230", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "bb2fb4ac-48e3-3274-181a-669eb9886be5", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "bd079d7b-b8ac-b648-0a0f-fa0d75c647d2", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "bd194d03-59f8-3e62-32e6-fe4f7a3b879b", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "bd2342ba-3dc5-ee86-3dfd-38ca414e3fca", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "bd26c6ec-d165-4279-e832-a0635cb9a1e5", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "bd3a37e9-fe59-1c15-b82a-aecb60558898", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "bd5c5e1b-5be8-03c6-a5e2-39063b12d65e", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "bdd09408-1595-3d9e-9ba2-750a734e3f90", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "be8499f8-c80d-6ecf-0314-d9a438061154", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "bed3ffa9-e96c-f7e5-eb1b-e22f1ec71421", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "bf02e8ed-6ab9-9191-d50a-9c05cf34fcef", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "bf542d10-d3a3-6bc7-9bfc-b0462086ba9b", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "c0028500-4cdc-8005-bb90-ed6399529b3f", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "c025d9b6-56e5-4289-89de-69f2f2d1d013", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "c054a00b-472b-2614-aac5-8337913cbe70", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "c0c452c8-6e09-202a-74cc-724212b93b85", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "c105f40c-b412-3a64-e00a-cb1f14df7cd8", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "c10a0baa-1e4b-54ba-5d59-5c584d8ae3ec", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "c3f29e56-c774-c1c8-366d-35e9ddfc64be", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "c437ad27-25ad-790e-ec14-e4cbb2c7d54f", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "c470d37a-a616-4624-0e1b-a3d600ba3c08", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "c49feb4a-a697-d42a-ade9-8a8f6028bbfc", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "c4b97e73-7182-c9d9-9bf7-916db4bdf6b3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "c5a0b44d-30ce-829b-93a7-716afe1e5163", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "c65167ab-7aa0-3908-3e63-2698d06fa1b4", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "c757b477-07a8-d325-d4cf-a0a78e352f66", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "c7a68e32-cda7-b864-e7f1-ba2ae5fab309", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "c7e266d7-3097-a994-1174-d3cf1608c41e", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "c8006108-d31d-3fc3-8118-4a00aa1228c8", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "c83566fe-4da0-b680-43f1-aaa1880db549", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "c888fa0e-3ba4-8446-ca99-35f2dd69819a", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "c8e06257-6008-61b4-4b53-278d79854078", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "c93aedf9-5f94-9dc3-c599-63c7235e54e4", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "c9db2283-f63a-871f-3474-0b3644830bf8", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "ca31003d-2c4d-41c8-9b9b-4c61347b3f44", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "cbff8567-0725-b204-ba70-6b3ea17679a2", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "cc89b80d-6432-18eb-4c1f-89d48642289d", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "cce2ada9-2f2d-ce10-1509-2e3988f0040e", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "cd47af08-b065-d7f9-957b-4331cf499a84", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "cd4a2b32-4de8-cae4-d813-3a9c528bce84", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "cfb44862-44a4-9cc9-5636-6fc938d47be3", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "d0425968-0a5c-0a9f-3897-b55f4e22a274", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "d051e973-698c-58dd-bda6-63d696077ad3", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "d07bb88c-bdf7-0c6b-a371-44ce794f7d3e", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "d2e5a5cc-7ca8-1bdd-b989-bd9c35ca0e88", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "d39c0714-beb7-9fc0-1fba-437d66426189", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "d4f123f5-ec66-2062-e7da-d35c3ee57eee", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "d6004a9b-1c74-80de-a857-6060eaf7261d", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "d6592817-12c5-1929-7656-0bc610ac5bb8", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "d7752dd6-7176-d04e-be06-8422283faab2", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "d7fdd83a-70db-66ab-6375-91cd319db355", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "d810fb97-00e7-f2a0-0985-acffaf11b187", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "d83d4cf6-076e-8942-5a26-f3fb3c195bbf", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "d887248e-7c1b-b541-76ce-6a1429625aa7", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "d9396d48-fd20-a52d-70b5-3f2085f7cfec", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "da917375-989e-aa66-3705-7fb13adc13b7", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "db8cd639-647a-8b58-26e1-09ded6668cba", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "ddc05051-6ba0-9876-0a13-ebc3052d2b4e", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "de4618b3-b26c-8e28-0a99-ae5525670cd5", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "df6e2e51-1635-c552-c2e4-47c20b623af6", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "df7466ab-6cd7-323b-3000-734d0a87e629", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "dfa77c24-d946-d3aa-8143-2d2980309d6b", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "e02b7f77-b4c9-bc10-276e-685319e06cae", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "e0423095-2fec-629c-28ab-8d15fc453cf0", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "e04a9235-6450-7289-01d9-1e0c6d60181e", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "e0a5ac38-0109-c23b-cdf9-bfcc771a6956", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "e1cc35de-1693-fdc6-8795-0119f8f61623", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "e291f668-1c34-8928-0af9-193ae7989012", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "e29f5f7f-1c7a-cc69-3cb1-b84d99512a10", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "e3444b28-a5e6-7291-e9e2-d64fc228bdec", "f8360932-cad7-22ba-add7-d31883af9229" },
                    { "e44ff3f4-6ff9-8af0-f12a-63b3268c710c", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "e4b69797-276b-44dc-f691-2839ccadbc59", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "e549f908-0b9f-bc96-93e7-a3debcc701cd", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "e5534c19-113d-4705-a9f8-5a5534f534bf", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "e792e81e-cd41-7b11-d310-735b5b93ea00", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "e7ac8242-2bdf-3ea8-34ed-376cd6d4cc6d", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "e8e08ba6-7aaa-47b0-1ba8-5672399ddd9c", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "e91072de-8876-66b5-cceb-4cfa6eb00b82", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "e915fc4f-2425-c1b9-7448-6f93374f4d93", "d6b75c65-0e4e-21d2-1215-b541eb0ebef5" },
                    { "e992a0f0-7cfc-f1ea-667c-c308c7560737", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "e9db33d6-c21d-844e-fbab-1988c3f1c501", "1dbea3b9-23c2-3605-d494-ca1c7124c184" },
                    { "ea01f8ea-b73e-be93-9a72-7db9fa21dd8c", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "eb190148-b365-1499-4bcf-34a8307d3ae5", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "ec46c0fe-0b44-80a4-27fb-211fc8190195", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "ec4fae02-dbe6-d8aa-4d3d-da1c38fb7f7c", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "ec725cd5-16d9-76f8-27ad-d5aa62b86c1b", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "eccdc834-73c7-adb9-9ff5-6255b7257146", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "ed3daf70-fcb0-7b32-f292-becdb3eb3eb3", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "ed67f473-5441-c705-b174-e26119a10316", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "edfda5e7-5084-880a-022d-29069aa5cbfa", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "eef85155-102e-817b-0de0-1e2e035404d7", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "efa6a2ea-b018-6b26-35e2-0f08ee59c252", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "f129bad2-788c-bc9e-89cf-60039b8e604a", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "f14fc5c6-c061-1111-1e79-f268130aaa74", "26d3840f-0826-0efe-7045-e23034efc8cd" },
                    { "f16f91c3-4de3-d09f-4071-921f313f15a8", "bde95391-58fe-5b55-3f3a-b92d9fdcc75d" },
                    { "f1707df7-3aa5-d08c-ea15-5bd6269c6cd3", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "f24c8abc-3f83-5162-2e6c-56859c5c056b", "fc422d79-4d66-9bc0-c3be-19d5b2cba234" },
                    { "f2ffd04c-6cf2-db85-a42a-bdb85851cef7", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "f3b1abe6-fc82-148f-0715-4d25554e7fa3", "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31" },
                    { "f3b3e51e-629c-d167-01db-a6540d350738", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "f59455ff-4ce7-d960-dc83-0e9693fa47a6", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "f602e4c9-bc99-4d36-b8af-7f9dcb88d01c", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "f7033651-e69a-4324-fbe2-d0182b44a808", "d5ccafec-e254-50d8-39ec-9d9684f49b5e" },
                    { "f74652db-dc7b-535b-b335-595d87ad4277", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "f7502be8-0a9a-4d63-69fe-fba66d3fc191", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "f7875753-a25c-5e48-6009-e5dbdd89d86e", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "f81f9d3a-35d8-f873-8f95-45726a1387a3", "de87aa7f-ad79-cfc9-2c65-6648889c76fd" },
                    { "f8eda48e-36b2-3c80-2a8d-45ed824d3d02", "7ac11e50-5cbb-c818-9b31-5e91770eece0" },
                    { "f95addc7-9b43-8f11-22be-04c9b277bbbe", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "f9f1b201-c78a-46fd-3f7d-701f0cb9d80b", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "fa8863c0-67b0-85c7-5ff5-bf270e35170e", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "fa95ca2d-6015-d738-9bbe-e8cba5195c60", "59bf4bd2-f6ce-9fa2-7070-b362983f9148" },
                    { "faa58a8c-d950-2e5f-5a1e-2fb3331958ca", "ff7eb421-56b5-3bbe-779c-355ceed7246b" },
                    { "fb2537bc-4439-2071-55a0-b6407e36e5e0", "14185a87-c07d-c0db-e37b-536e871528f2" },
                    { "fc38688b-a5a5-0a3e-f73f-a130d3c1ade0", "041d01e0-b34f-4331-85d9-9453132f67b6" },
                    { "fcbbff35-ac21-d887-426b-fc0c5af9fa0d", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "fcbeb7c4-fd9c-40cc-b15e-4ddf4d47233b", "455c6918-8f55-8171-e3b6-573e17977cfc" },
                    { "fd1bee15-e7b2-9c75-8f36-bf9c4510c9c5", "63d58b13-c957-6ee8-4ed6-303e20d09973" },
                    { "fea0de9b-2eaa-f28c-2118-dc74ea12b4b5", "14185a87-c07d-c0db-e37b-536e871528f2" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "03428ee8-3d9a-de72-c98b-dbc65724b005",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 46, 99, DateTimeKind.Utc).AddTicks(6074), "$2b$12$.FeKJCZ8uBg2oqkV1MMg..fwhFsfj6IBE8AVvY.D8Hys9OFFgAhnO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "041d01e0-b34f-4331-85d9-9453132f67b6",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 28, 793, DateTimeKind.Utc).AddTicks(961), "$2b$12$rLMPBoyMIMBUwEcRwgVbg.kxbxnE.PwoiUFahVZni3tfSli5Td7Ri" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 33, 159, DateTimeKind.Utc).AddTicks(5744), "$2b$12$xYa2M6rzzDsfBlaOfvuL1ekZgGyqjDKD9HSkKz8yHjynis4.tWbnW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "0b2b1684-7b29-7ac4-d601-be906e631ebb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 24, 240, DateTimeKind.Utc).AddTicks(2250), "$2b$12$ClYvKYPTDiCKhDXconz6weNFbHbonUGxnrHlbO9GWAgMiw4JGVRi6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 36, 221, DateTimeKind.Utc).AddTicks(3794), "$2b$12$u3kbKVGazoy56AL/gaiIWOVb5Vc1jZy8eM8J/796YFAKjZQwdd/kW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 39, 611, DateTimeKind.Utc).AddTicks(758), "$2b$12$y6Ls79ZLfXRkNBEEJumTgO798ZrG7nMX/vzia9SiH5.wizHiV1R6a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 25, 822, DateTimeKind.Utc).AddTicks(7290), "$2b$12$ra.Lj5MQGUssxgP0ouLRgOvzvAZ/ozTb.D46EY8mj3TrKch2toyF." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15918ed1-cfaf-95a1-a2f9-24bfb81eacfb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 43, 961, DateTimeKind.Utc).AddTicks(7829), "$2b$12$3iW39h.UunJzkh1tWjQ9eeMgTnujYdmC25MZz7eoqaKR2EJ0SLGnW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 31, 892, DateTimeKind.Utc).AddTicks(8252), "$2b$12$hTWWWTpwvfjUz.DPx7uX9OdYzH8kO4h6kk/nquxgCpwGXTRqYRmie" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "18241d26-a012-b189-957c-b5573ecb15d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 48, 230, DateTimeKind.Utc).AddTicks(4887), "$2b$12$24Tkdwy.0GvWNVIN9JeQ0ulx99dt7nBZrluV3WGvEgLonI/yXwTt6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "1dbea3b9-23c2-3605-d494-ca1c7124c184",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 26, 784, DateTimeKind.Utc).AddTicks(498), "$2b$12$t3Tr5gdVrWK9AugHMo9q2.STFXn8kqUa8hj50JwqtaNoPKa/e7yxO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "26d3840f-0826-0efe-7045-e23034efc8cd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 27, 400, DateTimeKind.Utc).AddTicks(7017), "$2b$12$uDkUVaoK54evOYie6DU6s.jAahX7inT5.R7iHmY4K68vSJxmUc/J." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 38, 700, DateTimeKind.Utc).AddTicks(9928), "$2b$12$TVLEb53GMVBaCisu3ynkrOQUtxEHuLjrVSD3et9t5BZuSDsmK1Yqa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3830d83f-4097-76e0-a9e0-b90ef45d1c79",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 48, 831, DateTimeKind.Utc).AddTicks(9377), "$2b$12$DVhGUIZHopFjIlXDtUrMSu2t2qmpggrlnfmgONdjNa0KFh3f7bvfq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 23, 318, DateTimeKind.Utc).AddTicks(3610), "$2b$12$NBqs6VOax/CqIW.S/Mn.teL2ARkQpN19PK7RCv56TkSzmYs1QJ08e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 31, 583, DateTimeKind.Utc).AddTicks(7106), "$2b$12$T8UWnX2SEIL5kYj0Hkp7QOLYNFTEJfdBJCUQXBxWN4YQojWSRtnx6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 24, 882, DateTimeKind.Utc).AddTicks(5854), "$2b$12$rrI51.BRQKLPNwTE2zbbZ.HRIlBqtw4ibqvwctecWHc7Q34V2D8Ka" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4ab584a9-078d-55db-c5b4-e647a99a1187",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 24, 573, DateTimeKind.Utc).AddTicks(9292), "$2b$12$xng/gzxg.bkwr0n2cv2jU.3LGhTa.jjlKp4zaSyAoKvIN7aG8KtEe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "4d41b3e5-536d-0aa0-a3e3-024218ac6267",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 43, 37, DateTimeKind.Utc).AddTicks(1297), "$2b$12$NI.MN2u4qAfKSqtYxjsTYusDLIfL/l.XBPfmhAWWURXh97lQaTjlO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "51432fb0-cda4-87aa-a2d2-e36c25823a2b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 44, 266, DateTimeKind.Utc).AddTicks(7993), "$2b$12$OQvffhX8ou/uBTi14Z.qHuPC.hxFu6tGkmE/eliIHkzI6.iw6R52W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "52fb0554-7e57-01bb-5949-987520c91eb5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 42, 115, DateTimeKind.Utc).AddTicks(9769), "$2b$12$c5zKslRBogpI1W2N0x3qQeXARpXNUeMFSay5TirkidaPMw2ZCKjsG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "557dd714-15d7-6df3-3ed1-22a2eec63c59",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 40, 837, DateTimeKind.Utc).AddTicks(5059), "$2b$12$V6ikkDGd5McWbMeIm0OZ6eU1sbqF9VW96dkrySJMeTnR8MCEL98AW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "57f13355-ddb7-5d3c-b09a-ff2c56e22753",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 39, 913, DateTimeKind.Utc).AddTicks(981), "$2b$12$k0meWno5LYGl/4sfpENTDucWYt8P/nHMDaJm2YevARN72q0zJgVY6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "59bf4bd2-f6ce-9fa2-7070-b362983f9148",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 28, 101, DateTimeKind.Utc).AddTicks(2801), "$2b$12$4JfB2bMfEqwiVge0uZXZkudKx/jW.KCk7nL56OBGyTKSkm51svWX." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 25, 203, DateTimeKind.Utc).AddTicks(6333), "$2b$12$.V210eQ0ncfjDnBpf5a8xuDy1XF7cFACDaTLSX4hXnuW4BquiUBN6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "606137a2-9de4-e505-00ba-117bc0f24b82",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 29, 715, DateTimeKind.Utc).AddTicks(4291), "$2b$12$7QbDJ90dKqtTJRDPfaLPXeDxbOorIZFfHdjK/yMsDfJQfPOcmgNYm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "617cb820-a96f-5ce4-513e-f9de2ec06556",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 43, 657, DateTimeKind.Utc).AddTicks(6197), "$2b$12$qD.Jcduka3xtiz6sY4tlgeOBQV2ChU9yduPtv6O0236Mlgs0t3H8q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 26, 476, DateTimeKind.Utc).AddTicks(5158), "$2b$12$9AG.kzPPJXr51fbC45NCB.OqgSB7Tkg8P3tNZkr7hrtvBtEYSBTwO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "68fbd87f-0c94-976f-40de-323667ff06bf",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 46, 399, DateTimeKind.Utc).AddTicks(2790), "$2b$12$0dFT4HifR6HWdBKmiIgd8OumRI8p5oQBcSiH7ZY09llOUtghIKveu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 32, 854, DateTimeKind.Utc).AddTicks(4577), "$2b$12$XoH0pg8yZDO8SRvOX.9uGOKvrv121UKIOFSlVnDT0Lijt32eIFiNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 37, 437, DateTimeKind.Utc).AddTicks(7257), "$2b$12$/rBkqHlAZtSurKdsuDZx7.oknZYlno7HYFpTm4UIJwHvE3ygvN02m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "70d4b385-0cd3-abfa-86b0-75c1ef2a9c1e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 41, 463, DateTimeKind.Utc).AddTicks(1549), "$2b$12$GERI6ZN24OMoSXfm8Hk.xOtDsg7Gd5.oDZSOjT75WnUbdOFOrPplG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 39, 307, DateTimeKind.Utc).AddTicks(4215), "$2b$12$CyjQQIf844WXvONg7pWfI.788RbdGxTlv07Di6MZEsTMhxXon7NZC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "7ac11e50-5cbb-c818-9b31-5e91770eece0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 30, 22, DateTimeKind.Utc).AddTicks(219), "$2b$12$Yhge3i5jeerEciau6mlw7us5ZPA2EXaS/v0FdnrgaCsuyrCp/R72m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8112e653-13fd-c47d-0fc5-7b36eda72bf0",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 47, 301, DateTimeKind.Utc).AddTicks(7274), "$2b$12$wVodwh6J3zQQiCSck9xT/.EPr9C4K1QoQxaGfm2DnsnkDdn6xM6Xq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8bb5c451-bf2f-2f66-1ce3-d3b8fd0503e5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 45, 795, DateTimeKind.Utc).AddTicks(9448), "$2b$12$u6LLEzRwQCeWiqF5JgUZIOqYL3FOh/58Kd4oU7OCcLwp.Z8OJVRpa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 38, 396, DateTimeKind.Utc).AddTicks(9469), "$2b$12$P5rhj3kSdFRtWWihWJ6ox.AkmbMlUN.Qx1ze/vu/k/5oDhjmQwpTu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 34, 999, DateTimeKind.Utc).AddTicks(9172), "$2b$12$1keEQKZTlg3Z72N8RGAwJOFUDh0WMRXcYyKcy5p4qcGtiYBz9W6dm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8e85356b-dff7-0fe0-9e0a-ac24101ff81c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 42, 423, DateTimeKind.Utc).AddTicks(2171), "$2b$12$HIxMGzhHNxC2y.cQhMWPHedPqGjOUg6WTYSIVVbrICuImcAM40TEe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8ee02cf3-bf69-3090-c8a3-acd718cd445f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 41, 164, DateTimeKind.Utc).AddTicks(330), "$2b$12$i93LXfq8ZcsPdeQjnjQZ.OsNglfgnKn/jnp6iDIICSj1nDLG8fMpy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "91f97c43-df32-927a-bb77-3f050c28c5d1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 42, 730, DateTimeKind.Utc).AddTicks(4912), "$2b$12$UqeetItsSsmZ6E0uxV5Jme8p3Oi6YEelqLNC95vpnbUKC1FHh6Uv." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "954d4710-fb9b-9bc8-33d6-1a00378fef99",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 48, 536, DateTimeKind.Utc).AddTicks(3569), "$2b$12$yvu4htB2aGjy1ThniToBguXk29pju/E7JrF8Y3dqeSPI/tKBEEOVi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "95755e71-293b-5fbe-2e06-ff9c6d90e96f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 44, 876, DateTimeKind.Utc).AddTicks(7734), "$2b$12$vXFBEaOcKvb2TcIWZBOnaeqltd2I5VVAd.N/fj3edWTonKznlkZp2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "96cb69c8-c721-11de-8075-582c3bb936c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 47, 597, DateTimeKind.Utc).AddTicks(606), "$2b$12$Qx9sSRI53gY1As576MrPRueBHUv3zFIzrJhsat5sVrwihr1cxlHKK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 35, 609, DateTimeKind.Utc).AddTicks(7886), "$2b$12$YJJ0RZbMGzxPU2KDuKwVguhYj6lckrl1PA8iQ2dqa96agHO31O2AO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 35, 304, DateTimeKind.Utc).AddTicks(9872), "$2b$12$PzmnFVW.kkYBphp.bunmVOOveGCgg00lyk/cE1XRudQYV3/hbXVta" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 34, 74, DateTimeKind.Utc).AddTicks(8704), "$2b$12$4Rrtva84ddZ4eqpZ2TrchOgvLWyVZxpF9fpGYq0lQ91z90Ihu4fbG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 37, 740, DateTimeKind.Utc).AddTicks(3211), "$2b$12$Ii2MjLnmiDRR616hl9qYA.p22kTz9NLTMStMmaYRUeqFirTwlxy56" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a3c3207a-f43c-47cf-bf43-b5aa0d1ca402",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 45, 180, DateTimeKind.Utc).AddTicks(9266), "$2b$12$B8FwMgfixxgqa9i/ywuqt.4Ij6dRoRRAxAnLcaDVtmi2oHqlJNImG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 34, 383, DateTimeKind.Utc).AddTicks(7742), "$2b$12$G7CibiJ9IrRdOBGl6OyX2uiXqmc7LIsvzbxNA.rKLkKegcK6eCUY6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 36, 528, DateTimeKind.Utc).AddTicks(8374), "$2b$12$Ck8nShqm0Iph8IgLb9VV/eTl9iTJS48A3Pl6Tn8r061TeyqT1bfhO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "aeba3eba-9c59-d115-5781-476232f36f4c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 45, 485, DateTimeKind.Utc).AddTicks(1826), "$2b$12$7bhl4d2RrCjxcaEdsjv7eensrXctL3FS4yM5pj365N0s.Cpk1yCeK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "af142cbb-a95e-ab3e-f00a-a39f87004ec3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 40, 220, DateTimeKind.Utc).AddTicks(1456), "$2b$12$wauCKZRmVP1lmvHTob.M1Ot2VmiFUUznLqemK.WMl2lx481OUUlqe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 38, 60, DateTimeKind.Utc).AddTicks(4187), "$2b$12$NE8xJTcqwBADELFzQZIHYuZ008O5EiSnOUvzLd9rFTYQAGaqmwoC." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 32, 547, DateTimeKind.Utc).AddTicks(5448), "$2b$12$UqnPvzs1SvNZG1.nyEqhgum3jE1cSN7idEwEen2blIgP4smULGMJS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b23b2edd-8498-994b-f92d-1033b02c5cee",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 23, 626, DateTimeKind.Utc).AddTicks(4807), "$2b$12$D48dkdpWG.ubll7asU2h4uTJsbXrfxUIJ0jrdSGJFEGGm4UkWVm.2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 30, 331, DateTimeKind.Utc).AddTicks(1158), "$2b$12$D3jOeeFIG9YugRJQ.5HIEum2CBN5iV0VzyjRI8nSSA5dv.z4BVyny" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b5f9f83d-f5bb-7af0-2344-5ff6a7fba816",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 47, 6, DateTimeKind.Utc).AddTicks(7447), "$2b$12$1ofRvhdbYHU/WifOUfYPB.FOEltqsKqHf25G4tL.7aVy8n6e6eYGe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bde95391-58fe-5b55-3f3a-b92d9fdcc75d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 27, 92, DateTimeKind.Utc).AddTicks(1890), "$2b$12$MvLSLnPWksXt51hFedeJ/OVYZOZgDiZCQWx6Rif0g9rDvnxVJlnU6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 32, 204, DateTimeKind.Utc).AddTicks(7924), "$2b$12$RBfVMkwjsKsHRYuB1tIVGetzFkA8Wl2.jv4sGZGkfVw6bKyKQZvkq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c1fcc118-bca7-c1b7-02d1-7557b18c7ad5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 43, 351, DateTimeKind.Utc).AddTicks(3543), "$2b$12$Gw92jJaB83Ofmw43AeXBLuNqjL.Q81c7101LNljXeGJeGRpfcC5dO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c2dd0d11-f58f-2546-c1ca-10b453a7bc96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 47, 907, DateTimeKind.Utc).AddTicks(4682), "$2b$12$H.w.GMYgg7IKGN77bMf2J.5MbE.FRCtP/sExbhfFSA6qMSSi0lhw6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c668490c-dda2-f1b1-d170-72005fc34624",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 44, 572, DateTimeKind.Utc).AddTicks(9853), "$2b$12$VooA6uFjA4jCg9jFpRiI.ud0M/mrm.sMlWoXJwW46xZq8.f8qnwW6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 31, 277, DateTimeKind.Utc).AddTicks(94), "$2b$12$i0UeGMUyMSvPxzZSwfPWXuN5Lt03xtsl/wu7JfbEAaQaaRTTKPjnW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c8936e2c-61ab-766a-1161-ed4577bda964",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 46, 706, DateTimeKind.Utc).AddTicks(4753), "$2b$12$GNbaMQTsd188ciqxAfh3Bu5tL5D4KsZJ3z8F6krh3eOZMo2DWg9Zi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 39, 3, DateTimeKind.Utc).AddTicks(2954), "$2b$12$5jE3EqhSzb7SxSv9EV1CVOZP0HRUpPVkey3.922fYHIJDMW5N76lK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ccd1db56-b977-3035-ca07-0d16377dbbe1",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 41, 771, DateTimeKind.Utc).AddTicks(440), "$2b$12$aPYmyfUsX50jwG7HaNeXAOIUXf/bmU8WH1xprAzuPToO4TaDFFkb2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d5ccafec-e254-50d8-39ec-9d9684f49b5e",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 27, 713, DateTimeKind.Utc).AddTicks(8047), "$2b$12$3KgNmp2u6rUjju3jCFaTnegAYK3B.dOqkXWGFcFaXT9W02kb23ffa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 26, 145, DateTimeKind.Utc).AddTicks(316), "$2b$12$qrewZ3VqWgR3QiSevu1Y0u3V3sWJOkzvYSywiGEpR3JFeasPw/N7e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8924a08-9bc1-e88e-8396-1a1e86e2276b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 40, 523, DateTimeKind.Utc).AddTicks(8290), "$2b$12$BLiEk40kelM7XbhSW9mTcuzDMLnZRl9bsLvHS/QeBb0HKUrKyidrm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 33, 464, DateTimeKind.Utc).AddTicks(2188), "$2b$12$Ir4hzdOv0w2.DK1k7CB1j.WyiEQD4Bt4u05NQF8rJLwstvCWwloW." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dbb59997-e2c2-22b4-f6bb-6f45eb8d46c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 23, 933, DateTimeKind.Utc).AddTicks(5061), "$2b$12$CZbcZXKF9BgUcfGadg8nKefJsdYjW3LL2vyeior/dtKZ2DcXA6Sf6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 34, 691, DateTimeKind.Utc).AddTicks(4041), "$2b$12$hb6zTCkbC.gvOh3u6ZKrROcFTCXEJaX1mC.trrusrZ8dTx0eps48a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "de87aa7f-ad79-cfc9-2c65-6648889c76fd",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 28, 473, DateTimeKind.Utc).AddTicks(6143), "$2b$12$lvBD.34fSy.wq8yZD/iYoOcOAGF/bBrpiXkU2R.YSEM3cxWkjip12" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 36, 834, DateTimeKind.Utc).AddTicks(4559), "$2b$12$/diJpprSthJqTh5Nz85kr.A5QqXl5MH5Cj3.kvggb2xzW8BA7biS2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 37, 135, DateTimeKind.Utc).AddTicks(4053), "$2b$12$tZ6DpFAzLKqqSpqsGkp/UekYEdCyM6lRcK.rxEYbXsIXVqXz9mnS6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 35, 914, DateTimeKind.Utc).AddTicks(5007), "$2b$12$eVOF9.HHCKGKxZfGNq17hO0gPZZXpaRq3JkFgEAOOx7OQoh5LTWJO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 33, 770, DateTimeKind.Utc).AddTicks(3049), "$2b$12$gJA.fdL0Cz82se6nkjzCdOWBHaAx0LsDL8Y8io9U77zEoqhOibF7." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 30, 968, DateTimeKind.Utc).AddTicks(4605), "$2b$12$aQ9x0TwvLMtY0OzdImcLr.5oqzj62P/ieVZLUGNV0Mc3ZyY5B8dOu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "f8360932-cad7-22ba-add7-d31883af9229",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 29, 408, DateTimeKind.Utc).AddTicks(7913), "$2b$12$1NweFb2jaQnccDJ.vQAlEekxE7Byj/kbRbMX9KmNvRggvqAhhkEgm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fc422d79-4d66-9bc0-c3be-19d5b2cba234",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 29, 98, DateTimeKind.Utc).AddTicks(8396), "$2b$12$rh8F053p3Rl.TcIT2xicz.4/LBXkM0vrTpBHlavX8aieJasgWLOcS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 30, 639, DateTimeKind.Utc).AddTicks(8524), "$2b$12$yF/3zPxYz2Fynn4ydNQXiOdX7n9ULCr66bKEWLC5YedMEgufnhJyq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 6, 10, 0, 25, 515, DateTimeKind.Utc).AddTicks(2888), "$2b$12$wesC1/qJtWvhZb32WSB2oeC29ViyDJkZMgVqjfSPER8k8zABdIlru" });

            migrationBuilder.InsertData(
                table: "Attend",
                columns: new[] { "group_id", "session_id" },
                values: new object[,]
                {
                    { "57bf1149-8880-c27c-d603-3546214d03a8", "8d1a51f4-7532-f767-7fb9-bb9829556752" },
                    { "64b93cdc-56f3-906f-6e4c-2adfe2184501", "1340bb3f-f749-7b9c-e64c-32cc1e407f57" }
                });

            migrationBuilder.InsertData(
                table: "Teach",
                columns: new[] { "session_id", "teacher_id" },
                values: new object[,]
                {
                    { "1340bb3f-f749-7b9c-e64c-32cc1e407f57", "606137a2-9de4-e505-00ba-117bc0f24b82" },
                    { "8d1a51f4-7532-f767-7fb9-bb9829556752", "455c6918-8f55-8171-e3b6-573e17977cfc" }
                });
        }
    }
}
