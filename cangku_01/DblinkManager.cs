using DbLink;
using System.Windows.Forms;

namespace cangku_01
{
    public class DbLinkManager
    {
        private static DataBaseType databaseType = DataBaseType.MySql;
        private static string connectString = "Server=localhost;user id=root;password=mysql;database=cangku_01;SslMode=none;charset=utf8";
        private static DbLinkFactory factory = DbLink.DbLink.CreateFactory(databaseType, connectString);

        public static DbLinkFactory GetLinkFactory() => factory;
    }
}
