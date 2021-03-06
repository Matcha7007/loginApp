using Microsoft.EntityFrameworkCore.Migrations;

namespace web_api.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DECLARE @UserID as INT
                --------------------------
                --Create User
                --------------------------
                IF not exists (select Id from Users where Username='Demo')
                insert into Users(Username,Password, PasswordKey, LastUpdateOn, LastUpdateBy)
                select 'Demo',
                0x4D5544D09B8319B423F6D4E054360D5289B57A98781A66B276E00C57919FDCD599BF45623D48CC81F535748F560AF0F70C8C7F3B4C3DB672562B5DD0E5E7C297,
                0x44A0BD5BFD689DF399346200A1117C33BEDF5869C17A7CB3DC6D8598A93845DB333B379AA90931D8D4E5F2CC7B1A4A96A7DB71B186DBCDCDC53B0A95440E4EDD7473668627970FBD9BB0BA17530CCAB2D9446A1902BD6AC12FE691FE09DD78A43398B89111056145843060026A414FFA8C5E75B474E187AD753D2872038D9FDD,
                getdate(),
                0

                SET @UserID = (select id from Users where Username='Demo')            
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DECLARE @UserID as int
                SET @UserID = (select id from Users where Username='Demo')
                delete from Users where Username='Demo'
            ");
        }
    }
}
