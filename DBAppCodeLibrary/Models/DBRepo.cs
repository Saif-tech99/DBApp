using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAppCodeLibrary.Models
{
    public class DBRepo
    {
        #region RicRes

        public void AddRic(Residence residence)
        {
            string sql = "INSERT INTO RicRes(Address, House, Apartement, Studio)" +
                "VALUES(@Address, @House, @Apartement, @Studio)";

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Query(sql, residence).ToList();
            }
        }

        public void UpdateRic(Residence residence)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Execute("UPDATE RicRes SET Address = @Address, House = @House, Apartement = @Apartement, Studio = @Studio WHERE ID = @id",
                     new { Address = residence.Address, House = residence.House, Apartement = residence.Apartement, Studio = residence.Studio, Id = residence.Id });
            }
        }

        public void DeleteRicById(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Execute("DELETE FROM RicRes WHERE Id = @Id", new { Id = id });
            }
        }

        public List<Residence> GetResidences()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                return connection.Query<Residence>("SELECT * FROM RicRes").ToList();
            }
        }
        #endregion

        #region getType

        public List<Residence> GetHouseType(Residence residence)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                var lst = connection.Query<Residence>("SELECT Address FROM RicRes WHERE House = @House",
                    new { House = residence.House }).ToList();
                return lst;
            }
        }

        public List<Residence> GetApartementType(Residence residence)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                var lst = connection.Query<Residence>("SELECT Address FROM RicRes WHERE Apartement = @Apartement",
                    new { Apartement = residence.Apartement }).ToList();
                return lst;
            }
        }

        public List<Residence> GetStudioType(Residence residence)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                var lst = connection.Query<Residence>("SELECT Address FROM RicRes WHERE Studio = @Studio",
                    new { Studio = residence.Studio }).ToList();
                return lst;
            }
        }
        #endregion

        #region RicPep
        public void AddPep(People people)
        {
            string sql = "INSERT INTO RicPep(Name, Male, Female, ResidenceId, Owner, Tenant)" +
                "VALUES(@Name, @Male, @Female, @ResidenceId, @Owner, @Tenant)";

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Query(sql, people).ToList();
            }
        }

        public void UpdatePep(People people)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Execute("UPDATE RicPep SET Name = @Name, Male = @Male, Female = @Female, ResidenceId = @ResidenceId, Owner = @Owner, Tenant = @Tenant WHERE ID = @id",
                 new { Name = people.Name, Male = people.Male, Female = people.Female, ResidenceId = people.ResidenceId, Owner = people.Owner, Tenant = people.Tenant, Id = people.Id });
            }
        }

        public void DeletePepById(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Execute("DELETE FROM RicPep WHERE Id = @Id", new { Id = id });
            }
        }

        public List<People> GetPeoples()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                return connection.Query<People>("SELECT * FROM RicPep").ToList();
            }
        }

        public List<People> GetPeoplesRicId(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                var lst = connection.Query<People>("SELECT Name FROM RicPep WHERE ResidenceId = @Id",
                    new { Id = id }).ToList();
                return lst;
            }
        }

        #endregion

        #region SrvSub

        public void AddSrv(AddSrv srv)
        {
            string sql = "INSERT INTO AddSrv(Type, CoName, SubTotal, RicReId)" +
                "VALUES(@Type, @CoName, @SubTotal, @RicReId)";

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Query(sql, srv).ToList();
            }

        }

        public void UpdateSrv(AddSrv srv)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Execute("UPDATE AddSrv SET Type = @Type, Coname = @CoName, SubTotal = @SubTotal, RicReId = @RicReId WHERE Id = @Id",
                    new { Type = srv.Type, CoName = srv.CoName, SubTotal = srv.SubTotal, RicReId = srv.RicReId, Id = srv.Id });
            }
        }

        public void DeleteSrv(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Query<AddSrv>("DELETE FROM AddSrv WHERE Id =@Id", new { Id = id });
            }
        }

        public List<AddSrv> GetSrvs()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                var lst = connection.Query<AddSrv>("SELECT * FROM AddSrv").ToList();
                return lst;
            }
        }

        public List<AddSrv> GetSrv(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                var lst = connection.Query<AddSrv>("SELECT CoName FROM AddSrv WHERE RicReId = @Id",
                    new { Id = id }).ToList();// more work to be done
                return lst;
            }
        }
        #endregion

        #region CoSub

        public void AddRecordes(Recordes re)
        {
            string sql = "INSERT INTO Recordes(ServProId, Type, FirstConMng, FirstCheckDate, SecondConMng, SecondCheckDate, RicId, TotalCon)" +
                "VALUES(@ServProId, @Type, @FirstConMng, @FirstCheckDate, @SecondConMng, @SecondCheckDate, @RicId, @TotalCon)";

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Query<Recordes>(sql, re).ToList();
            }
        }

        public void UpdateRecordes(Recordes recordes)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Execute("UPDATE Recordes SET ServProId = @ServProId, Type = @Type, FirstConMng = @FirstConMng, FirstCheckDate= @FirstCheckDate" +
                    "SecondConMng = @SecondConMng,SecondCheckDate = @SecondCheckDate, RicId = @RicId, TotalCon = @TotalCon, WHERE Id = @Id",
                    new
                    {
                        ServProId = recordes.ServProId,
                        Type = recordes.Type,
                        FirstConMng = recordes.FirstConMng,
                        FirstCheckDate = recordes.FirstCheckDate,
                        SecondConMng = recordes.SecondConMng,
                        SecondCheckDate = recordes.SecondCheckDate,
                        RicId = recordes.RicId,
                        TotalCon = recordes.TotalCon,
                        Is = recordes.Id
                    });
            }
        }

        public void DeleteRecordes(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                connection.Query<Recordes>("DELETE FROM Recordes WHERE Id = @Id",new { Id = id});
            }
        }

        public List<Recordes> GetRecordes()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("DBApp")))
            {
                var lst = connection.Query<Recordes>("SELECT * FROM Recordes").ToList();
                return lst;
            }
        }

        #endregion
    }
}
