using System;
using System.Configuration;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using BloodBankManagmentSystem.Entities;
using System.Collections.Generic;
namespace BloodBankManagmentSystem.Database
{
    public class DataContext
    {
        private OracleConnection _connection;
        private OracleCommand _command;
        private OracleDataReader _reader;
        private OracleDataAdapter _adapter;
        private OracleCommandBuilder _builder;
        private String _sql;
        private String _connectionString;
        private DataTable _table;
        private DataSet _dataSet;
        private OracleDataAdapter _dataAdapter;
        public DataContext()
        {
            try
            {
                _connectionString = "DATA SOURCE=RAIHAN-PC:1521/XE;USER ID=ADBMS;password=ADBMS";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

        }


        public OracleDataReader GatDataReader(String _sql)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();

                return _reader;
            }
        }

        public int GetLogger(string username, string password)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                int userid = 0;
                _sql = "SELECT log_in ('" + username + "','" + password + "' ) FROM dual";
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    userid = _reader.GetInt32(0);
                    return userid;
                }
                else
                {
                    return userid;
                }
            }
        }

        public string CheckUserType(int uId)
        {
            string type = "";
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "SELECT TYPE FROM LOGINS WHERE USERID =" + uId;
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    type = _reader.GetString(0);
                    return type;
                }
                else
                {
                    return type;
                }
            }
        }

        public string TotalNo(String _sql)
        {
            string no = "0";
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    no = _reader.GetInt32(0).ToString();
                    return no;
                }
                else
                {
                    return no;
                } 
            }
            
        }

        public int GetBranchId(int uId)
        {
            int no = 1000;
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "SELECT BR_ID FROM EMP_INFO WHERE USERID =" + uId;
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    no = _reader.GetInt32(0);
                    return no;
                }
                else
                {
                    return no;
                }
            }
        }

        public Employee GetEmployeeId(int p)
        {
            Employee emp = new Employee();
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "SELECT * FROM EMP_INFO WHERE USERID =" + p;
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    emp.UserID = _reader.GetInt32(0);
                    emp.Name = _reader.GetString(1);
                    emp.Email = _reader.GetString(2);
                    emp.Phone = _reader.GetInt32(3);
                    emp.Salary = _reader.GetInt32(4);
                    emp.EmpRole = _reader.GetString(5);
                    emp.AddressId = _reader.GetInt32(6);
                    emp.Joindate = _reader.GetDateTime(7);
                    emp.BranchId = _reader.GetInt32(8);
                    emp.Gender = _reader.GetString(9);
                    emp.Username = _reader.GetString(10);
                    emp.Password = _reader.GetString(11);
                    emp.Type = _reader.GetString(12);
                    emp.Locations = this.GetLocation(_reader.GetInt32(6));

                    return emp;
                }
                else
                {
                    return emp;
                }
            }
        }

        public Access GetAccessInfo(int p)
        {
            Access emp = new Access();
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "SELECT * FROM LOGINS WHERE USERID =" + p;
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    emp.UserId = _reader.GetInt32(0);
                    emp.Username = _reader.GetString(1);
                    emp.Password = _reader.GetString(2);
                    return emp;
                }
                else
                {
                    return emp;
                }
            }
        }

        private Locations GetLocation(int p)
        {
            Locations locations = new Locations();
            _sql = "SELECT * FROM LOCATIONS WHERE L_ID =" + p;
            _command = new OracleCommand(_sql, _connection);
            _reader = _command.ExecuteReader();

            if (_reader.Read())
            {
                locations.LocationId = _reader.GetInt32(0);
                locations.Address = _reader.GetString(1);
                locations.State = _reader.GetString(2);
                locations.City = _reader.GetString(3);
                locations.ZipCode = _reader.GetInt32(4);
                locations.Country = _reader.GetString(5);
            }
            return locations;
        }

        public bool ChangePassword(int uId, String newPassword)
        {
            try
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    _sql = "UPDATE LOGINS SET PASSWORD='" + newPassword + "' WHERE USERID =" + uId;
                    _command = new OracleCommand(_sql, _connection);
                    _reader = _command.ExecuteReader();
                    return true;
                }
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public bool ChangeUsername(int uId, String newUsername)
        {
            try
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    _sql = "UPDATE LOGINS SET USERNAME='" + newUsername + "' WHERE USERID =" + uId;
                    _command = new OracleCommand(_sql, _connection);
                    _reader = _command.ExecuteReader();
                    return true;
                }
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public DataTable GetBranchesInfo()
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "SELECT * FROM BRANCHES";
                _command = new OracleCommand(_sql, _connection);

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable GetAllManagersInfo()
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "SELECT * FROM EMPLOYEES WHERE EMP_ROLE='MANAGER' OR EMP_ROLE='Super User'";
                _command = new OracleCommand(_sql, _connection);

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public Branches GetBranchInfoById(int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                Branches branches = new Branches();
                _sql = "SELECT * FROM BRANCHES WHERE BR_ID =" + branchId;
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    branches.BranchId = _reader.GetInt32(0);
                    branches.BranchName = _reader.GetString(1);
                    branches.BranchEmail = _reader.GetString(2);
                    branches.BranchPhone = _reader.GetString(3);
                    branches.ManagerId = _reader.GetInt32(5);
                    branches.Location = GetLocation(_reader.GetInt32(4));
                }
                return branches;
            }
        }

        public bool InsertLogActivity(int uId)
        {
            try
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    _sql = "INSERT INTO LOG_ACTIVITIES (USERID)" + "VALUES (:LOG_USERID)";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":LOG_USERID",uId));
                    _reader = _command.ExecuteReader();
                    return true;
                }
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public DataTable GetEmpLogActivityInfo(int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM EMP_LOG_ACTIVITIES_INFO ";
                }
                else
                {
                    _sql = "SELECT * FROM EMP_LOG_ACTIVITIES_INFO WHERE BR_ID=" + branchId;
                }
                
                _command = new OracleCommand(_sql, _connection);

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable SearchEmpLogActivityInfo(int userId, int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();

                if (branchId == 0)
                {
                    _sql = "SELECT * FROM EMP_LOG_ACTIVITIES_INFO WHERE USERID=" + userId;
                }
                else
                {
                    _sql = "SELECT * FROM EMP_LOG_ACTIVITIES_INFO WHERE BR_ID=:BRANCHID AND USERID=" + userId;
                }


                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":BRANCHID", branchId));

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable SearchEmpLogActivityInfo(String username, int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();

                if (branchId == 0)
                {
                    _sql = "SELECT * FROM EMP_LOG_ACTIVITIES_INFO WHERE USERNAME LIKE '%' || :SUSERNAME || '%'";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":SUSERNAME", username));
                }
                else
                {
                    _sql = "SELECT * FROM EMP_LOG_ACTIVITIES_INFO WHERE BR_ID=:BRANCHID AND USERNAME LIKE '%' || :SUSERNAME || '%'";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":BRANCHID", branchId));
                    _command.Parameters.Add(new OracleParameter(":SUSERNAME", username));
                }


                
                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable SearchEmpLogActivityInfo(DateTime loginDate, int branchId)
        {
            String Date = loginDate.ToString("yyyy-MM-dd");
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();

                if (branchId == 0)
                {
                    _sql = "SELECT * FROM EMP_LOG_ACTIVITIES_INFO WHERE TRUNC(LOGIN_TIME) = TO_DATE('" + Date + "', 'YYYY-MM-DD')";
                }
                else
                {
                    _sql = "SELECT * FROM EMP_LOG_ACTIVITIES_INFO WHERE BR_ID=:BRANCHID AND TRUNC(LOGIN_TIME) = TO_DATE('" + Date + "', 'YYYY-MM-DD')";
                }


                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":BRANCHID", branchId));

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable GetDonorLogActivityInfo(int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM DONOR_LOG_ACTIVITIES_INFO ";
                }
                else
                {
                    _sql = "SELECT * FROM DONOR_LOG_ACTIVITIES_INFO WHERE BR_ID=" + branchId;
                }

                _command = new OracleCommand(_sql, _connection);

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable SearchDonorLogActivityInfo(String username, int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM DONOR_LOG_ACTIVITIES_INFO WHERE USERNAME LIKE '%' || :SUSERNAME || '%'";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":SUSERNAME", username));
                }
                else
                {
                    _sql = "SELECT * FROM DONOR_LOG_ACTIVITIES_INFO WHERE BR_ID=:BRANCHID AND USERNAME LIKE '%' || :SUSERNAME || '%'";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":BRANCHID", branchId));
                    _command.Parameters.Add(new OracleParameter(":SUSERNAME", username));
                }
                

                
                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable SearchDonorLogActivityInfo(int donorId, int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM DONOR_LOG_ACTIVITIES_INFO WHERE DRID=" + donorId;
                }
                else
                {
                    _sql = "SELECT * FROM DONOR_LOG_ACTIVITIES_INFO WHERE DRID=:BRANCHID AND USERID=" + donorId;
                }
                

                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":BRANCHID", branchId));
                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable SearchDonorLogActivityInfo(DateTime loginDate, int branchId)
        {
            String Date = loginDate.ToString("yyyy-MM-dd");
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();

                if (branchId == 0)
                {
                    _sql = "SELECT * FROM DONOR_LOG_ACTIVITIES_INFO WHERE TRUNC(LOGIN_TIME) = TO_DATE('" + Date + "', 'YYYY-MM-DD')";
                }
                else
                {
                    _sql = "SELECT * FROM DONOR_LOG_ACTIVITIES_INFO WHERE BR_ID=:BRANCHID AND TRUNC(LOGIN_TIME) = TO_DATE('" + Date + "', 'YYYY-MM-DD')";
                }


                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":BRANCHID", branchId));

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable GetAllBloodRequest(int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM BLOOD_REQS ";
                }
                else
                {
                    _sql = "SELECT * FROM BLOOD_REQS WHERE BR_ID=" + branchId;
                }

                _command = new OracleCommand(_sql, _connection);

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable SearchBloodRequestByBloodGroup(string selectedText, int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM BLOOD_REQS WHERE NEEDED_BL =:BLOODGROPU";
                }
                else
                {
                    _sql = "SELECT * FROM BLOOD_REQS WHERE NEEDED_BL =:BLOODGROPU AND BR_ID=" + branchId;
                }

                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":BLOODGROPU", selectedText));
                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable SearchBloodRequestByDate(string datetype, DateTime value, int branchId)
        {
            String Date = value.ToString("dd-MM-yyyy");
            if (datetype == "ReceiveDate")
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    if (branchId == 0)
                    {
                        _sql = "SELECT * FROM BLOOD_REQS WHERE TRUNC(REQ_DATE) = TO_DATE('" + Date + "', 'DD-MM-YYYY')";
                    }
                    else
                    {
                        _sql = "SELECT * FROM BLOOD_REQS WHERE BR_ID=:BRANCHID AND TRUNC(REQ_DATE) = TO_DATE('" + Date + "', 'DD-MM-YYYY')";
                    }

                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":BRANCHID", branchId));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                    return _table;
                }
            }
            else
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    if (branchId == 0)
                    {
                        _sql = "SELECT * FROM BLOOD_REQS WHERE TRUNC(DELV_DATE) = TO_DATE('" + Date + "', 'DD-MM-YYYY')";
                    }
                    else
                    {
                        _sql = "SELECT * FROM BLOOD_REQS WHERE BR_ID=:BRANCHID AND TRUNC(DELV_DATE) = TO_DATE('" + Date + "', 'DD-MM-YYYY')";
                    }

                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("BRANCHID", branchId));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                    return _table;
                }
            }
        }

        public BloodRequest GetBloodReqById(int bloodReqId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                BloodRequest bloodRequest = new BloodRequest();
                _sql = "SELECT * FROM BLOOD_REQS WHERE BL_REQ_ID =" + bloodReqId;
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    bloodRequest.BloodReqId = _reader.GetInt32(0);
                    bloodRequest.Name = _reader.GetString(1);
                    bloodRequest.Email = _reader.GetString(2);
                    bloodRequest.Phone = _reader.GetString(3);
                    bloodRequest.RequestDate = _reader.GetDateTime(4);
                    bloodRequest.NeededBloodGrp = _reader.GetString(5);
                    bloodRequest.NeededBloodAmount = _reader.GetInt32(6);
                    bloodRequest.GivenBloodAmount = _reader.GetInt32(7);
                    bloodRequest.RequestStatus = _reader.GetString(8);
                    bloodRequest.DeliveryDate = _reader.GetDateTime(9);
                    bloodRequest.BranchId = _reader.GetInt32(10);
                    bloodRequest.Remarks = _reader.GetString(11);
                }
                return bloodRequest;
            }
        }

        public bool DeleteBloodReq(int bloodReqId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "DELETE BLOOD_REQS WHERE BL_REQ_ID =:ID";
                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":ID", bloodReqId));

                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool SaveBloodRequest(BloodRequest bloodRequest)
        {
            try
            {
                String Date = bloodRequest.DeliveryDate.ToString("dd-MM-yyyy");
                using (_connection = new OracleConnection(_connectionString))
                {
                    if (bloodRequest.BranchId == 0)
                    {
                        bloodRequest.BranchId = 1000;
                    }
                    _connection.Open();
                    _sql = "INSERT INTO BLOOD_REQS (REQ_NAME, REQ_EMAIL, REQ_PHONE, NEEDED_BL, NEEDED_BL_UNIT, GIVEN_BL_UNIT, REQ_STATUS, DELV_DATE, BR_ID, DETAILS) VALUES (:REQNAME, :REQEMAIL, :REQPHONE, :REQNEEDED_BL, :REQNEEDED_BL_UNIT, :REQGIVEN_BL_UNIT, :REQSTATUS,TO_DATE(:REQDELV_DATE, 'DD-MM-YYYY'), :REQBR_ID, :REQDETAILS)";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":REQNAME", bloodRequest.Name));
                    _command.Parameters.Add(new OracleParameter(":REQEMAIL", bloodRequest.Email));
                    _command.Parameters.Add(new OracleParameter(":REQPHONE", bloodRequest.Phone));
                    _command.Parameters.Add(new OracleParameter(":REQNEEDED_BL", bloodRequest.NeededBloodGrp));
                    _command.Parameters.Add(new OracleParameter(":REQNEEDED_BL_UNIT", bloodRequest.NeededBloodAmount));
                    _command.Parameters.Add(new OracleParameter(":REQGIVEN_BL_UNIT", bloodRequest.GivenBloodAmount));
                    _command.Parameters.Add(new OracleParameter(":REQSTATUS", bloodRequest.RequestStatus));
                    _command.Parameters.Add(new OracleParameter(":REQDELV_DATE", Date));
                    _command.Parameters.Add(new OracleParameter(":REQBR_ID", bloodRequest.BranchId));
                    _command.Parameters.Add(new OracleParameter(":REQDETAILS", bloodRequest.Remarks));
                    if (_command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public bool UpdateBloodRequest(BloodRequest bloodRequest)
        {
            try
            {
                String Date = bloodRequest.DeliveryDate.ToString("dd-MM-yyyy");
                using (_connection = new OracleConnection(_connectionString))
                {
                    if (bloodRequest.BranchId == 0)
                    {
                        bloodRequest.BranchId = 1000;
                    }
                    _connection.Open();
                    _sql = "UPDATE BLOOD_REQS SET REQ_NAME=:REQNAME, REQ_EMAIL=:REQEMAIL, REQ_PHONE=:REQPHONE, NEEDED_BL=:REQNEEDED_BL, NEEDED_BL_UNIT=:REQNEEDED_BL_UNIT, GIVEN_BL_UNIT=:REQGIVEN_BL_UNIT, REQ_STATUS=:REQSTATUS, DELV_DATE=TO_DATE(:REQDELV_DATE, 'DD-MM-YYYY'), DETAILS=:REQDETAILS WHERE BL_REQ_ID=:BLREQID";
                    _command = new OracleCommand(_sql, _connection);
                    
                    _command.Parameters.Add(new OracleParameter(":REQNAME", bloodRequest.Name));
                    _command.Parameters.Add(new OracleParameter(":REQEMAIL", bloodRequest.Email));
                    _command.Parameters.Add(new OracleParameter(":REQPHONE", bloodRequest.Phone));
                    _command.Parameters.Add(new OracleParameter(":REQNEEDED_BL", bloodRequest.NeededBloodGrp));
                    _command.Parameters.Add(new OracleParameter(":REQNEEDED_BL_UNIT", bloodRequest.NeededBloodAmount));
                    _command.Parameters.Add(new OracleParameter(":REQGIVEN_BL_UNIT", bloodRequest.GivenBloodAmount));
                    _command.Parameters.Add(new OracleParameter(":REQSTATUS", bloodRequest.RequestStatus));
                    _command.Parameters.Add(new OracleParameter(":REQDELV_DATE", Date));
                    _command.Parameters.Add(new OracleParameter(":REQDETAILS", bloodRequest.Remarks));
                    _command.Parameters.Add(new OracleParameter(":BLREQID", bloodRequest.BloodReqId));
                    if (_command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public DataTable GetAllDonorsList(int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM DONORS_INFO ";
                }
                else
                {
                    _sql = "SELECT * FROM DONORS_INFO WHERE BR_ID=" + branchId;
                }

                _command = new OracleCommand(_sql, _connection);

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable GetSearchedDonorsList(int branchId, string searchKey, string searchType)
        {
            if (searchType == "Name")
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    if (branchId == 0)
                    {
                        _sql = "SELECT * FROM DONORS_INFO WHERE DR_NAME LIKE '%' || :SEARCH || '%'";
                    }
                    else
                    {
                        _sql = "SELECT * FROM DONORS_INFO WHERE DR_NAME LIKE '%' || :SEARCH || '%' AND BR_ID=" + branchId;
                    }

                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("SEARCH", searchKey));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                }
            }

            if (searchType == "Email")
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    if (branchId == 0)
                    {
                        _sql = "SELECT * FROM DONORS_INFO WHERE DR_EMAIL LIKE '%' || :SEARCH || '%'";
                    }
                    else
                    {
                        _sql = "SELECT * FROM DONORS_INFO WHERE DR_EMAIL LIKE '%' || :SEARCH || '%' AND BR_ID=" + branchId;
                    }

                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("SEARCH", searchKey));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                }
            }

            if (searchType == "Phone")
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    if (branchId == 0)
                    {
                        _sql = "SELECT * FROM DONORS_INFO WHERE DR_PHONE LIKE '%' || :SEARCH || '%'";
                    }
                    else
                    {
                        _sql = "SELECT * FROM DONORS_INFO WHERE DR_PHONE LIKE '%' || :SEARCH || '%' AND BR_ID=" + branchId;
                    }

                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("SEARCH", searchKey));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                }
            }

            if (searchType == "Blood Group")
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    if (branchId == 0)
                    {
                        _sql = "SELECT * FROM DONORS_INFO WHERE DR_BLOOD_GRP LIKE '%' || :SEARCH || '%'";
                    }
                    else
                    {
                        _sql = "SELECT * FROM DONORS_INFO WHERE DR_BLOOD_GRP LIKE '%' || :SEARCH || '%' AND BR_ID=" + branchId;
                    }

                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("SEARCH", searchKey));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                }
            }


            return _table;
        }

        public int NextSequenceNo(string sequence)
        {
            int no = 000;
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();

                _sql = "SELECT " + sequence + ".NEXTVAL FROM DUAL";


                _command = new OracleCommand(_sql, _connection);

                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    no = _reader.GetInt32(0);
                    return no;
                }
                else
                {
                    return no;
                }
            }
        }

        public bool SaveDonerLocation(Locations locations)
        {
            try
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    _sql = "INSERT INTO LOCATIONS (L_ID, ADDRESS, CITY, STATE, ZIP_CODE, COUNTRY) VALUES (:NEWL_ID, :NEWADDRESS, :NEWCITY, :NEWSTATE, :NEWZIP_CODE, :NEWCOUNTRY)";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":NEWL_ID", locations.LocationId));
                    _command.Parameters.Add(new OracleParameter(":NEWADDRESS", locations.Address));
                    _command.Parameters.Add(new OracleParameter(":NEWCITY", locations.City));
                    _command.Parameters.Add(new OracleParameter(":NEWSTATE", locations.State));
                    _command.Parameters.Add(new OracleParameter(":NEWZIP_CODE", locations.ZipCode));
                    _command.Parameters.Add(new OracleParameter(":NEWCOUNTRY", locations.Country));
                    if (_command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public bool SaveDonerInfo(Donor donor)
        {
            String BDate = donor.Birthdate.ToString("dd-MM-yyyy");
            String DonateDate = donor.LastDonetDate.ToString("dd-MM-yyyy");

            using (_connection = new OracleConnection(_connectionString))
            {
                if (donor.BranchId == 0)
                {
                    donor.BranchId = 1000;
                }
                _connection.Open();
                _sql = "INSERT INTO DONORS (DR_NAME,DR_EMAIL,DR_PHONE,DR_BLOOD_GRP,BIRTH_DATE,DR_ADDRESS,BR_ID,LAST_DONET_DATE) VALUES (:NEWDR_NAME,:NEWDR_EMAIL,:NEWDR_PHONE,:NEWDR_BLOOD_GRP,TO_DATE(:NEWBIRTH_DATE, 'DD-MM-YYYY'),:NEWDR_ADDRESS,:NEWBR_ID,TO_DATE(:NEWLAST_DONET_DATE, 'DD-MM-YYYY'))";
                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":NEWDR_NAME", donor.Name));
                _command.Parameters.Add(new OracleParameter(":NEWDR_EMAIL", donor.Email));
                _command.Parameters.Add(new OracleParameter(":NEWDR_PHONE", donor.Phone));
                _command.Parameters.Add(new OracleParameter(":NEWDR_BLOOD_GRP", donor.BloodGroup));
                _command.Parameters.Add(new OracleParameter(":NEWBIRTH_DATE", BDate));
                _command.Parameters.Add(new OracleParameter(":NEWDR_ADDRESS", donor.AddressId));
                _command.Parameters.Add(new OracleParameter(":NEWBR_ID", donor.BranchId));
                _command.Parameters.Add(new OracleParameter(":NEWLAST_DONET_DATE", DonateDate));
                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public bool DeleteLocation(int locationId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "DELETE LOCATIONS WHERE L_ID =:ID";
                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter("ID", locationId));

                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Donor GetDonorById(int donorId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                Donor donor = new Donor();
                _sql = "SELECT * FROM DONORS WHERE DRID =" + donorId;
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    donor.DrId = _reader.GetInt32(0);
                    donor.Name = _reader.GetString(1);
                    donor.Email = _reader.GetString(2);
                    donor.Phone = _reader.GetString(3);
                    donor.Birthdate = _reader.GetDateTime(5);
                    donor.BloodGroup = _reader.GetString(4);
                    donor.AddressId = _reader.GetInt32(6);
                    donor.BranchId = _reader.GetInt32(7);
                    donor.LastDonetDate = _reader.GetDateTime(8);
                    donor.Locations = this.GetLocation(_reader.GetInt32(6));
                }
                return donor;
            }
        }

        public bool UpdateDonerInfo(Donor donor)
        {
            String BDate = donor.Birthdate.ToString("dd-MM-yyyy");
            String DonateDate = donor.LastDonetDate.ToString("dd-MM-yyyy");
            using (_connection = new OracleConnection(_connectionString))
            {
                if (donor.BranchId == 0)
                {
                    donor.BranchId = 1000;
                }
                _connection.Open();
                _sql = "UPDATE DONORS SET DR_NAME=:NEWDR_NAME,DR_EMAIL=:NEWDR_EMAIL,DR_PHONE=:NEWDR_PHONE,DR_BLOOD_GRP=:NEWDR_BLOOD_GRP,BIRTH_DATE=TO_DATE(:NEWBIRTH_DATE, 'DD-MM-YYYY'),DR_ADDRESS=:NEWDR_ADDRESS,BR_ID=:NEWBR_ID,LAST_DONET_DATE=TO_DATE(:NEWLAST_DONET_DATE, 'DD-MM-YYYY') WHERE DRID=:NEWDRID";

                _command = new OracleCommand(_sql, _connection);

                _command.Parameters.Add(new OracleParameter(":NEWDR_NAME", donor.Name));
                _command.Parameters.Add(new OracleParameter(":NEWDR_EMAIL", donor.Email));
                _command.Parameters.Add(new OracleParameter(":NEWDR_PHONE", donor.Phone));
                _command.Parameters.Add(new OracleParameter(":NEWDR_BLOOD_GRP", donor.BloodGroup));
                _command.Parameters.Add(new OracleParameter(":NEWBIRTH_DATE", BDate));
                _command.Parameters.Add(new OracleParameter(":NEWDR_ADDRESS", donor.AddressId));
                _command.Parameters.Add(new OracleParameter(":NEWBR_ID", donor.BranchId));
                _command.Parameters.Add(new OracleParameter(":NEWLAST_DONET_DATE", DonateDate));
                _command.Parameters.Add(new OracleParameter(":NEWDRID", donor.DrId));
                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateDonerLocation(Locations locations)
        {
            //try
            //{
                
            //}
            //catch (Exception)
            //{
            //    return false;
            //}

            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();

                _sql = "UPDATE LOCATIONS SET ADDRESS=:NEWADDRESS, CITY=:NEWCITY, STATE=:NEWSTATE, ZIP_CODE=:NEWZIP_CODE, COUNTRY=:NEWCOUNTRY WHERE L_ID=:NEWL_ID";


                _command = new OracleCommand(_sql, _connection);


                _command.Parameters.Add(new OracleParameter(":NEWADDRESS", locations.Address));
                _command.Parameters.Add(new OracleParameter(":NEWCITY", locations.City));
                _command.Parameters.Add(new OracleParameter(":NEWSTATE", locations.State));
                _command.Parameters.Add(new OracleParameter(":NEWZIP_CODE", locations.ZipCode));
                _command.Parameters.Add(new OracleParameter(":NEWCOUNTRY", locations.Country));
                _command.Parameters.Add(new OracleParameter(":NEWL_ID", locations.LocationId));
                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public DataTable GetAllBranchesList()
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();

                _sql = "SELECT * FROM BRANCH_INFO";

                _command = new OracleCommand(_sql, _connection);

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public List<int> TotalEmpList(int p)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                List<int> tEmp = new List<int>();
                _connection.Open();
                if (p == 0)
                {
                    _sql = "SELECT COUNT(USERID) FROM EMPLOYEES GROUP BY BR_ID";
                }
                else
                {
                    _sql = "SELECT COUNT(USERID) FROM EMPLOYEES WHERE BR_ID=:BRANCHID GROUP BY BR_ID";
                }

                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":BRANCHID", p));
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    int no = _reader.GetInt32(0);
                    tEmp.Add(no);
                }
                return tEmp;
            }
        }

        public List<int> TotalDonList(int i)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                List<int> tDon = new List<int>();
                _connection.Open();
                if (i == 0)
                {
                    _sql = "SELECT COUNT(DRID) FROM DONORS GROUP BY BR_ID";
                }
                else
                {
                    _sql = "SELECT COUNT(DRID) FROM DONORS WHERE BR_ID=:BRANCHID GROUP BY BR_ID";
                }

                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":BRANCHID", i));
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    int no = _reader.GetInt32(0);
                    tDon.Add(no);
                }
                return tDon;
            }
        }

        public bool SaveBranchInfo(Branches branches)
        {
            try
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();
                    _sql = "INSERT INTO BRANCHES (BR_NAME, BR_EMAIL, BR_PHONE, L_ID, MANAGERID) VALUES (:NEWBR_NAME, :NEWBR_EMAIL, :NEWBR_PHONE, :NEWL_ID, :NEWMANAGERID)";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":NEWBR_NAME", branches.BranchName));
                    _command.Parameters.Add(new OracleParameter(":NEWBR_EMAIL", branches.BranchEmail));
                    _command.Parameters.Add(new OracleParameter(":NEWBR_PHONE", branches.BranchPhone));
                    _command.Parameters.Add(new OracleParameter(":NEWL_ID", branches.LocationId));
                    _command.Parameters.Add(new OracleParameter(":NEWMANAGERID", branches.ManagerId));
                    if (_command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public bool UpdateBranchInfo(Branches branches)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "UPDATE BRANCHES SET BR_NAME=:NEWBR_NAME, BR_EMAIL=:NEWBR_EMAIL, BR_PHONE=:NEWBR_PHONE, L_ID=:NEWL_ID, MANAGERID=:NEWMANAGERID WHERE BR_ID=:NEWBR_ID";
                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":NEWBR_NAME", branches.BranchName));
                _command.Parameters.Add(new OracleParameter(":NEWBR_EMAIL", branches.BranchEmail));
                _command.Parameters.Add(new OracleParameter(":NEWBR_PHONE", branches.BranchPhone));
                _command.Parameters.Add(new OracleParameter(":NEWL_ID", branches.LocationId));
                _command.Parameters.Add(new OracleParameter(":NEWMANAGERID", branches.ManagerId));
                _command.Parameters.Add(new OracleParameter(":NEWBR_ID", branches.BranchId));
                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeleteBranchInfo(int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "DELETE BRANCHES WHERE BR_ID =:ID";
                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter("ID", branchId));

                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public DataTable GetAllDonateList(int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM BLOOD_DONATE_INFO";
                }
                else
                {
                    _sql = "SELECT * FROM BLOOD_DONATE_INFO WHERE BR_ID=" + branchId;
                }

                _command = new OracleCommand(_sql, _connection);

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public Blood GetDonateBloodById(int donateId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                Blood branches = new Blood();
                _sql = "SELECT * FROM BLOODS WHERE BLID =" + donateId;
                _command = new OracleCommand(_sql, _connection);
                _reader = _command.ExecuteReader();

                if (_reader.Read())
                {
                    branches.BlId = _reader.GetInt32(0);
                    branches.ReceivedDate = _reader.GetDateTime(1);
                    branches.DonorId = _reader.GetInt32(2);
                    branches.BranchId = _reader.GetInt32(3);
                }
                return branches;
            }
        }

        public bool SaveDonateBlood(Blood blood)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                if (blood.BranchId == 0)
                {
                    blood.BranchId = 1000;
                }
                String recDate = blood.ReceivedDate.ToString("dd-MM-yyyy");
                _connection.Open();
                _sql = "INSERT INTO BLOODS (RECV_DATE, DR_ID, BR_ID) VALUES (TO_DATE(:NEWRECV_DATE, 'DD-MM-YYYY'), :NEWDR_ID, :NEWBR_ID)";
                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":NEWRECV_DATE", recDate));
                _command.Parameters.Add(new OracleParameter(":NEWDR_ID", blood.DonorId));
                _command.Parameters.Add(new OracleParameter(":NEWBR_ID", blood.BranchId));
                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateDonateBlood(Blood blood)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                if (blood.BranchId == 0)
                {
                    blood.BranchId = 1000;
                }
                String recDate = blood.ReceivedDate.ToString("dd-MM-yyyy");
                _connection.Open();
                _sql = "UPDATE BLOODS SET RECV_DATE=TO_DATE(:NEWRECV_DATE, 'DD-MM-YYYY'), DR_ID=:NEWDR_ID, BR_ID=:NEWBR_ID WHERE BLID=:NEWBLID";
                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":NEWRECV_DATE", recDate));
                _command.Parameters.Add(new OracleParameter(":NEWDR_ID", blood.DonorId));
                _command.Parameters.Add(new OracleParameter(":NEWBR_ID", blood.BranchId));
                _command.Parameters.Add(new OracleParameter(":NEWBLID", blood.BlId));
                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeleteDonateBlood(int donateId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "DELETE BLOODS WHERE BLID =:ID";
                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter("ID", donateId));

                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public DataTable GetAllEmployeesList(int branchId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM EMP_INFO";
                }
                else
                {
                    _sql = "SELECT * FROM EMP_INFO WHERE BR_ID=" + branchId;
                }

                _command = new OracleCommand(_sql, _connection);

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public bool DeleteLogin(int employeeId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                _sql = "DELETE LOGINS WHERE USERID =:ID";
                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter("ID", employeeId));

                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool SaveEmployeeInfo(Employee employee)
        {
            String BDate = employee.Joindate.ToString("dd-MM-yyyy");
            using (_connection = new OracleConnection(_connectionString))
            {
                if (employee.BranchId == 0)
                {
                    employee.BranchId = 1000;
                }
                _connection.Open();
                _sql = "INSERT INTO EMPLOYEES (EMP_NAME,EMP_EMAIL,EMP_PHO,SALARY,EMP_ROLE,ADDRESS_ID,JOIN_DATE,BR_ID,GENDER) VALUES (:NEWEMP_NAME,:NEWEMP_EMAIL,:NEWEMP_PHO,:NEWSALARY,:NEWEMP_ROLE,:NEWADDRESS_ID,TO_DATE(:NEWJOIN_DATE, 'DD-MM-YYYY'),:NEWBR_ID,:NEWGENDER)";
                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":NEWEMP_NAME", employee.Name));
                _command.Parameters.Add(new OracleParameter(":NEWEMP_EMAIL", employee.Email));
                _command.Parameters.Add(new OracleParameter(":NEWEMP_PHO", employee.Phone));
                _command.Parameters.Add(new OracleParameter(":NEWSALARY", employee.Salary));
                _command.Parameters.Add(new OracleParameter(":NEWEMP_ROLE", employee.EmpRole));
                _command.Parameters.Add(new OracleParameter(":NEWADDRESS_ID", employee.AddressId));
                _command.Parameters.Add(new OracleParameter(":NEWJOIN_DATE", BDate));
                _command.Parameters.Add(new OracleParameter(":NEWBR_ID", employee.BranchId));
                _command.Parameters.Add(new OracleParameter(":NEWGENDER", employee.Gender));
                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdateEmployeeInfo(Employee employee)
        {
            String BDate = employee.Joindate.ToString("dd-MM-yyyy");
            using (_connection = new OracleConnection(_connectionString))
            {
                if (employee.BranchId == 0)
                {
                    employee.BranchId = 1000;
                }
                _connection.Open();
                _sql ="UPDATE EMPLOYEES SET EMP_NAME=:NEWEMP_NAME,EMP_EMAIL=:NEWEMP_EMAIL,EMP_PHO=:NEWEMP_PHO,SALARY=:NEWSALARY,EMP_ROLE=:NEWEMP_ROLE,ADDRESS_ID=:NEWADDRESS_ID,JOIN_DATE=TO_DATE(:NEWJOIN_DATE, 'DD-MM-YYYY'),BR_ID=:NEWBR_ID,GENDER=:NEWGENDER WHERE USERID=:ID";

                _command = new OracleCommand(_sql, _connection);

                _command.Parameters.Add(new OracleParameter(":NEWEMP_NAME", employee.Name));
                _command.Parameters.Add(new OracleParameter(":NEWEMP_EMAIL", employee.Email));
                _command.Parameters.Add(new OracleParameter(":NEWEMP_PHO", employee.Phone));
                _command.Parameters.Add(new OracleParameter(":NEWSALARY", employee.Salary));
                _command.Parameters.Add(new OracleParameter(":NEWEMP_ROLE", employee.EmpRole));
                _command.Parameters.Add(new OracleParameter(":NEWADDRESS_ID", employee.AddressId));
                _command.Parameters.Add(new OracleParameter(":NEWJOIN_DATE", BDate));
                _command.Parameters.Add(new OracleParameter(":NEWBR_ID", employee.BranchId));
                _command.Parameters.Add(new OracleParameter(":NEWGENDER", employee.Gender));
                _command.Parameters.Add(new OracleParameter(":ID", employee.UserID));
                if (_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public DataTable GetPublicViewData()
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();

                _sql = "SELECT * FROM PUBLIC_INFO";
                _command = new OracleCommand(_sql, _connection);

                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }
        }

        public DataTable PublicSearch(string text, string type)
        {
            if (type == "Name")
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();

                    _sql = "SELECT * FROM PUBLIC_INFO WHERE DR_NAME LIKE '%' || :SEARCH || '%'";
                    
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("SEARCH", text));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                }
            }
            else
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();

                    _sql = "SELECT * FROM PUBLIC_INFO WHERE DR_BLOOD_GRP LIKE '%' || :SEARCH || '%'";
                    
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("SEARCH", text));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                }
            }
            return _table;
        }

        public DataTable GetDonorDonateHistroyData(int donorId)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();

                _sql = "SELECT * FROM BLOOD_DONATE_INFO WHERE DRID=:SEARCH";

                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":SEARCH", donorId));
                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
            }
            return _table;
        }

        public DataTable SearchDonorDonateHistroyData(DateTime value,int donorId)
        {
            String Date = value.ToString("dd-MM-yyyy");
            
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();

                _sql = "SELECT * FROM BLOOD_DONATE_INFO WHERE DRID=:SEARCH AND TRUNC(RECV_DATE) = TO_DATE('" + Date + "', 'DD-MM-YYYY')";

                _command = new OracleCommand(_sql, _connection);
                _command.Parameters.Add(new OracleParameter(":SEARCH", donorId));
                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
            }
            return _table;
        }

        public DataTable SearchBranch(string text, string type)
        {
            if (type == "Name")
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();

                    _sql = "SELECT * FROM BRANCH_INFO WHERE BR_NAME LIKE '%' || :SEARCH || '%'";

                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("SEARCH", text));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                }
            }
            else
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();

                    _sql = "SELECT * FROM BRANCH_INFO WHERE BR_EMAIL LIKE '%' || :SEARCH || '%'";

                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("SEARCH", text));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                }
            }
            return _table;
        }

        public DataTable EmployeeSearch(string text, string type)
        {
            if (type == "Name")
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();

                    _sql = "SELECT * FROM EMP_INFO WHERE EMP_NAME LIKE '%' || :SEARCH || '%'";

                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("SEARCH", text));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                }
            }
            else
            {
                using (_connection = new OracleConnection(_connectionString))
                {
                    _connection.Open();

                    _sql = "SELECT * FROM EMP_INFO WHERE EMP_EMAIL LIKE '%' || :SEARCH || '%'";

                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("SEARCH", text));
                    using (_dataAdapter = new OracleDataAdapter(_command))
                    {
                        _table = new DataTable();
                        //_dataAdapter.ReturnProviderSpecificTypes = true;
                        _dataAdapter.Fill(_table);
                    }
                }
            }
            return _table;
        }

        public DataTable GetSearchedBloodDonatList(int branchId, DateTime value)
        {
            String Date = value.ToString("dd-MM-yyyy");
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM BLOOD_DONATE_INFO WHERE TRUNC(RECV_DATE) = TO_DATE('" + Date + "', 'DD-MM-YYYY')";
                    _command = new OracleCommand(_sql, _connection);
                }
                else
                {
                    _sql = "SELECT * FROM BLOOD_DONATE_INFO WHERE BR_ID=:BRANCHID AND TRUNC(RECV_DATE) = TO_DATE('" + Date + "', 'DD-MM-YYYY')";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter("BRANCHID", branchId));
                }

                
                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
                return _table;
            }

        }

        public DataTable GetSearchedBloodDonatList(int branchId, String value)
        {
            using (_connection = new OracleConnection(_connectionString))
            {
                _connection.Open();
                if (branchId == 0)
                {
                    _sql = "SELECT * FROM BLOOD_DONATE_INFO WHERE DR_BLOOD_GRP LIKE '%' || :SEARCH || '%'";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":SEARCH", value));
                }
                else
                {
                    _sql = "SELECT * FROM BLOOD_DONATE_INFO WHERE BR_ID=:BRANCHID AND DR_BLOOD_GRP LIKE '%' || :SEARCH || '%'";
                    _command = new OracleCommand(_sql, _connection);
                    _command.Parameters.Add(new OracleParameter(":BRANCHID", branchId));
                    _command.Parameters.Add(new OracleParameter(":SEARCH", value));
                }
                
                using (_dataAdapter = new OracleDataAdapter(_command))
                {
                    _table = new DataTable();
                    //_dataAdapter.ReturnProviderSpecificTypes = true;
                    _dataAdapter.Fill(_table);
                }
            }
            return _table;
        }
    }
}
