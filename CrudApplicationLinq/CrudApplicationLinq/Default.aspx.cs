using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudApplicationLinq
{
    public partial class _Default : Page
    {
        DataClassesDataContext dbContext = new DataClassesDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadUSer();
            }
        }


        void LoadUSer()
        {
            var users = from d in dbContext.UserInfos select d;
            gvUser.DataSource = users;
            gvUser.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int uid = int.Parse(txtUserID.Text);
                string uName = txtUserName.Text;
                string address = ddlAddress.SelectedValue;
                string gender = RadioBtnGender.SelectedValue;
                double age = double.Parse(txtAge.Text);
                DateTime dob = DateTime.Parse(txtDOB.Text);

                var userInfo = new UserInfo
                {
                    UserID = uid,
                    UserName = uName,
                    Address = address,
                    Gender = gender,
                    Age = age,
                    DateOfBirth = dob
                };
                dbContext.UserInfos.InsertOnSubmit(userInfo);
                dbContext.SubmitChanges();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted';)", true);
                LoadUSer();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('" + ex.Message.ToString() + "';)", true);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int uid = int.Parse(txtUserID.Text);
                string uName = txtUserName.Text;
                string address = ddlAddress.SelectedValue;
                string gender = RadioBtnGender.SelectedValue;
                double age = double.Parse(txtAge.Text);
                DateTime dob = DateTime.Parse(txtDOB.Text);

                var userToUpdate = (from d in dbContext.UserInfos where d.UserID == uid select d).FirstOrDefault();
                userToUpdate.UserName = uName;
                userToUpdate.Address = address;
                userToUpdate.Gender = gender;
                userToUpdate.Age = age;
                userToUpdate.DateOfBirth = dob;
                dbContext.SubmitChanges();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully updated';)", true);
                LoadUSer();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('" + ex.Message.ToString() + "';)", true);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int uid = int.Parse(txtUserID.Text);

                var userToDelete = (from d in dbContext.UserInfos where d.UserID == uid select d).FirstOrDefault();
                dbContext.UserInfos.DeleteOnSubmit(userToDelete);
                dbContext.SubmitChanges();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted';)", true);
                LoadUSer();
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('" + ex.Message.ToString() + "';)", true);
            }
        }
    }
}
