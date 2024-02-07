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
	public class Citizenship_StatusType : INotifyPropertyChanged
	{
		private Citizenship_StatusObjectType citizenship_Status_ReferenceField;

		private Citizenship_Status_DataType[] citizenship_Status_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Citizenship_StatusObjectType Citizenship_Status_Reference
		{
			get
			{
				return this.citizenship_Status_ReferenceField;
			}
			set
			{
				this.citizenship_Status_ReferenceField = value;
				this.RaisePropertyChanged("Citizenship_Status_Reference");
			}
		}

		[XmlElement("Citizenship_Status_Data", Order = 1)]
		public Citizenship_Status_DataType[] Citizenship_Status_Data
		{
			get
			{
				return this.citizenship_Status_DataField;
			}
			set
			{
				this.citizenship_Status_DataField = value;
				this.RaisePropertyChanged("Citizenship_Status_Data");
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
