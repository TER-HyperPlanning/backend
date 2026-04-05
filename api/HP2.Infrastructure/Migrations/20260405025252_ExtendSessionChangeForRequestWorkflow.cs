using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExtendSessionChangeForRequestWorkflow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "approved_room_id",
                table: "SessionChange",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "change_type",
                table: "SessionChange",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "counter_proposal_date",
                table: "SessionChange",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "counter_proposal_end_time",
                table: "SessionChange",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "counter_proposal_room_id",
                table: "SessionChange",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "counter_proposal_start_time",
                table: "SessionChange",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "proposed_date",
                table: "SessionChange",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "proposed_end_time",
                table: "SessionChange",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "proposed_room_id",
                table: "SessionChange",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "proposed_start_time",
                table: "SessionChange",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rejection_reason",
                table: "SessionChange",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 44, 288, DateTimeKind.Utc).AddTicks(3297), "$2b$12$idG1TxkjXP76DHpBlh9JCecQATJXVLClxF89DABZou7UVLLlw0k3m" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 47, 54, DateTimeKind.Utc).AddTicks(8489), "$2b$12$2ZEILC2bk/gum1LTS/Cb.uTncZkkIeHV7NZGV85cl4FSGfPCOBpGK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 52, 84, DateTimeKind.Utc).AddTicks(2098), "$2b$12$QPYIPVtRp6V6fQ3F4jLvQep0xYLLpstniUHIevJgyqTHzmt/zJ1GW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 41, 70, DateTimeKind.Utc).AddTicks(1219), "$2b$12$P5.f6IyQcL8j9.apYpwvaOc/COYbkClb5sqFoXIPkKtt9Wmhmszy2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 43, 175, DateTimeKind.Utc).AddTicks(3368), "$2b$12$qI.DKuCrjXxofjWZjwS7Fuk1unBO4jvxdwMoPXzZmelpKbwu6nc92" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 50, 615, DateTimeKind.Utc).AddTicks(1275), "$2b$12$BHn0U2VHFrGqG/tb9/gW.egowCevgC1yYQ7ejV4UlTE.DxAZfRu3K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 39, 897, DateTimeKind.Utc).AddTicks(9000), "$2b$12$cH5SWG/ey7HSpoQ0w2C1d.S2agx9dE1C4hyfaLU/HFvqR8VVWDhsi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 42, 910, DateTimeKind.Utc).AddTicks(9615), "$2b$12$EvuC4YGeNnsEvgU5sU/E6ex10XOuUXqfxh.zXrbRmUTfyDPDnQLSa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 40, 220, DateTimeKind.Utc).AddTicks(256), "$2b$12$Ig1r3OVT2/t1rTKLuzMov.KC5JzqZYhvqLG67Zxc5Dnlf/.Q4Ijo2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 40, 524, DateTimeKind.Utc).AddTicks(7531), "$2b$12$HimkYJSJS1FJYlIayseCG.VrXkPU/Fqet1MGdBprL2s65AfHv9O8W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 41, 598, DateTimeKind.Utc).AddTicks(3519), "$2b$12$Q45Js4QJmWFE9m1Omiao5eI90F4pzFIHuKZossp7NslnKS7iiER3u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 43, 970, DateTimeKind.Utc).AddTicks(2268), "$2b$12$scNsSs3VQoaeaNKRRQFQs.yQVz.sHlfi7B6ELEfm8VmSO628L.A0W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 48, 627, DateTimeKind.Utc).AddTicks(5016), "$2b$12$PsIYHgP3XdF7US3LbkboNOM8CJSCZPcl9oe9Pj9yVH/tNXr6tEqiy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 51, 575, DateTimeKind.Utc).AddTicks(9952), "$2b$12$HXmZ3ktXIEtj.Qzclygw5eeFQ/20UnA5qO5Mepibv.61ctLTuxLny" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 50, 56, DateTimeKind.Utc).AddTicks(3859), "$2b$12$eW4KYO5fuuR6y5umgys8K.R6RboZSGdaQKL6OLmK/KGQ51cc0ZX1K" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 45, 891, DateTimeKind.Utc).AddTicks(8773), "$2b$12$irvEUtSJcnXjcu9v3ULqKOqJQ5ayjXRNVlhEjfuNNHT9DdH7CgHxC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 46, 486, DateTimeKind.Utc).AddTicks(5014), "$2b$12$dsjl4hrOUHtbCwaOISdAHeC06OC1KZfjX9uPnejoo/Npn7qqS6.jm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 46, 194, DateTimeKind.Utc).AddTicks(7373), "$2b$12$GBFQ3GoLKuhzr2uocTw/GO7CeyXrsbDSofGxASqrUfvRrfoLr1lGK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 45, 97, DateTimeKind.Utc).AddTicks(4333), "$2b$12$x5uNZdagOUXfaPU1Bb268Ok8PDRDc5jWO0Hhselom09VAih5nlHfy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 49, 105, DateTimeKind.Utc).AddTicks(1841), "$2b$12$6HHlJfUYMwYhzhu3UGSmi.68q4g/dGrVxx5pM8t9cptdAJ3p6Cy3C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 45, 362, DateTimeKind.Utc).AddTicks(3945), "$2b$12$5l1ELSMyAdngRWvOca4iTeci5mQZnq7/coEi28wuEtWG2M1Wm.ohK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 47, 326, DateTimeKind.Utc).AddTicks(690), "$2b$12$2e0.J3lyATCFLM6ZI15W4.K9XOu1CRSFuiToaVFwYIEoEr0i73daK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 49, 561, DateTimeKind.Utc).AddTicks(9573), "$2b$12$jcDta3w3QiroiTyDpTkF4OH6XRGWhN53BOpzK6B0TO17xrugfpLU." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 43, 698, DateTimeKind.Utc).AddTicks(2734), "$2b$12$Hdr/dNMT.692UlxZrQVVkOdduuOVciHEhMWr2b6kSNM7F.XGcdNsq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 41, 873, DateTimeKind.Utc).AddTicks(75), "$2b$12$NT7qMWiKB94/IFZAmkVe1eMFzHYpzmHAHd/7aKdKu3172EcXMNoyK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 43, 440, DateTimeKind.Utc).AddTicks(4843), "$2b$12$E.2y0.c5gVq9hFNDZdhP4OP4aIQMSo8myHRRfULwRdQtfuBF39rqu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 42, 655, DateTimeKind.Utc).AddTicks(7238), "$2b$12$znQd9Tk1vitJIDZhOIOL2uDpoDRikYVVx65.E9ePiBVKiRUwQ68Xq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 51, 69, DateTimeKind.Utc).AddTicks(5413), "$2b$12$nydJRwa8seuMRfGbf7lXoOYSwULdnMuxUF6/aatCBXJHd4GkC.VeK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 41, 339, DateTimeKind.Utc).AddTicks(1063), "$2b$12$4UF0z2njkAqKQ6g45hMdMuyJqmeKDfX4f.5cnBwXRC1FsJcg7j8ze" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 44, 567, DateTimeKind.Utc).AddTicks(1301), "$2b$12$m9vP5.Sura7U/cmlTikfVOf.cn4YupTpRlW7c57pxMq5f7rc3IyVe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 45, 624, DateTimeKind.Utc).AddTicks(9603), "$2b$12$.FE.utFI4bqmEndeA.gg5e/wW5M.DZSTeWxmMIFAF1bqj5SYcvk/u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 47, 659, DateTimeKind.Utc).AddTicks(4271), "$2b$12$7ApGvzjR2QbS7zHu6libG.Yq8um4/VZ96WG2cbJlD2Ryz6hJ18KIK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 48, 154, DateTimeKind.Utc).AddTicks(5952), "$2b$12$g1912Z.W8ipjcIx1oQ3up.3BBQSv1ETquZB0lZt5F0w/RAmVm2oWq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 46, 770, DateTimeKind.Utc).AddTicks(6272), "$2b$12$ScNBd3XjyOUWOjFOV.rYPurOP2i.oUFe0TA1yO66rlwGaQPokri2." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 44, 837, DateTimeKind.Utc).AddTicks(4048), "$2b$12$10mcon2LACkHPqhgZT4mVOyJFfljI4Rp1ULJAYrFZg.T16vfKLnT6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 42, 402, DateTimeKind.Utc).AddTicks(6538), "$2b$12$o0LJht5fpWy.XMQppJNK8enZAPx9z2fSUQPHJNDdW9/4MZdchCKP2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 42, 144, DateTimeKind.Utc).AddTicks(566), "$2b$12$bW/8iKBLKtGizevtk1UaaO.sSWZmoUUHL3MAWzdnK.T.22r3lNwIy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 5, 2, 52, 40, 793, DateTimeKind.Utc).AddTicks(4075), "$2b$12$JEX.bDIo5CVhexi2jAEc1usz4UA.eZ2OwXMwcjXuEKy876XCRRSX6" });

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_approved_room_id",
                table: "SessionChange",
                column: "approved_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_counter_proposal_room_id",
                table: "SessionChange",
                column: "counter_proposal_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_SessionChange_proposed_room_id",
                table: "SessionChange",
                column: "proposed_room_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionChange_ApprovedRoom",
                table: "SessionChange",
                column: "approved_room_id",
                principalTable: "Room",
                principalColumn: "room_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionChange_CounterProposalRoom",
                table: "SessionChange",
                column: "counter_proposal_room_id",
                principalTable: "Room",
                principalColumn: "room_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SessionChange_ProposedRoom",
                table: "SessionChange",
                column: "proposed_room_id",
                principalTable: "Room",
                principalColumn: "room_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SessionChange_ApprovedRoom",
                table: "SessionChange");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionChange_CounterProposalRoom",
                table: "SessionChange");

            migrationBuilder.DropForeignKey(
                name: "FK_SessionChange_ProposedRoom",
                table: "SessionChange");

            migrationBuilder.DropIndex(
                name: "IX_SessionChange_approved_room_id",
                table: "SessionChange");

            migrationBuilder.DropIndex(
                name: "IX_SessionChange_counter_proposal_room_id",
                table: "SessionChange");

            migrationBuilder.DropIndex(
                name: "IX_SessionChange_proposed_room_id",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "approved_room_id",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "change_type",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "counter_proposal_date",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "counter_proposal_end_time",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "counter_proposal_room_id",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "counter_proposal_start_time",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "proposed_date",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "proposed_end_time",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "proposed_room_id",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "proposed_start_time",
                table: "SessionChange");

            migrationBuilder.DropColumn(
                name: "rejection_reason",
                table: "SessionChange");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 603, DateTimeKind.Utc).AddTicks(9419), "$2b$12$w7zm9akzss3y.mZg0iylweFrCoo4IKJDuso3c/aJyghH8e79e3C2S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 581, DateTimeKind.Utc).AddTicks(8693), "$2b$12$EdUXunn4eZKoA9Sq5/pzoudKWvUCVnEmjY8OGsqiqxx891rL4DLUm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 850, DateTimeKind.Utc).AddTicks(108), "$2b$12$lcm49vlkedNNPJFmIjei5uSYQPx1HxU.kh24yi/UGEkKMmnCpL/Ru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 931, DateTimeKind.Utc).AddTicks(8571), "$2b$12$YEgoprooW2CT7IzS2uO2HOPOTS/J4qOyPqcsAUs3RhaLE5mSIe3E." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 412, DateTimeKind.Utc).AddTicks(8517), "$2b$12$sv9IFV7t95lAHk6uERAMoOULbQIlciEy5GZ3OH2UUm6Idve6JsO1O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 964, DateTimeKind.Utc).AddTicks(202), "$2b$12$cNEMuQUEP9E9s/R.xXSVe.2HO4SAa4d2XGFywxkqolfk/P0VqSk0C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 32, 637, DateTimeKind.Utc).AddTicks(9685), "$2b$12$Fax2rjUgggIKuEW3RsF6xuK/gj/yfDE9FVxGfU/4Qt4NeDaQaE/FS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 109, DateTimeKind.Utc).AddTicks(6112), "$2b$12$TYSd89QVNwNDchTpbiwA/uZisHcTrw4pOF7mfEgO6gYqoNpVlEXzS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 32, 983, DateTimeKind.Utc).AddTicks(3637), "$2b$12$/HdNOe4aldp5WmvQVPWOSub7A0/n2NAXdx4rHfAqQ2k1mIderA.L2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 312, DateTimeKind.Utc).AddTicks(9159), "$2b$12$sITpASa9/SEbkqttyTP2e.LE5ORy7IrtrsVZtC6d97N/QyjFxFvpy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 542, DateTimeKind.Utc).AddTicks(4947), "$2b$12$s5SlG1cOtHuxo9flV4RBXOBS4lM9tSOYE4tCiKgWxBaz0RovlXRfe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 307, DateTimeKind.Utc).AddTicks(5828), "$2b$12$VB6b.mm1dj95XfiVo0QPM.Zrtuy2F0UQ17rv45QBCVV2dr8xsQ4Bi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 772, DateTimeKind.Utc).AddTicks(9109), "$2b$12$rsfbaLnofQDwQzz029d4cOJ3ogiSaKSEj7B7YsMj6Hf39XC.prZim" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 554, DateTimeKind.Utc).AddTicks(1782), "$2b$12$ckDn6hItM4Pq4gpwGCWXvuzQAFmGXlKEQ06WxrlA.uqwLhjVnRuku" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 668, DateTimeKind.Utc).AddTicks(8780), "$2b$12$6cOHq51svhikpQzF9GnIg.rvzw9WlHOafbvJMlQGZYBqzlcSaZbNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 398, DateTimeKind.Utc).AddTicks(3955), "$2b$12$U4Bj759H4cZGSgnZ2USj9./aTEb14qSNM.uY9rAeUyCWQOGuFjBw." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 990, DateTimeKind.Utc).AddTicks(7686), "$2b$12$ACbu9Qwzm4aEz0OjLdB72.ZcWTtopSU8c0yMWeEovEum5FxLA3XfW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 694, DateTimeKind.Utc).AddTicks(9481), "$2b$12$mjbdpQe1vRyS.6VwsnwTjevVDN4OqP/W3XmBZlxmUj76VpmKveuai" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 502, DateTimeKind.Utc).AddTicks(9040), "$2b$12$499V5.yz.7jt2rdzxV4yNOdk83hR0CQ9n8Y0EuAkYVdxyfK8gvDqK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 76, DateTimeKind.Utc).AddTicks(9787), "$2b$12$gXputWw9fNLwBinfWIyXTeNWNllACy2lrMYU.kbGCKjd5sGl0E936" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 803, DateTimeKind.Utc).AddTicks(5327), "$2b$12$13mY0cxwJi/HnXtNqXm2JuuhVK1KK5lmCOqkwPaKZ5/T8NhptMq5G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 877, DateTimeKind.Utc).AddTicks(8479), "$2b$12$2UpEK6rTce0lzZSOvve90OEhTYvNb1qDgPGDHQEwBqtG2PlYC15HC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 374, DateTimeKind.Utc).AddTicks(736), "$2b$12$6IeaDla.AvODAWj115DzoujkJYUZrp3wVequUls3IfhdybPLQnCEm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 11, DateTimeKind.Utc).AddTicks(725), "$2b$12$yywEc2k9f4kFisgrF7M.ie5XWrc7DsfuV1umrEm0P3Wz8ZQHZbvvC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 845, DateTimeKind.Utc).AddTicks(7282), "$2b$12$ZWppWXotYdvTBIWGmqzUEOfQyL0Q9hZfA7uQ1zEG8HVNO/qaywlXW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 709, DateTimeKind.Utc).AddTicks(4919), "$2b$12$DVyYBkHa47g.Z0h/XWji2OfY2vDcHuD96fpBORTvTvEb7Qwxg/Tt." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 801, DateTimeKind.Utc).AddTicks(9140), "$2b$12$/.hbdANLA76ZpCF3IHmjuucCGT.D/JHTRZuKkgsh.e03Uz6W6e7Ym" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 259, DateTimeKind.Utc).AddTicks(7937), "$2b$12$fQnll/lghWz4ZfyeI/4...IdvQGVJXEZy5MIg.hjDnJjrSGoUMFAi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 236, DateTimeKind.Utc).AddTicks(9354), "$2b$12$TGLfWg14oTliIO4i/VabHeP4A/2U5BrRvryoUmbdhGiAOcVI3z5u2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 904, DateTimeKind.Utc).AddTicks(7054), "$2b$12$gettteKQZ9QZIeruHlJFCuvTYlIgFnS025SAFvDTb9hiuxCFPMfIa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 101, DateTimeKind.Utc).AddTicks(8076), "$2b$12$/hHJhQCVoEfA.e1/.OL25uXcYW/i7vdoP3rmOp.jBSVHOe/N4x99i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 181, DateTimeKind.Utc).AddTicks(1790), "$2b$12$S3M4GAu4XSEYxwEqdyeysedG9Hr/bWol9fv4FPlCpyUF9VHjkUFz." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 476, DateTimeKind.Utc).AddTicks(6637), "$2b$12$CW43qFBjD2g082cnHbvtQ.8Aj3Zz3UI4q77QLBP/p.wJ7msJRjloG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 286, DateTimeKind.Utc).AddTicks(4899), "$2b$12$rJoCb2uunwfxwxSj2.C/xeA4ImQSb5CO5CpPTU5Mso3AlO9scnqjC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 202, DateTimeKind.Utc).AddTicks(3310), "$2b$12$nbF7D43SCNEBhblR0D4Vlu5HekacvZ.C6iSqT5LBUgj56tljifRse" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 464, DateTimeKind.Utc).AddTicks(5706), "$2b$12$MpYfdCKqBqe9iOluchZBOu4Zgeq1CIPxxd.DgQUm2siRHO3Kc2jvy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 150, DateTimeKind.Utc).AddTicks(8304), "$2b$12$hYXYTnKSrxaEMR.0V4q4de2Bi8YuUSfAVZT7GRo3Tx5.fTUnWiD0u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 621, DateTimeKind.Utc).AddTicks(1336), "$2b$12$2d4k85iXxnmjjyH7aSUrqObuFP3jnx.jxnRMCs4519Ok1nHHxDWCG" });
        }
    }
}
