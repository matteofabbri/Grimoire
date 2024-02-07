using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_Roles_Sub_Process_DataType : INotifyPropertyChanged
	{
		private bool remove_All_Role_Assignments_for_Event_Target_AssigneeField;

		private bool remove_All_Role_Assignments_for_Event_Target_AssigneeFieldSpecified;

		private Assign_Roles_Role_Assignment_DataType[] assign_Roles_Role_Assignment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Remove_All_Role_Assignments_for_Event_Target_Assignee
		{
			get
			{
				return this.remove_All_Role_Assignments_for_Event_Target_AssigneeField;
			}
			set
			{
				this.remove_All_Role_Assignments_for_Event_Target_AssigneeField = value;
				this.RaisePropertyChanged("Remove_All_Role_Assignments_for_Event_Target_Assignee");
			}
		}

		[XmlIgnore]
		public bool Remove_All_Role_Assignments_for_Event_Target_AssigneeSpecified
		{
			get
			{
				return this.remove_All_Role_Assignments_for_Event_Target_AssigneeFieldSpecified;
			}
			set
			{
				this.remove_All_Role_Assignments_for_Event_Target_AssigneeFieldSpecified = value;
				this.RaisePropertyChanged("Remove_All_Role_Assignments_for_Event_Target_AssigneeSpecified");
			}
		}

		[XmlElement("Assign_Roles_Role_Assignment_Data", Order = 1)]
		public Assign_Roles_Role_Assignment_DataType[] Assign_Roles_Role_Assignment_Data
		{
			get
			{
				return this.assign_Roles_Role_Assignment_DataField;
			}
			set
			{
				this.assign_Roles_Role_Assignment_DataField = value;
				this.RaisePropertyChanged("Assign_Roles_Role_Assignment_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
