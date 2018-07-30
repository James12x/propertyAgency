using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PropertyAgencyCommissionNu {
    /// <summary>
    /// The class that hold everything related to database connection and query
    /// </summary>
    public class Connection {
        public static Connection Instance;
        MySqlConnection conn;
        public const string CONNECTION = "server=127.0.0.1; database=propertycommission; user=root; password=; Convert Zero Datetime=True";
        
        /// <summary>
        /// the connect method
        /// </summary>
        public void Connect() {
            try {
                conn = new MySqlConnection(CONNECTION);
                conn.Open();
                MessageBox.Show("Connected");
            } catch (Exception e) {
                MessageBox.Show("Cannot connect");
            }
        }
        

        #region Agent Methods
        /// <summary>
        /// checking whether the agent is active or not
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool CheckActiveAgent(string data, TempData type) {
            bool result = false;
            string dataType = "";
            if(type == TempData.ID) {
                dataType = "agent_id";
            } else {
                dataType = "agent_name";
            }

            string sql = $@"SELECT agent.agent_status FROM agent WHERE agent.{dataType} = @data";
            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add(new MySqlParameter("@data", MySqlDbType.String)).Value = data;
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetBoolean("agent_status");
            }
            reader.Close();
            return result;
        }

        /// <summary>
        /// query for inserting new agent
        /// </summary>
        /// <param name="data"></param>
        public void InsertNewAgent(object[] data) {
            string sql = "INSERT INTO agent (agent_id, agent_name, agent_email, agent_phone, agent_status, date_joined, branch_id, upline_id) " + "VALUES (@id, @name, @email, @phone, @status, @date, @branchId, @uplineId)";

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.String);
            idParam.Value = data[0];

            MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.String);
            nameParam.Value = data[1];

            MySqlParameter emailParam = new MySqlParameter("@email", MySqlDbType.String);
            emailParam.Value = data[2];

            MySqlParameter phoneParam = new MySqlParameter("@phone", MySqlDbType.String);
            phoneParam.Value = data[3];

            MySqlParameter statusParam = new MySqlParameter("@status", MySqlDbType.Int16);
            statusParam.Value = data[4];

            MySqlParameter dateParam = new MySqlParameter("@date", MySqlDbType.Date);
            dateParam.Value = data[5];

            MySqlParameter branchIdParam = new MySqlParameter("@branchId", MySqlDbType.String);
            branchIdParam.Value = data[6];

            MySqlParameter uplineIdParam = new MySqlParameter("@uplineId", MySqlDbType.String);
            uplineIdParam.Value = data[7];


            command.Parameters.Add(idParam);
            command.Parameters.Add(nameParam);
            command.Parameters.Add(emailParam);
            command.Parameters.Add(phoneParam);
            command.Parameters.Add(statusParam);
            command.Parameters.Add(dateParam);
            command.Parameters.Add(branchIdParam);
            command.Parameters.Add(uplineIdParam);

            command.Prepare();

            //  string sql2 = "INSERT INTO `agent` (`agent_id`, `agent_name`, `agent_phone`, `agent_email`, `agent_status`, `date`, `branch_id`, `upline_id`) VALUES('asd', 'B', '0', NULL, '1', '2005-1-1', NULL, NULL);";
            //  command.Connection = conn;

            command.ExecuteNonQuery();
            //    conn.Close();
            MessageBox.Show("Agent Added");
        }

        /// <summary>
        /// query for updateing agent data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="tempData"></param>
        public void UpdateAgentData(object[] data, TempData tempData) { // not yet
            string fillData = "";
            if (tempData == TempData.ID) {
                fillData = data[0].ToString();
            } else {
                fillData = data[1].ToString();
            }
            string sql = "UPDATE agent SET agent_id = @id, agent_name = @name, agent_email = @email, agent_phone = @phone, " +
                        "date_joined = @date, branch_id = @branchId, upline_id = @uplineId WHERE agent.agent_id = '" + fillData + "'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.String);
            idParam.Value = data[0];

            MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.String);
            nameParam.Value = data[1];

            MySqlParameter emailParam = new MySqlParameter("@email", MySqlDbType.String);
            emailParam.Value = data[2];

            MySqlParameter phoneParam = new MySqlParameter("@phone", MySqlDbType.String);
            phoneParam.Value = data[3];

            /*            MySqlParameter statusParam = new MySqlParameter("@status", MySqlDbType.Int16);
                        statusParam.Value = data[4];*/

            MySqlParameter dateParam = new MySqlParameter("@date", MySqlDbType.Date);
            dateParam.Value = data[5];

            MySqlParameter branchIdParam = new MySqlParameter("@branchId", MySqlDbType.String);
            branchIdParam.Value = data[6];

            MySqlParameter uplineIdParam = new MySqlParameter("@uplineId", MySqlDbType.String);
            uplineIdParam.Value = data[7];

            command.Parameters.Add(idParam);
            command.Parameters.Add(nameParam);
            command.Parameters.Add(emailParam);
            command.Parameters.Add(phoneParam);
            command.Parameters.Add(dateParam);
            command.Parameters.Add(branchIdParam);
            command.Parameters.Add(uplineIdParam);

            command.Prepare();

            command.ExecuteNonQuery();
            MessageBox.Show("Agent Updated");
        }

        public void UpdateAgentData(object[] data) { // not yet
            UpdateAgentData(data, TempData.ID);
        }

        /// <summary>
        /// query for getting the agent data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public object[] GetAgentData(string data, TempData dataType) {
            object[] result = new object[8];

            //  List<string> result = new List<string>();
            string sql = "";
            if (dataType == TempData.ID) {
                sql = "SELECT * from agent where agent.agent_id = '" + data + "'";
            } else {
                sql = "SELECT * from agent where agent.agent_name = '" + data + "'";
            }

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                // result.Add(reader.GetString("branch_id"));
                result[0] = reader.GetString("agent_id");
                result[1] = reader.GetString("agent_name");
                result[2] = reader.GetString("agent_email");
                result[3] = reader.GetString("agent_phone");
                result[4] = reader.GetInt16("agent_status");
                result[5] = reader.GetDateTime("date_joined");
                if (Convert.IsDBNull(reader["branch_id"])) {
                    result[6] = "";
                } else {
                    result[6] = reader.GetString("branch_id");
                }

                result[7] = reader.GetString("upline_id");
            }

            reader.Close();
            //   MessageBox.Show(result.Length.ToString());
            for (int i = 0; i < result.Length; i++) {
                //   MessageBox.Show(i + " : " + result[i].ToString());
            }
            return result;
        }

        /// <summary>
        /// query for disabling the agent
        /// </summary>
        /// <param name="data"></param>
        /// <param name="tempData"></param>
        public void DisableAgent(object[] data, TempData tempData) {
            string fillData = "";
            string dataType = "";
            if (tempData == TempData.ID) {
                fillData = data[0].ToString();
                dataType = "agent_id";
            } else {
                fillData = data[1].ToString();
                dataType = "agent_name";
            }
            string sql = "UPDATE agent SET agent_status = " + 0 + " WHERE agent." + dataType + " = '" + fillData + "'";
            MySqlCommand command = new MySqlCommand(sql, conn);

            command.ExecuteNonQuery();
            //    conn.Close();
            MessageBox.Show("Agent Disabled");
        }
        
        public void DisableAgent(string id) {
            DisableAgent(new object[] { id }, TempData.ID);
        }

        /// <summary>
        /// get agent id by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetAgentID(string name) {
            string result = "";
            string sql = "SELECT agent.agent_id FROM agent WHERE agent.agent_name = '" + name + "'";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetString("agent_id");
            }

            reader.Close();
            return result;
        }

        /// <summary>
        /// checking if the agent exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsAgentExists(string id) {
            string sql = "SELECT count(*) FROM agent WHERE agent.agent_id = @id";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.String);
            idParam.Value = id;
            command.Parameters.Add(idParam);
            command.Prepare();

            int totalCount = Convert.ToInt32(command.ExecuteScalar());

            if (totalCount > 0) {
                return true;
            } else {
                return false;
            }
        }

        public string[] GetAgentIDs() {
            return GetAgentIDs(true);
        }

        /// <summary>
        /// getting all agent ids
        /// </summary>
        /// <param name="removeParent">if true, the parent will be removed</param>
        /// <returns></returns>
        public string[] GetAgentIDs(bool removeParent) {
            List<string> result = new List<string>();

            string sql = "SELECT agent.agent_id from agent where agent.agent_status = 1 or agent.agent_id = '_parent'";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result.Add(reader.GetString("agent_id"));
            }
            reader.Close();

            if (removeParent) {
                result.Remove("_parent");
            }
            return result.ToArray();
        }

        /// <summary>
        /// get agent name from id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetAgentName(string id) {
            string result = "";
            string sql = "SELECT agent.agent_name FROM agent WHERE agent.agent_id = '" + id + "'";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetString("agent_name");
            }

            reader.Close();
            return result;
        }

        public string[] GetAgentNames() {
            return GetAgentNames(true);
        }

        /// <summary>
        /// get all agent names
        /// </summary>
        /// <param name="removeParent"></param>
        /// <returns></returns>
        public string[] GetAgentNames(bool removeParent) {
            List<string> result = new List<string>();

            string sql = "SELECT agent.agent_name from agent where agent.agent_status = 1 or agent.agent_id = '_parent'";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result.Add(reader.GetString("agent_name"));
            }
            reader.Close();
            if (removeParent) {
                result.Remove(GetAgentName("_parent"));
            }
            return result.ToArray();
        }

        /// <summary>
        /// get all agent names in a branch
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string[] GetAgentNamesInBranch(string id) {
            List<string> result = new List<string>();

            string sql = "SELECT agent.agent_name from agent where agent.agent_id = '_parent' OR (agent.agent_status = 1 AND  agent.branch_id = '" + id + "')";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result.Add(reader.GetString("agent_name"));
            }
            reader.Close();

            return result.ToArray();
        }

        public Agent[] GetAgentDatas() {
            return GetAgentDatas(true);
        }

        /// <summary>
        /// get all agent datas
        /// </summary>
        /// <param name="removeParent">if true, will remove parent</param>
        /// <returns></returns>
        public Agent[] GetAgentDatas(bool removeParent) {
            List<Agent> results = new List<Agent>();
            object[] result = new object[8];

            string sql = "SELECT * from agent";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result[0] = reader.GetString("agent_id");
                result[1] = reader.GetString("agent_name");
                result[2] = reader.GetString("agent_email");
                result[3] = reader.GetString("agent_phone");
                result[4] = reader.GetInt16("agent_status");
                result[5] = reader.GetDateTime("date_joined");
                if (Convert.IsDBNull(reader["branch_id"])) {
                    result[6] = "";
                } else {
                    result[6] = reader.GetString("branch_id");
                }

                result[7] = reader.GetString("upline_id");

                results.Add(new Agent(result));
            }

            reader.Close();

            if (removeParent) {
                for(int i = 0; i < results.Count; i++) {
                    if(results[i].ID == "_parent") {
                        results.RemoveAt(i);
                    }
                }
            }

            
            return results.ToArray();
        }
        #endregion

        #region Principal and Vice Principal
        /// <summary>
        /// get principal or vice principal name
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string[] GetPrincipalOrViceNames(PrincipalOrVice type) {
            List<string> result = new List<string>();

            string tempType = "";
            if (type == PrincipalOrVice.Principal) {
                tempType = "principal";
            } else {
                tempType = "vice_principal";
            }


            string sql = "SELECT " + tempType + ".agent_id from " + tempType + " where " + tempType + ".agent_status = 1 or agent.agent_id = '_parent'";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result.Add(reader.GetString("agent_name"));
            }
            reader.Close();
            return result.ToArray(); ;
        }
        /// <summary>
        /// insert principal or vice principal
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        public void InsertPrincipalOrVice(object[] data, PrincipalOrVice type) {
            string tempType = "";
            if (type == PrincipalOrVice.Principal) {
                tempType = "principal";
            } else {
                tempType = "vice_principal";
            }

            string sql = "INSERT INTO " + tempType + " (date, agent_id, branch_id) VALUES(@date, @agentId, @branchId)";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add(new MySqlParameter("@date", MySqlDbType.Date)).Value = data[0];
            command.Parameters.Add(new MySqlParameter("@agentId", MySqlDbType.String)).Value = data[1];
            command.Parameters.Add(new MySqlParameter("@branchId", MySqlDbType.String)).Value = data[2];

            command.Prepare();

            command.ExecuteNonQuery();
            
        }
        /// <summary>
        /// updating principal or vice principal data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        public void UpdatePrincipalOrVice(object[] data, PrincipalOrVice type) {
            string tempType = "";
            if (type == PrincipalOrVice.Principal) {
                tempType = "principal";
            } else {
                tempType = "vice_principal";
            }

            string sql = "UPDATE " + tempType + " SET agent_id = @agentId WHERE branch_id = @branchId";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add(new MySqlParameter("@agentId", MySqlDbType.String)).Value = data[1];
            command.Parameters.Add(new MySqlParameter("@branchId", MySqlDbType.String)).Value = data[2];

            command.Prepare();

            command.ExecuteNonQuery();

            MessageBox.Show(tempType + " updated");
        }

        /// <summary>
        /// checking if principal exist
        /// </summary>
        /// <param name="branchID"></param>
        /// <returns></returns>
        public bool IsPrincipalExistInBranch(string branchID) {
            string sql = "SELECT count(*) FROM principal WHERE principal.branchID = @id";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.String);
            idParam.Value = branchID;
            command.Parameters.Add(idParam);
            command.Prepare();

            int totalCount = Convert.ToInt32(command.ExecuteScalar());

            if (totalCount > 0) {
                return true;
            } else {
                return false;
            }
        }
        /// <summary>
        /// checking if a vice exist
        /// </summary>
        /// <param name="branchID"></param>
        /// <returns></returns>
        public bool IsVicePrincipalExistInBranch(string branchID) {
            string sql = "SELECT count(*) FROM vice_principal WHERE vice_principal.branchID = @id";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.String);
            idParam.Value = branchID;
            command.Parameters.Add(idParam);
            command.Prepare();

            int totalCount = Convert.ToInt32(command.ExecuteScalar());

            if (totalCount > 0) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// get the principal data of a branch
        /// </summary>
        /// <param name="branch_id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public object[] GetPrincipalOrViceDataFromBranchID(string branch_id, PrincipalOrVice type) {
            object[] result = new object[3];
            string tempType = "";
            if (type == PrincipalOrVice.Principal) {
                tempType = "principal";
            } else {
                tempType = "vice_principal";
            }

            string sql = "SELECT * from " + tempType + " WHERE " + tempType + ".branch_id = '" + branch_id + "'";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result[0] = reader.GetDateTime("date");
                result[1] = reader.GetString("agent_id");
                result[2] = reader.GetString("branch_id");
            }

            reader.Close();
            return result;
        }
        


        #endregion
        
        #region Branch Methods
        /// <summary>
        /// /inserting new branch
        /// </summary>
        /// <param name="data"></param>
        public void InsertNewBranch(object[] data) {
            string sql = "";
            sql = "INSERT INTO branch(branch_id, branch_name, branch_address, branch_city) " + "VALUES (@id, @name, @address, @city)";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.String);
            idParam.Value = data[0];

            MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.String);
            nameParam.Value = data[1];

            MySqlParameter addressParam = new MySqlParameter("@address", MySqlDbType.String);
            addressParam.Value = data[2];

            MySqlParameter cityParam = new MySqlParameter("@city", MySqlDbType.String);
            cityParam.Value = data[3];

            command.Parameters.Add(idParam);
            command.Parameters.Add(nameParam);
            command.Parameters.Add(addressParam);
            command.Parameters.Add(cityParam);

            command.Prepare();

            command.ExecuteNonQuery();

            MessageBox.Show("Branch Added");

            InsertPrincipalOrVice(new object[] { DateTime.Now, "_parent", data[0] }, PrincipalOrVice.Principal);
            InsertPrincipalOrVice(new object[] { DateTime.Now, "_parent", data[0] }, PrincipalOrVice.VicePrincipal);
        }

        /// <summary>
        /// checking if a branch exists
        /// </summary>
        /// <param name="branchID"></param>
        /// <returns></returns>
        public bool IsBranchExist(string branchID) {
            string sql = "SELECT count(*) FROM branch WHERE branch.branch_id = @id";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.String);
            idParam.Value = branchID;
            command.Parameters.Add(idParam);

            command.Prepare();

            int totalCount = Convert.ToInt32(command.ExecuteScalar());

            if (totalCount > 0) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// deleting a branch
        /// </summary>
        /// <param name="id"></param>
        public void DeleteBranch(string id) {
            string sql = "DELETE FROM branch WHERE branch.branch_id = '" + id + "'";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.ExecuteNonQuery();

            MessageBox.Show("Branch Deleted");
        }

        /// <summary>
        /// get branch data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="dataType"></param>
        /// <returns></returns>
        public object[] GetBranchData(string data, TempData dataType) {
            object[] result = new object[4];

            //  List<string> result = new List<string>();
            string sql = "";
            if (dataType == TempData.ID) {
                sql = "SELECT * from branch where branch.branch_id = '" + data + "'";
            } else {
                sql = "SELECT * from branch where branch.branch_name = '" + data + "'";
            }

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                // result.Add(reader.GetString("branch_id"));
                result[0] = reader.GetString("branch_id");
                result[1] = reader.GetString("branch_name");
                result[2] = reader.GetString("branch_address");
                result[3] = reader.GetString("branch_city");
            }

            reader.Close();
            //   MessageBox.Show(result.Length.ToString());
            for (int i = 0; i < result.Length; i++) {
                //   MessageBox.Show(i + " : " + result[i].ToString());
            }
            return result;
        }

        /// <summary>
        /// get branch id from agent id
        /// </summary>
        /// <param name="agentID"></param>
        /// <returns></returns>
        public string GetBranchIDFromAgentID(string agentID) {
            string result = "";
            string sql = "SELECT branch.branch_id FROM branch,agent WHERE agent.agent_id = '" + agentID + "' and agent.branch_id = branch.branch_id";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetString("branch_id");
            }

            reader.Close();
            return result;
        }

        /// <summary>
        /// get branch name from agent id
        /// </summary>
        /// <param name="branchName"></param>
        /// <returns></returns>
        public string GetBranchIDFromName(string branchName) {
            string result = "";
            string sql = "SELECT branch.branch_id FROM branch WHERE branch.branch_name = '" + branchName + "'";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetString("branch_id");
            }

            reader.Close();
            return result;
        }


        public string GetBranchNameFromAgentID(string agentID) {
            string result = "";
            string sql = "SELECT branch.branch_name FROM branch,agent WHERE agent.agent_id = '" + agentID + "' and agent.branch_id = branch.branch_id";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetString("branch_name");
            }

            reader.Close();
            return result;
        }

        /// <summary>
        /// get all branches names
        /// </summary>
        /// <returns></returns>
        public string[] GetBranchNames() {
            List<string> result = new List<string>();

            string sql = "SELECT branch.branch_name from branch";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result.Add(reader.GetString("branch_name"));
            }
            reader.Close();

            return result.ToArray();
        }

        /// <summary>
        /// get branch name from branch id
        /// </summary>
        /// <param name="branchID"></param>
        /// <returns></returns>
        public string GetBranchNameFromID(string branchID) {
            string result = "";
            string sql = "SELECT branch.branch_name FROM branch WHERE branch.branch_id = '" + branchID + "'";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetString("branch_name");
            }

            reader.Close();
            return result;
        }

        /// <summary>
        /// edit branch data
        /// </summary>
        /// <param name="data"></param>
        public void EditBranch(object[] data) {
            //    string sql = "UPDATE branch SET branch_name = '" + data[1] + "' WHERE branch_id = '" + data[0] + "'";
            string sql = "UPDATE branch SET branch_name = @name, branch_address = @address, branch_city = @city WHERE branch_id = @id";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.String);
            idParam.Value = data[0];

            MySqlParameter nameParam = new MySqlParameter("@name", MySqlDbType.String);
            nameParam.Value = data[1];

            MySqlParameter addressParam = new MySqlParameter("@address", MySqlDbType.String);
            addressParam.Value = data[2];

            MySqlParameter cityParam = new MySqlParameter("@city", MySqlDbType.String);
            cityParam.Value = data[3];


            command.Parameters.Add(nameParam);
            command.Parameters.Add(addressParam);
            command.Parameters.Add(cityParam);
            command.Parameters.Add(idParam);

            command.Prepare();

            command.ExecuteNonQuery();

            MessageBox.Show("Branch Edited");
        }


        public void EditBranch(string oldID, string newID, string name) {
            string sql = "UPDATE branch` SET branch_id = '" + oldID + "' , branch_name = '" + name + "' WHERE branch_id = '" + newID + "'";

            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            //  conn.Close();
            MessageBox.Show("Branch Edited");
        }

        /// <summary>
        /// get all branch ids
        /// </summary>
        /// <returns></returns>
        public string[] GetBranchIDs() {
            List<string> result = new List<string>();

            string sql = "SELECT branch.branch_id from branch";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result.Add(reader.GetString("branch_id"));
            }
            reader.Close();
            return result.ToArray(); ;
        }
        #endregion

        #region Closing Methods
        /// <summary>
        /// get the next closing id that will be used
        /// </summary>
        /// <returns></returns>
        public int GetNextClosingID() {
            int result = 0;
            string sql = @"Select closing_id from closing 
                        Where closing_id = (select MAX(closing_id) from closing) 
                        order by closing_id desc limit 1";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetInt32("closing_id");
            }

            reader.Close();
            return result + 1;
        }

        public string GetNextClosingIDInString() {
            string fmt = "00000000##";
            return GetNextClosingID().ToString(fmt);
        }
        /// <summary>
        /// converting the integer into unsiged zerofill
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetClosingIDInString(int id) {
            string fmt = "00000000##";
            return id.ToString(fmt);
        }

        /// <summary>
        /// insert new closing
        /// </summary>
        /// <param name="data"></param>
        public void InsertNewClosing(object[] data) {
            string sql = "";
            sql = @"INSERT INTO closing(date, closing_type, total_nominal) 
                    VALUES (@date, @closingType, @totalNominal)";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlParameter dateParam = new MySqlParameter("@date", MySqlDbType.Date);
            dateParam.Value = data[0];

            MySqlParameter closingTypeParam = new MySqlParameter("@closingType", MySqlDbType.String);
            closingTypeParam.Value = data[1];

            MySqlParameter totalNominalParam = new MySqlParameter("@totalNominal", MySqlDbType.Int64);
            totalNominalParam.Value = data[2];
            
            command.Parameters.Add(dateParam);
            command.Parameters.Add(closingTypeParam);
            command.Parameters.Add(totalNominalParam);
            command.Prepare();

            command.ExecuteNonQuery();

            MessageBox.Show("Closing Added");
        }


        #endregion

        #region Commission Methods
        /// <summary>
        /// insert new commission 
        /// </summary>
        /// <param name="data"></param>
        public void InsertNewCommission(object[] data) {
            string sql = "";
            sql = @"INSERT INTO commission(commission_level, commission_level_value, nominal, agent_id, closing_id, agentclosing_id) 
                    VALUES (@commLevel, @commLevelValue, @nominal, @agentId, @closingId, @agentClosingId)";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlParameter commLevelParam = new MySqlParameter("@commLevel", MySqlDbType.String);
            commLevelParam.Value = data[0];

            MySqlParameter commLevelValueParam = new MySqlParameter("@commLevelValue", MySqlDbType.Double);
            commLevelValueParam.Value = data[1];

            MySqlParameter nominalParam = new MySqlParameter("@nominal", MySqlDbType.Int64);
            nominalParam.Value = data[2];

            MySqlParameter agentIdParam = new MySqlParameter("@agentId", MySqlDbType.String);
            agentIdParam.Value = data[3];

            MySqlParameter closingIdParam = new MySqlParameter("@closingId", MySqlDbType.String);
            closingIdParam.Value = data[4];

            MySqlParameter agentClosingIdParam = new MySqlParameter("@agentClosingId", MySqlDbType.String);
            agentClosingIdParam.Value = data[5];

            command.Parameters.Add(commLevelParam);
            command.Parameters.Add(commLevelValueParam);
            command.Parameters.Add(nominalParam);
            command.Parameters.Add(agentIdParam);
            command.Parameters.Add(closingIdParam);
            command.Parameters.Add(agentClosingIdParam);
            command.Prepare();

            command.ExecuteNonQuery();

    //        MessageBox.Show("Commission Added");
        }

        /// <summary>
        /// get the parent data
        /// </summary>
        /// <returns></returns>
        public string GetEmptyAgent() {
            string result = "";
            string sql = "SELECT agent.agent_id from agent where agent.agent_id = '_parent'";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetString("agent_id");
            }
            reader.Close();
            
            return result;
        }

        
        /// <summary>
        /// get the commission data from agent and closnig
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="closingId"></param>
        /// <returns></returns>
        public Commission[] GetCommissionDataFromAgentAndClosing(string agentId, int closingId) {
            List<Commission> result = new List<Commission>();
            string sql = @"SELECT * FROM commission WHERE closing_id = @closingId AND agentclosing_id = @agentClosingId";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add(new MySqlParameter("@agentClosingId", MySqlDbType.String)).Value = agentId;
            command.Parameters.Add(new MySqlParameter("@closingId", MySqlDbType.Int32)).Value = closingId;
           
            command.Prepare();

            MySqlDataReader reader = command.ExecuteReader();

            object[] tempResult = new object[7];

            while (reader.Read()) {
                tempResult[0] = reader.GetInt32("id");
                tempResult[1] = reader.GetString("commission_level");
                tempResult[2] = reader.GetDouble("commission_level_value");
                tempResult[3] = reader.GetDouble("nominal");
                tempResult[4] = reader.GetString("agent_id");
                tempResult[5] = reader.GetInt32("closing_id");
                tempResult[6] = reader.GetString("agentclosing_id");

                result.Add(new Commission(tempResult));
            }
            reader.Close();
            return result.ToArray();
        }
        #endregion
        
        #region AgentClosing Methods
        /// <summary>
        /// insert new agent closing
        /// </summary>
        /// <param name="data"></param>
        public void InsertNewAgentClosing(object[] data) {
            string sql = @"INSERT INTO agentclosing(unit, nominal, agent_id, closing_id) 
                                           VALUES (@unit, @nominal, @agentId, @closingId)";

            MySqlCommand command = new MySqlCommand(sql, conn);

            MySqlParameter unitParam = new MySqlParameter("@unit", MySqlDbType.Double);
            unitParam.Value = data[0];

            MySqlParameter nominalParam = new MySqlParameter("@nominal", MySqlDbType.Double);
            nominalParam.Value = data[1];

            MySqlParameter agentIdParam = new MySqlParameter("@agentId", MySqlDbType.String);
            agentIdParam.Value = data[2];

            MySqlParameter closingIdParam = new MySqlParameter("@closingId", MySqlDbType.String);
            closingIdParam.Value = data[3];

            command.Parameters.Add(unitParam);
            command.Parameters.Add(nominalParam);
            command.Parameters.Add(agentIdParam);
            command.Parameters.Add(closingIdParam);
            command.Prepare();

            command.ExecuteNonQuery();

          //  MessageBox.Show("Agent Closing Added");
        }
        
        /// <summary>
        /// get the upline id from agent id
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        public string GetUplineIDFromAgentID(string agentId) {
            string result = "";

            string sql = @"SELECT agent.upline_id FROM agent WHERE agent.agent_id = @agentId";

            MySqlCommand command = new MySqlCommand(sql, conn);
            
            command.Parameters.Add(new MySqlParameter("@agentId", MySqlDbType.String)).Value = agentId;

            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetString("upline_id");
            }

            reader.Close();
            return result;
        }

        #endregion
        
        #region reportsssssssss
        /// <summary>
        /// get the array of closing starting at dateFrom until dateTo
        /// </summary>
        /// <param name="dateFrom">starting time</param>
        /// <param name="dateTo">ending time</param>
        /// <returns></returns>
        public ClosingProperty[] GetClosingDataInPeriod(DateTime dateFrom, DateTime dateTo) {
            List<ClosingProperty> result = new List<ClosingProperty>();
            string sql = @"SELECT * FROM closing WHERE date BETWEEN @dateFrom AND @dateTo";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add(new MySqlParameter("@dateFrom", MySqlDbType.Date)).Value = dateFrom;
            command.Parameters.Add(new MySqlParameter("@dateTo", MySqlDbType.Date)).Value = dateTo;

            command.Prepare();

            MySqlDataReader reader = command.ExecuteReader();

            object[] tempResult = new object[4];

            while (reader.Read()) {
                tempResult[0] = reader.GetInt32("closing_id");
                tempResult[1] = reader.GetDateTime("date");
                tempResult[2] = reader.GetString("closing_type");
                tempResult[3] = reader.GetDouble("total_nominal");

                result.Add(new ClosingProperty(tempResult));
            }

            reader.Close();
            return result.ToArray();
        }
        /// <summary>
        /// get all closing ids
        /// </summary>
        /// <returns></returns>
        public string[] GetClosingPropertyIDs() {
            List<int> resultInt = new List<int>();
            List<string> resultString = new List<string>();
            string sql = @"SELECT closing.closing_id FROM closing";

            MySqlCommand command = new MySqlCommand(sql, conn);
            
            MySqlDataReader reader = command.ExecuteReader();

           

            while (reader.Read()) {
                resultInt.Add(reader.GetInt32("closing_id"));
            }

            reader.Close();

            for(int i = 0; i < resultInt.Count; i++) {
                resultString.Add(GetClosingIDInString(resultInt[i]));
            }
            return resultString.ToArray();
        }
        /// <summary>
        /// get closing data from id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ClosingProperty GetClosingDataWithId(int id) {
            ClosingProperty result = new ClosingProperty();
            string sql = @"SELECT * FROM closing WHERE closing_id = @id";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = id;

            command.Prepare();

            MySqlDataReader reader = command.ExecuteReader();

            object[] tempResult = new object[4];

            while (reader.Read()) {
                tempResult[0] = reader.GetInt32("closing_id");
                tempResult[1] = reader.GetDateTime("date");
                tempResult[2] = reader.GetString("closing_type");
                tempResult[3] = reader.GetDouble("total_nominal");

                result = new ClosingProperty(tempResult);
            }

            reader.Close();
            return result;
        }
        /// <summary>
        /// get agent closing data from closing data
        /// </summary>
        /// <param name="closingId"></param>
        /// <returns></returns>
        public AgentClosing[] GetAgentClosingDataFromClosingData(string closingId) {
            List<AgentClosing> result = new List<AgentClosing>();
            string sql = @"SELECT * FROM agentclosing WHERE closing_id = @closingId";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add(new MySqlParameter("@closingId", MySqlDbType.Int32)).Value = closingId;

            command.Prepare();

            MySqlDataReader reader = command.ExecuteReader();

            object[] tempResult = new object[5];

            while (reader.Read()) {
                tempResult[0] = reader.GetInt32("id");
                tempResult[1] = reader.GetDouble("unit");
                tempResult[2] = reader.GetDouble("nominal");
                tempResult[3] = reader.GetString("agent_id");
                tempResult[4] = reader.GetInt32("closing_id");

                result.Add(new AgentClosing(tempResult));
            }
            reader.Close();
            return result.ToArray();
        }

        #endregion
        
        #region settings
        /// <summary>
        /// set the commission level value
        /// </summary>
        /// <param name="level"></param>
        /// <param name="value"></param>
        public void SetCommissionLevelValue(string level, double value) {
            string sql = @"UPDATE commissionlevel SET value = @value WHERE level = @level";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add(new MySqlParameter("@level", MySqlDbType.String)).Value = level;
            command.Parameters.Add(new MySqlParameter("@value", MySqlDbType.Double)).Value = value;

            command.Prepare();

            command.ExecuteNonQuery();


        }
        /// <summary>
        /// get the commission level value
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public double GetCommissionLevelValue(string level) {
            double result = 0;
            string sql = @"SELECT value FROM commissionlevel WHERE level = @level";

            MySqlCommand command = new MySqlCommand(sql, conn);

            command.Parameters.Add(new MySqlParameter("@level", MySqlDbType.String)).Value = level;

            command.Prepare();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                result = reader.GetDouble("value");
            }

            reader.Close();
            return result;
        }
        #endregion


    }
}

public enum TempData {
    ID, Name
}

public enum DataType {
    Agent, Branch
}

public enum PrincipalOrVice {
    Principal, VicePrincipal
}
