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
	public class Old_Emergency_ContactType : INotifyPropertyChanged
	{
		private Emergency_ContactObjectType emergency_Contact_ReferenceField;

		private Emergency_Contact_DataType emergency_Contact_DataField;

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
		public Emergency_Contact_DataType Emergency_Contact_Data
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
