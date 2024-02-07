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
	public class Change_Emergency_Contacts_DataType : INotifyPropertyChanged
	{
		private Emergency_ContactObjectType emergency_Contact_ReferenceField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		private Change_Emergency_Contact_DataType emergency_Contact_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Emergency_ContactObjectType Emergency_Contact_Reference
		{
			get
			{
				return this.emergency_Contact_ReferenceField;
			}
			set
			{
				this.emergency_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Emergency_Contact_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Change_Emergency_Contact_DataType Emergency_Contact_Data
		{
			get
			{
				return this.emergency_Contact_DataField;
			}
			set
			{
				this.emergency_Contact_DataField = value;
				this.RaisePropertyChanged("Emergency_Contact_Data");
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
