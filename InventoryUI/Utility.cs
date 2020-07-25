using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;

namespace InventoryUI
{
    static class Utility
    {
        public static string ConString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=InventoryDB;Data Source=DESKTOP-6KDQOM6\SQLEXPRESS;Connect Timeout=10";

        public static string SettingsPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Settings.txt";

        #region Control Switching
        public static System.Drawing.Color colorBtnDefault = System.Drawing.Color.FromArgb(39, 40, 68);
        public static System.Drawing.Color colorBtnActive = System.Drawing.Color.FromArgb(169, 169, 169);
        public static dynamic currentMainControl { get; set; }
        public static dynamic currentTabControl { get; set; }
        private static Button _currentButton;
        public static Button currentButton
        {
            get { return _currentButton; }

            set { _currentButton = value; _currentButton.BackColor = colorBtnActive; }
        }
        public static void DistroyControlOnPanel()
        {
            currentMainControl.Dispose();
            Utility.currentButton.BackColor = Utility.colorBtnDefault;
        }
        public static void DistroyControlOnTab()
        {
            currentTabControl.Dispose();
        }
        public static void CreateControl<ControlType>(ControlType control, dynamic parent)
           where ControlType : //those are generic type constraints on the generic type passed to the function
           UserControl,        //the generic type must be UserControl or inherit from it
           new()               //must have a public parameterless constructor
        {
            control = new ControlType();
            parent.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            control.Location = new System.Drawing.Point(286, 0);
            control.Size = new System.Drawing.Size(1080, 697);
            if (parent.GetType() == typeof(Panel))
                Utility.currentMainControl = control;
            else if (parent.GetType() == typeof(TabPage))
                Utility.currentTabControl = control;
        }
        public static void CreateControl<ControlType>(ControlType control, dynamic parent, string name)
          where ControlType : //those are generic type constraints on the generic type passed to the function
          UserControl,        //the generic type must be UserControl or inherit from it
          new()               //must have a public parameterless constructor
        {
            control = new ControlType();
            parent.Controls.Add(control);
            control.Name = name;
            control.Dock = DockStyle.Fill;
            control.Location = new System.Drawing.Point(286, 0);
            control.Size = new System.Drawing.Size(1080, 697);
            if (parent.GetType() == typeof(Panel))
                Utility.currentMainControl = control;
            else if (parent.GetType() == typeof(TabPage))
                Utility.currentTabControl = control;
        }
        #endregion

        #region Combobox Filling
        /// <summary>
        /// class to add a displayed value and an actual value for the combo boxes
        /// </summary>
        public class ComboboxItem
        {
            /// <value>the displayed value of the combo box item</value>
            public string Text { get; set; }
            /// <value>the actual value of the combo box item</value>
            public int Value { get; set; }

        }

        /// <summary>
        /// Populate the Items of the Child ComboBox with/without its relation with a Parent ComboBox
        /// </summary>
        /// <param name="cmb">Child ComboBox</param>
        /// <param name="storedProcedure">Stored Procedure Name</param>
        public static bool FillCombo(ComboBox cmb, string storedProcedure)
        {
            cmb.Items.Clear();
            cmb.Text = "";
            cmb.SelectedIndex = -1;
            using (SqlConnection con = new SqlConnection(Utility.ConString))
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmb.Items.Add(new Utility.ComboboxItem { Text = (string)reader[1], Value = (int)reader[0] });
                    }

                    cmb.DisplayMember = "Text";
                    cmb.SelectedValue = "Value";


                    reader.Close();
                    if (cmb.Items.Count > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, "PopulateComboBox Function\n" + ex.Message, "Utility Function Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
        }
        /// <summary>
        /// Populate the Items of the Child ComboBox with/without its relation with a Parent ID
        /// </summary>
        /// <param name="cmb">Child ComboBox</param>
        /// <param name="parentID">Parent ID</param>
        /// <param name="storedProcedure">Stored Procedure Name</param>
        public static bool FillCombo(ComboBox cmb, string storedProcedure, string parameterName, int parentID)
        {
            cmb.Items.Clear();
            cmb.Text = "";
            cmb.SelectedIndex = -1;
            using (SqlConnection con = new SqlConnection(Utility.ConString))
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;

                    cmd.Parameters.Add(parameterName, SqlDbType.Int).Value = parentID;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cmb.Items.Add(new Utility.ComboboxItem { Text = (string)reader[1], Value = (int)reader[0] });
                    }

                    cmb.DisplayMember = "Text";
                    cmb.SelectedValue = "Value";


                    reader.Close();
                    if (cmb.Items.Count > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, "PopulateComboBox Function\n" + ex.Message, "Utility Function Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
        }
        public static bool SelectItem(ComboBox cmbbx, int value)
        {
            foreach (Utility.ComboboxItem item in cmbbx.Items)
            {
                if (item.Value == value)
                {
                    cmbbx.SelectedItem = item;
                    return true;
                }
            }
            MessageBox.Show(null, String.Format("SelectItem Function\n an Item with Value = {0} could not be found", value), "Utility Function Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public static bool SelectItem(ComboBox cmbbx, string text)
        {
            foreach (Utility.ComboboxItem item in cmbbx.Items)
            {
                if (item.Text == text)
                {
                    cmbbx.SelectedItem = item;
                    return true;
                }
            }
            MessageBox.Show(null, String.Format("SelectItem Function\n an Item with Text = {0} could not be found", text) , "Utility Function Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        #endregion

        #region Stored Procedure Execution

        /// <summary>
        /// class used to encapsulate all information required by ADO.NET to send procedure parameters to the Database.
        /// </summary>
        public class ProcedureParameter
        {
            /// <value> Name of the parameter as specified in the stored procedure. </value>
            public string parameterName { get; set; }
            /// <value> the database datatype as captured from ADO.NET <c>SqlDbType</c>. </value>
            public SqlDbType DType { get; set; }
            /// <value> the object that holds the procedure parameter value. </value>
            public dynamic SourceObject { get; set; }
            // public Type ObjectType { get; set; }
            public override string ToString()
            {
                return parameterName;
            }
        }
      
        public static DataTable FillDataTable(DataTable dt, string procedureName)
        {
            using (SqlConnection con = new SqlConnection(Utility.ConString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procedureName;
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Rows.Clear();
                    while (reader.Read())
                    {
                        DataRow dr = dt.NewRow();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dr[i] = reader[i];

                        }
                        dt.Rows.Add(dr);
                    }
                    reader.Close();
                    return dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, String.Format("{0} Procedure\n{1}", procedureName, ex.Message), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        public static DataTable FillDataTable(DataTable dt, string procedureName, List<Utility.ProcedureParameter> parameters)
        {
            using (SqlConnection con = new SqlConnection(Utility.ConString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procedureName;
                    dynamic value;
                    foreach (Utility.ProcedureParameter parameter in parameters)
                    {
                        value = getParameterValue(parameter.SourceObject, parameter.DType);
                        if (value != null)
                            cmd.Parameters.Add(parameter.parameterName, parameter.DType).Value = value;
                        else
                        {
                            MessageBox.Show(null, String.Format("{0} Procedure\n getParameterValue() function failed to determine the parameter value, parameter value is null.", procedureName), "Utility Function Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                    }


                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Rows.Clear();
                    while (reader.Read())
                    {
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dr[i] = reader[i];

                        }



                        dt.Rows.Add(dr);
                    }
                    reader.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, String.Format("{0} Procedure\n{1}", procedureName, ex.Message), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        public static List<T> QueryToList<T>(string procedureName)
          where T : new()
        {
            using (SqlConnection con = new SqlConnection(Utility.ConString))
            {
                try
                {
                    List<T> list = new List<T>();
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procedureName;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        T dataObject = new T();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Type type = dataObject.GetType();
                            PropertyInfo prop = type.GetProperty(reader.GetName(i));
                            prop.SetValue(dataObject, reader.GetValue(i), null);
                        }

                        list.Add(dataObject);
                    }
                    reader.Close();

                    return list;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, String.Format("{0} Procedure\n{1}", procedureName, ex.Message), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }
        /// <summary>
        /// executes an Insert Stored Procedure in the database.
        /// </summary>
        /// <param name="procedureName">the name of the Insert Procedure as specified in the database.</param>
        /// <param name="parameters">
        /// <para>a list of <c>Utility.ProcedureParameter</c> that contains one or more parameter instances.</para>
        /// <para>each contains their required information to send the procedure parameters to the database.</para>
        /// </param>
        /// <returns>returns -1 if successful Insetion or a positive value if procedure returns value, 0 otherwise</returns>
        public static int InsertProcedure(String procedureName, List<Utility.ProcedureParameter> parameters)
        {
            using (SqlConnection con = new SqlConnection(Utility.ConString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procedureName;
                    dynamic value;
                    foreach (Utility.ProcedureParameter parameter in parameters)
                    {
                        value = getParameterValue(parameter.SourceObject, parameter.DType);
                        if (value != null)
                            cmd.Parameters.Add(parameter.parameterName, parameter.DType).Value = value;
                        else
                        {
                            MessageBox.Show(null, String.Format("{0} Procedure\n getParameterValue() function failed to determine the parameter value, parameter value is null.", procedureName), "Utility Function Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }

                    int? returnValue = (int?)cmd.ExecuteScalar();
                    if (returnValue == null)
                        returnValue = -1;
                    return (int)returnValue;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, String.Format("{0} Procedure\n{1}", procedureName, ex.Message), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }
        /// <summary>
        /// Extracts the Value from the form object for usage in the <c>InsertProcedure</c> function.
        /// </summary>
        /// <param name="SourceObject"> 
        /// <para>the object that contains the parameter value.</para>
        /// <para>supported object types: <c>TextBox, DBNull.Value, DataGridViewTextBoxCell</c></para>
        /// </param>
        /// <returns><c>dynamic</c> parameter value or <c>null</c> if object type is unsupported</returns>
        private static dynamic getParameterValue(dynamic SourceObject, SqlDbType Dtype)
        {
            try
            {
                dynamic value = null;
                if (SourceObject.GetType() == typeof(int))      //must catch basic types first (int,double,string,...)
                    value = SourceObject;
                else if (SourceObject.GetType() == typeof(double))
                {
                    value = SourceObject;
                }
                else if (SourceObject.GetType() == typeof(string))
                {
                    value = SourceObject;
                }
                else if (SourceObject.GetType() == typeof(byte[]))
                {
                    value = SourceObject;
                }
                else if (SourceObject.GetType() == typeof(TextBox))
                    if (String.IsNullOrWhiteSpace(SourceObject.Text))
                        value = DBNull.Value;
                    else
                        value = SourceObject.Text;
                else if (SourceObject.GetType() == typeof(ComboBox))
                    if (SourceObject.SelectedItem == null || SourceObject.SelectedItem.Value == -1)
                        value = DBNull.Value;
                    else
                        value = SourceObject.SelectedItem.Value;
                else if (SourceObject.GetType() == typeof(DataGridViewTextBoxCell)) //^^ from DataGridViewCell to DataGridViewCell
                    if (String.IsNullOrWhiteSpace(SourceObject.Value))
                        value = DBNull.Value;
                    else
                        value = SourceObject.Value;
                else if (SourceObject.GetType() == typeof(DateTimePicker))
                    value = SourceObject.Value;
                else if (SourceObject.GetType() == typeof(CheckBox))
                    value = SourceObject.Checked;
                else if (SourceObject == DBNull.Value)
                    value = SourceObject;

                if (value is DBNull)      //do not enter the DBnull.Value into the convert section
                    return value;
                else if ((Dtype == SqlDbType.Money || Dtype == SqlDbType.SmallMoney) && (value.GetType() == typeof(string) || value.GetType() == typeof(int)))
                    value = Convert.ToDecimal(value);
                else if ((Dtype == SqlDbType.TinyInt) && (value.GetType() == typeof(string) || value.GetType() == typeof(int)))
                    value = Convert.ToByte(value);
                else if ((Dtype == SqlDbType.Int) && value.GetType() == typeof(string))
                    value = Convert.ToInt32(value);

                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, String.Format("getParameterValue Function\n{0}", ex.Message), "Utility Function Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        #endregion

        #region Control Cleanup

        /// <summary>
        /// <para>clears all data within a panel child objects</para>
        /// <para>supported child objects and clear behaviors:- </para>
        /// <para><c>TextBox</c>: Clears Text</para>
        /// <para>c>CheckBox</c>: Uncheck</para>
        /// <para><c>DateTimePicker</c>sets value to <c>DateTime.Now</c></para>
        /// </summary>
        /// <param name="pnl"><c>panel</c> object to be searched for supported object to be cleared. </param>
        public static void clearPanel(Panel pnl)
        {
            foreach (Control c in EnumerateControlsRecursive(pnl))
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
                if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                    ((DataGridView)c).Rows.Clear();
                }
                if (c is PictureBox)
                {
                    ((PictureBox)c).Image = Properties.Resources.shopping_cart_6;
                }
            }
        }
        /// <summary>
        /// Recursive IEnum Function that Depth-first search a control
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="root"></param>
        /// <returns></returns>
        private static IEnumerable<Control> EnumerateControlsRecursive(Control parent)
        {
            foreach (Control child in parent.Controls)  //for each control in parent
            {
                yield return child;   //return a child to the call location and come back here after one iteration of the call's loop is done
                foreach (Control descendant in EnumerateControlsRecursive(child))   //the code returns and a recursive call on the child is used to make that child a parent of other controls in the search
                    //if that child control does have decendants then after it's recursion ends do the same for the new decendant and so on...
                    yield return descendant;
            }
        }

        /// <summary>clears all data within a DataTable in order to clear it's connected DataGridView</summary>
        /// <param name="dt"><c>DataTable</c> DataTable object to be cleared. </param>
        public static void ClearDataTable(DataTable dt)
        {
            dt.Rows.Clear();
        }
        #endregion

        #region Validation

        public class ValidationItem
        {
            public dynamic control { get; set; }

            public Label lblError { get; set; }
        }
        //public class ValidationItem<ControlType>
        //    where ControlType : Control
        //{
        //    public ControlType control { get; set; }

        //    public Label lblError { get; set; }
        //}

        public static bool ValidateControlList(List<Utility.ValidationItem> validationList)
        {
            bool IsSafe = true;
            foreach (Utility.ValidationItem item in validationList)
            {
                if (IsEmptyControl(item.control))
                    item.lblError.Visible = true;
                else
                    item.lblError.Visible = false;

            }
            foreach (Utility.ValidationItem item in validationList)
            {
                if (item.lblError.Visible)
                {
                    IsSafe = false;
                    break;
                }
            }

            return IsSafe;
        }
        static private bool IsEmptyControl(dynamic control)
        {
            if (String.IsNullOrWhiteSpace(control.Text))
                return true;
            else
                return false;
        }
        #endregion

        public static double convertPercent(double x)
        {
            return (double)(x / 100);
        }

    }
}
