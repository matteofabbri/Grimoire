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
	public class Military_Service_DataType : INotifyPropertyChanged
	{
		private Military_Status_ReferenceType military_Status_ReferenceField;

		private DateTime military_Discharge_DateField;

		private bool military_Discharge_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Military_Status_ReferenceType Military_Status_Reference
		{
			get
			{
				return this.military_Status_ReferenceField;
			}
			set
			{
				this.military_Status_ReferenceField = value;
				this.RaisePropertyChanged("Military_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Military_Discharge_Date
		{
			get
			{
				return this.military_Discharge_DateField;
			}
			set
			{
				this.military_Discharge_DateField = value;
				this.RaisePropertyChanged("Military_Discharge_Date");
			}
		}

		[XmlIgnore]
		public bool Military_Discharge_DateSpecified
		{
			get
			{
				return this.military_Discharge_DateFieldSpecified;
			}
			set
			{
				this.military_Discharge_DateFieldSpecified = value;
				this.RaisePropertyChanged("Military_Discharge_DateSpecified");
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
