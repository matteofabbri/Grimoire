using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Provisioning_Group_AssignmentType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType provisioning_Group_Assignment_ReferenceField;

		private Provisioning_Group_Assignment_DataType provisioning_Group_Assignment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Provisioning_Group_Assignment_Reference
		{
			get
			{
				return this.provisioning_Group_Assignment_ReferenceField;
			}
			set
			{
				this.provisioning_Group_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Provisioning_Group_Assignment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Provisioning_Group_Assignment_DataType Provisioning_Group_Assignment_Data
		{
			get
			{
				return this.provisioning_Group_Assignment_DataField;
			}
			set
			{
				this.provisioning_Group_Assignment_DataField = value;
				this.RaisePropertyChanged("Provisioning_Group_Assignment_Data");
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
