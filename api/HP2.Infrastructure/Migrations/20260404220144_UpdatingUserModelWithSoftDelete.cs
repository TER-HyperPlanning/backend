using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HP2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingUserModelWithSoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_at",
                table: "User",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 603, DateTimeKind.Utc).AddTicks(9419), null, "$2b$12$w7zm9akzss3y.mZg0iylweFrCoo4IKJDuso3c/aJyghH8e79e3C2S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 581, DateTimeKind.Utc).AddTicks(8693), null, "$2b$12$EdUXunn4eZKoA9Sq5/pzoudKWvUCVnEmjY8OGsqiqxx891rL4DLUm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 850, DateTimeKind.Utc).AddTicks(108), null, "$2b$12$lcm49vlkedNNPJFmIjei5uSYQPx1HxU.kh24yi/UGEkKMmnCpL/Ru" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 931, DateTimeKind.Utc).AddTicks(8571), null, "$2b$12$YEgoprooW2CT7IzS2uO2HOPOTS/J4qOyPqcsAUs3RhaLE5mSIe3E." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 412, DateTimeKind.Utc).AddTicks(8517), null, "$2b$12$sv9IFV7t95lAHk6uERAMoOULbQIlciEy5GZ3OH2UUm6Idve6JsO1O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 964, DateTimeKind.Utc).AddTicks(202), null, "$2b$12$cNEMuQUEP9E9s/R.xXSVe.2HO4SAa4d2XGFywxkqolfk/P0VqSk0C" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 32, 637, DateTimeKind.Utc).AddTicks(9685), null, "$2b$12$Fax2rjUgggIKuEW3RsF6xuK/gj/yfDE9FVxGfU/4Qt4NeDaQaE/FS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 109, DateTimeKind.Utc).AddTicks(6112), null, "$2b$12$TYSd89QVNwNDchTpbiwA/uZisHcTrw4pOF7mfEgO6gYqoNpVlEXzS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 32, 983, DateTimeKind.Utc).AddTicks(3637), null, "$2b$12$/HdNOe4aldp5WmvQVPWOSub7A0/n2NAXdx4rHfAqQ2k1mIderA.L2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 312, DateTimeKind.Utc).AddTicks(9159), null, "$2b$12$sITpASa9/SEbkqttyTP2e.LE5ORy7IrtrsVZtC6d97N/QyjFxFvpy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 542, DateTimeKind.Utc).AddTicks(4947), null, "$2b$12$s5SlG1cOtHuxo9flV4RBXOBS4lM9tSOYE4tCiKgWxBaz0RovlXRfe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 307, DateTimeKind.Utc).AddTicks(5828), null, "$2b$12$VB6b.mm1dj95XfiVo0QPM.Zrtuy2F0UQ17rv45QBCVV2dr8xsQ4Bi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 772, DateTimeKind.Utc).AddTicks(9109), null, "$2b$12$rsfbaLnofQDwQzz029d4cOJ3ogiSaKSEj7B7YsMj6Hf39XC.prZim" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 554, DateTimeKind.Utc).AddTicks(1782), null, "$2b$12$ckDn6hItM4Pq4gpwGCWXvuzQAFmGXlKEQ06WxrlA.uqwLhjVnRuku" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 668, DateTimeKind.Utc).AddTicks(8780), null, "$2b$12$6cOHq51svhikpQzF9GnIg.rvzw9WlHOafbvJMlQGZYBqzlcSaZbNS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 398, DateTimeKind.Utc).AddTicks(3955), null, "$2b$12$U4Bj759H4cZGSgnZ2USj9./aTEb14qSNM.uY9rAeUyCWQOGuFjBw." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 990, DateTimeKind.Utc).AddTicks(7686), null, "$2b$12$ACbu9Qwzm4aEz0OjLdB72.ZcWTtopSU8c0yMWeEovEum5FxLA3XfW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 694, DateTimeKind.Utc).AddTicks(9481), null, "$2b$12$mjbdpQe1vRyS.6VwsnwTjevVDN4OqP/W3XmBZlxmUj76VpmKveuai" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 502, DateTimeKind.Utc).AddTicks(9040), null, "$2b$12$499V5.yz.7jt2rdzxV4yNOdk83hR0CQ9n8Y0EuAkYVdxyfK8gvDqK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 76, DateTimeKind.Utc).AddTicks(9787), null, "$2b$12$gXputWw9fNLwBinfWIyXTeNWNllACy2lrMYU.kbGCKjd5sGl0E936" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 803, DateTimeKind.Utc).AddTicks(5327), null, "$2b$12$13mY0cxwJi/HnXtNqXm2JuuhVK1KK5lmCOqkwPaKZ5/T8NhptMq5G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 877, DateTimeKind.Utc).AddTicks(8479), null, "$2b$12$2UpEK6rTce0lzZSOvve90OEhTYvNb1qDgPGDHQEwBqtG2PlYC15HC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 42, 374, DateTimeKind.Utc).AddTicks(736), null, "$2b$12$6IeaDla.AvODAWj115DzoujkJYUZrp3wVequUls3IfhdybPLQnCEm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 11, DateTimeKind.Utc).AddTicks(725), null, "$2b$12$yywEc2k9f4kFisgrF7M.ie5XWrc7DsfuV1umrEm0P3Wz8ZQHZbvvC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 845, DateTimeKind.Utc).AddTicks(7282), null, "$2b$12$ZWppWXotYdvTBIWGmqzUEOfQyL0Q9hZfA7uQ1zEG8HVNO/qaywlXW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 36, 709, DateTimeKind.Utc).AddTicks(4919), null, "$2b$12$DVyYBkHa47g.Z0h/XWji2OfY2vDcHuD96fpBORTvTvEb7Qwxg/Tt." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 801, DateTimeKind.Utc).AddTicks(9140), null, "$2b$12$/.hbdANLA76ZpCF3IHmjuucCGT.D/JHTRZuKkgsh.e03Uz6W6e7Ym" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 43, 259, DateTimeKind.Utc).AddTicks(7937), null, "$2b$12$fQnll/lghWz4ZfyeI/4...IdvQGVJXEZy5MIg.hjDnJjrSGoUMFAi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 34, 236, DateTimeKind.Utc).AddTicks(9354), null, "$2b$12$TGLfWg14oTliIO4i/VabHeP4A/2U5BrRvryoUmbdhGiAOcVI3z5u2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 37, 904, DateTimeKind.Utc).AddTicks(7054), null, "$2b$12$gettteKQZ9QZIeruHlJFCuvTYlIgFnS025SAFvDTb9hiuxCFPMfIa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 39, 101, DateTimeKind.Utc).AddTicks(8076), null, "$2b$12$/hHJhQCVoEfA.e1/.OL25uXcYW/i7vdoP3rmOp.jBSVHOe/N4x99i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 181, DateTimeKind.Utc).AddTicks(1790), null, "$2b$12$S3M4GAu4XSEYxwEqdyeysedG9Hr/bWol9fv4FPlCpyUF9VHjkUFz." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 41, 476, DateTimeKind.Utc).AddTicks(6637), null, "$2b$12$CW43qFBjD2g082cnHbvtQ.8Aj3Zz3UI4q77QLBP/p.wJ7msJRjloG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 40, 286, DateTimeKind.Utc).AddTicks(4899), null, "$2b$12$rJoCb2uunwfxwxSj2.C/xeA4ImQSb5CO5CpPTU5Mso3AlO9scnqjC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 38, 202, DateTimeKind.Utc).AddTicks(3310), null, "$2b$12$nbF7D43SCNEBhblR0D4Vlu5HekacvZ.C6iSqT5LBUgj56tljifRse" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 464, DateTimeKind.Utc).AddTicks(5706), null, "$2b$12$MpYfdCKqBqe9iOluchZBOu4Zgeq1CIPxxd.DgQUm2siRHO3Kc2jvy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 35, 150, DateTimeKind.Utc).AddTicks(8304), null, "$2b$12$hYXYTnKSrxaEMR.0V4q4de2Bi8YuUSfAVZT7GRo3Tx5.fTUnWiD0u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "deleted_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 22, 1, 33, 621, DateTimeKind.Utc).AddTicks(1336), null, "$2b$12$2d4k85iXxnmjjyH7aSUrqObuFP3jnx.jxnRMCs4519Ok1nHHxDWCG" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "User");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "User");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "09095bf3-fa8c-0e49-eecb-f4bf320842ea",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 20, 74, DateTimeKind.Utc).AddTicks(8622), "$2b$12$b2rP7rDZCavlDWMWT6Jx/eUTOp6MnCgJwWXkYpTIrolWQHQ9SvC7S" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "11819a20-b220-4acf-fee3-7294e4971100",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 23, 177, DateTimeKind.Utc).AddTicks(7939), "$2b$12$1tZHQx8mYT70gtCF.ldvC.iMFnVgPm/26CAuBDE0w6bfGvzf7EifW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "13aacf42-836e-5f88-2ccd-f93c81b68f7d",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 26, 570, DateTimeKind.Utc).AddTicks(164), "$2b$12$pb1Hwln.zArxKMlh8KVcCO1dKOeWEhiUADdINt68wvgD0VrBiovcq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "14185a87-c07d-c0db-e37b-536e871528f2",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 16, 281, DateTimeKind.Utc).AddTicks(1629), "$2b$12$Fv8J3IGY5t25vDEV/c9Ceust9oLkgtW11HbgbBtg3RoPd0XCG54xe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "15f55f4b-c16e-2fc7-26dc-5d0d607d1778",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 18, 860, DateTimeKind.Utc).AddTicks(2056), "$2b$12$B0HTOzcvkgYau.dFk0IbmOG5N22FxbwBZyW.CPF1ap.QT6vR.Ybl6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "32573a03-d414-5891-15fe-b991e1f6d0a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 25, 644, DateTimeKind.Utc).AddTicks(4788), "$2b$12$H2aLNgmx61cDCbmPzKyUseZ2lq3uztFo2H9ZjyhM1G.U/EnNaNQ7i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3c22107c-0651-f328-9d16-c4eb18aed5c3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 15, 11, DateTimeKind.Utc).AddTicks(5049), "$2b$12$lXypE.8cdgwYdmyZQF5yb.7PW6Yy08NbcCLyq.6PwY2i.WYWTcnLq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "3fca4239-b5f4-f163-c65c-8d835f1a0154",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 18, 551, DateTimeKind.Utc).AddTicks(6155), "$2b$12$UmjETpRAWtQBKCz.cKvelOWdbvhQgbkmLGLtJ6sRWFis5R3RMGig2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "455c6918-8f55-8171-e3b6-573e17977cfc",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 15, 356, DateTimeKind.Utc).AddTicks(4287), "$2b$12$Dtls9yDRTmyp8fwoUuOA0.MZhvrQ75vAjloX4Fp83aSOqILtZkp4i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "5e94eeee-73d3-1bdb-0a7d-4499ede8fb31",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 15, 660, DateTimeKind.Utc).AddTicks(4746), "$2b$12$5EDSqQUuudmuMOi/PR4GKOD/SLw584ihpXatu5IDzgMSD7scdKOva" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "63d58b13-c957-6ee8-4ed6-303e20d09973",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 16, 935, DateTimeKind.Utc).AddTicks(2894), "$2b$12$N.T11tUKkA/0jG1Gm4GVjuzjFtJ8n692LuOEQS.MQTLxZheI.Yw0u" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a10f91d-0aed-5fa7-4002-3bd76f3e6d11",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 19, 771, DateTimeKind.Utc).AddTicks(896), "$2b$12$QX/c9EPkcSpc0aCMcpKvQ.wsG7V5zsdtKsIe7eO9NhSYnuEAJ1Duq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "6a5c6b51-5c13-fc1f-5a81-bd99f87a71a7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 24, 409, DateTimeKind.Utc).AddTicks(3082), "$2b$12$ftiZ9wCbSbf8hLxHDFdrce6MMDMFjLJYkcq5wYQrLI3v2mH9Y8Es." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "77eb8c7e-d27b-ca0d-7b40-66def436466b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 26, 264, DateTimeKind.Utc).AddTicks(1307), "$2b$12$JDgEAGWnixHGDdVsdR9wf.R7vcK0wExthsSVmOexjCuveKq4rinfS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8c6614ce-430a-30a5-a877-fc157f5b7ad7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 25, 338, DateTimeKind.Utc).AddTicks(234), "$2b$12$cn5M/kDjCQVsCDEJhyV6xeIkmqy4loTfpIRAmDS5fFSytLrmarOTy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "8d936d9f-0ae5-8334-3197-ce641e6873bb",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 21, 953, DateTimeKind.Utc).AddTicks(5667), "$2b$12$./9dlu3RuIDfhPK2B4MQ8.01L9Ciq5KwlypOxSqNHQE/OnqRDLnTm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "985474c8-8b56-e296-730f-d011dd6d63ad",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 22, 558, DateTimeKind.Utc).AddTicks(9420), "$2b$12$CWUzMd2yTsHNi1UGnXoOyu.Tn2DQD5/XWCMvxOZ.g1N47s9OTNNY2" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9e35ec2e-6454-dbbf-a24a-c1fbe7ba6787",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 22, 257, DateTimeKind.Utc).AddTicks(649), "$2b$12$2Wxr20aClXofBGNLUyLLt.bHZbBQslS9sPWoLo/05IKT3jBDmQ6mS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "9f33ca92-97a2-351d-cf5a-e9841c28e7f7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 21, 36, DateTimeKind.Utc).AddTicks(6241), "$2b$12$xXJFDP6O7P7VTLcn8IdFzOKUbPppAYGVSwbpdzoAaRUAF2VcsB26e" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a1e5a516-c159-675d-0f0d-96289cd47e35",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 24, 719, DateTimeKind.Utc).AddTicks(7617), "$2b$12$dUIFBBfiP4zpmP1TDW6QcOWemEhXpazh1MSqGHdbCqvDLQOFWZx52" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a4583bc8-b1cd-5994-bf7f-6ba5ed4d059f",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 21, 349, DateTimeKind.Utc).AddTicks(4583), "$2b$12$xrd8jz9IisUaoG4zan0OZenxpD6NWIWbNwz6ZYh2nHfqLYn7L73NS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "a5e38765-a824-e761-1cfd-a76a2136091c",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 23, 488, DateTimeKind.Utc).AddTicks(2506), "$2b$12$8EC0gBpVdOS9QrsGMg0vfOv8C7/79f6dcspNxsd1JLsF6Lz9QJEkK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b008fcd4-f3ad-f24d-91a7-c16be33fe62b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 25, 31, DateTimeKind.Utc).AddTicks(6615), "$2b$12$vugTR10k.g/3iUC1WkIXjOTIDUqAqEYKuHDaNWKzZAimPS9RkSH8." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b11e5b82-12d0-5a31-1105-780499cbfc20",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 19, 464, DateTimeKind.Utc).AddTicks(5760), "$2b$12$P.z2by835MFHA2TuJjwKAez56SQ1uajnStM1iCWLkxIyYQS36mSjC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "b49e8575-9a94-b93d-703c-1fc9cf200f96",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 17, 294, DateTimeKind.Utc).AddTicks(5969), "$2b$12$QbfhayHecGsIUyll32yzneR1FChF8s6Y1Pvg5JNL7K//4GVv36PYC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "bf1e4d8c-7dfa-12e7-fb4d-7fc307df9aa3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 19, 162, DateTimeKind.Utc).AddTicks(1544), "$2b$12$VxQEwzk.9SdUq.XzBiANdepASniUNSpxNkOVicZT5//WR6P9wZMa6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "c67f2f50-8142-b095-ad35-e91badccbc00",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 18, 209, DateTimeKind.Utc).AddTicks(681), "$2b$12$kYqhQT28amfQDtble0JgeO02FtYEJAqdmwCrOQrEuoOdGDIEf4Zl6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "cafb714b-44d5-a183-e909-da93f4a926c8",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 25, 949, DateTimeKind.Utc).AddTicks(7901), "$2b$12$V5afxYV.JZ5JeP7bO0VQfuDtO5dFdKz.6FJQIo9nEsEnqXLcGMnXm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d6b75c65-0e4e-21d2-1215-b541eb0ebef5",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 16, 620, DateTimeKind.Utc).AddTicks(7739), "$2b$12$vLJTy1qA.AXJg0RnMS2AZuLgKolYWROXUPtLfR8IrYxmm522rcmVu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "d8ba01ab-6a2c-951c-02c4-d6a0150808a3",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 20, 380, DateTimeKind.Utc).AddTicks(6952), "$2b$12$cUy30iEl8rJ.bAxPcnj/VuV.7lK01GfYqVN06RVoXG5Y7ufa5PtlO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "dd0b032a-0b32-dfa0-1dbe-c55b3db45489",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 21, 652, DateTimeKind.Utc).AddTicks(5711), "$2b$12$S6MVUDkPonStxDRq6LozHe1rpf2jr9n5RGOf8JfwdE4.artuHJdwq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e115db87-7553-5590-e81c-cf366ee4dc30",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 23, 794, DateTimeKind.Utc).AddTicks(4205), "$2b$12$P4ZGCa06LDuXgi3aJa2PGey/.KiTaQbL6547cTIQT.GdmxY/0qfKC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e1c033a0-e584-8bcb-b745-6a93d3fc2cf7",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 24, 99, DateTimeKind.Utc).AddTicks(459), "$2b$12$xOyXsbrk0BLb/2R9piDUZeTWh5Qg7di3n0SPsOYYmPQRnLSMpVHxm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e894b918-a541-2628-3bcd-376cf02e4986",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 22, 861, DateTimeKind.Utc).AddTicks(4236), "$2b$12$XaU890D47o7SCIKwvk55TuGxtsEfXowIKiYXcK/wl7D8OmUw4epO." });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "e9e3bb79-3eab-df5e-de27-f8914cef210a",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 20, 727, DateTimeKind.Utc).AddTicks(1850), "$2b$12$n3T/6nS854BvLlksmKKCk.n6/yfvT5rp2eCK3KrQFHvIVeX7YyFh6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ee7ac72a-3cf6-b7b0-9861-2f86c95f6f85",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 17, 905, DateTimeKind.Utc).AddTicks(4363), "$2b$12$viwmpsrFh/l9Up5WrKns5.y7q0t2J4QAREWRRCgf3g0Tqul/C7CDC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "fd2b34ab-7283-eff1-ce41-b75fe87946b9",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 17, 599, DateTimeKind.Utc).AddTicks(9805), "$2b$12$F8kqkT1ctrTrsdbz3LrXKuHbIfHVO5/5jTVI5rGRll8J0Lc8GsH0y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "user_id",
                keyValue: "ff7eb421-56b5-3bbe-779c-355ceed7246b",
                columns: new[] { "created_at", "password" },
                values: new object[] { new DateTime(2026, 4, 4, 8, 16, 15, 967, DateTimeKind.Utc).AddTicks(304), "$2b$12$NR9yeYviD5rJBDEjqn0UB.rqq0YIKcB5rDtdx.28lFMR6r27VZwfa" });
        }
    }
}
