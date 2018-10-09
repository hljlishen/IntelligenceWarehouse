using cangku_01.MysqlConnection;
using DbLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cangku_01.entity
{
    class TemperatureAndHumidity : ActiveRecord
    {
        static DbLinkFactory factory = DbLinkManager.GetLinkFactory();
        DataMysql dbo = DataMysql.GetDataMysqlGreateInstance(DataMysql.mysqldefaultconnection);

        public int? tem_id { get; set; }
        public double? tem_temperature { get; set; }
        public double? tem_humidity { get; set; }
        public DateTime? tem_time { get; set; }

        ISelectSqlMaker maker;

        public TemperatureAndHumidity() : base("t_temandhum", "tem_id", factory)
        {
        }
    }
}
