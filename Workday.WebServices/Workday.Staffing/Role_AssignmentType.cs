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
	public class Role_AssignmentType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType role_Assignment_ReferenceField;

		private Organization_Role_Assignment_DataType role_Assignment_DataField;

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

		[XmlElement(Order = 1)]
		public Organization_Role_Assignment_DataType Role_Assignment_Data
		{
			get
			{
				return this.role_Assignment_DataField;
			}
			set
			{
				this.role_Assignment_DataField = value;
				this.RaisePropertyChanged("Role_Assignment_Data");
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
