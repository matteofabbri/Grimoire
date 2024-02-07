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
	public class Organization_Role_Assignment_DataType : INotifyPropertyChanged
	{
		private Role_AssignerObjectType role_Assigner_ReferenceField;

		private Assignable_RoleObjectType organization_Role_ReferenceField;

		private RoleeObjectType[] role_Assignee_ReferenceField;

		private RoleeObjectType single_Assignment_Manager_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Role_AssignerObjectType Role_Assigner_Reference
		{
			get
			{
				return this.role_Assigner_ReferenceField;
			}
			set
			{
				this.role_Assigner_ReferenceField = value;
				this.RaisePropertyChanged("Role_Assigner_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Assignable_RoleObjectType Organization_Role_Reference
		{
			get
			{
				return this.organization_Role_ReferenceField;
			}
			set
			{
				this.organization_Role_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Role_Reference");
			}
		}

		[XmlElement("Role_Assignee_Reference", Order = 2)]
		public RoleeObjectType[] Role_Assignee_Reference
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

		[XmlElement(Order = 3)]
		public RoleeObjectType Single_Assignment_Manager_Reference
		{
			get
			{
				return this.single_Assignment_Manager_ReferenceField;
			}
			set
			{
				this.single_Assignment_Manager_ReferenceField = value;
				this.RaisePropertyChanged("Single_Assignment_Manager_Reference");
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
