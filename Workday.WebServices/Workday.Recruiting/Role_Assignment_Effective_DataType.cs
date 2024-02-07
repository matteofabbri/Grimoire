using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Role_Assignment_Effective_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType role_Assignment_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Assignable_RoleObjectType role_ReferenceField;

		private RoleeObjectType[] role_Assignee_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Role_Assignment_Reference
		{
			get
			{
				return this.role_Assignment_ReferenceField;
			}
			set
			{
				this.role_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Role_Assignment_Reference");
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

		[XmlElement(Order = 2)]
		public Assignable_RoleObjectType Role_Reference
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

		[XmlElement("Role_Assignee_Reference", Order = 3)]
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
