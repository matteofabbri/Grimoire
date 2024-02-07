using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_Organization_Roles_Event_DataType : INotifyPropertyChanged
	{
		private RoleeObjectType role_Assignee_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Role_AssignmentType[] role_AssignmentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RoleeObjectType Role_Assignee_Reference
		{
			get
			{
				return this.role_Assignee_ReferenceField;
			}
			set
			{
				this.role_Assignee_ReferenceField = value;
				this.RaisePropertyChanged("Role_Assignee_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement("Role_Assignment", Order = 2)]
		public Role_AssignmentType[] Role_Assignment
		{
			get
			{
				return this.role_AssignmentField;
			}
			set
			{
				this.role_AssignmentField = value;
				this.RaisePropertyChanged("Role_Assignment");
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
