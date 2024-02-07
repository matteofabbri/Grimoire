using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Task_Role_Assignment_DataType : INotifyPropertyChanged
	{
		private Award_Task_Role_AssignmentObjectType award_Task_Role_Assignment_ReferenceField;

		private string awad_Task_Role_Assignment_IDField;

		private Award_Task_Role_GroupObjectType role_Group_ReferenceField;

		private Role_UsageObjectType role_Usage_ReferenceField;

		private Security_GroupObjectType role_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_Task_Role_AssignmentObjectType Award_Task_Role_Assignment_Reference
		{
			get
			{
				return this.award_Task_Role_Assignment_ReferenceField;
			}
			set
			{
				this.award_Task_Role_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Role_Assignment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Awad_Task_Role_Assignment_ID
		{
			get
			{
				return this.awad_Task_Role_Assignment_IDField;
			}
			set
			{
				this.awad_Task_Role_Assignment_IDField = value;
				this.RaisePropertyChanged("Awad_Task_Role_Assignment_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Award_Task_Role_GroupObjectType Role_Group_Reference
		{
			get
			{
				return this.role_Group_ReferenceField;
			}
			set
			{
				this.role_Group_ReferenceField = value;
				this.RaisePropertyChanged("Role_Group_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Role_UsageObjectType Role_Usage_Reference
		{
			get
			{
				return this.role_Usage_ReferenceField;
			}
			set
			{
				this.role_Usage_ReferenceField = value;
				this.RaisePropertyChanged("Role_Usage_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Security_GroupObjectType Role_Reference
		{
			get
			{
				return this.role_ReferenceField;
			}
			set
			{
				this.role_ReferenceField = value;
				this.RaisePropertyChanged("Role_Reference");
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
